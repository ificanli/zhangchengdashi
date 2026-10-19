"""Create an exact, deduplicated archive of non-Git recovery materials.

No source data is deleted or modified. Credential values are never emitted.
"""
from pathlib import Path
import collections
import hashlib
import json
import os
import re
import sys
import tarfile
import time

import zstandard

ROOT=Path(__file__).resolve().parents[2]
DELIVERY=ROOT/'outputs/完整资料交付'
SCRATCH=ROOT/'work/git-delivery'
PARTS=SCRATCH/'release-parts'
PARTS.mkdir(parents=True,exist_ok=True)
STATE=SCRATCH/'archive-build-progress.json'
GIT_MAX=32*1024*1024
PART_LIMIT=512*1024*1024
CACHE_NAMES={'.git','.venv','node_modules','__pycache__'}
SECRET_NAMES={'.env','.npmrc','.pypirc','credentials.json','google-services-desktop.json'}
SECRET_SUFFIXES={'.hexlic','.pfx','.p12','.pem','.key'}

def save(state):
    STATE.write_text(json.dumps(state,ensure_ascii=False,indent=2),encoding='utf-8')

def sha_file(path):
    h=hashlib.sha256()
    with path.open('rb') as stream:
        while block:=stream.read(4*1024*1024):h.update(block)
    return h.hexdigest()

def candidates():
    excluded=[]
    for base,dirs,files in os.walk(ROOT):
        relative=Path(base).relative_to(ROOT)
        kept=[]
        for name in dirs:
            child=(relative/name).as_posix()
            reason=None
            if name in CACHE_NAMES:reason='rebuildable_cache_or_nested_git'
            elif child=='work/git-delivery':reason='delivery_scratch_not_original_material'
            elif child.startswith('outputs/OccupyCityRecovered/') and name in {'Library','Temp','Logs','UserSettings','obj'}:reason='rebuildable_unity_cache'
            if reason:excluded.append(dict(path=child,reason=reason,directory=True))
            else:kept.append(name)
        dirs[:]=sorted(kept)
        for name in sorted(files):
            path=Path(base)/name
            rel=path.relative_to(ROOT).as_posix()
            if name in SECRET_NAMES or path.suffix.lower() in SECRET_SUFFIXES:
                excluded.append(dict(path=rel,reason='credential_or_original_cloud_configuration',directory=False))
                continue
            if path.suffix.lower()=='.pyc':continue
            if rel.startswith('outputs/完整资料交付/') and name not in {'build_delivery_archive.py','restore_all_materials.py','verify_delivery.py','upload_github_release.py'}:
                continue
            yield path,rel,excluded
    (DELIVERY/'排除项说明.json').write_text(json.dumps(excluded,ensure_ascii=False,indent=2),encoding='utf-8')

