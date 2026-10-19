using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using ToolModule;

static class Program
{
 static int scenarios,checks,failures;
 static readonly List<object> ResourceResults=new();
 static void Check(bool condition,string message){checks++;if(!condition)throw new Exception(message);}
 static void Run(string name,Action action){scenarios++;UnityEngine.Debug.Errors.Clear();try{action();Console.WriteLine("PASS "+name);}catch(Exception ex){failures++;Console.WriteLine("FAIL "+name+": "+ex.GetBaseException().Message);}}
 static byte[] Pack(byte[] bytes){using var output=new MemoryStream();using(var gzip=new GZipStream(output,CompressionLevel.Optimal,true))gzip.Write(bytes,0,bytes.Length);return output.ToArray();}
 static string Encoded(string text)=>Convert.ToBase64String(Pack(Encoding.UTF8.GetBytes(text)));
 static string Hash(byte[] bytes)=>Convert.ToHexString(SHA256.HashData(bytes)).ToLowerInvariant();
 static void Main()
 {
  Run("UTF8 field initializer and original type flags",()=>{var type=typeof(GZipTool);var encoding=(Encoding)type.GetField("DefaultEncoding",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null);Check(ReferenceEquals(encoding,Encoding.UTF8),"same UTF8 singleton");Check((type.Attributes&TypeAttributes.BeforeFieldInit)!=0,"original BeforeFieldInit retained");Check((int)type.GetField("BufferSize",BindingFlags.NonPublic|BindingFlags.Static).GetRawConstantValue()==81920,"original buffer size");});
  Run("null and empty strings return empty without logging",()=>{Check(GZipTool.DecompressFromBase64(null)==string.Empty,"null string becomes empty");Check(GZipTool.DecompressFromBase64("")==string.Empty,"empty string becomes empty");Check(UnityEngine.Debug.Errors.Count==0,"no early-return error log");});
  Run("Base64 whitespace contract",()=>{Check(GZipTool.DecompressFromBase64(" \r\n\t")==string.Empty,"whitespace decodes to zero bytes");string text="[{\"中文\":\"测试😀\"}]";string value=Encoded(text);string spaced="\r\n"+string.Join(" \n",Enumerable.Range(0,value.Length/4).Select(i=>value.Substring(i*4,4)))+"\t";Check(GZipTool.DecompressFromBase64(spaced)==text,"FromBase64String accepts whitespace");});
  Run("malformed Base64 logs original input and rethrows FormatException",()=>{string invalid="%%%not-base64%%%";Exception error=null;var old=Console.Out;var output=new StringWriter();try{Console.SetOut(output);try{GZipTool.DecompressFromBase64(invalid);}catch(Exception ex){error=ex;}}finally{Console.SetOut(old);}Check(error is FormatException,"original conversion exception type");Check(UnityEngine.Debug.Errors.SequenceEqual(new[]{"解压失败："+invalid}),"exact native log prefix plus input");Check(output.ToString().Contains("FormatException"),"Console.WriteLine receives original exception");Check(error.StackTrace.Contains("Convert.FromBase64"),"throw preserves conversion stack");});
  Run("null and empty byte inputs preserve identity",()=>{Check(GZipTool.Decompress(null)==null,"null byte input preserved");var empty=new byte[0];Check(ReferenceEquals(empty,GZipTool.Decompress(empty)),"empty byte array identity preserved");});
  Run("gzip UTF8 non-ASCII text",()=>{string text="[{\"text\":\"你好，世界\\n😀 café\"}]";Check(GZipTool.DecompressFromBase64(Encoded(text))==text,"UTF8 characters and escapes retained");});
  Run("gzip arbitrary bytes preserve every byte",()=>{var bytes=Enumerable.Range(0,81920*3+73).Select(i=>(byte)(i*73)).ToArray();var compressed=Pack(bytes);var actual=GZipTool.Decompress(compressed);Check(actual!=null&&actual.SequenceEqual(bytes),"all streamed bytes restored across multiple reads");Check(!ReferenceEquals(actual,compressed),"successful decompression returns output array");});
  Run("valid gzip representing empty payload",()=>{var compressed=Convert.FromBase64String("H4sIAAAAAAACAAMAAAAAAAAAAAA=");var actual=GZipTool.Decompress(compressed);Check(actual!=null&&actual.Length==0&&!ReferenceEquals(actual,compressed),"empty payload succeeds and returns decoded empty array");Check(GZipTool.DecompressFromBase64(Convert.ToBase64String(compressed))=="","empty gzip becomes empty text");});
  Run("invalid gzip preserves original bytes through native catch",()=>{var invalid=Encoding.UTF8.GetBytes("this is not gzip");Check(ReferenceEquals(invalid,GZipTool.Decompress(invalid)),"core exception returns original array");Check(GZipTool.DecompressFromBase64(Convert.ToBase64String(invalid))=="this is not gzip","wrapper decodes returned original bytes");Check(UnityEngine.Debug.Errors.Count==0,"core fallback does not create wrapper error log");});
  Run("bad gzip CRC follows original byte fallback",()=>{var compressed=Pack(Encoding.UTF8.GetBytes("CRC failure fixture"));compressed[^8]^=0xff;Check(ReferenceEquals(compressed,GZipTool.Decompress(compressed)),"CRC failure returns original compressed array");Check(UnityEngine.Debug.Errors.Count==0,"no wrapper error log on core catch");});
  Run("UTF8 replacement fallback is retained",()=>{byte[] bytes={0xc3,0x28,0xff};Check(GZipTool.DecompressFromBase64(Convert.ToBase64String(Pack(bytes)))=="\uFFFD(\uFFFD","UTF8 uses replacement instead of strict throw");});
  Run("UTF8 BOM is not removed by GetString",()=>{var bytes=new byte[]{0xef,0xbb,0xbf}.Concat(Encoding.UTF8.GetBytes("[]")).ToArray();Check(GZipTool.DecompressFromBase64(Convert.ToBase64String(Pack(bytes)))=="\uFEFF[]","GetString preserves BOM character");});
  Run("large UTF8 payload spans original buffer size",()=>{string text=string.Concat(Enumerable.Repeat("汉字😀 abc 123\n",100000));Check(GZipTool.DecompressFromBase64(Encoded(text))==text,"large payload fully restored");});
  Run("damaged Base64 padding remains FormatException",()=>{string invalid="AAAA=";var old=Console.Out;try{Console.SetOut(TextWriter.Null);bool caught=false;try{GZipTool.DecompressFromBase64(invalid);}catch(FormatException){caught=true;}Check(caught,"padding error propagates");Check(UnityEngine.Debug.Errors.Count==1,"padding error logged once");}finally{Console.SetOut(old);}});
  using var manifest=JsonDocument.Parse(File.ReadAllText("work/gzip-recovery/resource-oracle.json"));
  foreach(var resource in manifest.RootElement.EnumerateArray())
  {
   string path=resource.GetProperty("path").GetString();string address=resource.GetProperty("address").GetString();string category=resource.GetProperty("category").GetString();
   Run(category+" "+Path.GetFileName(path),()=>
   {
    byte[] raw=File.ReadAllBytes(path);Check(Hash(raw)==resource.GetProperty("sourceSha256").GetString(),"resource source bytes unchanged");string decoded=GZipTool.DecompressFromBase64(File.ReadAllText(path));
    Check(decoded!=null&&Hash(Encoding.UTF8.GetBytes(decoded))==resource.GetProperty("decodedUtf8Sha256").GetString(),"actual source output matches independent Python gzip oracle");
    using var json=JsonDocument.Parse(decoded);Check(json.RootElement.ValueKind==JsonValueKind.Array,"original list JSON shape");Check(json.RootElement.GetArrayLength()==resource.GetProperty("rowCount").GetInt32(),"original JSON row count");
    ResourceResults.Add(new{address,category,sourceSha256=Hash(raw),decodedSha256=Hash(Encoding.UTF8.GetBytes(decoded)),rows=json.RootElement.GetArrayLength(),status="passed"});
   });
  }
  File.WriteAllText("work/gzip-recovery/tests/resource-readback.json",JsonSerializer.Serialize(ResourceResults,new JsonSerializerOptions{WriteIndented=true}));
  Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures} resourcesPassed={ResourceResults.Count}");Environment.ExitCode=failures==0?0:1;
 }
}
namespace UnityEngine
{
 // Test-only log sink. Actual standalone compilation uses Unity's real Debug API.
 public static class Debug {public static readonly List<string> Errors=new();public static void LogError(object value)=>Errors.Add(value?.ToString());}
}
