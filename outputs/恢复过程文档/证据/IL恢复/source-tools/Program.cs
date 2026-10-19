using System.Text;
using System.Text.Json.Nodes;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

if(args.Length!=2)throw new ArgumentException("workspace-root plan|apply|readback");
var workspace=Path.GetFullPath(args[0]);
var mode=args[1];
if(mode.StartsWith("auto-")){AutoPropertyWriter.Run(workspace,mode);return;}
var scripts=Path.Combine(workspace,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp");
var work=Path.Combine(workspace,"work/il-recovery/source-injection");
Directory.CreateDirectory(work);
var manifest=JsonNode.Parse(File.ReadAllText(Path.Combine(workspace,"work/il-recovery/sample100-probe/sample-manifest.json")))!.AsArray();
var validation=JsonNode.Parse(File.ReadAllText(Path.Combine(workspace,"work/il-recovery/sample100-probe/sample-validation.json")))!["results"]!.AsArray();
var jsonOptions=new System.Text.Json.JsonSerializerOptions {WriteIndented=true};
var aliases=new Dictionary<string,string>{{"bool","System.Boolean"},{"byte","System.Byte"},{"sbyte","System.SByte"},{"short","System.Int16"},{"ushort","System.UInt16"},{"int","System.Int32"},{"uint","System.UInt32"},{"long","System.Int64"},{"ulong","System.UInt64"},{"float","System.Single"},{"double","System.Double"},{"void","System.Void"}};
string Norm(string name)=>aliases.GetValueOrDefault(name,name);
string Hash(string text)=>Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text)));
string FileHash(string path)=>Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path)));
string PathFor(string type)=>Path.Combine(scripts,type.Split('+')[0].Replace('.',Path.DirectorySeparatorChar)+".cs");
string TypeName(SyntaxNode node)
{
    var names=node.Ancestors().OfType<TypeDeclarationSyntax>().Reverse().Select(t=>t.Identifier.ValueText);
    var ns=string.Join('.',node.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(n=>n.Name.ToString()));
    return (ns.Length==0?"":ns+".")+string.Join('+',names);
}
string? Rva(SyntaxNode node)
{
    var attributes=node is AccessorDeclarationSyntax a?a.AttributeLists:((MethodDeclarationSyntax)node).AttributeLists;
    return attributes.SelectMany(a=>a.Attributes).Where(a=>a.Name.ToString().EndsWith("Address")).SelectMany(a=>a.ArgumentList?.Arguments??default)
        .FirstOrDefault(a=>a.NameEquals?.Name.Identifier.ValueText=="RVA")?.Expression is LiteralExpressionSyntax value?value.Token.ValueText:null;
}
SyntaxNode Find(JsonNode sample,string text)
{
    var root=CSharpSyntaxTree.ParseText(text).GetRoot();
    var candidates=root.DescendantNodes().Where(n=>n is AccessorDeclarationSyntax or MethodDeclarationSyntax)
        .Where(n=>TypeName(n)==sample["TypeName"]!.GetValue<string>() && string.Equals(Rva(n),sample["Address"]!.GetValue<string>(),StringComparison.OrdinalIgnoreCase)).ToArray();
    if(candidates.Length!=1)throw new Exception($"RVA/type match count={candidates.Length}");
    var candidate=candidates[0];
    string methodName,returnType;string[] parameters;bool isStatic;
    if(candidate is AccessorDeclarationSyntax accessor)
    {
        var property=(PropertyDeclarationSyntax)accessor.Parent!.Parent!;
        methodName=accessor.Keyword.ValueText+"_"+property.Identifier.ValueText;
        returnType=accessor.IsKind(SyntaxKind.GetAccessorDeclaration)?Norm(property.Type.ToString()):"System.Void";
        parameters=accessor.IsKind(SyntaxKind.SetAccessorDeclaration)?[Norm(property.Type.ToString())]:[];
        isStatic=property.Modifiers.Any(SyntaxKind.StaticKeyword);
    }
    else
    {
        var method=(MethodDeclarationSyntax)candidate;
        methodName=method.Identifier.ValueText;
        returnType=Norm(method.ReturnType.ToString());
        parameters=method.ParameterList.Parameters.Select(p=>Norm(p.Type!.ToString())).ToArray();
        isStatic=method.Modifiers.Any(SyntaxKind.StaticKeyword);
    }
    if(methodName!=sample["MethodName"]!.GetValue<string>() ||returnType!=sample["ReturnType"]!.GetValue<string>()
        ||isStatic!=sample["IsStatic"]!.GetValue<bool>() ||!parameters.SequenceEqual(sample["ParameterTypes"]!.AsArray().Select(p=>p!.GetValue<string>())))
        throw new Exception("Source signature does not match native metadata");
    return candidate;
}
BlockSyntax Body(SyntaxNode node)=>node is AccessorDeclarationSyntax a?a.Body??throw new Exception("Accessor has no block"):((MethodDeclarationSyntax)node).Body??throw new Exception("Method has no block");
string[] ParameterNames(SyntaxNode node)=>node is AccessorDeclarationSyntax a?(a.IsKind(SyntaxKind.SetAccessorDeclaration)?["value"]:[]):((MethodDeclarationSyntax)node).ParameterList.Parameters.Select(p=>p.Identifier.Text).ToArray();

