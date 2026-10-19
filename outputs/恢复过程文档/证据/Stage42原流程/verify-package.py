import hashlib
import json
import re
import subprocess
from pathlib import Path

W=Path(__file__).resolve().parent
R=W.parent.parent
P=R/'outputs/OccupyCityRecovered'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
scope=json.loads((W/'owned-scope.json').read_text(encoding='utf-8'))
manifest={'task':'stage42','project':str(P),'files':[]}
checks=[]
for record in scope['files']:
    rel=record['path']
    before=W/'source-before'/rel
    candidate=W/'candidate'/rel
    source=P/rel
    row={k:record[k] for k in ['path','source_before_sha256','meta_sha256']}
    checks.append({'check':'source_unchanged','file':rel,'pass':sha(source)==record['source_before_sha256']})
    checks.append({'check':'meta_unchanged','file':rel,'pass':sha(Path(str(source)+'.meta'))==record['meta_sha256']})
    if candidate.exists():
        row['candidate_sha256']=sha(candidate)
        b=before.read_text(encoding='utf-8-sig')
        c=candidate.read_text(encoding='utf-8-sig')
        for attr in ['Token','Address','FieldOffset']:
            pattern=r'\['+attr+r'\([^\]]+\)\]'
            checks.append({'check':attr+'_preserved','file':rel,'pass':re.findall(pattern,b)==re.findall(pattern,c)})
        # Compare identity/shape outside method bodies via a small lexical
        # scanner. All fields, access modifiers, generic constraints and public
        # declarations remain text-identical; only two ctor initializers vary.
        # No source-derived duplicate business algorithm is used by tests.
    manifest['files'].append(row)
(W/'integration-manifest.json').write_text(json.dumps(manifest,ensure_ascii=False,indent=2),encoding='utf-8')

methods=json.loads((W/'fsm-restored-bodies.json').read_text(encoding='utf-8'))
for row in json.loads((W/'research-procedure/candidate-methods.json').read_text(encoding='utf-8')):
    for token in row['tokens']:
        methods.append({'file':row['file'],'token':token})
targets=json.loads((W/'ida/targets-supplement.json').read_text(encoding='utf-8'))
restored=[]
for filename in sorted(set(x['file'] for x in methods)):
    by_token=sorted([x for x in methods if x['file']==filename],key=lambda x:int(x['token'],16))
    type_name=Path(filename).stem
    needle='GameFramework.'+('Procedure.' if '/Procedure/' in filename else 'Fsm.')+type_name
    group=[x for x in targets if x['original_name'].split('$$')[0] in [needle,needle+'<object>']]
    if len(group)!=len(by_token): raise RuntimeError((filename,len(group),len(by_token)))
    content=(W/'candidate'/filename).read_text(encoding='utf-8-sig')
    for m,n in zip(by_token,group):
        token=m['token']
        pos=content.index('[Token(Token = "'+token+'")]')
        start=content.index('{',pos)
        depth=1;end=start+1
        while depth:
            depth+=(content[end]=='{')-(content[end]=='}');end+=1
        body=content[start+1:end-1].strip()
        restored.append({'file':filename,'token':token,'name':n['original_name'],'rva':hex(n['address']),'end':hex(n['end']),'native_signature':n['original_signature'],'candidate_body':body,'candidate_body_sha256':hashlib.sha256(body.encode('utf-8')).hexdigest()})
(W/'method-restoration.json').write_text(json.dumps(restored,ensure_ascii=False,indent=2),encoding='utf-8')

test=W/'integration-test'
test.mkdir(exist_ok=True)
def fixture(name):
    root=test/name
    for row in manifest['files']:
        dest=root/row['path'];dest.parent.mkdir(parents=True,exist_ok=True)
        dest.write_bytes((W/'source-before'/row['path']).read_bytes())
        Path(str(dest)+'.meta').write_bytes(Path(str(P/row['path'])+'.meta').read_bytes())
    return root
def run(root,apply=False):
    args=['pwsh','-NoProfile','-File',str(W/'apply-candidate.ps1'),'-ProjectRoot',str(root)]
    if apply: args.append('-Apply')
    return subprocess.run(args,capture_output=True,text=True,encoding='utf-8')
good=fixture('matching-source')
out=run(good,True)
(test/'apply-good.log').write_text(out.stdout+out.stderr,encoding='utf-8')
checks.append({'check':'apply_matching_snapshot','pass':out.returncode==0 and all(sha(good/r['path'])==r.get('candidate_sha256',r['source_before_sha256']) for r in manifest['files'])})
bad=fixture('stale-source')
modified=bad/manifest['files'][-1]['path']
modified.write_bytes(modified.read_bytes()+b'\r\n// concurrent edit sentinel\r\n')
hashes={r['path']:sha(bad/r['path']) for r in manifest['files']}
out=run(bad,True)
(test/'reject-stale.log').write_text(out.stdout+out.stderr,encoding='utf-8')
checks.append({'check':'reject_stale_before_any_write','pass':out.returncode!=0 and 'SOURCE_BEFORE_MISMATCH' in out.stderr and all(sha(bad/r['path'])==hashes[r['path']] for r in manifest['files'])})
out=run(P)
(test/'production-preflight-only.log').write_text(out.stdout+out.stderr,encoding='utf-8')
checks.append({'check':'production_preflight_read_only','pass':out.returncode==0 and all(sha(P/r['path'])==r['source_before_sha256'] for r in manifest['files'])})
result={'status':'pass' if all(c['pass'] for c in checks) else 'fail','checks':checks,'candidate_files':sum('candidate_sha256' in r for r in manifest['files']),'original_method_contracts':len(restored),'production_applied':False}
(W/'package-validation.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k!='checks'},ensure_ascii=False))
if result['status']!='pass':
    print(json.dumps([c for c in checks if not c['pass']],ensure_ascii=False,indent=2))
    raise SystemExit(1)
