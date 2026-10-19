using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var mode=args[1];var w=Path.Combine(root,"work/stage49-model-defaults");var output=Path.Combine(w,"fixture-"+mode);Directory.CreateDirectory(output);
var plan=JsonDocument.Parse(File.ReadAllText(Path.Combine(w,"write-plan.json"))).RootElement.GetProperty("files");var tokens=plan.EnumerateArray().SelectMany(f=>f.GetProperty("methods").EnumerateArray()).Select(m=>m.GetProperty("token").GetString()!).ToHashSet();
var paths=plan.EnumerateArray().Select(f=>f.GetProperty("path").GetString()!).Concat(new[]{"Assets/Scripts/Assembly-CSharp/DataModule/PlayerChestData.cs","Assets/Scripts/Assembly-CSharp/DataModule/PlayerTimeData.cs"}).ToArray();
foreach(var rel in paths)
{
 var candidate=mode=="actual"?Path.Combine(root,"outputs/OccupyCityRecovered",rel):Path.Combine(w,mode=="before"?"before":"candidate",rel);if(!File.Exists(candidate))candidate=Path.Combine(root,"outputs/OccupyCityRecovered",rel);
 var syntax=CSharpSyntaxTree.ParseText(File.ReadAllText(candidate)).GetRoot();var result=new Filter(tokens).Visit(syntax)!.ToFullString();
 if(mode=="mutant"&&rel.EndsWith("/PlayerCardData.cs"))
 {
  var changed=new Regex(@"\b1001\b").Replace(result,"1006",1);
  if(changed==result)throw new Exception("Negative mutation did not materialize");result=changed;
 }
 File.WriteAllText(Path.Combine(output,Path.GetFileName(rel)),result);
}
sealed class Filter(HashSet<string> tokens):CSharpSyntaxRewriter
{
 static string? Token(SyntaxList<AttributeListSyntax> attrs){var m=Regex.Match(attrs.ToFullString(),"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return m.Success?m.Groups[1].Value:null;}
 public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)=>tokens.Contains(Token(node.AttributeLists)??"")?base.VisitMethodDeclaration(node):null;
 public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)=>null;
 public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)=>node.Name?.ToString() is "Il2CppDummyDll" or "Beebyte.Obfuscator"?null:base.VisitUsingDirective(node);
 public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)
 {
  var keep=node.Attributes.Where(a=>a.Name.ToString() is not "Token" and not "Address" and not "FieldOffset" and not "Il2CppDummyDll.FieldOffset" and not "Skip").ToArray();return keep.Length==0?null:node.WithAttributes(SyntaxFactory.SeparatedList(keep));
 }
}
