import json,hashlib,shutil
from pathlib import Path
r=Path(__file__).resolve().parents[2];w=r/'work/stage49-model-defaults';d=r/'outputs/恢复过程文档/49-十五模型本地默认数据恢复-证据';d.mkdir(parents=True,exist_ok=True)
for p in w.iterdir():
 if p.is_file() and p.suffix in ['.json','.cs','.csproj','.py','.ps1','.rsp','.log','.md']:shutil.copy2(p,d/p.name)
for folder in ['before','candidate','fixture-common','fixture-candidate','fixture-before','fixture-mutant','fixture-actual']:
 for p in (w/folder).rglob('*'):
  if p.is_file() and not any(x in ['bin','obj'] for x in p.relative_to(w/folder).parts):
   out=d/folder/p.relative_to(w/folder);out.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(p,out)
for name in ['status-stage49-defaults.json','status-stage49-supplement.json']:
 p=r/'work/ida-framework-assets'/name;assert json.loads(p.read_text(encoding='utf-8-sig'))['stage']=='complete';shutil.copy2(p,d/name)
addresses={t['address'] for name in ['native-targets.json','supplement-targets.json'] for t in json.loads((w/name).read_text(encoding='utf-8'))}
for a in sorted(addresses):
 for ext in ['.c','.asm.txt']:
  p=r/'work/ida-framework-assets/pseudocode'/f'0x{a:x}{ext}';out=d/'native'/p.name;out.parent.mkdir(exist_ok=True);shutil.copy2(p,out)
for row in json.loads((w/'applied.json').read_text(encoding='utf-8')):
 for ext in ['','.meta']:
  p=r/'outputs/OccupyCityRecovered'/(row['file']+ext);expected=row['productionSha256'] if not ext else row['metaSha256'];assert hashlib.sha256(p.read_bytes()).hexdigest().upper()==expected
  out=Path(str(d/'production'/row['file'])+ext);out.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(p,out)
 p=Path(row['backup']+'.meta');out=d/'before'/(row['file']+'.meta');shutil.copy2(p,out)
compiled=d/'compiled-validation';compiled.mkdir(exist_ok=True);shutil.copy2(w/'Assembly-CSharp.check.dll',compiled/'Assembly-CSharp.check.dll')
shutil.copy2(r/'work/parallel-coordination/stage49-handoff.json',d/'stage49-handoff.json')
entries=[dict(file=p.relative_to(d).as_posix(),bytes=p.stat().st_size,sha256=hashlib.sha256(p.read_bytes()).hexdigest().upper()) for p in sorted(d.rglob('*')) if p.is_file() and p.name!='evidence-hashes.json']
(d/'evidence-hashes.json').write_text(json.dumps(dict(files=len(entries),nativeBoundedTargets=len(addresses),entries=entries),ensure_ascii=False,indent=2),encoding='utf-8')
print(f'Archived {len(entries)} files / {len(addresses)} native bounded targets; 14 source+meta hashes verified; original ARM6446 / actual931 / negative239+1')
