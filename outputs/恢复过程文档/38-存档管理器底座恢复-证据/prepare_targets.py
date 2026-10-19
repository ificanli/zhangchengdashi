from pathlib import Path
import bisect,json
root=Path(__file__).resolve().parents[2]
work=root/'work/stage38-savebase'
s=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
ends=sorted(set(s['Addresses']));methods={m['Address']:m for m in s['ScriptMethod']}
metadata=json.loads((work/'original-metadata.json').read_text(encoding='utf-8-sig'))
types={t['FullName']:t for t in metadata}
targets=[]
for type_name,prefix,path in [
 ('DbtSaveDataManagerBase`2','DbtSaveDataManagerBase<object, object>$$','Assets/Scripts/Assembly-CSharp/DbtSaveDataManagerBase.cs'),
 ('GameFramework.DataManagerBase','GameFramework.DataManagerBase$$','Assets/Scripts/GFRunning/GameFramework/DataManagerBase.cs')]:
    for native in [m for m in s['ScriptMethod'] if m['Name'].startswith(prefix)]:
        name=native['Name'].split('$$')[1]
        # Source-safe obfuscated metadata names match original DummyDll; use exact RVA for GF fallback.
        choices=[m for m in types[type_name]['methods'] if m['Name']==name or m.get('rva') and int(m['rva'],16)==native['Address']]
        assert len(choices)==1,(name,choices)
        m=choices[0];address=native['Address']
        ret='void*' if name in ('get_Data','GetData','ReLoadLocalData','get_DataKey','ReadLocalData') else 'unsigned char' if name=='\x8e\xb6F\xb6dB' else 'void'
        arg='void* data,' if any(v in native['Signature'] for v in ['System_String_o* str','Il2CppObject* value','Il2CppObject* data','System_String_o* ___cf_']) else 'int flag,' if 'bool L_M___' in native['Signature'] else 'long long stamp,' if 'int64_t ____u_' in native['Signature'] else 'int kind,void* msg,' if 'int32_t type' in native['Signature'] else ''
        targets.append(dict(name=native['Name'],address=address,end=ends[bisect.bisect_right(ends,address)],signature=native['Signature'],prototype=f'{ret} SaveBaseTarget{len(targets)}(void* self,{arg}const MethodInfo* method);',method_token=m['token'],file=path,source_signature=m['FullName'],genericShared=type_name.startswith('Dbt')))
for address,token,path in [(0x4376AFC,'0x60059C2','Assets/Scripts/Assembly-CSharp/DataModule/PlayerTimeData.cs')]:
    native=methods[address]
    targets.append(dict(name=native['Name'],address=address,end=ends[bisect.bisect_right(ends,address)],signature=native['Signature'],prototype='void PlayerTimeDataCtor(void* self,const MethodInfo* method);',method_token=token,file=path))
(work/'native-targets.json').write_text(json.dumps(targets,ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(targets),'bounded native requests; production unchanged')
