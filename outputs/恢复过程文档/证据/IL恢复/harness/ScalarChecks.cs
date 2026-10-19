using System.Reflection;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Builder;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.Builder;
using Cpp2IL.Core;
using Cpp2IL.Core.Graphs;
using Cpp2IL.Core.ISIL;
using Cpp2IL.Core.Model.Contexts;
using Cpp2IL.Core.Utils.AsmResolver;
using MAttrs = AsmResolver.PE.DotNet.Metadata.Tables.MethodAttributes;
using TAttrs = AsmResolver.PE.DotNet.Metadata.Tables.TypeAttributes;

static class ScalarChecks
{
    public static void Run(ApplicationAnalysisContext app, string output)
    {
        var module = new ModuleDefinition("Cpp2ILScalarRegression.dll", new AssemblyReference("mscorlib", new Version(4,0,0,0)));
        var assembly = new AssemblyDefinition("Cpp2ILScalarRegression", new Version(1,0,0,0));
        assembly.Modules.Add(module);
        var type = new TypeDefinition("", "ScalarConversions", TAttrs.Public | TAttrs.Class, module.CorLibTypeFactory.Object.Type);
        module.TopLevelTypes.Add(type);
        var types = app.SystemTypes;
        var specs = new (string Name, OpCode Op, TypeAnalysisContext From, TypeAnalysisContext To)[] {
            ("F32I32", OpCode.Convert, types.SystemSingleType, types.SystemInt32Type),
            ("F32I64", OpCode.Convert, types.SystemSingleType, types.SystemInt64Type),
            ("F64I32", OpCode.Convert, types.SystemDoubleType, types.SystemInt32Type),
            ("F64I64", OpCode.Convert, types.SystemDoubleType, types.SystemInt64Type),
            ("I32F32", OpCode.Convert, types.SystemInt32Type, types.SystemSingleType),
            ("I64F64", OpCode.Convert, types.SystemInt64Type, types.SystemDoubleType),
            ("Bits32F32", OpCode.Bitcast, types.SystemInt32Type, types.SystemSingleType),
            ("Bits64F64", OpCode.Bitcast, types.SystemInt64Type, types.SystemDoubleType)
        };
        foreach (var spec in specs)
        {
            var context = new InjectedMethodAnalysisContext(types.SystemObjectType, spec.Name, spec.To,
                System.Reflection.MethodAttributes.Public | System.Reflection.MethodAttributes.Static, [spec.From], ["input"]);
            var input = new LocalVariable("input", new Register(null, "arg0"), spec.From);
            var result = new LocalVariable("result", new Register(null, "result"), spec.To);
            context.Locals = [input, result];
            context.ParameterLocals = [input];
            context.ControlFlowGraph = new ISILControlFlowGraph([
                new Instruction(0, spec.Op, result, input, spec.From, spec.To),
                new Instruction(1, OpCode.Return, result)]);
            var method = new MethodDefinition(spec.Name, MAttrs.Public | MAttrs.Static,
                MethodSignature.CreateStatic(module.DefaultImporter.ImportTypeSignature(spec.To.ToTypeSignature()),
                    [module.DefaultImporter.ImportTypeSignature(spec.From.ToTypeSignature())]));
            method.ParameterDefinitions.Add(new ParameterDefinition(1, "input", (AsmResolver.PE.DotNet.Metadata.Tables.ParameterAttributes)0));
            type.Methods.Add(method);
            // Exercises warnings too: they must not create an unterminated IL block.
            context.AnalysisWarnings.Add("scalar regression diagnostic");
            IlGenerator.GenerateIl(context, method);
        }
        var path = Path.Combine(output, "Cpp2ILScalarRegression.dll");
        new ManagedPEFileBuilder().CreateFile(module.ToPEImage(new ManagedPEImageBuilder())).Write(path);
        var loaded = Assembly.LoadFile(path).GetType("ScalarConversions")!;
        var checks = new List<string>();
        void Check(string name, object input, object expected)
        {
            object actual = loaded.GetMethod(name)!.Invoke(null, [input])!;
            if (!actual.Equals(expected)) throw new Exception($"Scalar regression {name}({input}): expected={expected}, actual={actual}");
            checks.Add($"PASS {name}({input}) = {actual}");
        }
        foreach (var name in new[] { "F32I32", "F64I32" })
        {
            object Input(double value) => name.StartsWith("F32") ? (object)(float)value : value;
            foreach (var (input, expected) in new (double,int)[] { (double.NaN,0),(double.PositiveInfinity,int.MaxValue),(double.NegativeInfinity,int.MinValue),(2147483648d,int.MaxValue),(-2147483648d,int.MinValue),(1.9,1),(-1.9,-1),(0,0) })
                Check(name, Input(input), expected);
        }
        foreach (var name in new[] { "F32I64", "F64I64" })
        {
            object Input(double value) => name.StartsWith("F32") ? (object)(float)value : value;
            foreach (var (input, expected) in new (double,long)[] { (double.NaN,0),(double.PositiveInfinity,long.MaxValue),(double.NegativeInfinity,long.MinValue),(9223372036854775808d,long.MaxValue),(-9223372036854775808d,long.MinValue),(1.9,1),(-1.9,-1),(0,0) })
                Check(name, Input(input), expected);
        }
        foreach (var value in new[] { int.MinValue, int.MaxValue, -1, 0, 16777219 }) Check("I32F32", value, (float)value);
        foreach (var value in new[] { long.MinValue, long.MaxValue, -1L, 0L, 9007199254740993L }) Check("I64F64", value, (double)value);
        foreach (var value in new[] { 0, int.MinValue, 0x3F000000, 0x7F800000, 0x7FC00000 }) Check("Bits32F32", value, BitConverter.Int32BitsToSingle(value));
        foreach (var value in new[] { 0L, long.MinValue, 0x3FE0000000000000L, 0x7FF0000000000000L, 0x7FF8000000000000L }) Check("Bits64F64", value, BitConverter.Int64BitsToDouble(value));
        File.WriteAllLines(Path.Combine(output, "scalar-regression.log"), checks.Append($"SCALAR_REGRESSION tested={checks.Count} passed={checks.Count} failed=0"));
        Console.WriteLine($"SCALAR_REGRESSION tested={checks.Count} passed={checks.Count} failed=0");
    }
}
