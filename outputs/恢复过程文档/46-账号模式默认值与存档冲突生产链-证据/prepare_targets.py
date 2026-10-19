from pathlib import Path
import json,bisect
r=Path(__file__).resolve().parents[2];w=r/'work/stage46-account-mode';s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));methods={m['Address']:m for m in s['ScriptMethod']};ends=sorted(set(s['Addresses']))
meta=json.loads((w/'original-metadata.json').read_text(encoding='utf-8'));identities={int(m['rva'],16):dict(declaringType=t['FullName'],**m) for t in meta for m in t['methods'] if m.get('rva')}
spec=[(0x7301010,'int AccountModeGet(const MethodInfo* method);','Assets/Scripts/GFRunning/GameFramework/Login/ILoginProcedure.cs'),(0x7301068,'void AccountModeSet(int mode,const MethodInfo* method);','Assets/Scripts/GFRunning/GameFramework/Login/ILoginProcedure.cs'),(0x7301214,'void AccountModeCctor(const MethodInfo* method);','Assets/Scripts/GFRunning/GameFramework/Login/ILoginProcedure.cs'),(0x434D56C,'void ConflictChosen(void* self,int mode,const MethodInfo* method);','Assets/Scripts/Assembly-CSharp/DataModule/DataManager.cs')]
targets=[]
for a,p,path in spec:
 n=methods[a];m=identities[a];targets.append(dict(name=n['Name'],address=a,end=ends[bisect.bisect_right(ends,a)],signature=n['Signature'],prototype=p,method_token=m['token'],file=path,requestIncomingXrefs=True,note='Readonly producer audit; original default and assignment callers must precede Editor provider design'))
(w/'native-targets.json').write_text(json.dumps(targets,ensure_ascii=False,indent=2),encoding='utf-8')
(w/'xref-requests.json').write_text(json.dumps(dict(methods=[dict(address=hex(a),name=methods[a]['Name']) for a,_,_ in spec],metadataGlobals=[dict(address='0x8CE8C58',name='GameFramework.Login.ILoginProcedure_TypeInfo',purpose='incoming type refs may inline accountType field writes; inspect only actual startup assignment producers')],required='Incoming call xrefs for set_accountType and ChooseConflict; trace SaveConflictCheckFinish original producer, no SDK flags written'),ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(targets),'exact native bodies plus incoming-xref audit request; production unchanged')
