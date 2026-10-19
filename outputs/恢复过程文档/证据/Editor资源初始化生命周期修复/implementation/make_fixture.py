from pathlib import Path
import hashlib,json,sys
w=Path(__file__).resolve().parent
candidate=(w.parents[1]/'outputs/OccupyCityRecovered') if '--production' in sys.argv else w/'candidate'
f=w/'fixture';f.mkdir(parents=True,exist_ok=True)
def member(text,signature):
 a=text.index(signature);a=text.rfind('\n',0,a)+1;start=text.index('{',a);n=1;b=start+1
 while n:n+=(text[b]=='{')-(text[b]=='}');b+=1
 return text[a:b]
p=candidate/'Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesProvider.cs'
b=candidate/'Assets/Scripts/GFRunning/GameFramework/Recovery/LocalEditorResourceBridge.cs'
text=p.read_text(encoding='utf-8-sig'); bt=b.read_text(encoding='utf-8-sig')
start=text.index('        private sealed class InitializationLease')
end=text.index('        private IEnumerator InitializeCore',start)
cluster=text[start:end]
classes='\n'.join(member(text,'public sealed class '+name) for name in ['Receipt','PayloadRecord','LoadRecord','LookupRecord','InstanceRecord'])
save=member(text,'private void Save()')+'\n'+member(text,'private static void WriteReceiptFile(string path, string json)')
prefix='''using System;using System.Collections;using System.Collections.Generic;using System.IO;using System.Text;using GameFramework.Recovery;using GameFramework.Resources;using UnityEditor;using UnityEngine;
namespace OccupyCity.Recovery.LocalResources.Editor { public sealed class LocalEditorResourcesProvider:ILocalEditorResourcesProvider {
private bool _initializing;private string _receiptPath;private Receipt _receipt;private Registry _registry;private sealed class Registry{public string applicationName;}
public string ProviderId=>"LocalEditorResourcesProvider";public bool IsReady{get;private set;}public Exception Failure{get;private set;}public IBundleServices BundleServices{get;private set;}
public string ReceiptPath=>_sessionReceiptPath;public int CoreDisposals{get;private set;}public int CoreEntries{get;private set;}
public UnityEngine.Object LoadAsset(string b,string n,Type t)=>throw new NotSupportedException();public void RecordInstance(string b,string n,GameObject s,GameObject i,bool a)=>throw new NotSupportedException();
'''
core='''
// Dependency-only adapter for the unchanged actual resource I/O coroutine.
private IEnumerator InitializeCore(string applicationName){CoreEntries++;try{
_registry=new Registry{applicationName=applicationName};_receiptPath=Env.Canonical;string runId=Guid.NewGuid().ToString("N");_sessionReceiptPath=Path.Combine(Env.RunRoot,runId+".json");
_receipt=new Receipt{runId=runId,ready=false,status="checking_actual_local_resources",initializationLeaseId=_initializationLease.Id,initializationSessionKind=_initializationLease.StartedInPlayMode?"play_owner":"independent_editor_owner",sessionReceiptPath=_sessionReceiptPath};Save();
while(!Env.HashReady)yield return null;
_receipt.checkedPayloads=34;Save();yield return null;
_receipt.loadedLegacyTextAssets=10;Save();yield return null;
if(Env.ResourceFailure)throw new InvalidDataException("actual I/O failure marker");
_receipt.loadedLegacyTextAssets=50;_receipt.originalManifestParsed=true;_receipt.actualTypedLoadsCompleted=true;_receipt.ready=true;_receipt.status="ready_actual_local_manifest_and_typed_loads";BundleServices=new TestServices();Save();IsReady=true;
}finally{CoreDisposals++;if(Env.CoreDisposeThrows)throw new IOException("core disposal marker");}}
}}
'''
(f/'Provider.cs').write_text(prefix+classes+'\n'+cluster+'\n'+save+'\n'+core,encoding='utf-8')
bridgeclass=member(bt,'public static class LocalEditorResourceBridge')
interface=member(bt,'public interface ILocalEditorResourcesProvider')
(f/'Bridge.cs').write_text('using System;using System.Collections;using System.Collections.Generic;using GameFramework.Resources;using UnityEngine;namespace GameFramework.Recovery{'+interface+'\n'+bridgeclass+'\npublic sealed class LocalEditorResourcesInfo:ResourcesInfo{public LocalEditorResourcesInfo(string value){}}}',encoding='utf-8')
helper=candidate/'Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesPlaySession.cs'
(f/'PlaySession.cs').write_text(helper.read_text(encoding='utf-8-sig'),encoding='utf-8')
(f/'Program.cs').write_text((w/'fixture-program.cs.txt').read_text(encoding='utf-8'),encoding='utf-8')
(f/'Adapters.cs').write_text((w/'fixture-adapters.cs.txt').read_text(encoding='utf-8'),encoding='utf-8')
(f/'Lifecycle.csproj').write_text('<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><ImplicitUsings>enable</ImplicitUsings><NoWarn>CS0649</NoWarn></PropertyGroup></Project>',encoding='utf-8')
provenance={'providerSource':str(p),'providerSha256':hashlib.sha256(p.read_bytes()).hexdigest(),'bridgeSource':str(b),'bridgeSha256':hashlib.sha256(b.read_bytes()).hexdigest(),'playSessionSource':str(helper),'playSessionSha256':hashlib.sha256(helper.read_bytes()).hexdigest(),'lifecycleMethods':'Copied actual candidate bodies byte-for-byte except enclosing fixture types; actual resource I/O coroutine alone replaced with controlled yield/failure dependency adapter. Actual Save/receipt file I/O retained.','productionEdits':0}
(w/'fixture-provenance.json').write_text(json.dumps(provenance,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print(json.dumps(provenance,ensure_ascii=False))
