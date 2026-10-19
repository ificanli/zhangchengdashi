using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Cryptography;
using System.Text.Json;

var root=Path.GetFullPath(args[0]);
var input=Path.Combine(root,"outputs/OccupyCityRecovered/Assets/Scripts/Whinarn.UnityMeshSimplifier.Runtime/BrainFailProductions/PolyFew/UnityMeshSimplifier");
var output=Path.Combine(root,"work/constructor-tests/Generated");Directory.CreateDirectory(output);
var records=new List<object>();
foreach(var name in new[]{"BlendShape","BlendShapeFrame","BorderVertex","LODLevel","Vector3d"})
{
 var path=Path.Combine(input,name+".cs");var text=File.ReadAllText(path);var source=CSharpSyntaxTree.ParseText(text).GetCompilationUnitRoot();
 var type=source.DescendantNodes().OfType<StructDeclarationSyntax>().Single(t=>t.Identifier.ValueText==name);
 var members=type.Members.Where(m=>m is FieldDeclarationSyntax or ConstructorDeclarationSyntax).ToArray();
 var fixture=type.WithBaseList(null).WithMembers(SyntaxFactory.List(members));
 var ns=SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("BrainFailProductions.PolyFew.UnityMeshSimplifier")).WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(fixture));
 var result=SyntaxFactory.CompilationUnit().WithUsings(source.Usings).WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(ns)).NormalizeWhitespace().ToFullString();
 File.WriteAllText(Path.Combine(output,name+".cs"),"// Test fixture: actual production fields and constructors only; unrelated methods excluded, not repaired.\n"+result);
 records.Add(new { source=path, sha256=Convert.ToHexString(SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(text))), constructors=members.OfType<ConstructorDeclarationSyntax>().Select(c=>new {signature=c.Identifier.ValueText+c.ParameterList,bodySha256=Convert.ToHexString(SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(c.Body!.ToFullString())))}).ToArray() });
}
File.WriteAllText(Path.Combine(root,"work/recovery-ledger/constructor-fixture-provenance.json"),JsonSerializer.Serialize(records,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine("Extracted actual fields and ten constructor bodies from five production source files.");
