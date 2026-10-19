from pathlib import Path
import bisect,json
root=Path(__file__).resolve().parents[2];w=root/'work/stage38-savebase'
s=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));methods={m['Address']:m for m in s['ScriptMethod']};ends=sorted(set(s['Addresses']))
metadata=json.loads((w/'original-metadata.json').read_text(encoding='utf-8-sig'))
addresses={int(m['rva'],16):(t,m) for t in metadata for m in t['methods'] if m.get('rva')}
spec=[]
def add(addr,proto,note,path=None,token=None):
    n=methods[addr]
    if addr in addresses:
        t,m=addresses[addr];token=m['token']
        path=path or ('Assets/Scripts/Assembly-CSharp/L_Tools/DataCompressTools.cs' if t['FullName']=='L_Tools.DataCompressTools' else 'Assets/Scripts/GFRunning/GameFramework/'+t['FullName'].split('.')[-1]+'.cs' if t['FullName'].startswith('GameFramework.') else 'Assets/Scripts/GFRunning/ÂOke-Á.cs')
    spec.append(dict(name=n['Name'],address=addr,end=ends[bisect.bisect_right(ends,addr)],signature=n['Signature'],prototype=proto,method_token=token,file=path,note=note))
for addr,proto in [(0x43F8990,'void* EncryptSaveString(void* value,const MethodInfo* method);'),(0x43F8B04,'void* DecryptSaveString(void* value,const MethodInfo* method);'),(0x43F8164,'void* CompressSaveString(void* value,const MethodInfo* method);'),(0x43F8DE0,'void* CompressSaveBytes(void* bytes,const MethodInfo* method);'),(0x43F7E58,'void* DecompressSaveString(void* value,const MethodInfo* method);'),(0x43F9134,'void* DecompressSaveBytes(void* bytes,const MethodInfo* method);'),(0x43F9614,'void SaveCompressionCctor(const MethodInfo* method);')]:
    add(addr,proto,'Actual save JSON consumer Gzip dependency; all current unknown; reconstruct exact format and invalid input contract, no MemoryPack replacement')
for addr,proto in [(0x71723B4,'void* PoolInstance(const MethodInfo* method);'),(0x7177DDC,'void PoolCtor(void* self,const MethodInfo* method);'),(0x71783A4,'void PoolInit(void* self,const MethodInfo* method);'),(0x7178D38,'void* PoolGetType(void* self,void* type,const MethodInfo* method);'),(0x4B983AC,'void* PoolAddModel(void* self,void* model,unsigned char init,const MethodInfo* method);'),(0x4B98584,'void* PoolGetModel(void* self,const MethodInfo* method);')]:
    add(addr,proto,'Original producer of model registration and static I; readonly trace before scope approval',path='Assets/Scripts/GFRunning/GameFramework/DataManagerPool.cs',token='0x600585B' if addr==0x4B983AC else '0x6005860' if addr==0x4B98584 else None)
for addr,proto in [(0x7171C1C,'unsigned char ValidateDataKey(void* key,const MethodInfo* method);'),(0x71728F4,'void* ReadNativeData(void* key,unsigned char useServer,const MethodInfo* method);'),(0x717247C,'void WriteNativeData(void* key,void* data,unsigned char useServer,const MethodInfo* method);')]:
    add(addr,proto,'Readonly lower native storage boundary evidence only; no emulator/user-data I/O authorized')
for addr,proto in [(0x7171934,'void ModelRegisterCtor(void* self,void* name,unsigned char autoSyn,unsigned char compress,const MethodInfo* method);'),(0x71718FC,'void* ModelGameName(void* self,const MethodInfo* method);'),(0x7171864,'unsigned char ModelAutoSyn(void* self,const MethodInfo* method);'),(0x71719A4,'unsigned char ModelCompress(void* self,const MethodInfo* method);')]:
    add(addr,proto,'Original registration flags must remain real; current ctor/getters unknown; not online/login bypass')
(w/'supplement-targets.json').write_text(json.dumps(spec,ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(spec),'bounded dependencies, production unchanged')
