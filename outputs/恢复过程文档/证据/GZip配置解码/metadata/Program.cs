using System.Text.Json;
using AssetRipper.Primitives;
using Cpp2IL.Core;
var root=Path.GetFullPath(".");new Cpp2IlCorePlugin().OnLoad();Cpp2IlApi.RuntimeOptions=new Cpp2IlRuntimeArgs{LowMemoryMode=true};Cpp2IlApi.InitializeLibCpp2Il(Path.Combine(root,"work/ida-input/libil2cpp-arm64.so"),Path.Combine(root,"work/metadata-probe/global-metadata.decoded.dat"),UnityVersion.Parse("2022.3.62f3"));var app=Cpp2IlApi.CurrentAppContext;
var type=app.AllTypes.Single(t=>t.FullName=="ToolModule.GZipTool");
var data=new{type=type.FullName,token=$"0x{type.Token:X8}",attributes=type.Attributes.ToString(),fields=type.Fields.Select(f=>new{f.Name,type=f.FieldType.FullName,f.IsStatic,f.Offset,token=$"0x{f.Token:X8}"}),methods=type.Methods.Select(m=>new{m.Name,signature=m.FullNameWithSignature,m.IsStatic,token=$"0x{m.Token:X8}",address=$"0x{m.UnderlyingPointer:X}"}),listHelper=app.MethodsByAddress[0x4D652A0].Select(m=>m.FullNameWithSignature).Distinct().ToArray()};
File.WriteAllText(Path.Combine(root,"work/gzip-recovery/metadata-types.json"),JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine("GZIP_METADATA complete "+type.Attributes);