def inventory():
    rows=[];unique={};git_by_hash={};total=0;start=time.monotonic()
    progress_rows=SCRATCH/'partial-inventory.jsonl'
    existing={}
    if progress_rows.exists():
        for line in progress_rows.read_text(encoding='utf-8').splitlines():
            try:
                row=json.loads(line);existing[row['path']]=row
            except ValueError:pass
    journal=progress_rows.open('a',encoding='utf-8')
    locked=[]
    for index,(path,relative,_) in enumerate(candidates(),1):
        stat=path.stat();cached=existing.get(relative)
        if cached and cached['bytes']==stat.st_size and cached['sourceMtimeNs']==stat.st_mtime_ns:
            digest=cached['sha256']
        else:
            try:digest=sha_file(path)
            except PermissionError:
                locked.append(relative)
                print('Deferred locked file: '+relative,flush=True)
                continue
        after=path.stat()
        if (stat.st_size,stat.st_mtime_ns)!=(after.st_size,after.st_mtime_ns):raise RuntimeError('Source changed during archive scan: '+relative)
        is_git=(relative.startswith('outputs/') or relative in {'README.md','.gitignore','.gitattributes'}) and stat.st_size<GIT_MAX
        # Preserve built fixture DLLs in Release even when generated; git ignores bin/obj.
        if any(part in {'bin','obj'} for part in Path(relative).parts):is_git=False
        if relative.startswith('outputs/IDA分析材料/首轮反编译/') and path.suffix.lower() in {'.i64','.id0','.id1','.id2','.nam','.til'}:is_git=False
        row=dict(path=relative,bytes=stat.st_size,sha256=digest,storage='git' if is_git else 'archive',sourceMtimeNs=stat.st_mtime_ns)
        journal.write(json.dumps(row,ensure_ascii=False)+'\n');journal.flush()
        rows.append(row);total+=stat.st_size
        if is_git:git_by_hash.setdefault(digest,relative)
        else:unique.setdefault(digest,dict(path=relative,bytes=stat.st_size))
        if index%2000==0:
            save(dict(stage='hashing_inventory',files=index,totalBytes=total,elapsedSeconds=time.monotonic()-start))
            print(f'Inventory files={index} bytes={total}',flush=True)
    journal.close()
    if locked:
        save(dict(stage='inventory_waiting_for_locked_files',lockedFiles=locked,hashedFiles=len(rows)))
        raise RuntimeError('Archive not created: '+str(len(locked))+' locked files await normal application close; completed hashes are cached.')
    for row in rows:
        if row['storage']=='archive' and row['sha256'] in git_by_hash:
            row['storage']='git-copy';row['sourceGitPath']=git_by_hash[row['sha256']]
    for digest in list(unique):
        if digest in git_by_hash:del unique[digest]
    # Compiler response files and actual importer logs are evidence, even though
    # the containing Library/Logs directories are otherwise rebuildable caches.
    special=list((ROOT/'outputs/OccupyCityRecovered/Library/Bee').rglob('*.rsp'))
    special += [p for p in (ROOT/'outputs/OccupyCityRecovered/Logs').rglob('*') if p.is_file()]
    for path in sorted(special):
        relative=path.relative_to(ROOT).as_posix();stat=path.stat();digest=sha_file(path)
        rows.append(dict(path=relative,bytes=stat.st_size,sha256=digest,storage='archive',sourceMtimeNs=stat.st_mtime_ns,
                         specialEvidence='original_unity_compiler_rsp_or_actual_importer_log'))
        unique.setdefault(digest,dict(path=relative,bytes=stat.st_size));total+=stat.st_size
    result=dict(schema=1,repository='ificanli/zhangchengdashi',releaseTag='recovery-checkpoint-2026-10-19',
                files=rows,fileCount=len(rows),logicalBytes=total,archiveUniqueBlobs=len(unique),
                archiveUniqueBytes=sum(row['bytes'] for row in unique.values()),
                originalSourcePathsPreserved=True,goalStatus='paused_not_fully_playable')
    (DELIVERY/'完整资料路径与哈希清单.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
    (SCRATCH/'unique-archive-inputs.json').write_text(json.dumps(unique,ensure_ascii=False,indent=2),encoding='utf-8')
    return result,unique

class SplitWriter:
    def __init__(self):self.stream=None;self.size=0;self.index=0;self.parts=[];self.digest=None;self.position=0
    def writable(self):return True
    def tell(self):return self.position
    def flush(self):
        if self.stream:self.stream.flush()
    def _close_part(self):
        if self.stream:
            self.stream.close()
            self.parts.append(dict(name=self.name,bytes=self.size,sha256=self.digest.hexdigest()))
            self.stream=None
            (SCRATCH/'completed-parts.json').write_text(json.dumps(self.parts,indent=2),encoding='utf-8')
            print(f'Archive part complete: {self.name} {self.size} bytes',flush=True)
    def write(self,data):
        original=len(data);view=memoryview(data)
        while view:
            if self.stream is None:
                self.index+=1;self.name=f'complete-materials.tar.zst.part{self.index:03d}'
                self.stream=(PARTS/self.name).open('xb');self.size=0;self.digest=hashlib.sha256()
            take=min(len(view),PART_LIMIT-self.size);chunk=view[:take]
            self.stream.write(chunk);self.digest.update(chunk);self.size+=take;self.position+=take;view=view[take:]
            if self.size==PART_LIMIT:self._close_part()
        return original
    def close(self):self._close_part()

def pack(manifest,unique):
    writer=SplitWriter();start=time.monotonic();uncompressed=0
    save(dict(stage='compressing',blobCount=len(unique),uniqueBytes=manifest['archiveUniqueBytes']))
    compressor=zstandard.ZstdCompressor(level=3,threads=4)
    try:
        with compressor.stream_writer(writer,closefd=False) as compressed:
            with tarfile.open(fileobj=compressed,mode='w|',format=tarfile.PAX_FORMAT) as archive:
                for index,(digest,row) in enumerate(sorted(unique.items()),1):
                    path=ROOT/row['path'];stat=path.stat()
                    assert stat.st_size==row['bytes'],row['path']
                    info=tarfile.TarInfo('blobs/'+digest);info.size=row['bytes'];info.mode=0o644;info.mtime=0
                    with path.open('rb') as source:archive.addfile(info,source)
                    uncompressed+=row['bytes']
                    if index%500==0:
                        save(dict(stage='compressing',blobs=index,uniqueBlobs=len(unique),inputBytes=uncompressed,
                                  compressedBytes=writer.position,elapsedSeconds=time.monotonic()-start))
                raw=(DELIVERY/'完整资料路径与哈希清单.json').read_bytes()
                import io
                info=tarfile.TarInfo('delivery-manifest.json');info.size=len(raw);info.mode=0o644
                archive.addfile(info,io.BytesIO(raw))
        writer.close()
    except Exception:
        writer.close();raise
    result=dict(schema=1,releaseTag=manifest['releaseTag'],encoding='one tar.zst stream split into ordered parts',
                parts=writer.parts,partCount=len(writer.parts),compressedBytes=sum(p['bytes'] for p in writer.parts),
                manifestSha256=sha_file(DELIVERY/'完整资料路径与哈希清单.json'),
                originalFiles=manifest['fileCount'],originalLogicalBytes=manifest['logicalBytes'],
                uniqueArchiveBlobs=len(unique),uniqueArchiveBytes=manifest['archiveUniqueBytes'])
    (DELIVERY/'附件分卷清单.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
    save(dict(stage='archive_created_requires_verification',**result))
    print(json.dumps({key:value for key,value in result.items() if key!='parts'},ensure_ascii=False,indent=2),flush=True)

if __name__=='__main__':
    DELIVERY.mkdir(parents=True,exist_ok=True)
    if (DELIVERY/'完整资料路径与哈希清单.json').exists() and '--reuse-inventory' in sys.argv:
        manifest=json.loads((DELIVERY/'完整资料路径与哈希清单.json').read_text());unique=json.loads((SCRATCH/'unique-archive-inputs.json').read_text())
    else:manifest,unique=inventory()
    pack(manifest,unique)
