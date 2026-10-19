using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using ToolModule;

static class Program
{
 static int scenarios,checks,failures;static readonly List<object> KeyResults=new();
 static void Check(bool pass,string message){checks++;if(!pass)throw new Exception(message);}
 static void Run(string name,Action test){scenarios++;try{test();Console.WriteLine("PASS "+name);}catch(Exception ex){failures++;Console.WriteLine("FAIL "+name+": "+ex.GetBaseException().Message);}}
 static string Hash(byte[] data)=>Convert.ToHexString(SHA256.HashData(data)).ToLowerInvariant();
 static void Main()
 {
  var inputCases=new(string text,int expected)[]{(null,0),("",0),(" ",0),("\r\n\t",0),("0",0),("17",17),("-7",-7),("+42",42),(" \t-12\r\n",-12),("000012",12),("2147483647",int.MaxValue),("2147483648",0),("-2147483648",int.MinValue),("-2147483649",0),("99999999999999999999999999999999999",0),("3.0",3),("3.000",3),("3.",3),("0.000",0),("0.1",0),("-3.0",-3),("2147483647.0",int.MaxValue),("-2147483648.000",int.MinValue),("1e3",1000),("1E+3",1000),("1.2e1",12),("120e-1",12),("12e-1",0),("1e-1",0),("1e0",1),("2.147483647e9",int.MaxValue),("2.147483648e9",0),("-2.147483648e9",int.MinValue),("-2.147483649e9",0),("1e100000",0),("1,000",0),("1,0",0),("1 000",0),("0x10",0),("NaN",0),("Infinity",0),("123-",0),("(123)",0),("￥3",0),("text",0),("１２",0),("١٢",0),("−12",0),("\u00A012\u00A0",0)};
  Run("native NumberStyles value",()=>Check((int)NumberStyles.Float==167,"native 0xA7 equals Float"));
  foreach(var item in inputCases){var c=item;Run("ToInt "+JsonSerializer.Serialize(c.text),()=>Check(StringTool.ToInt(c.text)==c.expected,"expected "+c.expected));}
  foreach(string culture in new[]{"en-US","de-DE","fr-FR","tr-TR","ar-SA"})
   Run("InvariantCulture ignores current "+culture,()=>{var previous=CultureInfo.CurrentCulture;try{CultureInfo.CurrentCulture=CultureInfo.GetCultureInfo(culture);Check(StringTool.ToInt("1.0")==1,"invariant decimal point");Check(StringTool.ToInt("1,0")==0,"locale decimal separator not accepted");Check(StringTool.ToInt("1e3")==1000,"exponent stable");Check(StringTool.ToInt("+17")==17&&StringTool.ToInt("-17")==-17,"invariant signs stable");}finally{CultureInfo.CurrentCulture=previous;}});
  Run("custom current-culture signs cannot change native conversion",()=>{var previous=CultureInfo.CurrentCulture;var custom=(CultureInfo)CultureInfo.InvariantCulture.Clone();custom.NumberFormat.PositiveSign="P";custom.NumberFormat.NegativeSign="M";custom.NumberFormat.NumberDecimalSeparator=",";try{CultureInfo.CurrentCulture=custom;Check(StringTool.ToInt("P17")==0&&StringTool.ToInt("M17")==0,"custom signs ignored");Check(StringTool.ToInt("+17")==17&&StringTool.ToInt("-17")==-17,"invariant signs used");}finally{CultureInfo.CurrentCulture=previous;}});
  var empties=new(string text,bool trim,bool expected)[]{(null,true,true),(null,false,true),("",true,true),("",false,true),(" ",true,true),(" ",false,false),("\t\r\n",true,true),("\t\r\n",false,false),("\u00A0\u2003\u202F\u3000",true,true),("\u00A0\u2003\u202F\u3000",false,false),("\u200B",true,false),("\uFEFF",true,false),("\0",true,false),(" a ",true,false),(" a ",false,false),(" Assets/JsonData ",true,false)};
  foreach(var item in empties){var c=item;Run("IsNullOrEmpty "+JsonSerializer.Serialize(c.text)+" trim="+c.trim,()=>Check(StringTool.IsNullOrEmpty(c.text,c.trim)==c.expected,"native null/Trim/Length semantics"));}
  Run("trimSpaces default remains optional true",()=>{Check(StringTool.IsNullOrEmpty(" \t\r\n"),"default invocation trims");var p=typeof(StringTool).GetMethod("IsNullOrEmpty").GetParameters()[1];Check(p.IsOptional&&p.HasDefaultValue&&Equals(p.DefaultValue,true),"metadata optional bool default true");Check(typeof(StringTool).GetMethod("IsNullOrEmpty").IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute),false),"extension identity retained");});
  Run("ToEnum is diagnostic-only unrecovered member",()=>{bool caught=false;try{StringTool.ToEnum<DayOfWeek>("Monday");}catch(NotImplementedException ex){caught=ex.Message.Contains("0x060006B1")&&ex.Message.Contains("0x4ED6794")&&ex.Message.Contains("0x4ED68A4");}Check(caught,"explicit diagnostic does not fabricate enum result");});
  using var keys=JsonDocument.Parse(File.ReadAllText("work/stringtool-recovery/key-oracle.json"));
  foreach(var record in keys.RootElement.EnumerateArray())
  {
   string path=record.GetProperty("path").GetString();string field=record.GetProperty("field").GetString();
   Run("original dictionary keys "+record.GetProperty("category").GetString()+" "+Path.GetFileName(path),()=>
   {
    Check(Hash(File.ReadAllBytes(path))==record.GetProperty("sourceSha256").GetString(),"original resource hash");string json=GZipTool.DecompressFromBase64(File.ReadAllText(path));Check(Hash(Encoding.UTF8.GetBytes(json))==record.GetProperty("jsonSha256").GetString(),"decoded source identity");using var doc=JsonDocument.Parse(json);var expected=record.GetProperty("expectedIntegers").EnumerateArray().Select(x=>x.GetInt32()).ToArray();var dict=new Dictionary<int,JsonElement>();int index=0;
    foreach(var row in doc.RootElement.EnumerateArray()){string input=row.GetProperty(field).GetString();int value=StringTool.ToInt(input);Check(value==expected[index],"original "+field+" key conversion index="+index);dict.Add(value,row.Clone());index++;}
    Check(dict.Count==record.GetProperty("rowCount").GetInt32(),"no all-zero dictionary collision");Check(dict.Keys.SequenceEqual(expected),"original ordered distinct dictionary keys");KeyResults.Add(new{path,field,rows=dict.Count,firstKey=dict.Keys.First(),lastKey=dict.Keys.Last(),status="passed"});
   });
  }
  File.WriteAllText("work/stringtool-recovery/tests/key-readback.json",JsonSerializer.Serialize(KeyResults,new JsonSerializerOptions{WriteIndented=true}));
  Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures} dictionaryFilesPassed={KeyResults.Count}");Environment.ExitCode=failures==0?0:1;
 }
}
namespace UnityEngine {public static class Debug {public static void LogError(object value)=>throw new Exception("Unexpected GZip resource failure "+value);}}
