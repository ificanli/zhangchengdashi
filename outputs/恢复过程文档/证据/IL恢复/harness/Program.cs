using System.Collections.Concurrent;
using System.Text.Json;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.PE.DotNet.Cil;
using AssetRipper.Primitives;
using AssetRipper.CIL;
using Cpp2IL.Core;
using Cpp2IL.Core.Logging;
using Cpp2IL.Core.Model.Contexts;
using Cpp2IL.Core.OutputFormats;

if (args.Length != 3) throw new ArgumentException("binary metadata output-dir");
var output = Path.GetFullPath(args[2]);
Directory.CreateDirectory(output);
Logger.InfoLog += (message, source) => Console.Write($"[INFO] [{source}] {message}");
Logger.WarningLog += (message, source) => Console.Write($"[WARN] [{source}] {message}");
Logger.ErrorLog += (message, source) => Console.Write($"[ERROR] [{source}] {message}");
new Cpp2IlCorePlugin().OnLoad();
Cpp2IlApi.RuntimeOptions = new Cpp2IlRuntimeArgs { LowMemoryMode = true };
Cpp2IlApi.InitializeLibCpp2Il(Path.GetFullPath(args[0]), Path.GetFullPath(args[1]), UnityVersion.Parse("2022.3.62f3"));
var context = Cpp2IlApi.CurrentAppContext;
var format = new SelectiveRecovery(output);
format.DoOutput(context, output);
ScalarChecks.Run(context, output);
File.WriteAllText(Path.Combine(output, "method-results.json"), JsonSerializer.Serialize(format.Results.OrderBy(x => x.Method), new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine("PROBE COMPLETE: only selected methods analyzed; every other method in emitted Assembly-CSharp is an explicit throw and is NOT recovered.");

record ProbeResult(string Method, string Address, int RawBytes, int IsilCount, int CilCount, string Status, string[] Warnings, string? Error);

sealed class SelectiveRecovery(string output) : AsmResolverDllOutputFormat
{
    readonly HashSet<string> targets = ["HexManager::HexDistance", "GameModule.SynergyEffectManager::InternalCalculateDamage"];
    public ConcurrentBag<ProbeResult> Results { get; } = [];
    public override string OutputFormatId => "selective_recovery_probe";
    public override string OutputFormatName => "Two method IL recovery probe (all other methods throw)";
    public override List<AssemblyDefinition> BuildAssemblies(ApplicationAnalysisContext context)
    {
        _ = context.GetOrCreateKeyFunctionAddresses();
        IlGenerator.InjectHelpersType(context);
        return base.BuildAssemblies(context).Where(a => a.Name == "Assembly-CSharp").ToList();
    }
    protected override void FillMethodBody(MethodDefinition method, MethodAnalysisContext ctx)
    {
        if (!method.IsManagedMethodWithBody()) return;
        method.CilMethodBody = new CilMethodBody();
        method.CilMethodBody.Instructions.Add(CilOpCodes.Ldnull);
        method.CilMethodBody.Instructions.Add(CilOpCodes.Throw);
        if (!targets.Contains(ctx.FullName)) return;
        var prefix = Path.Combine(output, ctx.FullName.Replace("::", "."));
        Console.WriteLine($"PROBE START {ctx.FullName} 0x{ctx.UnderlyingPointer:X}");
        try
        {
            ctx.EnsureRawBytes();
            File.WriteAllText(prefix + ".native.txt", ctx.AppContext.InstructionSet.PrintAssembly(ctx));
            ctx.Analyze();
            File.WriteAllLines(prefix + ".isil.txt", ctx.ConvertedIsil!.Select(i => i.ToString()));
            File.WriteAllText(prefix + ".cfg.txt", string.Join(Environment.NewLine, ctx.ControlFlowGraph!.Blocks));
            if (ctx.ConvertedIsil.Count == 0) throw new InvalidOperationException("No ISIL generated");
            IlGenerator.GenerateIl(ctx, method);
            File.WriteAllLines(prefix + ".cil.txt", method.CilMethodBody!.Instructions.Select(i => i.ToString()));
            Results.Add(new(ctx.FullName, $"0x{ctx.UnderlyingPointer:X}", ctx.RawBytes.Length, ctx.ConvertedIsil.Count, method.CilMethodBody.Instructions.Count, "IL-emitted-not-yet-validated", ctx.AnalysisWarnings.ToArray(), null));
            Console.WriteLine($"PROBE IL EMITTED {ctx.FullName} {method.CilMethodBody.Instructions.Count} instructions");
        }
        catch (Exception e)
        {
            File.WriteAllText(prefix + ".error.txt", e.ToString());
            if (ctx.ConvertedIsil != null) File.WriteAllLines(prefix + ".partial-isil.txt", ctx.ConvertedIsil.Select(i => i.ToString()));
            Results.Add(new(ctx.FullName, $"0x{ctx.UnderlyingPointer:X}", ctx.RawBytes.Length, ctx.ConvertedIsil?.Count ?? 0, 0, "failed", ctx.AnalysisWarnings.ToArray(), e.ToString()));
            Console.WriteLine($"PROBE FAILED {ctx.FullName}: {e}");
            method.CilMethodBody = new CilMethodBody();
            method.CilMethodBody.Instructions.Add(CilOpCodes.Ldnull);
            method.CilMethodBody.Instructions.Add(CilOpCodes.Throw);
        }
    }
}
