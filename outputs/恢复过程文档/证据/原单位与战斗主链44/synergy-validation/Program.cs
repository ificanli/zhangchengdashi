using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using GameModule;
using System.Runtime.CompilerServices;
int checks=0,failures=0;
void Check(string n,bool ok,string info=""){checks++;if(!ok){failures++;if(failures<=30)Console.WriteLine("FAIL "+n+" "+info);}}
using var doc=JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"../../../native-oracle.json")));
var type=typeof(SynergyEffectManager);var field=type.GetField("IsUseNewFetter",BindingFlags.NonPublic|BindingFlags.Instance);
foreach(var row in doc.RootElement.EnumerateArray()){
 var sc=row.GetProperty("scenario");Env.Player=sc.GetProperty("player").EnumerateArray().Select(x=>x.GetInt32()).ToArray();Env.Enemy=sc.GetProperty("enemy").EnumerateArray().Select(x=>x.GetInt32()).ToArray();Env.New=sc.GetProperty("new").GetBoolean();Env.RandomValue=sc.GetProperty("random").GetInt32();Env.Near=sc.GetProperty("near").GetInt32();
 var self=new SynergyEffectManager();field.SetValue(self,Env.New);Env.Trace.Clear();
 var name=row.GetProperty("name").GetString();var method=type.GetMethod(name,BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Public);var ps=method.GetParameters();var ints=row.GetProperty("args").EnumerateArray().Select(x=>x.GetInt64()).ToArray();int ii=0;object[] invokeArgs=new object[ps.Length];
 for(int i=0;i<ps.Length;i++){
  var pt=ps[i].ParameterType;
  if(pt==typeof(float)){invokeArgs[i]=BitConverter.Int32BitsToSingle(unchecked((int)row.GetProperty("floatBits").GetUInt32()));continue;}
  long value=ints[ii++];
  if(pt==typeof(EntityBase)){
   var kind=sc.GetProperty("targetKind").GetString();var ft=(CardFettersType)sc.GetProperty("targetFetter").GetInt32();invokeArgs[i]=kind=="null"?null:kind=="role"?new RoleBehaviour{CardFettersType=ft}:kind=="arch"?new ArchitectureBehaviour{CardFettersType=ft}:new EntityBase();
  }else if(pt==typeof(bool))invokeArgs[i]=value!=0;else if(pt.IsEnum)invokeArgs[i]=Enum.ToObject(pt,(int)value);else invokeArgs[i]=(int)value;
 }
 object actual=method.Invoke(self,invokeArgs);long got=actual is float fl?unchecked((uint)BitConverter.SingleToInt32Bits(fl)):actual is bool bl?bl?1:0:(int)actual;long expected=row.GetProperty("native").GetInt64();
 bool same=got==expected;if(actual is float f&&float.IsNaN(f)){float nf=BitConverter.Int32BitsToSingle(unchecked((int)expected));same=float.IsNaN(nf);}
 Check(name+" return",same,$"got {got}, native {expected}");
 var trace=JsonSerializer.SerializeToNode(Env.Trace);Check(name+" call-order",JsonNode.DeepEquals(trace,JsonNode.Parse(row.GetProperty("trace").GetRawText())),trace.ToJsonString()+" native "+row.GetProperty("trace").GetRawText());
}
using var ctorDoc=JsonDocument.Parse(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"../../../native-constructor.json")));
foreach(var row in ctorDoc.RootElement.EnumerateArray()){
 Env.New=row.GetProperty("new").GetBoolean();Env.ConstructorTrace.Clear();var self=new SynergyEffectManager();var trace=JsonSerializer.SerializeToNode(Env.ConstructorTrace);Check("constructor order",JsonNode.DeepEquals(trace,JsonNode.Parse(row.GetProperty("trace").GetRawText())),trace.ToJsonString());Check("constructor stored flag",(bool)field.GetValue(self)==row.GetProperty("storedNew").GetBoolean());
 Env.BuilderResults=0;var task=self.Init();Check("Init completes native no-op",task.Completed&&Env.BuilderResults==1);
}
var stateType=type.GetNestedType("_003CInit_003Ed__1",BindingFlags.NonPublic);var sm=(IAsyncStateMachine)Activator.CreateInstance(stateType);Env.BuilderSetMachines=0;sm.SetStateMachine(sm);Check("SetStateMachine forwards",Env.BuilderSetMachines==1);sm.MoveNext();Check("MoveNext marks complete",(int)stateType.GetField("_003C_003E1__state").GetValue(sm)==-2);
Console.WriteLine($"checks={checks} failures={failures}");Environment.ExitCode=failures==0?0:1;

