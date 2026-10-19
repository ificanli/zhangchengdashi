using System.Reflection;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text.Json;

// Loads the independently compiled, complete GFRunning candidate assembly.
// No GameFramework boundary adapter is referenced by this executable.
var taskRoot = @"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20";
var projectRoot = Path.Combine(taskRoot, "outputs", "OccupyCityRecovered");
var validationRoot = Path.Combine(taskRoot, "work", "stage42-independent-review", "validation");
var assemblyPath = Path.Combine(validationRoot, "unity-csc", "GFRunning.Stage42.dll");
var rsp = Path.Combine(validationRoot, "unity-csc", "GFRunning.Stage42.rsp");
var references = File.ReadAllLines(rsp).Where(x => x.StartsWith("-r:") || x.StartsWith("/r:"))
    .Select(x => x[3..].Trim('"')).Select(x => Path.IsPathRooted(x) ? x : Path.Combine(projectRoot, x))
    .GroupBy(x => Path.GetFileNameWithoutExtension(x), StringComparer.OrdinalIgnoreCase).ToDictionary(x => x.Key, x => x.First(), StringComparer.OrdinalIgnoreCase);
AssemblyLoadContext.Default.Resolving += (_, name) => references.TryGetValue(name.Name!, out var path) && File.Exists(path) ? AssemblyLoadContext.Default.LoadFromAssemblyPath(path) : null;
var asm = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
var utility = asm.GetType("GameFramework.Utility+Text", true)!;
var genericKey = utility.GetMethods(BindingFlags.Public | BindingFlags.Static).Single(x => x.Name == "GetFullName" && x.IsGenericMethodDefinition).MakeGenericMethod(typeof(object));
var key = genericKey.Invoke(null, new object[] { "blocked" });
if (key is not null) throw new Exception("Expected actual current production GetFullName<object> to return null");
var managerType = asm.GetType("GameFramework.Fsm.FsmManager", true)!;
var manager = Activator.CreateInstance(managerType)!;
var create = managerType.GetMethods().Single(x => x.Name == "CreateFsm" && x.GetParameters().Length == 3).MakeGenericMethod(typeof(object));
var stateType = asm.GetType("GameFramework.Fsm.FsmState`1", true)!.MakeGenericType(typeof(object));
string? exceptionName = null; string? parameter = null;
try { create.Invoke(manager, new object[] { "blocked", new object(), Array.CreateInstance(stateType, 0) }); }
catch (TargetInvocationException e) when (e.InnerException is ArgumentNullException nullKey) { exceptionName = nullKey.GetType().FullName; parameter = nullKey.ParamName; }
if (exceptionName is null || parameter != "key") throw new Exception("Expected production manager to fail at null dictionary key before constructor state validation");
var source = Path.Combine(projectRoot, "Assets", "Scripts", "GFRunning", "GameFramework", "Utility.cs");
var result = new { passed = true, fullProductionAssembly = assemblyPath, fullProductionAssemblySha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(assemblyPath))),
    utilitySource = source, utilitySourceSha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(source))),
    actualCurrentUtilityResult = key, actualCreateFsmException = exceptionName, actualExceptionParamName = parameter,
    noBoundaryAdapters = true, unityStarted = false, runtimeAcceptance = false,
    conclusion = "Current production Utility.Text.GetFullName remains empty. Actual full GFRunning candidate cannot create FSMs until this out-of-scope dependency is restored." };
File.WriteAllText(Path.Combine(validationRoot, "unity-csc", "production-dependency-negative.json"), JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
