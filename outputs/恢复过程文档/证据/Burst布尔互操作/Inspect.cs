using System.Text.Json;
using System.Security.Cryptography;
using Mono.Cecil;
using Mono.Cecil.Cil;
var task=Path.GetFullPath(args[0]);var work=Path.Combine(task,"work/burst-bool-abi");var paths=new[]{("originalDummy","work/il2cpp-dump-decoded/DummyDll/AstarPathfindingProject.dll"),("actualImport13","outputs/OccupyCityRecovered/Library/ScriptAssemblies/AstarPathfindingProject.dll")};var results=new List<object>();var targets=new[]{"Pathfinding.ECS.JobRepairPathHelpers/PathTracerInfo","Pathfinding.Graphs.Navmesh.TileHandler/CutCollection"};
foreach(var (kind,relative) in paths){var path=Path.Combine(task,relative);var asm=AssemblyDefinition.ReadAssembly(path);var types=asm.MainModule.Types.SelectMany(All).ToArray();var layouts=targets.Select(name=>{
 var type=types.Single(t=>t.FullName==name);return new{type.FullName,token=Token(type),type.Attributes,type.IsSequentialLayout,type.IsExplicitLayout,type.ClassSize,type.PackingSize,fields=type.Fields.Where(f=>!f.IsStatic).Select(f=>new{f.Name,type=f.FieldType.FullName,token=Token(f),f.Offset,il2cppOffset=f.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="FieldOffsetAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Offset").Argument.Value,f.HasMarshalInfo,marshal=f.HasMarshalInfo?f.MarshalInfo.NativeType.ToString():null,attributes=f.CustomAttributes.Select(a=>a.AttributeType.FullName)})};}).ToArray();
 var bridges=types.SelectMany(t=>t.Methods).Where(m=>m.Parameters.Any(p=>p.ParameterType.IsByReference&&targets.Contains(p.ParameterType.GetElementType().FullName))).Select(m=>new{m.FullName,token=Token(m),parameterTypes=m.Parameters.Select(p=>p.ParameterType.FullName),calls=m.HasBody?m.Body.Instructions.Where(i=>i.OpCode.Code==Code.Calli).Select(i=>new{offset=i.Offset,signature=i.Operand.ToString()}):null}).ToArray();
 results.Add(new{kind,source=relative,sha256=Hash(path),layouts,bridgeSignatures=bridges});
}
File.WriteAllText(Path.Combine(work,"original-and-import13-layout.json"),JsonSerializer.Serialize(results,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine("Inspected original Field tokens/offsets/MarshalInfo and actual Import13 field metadata plus generated calli signatures; no code executed");
static IEnumerable<TypeDefinition> All(TypeDefinition t){yield return t;foreach(var n in t.NestedTypes)foreach(var x in All(n))yield return x;}
static string? Token(ICustomAttributeProvider p)=>p.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="TokenAttribute")?.Fields.FirstOrDefault(f=>f.Name=="Token").Argument.Value as string;
static string Hash(string p)=>Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(p))).ToLowerInvariant();
