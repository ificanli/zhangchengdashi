using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var workspace=Path.GetFullPath(".");var work=Path.Combine(workspace,"work/scalar-expansion");var scripts=Path.Combine(workspace,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp");
string mode=args.Length==1?args[0]:throw new Exception("plan|apply|readback");
var options=new JsonSerializerOptions{WriteIndented=true};
string Hash(string path)=>Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path)));
string TextHash(string text)=>Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
string Owner(SyntaxNode node) {var ns=string.Join('.',node.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(n=>n.Name));return (ns.Length>0?ns+".":"")+string.Join('+',node.Ancestors().OfType<TypeDeclarationSyntax>().Reverse().Select(t=>t.Identifier.ValueText));}
SyntaxList<AttributeListSyntax> Attrs(SyntaxNode node)=>node switch{AccessorDeclarationSyntax a=>a.AttributeLists,PropertyDeclarationSyntax p=>p.AttributeLists,FieldDeclarationSyntax f=>f.AttributeLists,_=>default};
string? Attr(SyntaxNode node,string type,string key)=>Attrs(node).SelectMany(a=>a.Attributes).Where(a=>a.Name.ToString().EndsWith(type)).SelectMany(a=>a.ArgumentList?.Arguments??default).FirstOrDefault(a=>a.NameEquals?.Name.Identifier.ValueText==key)?.Expression is LiteralExpressionSyntax value?value.Token.ValueText:null;
bool TokenEqual(string? token,string native)=>token!=null&&Convert.ToUInt32(token[2..],16)==Convert.ToUInt32(native[2..],16);
PropertyDeclarationSyntax Find(SyntaxNode root,JsonNode entry)=>root.DescendantNodes().OfType<PropertyDeclarationSyntax>().Single(p=>Owner(p)==entry["type"]!.GetValue<string>()&&p.Identifier.ValueText==entry["property"]!.GetValue<string>());
AccessorDeclarationSyntax FindAccessor(PropertyDeclarationSyntax property,JsonNode native)=>property.AccessorList!.Accessors.Single(a=>TokenEqual(Attr(a,"Token","Token"),native["methodToken"]!.GetValue<string>())&&string.Equals(Attr(a,"Address","RVA"),native["address"]!.GetValue<string>(),StringComparison.OrdinalIgnoreCase));
var excluded=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"excluded-types.json")))!.AsArray().Select(t=>t!.GetValue<string>()).ToHashSet();
JsonArray plan;
if(mode=="plan")
{
 plan=new();var explicitAccessors=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"field-accessor-plan.json")))!.AsArray();var properties=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"auto-property-plan.json")))!.AsArray();
 foreach(var proof in explicitAccessors.Concat(properties))
 {
  string path=proof!["sourcePath"]!.GetValue<string>();string owner=proof["type"]!.GetValue<string>();if(excluded.Contains(owner.Split('+')[0]))throw new Exception("Excluded source type");
  if(Hash(path)!=proof["sourceHash"]!.GetValue<string>()||Hash(path+".meta")!=proof["metaHash"]!.GetValue<string>())throw new Exception("Concurrent source/meta edit before plan: "+path);
  string text=File.ReadAllText(path);var property=Find(CSharpSyntaxTree.ParseText(text).GetRoot(),proof);string before,after;int start,length;
  bool auto=proof["native"]==null;
  if(auto)
  {
   if(property.ToString()!=proof["sourceProperty"]!.GetValue<string>())throw new Exception("Property source changed");
   before=text[property.Span.Start..property.Span.End];after=before;start=property.Span.Start;length=property.Span.Length;
   foreach(var kind in new[]{"getter","setter"}) {var a=FindAccessor(property,proof[kind]!);if(a.Body==null)throw new Exception("No placeholder body");}
   foreach(var a in property.AccessorList!.Accessors.OrderByDescending(a=>a.SpanStart)){int astart=a.Keyword.Span.End-property.Span.Start;int aend=a.Body!.Span.End-property.Span.Start;after=after[..astart]+";"+after[aend..];}
  }
  else
  {
   var native=proof["native"]!;var a=FindAccessor(property,native);if(a.Body?.ToString()!=proof["sourceBody"]!.GetValue<string>())throw new Exception("Accessor source changed");
   string field=native["field"]!.GetValue<string>();string ownerPath=Path.Combine(scripts,native["fieldOwner"]!.GetValue<string>().Split('+')[0].Replace('.',Path.DirectorySeparatorChar)+".cs");
   var originalField=CSharpSyntaxTree.ParseText(File.ReadAllText(ownerPath)).GetRoot().DescendantNodes().OfType<FieldDeclarationSyntax>().Single(f=>Owner(f)==native["fieldOwner"]!.GetValue<string>()&&TokenEqual(Attr(f,"Token","Token"),native["fieldToken"]!.GetValue<string>()));
   string sourceName=originalField.Declaration.Variables.Single(v=>v.Identifier.ValueText==field).Identifier.Text;
   string nl=text.Contains("\r\n")?"\r\n":"\n";start=a.Body!.Span.Start;length=a.Body.Span.Length;before=text.Substring(start,length);string indent=text[(text.LastIndexOf('\n',start)+1)..start];
   string statement=native["kind"]!.GetValue<string>()=="getter"?"return "+sourceName+";":sourceName+" = value;";after="{"+nl+indent+"\t"+statement+nl+indent+"}";
  }
  if(SyntaxFactory.ParseMemberDeclaration(auto?after:"public class Fixture { public int Placeholder {get "+after+"} }")?.ContainsDiagnostics!=false)throw new Exception("Generated source has syntax diagnostics");
  plan.Add(new JsonObject{["type"]=owner,["property"]=proof["property"]!.DeepClone(),["autoProperty"]=auto,["sourcePath"]=path,["sourceHash"]=proof["sourceHash"]!.DeepClone(),["metaHash"]=proof["metaHash"]!.DeepClone(),["start"]=start,["length"]=length,["before"]=before,["after"]=after,["proof"]=proof.DeepClone()});
 }
 // DataManager goes into the first atomic file write.
 plan=new JsonArray(plan.OrderBy(p=>p!["type"]!.GetValue<string>()=="DataModule.DataManager"?0:1).Select(p=>p!.DeepClone()).ToArray());
 File.WriteAllText(Path.Combine(work,"write-plan.json"),plan.ToJsonString(options));
}
else plan=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"write-plan.json")))!.AsArray();

