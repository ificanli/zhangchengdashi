import difflib,hashlib,json,re
from pathlib import Path
from bootstrap import members
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent
owned=json.loads((W/'owned-scope.json').read_text(encoding='utf-8'));project=Path(owned['project']);out=[]
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
for item in owned['files']:
 rel=item['path'];before=W/'source-before'/rel;candidate=W/'candidate'/rel;source=project/rel
 assert sha(before)==item['source_before_sha256']
 assert sha(source)==sha(before),'Shared source changed: '+rel
 assert sha(Path(str(source)+'.meta'))==item['meta_sha256']
 # Decode bytes directly so CRLF inside previously recovered bodies is protected.
 old=before.read_bytes().decode('utf-8-sig');new=candidate.read_bytes().decode('utf-8-sig')
 token=lambda t:re.findall(r'\[Token\(Token = "(0x[0-9A-Fa-f]+)"\)\]',t)
 address=lambda t:re.findall(r'\[Address\([^\r\n]*',t)
 assert token(old)==token(new),rel+' Token order changed'
 assert address(old)==address(new),rel+' original Address attributes changed'
 om=members(old);nm=members(new)
 assert len(om)==len(nm),rel+' declared method count changed'
 changed=[];preserved=[]
 for a,b in zip(om,nm):
  assert (a['token'],a['rva'])==(b['token'],b['rva'])
  if not a['stub']:
   assert a['body']==b['body'],rel+' overwrote recovered '+a['rva']
   preserved.append(a['rva'])
  if a['body']!=b['body']:
   assert a['stub'],rel+' overwrote nonstub '+a['rva']
   changed.append(dict(token=a['token'],rva=a['rva'],signature=b['signature'],candidate_body_sha256=hashlib.sha256(b['body'].encode()).hexdigest()))
 row=dict(path=rel,source_before_sha256=sha(before),candidate_sha256=sha(candidate),meta_sha256=item['meta_sha256'],restored_bodies=len(changed),preserved_existing_bodies=preserved,methods=changed)
 out.append(row)
 patch=W/'diffs'/(Path(rel).name+'.patch');patch.parent.mkdir(exist_ok=True)
 patch.write_text('\n'.join(difflib.unified_diff(old.splitlines(),new.splitlines(),fromfile='source-before/'+rel,tofile='candidate/'+rel,lineterm='')),encoding='utf-8')
data=dict(task=44,thread_id=owned['thread_id'],project=str(project),candidate_root=str(W/'candidate'),shared_sources_unchanged=True,metas_unchanged=True,all_original_tokens_and_addresses_preserved=True,all_existing_nonstub_bodies_byte_exact=True,files=out,total_new_bodies=sum(r['restored_bodies'] for r in out))
(W/'delivery-manifest.json').write_text(json.dumps(data,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps({k:v for k,v in data.items() if k!='files'},ensure_ascii=False,indent=2));print([(Path(r['path']).name,r['restored_bodies']) for r in out])
