using System.Text.Json;
using Mono.Cecil;
var root=Path.GetFullPath(args[0]);var rows=new List<object>();
var specs=new[]{("Assembly-CSharp.dll",new[]{"DbtSaveDataManagerBase`2","DbtSaveDataManager_PlayerTimeData","DbtSaveDataManager_PlayerCoreData","DataModule.PlayerTimeData","DataModule.TimeInfo","ServerBaseData","L_Tools.DataCompressTools"}),("GFRunning.dll",new[]{"GameFramework.DataManagerBase","GameFramework.Tools.JsonHelper","GameFramework.ModelRegister","GameFramework.DataManagerPool","ÂOke\u008DÁ","GameFramework.Utility/AssemblyUtility","³\u0092¿\u0080d\u0084"})};
foreach(var (assembly,names) in specs)
{
 var asm=AssemblyDefinition.ReadAssembly(Path.Combine(root,"work/il2cpp-dump-decoded/DummyDll",assembly));
 foreach(var t in asm.MainModule.Types.SelectMany(All).Where(t=>names.Contains(t.FullName)))
  rows.Add(new{assembly,t.FullName,token=Token(t),baseType=t.BaseType?.FullName,
   genericParameters=t.GenericParameters.Select(g=>new{g.Name,attributes=g.Attributes.ToString(),constraints=g.Constraints.Select(c=>c.ConstraintType.FullName)}),
   fields=t.Fields.Select(f=>new{f.Name,type=f.FieldType.FullName,f.IsStatic,token=Token(f),attributes=Attrs(f),offset=f.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="FieldOffsetAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Offset").Argument.Value}),
   properties=t.Properties.Select(p=>new{p.Name,token=Token(p),getter=p.GetMethod?.Name,getterAttrs=p.GetMethod==null?null:Attrs(p.GetMethod),setter=p.SetMethod?.Name,setterAttrs=p.SetMethod==null?null:Attrs(p.SetMethod)}),
   methods=t.Methods.Select(m=>new{m.Name,m.FullName,m.IsStatic,m.IsPublic,m.IsPrivate,m.IsAbstract,token=Token(m),attributes=Attrs(m),rva=m.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="AddressAttribute")?.Fields.FirstOrDefault(x=>x.Name=="RVA").Argument.Value})});
}
File.WriteAllText(Path.Combine(root,"work/stage38-savebase/original-metadata.json"),JsonSerializer.Serialize(rows,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine($"Inspected {rows.Count} original types; no methods executed");
static string[] Attrs(ICustomAttributeProvider p)=>p.CustomAttributes.Select(a=>a.AttributeType.FullName).ToArray();
static string? Token(ICustomAttributeProvider p)=>p.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="TokenAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Token").Argument.Value as string;

static IEnumerable<TypeDefinition> All(TypeDefinition t){yield return t;foreach(var n in t.NestedTypes)foreach(var x in All(n))yield return x;}