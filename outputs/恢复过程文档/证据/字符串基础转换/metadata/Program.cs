using System.Text.Json;
using AssetRipper.Primitives;
using Cpp2IL.Core;
var root=Path.GetFullPath(".");new Cpp2IlCorePlugin().OnLoad();Cpp2IlApi.RuntimeOptions=new Cpp2IlRuntimeArgs{LowMemoryMode=true};Cpp2IlApi.InitializeLibCpp2Il(Path.Combine(root,"work/ida-input/libil2cpp-arm64.so"),Path.Combine(root,"work/metadata-probe/global-metadata.decoded.dat"),UnityVersion.Parse("2022.3.62f3"));var app=Cpp2IlApi.CurrentAppContext;
var type=app.AllTypes.Single(t=>t.FullName=="ToolModule.StringTool");var targets=type.Methods.Where(m=>m.Name is "ToInt" or "IsNullOrEmpty" or "ToEnum").ToArray();
var data=new{type=type.FullName,token=$"0x{type.Token:X8}",methods=targets.Select(m=>new{m.Name,signature=m.FullNameWithSignature,token=$"0x{m.Token:X8}",address=$"0x{m.UnderlyingPointer:X}",m.IsStatic,parameters=m.Parameters.Select(p=>new{p.Name,type=p.ParameterType.FullName,attributes=p.Attributes.ToString(),defaultValue=p.OriginalDefaultValue})}),identityByAddress=new ulong[]{0x3F73A70,0x3F75418,0x4ED6794,0x4ED68A4}.Select(a=>new{address=$"0x{a:X}",signatures=app.MethodsByAddress[a].Select(m=>m.FullNameWithSignature).Distinct().ToArray()})};
File.WriteAllText(Path.Combine(root,"work/stringtool-recovery/metadata-identities.json"),JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine("STRING_TOOL_METADATA complete");
