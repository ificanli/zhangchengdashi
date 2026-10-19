using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text.Json;
using Mono.Cecil;
using Mono.Cecil.Cil;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage46-account-mode");var dll=Path.Combine(work,"GFRunning.check.dll");var passed=new List<string>();
void Check(bool ok,string name){if(!ok)throw new Exception(name);passed.Add(name);}
AssemblyLoadContext.Default.Resolving+=(context,name)=>
{
 var candidates=new[]{Path.Combine(root,"outputs/OccupyCityRecovered/Library/ScriptAssemblies",name.Name+".dll"),Path.Combine("C:/Program Files/Unity/Hub/Editor/2022.3.62f3c1/Editor/Data/Managed/UnityEngine",name.Name+".dll")};
 var path=candidates.FirstOrDefault(File.Exists);return path==null?null:context.LoadFromAssemblyPath(path);
};
var assembly=AssemblyLoadContext.Default.LoadFromAssemblyPath(dll);var type=assembly.GetType("GameFramework.Login.ILoginProcedure",true)!;var property=type.GetProperty("accountType")!;
var mode=type.GetField("_00ACI_008A_00B9b_0098",BindingFlags.Static|BindingFlags.NonPublic)!;
var invalid=type.GetField("C_009C_0090_00BB_00ACi",BindingFlags.Static|BindingFlags.NonPublic)!;
Check(Convert.ToInt32(property.GetValue(null))==10,"Actual compiled GF first getter runs original None=10 cctor");
Check(Convert.ToInt32(mode.GetValue(null))==10,"Actual existing private field receives original default");
Check(!(bool)invalid.GetValue(null)!,"Original cctor leaves adjacent bool at CLR default");
var cases=new[]{int.MinValue,-1,0,1,2,10,11,12,13,12345,int.MaxValue};
foreach(var value in cases)
{
 bool sentinel=(value&1)!=0;invalid.SetValue(null,sentinel);
 property.SetValue(null,Enum.ToObject(property.PropertyType,value));
 Check(Convert.ToInt32(property.GetValue(null))==value,"Actual getter/setter preserves raw enum int "+value);
 Check(Convert.ToInt32(mode.GetValue(null))==value,"Actual setter uses original explicit field "+value);
 Check((bool)invalid.GetValue(null)! == sentinel,"Adjacent login-invalid flag unchanged "+value);
 RuntimeHelpers.RunClassConstructor(type.TypeHandle);
 Check(Convert.ToInt32(property.GetValue(null))==value,"Original class initialization does not repeat "+value);
}
var fields=type.GetFields(BindingFlags.Static|BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly);
Check(fields.Length==4&&!fields.Any(f=>f.Name.Contains("BackingField")),"No new auto backing or state fields introduced");
using var image=AssemblyDefinition.ReadAssembly(dll);var target=image.MainModule.Types.Single(t=>t.FullName==type.FullName);
foreach(var name in new[]{"get_accountType","set_accountType",".cctor"})
{
 var method=target.Methods.Single(m=>m.Name==name);var writes=method.Body.Instructions.Where(i=>i.OpCode.Code==Code.Stsfld).ToArray();
 Check(writes.Length==(name=="get_accountType"?0:1)&&writes.All(i=>((FieldReference)i.Operand).Name==mode.Name),"Actual IL writes only original mode field: "+name);
 Check(!method.Body.Instructions.Any(i=>i.OpCode.Code is Code.Call or Code.Callvirt or Code.Newobj),"Actual IL makes no SDK Unity or login calls: "+name);
}
var cctor=target.Methods.Single(m=>m.Name==".cctor");
Check(cctor.Body.Instructions.Any(i=>(i.OpCode.Code==Code.Ldc_I4_S&&Convert.ToInt32(i.Operand)==10)||(i.OpCode.Code==Code.Ldc_I4&&Convert.ToInt32(i.Operand)==10)),"Actual cctor IL contains native constant ten");
Console.WriteLine(JsonSerializer.Serialize(new{passed=passed.Count,assembly=dll,mode="Actual Unity-compiled GF DLL reflected under CLR; no Unity engine methods invoked",tests=passed},new JsonSerializerOptions{WriteIndented=true}));
