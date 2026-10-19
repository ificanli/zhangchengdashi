using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
var workspace=Path.GetFullPath(args[0]);
var work=Path.Combine(workspace,"work/stage33-time");
var project=Path.Combine(workspace,"outputs/OccupyCityRecovered");
var plan=JsonSerializer.Deserialize<Plan>(File.ReadAllText(Path.Combine(work,"write-plan.json")))!;
var records=new List<object>();
foreach(var file in plan.files)
{
    var path=Path.Combine(project,file.path);
    var before=File.ReadAllText(path);
    var rw=new Writer(file);
    var root=rw.Visit(CSharpSyntaxTree.ParseText(before).GetRoot())!;
    var after=root.ToFullString();
    if(rw.count!=file.methods.Count || rw.properties!=file.autoProperties.Length)throw new Exception("Mismatch selected count");
    var errors=CSharpSyntaxTree.ParseText(after).GetDiagnostics().Where(d=>d.Severity==DiagnosticSeverity.Error).ToArray();
    if(errors.Length>0)throw new Exception(string.Join("\n",errors.Select(x=>x.ToString())));
    var target=Path.Combine(work,"candidate",file.path);
    Directory.CreateDirectory(Path.GetDirectoryName(target)!);
    File.WriteAllText(target,after,new System.Text.UTF8Encoding(false));
    var origin=Path.Combine(work,"before",file.path);
    Directory.CreateDirectory(Path.GetDirectoryName(origin)!);
    File.Copy(path,origin,true);
    records.Add(new{file=file.path,methods=rw.count,autoProperties=rw.properties,addedOriginalCctor=file.addHelper!=null,
        beforeSha256=Hash(before),candidateSha256=Hash(after),metaSha256=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path+".meta")))});
}
File.WriteAllText(Path.Combine(work,"candidate-manifest.json"),JsonSerializer.Serialize(records,new JsonSerializerOptions{WriteIndented=true}));
Console.WriteLine(JsonSerializer.Serialize(records));
static string Hash(string s)=>Convert.ToHexString(SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(s)));
sealed class Plan{public List<FilePlan> files{get;set;}=[];}
sealed class FilePlan{public string path{get;set;}="";public List<MethodPlan> methods{get;set;}=[];public string[] autoProperties{get;set;}=[];public string? helperClassToken{get;set;}public string? addHelper{get;set;}}
sealed class MethodPlan{public string token{get;set;}="";public string body{get;set;}="";public bool makeAsync{get;set;}public bool iterator{get;set;}}
sealed class Writer(FilePlan p):CSharpSyntaxRewriter
{
 public int count,properties;
 static uint? Token(SyntaxList<AttributeListSyntax> attrs){var m=Regex.Match(attrs.ToFullString(),"Token\\s*=\\s*\"(0x[0-9A-Fa-f]+)\"");return m.Success?Convert.ToUInt32(m.Groups[1].Value[2..],16):null;}
 MethodPlan? Get(SyntaxList<AttributeListSyntax> attrs)=>p.methods.SingleOrDefault(m=>Convert.ToUInt32(m.token[2..],16)==Token(attrs));
 static void Verify(BlockSyntax? body,string token){if(body==null || body.Statements.Any(s=>s is not ReturnStatementSyntax) || body.Statements.Count>1)throw new Exception("Nonstub "+token);}
 static SyntaxList<AttributeListSyntax> Clean(SyntaxList<AttributeListSyntax> attrs)=>SyntaxFactory.List(attrs.Select(g=>g.WithAttributes(SyntaxFactory.SeparatedList(g.Attributes.Where(a=>!a.Name.ToString().EndsWith("AsyncStateMachine")&&!a.Name.ToString().EndsWith("IteratorStateMachine"))))).Where(g=>g.Attributes.Count>0));
 public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
 {
  var m=Get(node.AttributeLists);if(m==null)return base.VisitMethodDeclaration(node);Verify(node.Body,m.token);
  var result=node.WithBody(((BlockSyntax)SyntaxFactory.ParseStatement(m.body)).NormalizeWhitespace().WithTriviaFrom(node.Body!));
  if(m.makeAsync)result=result.WithModifiers(result.Modifiers.Add(SyntaxFactory.Token(SyntaxKind.AsyncKeyword).WithTrailingTrivia(SyntaxFactory.Space)));
  if(m.makeAsync||m.iterator)result=result.WithAttributeLists(Clean(result.AttributeLists));
  count++;return result;
 }
 public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
 {
  var m=Get(node.AttributeLists);if(m==null)return base.VisitConstructorDeclaration(node);Verify(node.Body,m.token);count++;
  return node.WithBody(((BlockSyntax)SyntaxFactory.ParseStatement(m.body)).NormalizeWhitespace().WithTriviaFrom(node.Body!));
 }
 public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
 {
  if(!p.autoProperties.Any(s=>Convert.ToUInt32(s[2..],16)==Token(node.AttributeLists)))return base.VisitPropertyDeclaration(node);
  if(node.AccessorList==null)throw new Exception("No accessors");
  properties++;
  return node.WithAccessorList(node.AccessorList.WithAccessors(SyntaxFactory.List(node.AccessorList.Accessors.Select(a=>a.WithBody(null).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))))));
 }
 public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
 {
  var r=(ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
  if(p.addHelper!=null&&p.helperClassToken!=null&&Token(node.AttributeLists)==Convert.ToUInt32(p.helperClassToken[2..],16))
   r=r.AddMembers((SyntaxFactory.ParseMemberDeclaration(p.addHelper)??throw new Exception("Helper parse")).NormalizeWhitespace().WithLeadingTrivia(SyntaxFactory.EndOfLine("\r\n")));
  return r;
 }
}
