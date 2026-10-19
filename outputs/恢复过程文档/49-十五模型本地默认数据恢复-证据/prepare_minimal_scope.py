from pathlib import Path
import json
w=Path(__file__).parent;models=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'))
selected=[];deferred=[];noop=[]
for model in models:
 for m in model['ownMethods']:
  record=dict(file=model['source'],dataType=model['dataType'],token=m['token'],rva=m['rva'],name=m['Name'])
  if model['protectedExisting']:continue
  if m['Name']=='.ctor':
   if model['dataType']=='DataModule.PlayerChestData':noop.append(record)
   else:selected.append(record)
  elif m['Name']=='InitFromDefaults':
   if model['dataType'] in ['DataModule.PlayerCardData','DataModule.PlayerChestData']:noop.append(record)
   else:selected.append(record)
  elif m['Name']=='Init' and model['dataType']=='DataModule.PlayerCoreData':selected.append(record)
  else:deferred.append(record)
selected.append(dict(file='Assets/Scripts/Assembly-CSharp/DataModule/SeasonData.cs',dataType='DataModule.SeasonData',token='0x600593D',rva='0x436A224',name='.ctor',needsNative=True))
proposal=dict(stage=49,productionWritesAuthorized=False,selected=selected,nativeEquivalentNoopPreserve=noop,deferred=deferred,unknown=['ArenaCtor requires outlined block to settle field writes','SeasonData child ctor must be confirmed pure','Nontrivial Init may include GlobalInfo/ABTest/PlayerPrefs/Save/event/migration dependencies, no fake defaults'],limits='Only exact original fields in selected bodies; no blanket initialization of declared collections, no SDK/userID/success flags, preserve old108/new145 accessors and protected PlayerTimeData ctor')
(w/'minimal-scope-proposal.json').write_text(json.dumps(proposal,ensure_ascii=False,indent=2),encoding='utf-8')
print('Proposed',len(selected),'original bodies across',len(set(x['file'] for x in selected)),'files; preserve',len(noop),'native equivalent noops; defer',len(deferred),'complex Init bodies; production unauthorized')
