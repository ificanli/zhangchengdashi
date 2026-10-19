using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage38-savebase");
var plans=JsonDocument.Parse(File.ReadAllText(Path.Combine(work,"write-plan.json"))).RootElement.GetProperty("files");var results=new List<object>();
foreach(var plan in plans.EnumerateArray())
{
 var rel=plan.GetProperty("path").GetString()!;var before=Parse(Path.Combine(work,"before",rel));var after=Parse(Path.Combine(work,"candidate",rel));
 var chosen=plan.GetProperty("methods").EnumerateArray().Select(m=>m.GetProperty("token").GetString()!).Concat(plan.GetProperty("autoProperties").EnumerateArray().Select(t=>t.GetString()!)).ToHashSet();
 bool Selected(SyntaxNode n)=>chosen.Contains(Token(n)??"") || n is PropertyDeclarationSyntax p&&p.AccessorList!.Accessors.Any(a=>chosen.Contains(Token(a)??""));
 var old=Leaves(before).Where(n=>!Selected(n)).GroupBy(n=>Token(n)!).ToDictionary(g=>g.Key,g=>g.ToArray());
 var current=Leaves(after).Where(n=>!Selected(n)).GroupBy(n=>Token(n)!).ToDictionary(g=>g.Key,g=>g.ToArray());
 int count=0;foreach(var (token,members) in old)
 {
  if(!current.TryGetValue(token,out var others)||members.Length!=others.Length)throw new Exception("Members differ "+rel+" "+token);
  for(int i=0;i<members.Length;i++){if(members[i].ToFullString()!=others[i].ToFullString())throw new Exception("Non-target changed "+rel+" "+token);count++;}
 }
 results.Add(new{file=rel,unchangedNonTargetMembers=count,selectedUniqueTokens=plan.GetProperty("methods").GetArrayLength(),selectedDeclarationBodies=after.DescendantNodes().Count(n=>(n is BaseMethodDeclarationSyntax||n is AccessorDeclarationSyntax)&&chosen.Contains(Token(n)??"")),addedStaticConstructors=after.DescendantNodes().OfType<ConstructorDeclarationSyntax>().Count(c=>c.Modifiers.Any(SyntaxKind.StaticKeyword))-before.DescendantNodes().OfType<ConstructorDeclarationSyntax>().Count(c=>c.Modifiers.Any(SyntaxKind.StaticKeyword))});
}
File.WriteAllText(Path.Combine(work,"source-verification.json"),JsonSerializer.Serialize(results,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine(JsonSerializer.Serialize(results));
static SyntaxNode Parse(string path)=>CSharpSyntaxTree.ParseText(File.ReadAllText(path)).GetRoot();
static IEnumerable<SyntaxNode> Leaves(SyntaxNode root)=>root.DescendantNodes().Where(n=>n is MethodDeclarationSyntax or ConstructorDeclarationSyntax or PropertyDeclarationSyntax or FieldDeclarationSyntax or EnumMemberDeclarationSyntax).Where(n=>Token(n)!=null);
static string? Token(SyntaxNode n)
{
 var attrs=n switch{MemberDeclarationSyntax m=>m.AttributeLists.ToFullString(),AccessorDeclarationSyntax a=>a.AttributeLists.ToFullString(),_=>""};var match=Regex.Match(attrs,"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return match.Success?match.Groups[1].Value:null;
}
