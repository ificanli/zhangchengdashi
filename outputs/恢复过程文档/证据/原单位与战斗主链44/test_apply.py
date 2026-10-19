import hashlib,json,shutil,subprocess,sys
from pathlib import Path
W=Path(__file__).resolve().parent;ROOT=W/'apply-test-project';ROOT.mkdir(exist_ok=True)
m=json.loads((W/'delivery-manifest.json').read_text(encoding='utf-8'));project=Path(m['project'])
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def reset():
 for r in m['files']:
  dest=ROOT/r['path'];dest.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(W/'source-before'/r['path'],dest);shutil.copyfile(Path(str(project/r['path'])+'.meta'),Path(str(dest)+'.meta'))
cmd=[sys.executable,'-X','utf8',str(W/'apply_candidates.py'),'--project-root',str(ROOT)]
def run(apply=False):
 p=subprocess.run(cmd+(['--apply'] if apply else []),capture_output=True,text=True,encoding='utf-8');return dict(exit_code=p.returncode,stdout=p.stdout,stderr=p.stderr)
reset();check=run();assert check['exit_code']==0
changed=ROOT/m['files'][1]['path'];changed.write_bytes(changed.read_bytes()+b'\r\n// integration race fixture\r\n')
before={r['path']:sha(ROOT/r['path']) for r in m['files']};refused=run(True);assert refused['exit_code']!=0 and 'SOURCE_CHANGED' in refused['stderr'];assert before=={r['path']:sha(ROOT/r['path']) for r in m['files']}
reset();applied=run(True);assert applied['exit_code']==0
assert all(sha(ROOT/r['path'])==r['candidate_sha256'] for r in m['files'])
again=run(True);assert again['exit_code']!=0 and 'SOURCE_CHANGED' in again['stderr']
result=dict(preflight=check,stale_source_refused_without_partial_write=refused,applied_to_disposable_project=applied,reapply_refused=again,shared_project_never_applied=True)
(W/'apply-validation.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');print('Apply script: preflight, source-change refusal, disposable apply/readback, reapply refusal all passed')
