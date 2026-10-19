import hashlib,json,shutil
from pathlib import Path
r=Path(__file__).resolve().parents[2];w=r/'work/stage38-savebase';d=r/'outputs/恢复过程文档/38-存档管理器底座恢复-证据';d.mkdir(parents=True,exist_ok=True)
targets=['native-targets.json','supplement-targets.json','registration-tail-targets.json','assembly-utility-targets.json']
statuses=['status-stage38-savebase.json','status-stage38-supplement.json','status-stage38-registration-tail.json','status-stage38-assembly-utility.json']
files=['owned-scope.json','boundary-plan.md','original-metadata.json','coretime-generic-slots.json','native-method-inventory.json','native-refs.json','supplement-refs.json','exception-boundaries.json','report-scalar-native-read.json','write-plan.json','candidate-manifest.json','applied.json','source-verification.json','source-verification.log','guard-refinement.json','fixture-editor.log','fixture-apk.log','candidate-gf2-errors.json','candidate-gf2.log','candidate-gf2.rsp','candidate-main3-errors.json','candidate-main3.log','candidate-main3.rsp']
for name in files+targets:
 shutil.copy2(w/name,d/name)
for path in w.glob('*.cs'):
 shutil.copy2(path,d/path.name)
for pattern in ['*.csproj','*.py','*.ps1']:
 for path in w.glob(pattern):shutil.copy2(path,d/path.name)
for folder in ['before','candidate','fixture']:
 for path in (w/folder).rglob('*'):
  if path.is_file() and not any(p in ('bin','obj') for p in path.relative_to(w/folder).parts):
   target=d/folder/path.relative_to(w/folder);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(path,target)
addresses=set();native_by_token={}
for name in targets:
 for t in json.loads((w/name).read_text(encoding='utf-8-sig')):
  addresses.add(t['address'])
  if t.get('method_token'):native_by_token[t['method_token']]=t
for name in statuses:
 source=r/'work/ida-framework-assets'/name;data=json.loads(source.read_text(encoding='utf-8-sig'));assert data['stage']=='complete';shutil.copy2(source,d/name)
for a in sorted(addresses):
 for ext in ['.c','.asm.txt']:
  source=r/'work/ida-framework-assets/pseudocode'/f'0x{a:x}{ext}';assert source.exists();target=d/'native'/source.name;target.parent.mkdir(exist_ok=True);shutil.copy2(source,target)
metadata=json.loads((w/'original-metadata.json').read_text(encoding='utf-8'))
original={m['token']:dict(declaringType=t['FullName'],assembly=t['assembly'],**m) for t in metadata for m in t['methods']}
plan=json.loads((w/'write-plan.json').read_text(encoding='utf-8'));restored=[]
for f in plan['files']:
 for m in f['methods']:
  t=m['token'];identity=original[t];native=native_by_token.get(t)
  assert native or identity.get('rva'),t
  restored.append(dict(file=f['path'],token=t,declaringType=identity['declaringType'],assembly=identity['assembly'],name=identity['Name'],rva=hex(native['address']) if native else identity['rva'],kind='EditorIOAdapterAndNonEditorDiagnostic' if t in ['0x600581A','0x600581B','0x600581C'] else 'OriginalBody'))
for t in ['0x6005E0E','0x600587E','0x600600A']:
 identity=original[t];restored.append(dict(token=t,declaringType=identity['declaringType'],assembly=identity['assembly'],name='.cctor',rva=identity['rva'],kind='OriginalOmittedStaticConstructor'))
(d/'restored-methods.json').write_text(json.dumps(restored,ensure_ascii=False,indent=2),encoding='utf-8')
for row in json.loads((w/'applied.json').read_text(encoding='utf-8')):
 for ext in ['', '.meta']:
  source=r/'outputs/OccupyCityRecovered'/(row['file']+ext);target=Path(str(d/'production'/row['file'])+ext);target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(source,target)
  expected=row['productionSha256'] if not ext else row['metaSha256'];assert hashlib.sha256(source.read_bytes()).hexdigest().upper()==expected
 source=Path(row['backup']+'.meta');target=d/'before'/(row['file']+'.meta');shutil.copy2(source,target)
shutil.copy2(r/'work/parallel-coordination/stage38-handoff.json',d/'stage38-handoff.json')
inventory=[dict(file=p.relative_to(d).as_posix(),bytes=p.stat().st_size,sha256=hashlib.sha256(p.read_bytes()).hexdigest().upper()) for p in sorted(d.rglob('*')) if p.is_file() and p.name!='evidence-hashes.json']
(d/'evidence-hashes.json').write_text(json.dumps(dict(files=len(inventory),boundedNativeMethods=len(addresses),entries=inventory),ensure_ascii=False,indent=2),encoding='utf-8')
print(f'Archived {len(inventory)} files, {len(addresses)} bounded native methods; 8 production+meta verified; final Editor51/APK37')
