using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage33-time");
var plans=JsonDocument.Parse(File.ReadAllText(Path.Combine(work,"write-plan.json"))).RootElement.GetProperty("files");
var metadata=JsonDocument.Parse(File.ReadAllText(Path.Combine(work,"original-metadata.json"))).RootElement;
var methods=metadata.EnumerateArray().SelectMany(t=>t.GetProperty("methods").EnumerateArray().Select(m=>(type:t.GetProperty("FullName").GetString(),node:m))).ToDictionary(x=>x.node.GetProperty("token").GetString()!,x=>x);
var rows=new List<object>();var restored=new List<object>();
var move=new Dictionary<string,string>{{"0x60004B4","0x3F6EA3C"},{"0x60004B6","0x3F6F450"},{"0x60004BB","0x3F6E780"},{"0x60004BD","0x3F70868"},{"0x60004C4","0x3F6E564"},{"0x60004C5","0x3F6E440"},{"0x60004C6","0x3F6E688"},{"0x60004DA","0x3F6FAF4"}};
foreach(var p in plans.EnumerateArray())
{
 var rel=p.GetProperty("path").GetString()!;var before=Parse(Path.Combine(work,"before",rel));var after=Parse(Path.Combine(work,"candidate",rel));
 var tokens=p.GetProperty("methods").EnumerateArray().Select(m=>m.GetProperty("token").GetString()!).Concat(p.GetProperty("autoProperties").EnumerateArray().Select(t=>t.GetString()!)).ToHashSet();
 var a=Leaves(after).ToDictionary(n=>Token(n)!,n=>n);var count=0;
 foreach(var n in Leaves(before))
 {
  var token=Token(n)!;if(tokens.Contains(token))continue;
  if(!a.TryGetValue(token,out var same)||n.ToFullString()!=same.ToFullString())throw new Exception("Unselected source changed "+token);count++;
 }
 rows.Add(new{file=rel,unchangedNonTargetMembers=count,selectedMethodBodies=p.GetProperty("methods").GetArrayLength(),autoProperties=p.GetProperty("autoProperties").GetArrayLength()});
 foreach(var m in p.GetProperty("methods").EnumerateArray())
 {
  var token=m.GetProperty("token").GetString()!;var native=methods[token];var rva=native.node.GetProperty("rva").GetString();
  restored.Add(new{file=rel,token,declaringType=native.type,name=native.node.GetProperty("Name").GetString(),wrapperOrDirectRva=rva,nativeBodyRva=move.GetValueOrDefault(token,rva)});
 }
}
File.WriteAllText(Path.Combine(work,"source-verification.json"),JsonSerializer.Serialize(rows,new JsonSerializerOptions{WriteIndented=true}));
File.WriteAllText(Path.Combine(work,"restored-methods.json"),JsonSerializer.Serialize(restored,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine(JsonSerializer.Serialize(rows));
static SyntaxNode Parse(string path)=>CSharpSyntaxTree.ParseText(File.ReadAllText(path)).GetRoot();
static IEnumerable<SyntaxNode> Leaves(SyntaxNode root)=>root.DescendantNodes().Where(n=>n is MethodDeclarationSyntax or ConstructorDeclarationSyntax or PropertyDeclarationSyntax or FieldDeclarationSyntax or EnumMemberDeclarationSyntax).Where(n=>Token(n)!=null);
static string? Token(SyntaxNode n)
{
 var attrs=n switch{MemberDeclarationSyntax m=>m.AttributeLists.ToFullString(),_=>""};var match=Regex.Match(attrs,"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return match.Success?match.Groups[1].Value:null;
}

