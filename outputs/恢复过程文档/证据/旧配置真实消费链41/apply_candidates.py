from pathlib import Path
import argparse,hashlib,json,os,sys
W=Path(__file__).resolve().parent
DEFAULT_PROJECT=W.parents[1]/'outputs/OccupyCityRecovered'
def sha(path):return hashlib.sha256(path.read_bytes()).hexdigest()
def apply(project,do_apply=False):
 plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8'))
 project=project.resolve(); checked=[]
 for row in plan['files']:
  rel=Path(row['path']);target=(project/rel).resolve();candidate=(W/'candidate'/rel).resolve();meta=target.with_suffix('.cs.meta')
  if not target.is_relative_to(project) or not candidate.is_relative_to((W/'candidate').resolve()):raise RuntimeError('Path escaped allowed root: '+str(rel))
  if not target.is_file() or sha(target)!=row['sourceBeforeSha256']:raise RuntimeError('SOURCE_BEFORE_SHA_MISMATCH: '+str(target))
  if not candidate.is_file() or sha(candidate)!=row['candidateSha256']:raise RuntimeError('CANDIDATE_SHA_MISMATCH: '+str(candidate))
  if not meta.is_file() or sha(meta)!=row['metaSha256']:raise RuntimeError('META_SHA_MISMATCH: '+str(meta))
  checked.append((row,target,candidate))
 # Preflight every file before writing any file. Recheck the live source directly
 # before each atomic replacement so stale handoffs never silently overwrite it.
 if do_apply:
  for row,target,candidate in checked:
   if sha(target)!=row['sourceBeforeSha256']:raise RuntimeError('SOURCE_CHANGED_DURING_APPLY: '+str(target))
   temp=target.with_name(target.name+'.stage41.tmp')
   try:
    with temp.open('xb') as stream:stream.write(candidate.read_bytes())
    os.replace(temp,target)
   finally:
    if temp.exists():temp.unlink()
  for row,target,candidate in checked:
   if sha(target)!=row['candidateSha256']:raise RuntimeError('APPLY_READBACK_MISMATCH: '+str(target))
 return {'stage':41,'status':'applied' if do_apply else 'preflight_passed','projectRoot':str(project),'files':[row['path'] for row,_,_ in checked],'sourceBeforeProtected':True,'metaProtected':True}
if __name__=='__main__':
 parser=argparse.ArgumentParser(description='Stage41 source-before guarded apply; default is check-only.')
 parser.add_argument('--project-root',type=Path,default=DEFAULT_PROJECT);parser.add_argument('--apply',action='store_true');args=parser.parse_args()
 try:print(json.dumps(apply(args.project_root,args.apply),ensure_ascii=False,indent=2))
 except Exception as exc:print(str(exc),file=sys.stderr);sys.exit(2)
