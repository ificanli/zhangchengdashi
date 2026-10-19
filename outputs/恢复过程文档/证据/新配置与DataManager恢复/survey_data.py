import json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/new-config-restore'
BASE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))
source=(BASE/'DataModule/GlobalInfo.cs').read_text(encoding='utf-8-sig')
fields={int(m.group(1),16):{'type':m.group(2),'name':m.group(3)} for m in re.finditer(r'FieldOffset\(Offset = "(0x[0-9A-Fa-f]+)"\)\]\s*(?:public|private)\s+([^;\n]+?)\s+(\w+);',source)}
callbacks=[]
for row in native['methods']:
    if '$$<InitInfo>b__92_' not in row['name']:continue
    index=int(row['name'].rsplit('_',1)[-1]); asm=(ROOT/row['assembly']).read_text(encoding='utf-8')
    stores=re.findall(r'str\s+x(?:1|20), \[x(?:0|19), #(0x[0-9a-f]+)\]',asm)
    known=[{'offset':hex(int(off,16)),**fields.get(int(off,16),{})} for off in stores]
    key_loads=re.findall(r'ldr\s+[xw]\d+, \[x0, #(0x[0-9a-f]+)\]',asm)
    list_type=re.search(r'List_([^_]+)__o\* list',row.get('Signature',''))
    callbacks.append({'index':index,'address':row['address'],'name':row['name'],'signature':next((r['Signature'] for r in json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))['ScriptMethod'] if r['Name']==row['name']),None) if False else row.get('signature'), 'stores':known,'keyLoads':key_loads,'calls':[r['Name'] for r in row['directCalls']], 'metadata':[r.get('Name',r.get('Value')) for r in row['metadataReferences']]})
constructor=next(r for r in native['methods'] if r['name']=='DataModule.GlobalInfo$$.ctor')
ctor_asm=(ROOT/constructor['assembly']).read_text(encoding='utf-8')
ctor_stores=re.findall(r'str\s+x\d+, \[x19, #(0x[0-9a-f]+)\]',ctor_asm)
report={'fields':{hex(k):v for k,v in fields.items()},'constructorStores':[{'offset':off,**fields.get(int(off,16),{})} for off in ctor_stores], 'constructorStrings':[r['Value'] for r in constructor['metadataReferences'] if r['category']=='ScriptString'], 'callbacks':callbacks}
(WORK/'field-callback-survey.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print('CTOR',json.dumps(report['constructorStores'],ensure_ascii=False))
print('CTOR_STRINGS',report['constructorStrings'])
for row in callbacks:print(row['index'],row['address'],json.dumps(row['stores'],ensure_ascii=False),row['keyLoads'],row['calls'])
for name in ('GlobalSummonInfo','GlobalMapInfo','GlobalMainCityMapInfo'):
    print('CLASSFILES',name,[str(p.relative_to(BASE)) for p in BASE.rglob(name+'.cs')])
