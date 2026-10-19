from pathlib import Path
import json,re,hashlib
from restore_role import ROOT,WORK,DEST,extract
own=WORK/'role-validation'
before=(own/'source-before.cs').read_bytes();after=DEST.read_bytes();bs=before.decode('utf-8-sig');cs=after.decode('utf-8-sig');bm=extract(bs);cm=extract(cs)
def mask(s,methods):
 for r,x in sorted(methods.items(),key=lambda x:x[1]['a'],reverse=True):s=s[:x['a']]+'<BODY-'+hex(r)+'>'+s[x['b']:]
 return s
existing=[r for r,x in bm.items() if x['body'].strip() not in ('','return default;','return null;')]
changes=[r for r in bm if bm[r]['body']!=cm[r]['body']]
checks={'members_unchanged':list(bm)==list(cm),'tokens_unchanged':re.findall(r'\[Token\(Token = "(0x[0-9a-fA-F]+)"\)\]',bs)==re.findall(r'\[Token\(Token = "(0x[0-9a-fA-F]+)"\)\]',cs),'addresses_unchanged':re.findall(r'\[Address\([^\n]+\)\]',bs)==re.findall(r'\[Address\([^\n]+\)\]',cs),'declarations_fields_attributes_unchanged':mask(bs,bm)==mask(cs,cm),'existing_nonempty_bodies_preserved':all(bm[r]['body']==cm[r]['body'] for r in existing),'changed_count_exact_64':len(changes)==64,'shared_source_unchanged':hashlib.sha256((ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/RoleBehaviour.cs').read_bytes()).hexdigest()==hashlib.sha256(before).hexdigest()}
result={'checks':checks,'passed':all(checks.values()),'source_sha256':hashlib.sha256(before).hexdigest(),'candidate_sha256':hashlib.sha256(after).hexdigest(),'original_members':len(bm),'preserved_nonempty':[hex(r) for r in existing],'restored_count':len(changes),'restored':[{'rva':hex(r),'token':cm[r]['token'],'declaration':cm[r]['declaration'],'body_sha256':hashlib.sha256(cm[r]['body'].encode()).hexdigest()} for r in changes]}
(own/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k not in ['restored']},ensure_ascii=False))
