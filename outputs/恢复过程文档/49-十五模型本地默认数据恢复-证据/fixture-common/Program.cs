using System.Collections;
using System.Numerics;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
var w=Path.GetFullPath(args[0]);var gold=JsonNode.Parse(File.ReadAllText(Path.Combine(w,"native-golden.json")))!.AsArray();var inventory=JsonNode.Parse(File.ReadAllText(Path.Combine(w,"model-inventory.json")))!.AsArray();var child=JsonNode.Parse(File.ReadAllText(Path.Combine(w,"child-metadata.json")))!;inventory.Add(child.DeepClone());
AssemblyLoadContext.Default.Resolving+=(context,name)=>
{
 var root=Directory.GetParent(Directory.GetParent(w)!.FullName)!.FullName;
 var choices=new[]{Path.Combine(root,"outputs/OccupyCityRecovered/Library/ScriptAssemblies",name.Name+".dll"),Path.Combine("C:/Program Files/Unity/Hub/Editor/2022.3.62f3c1/Editor/Data/Managed/UnityEngine",name.Name+".dll")};
 var path=choices.FirstOrDefault(File.Exists);return path==null?null:context.LoadFromAssemblyPath(path);
};
var schemas=inventory.ToDictionary(m=>m!["dataType"]!.GetValue<string>(),m=>m!["fields"]!.AsArray());var checks=0;var failures=new List<string>();
void Check(bool ok,string label){checks++;if(!ok)failures.Add(label);}
var offsets=new Dictionary<string,int[]>{{"DataModule.PlayerMainCityData",new[]{0x10}},{"DataModule.PlayerArenaData",new[]{0x10}},{"DataModule.PlayerResourceData",new[]{0x10}},{"DataModule.PlayerShopData",new[]{0xA0,0xD8,0xA8,0x60}},{"DataModule.PlayerCustomizationData",new[]{0x18}},{"DataModule.PlayerCoreData",new[]{0x60}}};
FieldInfo Field(Type t,string name)=>t.GetField(name,BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.DeclaredOnly)!;
object Seed(Type type)
{
 if(type==typeof(string))return "ExistingName";
 object v=Activator.CreateInstance(type)!;
 if(v is IDictionary d){var a=type.GetGenericArguments();object key=a[0]==typeof(string)?"existing":EnumOrValue(a[0]);object value=a[1].IsValueType?Activator.CreateInstance(a[1])!:null!;d.Add(key,value);}
 else if(v is IList l){var e=type.GetGenericArguments()[0];l.Add(e==typeof(int)?999:e.IsValueType?Activator.CreateInstance(e):null);}
 return v;
}
object EnumOrValue(Type type)=>type==typeof(int)?777:type.IsEnum?Enum.ToObject(type,777):Activator.CreateInstance(type)!;
JsonNode? Normalize(object? v)
{
 if(v==null)return null;
 if(v is string s)return JsonValue.Create(s);
 if(v is bool b)return JsonValue.Create(b);
 if(v is int i)return JsonValue.Create(i);
 if(v is long l)return JsonValue.Create(l);
 if(v is float f)return JsonValue.Create(f);
 if(v.GetType().IsEnum)return JsonValue.Create(Convert.ToInt32(v));
 if(v is DateTime dt)return JsonSerializerNode(new{kind="date",ticks=dt.Ticks});
 if(v is BigInteger bi)return JsonSerializerNode(new{kind="bigint",value=bi.ToString()});
 if(v is IDictionary d)return JsonSerializerNode(new{kind="dictionary",count=d.Count});
 if(v is IList list){var node=new JsonObject{{"kind","list"},{"count",list.Count}};if(v.GetType().GetGenericArguments().FirstOrDefault()==typeof(int))node["items"]=JsonSerializerNode(list.Cast<int>().ToArray());return node;}
 return JsonSerializerNode(new{kind="object"});
}
JsonNode JsonSerializerNode(object value)=>System.Text.Json.JsonSerializer.SerializeToNode(value)!;
foreach(var row in gold)
{
 string name=row!["dataType"]!.GetValue<string>(),method=row["method"]!.GetValue<string>(),seed=row["seed"]!.GetValue<string>();var type=Assembly.GetExecutingAssembly().GetType(name,true)!;object obj=Activator.CreateInstance(type)!;var previous=new Dictionary<string,object>();
 if(method!=".ctor"&&seed!="normal")
 {
  var chosen=method=="Init"?new[]{0xB8}:offsets.GetValueOrDefault(name,Array.Empty<int>());var json=new JsonObject();
  foreach(var schema in schemas[name])
  {
   if(schema!["IsStatic"]?.GetValue<bool>()==true||schema["offset"]==null)continue;
   int offset=Convert.ToInt32(schema["offset"]!.GetValue<string>()[2..],16);if(!chosen.Contains(offset))continue;
   var field=Field(type,schema["Name"]!.GetValue<string>());string key=schema["jsonName"]?.GetValue<string>()??field.Name;
   object? value=seed=="null"?null:Seed(field.FieldType);json[key]=value==null?null:JsonNode.Parse(JsonConvert.SerializeObject(value));
  }
  // Real original JsonProperty contracts run the actual TD constructor first,
  // then apply explicit persisted null or existing collection values.
  obj=JsonConvert.DeserializeObject(json.ToJsonString(),type)!;
  foreach(string key in row["preserved"]!.AsObject().Select(x=>x.Key))previous[key]=Field(type,key).GetValue(obj)!;
 }
 ControlledRng.Reset(name);string? error=null;
 if(method!=".ctor")try{type.GetMethod(method)!.Invoke(obj,null);}catch(TargetInvocationException ex){error=ex.InnerException!.GetType().Name;}
 string prefix=name+"."+method+"/"+seed;Check(error==row["error"]?.GetValue<string>(),prefix+" exception");
 foreach(var pair in row["fields"]!.AsObject())
 {
  var actual=Normalize(Field(type,pair.Key).GetValue(obj));Check(JsonNode.DeepEquals(actual,pair.Value),prefix+" field "+pair.Key+" expected="+pair.Value?.ToJsonString()+" actual="+actual?.ToJsonString());
 }
 foreach(var pair in row["preserved"]!.AsObject())Check(ReferenceEquals(previous[pair.Key],Field(type,pair.Key).GetValue(obj))==pair.Value!.GetValue<bool>(),prefix+" reference identity "+pair.Key);
 Check(JsonNode.DeepEquals(JsonSerializerNode(ControlledRng.Draws),row["draws"]),prefix+" original RNG requests");Check(ControlledRng.Created==row["randomConstructors"]!.GetValue<int>(),prefix+" original Random constructor count");
}
Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new{scenarios=gold.Count,checks,failures=failures.Count,errors=failures.Take(80),note="Actual selected TD source/fields and real JsonProperty JSON; controlled RNG and actual compiled main/GF companion types. No Unity runtime acceptance."},new JsonSerializerOptions{WriteIndented=true}));Environment.ExitCode=failures.Count==0?0:1;
