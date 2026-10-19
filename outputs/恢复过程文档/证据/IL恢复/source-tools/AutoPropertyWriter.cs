using System.Text;
using System.Text.Json.Nodes;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

static class AutoPropertyWriter
{
    static string Hash(string text)=>Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
    static string FileHash(string path)=>Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path)));
    static string FullType(SyntaxNode node)
    {
        var ns=string.Join('.',node.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(n=>n.Name.ToString()));
        return (ns.Length==0?"":ns+".")+string.Join('+',node.Ancestors().OfType<TypeDeclarationSyntax>().Reverse().Select(t=>t.Identifier.ValueText));
    }
    static string Normalize(string name)=>name switch {"bool"=>"System.Boolean","int"=>"System.Int32","float"=>"System.Single","double"=>"System.Double","long"=>"System.Int64","uint"=>"System.UInt32","ulong"=>"System.UInt64","short"=>"System.Int16","ushort"=>"System.UInt16","byte"=>"System.Byte","sbyte"=>"System.SByte",_=>name};
    static string? Rva(AccessorDeclarationSyntax accessor)=>accessor.AttributeLists.SelectMany(l=>l.Attributes).Where(a=>a.Name.ToString().EndsWith("Address"))
        .SelectMany(a=>a.ArgumentList?.Arguments??default).FirstOrDefault(a=>a.NameEquals?.Name.Identifier.ValueText=="RVA")?.Expression is LiteralExpressionSyntax literal?literal.Token.ValueText:null;
    static PropertyDeclarationSyntax Find(string text,JsonNode proof)
    {
        var matches=CSharpSyntaxTree.ParseText(text).GetRoot().DescendantNodes().OfType<PropertyDeclarationSyntax>()
            .Where(p=>FullType(p)==proof["type"]!.GetValue<string>()&&p.Identifier.ValueText==proof["property"]!.GetValue<string>()).ToArray();
        if(matches.Length!=1)throw new Exception("Property type/name is not unique");
        var property=matches[0];
        if(Normalize(property.Type.ToString())!=proof["fieldType"]!.GetValue<string>())throw new Exception("Property type mismatch");
        foreach(var kind in new[]{"getter","setter"})
        {
            var node=property.AccessorList?.Accessors.SingleOrDefault(a=>a.Keyword.ValueText==(kind=="getter"?"get":"set"));
            if(node==null||!string.Equals(Rva(node),proof[kind]!["Address"]!.GetValue<string>(),StringComparison.OrdinalIgnoreCase))throw new Exception(kind+" RVA mismatch");
        }
        return property;
    }
    public static void Run(string workspace,string mode)
    {
        var work=Path.Combine(workspace,"work/il-recovery/source-injection");
        var auditPath=Path.Combine(workspace,"work/il-recovery/autoproperty-audit");
        var scripts=Path.Combine(workspace,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp");
        var options=new System.Text.Json.JsonSerializerOptions{WriteIndented=true};
        if(mode=="auto-plan")
        {
            var audit=JsonNode.Parse(File.ReadAllText(Path.Combine(auditPath,"autoproperty-audit.json")))!.AsArray();
            var entries=new JsonArray();var blocked=new JsonArray();
            foreach(var proof in audit.Where(p=>p!["status"]!.GetValue<string>()=="both-native-accessors-proven"))
            {
                try
                {
                    string path=Path.Combine(scripts,proof!["type"]!.GetValue<string>().Split('+')[0].Replace('.',Path.DirectorySeparatorChar)+".cs");
                    string text=File.ReadAllText(path);var property=Find(text,proof);
                    if(property.Initializer!=null||property.ExpressionBody!=null||property.Modifiers.Any(t=>t.IsKind(SyntaxKind.StaticKeyword)||t.IsKind(SyntaxKind.VirtualKeyword)||t.IsKind(SyntaxKind.OverrideKeyword)||t.IsKind(SyntaxKind.AbstractKeyword)))
                        throw new Exception("Initializer/static/explicit virtual property requires separate review");
                    if(property.DescendantNodesAndSelf().OfType<AttributeSyntax>().Any(a=>a.Name.ToString().Contains("Serialize")))throw new Exception("Serialization attribute requires separate preservation");
                    foreach(var accessor in property.AccessorList!.Accessors)
                    {
                        if(accessor.Body==null)throw new Exception("Accessor no longer has a placeholder block");
                        if(accessor.IsKind(SyntaxKind.SetAccessorDeclaration)&&accessor.Body.Statements.Count!=0)throw new Exception("Setter has existing logic");
                        if(accessor.IsKind(SyntaxKind.GetAccessorDeclaration)&&!(accessor.Body.Statements.Count==1&&accessor.Body.Statements[0] is ReturnStatementSyntax {Expression:LiteralExpressionSyntax expression}&&expression.IsKind(SyntaxKind.DefaultLiteralExpression)))throw new Exception("Getter has existing logic");
                    }
                    string oldProperty=text[property.Span.Start..property.Span.End];string newProperty=oldProperty;
                    foreach(var accessor in property.AccessorList.Accessors.OrderByDescending(a=>a.SpanStart))
                    {
                        int start=accessor.Keyword.Span.End-property.Span.Start;int end=accessor.Body!.Span.End-property.Span.Start;
                        newProperty=newProperty[..start]+";"+newProperty[end..];
                    }
                    if(SyntaxFactory.ParseMemberDeclaration(newProperty)?.ContainsDiagnostics!=false)throw new Exception("Generated auto-property has invalid syntax");
                    entries.Add(new JsonObject{["sourcePath"]=path,["sourceFileHashBefore"]=Hash(text),["metaHash"]=FileHash(path+".meta"),["propertyStart"]=property.Span.Start,["propertyLength"]=property.Span.Length,["oldProperty"]=oldProperty,["newProperty"]=newProperty,["proof"]=proof.DeepClone()});
                }
                catch(Exception error){blocked.Add(new JsonObject{["type"]=proof!["type"]!.DeepClone(),["property"]=proof["property"]!.DeepClone(),["reason"]=error.Message});}
            }
            File.WriteAllText(Path.Combine(work,"auto-plan.json"),new JsonObject{["entries"]=entries,["blocked"]=blocked}.ToJsonString(options));
            Console.WriteLine($"AUTO_PLAN properties={entries.Count} accessors={entries.Count*2} blocked={blocked.Count}");
        }
        string planFile=mode=="auto-readback"?"auto-plan-applied.json":"auto-plan.json";
        var plan=JsonNode.Parse(File.ReadAllText(Path.Combine(work,planFile)))!;var plans=plan["entries"]!.AsArray();
        if(mode=="auto-apply")
        {
            var validation=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"auto-preflight/sample-validation.json")))!;
            if(validation["statuses"]?["passed"]?.GetValue<int>()!=plans.Count*2)throw new Exception("All accessor preflight cases must pass");
            foreach(var entry in plans)if(Hash(File.ReadAllText(entry!["sourcePath"]!.GetValue<string>()))!=entry["sourceFileHashBefore"]!.GetValue<string>())throw new Exception("Concurrent source change: "+entry["sourcePath"]);
            foreach(var group in plans.GroupBy(p=>p!["sourcePath"]!.GetValue<string>()))
            {
                var bytes=File.ReadAllBytes(group.Key);string text=File.ReadAllText(group.Key);
                foreach(var entry in group.OrderByDescending(p=>p!["propertyStart"]!.GetValue<int>()))
                {
                    int start=entry!["propertyStart"]!.GetValue<int>(),length=entry["propertyLength"]!.GetValue<int>();
                    text=text[..start]+entry["newProperty"]!.GetValue<string>()+text[(start+length)..];
                }
                File.WriteAllText(group.Key,text,new UTF8Encoding(bytes.Length>=3&&bytes[0]==0xEF&&bytes[1]==0xBB&&bytes[2]==0xBF));
                foreach(var entry in group)
                {
                    if(FileHash(group.Key+".meta")!=entry!["metaHash"]!.GetValue<string>())throw new Exception("GUID changed");
                    entry["sourceFileHashAfter"]=Hash(text);
                }
            }
            File.WriteAllText(Path.Combine(work,"auto-plan-applied.json"),plan.ToJsonString(options));
            Console.WriteLine($"AUTO_APPLIED properties={plans.Count} accessors={plans.Count*2} files={plans.Select(p=>p!["sourcePath"]!.GetValue<string>()).Distinct().Count()}");
        }
        if(mode is "auto-plan" or "auto-readback")
        {
            var fixture=Path.Combine(work,mode=="auto-plan"?"auto-preflight":"auto-readback");Directory.CreateDirectory(fixture);
            var nativeGolden=JsonNode.Parse(File.ReadAllText(Path.Combine(auditPath,"sample-native-golden.json")))!.AsArray();
            var sources=new StringBuilder("using System;\nusing System.Runtime.CompilerServices;\nusing Il2CppDummyDll;\n");
            var manifest=new JsonArray();var golden=new JsonArray();int propertyIndex=0;
            foreach(var entry in plans)
            {
                var proof=entry!["proof"]!;string propertyText=entry["newProperty"]!.GetValue<string>();
                if(mode=="auto-readback")
                {
                    string text=File.ReadAllText(entry["sourcePath"]!.GetValue<string>());propertyText=Find(text,proof).ToString();
                    if(Hash(propertyText)!=Hash(entry["newProperty"]!.GetValue<string>()))throw new Exception("Auto-property readback mismatch");
                    entry["readbackProperty"]=propertyText;entry["readbackPropertyHash"]=Hash(propertyText);entry["readbackSourceFileHash"]=Hash(text);
                    foreach(var kind in new[]{"getter","setter"})
                    {
                        var native=proof[kind]!;
                        entry[kind+"NativeDisassembly"]=File.ReadAllText(Path.Combine(auditPath,proof["type"]!.GetValue<string>()+"."+native["MethodName"]!.GetValue<string>()+".native.txt"));
                    }
                    if(File.Exists(Path.Combine(fixture,"sample-validation.json")))
                    {
                        var verified=JsonNode.Parse(File.ReadAllText(Path.Combine(fixture,"sample-validation.json")))!["results"]!.AsArray();
                        foreach(var kind in new[]{"getter","setter"})
                            entry[kind+"CompiledVerification"]=verified.Single(v=>v!["method"]!.GetValue<string>()==proof[kind]!["Method"]!.GetValue<string>())!.DeepClone();
                    }
                }
                string fixtureType=$"RecoveredProperty_{propertyIndex++:000}";
                sources.AppendLine($"public class {fixtureType}\n{{\n{propertyText}\n}}");
                foreach(var kind in new[]{"getter","setter"})
                {
                    var sample=proof[kind]!.DeepClone();var originalMethod=sample["Method"]!.GetValue<string>();
                    sample["TypeName"]=fixtureType;sample["FieldDeclaringType"]=fixtureType;manifest.Add(sample);
                    var oracle=nativeGolden.Single(g=>g!["method"]!.GetValue<string>()==originalMethod)!.DeepClone();oracle["index"]=golden.Count;golden.Add(oracle);
                }
            }
            File.WriteAllText(Path.Combine(fixture,"ActualProperties.cs"),sources.ToString());
            string attributes=Path.Combine(workspace,"work/il2cpp-dump-decoded/DummyDll/Il2CppDummyDll.dll");
            File.WriteAllText(Path.Combine(fixture,"ActualProperties.csproj"),$"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><AssemblyName>Assembly-CSharp</AssemblyName></PropertyGroup><ItemGroup><Reference Include=\"Il2CppDummyDll\"><HintPath>{attributes}</HintPath></Reference></ItemGroup></Project>");
            File.WriteAllText(Path.Combine(fixture,"sample-manifest.json"),manifest.ToJsonString(options));File.WriteAllText(Path.Combine(fixture,"sample-native-golden.json"),golden.ToJsonString(options));
            if(mode=="auto-readback")File.WriteAllText(Path.Combine(work,"auto-source-provenance.json"),plan.ToJsonString(options));
            Console.WriteLine($"AUTO_FIXTURE mode={mode} properties={plans.Count} accessors={manifest.Count}");
        }
    }
}
