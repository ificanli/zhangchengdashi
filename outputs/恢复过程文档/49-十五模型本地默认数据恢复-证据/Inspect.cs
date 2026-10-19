using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using Mono.Cecil;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage49-model-defaults");
var gold=JsonDocument.Parse(File.ReadAllText(Path.Combine(root,"work/stage45-data/native-golden.json"))).RootElement;
var success=gold.EnumerateArray().First(x=>x.GetProperty("kind").GetString()=="LoadAllSaveData"&&x.GetProperty("missingIndex").GetInt32()==-1&&x.GetProperty("error").ValueKind==JsonValueKind.Null);
var order=success.GetProperty("calls").EnumerateArray().Select(x=>x.GetString()!).ToArray();if(order.Length!=15)throw new Exception("Expected actual 15 native success models");
using var asm=AssemblyDefinition.ReadAssembly(Path.Combine(root,"work/il2cpp-dump-decoded/DummyDll/Assembly-CSharp.dll"));
var all=asm.MainModule.Types.ToDictionary(t=>t.FullName);var rows=new List<object>();
for(int i=0;i<order.Length;i++)
{
 var model=all[order[i]];var generic=(GenericInstanceType)model.BaseType;var tdName=generic.GenericArguments[1].FullName;var td=all[tdName];
 var rel="Assets/Scripts/Assembly-CSharp/"+tdName.Replace('.','/')+".cs";var path=Path.Combine(root,"outputs/OccupyCityRecovered",rel);var bytes=File.ReadAllBytes(path);var syntax=CSharpSyntaxTree.ParseText(File.ReadAllText(path)).GetRoot();
 var own=td.Methods.Where(m=>m.Name is ".ctor" or ".cctor" or "Init" or "InitFromDefaults").Select(m=>
 {
  var token=Token(m)!;var declarations=syntax.DescendantNodes().OfType<BaseMethodDeclarationSyntax>().Where(n=>TokenSyntax(n.AttributeLists)==token).ToArray();
  return new {m.Name,m.FullName,token,rva=Rva(m),m.IsStatic,m.IsVirtual,sourceDeclarations=declarations.Length,sourceNonEmpty=declarations.Any(d=>d.Body?.Statements.Count>0),sourceBodies=declarations.Select(d=>d.Body?.ToFullString()),alreadyProtected=tdName=="DataModule.PlayerTimeData"};
 }).ToArray();
 rows.Add(new{nativeLoadIndex=i,model=model.FullName,modelToken=Token(model),genericBase=model.BaseType.FullName,dataType=tdName,dataTypeToken=Token(td),baseType=td.BaseType.FullName,source=rel,sourceSha256=Convert.ToHexString(SHA256.HashData(bytes)),metaSha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path+".meta"))),protectedExisting=tdName=="DataModule.PlayerTimeData",
  fields=td.Fields.Select(f=>new{f.Name,type=f.FieldType.FullName,f.IsStatic,f.IsPrivate,token=Token(f),offset=f.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="FieldOffsetAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Offset").Argument.Value,jsonName=f.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="JsonPropertyAttribute")?.ConstructorArguments.FirstOrDefault().Value}),
  ownMethods=own,inheritedInit=!td.Methods.Any(m=>m.Name=="Init"),inheritedDefaults=!td.Methods.Any(m=>m.Name=="InitFromDefaults"),
  sourceFieldInitializers=syntax.DescendantNodes().OfType<FieldDeclarationSyntax>().SelectMany(f=>f.Declaration.Variables).Where(v=>v.Initializer!=null).Select(v=>v.ToString())});
}
File.WriteAllText(Path.Combine(work,"model-inventory.json"),JsonSerializer.Serialize(rows,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine($"Inspected {rows.Count} actual TD types in original native success order; no source writes");
static string? Token(ICustomAttributeProvider p)=>p.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="TokenAttribute")?.Fields.FirstOrDefault(x=>x.Name=="Token").Argument.Value as string;
static string? Rva(ICustomAttributeProvider p)=>p.CustomAttributes.FirstOrDefault(a=>a.AttributeType.Name=="AddressAttribute")?.Fields.FirstOrDefault(x=>x.Name=="RVA").Argument.Value as string;
static string? TokenSyntax(SyntaxList<AttributeListSyntax> attrs){var m=Regex.Match(attrs.ToFullString(),"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return m.Success?m.Groups[1].Value:null;}
