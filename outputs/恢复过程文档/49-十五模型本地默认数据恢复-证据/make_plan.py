from pathlib import Path
import json,re
w=Path(__file__).parent;models=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'));by={x['dataType'].split('.')[-1]:x for x in models};files=[];facts=[]
def cs(t):return 'global::'+re.sub(r'`\d+','',t).replace('/','.')
def field(model,offset):
    fs=[f for f in by[model]['fields'] if not f['IsStatic'] and f.get('offset') and int(f['offset'],16)==offset]
    assert len(fs)==1,(model,offset,fs)
    return fs[0]
def new(model,offset,init=None):
    f=field(model,offset);suffix='()' if init is None else ' { '+init+' }'
    return f['Name']+' = new '+cs(f['type'])+suffix+';'
def val(model,offset,value):return field(model,offset)['Name']+' = '+value+';'
def add(model,name,body):
    original=by[model];m=next(m for m in original['ownMethods'] if m['Name']==name)
    row=next((x for x in files if x['path']==original['source']),None)
    if row is None:row=dict(path=original['source'],methods=[],autoProperties=[]);files.append(row)
    row['methods'].append(dict(token=m['token'],body='{\n'+body+'\n}',makeAsync=False,iterator=False))
    facts.append(dict(file=original['source'],token=m['token'],rva=m['rva'],name=name,body=body))
def ctor(model,ops):add(model,'.ctor','\n'.join(ops))
ctor('PlayerMainCityData',[new('PlayerMainCityData',o) for o in [0x10,0x18,0x20,0x28,0x48]])
ctor('PlayerCardData',[new('PlayerCardData',o) for o in [0x10,0x18,0x20,0x28]]+[new('PlayerCardData',0x38,'1001, 1002, 1003, 1004, 1005, 1011, 1013, 1014')]+[new('PlayerCardData',o) for o in [0x40,0x48]])
ctor('PlayerShopData',[new('PlayerShopData',o) for o in [0x10,0x18,0x20,0x28,0x30,0x38]]+[val('PlayerShopData',0x40,'string.Empty')]+[new('PlayerShopData',o) for o in [0x50,0x58,0x60,0x78]]+[val('PlayerShopData',0x90,'string.Empty')]+[new('PlayerShopData',o) for o in [0xA0,0xA8]]+[val('PlayerShopData',o,'true') for o in [0x100,0x101]]+[new('PlayerShopData',0x118),val('PlayerShopData',0x120,'-1'),new('PlayerShopData',0x128)])
ctor('PlayerArenaData',[new('PlayerArenaData',0x10)])
ctor('PlayerRankData',[new('PlayerRankData',0x10)])
ctor('PlayerResourceData',[new('PlayerResourceData',o) for o in [0x10,0x18]])
ctor('PlayerAdData',[val('PlayerAdData',o,'5') for o in [0x20,0x24]])
ctor('PlayerArtifactData',[val('PlayerArtifactData',0x34,'1'),val('PlayerArtifactData',0x38,'-1')])
ctor('PlayerCustomizationData',[val('PlayerCustomizationData',o,'true') for o in [0x10,0x11,0x12]]+[val('PlayerCustomizationData',0x20,'"1003"')])
ctor('PlayerCoreData',[new('PlayerCoreData',o) for o in [0x60,0x90,0x98,0xB8]])
ctor('PlayerGuideData',[new('PlayerGuideData',o) for o in [0x18,0x20,0x28]])
ctor('PlayerMysteryAdventureData',[val('PlayerMysteryAdventureData',0x28,'1')]+[new('PlayerMysteryAdventureData',o) for o in [0x40,0x48,0x60,0x68,0x70,0xA0]])
ctor('PlayerWorldCupActivityData',[new('PlayerWorldCupActivityData',o) for o in [0x20,0x28,0x40]])
def defaults(model,body):add(model,'InitFromDefaults','base.InitFromDefaults();\n'+body)
for model,offset in [('PlayerMainCityData',0x10),('PlayerResourceData',0x10)]:defaults(model,'if ('+field(model,offset)['Name']+' == null) '+new(model,offset))
defaults('PlayerShopData',val('PlayerShopData',0x80,'true')+'\n'+'\n'.join(new('PlayerShopData',o) for o in [0xA0,0xD8,0xA8,0x60])+'\n'+'\n'.join(val('PlayerShopData',o,'true') for o in [0x100,0x101]))
defaults('PlayerArenaData',val('PlayerArenaData',0x1C,'1')+'\nif ('+field('PlayerArenaData',0x10)['Name']+' == null) '+new('PlayerArenaData',0x10))
defaults('PlayerAdData','\n'.join(val('PlayerAdData',o,'5') for o in [0x18,0x1C,0x20,0x24])+'\n'+val('PlayerAdData',0x28,'1'))
defaults('PlayerArtifactData',val('PlayerArtifactData',0x18,'"3001"'))
defaults('PlayerCustomizationData','''if (ToolModule.StringTool.IsNullOrEmpty(playerName, true))
{
    int number = 0;
    for (int i = 0; i < 6; i++)
    {
        int digit = new global::System.Random().Next(0, 9);
        number += (int)global::System.Math.Pow(10, i) * digit;
    }
    playerName = "User" + number.ToString();
}''')
defaults('PlayerCoreData',val('PlayerCoreData',0x5C,'true')+'\n'+val('PlayerCoreData',0x20,'20')+'\nfor (int i = 0; i < 4; i++)\n    '+field('PlayerCoreData',0x60)['Name']+'.Add(global::UnityEngine.Random.Range(0, 100) < 80 ? 1 : 2);')
defaults('PlayerGuideData',val('PlayerGuideData',0x10,'true'))
f=field('PlayerCoreData',0xB8)
add('PlayerCoreData','Init','base.Init();\nif ('+f['Name']+' == null) '+new('PlayerCoreData',0xB8))
season=dict(path='Assets/Scripts/Assembly-CSharp/DataModule/SeasonData.cs',autoProperties=[],methods=[dict(token='0x600593D',body='''{
allSeasonData = new global::System.Collections.Generic.Dictionary<string, global::DataModule.SingleSeasonData>();
allWeeklyClashData = new global::System.Collections.Generic.Dictionary<string, global::DataModule.SingleWeeklyClashData>();
}''',makeAsync=False,iterator=False)])
files.append(season)
(w/'write-plan.json').write_text(json.dumps(dict(files=files),ensure_ascii=False,indent=2),encoding='utf-8');(w/'curated-body-map.json').write_text(json.dumps(facts,ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(files),'files and',sum(len(x['methods']) for x in files),'original selected bodies; no protected accessors or TimeData changes')