if(mode=="plan")
{
    var entries=new JsonArray();var blocked=new JsonArray();
    foreach(var result in validation.Where(r=>r!["status"]!.GetValue<string>()=="passed"))
    {
        int index=result!["index"]!.GetValue<int>();var sample=manifest[index]!;
        try
        {
            string path=PathFor(sample["TypeName"]!.GetValue<string>());
            string text=File.ReadAllText(path);var node=Find(sample,text);var oldBody=Body(node);
            if(oldBody.Statements.Count!=0 && !(oldBody.Statements.Count==1 && oldBody.Statements[0] is ReturnStatementSyntax {Expression: LiteralExpressionSyntax expression} && expression.IsKind(SyntaxKind.DefaultLiteralExpression)))
                throw new Exception("Existing body is not a placeholder; preserve it");
            string? field=sample["FieldName"]?.GetValue<string>();string? sourceFieldType=null;
            if(field!=null)
            {
                var declaring=sample["FieldDeclaringType"]!.GetValue<string>();
                var fieldRoot=CSharpSyntaxTree.ParseText(File.ReadAllText(PathFor(declaring))).GetRoot();
                var declarations=fieldRoot.DescendantNodes().OfType<FieldDeclarationSyntax>().Where(f=>TypeName(f)==declaring)
                    .SelectMany(f=>f.Declaration.Variables.Where(v=>v.Identifier.ValueText==field).Select(v=>(Field:f,Variable:v))).ToArray();
                if(declarations.Length!=1)throw new Exception($"Field missing/ambiguous in original source: {declaring}.{field}");
                sourceFieldType=declarations[0].Field.Declaration.Type.ToString();
                if(Norm(sourceFieldType)!=sample["FieldType"]!.GetValue<string>())throw new Exception("Field type mismatch");
                field=declarations[0].Variable.Identifier.Text;
            }
            string decompiled=File.ReadAllText(Path.Combine(work,"decompiled",$"{index:000}.cs"));
            int start=decompiled.IndexOf('{');int end=decompiled.LastIndexOf('}');
            if(start<0||end<start)throw new Exception("Decompiler did not return a body");
            string rawBody=decompiled[start..(end+1)];
            if(SyntaxFactory.ParseStatement(rawBody) is not BlockSyntax parsed ||parsed.ContainsDiagnostics)throw new Exception("Decompiler body contains syntax errors");
            string newline=text.Contains("\r\n")?"\r\n":"\n";
            int lineStart=text.LastIndexOf('\n',oldBody.SpanStart)+1;
            string indent=text[lineStart..oldBody.SpanStart];
            var bodyLines=rawBody.Split('\n').Skip(1).SkipLast(1).Select(line=>line.TrimEnd('\r')).ToArray();
            int common=bodyLines.Where(l=>l.Trim().Length>0).Select(l=>l.TakeWhile(char.IsWhiteSpace).Count()).DefaultIfEmpty(0).Min();
            string newBody="{"+newline+string.Join(newline,bodyLines.Select(l=>indent+"\t"+(l.Length>=common?l[common..]:"")))+newline+indent+"}";
            var entry=new JsonObject { ["index"]=index,["method"]=sample["Method"]!.GetValue<string>(),["sourcePath"]=path,["sourceFileHashBefore"]=Hash(text),["metaHash"]=FileHash(path+".meta"),["bodyStart"]=oldBody.SpanStart,["bodyLength"]=oldBody.Span.Length,["oldBody"]=oldBody.ToString(),["newBody"]=newBody,["sourceField"]=field,["sourceFieldType"]=sourceFieldType,["parameterNames"]=new JsonArray(ParameterNames(node).Select(x => (JsonNode?)JsonValue.Create(x)).ToArray()),["native"]=sample.DeepClone(),["validation"]=result.DeepClone()};
            entries.Add(entry);
        }
        catch(Exception error){blocked.Add(new JsonObject {["index"]=index,["method"]=sample["Method"]!.GetValue<string>(),["reason"]=error.Message});}
    }
    var plan=new JsonObject {["entries"]=entries,["blocked"]=blocked};
    File.WriteAllText(Path.Combine(work,"source-plan.json"),plan.ToJsonString(jsonOptions));
    Console.WriteLine($"SOURCE_PLAN writable={entries.Count} blocked={blocked.Count}");
}
var planFile=mode=="readback"&&File.Exists(Path.Combine(work,"source-plan-applied.json"))?"source-plan-applied.json":"source-plan.json";
var planNode=JsonNode.Parse(File.ReadAllText(Path.Combine(work,planFile)))!;
var plans=planNode["entries"]!.AsArray();
if(mode=="apply")
{
    if(!File.Exists(Path.Combine(work,"preflight", "sample-validation.json")))throw new Exception("Preflight validation is missing");
    var accepted=JsonNode.Parse(File.ReadAllText(Path.Combine(work,"preflight","sample-validation.json")))!;
    if(accepted["statuses"]?["passed"]?.GetValue<int>()!=plans.Count)throw new Exception("Preflight did not pass every planned method");
    foreach(var entry in plans)
        if(Hash(File.ReadAllText(entry!["sourcePath"]!.GetValue<string>()))!=entry["sourceFileHashBefore"]!.GetValue<string>())
            throw new Exception("Concurrent source edit before batch: "+entry["sourcePath"]);
    foreach(var group in plans.GroupBy(p=>p!["sourcePath"]!.GetValue<string>()))
    {
        var bytes=File.ReadAllBytes(group.Key);string text=File.ReadAllText(group.Key);
        if(group.Any(p=>p!["sourceFileHashBefore"]!.GetValue<string>()!=Hash(text)))throw new Exception("Concurrent source edit: "+group.Key);
        foreach(var entry in group.OrderByDescending(p=>p!["bodyStart"]!.GetValue<int>()))
        {
            int start=entry!["bodyStart"]!.GetValue<int>(),length=entry["bodyLength"]!.GetValue<int>();
            text=text[..start]+entry["newBody"]!.GetValue<string>()+text[(start+length)..];
        }
        File.WriteAllText(group.Key,text,new UTF8Encoding(bytes.Length>=3&&bytes[0]==0xEF&&bytes[1]==0xBB&&bytes[2]==0xBF));
        foreach(var entry in group)
        {
            if(FileHash(group.Key+".meta")!=entry!["metaHash"]!.GetValue<string>())throw new Exception("Script GUID file changed");
            entry["sourceFileHashAfter"]=Hash(text);
        }
    }
    File.WriteAllText(Path.Combine(work,"source-plan-applied.json"),planNode.ToJsonString(jsonOptions));
    Console.WriteLine($"SOURCE_APPLIED methods={plans.Count} files={plans.Select(p=>p!["sourcePath"]!.GetValue<string>()).Distinct().Count()}");
}
if(mode is "plan" or "readback")
{
    var fixture=Path.Combine(work,mode=="plan"?"preflight":"readback");Directory.CreateDirectory(fixture);
    var sources=new StringBuilder("using System;\n");var fixtureManifest=new JsonArray();var fixtureGolden=new JsonArray();
    var nativeGolden=JsonNode.Parse(File.ReadAllText(Path.Combine(workspace,"work/il-recovery/sample100-probe/sample-native-golden.json")))!.AsArray();
    int fixtureIndex=0;
    foreach(var entry in plans)
    {
        int index=entry!["index"]!.GetValue<int>();var sample=manifest[index]!;string body=entry["newBody"]!.GetValue<string>();
        if(mode=="readback")
        {
            string text=File.ReadAllText(entry["sourcePath"]!.GetValue<string>());var node=Find(sample,text);body=Body(node).ToString();
            if(Hash(body)!=Hash(entry["newBody"]!.GetValue<string>()))throw new Exception("Readback body mismatch: "+entry["method"]);
            entry["readbackBodyHash"]=Hash(body);
            entry["readbackSourceBody"]=body;
            entry["readbackSourceFileHash"]=Hash(text);
            var dumpPrefix=sample["Method"]!.GetValue<string>().Replace("::",".");
            entry["nativeDisassembly"]=File.ReadAllText(Path.Combine(workspace,"work/il-recovery/sample100-probe",dumpPrefix+".native.txt"));
            entry["generatedIl"]=File.ReadAllText(Path.Combine(workspace,"work/il-recovery/sample100-probe",dumpPrefix+".cil.txt"));
            entry["generatedCSharp"]=File.ReadAllText(Path.Combine(work,"decompiled",$"{index:000}.cs"));
        }
        string typeName=$"RecoveredSample_{index:000}";var parameterNames=entry["parameterNames"]!.AsArray().Select(p=>p!.GetValue<string>()).ToArray();
        string parameters=string.Join(", ",sample["ParameterTypes"]!.AsArray().Select((p,i)=>p!.GetValue<string>()+" "+parameterNames[i]));
        sources.AppendLine($"public class {typeName} {{");
        if(entry["sourceField"]!=null)sources.AppendLine($"public {entry["sourceFieldType"]!.GetValue<string>()} {entry["sourceField"]!.GetValue<string>()};");
        sources.AppendLine($"public {(sample["IsStatic"]!.GetValue<bool>()?"static ":"")}{(sample["ReturnType"]!.GetValue<string>() == "System.Void" ? "void" : sample["ReturnType"]!.GetValue<string>())} Invoke({parameters}) {body}\n}}");
        var item=sample.DeepClone();item["TypeName"]=typeName;item["MethodName"]="Invoke";item["FieldDeclaringType"]=entry["sourceField"]==null?null:typeName;item["FieldName"]=entry["sourceField"]?.DeepClone();
        fixtureManifest.Add(item);var oracle=nativeGolden[index]!.DeepClone();oracle["index"]=fixtureIndex++;fixtureGolden.Add(oracle);
    }
    File.WriteAllText(Path.Combine(fixture,"ActualBodies.cs"),sources.ToString());
    File.WriteAllText(Path.Combine(fixture,"ActualBodies.csproj"),"<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><TargetFramework>net10.0</TargetFramework><AssemblyName>Assembly-CSharp</AssemblyName></PropertyGroup></Project>");
    File.WriteAllText(Path.Combine(fixture,"sample-manifest.json"),fixtureManifest.ToJsonString(jsonOptions));
    File.WriteAllText(Path.Combine(fixture,"sample-native-golden.json"),fixtureGolden.ToJsonString(jsonOptions));
    if(mode=="readback")File.WriteAllText(Path.Combine(work,"source-provenance.json"),planNode.ToJsonString(jsonOptions));
    Console.WriteLine($"SOURCE_FIXTURE mode={mode} methods={plans.Count}");
}

