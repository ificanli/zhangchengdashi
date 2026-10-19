using System.Text.Json;
using Mono.Cecil;
var root=Path.GetFullPath(args[0]);var rows=new List<object>();
foreach(var (assembly,names) in new[]{("GFRunning.dll",new[]{"GameFramework.Login.ILoginProcedure","GameFramework.Login.AccountType"}),("Assembly-CSharp.dll",new[]{"DataModule.DataManager","DataModule.ComflictStatus","L_Tools.LoginControl","CommonGameModule.Login.LoginProcedureBase","DataModule.DataCompareMgr","DataModule.SaveConflictCanvas"})})
{
 var asm=AssemblyDefinition.ReadAssembly(Path.Combine(root,"work/il2cpp-dump-decoded/DummyDll",assembly));
 foreach(var t in asm.MainModule.Types.SelectMany(All).Where(t=>names.Contains(t.FullName)||t.FullName.StartsWith("DataModule.DataCompareMgr/")||t.FullName.StartsWith("DataModule.SaveConflictCanvas/")))
  rows.Add(new{assembly,t.FullName,token=Token(t),baseType=t.BaseType?.FullName,
   fields=t.Fields.Select(f=>new{f.Name,type=f.FieldType.FullName,f.IsStatic,f.IsPrivate,token=Token(f),attributes=Attrs(f),offset=f.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="FieldOffsetAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Offset").Argument.Value,constant=f.HasConstant?f.Constant:null}),
   properties=t.Properties.Select(p=>new{p.Name,token=Token(p),getter=p.GetMethod?.Name,getterAttrs=p.GetMethod==null?null:Attrs(p.GetMethod),setter=p.SetMethod?.Name,setterAttrs=p.SetMethod==null?null:Attrs(p.SetMethod)}),
   methods=t.Methods.Select(m=>new{m.Name,m.FullName,m.IsStatic,m.IsPublic,m.IsPrivate,m.IsAbstract,token=Token(m),attributes=Attrs(m),rva=m.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="AddressAttribute")?.Fields.FirstOrDefault(x=>x.Name=="RVA").Argument.Value})});
}
File.WriteAllText(Path.Combine(root,"work/stage46-account-mode/original-metadata.json"),JsonSerializer.Serialize(rows,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine($"Inspected {rows.Count} original account/conflict types; no methods executed");
static IEnumerable<TypeDefinition> All(TypeDefinition t){yield return t;foreach(var n in t.NestedTypes)foreach(var x in All(n))yield return x;}
static string[] Attrs(ICustomAttributeProvider p)=>p.CustomAttributes.Select(a=>a.AttributeType.FullName).ToArray();
static string? Token(ICustomAttributeProvider p)=>p.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="TokenAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Token").Argument.Value as string;
