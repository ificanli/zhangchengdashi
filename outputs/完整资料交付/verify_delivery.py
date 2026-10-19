"""Verify each compressed part and every archive blob against the path manifest."""
from pathlib import Path
import argparse
import hashlib
import json
import tarfile
import time

import zstandard
from restore_all_materials import JoinedParts,sha_file

BASE=Path(__file__).resolve().parent
ROOT=BASE.parents[1]

def main():
    parser=argparse.ArgumentParser();parser.add_argument('--parts-directory',type=Path,default=ROOT/'work/git-delivery/release-parts');args=parser.parse_args()
    manifest=json.loads((BASE/'完整资料路径与哈希清单.json').read_text(encoding='utf-8'))
    parts=json.loads((BASE/'附件分卷清单.json').read_text(encoding='utf-8'))['parts']
    expected={row['sha256']:row['bytes'] for row in manifest['files'] if row['storage']=='archive'}
    start=time.monotonic();checks=[]
    for part in parts:
        p=args.parts_directory/part['name'];actual=sha_file(p)
        if actual!=part['sha256'] or p.stat().st_size!=part['bytes']:raise RuntimeError('Part SHA mismatch')
        checks.append(dict(name=part['name'],bytes=p.stat().st_size,sha256=actual));print('Verified part',part['name'],flush=True)
    count=0;total=0
    with JoinedParts([args.parts_directory/part['name'] for part in parts]) as joined:
        with zstandard.ZstdDecompressor().stream_reader(joined) as raw:
            with tarfile.open(fileobj=raw,mode='r|') as archive:
                for member in archive:
                    if member.name=='delivery-manifest.json':continue
                    if not member.isfile() or not member.name.startswith('blobs/'):raise RuntimeError('Unexpected archive entry')
                    digest=member.name.split('/',1)[1];size=expected.pop(digest,None)
                    if size is None or size!=member.size:raise RuntimeError('Unexpected/duplicate blob or size mismatch')
                    h=hashlib.sha256();source=archive.extractfile(member)
                    while block:=source.read(4*1024*1024):h.update(block)
                    if h.hexdigest()!=digest:raise RuntimeError('Blob hash mismatch')
                    count+=1;total+=size
                    if count%1000==0:print(f'Verified archive blobs={count} bytes={total}',flush=True)
    if expected:raise RuntimeError('Missing archive blobs')
    result=dict(status='all_parts_and_decompressed_blobs_verified',parts=checks,uniqueBlobs=count,
                archiveUniqueBytes=total,logicalFiles=manifest['fileCount'],logicalBytes=manifest['logicalBytes'],
                elapsedSeconds=time.monotonic()-start,failures=0)
    (ROOT/'work/git-delivery/archive-verification.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
    print(json.dumps({k:v for k,v in result.items() if k!='parts'},ensure_ascii=False,indent=2))

if __name__=='__main__':main()
