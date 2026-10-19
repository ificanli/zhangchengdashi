using System.Text.Json;
using AssetRipper.Primitives;
using Cpp2IL.Core;
var root=Path.GetFullPath(".");new Cpp2IlCorePlugin().OnLoad();Cpp2IlApi.RuntimeOptions=new Cpp2IlRuntimeArgs{LowMemoryMode=true};Cpp2IlApi.InitializeLibCpp2Il(Path.Combine(root,"work/ida-input/libil2cpp-arm64.so"),Path.Combine(root,"work/metadata-probe/global-metadata.decoded.dat"),UnityVersion.Parse("2022.3.62f3"));var app=Cpp2IlApi.CurrentAppContext;
var data=app.AllTypes.Where(t=>t.FullName.StartsWith("GameFramework.UIModule")).Select(t=>new{type=t.FullName,token=$"0x{t.Token:X8}",fields=t.Fields.Select(f=>new{f.Name,type=f.FieldType.FullName,f.IsStatic,f.Offset,token=$"0x{f.Token:X8}"}),methods=t.Methods.Select(m=>new{m.Name,signature=m.FullNameWithSignature,m.IsStatic,token=$"0x{m.Token:X8}",address=$"0x{m.UnderlyingPointer:X}"})}).ToArray();
File.WriteAllText(Path.Combine(root,"work/stage40-ui/original-metadata.json"),JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine("UI_METADATA types="+data.Length);
