"""Verify every payload file in the Chinese legacy recovery delivery package."""
import argparse
import hashlib
import json
from pathlib import Path

def main(root):
    root=Path(root).resolve()
    manifest=json.loads((root/'完整哈希清单.json').read_text(encoding='utf-8'))
    failures=[]
    for row in manifest['files']:
        path=root/row['path']
        if not path.is_file(): failures.append({'path':row['path'],'reason':'missing'}); continue
        data=path.read_bytes()
        if len(data)!=row['bytes'] or hashlib.sha256(data).hexdigest()!=row['sha256']:
            failures.append({'path':row['path'],'reason':'length or SHA256 mismatch'})
    known={r['path'] for r in manifest['files']}|{'完整哈希清单.json','完整哈希清单.sha256'}
    extras=[p.relative_to(root).as_posix() for p in root.rglob('*') if p.is_file() and '__pycache__' not in p.parts and p.relative_to(root).as_posix() not in known]
    manifest_hash=hashlib.sha256((root/'完整哈希清单.json').read_bytes()).hexdigest()
    declared=(root/'完整哈希清单.sha256').read_text(encoding='utf-8').split()[0]
    result={'root':str(root),'verifiedFiles':len(manifest['files']),'failures':failures,'unexpectedFiles':extras,'manifestHashMatches':manifest_hash==declared,'success':not failures and not extras and manifest_hash==declared}
    print(json.dumps(result,ensure_ascii=True,indent=2))
    if not result['success']:raise SystemExit(1)

if __name__=='__main__':
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--root',type=Path,default=Path(__file__).resolve().parents[1])
    args=parser.parse_args();main(args.root)
