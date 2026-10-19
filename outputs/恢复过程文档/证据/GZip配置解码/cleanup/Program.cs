using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

static class Program
{
 static int tests,checks,failures;
 static void Check(bool value,string message){checks++;if(!value)throw new Exception(message);}
 static byte[] Pack(){using var output=new MemoryStream();using(var gzip=new GZipStream(output,CompressionLevel.Optimal,true)){byte[] b=Encoding.UTF8.GetBytes("cleanup");gzip.Write(b,0,b.Length);}return output.ToArray();}
 static void Run(string fault){tests++;CleanupProbe.Reset(fault);try{byte[] input=Pack();byte[] result=ToolModule.GZipTool.Decompress(input);bool ok=fault=="none";Check(ok?Encoding.UTF8.GetString(result)=="cleanup":ReferenceEquals(input,result),"original success or catch identity");Check(CleanupProbe.Trace.Contains("dispose:gzip"),"gzip disposed");Check(CleanupProbe.Trace.Count(x=>x=="dispose:input")>=1,"input disposed");if(fault!="output-new")Check(CleanupProbe.Trace.Contains("dispose:output"),"output disposed");if(fault is not("output-new" or "rent")){Check(CleanupProbe.Trace.Count(x=>x=="return:False")==1,"buffer returned exactly once, no clear");Check(CleanupProbe.Trace.IndexOf("return:False")<CleanupProbe.Trace.IndexOf("dispose:output"),"buffer return before stream disposal");}else Check(!CleanupProbe.Trace.Any(x=>x.StartsWith("return:")),"no return before successful rent");if(fault!="output-new")Check(CleanupProbe.Requested==81920,"exact native rent size");if(ok)Check(!ReferenceEquals(input,result),"success returns new output");Console.WriteLine("PASS "+fault+" "+string.Join(" > ",CleanupProbe.Trace));}catch(Exception e){failures++;Console.WriteLine("FAIL "+fault+" "+e.Message);}}
 static void Main(){foreach(string fault in new[]{"none","read","rent","return","output-new","output-dispose","gzip-dispose"})Run(fault);Console.WriteLine($"RESULT cleanupScenarios={tests} checks={checks} failures={failures}");Environment.ExitCode=failures==0?0:1;}
}
static class CleanupProbe
{
 public static string Fault;public static int Requested;public static readonly List<string> Trace=new();public static readonly BufferPool Pool=new();
 public static void Reset(string fault){Fault=fault;Requested=0;Trace.Clear();}
 public class BufferPool
 {
  public byte[] Rent(int size){Requested=size;Trace.Add("rent:"+size);if(Fault=="rent")throw new IOException("rent");return System.Buffers.ArrayPool<byte>.Shared.Rent(size);}
  public void Return(byte[] buffer,bool clear){Trace.Add("return:"+clear);System.Buffers.ArrayPool<byte>.Shared.Return(buffer,clear);if(Fault=="return")throw new IOException("return");}
 }
 public class Memory : MemoryStream
 {
  readonly string name;
  public Memory(byte[] b):base(b){name="input";Trace.Add("new:input");}
  public Memory(){name="output";Trace.Add("new:output");if(Fault=="output-new")throw new IOException("output-new");}
  protected override void Dispose(bool disposing){Trace.Add("dispose:"+name);base.Dispose(disposing);if(name=="output"&&Fault=="output-dispose")throw new IOException("output-dispose");}
 }
 public class Gzip : GZipStream
 {
  public Gzip(Stream stream,CompressionMode mode):base(stream,mode){Trace.Add("new:gzip");}
  public override int Read(byte[] buffer,int offset,int count){Trace.Add("read:"+count);if(Fault=="read")throw new IOException("read");return base.Read(buffer,offset,count);}
  protected override void Dispose(bool disposing){Trace.Add("dispose:gzip");base.Dispose(disposing);if(Fault=="gzip-dispose")throw new IOException("gzip-dispose");}
 }
}
namespace UnityEngine {public static class Debug {public static void LogError(object value){throw new Exception("Unexpected wrapper log in core cleanup tests");}}}
