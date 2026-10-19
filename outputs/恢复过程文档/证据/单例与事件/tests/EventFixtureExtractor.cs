using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

static class EventFixtureExtractor
{
    public static void Run(string workspace,bool negativeControl)
    {
        string sourcePath=Path.Combine(workspace,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/EventModule/EventManager.cs");
        string source=File.ReadAllText(sourcePath);
        var type=CSharpSyntaxTree.ParseText(source).GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>().Single(c=>c.Identifier.ValueText=="EventManager");
        var required=new Dictionary<string,string>{{"Init","0x3F11934"},{"StartListening","0x3F07F3C"},{"StopListening","0x3F05D94"},{"StartListeningOnce","0x3F119B4"},{"StopListeningOnce","0x3F11B48"},{"TriggerEvent","0x3F05F64"}};
        var parts=new List<MemberDeclarationSyntax>();var provenance=new List<object>();
        foreach(var field in type.Members.OfType<FieldDeclarationSyntax>())
        {
            var copy=field.WithAttributeLists(default);
            if(negativeControl)copy=copy.WithDeclaration(copy.Declaration.WithVariables(SyntaxFactory.SeparatedList(copy.Declaration.Variables.Select(v=>v.WithInitializer(null)))));
            parts.Add(copy);
            provenance.Add(new{kind="field",source=field.ToString(),sha256=Hash(field.ToString())});
        }
        foreach(var method in type.Members.OfType<MethodDeclarationSyntax>().Where(m=>required.ContainsKey(m.Identifier.ValueText)))
        {
            var rva=method.AttributeLists.SelectMany(a=>a.Attributes).Where(a=>a.Name.ToString().EndsWith("Address")).SelectMany(a=>a.ArgumentList!.Arguments)
                .Single(a=>a.NameEquals?.Name.Identifier.ValueText=="RVA").Expression.ToString().Trim('"');
            if(!rva.Equals(required[method.Identifier.ValueText],StringComparison.OrdinalIgnoreCase))throw new Exception("Event RVA mismatch");
            var copy=method.WithAttributeLists(default).WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));
            if(negativeControl&&method.Identifier.ValueText!="Init")copy=copy.WithBody(SyntaxFactory.Block());
            parts.Add(copy);
            provenance.Add(new{kind="method",name=method.Identifier.ValueText,rva,body=method.Body!.ToString(),bodySha256=Hash(method.Body.ToString()),signature=method.ParameterList.ToString()});
        }
        var constructor=type.Members.OfType<ConstructorDeclarationSyntax>().Single();
        parts.Add(constructor.WithAttributeLists(default).WithIdentifier(SyntaxFactory.Identifier("EventManagerFixture")));
        provenance.Add(new{kind="constructor",body=constructor.Body!.ToString(),bodySha256=Hash(constructor.Body.ToString()),note="Exact source field initializers execute before base construction"});
        var fixture=SyntaxFactory.ClassDeclaration("EventManagerFixture").WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword))).WithMembers(SyntaxFactory.List(parts));
        string folder=Path.Combine(workspace,"work/event-recovery",negativeControl?"control":"tests");Directory.CreateDirectory(folder);
        File.WriteAllText(Path.Combine(folder,"ActualEventMethods.cs"),"using System;\nusing System.Collections.Generic;\nusing Cysharp.Threading.Tasks;\n"+fixture.NormalizeWhitespace().ToFullString());
        string unitask=Path.Combine(workspace,"outputs/OccupyCityRecovered/Library/ScriptAssemblies/UniTask.dll");
        File.WriteAllText(Path.Combine(folder,"EventTests.csproj"),$"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><OutputType>Exe</OutputType></PropertyGroup><ItemGroup><Reference Include=\"UniTask\"><HintPath>{unitask}</HintPath></Reference></ItemGroup></Project>");
        File.WriteAllText(Path.Combine(folder,"source-provenance.json"),JsonSerializer.Serialize(new{sourcePath,sourceSha256=Hash(source),negativeControl,entries=provenance},new JsonSerializerOptions{WriteIndented=true}));
        Console.WriteLine($"EVENT_EXTRACT methods={required.Count} fields={type.Members.OfType<FieldDeclarationSyntax>().Count()} negativeControl={negativeControl}");
    }
    static string Hash(string text)=>Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
}
