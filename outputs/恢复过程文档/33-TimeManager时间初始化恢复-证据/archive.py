import hashlib,json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2]
work=root/'work/stage33-time'
dest=root/'outputs/恢复过程文档/33-TimeManager时间初始化恢复-证据'
dest.mkdir(parents=True,exist_ok=True)
files=['write-plan.json','candidate-manifest.json','applied.json','source-verification.json','restored-methods.json','original-metadata.json',
       'candidate1-errors.json','candidate1.log','candidate1.rsp','fixture-editor.log','fixture-apk.log','native-refs-first.json','native-refs-checks.json',
       'native-targets.json','supplement-targets.json','time-source-boundary-targets.json','check-loop-targets.json','persistence-helper-targets.json',
       'make_plan.py','Rewrite.cs','Rewrite.csproj','Extract.cs','Extract.csproj','Verify.cs','Verify.csproj','compile-candidate.ps1','apply.py','archive.py']
for name in files:shutil.copy2(work/name,dest/name)
for folder in ['before','candidate','fixture']:
    for path in (work/folder).rglob('*'):
        if path.is_file() and not any(p in ('bin','obj') for p in path.relative_to(work/folder).parts):
            target=dest/folder/path.relative_to(work/folder);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(path,target)
status_names=['status-stage33-time.json','status-stage33-time-supplement.json','status-stage33-time-boundary.json','status-stage33-time-checks.json','status-stage33-time-persistence.json']
addresses=set()
for name in status_names:
    status=root/'work/ida-framework-assets'/name
    data=json.loads(status.read_text(encoding='utf-8-sig'))
    assert data['stage']=='complete',(name,data['stage'])
    shutil.copy2(status,dest/name)
for name in ['native-targets.json','supplement-targets.json','time-source-boundary-targets.json','check-loop-targets.json','persistence-helper-targets.json']:
    for item in json.loads((work/name).read_text(encoding='utf-8-sig')):addresses.add(item['address'])
for address in sorted(addresses):
    for ext in ['.c','.asm.txt']:
        source=root/'work/ida-framework-assets/pseudocode'/f'0x{address:x}{ext}'
        assert source.exists(),source
        target=dest/'native'/source.name;target.parent.mkdir(exist_ok=True);shutil.copy2(source,target)
for row in json.loads((work/'applied.json').read_text(encoding='utf-8')):
    for ext in ['', '.meta']:
        source=root/'outputs/OccupyCityRecovered'/(row['file']+ext)
        target=dest/'production'/row['file']
        target=Path(str(target)+ext);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(source,target)
        if not ext:assert hashlib.sha256(source.read_bytes()).hexdigest().upper()==row['productionSha256']
    source=Path(row['backup']+'.meta');target=dest/'before'/(row['file']+'.meta');shutil.copy2(source,target)
inventory=[]
for path in sorted(dest.rglob('*')):
    if path.is_file() and path.name!='evidence-hashes.json':
        inventory.append(dict(file=path.relative_to(dest).as_posix(),bytes=path.stat().st_size,sha256=hashlib.sha256(path.read_bytes()).hexdigest().upper()))
(dest/'evidence-hashes.json').write_text(json.dumps(dict(files=len(inventory),nativeMethods=len(addresses),entries=inventory),ensure_ascii=False,indent=2),encoding='utf-8')
print(f'Archived {len(inventory)} files, {len(addresses)} bounded native methods, 2 production files with unchanged meta')
