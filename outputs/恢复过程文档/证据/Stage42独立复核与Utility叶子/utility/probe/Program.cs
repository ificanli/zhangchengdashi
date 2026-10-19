using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Loader;
using System.Security.Cryptography;
using System.Text.Json;

string mode = args.Length > 0 ? args[0] : "candidate";
var root = @"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20";
var own = Path.Combine(root, "work", "stage42-independent-review", "utility");
var project = Path.Combine(root, "outputs", "OccupyCityRecovered");
var compile = Path.Combine(own, "compile", mode);
var assemblyPath = Path.Combine(compile, "GFRunning.Stage42.dll");
var references = File.ReadAllLines(Path.Combine(compile, "GFRunning.Stage42.rsp")).Where(x => x.StartsWith("-r:") || x.StartsWith("/r:"))
    .Select(x => x[3..].Trim('"')).Select(x => Path.IsPathRooted(x) ? x : Path.Combine(project, x))
    .GroupBy(x => Path.GetFileNameWithoutExtension(x), StringComparer.OrdinalIgnoreCase).ToDictionary(x => x.Key, x => x.First(), StringComparer.OrdinalIgnoreCase);
AssemblyLoadContext.Default.Resolving += (_, name) => references.TryGetValue(name.Name, out var path) ? AssemblyLoadContext.Default.LoadFromAssemblyPath(path) : null;
var asm = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
int checks = 0;
void Check(bool condition, string message) { checks++; if (!condition) throw new Exception(message); }
object Call(object owner, string name, params object[] values) => owner.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Single(m => m.Name == name && !m.IsGenericMethod && m.GetParameters().Length == values.Length).Invoke(owner, values);
object Field(object owner, string name) => owner.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(owner);
var utility = asm.GetType("GameFramework.Utility+Text", true);
var generic = utility.GetMethods().Single(m => m.Name == "GetFullName" && m.IsGenericMethod).MakeGenericMethod(typeof(object));
Check((string)generic.Invoke(null, new object[] { "live" }) == "System.Object.live", "Real generic Utility key failed");
var typeKey = utility.GetMethods().Single(m => m.Name == "GetFullName" && !m.IsGenericMethod);
Check((string)typeKey.Invoke(null, new object[] { typeof(object), "" }) == "System.Object", "Real typed Utility key failed");

var pmType = asm.GetType("GameFramework.Procedure.ProcedureManager", true);
var procedureBase = asm.GetType("GameFramework.Procedure.ProcedureBase", true);
var dynamicAssembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("Stage42IndependentProbeStates"), AssemblyBuilderAccess.Run);
var dynamicModule = dynamicAssembly.DefineDynamicModule("States");
Type State(string name) { var t = dynamicModule.DefineType(name, TypeAttributes.Public | TypeAttributes.Sealed, procedureBase); t.DefineDefaultConstructor(MethodAttributes.Public); return t.CreateType(); }
var aType = State("Stage42ProbeProcedureA");
var bType = State("Stage42ProbeProcedureB");
var a = Activator.CreateInstance(aType);
var b = Activator.CreateInstance(bType);
var pm = Activator.CreateInstance(pmType);
Call(pm, "Initialize", new object[] { Array.Empty<object>() });
var ready = asm.GetType("GameFramework.GameFrameModule", true).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Single(f => f.FieldType == typeof(bool));
Check((bool)ready.GetValue(pm), "Procedure Initialize own ready missing");
var states = Array.CreateInstance(procedureBase, 2); states.SetValue(a, 0); states.SetValue(b, 1);
Call(pm, "Register", new object[] { states });
var manager = Field(pm, "m_FsmManager");
var fsm = Field(pm, "m_ProcedureFsm");
Check(manager != null && fsm != null, "Actual GameFrameEntry module acquisition or generic CreateFsm failed");
Check((int)manager.GetType().GetProperty("Count").GetValue(manager) == 1, "Actual manager count failed");
Check(ReferenceEquals(pm, fsm.GetType().GetProperty("Owner").GetValue(fsm)), "Actual owner identity lost");
Check((string)fsm.GetType().GetProperty("FullName").GetValue(fsm) == "GameFramework.Procedure.IProcedureManager", "Actual FSM key is not original owner key");
Check((int)fsm.GetType().GetProperty("FsmStateCount").GetValue(fsm) == 2, "Actual states not constructed");
Call(pm, "StartProcedure", aType);
Check(ReferenceEquals(a, pmType.GetProperty("CurrentProcedure").GetValue(pm)), "Actual StartProcedure did not enter A");
Call(manager, "Update", .125f, .5f);
Check((float)pmType.GetProperty("CurrentProcedureTime").GetValue(pm) == .125f, "Actual manager/FSM update did not advance scaled time");
var bridge = procedureBase.BaseType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic).Single(m => m.Name == "ChangeState" && !m.IsGenericMethod);
bridge.Invoke(a, new object[] { fsm, bType, Array.Empty<object>() });
Check(ReferenceEquals(b, pmType.GetProperty("CurrentProcedure").GetValue(pm)), "Actual state bridge did not enter B");
Check((float)pmType.GetProperty("CurrentProcedureTime").GetValue(pm) == 0f, "Actual ChangeState did not reset time");
try { Call(pm, "StartProcedure", aType); throw new Exception("Expected already-running exception"); }
catch (TargetInvocationException e) when (e.InnerException.GetType().FullName == "GameFramework.GameFrameworkException") { checks++; }
Call(pm, "Shutdown");
Check((int)manager.GetType().GetProperty("Count").GetValue(manager) == 0, "Actual Shutdown failed to destroy/remove FSM");
Check(Field(pm, "m_FsmManager") == null && Field(pm, "m_ProcedureFsm") == null, "Actual Shutdown did not clear fields");
Check(!(bool)ready.GetValue(pm), "Actual Shutdown did not clear own ready");
var result = new { mode, passed = true, checks, fullProductionAssembly = assemblyPath, assemblySha256 = Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(assemblyPath))).ToLowerInvariant(), noBoundaryAdapters = true,
    testStates = "Two dynamically defined subclasses inherit actual ProcedureBase/FsmState bodies; no FSM or Utility logic substituted",
    actualChain = "Real Utility -> actual GameFrameEntry.GetModule<FsmManager> -> ProcedureManager.Register -> CreateFsm<IProcedureManager> -> original constructors -> StartProcedure/Update/ChangeState/Shutdown",
    UnityStarted = false, visibleUIAccepted = false, coreGameplayAccepted = false };
File.WriteAllText(Path.Combine(compile, "full-GF-probe.json"), JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
