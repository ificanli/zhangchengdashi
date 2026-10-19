from pathlib import Path
import importlib.util,json,hashlib,shutil
W=Path(__file__).resolve().parent;V=W/'verification/apply-fixture';V.mkdir(parents=True,exist_ok=True)
spec=importlib.util.spec_from_file_location('stage41_apply',W/'apply_candidates.py');module=importlib.util.module_from_spec(spec);spec.loader.exec_module(module)
plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8'));project=V/'project';staged=V/'handoff';staged.mkdir(parents=True,exist_ok=True)
shutil.copy2(W/'write-plan.json',staged/'write-plan.json')
for row in plan['files']:
 rel=row['path'];dst=project/rel;dst.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(W/'source-before'/rel,dst);shutil.copy2((W/'source-before'/rel).with_suffix('.cs.meta'),dst.with_suffix('.cs.meta'));cand=staged/'candidate'/rel;cand.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(W/'candidate'/rel,cand)
module.W=staged
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
before={x['path']:sha(project/x['path']) for x in plan['files']};results=[]
def run(name,fn,expected=None):
 try:
  value=fn();assert expected is None,(name,'expected rejection');results.append({'name':name,'passed':True,'status':value['status']})
 except RuntimeError as exc:
  assert expected and expected in str(exc),(name,str(exc));results.append({'name':name,'passed':True,'rejection':str(exc)})
run('complete preflight',lambda:module.apply(project))
target=project/plan['files'][-1]['path'];original=target.read_bytes();target.write_bytes(original+b'\n// concurrent edit\n')
run('stale third source rejects before first write',lambda:module.apply(project,True),'SOURCE_BEFORE_SHA_MISMATCH')
assert all(sha(project/x['path'])==before[x['path']] for x in plan['files'][:-1]);target.write_bytes(original)
candidate=staged/'candidate'/plan['files'][0]['path'];original_candidate=candidate.read_bytes();candidate.write_bytes(original_candidate+b'\n')
run('tampered candidate rejects',lambda:module.apply(project,True),'CANDIDATE_SHA_MISMATCH');candidate.write_bytes(original_candidate)
meta=target.with_suffix('.cs.meta');original_meta=meta.read_bytes();meta.write_bytes(original_meta+b'\n')
run('modified meta rejects',lambda:module.apply(project,True),'META_SHA_MISMATCH');meta.write_bytes(original_meta)
run('valid fixture apply with readback',lambda:module.apply(project,True))
assert all(sha(project/x['path'])==x['candidateSha256'] for x in plan['files'])
run('repeat apply refuses changed source',lambda:module.apply(project,True),'SOURCE_BEFORE_SHA_MISMATCH')
result={'cases':results,'caseCount':len(results),'allPassed':all(x['passed'] for x in results),'sharedProjectWritten':False,'fixtureRoot':str(V)}
(W/'verification/apply-guard-result.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(result,ensure_ascii=False,indent=2))
