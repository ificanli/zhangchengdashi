using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage38-savebase");var output=Path.Combine(work,"fixture");Directory.CreateDirectory(output);
var plans=JsonDocument.Parse(File.ReadAllText(Path.Combine(work,"write-plan.json"))).RootElement.GetProperty("files");
foreach(var p in plans.EnumerateArray())
{
 string rel=p.GetProperty("path").GetString()!;var source=Path.Combine(work,"candidate",rel);
 var selected=p.GetProperty("methods").EnumerateArray().Select(m=>m.GetProperty("token").GetString()!).ToHashSet();
 var tree=CSharpSyntaxTree.ParseText(File.ReadAllText(source));
 var filtered=new Filter(Path.GetFileName(rel),selected).Visit(tree.GetRoot())!;
 File.WriteAllText(Path.Combine(output,Path.GetFileName(rel)),filtered.ToFullString());
}
foreach(var rel in new[]{"DbtSaveDataManager_PlayerTimeData.cs","ServerBaseData.cs","DataModule/TimeInfo.cs"})
{
 var tree=CSharpSyntaxTree.ParseText(File.ReadAllText(Path.Combine(root,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp",rel)));
 File.WriteAllText(Path.Combine(output,Path.GetFileName(rel)),new Filter("",[]).Visit(tree.GetRoot())!.ToFullString());
}
sealed class Filter(string file,HashSet<string> selected):CSharpSyntaxRewriter
{
 static string? Token(SyntaxNode n){if(n is not MemberDeclarationSyntax m && n is not AccessorDeclarationSyntax)return null;var attrs=n is MemberDeclarationSyntax x?x.AttributeLists.ToFullString():((AccessorDeclarationSyntax)n).AttributeLists.ToFullString();var match=Regex.Match(attrs,"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return match.Success?match.Groups[1].Value:null;}
 public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)=>node.Name?.ToString() is "Il2CppDummyDll" or "Beebyte.Obfuscator" or "GameFramework.Obfuscator"?null:base.VisitUsingDirective(node);
 public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)
 {
  var attrs=node.Attributes.Where(a=>a.Name.ToString() is not "Token" and not "Address" and not "FieldOffset" and not "Il2CppDummyDll.FieldOffset" and not "Skip" and not "Confuse").ToArray();
  return attrs.Length==0?null:node.WithAttributes(SyntaxFactory.SeparatedList(attrs));
 }
 public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
 {
  if(file=="Utility.cs"&&node.Parent is ClassDeclarationSyntax c&&c.Identifier.Text=="Utility"&&node.Identifier.Text!="AssemblyUtility")return null;
  return base.VisitClassDeclaration(node);
 }
 public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
 {
  if(file=="DataManagerPool.cs" || file=="ModelRegister.cs" || file=="----d-.cs")
  {
   var keep=selected.Contains(Token(node)??"") || node.Identifier.Text=="Dispose";
   if(file=="----d-.cs" && new[]{"_0090_00A2Y_00B2_00B4_0094","Â_0080TU_00BEn","Y_00A9cR_0088B","_00A5dWfk_0081"}.Contains(node.Identifier.Text))keep=true;
   if(!keep)return null;
  }
  return base.VisitMethodDeclaration(node);
 }
 public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
 {
  if(file is "DataManagerPool.cs" or "ModelRegister.cs")
   if(node.AccessorList==null || !node.AccessorList.Accessors.Any(a=>selected.Contains(Token(a)??"")))return null;
  return base.VisitPropertyDeclaration(node);
 }
}
