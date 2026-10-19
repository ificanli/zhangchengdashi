using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var root=Path.GetFullPath(args[0]);var work=Path.Combine(root,"work/stage33-time");
Directory.CreateDirectory(Path.Combine(work,"fixture"));
foreach(var name in new[]{"TimeModuleO/TimeManager.cs","L_Tools/DateTools.cs"})
{
 var syntax=(CompilationUnitSyntax)CSharpSyntaxTree.ParseText(File.ReadAllText(Path.Combine(work,"candidate/Assets/Scripts/Assembly-CSharp",name))).GetRoot();
 syntax=syntax.WithUsings(SyntaxFactory.List(syntax.Usings.Where(u=>u.Name?.ToString() is not "Il2CppDummyDll" and not "Cysharp.Threading.Tasks.CompilerServices")));
 var result=new Strip().Visit(syntax)!;
 File.WriteAllText(Path.Combine(work,"fixture",Path.GetFileName(name)),result.ToFullString());
}
sealed class Strip:CSharpSyntaxRewriter
{
 public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)=>null;
 public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
 {
  if(node.Parent is ClassDeclarationSyntax c && c.Identifier.Text=="TimeManager" && node.Identifier.Text!="Timer")return null;
  return base.VisitClassDeclaration(node);
 }
 public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)=>null;
}
