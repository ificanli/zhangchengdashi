"""Download verified Release parts and restore every original relative material path.

Requires Python 3.10+ and zstandard. Never overwrites a changed existing file.
"""
from pathlib import Path
import argparse
import hashlib
import io
import json
import os
import shutil
import tarfile
import urllib.request

import zstandard

BASE=Path(__file__).resolve().parent

def sha_file(path):
    digest=hashlib.sha256()
    with path.open('rb') as stream:
        while block:=stream.read(4*1024*1024):digest.update(block)
    return digest.hexdigest()

class JoinedParts(io.RawIOBase):
    def __init__(self,paths):super().__init__();self.paths=iter(paths);self.current=None
    def readable(self):return True
    def readinto(self,buffer):
        while True:
            if self.current is None:
                try:self.current=next(self.paths).open('rb')
                except StopIteration:return 0
            size=self.current.readinto(buffer)
            if size:return size
            self.current.close();self.current=None
    def close(self):
        if self.current:self.current.close()
        super().close()

def confined(root,relative):
    target=(root/relative).resolve()
    if not target.is_relative_to(root.resolve()):raise RuntimeError('Manifest path escaped destination root')
    return target

def ensure_existing(target,digest):
    if not target.exists():return False
    if not target.is_file() or sha_file(target)!=digest:
        raise RuntimeError('Existing file differs; refuse overwrite: '+str(target))
    return True

def fetch_parts(parts,cache,repository,tag):
    headers={'Accept':'application/vnd.github+json','User-Agent':'OccupyCityRecoveryRestore'}
    token=os.environ.get('GITHUB_TOKEN')
    if token:headers['Authorization']='Bearer '+token
    request=urllib.request.Request(f'https://api.github.com/repos/{repository}/releases/tags/{tag}',headers=headers)
    with urllib.request.urlopen(request,timeout=60) as response:release=json.load(response)
    assets={asset['name']:asset for asset in release['assets']}
    for part in parts:
        target=cache/part['name'];asset=assets.get(part['name'])
        if asset is None:raise RuntimeError('Release asset is missing: '+part['name'])
        if target.exists() and target.stat().st_size==part['bytes'] and sha_file(target)==part['sha256']:
            print('Verified cached part:',part['name'],flush=True);continue
        temporary=target.with_suffix(target.suffix+'.download')
        req=urllib.request.Request(asset['browser_download_url'],headers={'User-Agent':'OccupyCityRecoveryRestore'})
        if release.get('private') or token:
            req=urllib.request.Request(asset['url'],headers={**headers,'Accept':'application/octet-stream'})
        with urllib.request.urlopen(req,timeout=120) as response,temporary.open('wb') as output:
            shutil.copyfileobj(response,output,4*1024*1024)
        if temporary.stat().st_size!=part['bytes'] or sha_file(temporary)!=part['sha256']:
            raise RuntimeError('Downloaded part failed SHA256: '+part['name'])
        temporary.replace(target);print('Downloaded and verified:',part['name'],flush=True)

def restore(root,cache,manifest,parts):
    by_hash={}
    for row in manifest['files']:
        if row['storage']=='archive':by_hash.setdefault(row['sha256'],[]).append(row)
    restored=0;skipped=0
    with JoinedParts([cache/part['name'] for part in parts]) as joined:
        with zstandard.ZstdDecompressor().stream_reader(joined) as raw:
            with tarfile.open(fileobj=raw,mode='r|') as archive:
                for member in archive:
                    if member.name=='delivery-manifest.json':continue
                    if not member.isfile() or not member.name.startswith('blobs/'):
                        raise RuntimeError('Unexpected archive member')
                    digest=member.name.split('/',1)[1];rows=by_hash.pop(digest,None)
                    if rows is None:raise RuntimeError('Unknown or duplicate archive blob: '+digest)
                    if any(row['bytes']!=member.size for row in rows):raise RuntimeError('Blob size differs from manifest')
                    source=archive.extractfile(member);h=hashlib.sha256()
                    first=confined(root,rows[0]['path']);exists=ensure_existing(first,digest)
                    first.parent.mkdir(parents=True,exist_ok=True)
                    temporary=first.with_name(first.name+'.restore-partial')
                    output=temporary.open('xb') if not exists else None
                    try:
                        while block:=source.read(4*1024*1024):
                            h.update(block)
                            if output:output.write(block)
                    finally:
                        if output:output.close()
                    if h.hexdigest()!=digest:raise RuntimeError('Decompressed blob SHA256 mismatch')
                    if not exists:temporary.replace(first);restored+=1
                    else:skipped+=1
                    for row in rows[1:]:
                        target=confined(root,row['path'])
                        if ensure_existing(target,digest):skipped+=1;continue
                        target.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(first,target);restored+=1
                    if (restored+skipped)%500==0:print(f'Restored={restored} existingVerified={skipped}',flush=True)
    if by_hash:raise RuntimeError('Archive did not contain all expected blobs')
    for row in manifest['files']:
        if row['storage']!='git-copy':continue
        source=confined(root,row['sourceGitPath']);target=confined(root,row['path'])
        if not ensure_existing(source,row['sha256']):raise RuntimeError('Git source is missing; clone main branch first')
        if ensure_existing(target,row['sha256']):skipped+=1;continue
        target.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(source,target);restored+=1
    print(json.dumps(dict(restoredFiles=restored,existingVerifiedFiles=skipped),indent=2))

def main():
    parser=argparse.ArgumentParser()
    parser.add_argument('--root',type=Path,default=BASE.parents[1])
    parser.add_argument('--parts-directory',type=Path)
    parser.add_argument('--download-only',action='store_true')
    parser.add_argument('--verify-only',action='store_true')
    args=parser.parse_args();root=args.root.resolve()
    manifest=json.loads((BASE/'完整资料路径与哈希清单.json').read_text(encoding='utf-8'))
    part_manifest=json.loads((BASE/'附件分卷清单.json').read_text(encoding='utf-8'))
    cache=args.parts_directory or root/'work/downloaded-delivery-parts';cache.mkdir(parents=True,exist_ok=True)
    parts=part_manifest['parts']
    if not args.parts_directory:fetch_parts(parts,cache,manifest['repository'],manifest['releaseTag'])
    for part in parts:
        path=cache/part['name']
        if not path.is_file() or path.stat().st_size!=part['bytes'] or sha_file(path)!=part['sha256']:
            raise RuntimeError('Part missing or SHA mismatch: '+part['name'])
    if not args.download_only and not args.verify_only:restore(root,cache,manifest,parts)
    elif args.verify_only:print('All delivery part sizes and SHA256 values verified.')

if __name__=='__main__':main()
