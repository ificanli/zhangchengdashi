"""Stage44 integration tool. Default is read-only preflight; --apply writes exactly four owned .cs files."""
import argparse,hashlib,json,sys
from pathlib import Path
W=Path(__file__).resolve().parent
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
def run():
 parser=argparse.ArgumentParser(description=__doc__);parser.add_argument('--project-root',type=Path);parser.add_argument('--apply',action='store_true');args=parser.parse_args()
 manifest=json.loads((W/'delivery-manifest.json').read_text(encoding='utf-8'))
 project=(args.project_root or Path(manifest['project'])).resolve()
 rows=[]
 # All four candidates and sources are checked before the first write.
 for item in manifest['files']:
  rel=Path(item['path']);dest=(project/rel).resolve();candidate=(W/'candidate'/rel).resolve()
  if not dest.is_relative_to(project) or not candidate.is_relative_to((W/'candidate').resolve()):raise RuntimeError('Path escaped owned root')
  if sha(dest)!=item['source_before_sha256']:raise RuntimeError('SOURCE_CHANGED refuse overwrite: '+str(dest))
  if sha(candidate)!=item['candidate_sha256']:raise RuntimeError('CANDIDATE_CHANGED: '+str(candidate))
  if sha(Path(str(dest)+'.meta'))!=item['meta_sha256']:raise RuntimeError('META_CHANGED: '+str(dest))
  rows.append((dest,candidate,item))
 if args.apply:
  for dest,candidate,item in rows:
   if sha(dest)!=item['source_before_sha256']:raise RuntimeError('SOURCE_CHANGED during integration: '+str(dest))
   data=candidate.read_bytes()
   if hashlib.sha256(data).hexdigest()!=item['candidate_sha256']:raise RuntimeError('CANDIDATE_CHANGED during integration')
   temp=dest.with_name(dest.name+'.stage44.tmp')
   with temp.open('xb') as target:target.write(data)
   temp.replace(dest)
  for dest,candidate,item in rows:
   if sha(dest)!=item['candidate_sha256']:raise RuntimeError('Readback mismatch '+str(dest))
 print(json.dumps(dict(state='applied' if args.apply else 'preflight_passed',project=str(project),files=[item['path'] for _,_,item in rows]),ensure_ascii=False,indent=2))
if __name__=='__main__':
 try:run()
 except Exception as e:print(str(e),file=sys.stderr);raise SystemExit(1)