if(mode=="apply")
{
 var validation=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"preflight/sample-validation.json")))!;
 int count=plan.Sum(p=>p!["autoProperty"]!.GetValue<bool>()?2:1);
 if(validation["statuses"]?["passed"]?.GetValue<int>()!=count||validation["methods"]!.GetValue<int>()!=count)throw new Exception("Every native preflight method must pass");
 foreach(var p in plan){string path=p!["sourcePath"]!.GetValue<string>();if(Hash(path)!=p["sourceHash"]!.GetValue<string>()||Hash(path+".meta")!=p["metaHash"]!.GetValue<string>())throw new Exception("Concurrent source/meta change blocks batch: "+path);}
 foreach(var group in plan.GroupBy(p=>p!["sourcePath"]!.GetValue<string>()))
 {
  string path=group.Key;byte[] bytes=File.ReadAllBytes(path);string text=File.ReadAllText(path);if(Hash(path)!=group.First()!["sourceHash"]!.GetValue<string>())throw new Exception("Concurrent source edit: "+path);
  string relative=Path.GetRelativePath(scripts,path);string backup=Path.Combine(workspace,"work/recovery-stubs/scalar-expansion-before",relative);Directory.CreateDirectory(Path.GetDirectoryName(backup)!);if(File.Exists(backup))throw new Exception("Backup already exists; batch must not run twice");File.WriteAllBytes(backup,bytes);File.Copy(path+".meta",backup+".meta");
  int previous=text.Length;
  foreach(var p in group.OrderByDescending(p=>p!["start"]!.GetValue<int>())){int start=p!["start"]!.GetValue<int>(),length=p["length"]!.GetValue<int>();if(start+length>previous||text.Substring(start,length)!=p["before"]!.GetValue<string>())throw new Exception("Overlapping or stale source edit");text=text[..start]+p["after"]!.GetValue<string>()+text[(start+length)..];previous=start;}
  File.WriteAllText(path,text,new UTF8Encoding(bytes.Length>=3&&bytes[0]==0xEF&&bytes[1]==0xBB&&bytes[2]==0xBF));
  foreach(var p in group){if(Hash(path+".meta")!=p!["metaHash"]!.GetValue<string>())throw new Exception("GUID changed");p["afterHash"]=Hash(path);}
 }
 File.WriteAllText(Path.Combine(work,"applied-plan.json"),plan.ToJsonString(options));Console.WriteLine($"SOURCE_APPLIED methods={count} files={plan.Select(p=>p!["sourcePath"]!.GetValue<string>()).Distinct().Count()}");return;
}
if(mode is not("plan" or "readback"))throw new Exception("Unknown mode");
if(mode=="readback")plan=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"applied-plan.json")))!.AsArray();
var fixture=Path.Combine(work,mode=="plan"?"preflight":"readback");Directory.CreateDirectory(fixture);var manifest=new JsonArray();var code=new StringBuilder("using System;\nusing System.Runtime.CompilerServices;\nusing Il2CppDummyDll;\n");int index=0;
foreach(var p in plan)
{
 var proof=p!["proof"]!;string member=p["after"]!.GetValue<string>();bool auto=p["autoProperty"]!.GetValue<bool>();string fixtureType="RecoveredScalar_"+(index++).ToString("000");
 if(mode=="readback") {string path=p["sourcePath"]!.GetValue<string>();var property=Find(CSharpSyntaxTree.ParseText(File.ReadAllText(path)).GetRoot(),p);member=auto?property.ToString():FindAccessor(property,proof["native"]!).Body!.ToString();if(TextHash(member)!=TextHash(p["after"]!.GetValue<string>()))throw new Exception("Readback source differs: "+path);if(Hash(path+".meta")!=p["metaHash"]!.GetValue<string>())throw new Exception("Meta changed");p["readbackHash"]=Hash(path);p["readbackMember"]=member;}
 code.AppendLine("public class "+fixtureType+" {");
 if(auto)code.AppendLine(member);else {var n=proof["native"]!;string field=n["field"]!.GetValue<string>();string fieldType=n["fieldType"]!.GetValue<string>();string parameters=n["kind"]!.GetValue<string>()=="setter"?fieldType+" value":"";code.AppendLine("public "+fieldType+" "+field+";");code.AppendLine("public "+(n["returnType"]!.GetValue<string>()=="System.Void"?"void":n["returnType"]!.GetValue<string>())+" Invoke("+parameters+") "+member);}
 code.AppendLine("}");
 foreach(var n in auto?new[]{proof["getter"]!,proof["setter"]!}:new[]{proof["native"]!})
  manifest.Add(new JsonObject{["Method"]=n["method"]!.DeepClone(),["TypeName"]=fixtureType,["MethodName"]=auto?n["methodName"]!.DeepClone():JsonValue.Create("Invoke"),["Kind"]=n["kind"]!.DeepClone(),["Address"]=n["address"]!.DeepClone(),["CodeHex"]=n["codeHex"]!.DeepClone(),["ReturnType"]=n["returnType"]!.DeepClone(),["IsStatic"]=false,["ParameterTypes"]=n["parameters"]!.DeepClone(),["FieldDeclaringType"]=fixtureType,["FieldName"]=n["field"]!.DeepClone(),["FieldType"]=n["fieldType"]!.DeepClone(),["FieldOffset"]=n["fieldOffset"]!.DeepClone(),["OriginalMethodToken"]=n["methodToken"]!.DeepClone(),["OriginalFieldToken"]=n["fieldToken"]!.DeepClone()});
}
File.WriteAllText(Path.Combine(fixture,"ActualMembers.cs"),code.ToString());File.WriteAllText(Path.Combine(fixture,"sample-manifest.json"),manifest.ToJsonString(options));
string attributes=Path.Combine(workspace,"outputs/OccupyCityRecovered/Library/ScriptAssemblies/Il2CppDummyDll.dll");File.WriteAllText(Path.Combine(fixture,"ActualMembers.csproj"),$"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><AssemblyName>Assembly-CSharp</AssemblyName></PropertyGroup><ItemGroup><Reference Include=\"Il2CppDummyDll\"><HintPath>{attributes}</HintPath></Reference></ItemGroup></Project>");
if(mode=="readback")File.WriteAllText(Path.Combine(work,"source-provenance.json"),plan.ToJsonString(options));Console.WriteLine($"SOURCE_FIXTURE mode={mode} methods={manifest.Count} members={plan.Count}");
