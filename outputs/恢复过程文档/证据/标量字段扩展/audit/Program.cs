using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using AssetRipper.Primitives;
using Cpp2IL.Core;
using Cpp2IL.Core.Model.Contexts;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var root=Path.GetFullPath(".");var own=Path.Combine(root,"work/scalar-expansion");Directory.CreateDirectory(own);
var source=Path.Combine(root,"outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp");
new Cpp2IlCorePlugin().OnLoad();Cpp2IlApi.RuntimeOptions=new Cpp2IlRuntimeArgs{LowMemoryMode=true};Cpp2IlApi.InitializeLibCpp2Il(Path.Combine(root,"work/ida-input/libil2cpp-arm64.so"),Path.Combine(root,"work/metadata-probe/global-metadata.decoded.dat"),UnityVersion.Parse("2022.3.62f3"));
var app=Cpp2IlApi.CurrentAppContext;
if(args.Contains("field-attributes"))
{
 var plan=JsonDocument.Parse(File.ReadAllText(Path.Combine(own,"auto-property-plan.json")));var rows=new List<object>();
 foreach(var entry in plan.RootElement.EnumerateArray())
 {
  string owner=entry.GetProperty("type").GetString()!;uint token=Convert.ToUInt32(entry.GetProperty("fieldToken").GetString()![2..],16);
  var field=app.AllTypes.Single(t=>t.FullName==owner).Fields.Single(f=>f.Token==token);field.AnalyzeCustomAttributeData();
  string[] attributes=field.CustomAttributes?.Select(a=>a.Constructor.DeclaringType!.FullName).ToArray()??[];
  if(attributes.Any(a=>a!="System.Runtime.CompilerServices.CompilerGeneratedAttribute"&&a!="System.Diagnostics.DebuggerBrowsableAttribute"))throw new Exception("Extra backing-field attribute needs preservation: "+owner+"."+field.Name+" "+string.Join(',',attributes));
  rows.Add(new{type=owner,field=field.Name,token=$"0x{token:X8}",attributes});
 }
 File.WriteAllText(Path.Combine(own,"backingfield-attributes.json"),JsonSerializer.Serialize(rows,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine($"BACKING_FIELD_ATTRIBUTES proven={rows.Count} no extra serialization attributes");return;
}
var scalars=new Dictionary<string,(string opcode,string getter,string setter)> {
 ["System.Boolean"]=("B","W0","W1"),["System.Byte"]=("B","W0","W1"),["System.SByte"]=("B","W0","W1"),["System.Int16"]=("H","W0","W1"),["System.UInt16"]=("H","W0","W1"),["System.Int32"]=("","W0","W1"),["System.UInt32"]=("","W0","W1"),["System.Int64"]=("","X0","X1"),["System.UInt64"]=("","X0","X1"),["System.Single"]=("","S0","S0"),["System.Double"]=("","D0","D0")};
var aliases=new Dictionary<string,string>{{"bool","System.Boolean"},{"byte","System.Byte"},{"sbyte","System.SByte"},{"short","System.Int16"},{"ushort","System.UInt16"},{"int","System.Int32"},{"uint","System.UInt32"},{"long","System.Int64"},{"ulong","System.UInt64"},{"float","System.Single"},{"double","System.Double"}};
string Norm(string value)=>aliases.GetValueOrDefault(value,value);
string Sha(string path)=>Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(path)));
string PathFor(string type)=>Path.Combine(source,type.Split('+')[0].Replace('.',Path.DirectorySeparatorChar)+".cs");
var excluded=new HashSet<string>{"CoreModule.GameLauncher","L_Tools.Singleton","QuickTutor.Singleton","LocalizationModule.Runtime.CustomBundlesManager","AssetsModule.AssetsManager","LoadingModule.LoadingManager","ljzs_lt.Procedure.ProcedurePreLoad","ljzs_lt.Procedure.ProcedureStarGame","L_Tools.LoginControl","CommonGameModule.Login.LoginProcedureBase"};
string Owner(SyntaxNode node) {var ns=string.Join('.',node.Ancestors().OfType<BaseNamespaceDeclarationSyntax>().Reverse().Select(n=>n.Name));return (ns.Length>0?ns+".":"")+string.Join('+',node.Ancestors().OfType<TypeDeclarationSyntax>().Reverse().Select(t=>t.Identifier.ValueText));}
SyntaxList<AttributeListSyntax> Attrs(SyntaxNode node)=>node switch{AccessorDeclarationSyntax a=>a.AttributeLists,PropertyDeclarationSyntax p=>p.AttributeLists,FieldDeclarationSyntax f=>f.AttributeLists,_=>default};
string? Token(SyntaxNode node)=>Attrs(node).SelectMany(a=>a.Attributes).Where(a=>a.Name.ToString().EndsWith("Token")).SelectMany(a=>a.ArgumentList?.Arguments??default).FirstOrDefault(a=>a.NameEquals?.Name.Identifier.ValueText=="Token")?.Expression is LiteralExpressionSyntax value?value.Token.ValueText:null;
string? Rva(AccessorDeclarationSyntax node)=>node.AttributeLists.SelectMany(a=>a.Attributes).Where(a=>a.Name.ToString().EndsWith("Address")).SelectMany(a=>a.ArgumentList?.Arguments??default).FirstOrDefault(a=>a.NameEquals?.Name.Identifier.ValueText=="RVA")?.Expression is LiteralExpressionSyntax value?value.Token.ValueText:null;
bool TokEq(string? token,uint native)=>token!=null&&Convert.ToUInt32(token[2..],16)==native;
bool Placeholder(AccessorDeclarationSyntax a)=>a.Body!=null&&(a.IsKind(SyntaxKind.SetAccessorDeclaration)?a.Body.Statements.Count==0:a.Body.Statements.Count==1&&a.Body.Statements[0] is ReturnStatementSyntax{Expression:LiteralExpressionSyntax lit}&&lit.IsKind(SyntaxKind.DefaultLiteralExpression));
var documents=new Dictionary<string,(string text,SyntaxNode root)>();
(string text,SyntaxNode root) Document(string path) {if(!documents.TryGetValue(path,out var doc)){string text=File.ReadAllText(path);doc=(text,CSharpSyntaxTree.ParseText(text).GetRoot());documents[path]=doc;}return doc;}
var native=new List<Proof>();var rejected=new List<object>();
foreach(var type in app.Assemblies.Single(a=>a.Name=="Assembly-CSharp").Types)
{
 if(type.IsValueType||type.GenericParameters.Count!=0||type.FullName.Contains('<')||excluded.Contains(type.FullName.Split('+')[0]))continue;
 foreach(var method in type.Methods)
 {
  bool getter=method.Name.StartsWith("get_");bool setter=method.Name.StartsWith("set_");
  if(!getter&&!setter||method.IsStatic||method.IsAbstract||method.GenericParameters.Count!=0||method.UnderlyingPointer==0)continue;
  string valueType=getter?method.ReturnType.FullName:method.Parameters.Count==1&&method.IsVoid?method.Parameters[0].ParameterType.FullName:"";
  if(!scalars.TryGetValue(valueType,out var spec)||getter&&method.Parameters.Count!=0)continue;
  try
  {
   method.EnsureRawBytes();if(method.RawBytes.Length is <8 or >12)continue;
   string assembly=app.InstructionSet.PrintAssembly(method);var lines=assembly.Split('\n',StringSplitOptions.TrimEntries|StringSplitOptions.RemoveEmptyEntries);if(lines.Length<2||!lines[^1].EndsWith(" RET"))continue;
   int access=0;string register=getter?spec.getter:spec.setter;
   if(setter&&valueType=="System.Boolean"&&lines.Length==3){var normalize=Regex.Match(lines[0],@"^0x[0-9A-F]+ AND (W[0-9]+), W1, 0x1$",RegexOptions.IgnoreCase);if(!normalize.Success)continue;register=normalize.Groups[1].Value;access=1;}
   if(lines.Length!=access+2)continue;
   var match=Regex.Match(lines[access],@"^0x[0-9A-F]+ "+(getter?"LDR":"STR")+spec.opcode+" "+register+@", \[X0(?: \+ 0x([0-9A-F]+))?\]$",RegexOptions.IgnoreCase);if(!match.Success)continue;
   int offset=match.Groups[1].Success?Convert.ToInt32(match.Groups[1].Value,16):0;
   var matches=new List<FieldAnalysisContext>();for(var t=type;t!=null;t=t.BaseType)matches.AddRange(t.Fields.Where(f=>!f.IsStatic&&f.Offset==offset));
   if(matches.Count!=1||matches[0].FieldType.FullName!=valueType)continue;
   var field=matches[0];method.AnalyzeCustomAttributeData();field.AnalyzeCustomAttributeData();
   native.Add(new Proof(method,field,getter?"getter":"setter",assembly,Convert.ToHexString(method.RawBytes.AsSpan())));
  }catch(Exception ex){rejected.Add(new{method=method.FullNameWithSignature,status="native-inspection-failed",reason=ex.Message});}
 }
}
var ordinary=new List<object>();var pairs=new List<object>();var skip=new List<object>();
var completed=new HashSet<string>();
foreach(var proof in native)
{
 var method=proof.Method;var field=proof.Field;string owner=method.DeclaringType.FullName;string propertyName=method.Name[4..];
 try
 {
  string path=PathFor(owner);var doc=Document(path);var properties=doc.root.DescendantNodes().OfType<PropertyDeclarationSyntax>().Where(p=>Owner(p)==owner&&p.Identifier.ValueText==propertyName).ToArray();
  if(properties.Length!=1)throw new Exception("Source property identity missing or ambiguous");var property=properties[0];var access=property.AccessorList?.Accessors.SingleOrDefault(a=>a.Keyword.ValueText==(proof.Kind=="getter"?"get":"set"));
  if(access==null||!TokEq(Token(access),method.Token)||!string.Equals(Rva(access),$"0x{method.UnderlyingPointer:X}",StringComparison.OrdinalIgnoreCase)||Norm(property.Type.ToString())!=field.FieldType.FullName||property.Modifiers.Any(SyntaxKind.StaticKeyword))throw new Exception("Accessor Token/RVA/signature/static differs from native metadata");
  if(!Placeholder(access)){skip.Add(new{method=method.FullNameWithSignature,reason="Existing body or auto accessor preserved"});continue;}
  if(property.Modifiers.Any(t=>t.IsKind(SyntaxKind.VirtualKeyword)||t.IsKind(SyntaxKind.OverrideKeyword)||t.IsKind(SyntaxKind.AbstractKeyword))||method.DeclaringType.Properties.Single(p=>p.Name==propertyName).IsVirtual)throw new Exception("All virtual accessors excluded from expansion");
  if(field.Name.StartsWith('<')&&field.Name.EndsWith(">k__BackingField"))
  {
   string key=owner+"::"+propertyName;if(completed.Contains(key))continue;completed.Add(key);
   var propertyMetadata=method.DeclaringType.Properties.Single(p=>p.Name==propertyName);
   if(!TokEq(Token(property),propertyMetadata.Token))throw new Exception("Property Token differs");
   var get=native.SingleOrDefault(p=>p.Method==propertyMetadata.Getter);var set=native.SingleOrDefault(p=>p.Method==propertyMetadata.Setter);
   if(get==null||set==null||get.Field.Token!=set.Field.Token||get.Field.DeclaringType.FullName!=owner)throw new Exception("Both native accessors to same original field required");
   if(!field.IsCompilerGeneratedBasedOnCustomAttributes||!get.Method.IsCompilerGeneratedBasedOnCustomAttributes||!set.Method.IsCompilerGeneratedBasedOnCustomAttributes)throw new Exception("Original CompilerGenerated metadata required");
   if(field.CustomAttributes?.Any(a=>a.Constructor.DeclaringType!.FullName.Contains("SerializeField")||a.Constructor.DeclaringType!.FullName.Contains("SerializeReference"))==true)throw new Exception("Serialized original backing field excluded");
   if(field.CustomAttributes?.Any(a=>a.Constructor.DeclaringType!.FullName!="System.Runtime.CompilerServices.CompilerGeneratedAttribute"&&a.Constructor.DeclaringType!.FullName!="System.Diagnostics.DebuggerBrowsableAttribute")==true)throw new Exception("Extra original backing-field attributes need separate preservation");
   if(property.Initializer!=null||property.ExpressionBody!=null||property.Modifiers.Any(t=>t.IsKind(SyntaxKind.VirtualKeyword)||t.IsKind(SyntaxKind.OverrideKeyword)||t.IsKind(SyntaxKind.AbstractKeyword))||propertyMetadata.IsVirtual)throw new Exception("Initializer or virtual property excluded");
   if(property.AttributeLists.SelectMany(a=>a.Attributes).Any(a=>a.Name.ToString().Contains("Serialize")))throw new Exception("Source serialization attributes excluded");
   foreach(var a in property.AccessorList!.Accessors){var n=a.IsKind(SyntaxKind.GetAccessorDeclaration)?get:set;if(!Placeholder(a)||!TokEq(Token(a),n.Method.Token)||!string.Equals(Rva(a),$"0x{n.Method.UnderlyingPointer:X}",StringComparison.OrdinalIgnoreCase))throw new Exception("Paired source accessor no longer placeholder or identity differs");}
   pairs.Add(new{type=owner,property=propertyName,propertyToken=$"0x{propertyMetadata.Token:X8}",field=field.Name,fieldToken=$"0x{field.Token:X8}",fieldOffset=field.Offset,fieldType=field.FieldType.FullName,sourcePath=path,sourceHash=Sha(path),metaHash=Sha(path+".meta"),sourceProperty=property.ToString(),getter=get.Export(),setter=set.Export()});
  }
  else
  {
   var fieldDoc=Document(PathFor(field.DeclaringType.FullName));var fields=fieldDoc.root.DescendantNodes().OfType<FieldDeclarationSyntax>().Where(f=>Owner(f)==field.DeclaringType.FullName&&f.Declaration.Variables.Any(v=>v.Identifier.ValueText==field.Name)).ToArray();
   if(fields.Length!=1||!TokEq(Token(fields[0]),field.Token)||Norm(fields[0].Declaration.Type.ToString())!=field.FieldType.FullName||fields[0].Modifiers.Any(SyntaxKind.StaticKeyword))throw new Exception("Source field Token/type/static identity mismatch");
   ordinary.Add(new{type=owner,property=propertyName,sourcePath=path,sourceHash=Sha(path),metaHash=Sha(path+".meta"),sourceBody=access.Body!.ToString(),native=proof.Export(),fieldSourceToken=Token(fields[0])});
  }
 }catch(Exception ex){rejected.Add(new{method=method.FullNameWithSignature,status="source-or-pair-proof-rejected",reason=ex.Message});}
}
var options=new JsonSerializerOptions{WriteIndented=true};void Write(string name,object value)=>File.WriteAllText(Path.Combine(own,name),JsonSerializer.Serialize(value,options));
Write("native-field-candidates.json",native.Select(p=>p.Export()));Write("field-accessor-plan.json",ordinary);Write("auto-property-plan.json",pairs);Write("rejected.json",rejected);Write("existing-preserved.json",skip);Write("excluded-types.json",excluded);
var summary=new{nativeFieldCandidates=native.Count,newExplicitAccessors=ordinary.Count,newAutoProperties=pairs.Count,newAutoAccessors=pairs.Count*2,existingPreserved=skip.Count,rejected=rejected.Count,excludedTypes=excluded.ToArray(),noProductionSourceWrites=true};Write("summary.json",summary);Console.WriteLine(JsonSerializer.Serialize(summary,options));
record Proof(MethodAnalysisContext Method,FieldAnalysisContext Field,string Kind,string Assembly,string CodeHex)
{
 public object Export()=>new{method=Method.FullNameWithSignature,methodName=Method.Name,methodToken=$"0x{Method.Token:X8}",methodType=Method.DeclaringType.FullName,address=$"0x{Method.UnderlyingPointer:X}",kind=Kind,returnType=Method.ReturnType.FullName,parameters=Method.Parameters.Select(p=>p.ParameterType.FullName).ToArray(),fieldType=Field.FieldType.FullName,field=Field.Name,fieldToken=$"0x{Field.Token:X8}",fieldOwner=Field.DeclaringType.FullName,fieldOffset=Field.Offset,native=Assembly,codeHex=CodeHex};
}
