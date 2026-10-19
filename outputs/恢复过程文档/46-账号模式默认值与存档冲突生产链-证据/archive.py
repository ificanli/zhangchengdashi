import json,hashlib,shutil
from pathlib import Path
r=Path(__file__).resolve().parents[2];w=r/'work/stage46-account-mode';d=r/'outputs/恢复过程文档/46-账号模式默认值与存档冲突生产链-证据';d.mkdir(parents=True,exist_ok=True)
for path in w.iterdir():
 if path.is_file() and path.suffix in ['.json','.cs','.csproj','.py','.ps1','.rsp','.log']:shutil.copy2(path,d/path.name)
for folder in ['before','candidate']:
 for path in (w/folder).rglob('*'):
  if path.is_file():target=d/folder/path.relative_to(w/folder);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(path,target)
for name in ['status-stage46-account.json','status-stage46-conflict.json','xrefs-stage46-account.json']:
 path=r/'work/ida-framework-assets'/name
 if name.startswith('status-'):assert json.loads(path.read_text(encoding='utf-8-sig'))['stage']=='complete'
 shutil.copy2(path,d/name)
addresses={t['address'] for name in ['native-targets.json','conflict-producer-targets.json'] for t in json.loads((w/name).read_text(encoding='utf-8'))}
for a in sorted(addresses):
 for ext in ['.c','.asm.txt']:
  source=r/'work/ida-framework-assets/pseudocode'/f'0x{a:x}{ext}';target=d/'native'/source.name;target.parent.mkdir(exist_ok=True);shutil.copy2(source,target)
for row in json.loads((w/'applied.json').read_text(encoding='utf-8')):
 for ext in ['','.meta']:
  source=r/'outputs/OccupyCityRecovered'/(row['file']+ext);expected=row['productionSha256'] if not ext else row['metaSha256'];assert hashlib.sha256(source.read_bytes()).hexdigest().upper()==expected
  target=Path(str(d/'production'/row['file'])+ext);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(source,target)
 source=Path(row['backup']+'.meta');target=d/'before'/(row['file']+'.meta');shutil.copy2(source,target)
compiled=d/'compiled-validation';compiled.mkdir(exist_ok=True);shutil.copy2(w/'GFRunning.check.dll',compiled/'GFRunning.check.dll')
handoff=r/'work/parallel-coordination/stage46-handoff.json';j=json.loads(handoff.read_text(encoding='utf-8'));j['readonlyConflictAudit']={'nativeMethods':9,'status':'complete readonly; production scope not authorized','scope':'DataCompareMgr plus SaveConflictCanvas original decision/confirm boundaries','remaining':'VersionConflict / CheckSaveUserID / OnLTDataCallback and original server/UI closures require separate scope; no fake proxy or Finish writes'};handoff.write_text(json.dumps(j,ensure_ascii=False,indent=2),encoding='utf-8');shutil.copy2(handoff,d/handoff.name)
entries=[dict(file=p.relative_to(d).as_posix(),bytes=p.stat().st_size,sha256=hashlib.sha256(p.read_bytes()).hexdigest().upper()) for p in sorted(d.rglob('*')) if p.is_file() and p.name!='evidence-hashes.json']
(d/'evidence-hashes.json').write_text(json.dumps(dict(files=len(entries),nativeMethods=len(addresses),entries=entries),ensure_ascii=False,indent=2),encoding='utf-8')
print(f'Archived {len(entries)} files and {len(addresses)} native methods; actual compiled GF DLL preserved; source/meta verified')
