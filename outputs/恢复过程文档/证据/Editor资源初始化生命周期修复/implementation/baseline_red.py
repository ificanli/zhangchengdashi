import pathlib, re, subprocess, json
w=pathlib.Path(__file__).resolve().parent
r=w.parents[1]
p=r/'outputs/OccupyCityRecovered'
f=w/'red-fixture';f.mkdir(parents=True,exist_ok=True)
def body(path, signature):
 t=path.read_text(encoding='utf-8-sig');a=t.index(signature);a=t.index('{',a);n=1;b=a+1
 while n:
  n+=(t[b]=='{')-(t[b]=='}');b+=1
 return t[a+1:b-1]
provider=body(p/'Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesProvider.cs','public IEnumerator Initialize(string applicationName)')
bridge=p/'Assets/Scripts/GFRunning/GameFramework/Recovery/LocalEditorResourceBridge.cs'
guard=body(bridge,'public static IEnumerator Guard(IEnumerator operation, Action<Exception> onFailure)')
code='''using System;using System.Collections;using System.Collections.Generic;using System.Reflection;
class Receipt {public string status,failure;public bool ready;}
class Provider {private bool _initializing;private Receipt _receipt=new();public Exception Failure;public bool IsReady;private dynamic _registry=new Registry();class Registry{public string applicationName="game";}public IEnumerator Initialize(string applicationName){'''+provider+'''}
private IEnumerator InitializeCore(string name){yield return null;yield return null;IsReady=true;}private void Save(){}public bool Busy=>(bool)typeof(Provider).GetField("_initializing",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(this);}
class Guard {public static IEnumerator Run(IEnumerator operation,Action<Exception> onFailure){'''+guard+'''}}
class DisposableWait:IEnumerator,IDisposable {public int Disposed;public object Current=>null;public bool MoveNext()=>true;public void Reset()=>throw new NotSupportedException();public void Dispose(){Disposed++;}}
class Program{static int Main(){int failures=0;var p=new Provider();var op=p.Initialize("game");op.MoveNext();((IDisposable)op).Dispose();if(p.Busy){Console.WriteLine("FAIL provider lease remains busy after dispose at yield");failures++;}var wait=new DisposableWait();var g=Guard.Run(wait,null);g.MoveNext();((IDisposable)g).Dispose();if(wait.Disposed!=1){Console.WriteLine("FAIL Guard does not dispose the active inner enumerator");failures++;}Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new{cases=2,failures}));return failures==0?0:1;}}
'''
(f/'Program.cs').write_text(code,encoding='utf-8')
(f/'Red.csproj').write_text('<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><NoWarn>CS0649</NoWarn></PropertyGroup></Project>',encoding='utf-8')
run=subprocess.run(['dotnet','run','--project',str(f/'Red.csproj')],capture_output=True,text=True,encoding='utf-8',errors='replace')
(w/'baseline-red.log').write_text(run.stdout+run.stderr,encoding='utf-8')
result={'exitCode':run.returncode,'expectedExitCode':1,'actualMethodBodies':True,'stdout':run.stdout,'stderr':run.stderr}
(w/'baseline-red.json').write_text(json.dumps(result,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print(run.stdout+run.stderr)
assert run.returncode==1 and 'cases":2,"failures":2' in run.stdout
