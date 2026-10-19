import collections,hashlib,json
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/scalar-expansion';scripts=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'
plan=json.loads((own/'source-provenance.json').read_text(encoding='utf-8-sig'));excluded=set(json.loads((own/'excluded-types.json').read_text()))
grouped=collections.defaultdict(list)
for p in plan:
    assert p['type'].split('+')[0] not in excluded
    grouped[p['sourcePath']].append(p)
sha=lambda b:hashlib.sha256(b).hexdigest().upper()
files=[]
for filename,entries in grouped.items():
    path=Path(filename);relative=path.relative_to(scripts);before=root/'work/recovery-stubs/scalar-expansion-before'/relative
    original=before.read_bytes();text=original.decode('utf-8-sig')
    for p in sorted(entries,key=lambda p:p['start'],reverse=True):
        assert text[p['start']:p['start']+p['length']]==p['before']
        text=text[:p['start']]+p['after']+text[p['start']+p['length']:]
    encoded=text.encode('utf-8-sig' if original.startswith(b'\xef\xbb\xbf') else 'utf-8')
    assert encoded==path.read_bytes(),f'Unplanned source changes in {relative}'
    assert sha(path.with_suffix('.cs.meta').read_bytes())==sha(before.with_suffix('.cs.meta').read_bytes())==entries[0]['metaHash']
    files.append({'path':str(relative),'beforeHash':sha(original),'afterHash':sha(encoded),'metaHash':entries[0]['metaHash'],'accessors':sum(2 if p['autoProperty'] else 1 for p in entries)})
samples=json.loads((own/'readback/sample-manifest.json').read_text());validation=json.loads((own/'readback/sample-validation.json').read_text());golden=json.loads((own/'readback/sample-native-golden.json').read_text())
assert len(samples)==145 and validation['methods']==145 and validation['statuses']=={'passed':145}
assert sum(len(g['cases']) for g in golden)==435 and all(g['nativeError'] is None and not g['constantOutput'] for g in golden)
previous=json.loads((root/'work/il-recovery/source-injection/source-provenance.json').read_text());older={(e['native']['TypeName'],int(e['native']['Address'],16)) for e in previous['entries']}
auto=json.loads((root/'work/il-recovery/source-injection/auto-source-provenance.json').read_text());older.update((e['proof']['type'],int(e['proof'][k]['Address'],16)) for e in auto['entries'] for k in ['getter','setter'])
new={(p['proof'][k]['methodType'],int(p['proof'][k]['address'],16)) for p in plan for k in (['getter','setter'] if p['autoProperty'] else ['native'])}
assert len(new)==145 and not new.intersection(older)
result={'newAccessors':len(samples),'explicitAccessors':sum(not p['autoProperty'] for p in plan),'autoProperties':sum(p['autoProperty'] for p in plan),'sourceFiles':len(files),'nativeInputs':435,'readbackVerified':145,'overlapWithPrevious108':0,'onlyPlannedEdits':True,'allMetaUnchanged':True,'excludedTypes':sorted(excluded),'sourceFilesDetail':files,'wholeUnityOrGameplayValidation':'not-run by this stage'}
(own/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k!='sourceFilesDetail'},ensure_ascii=False,indent=2))
for p in plan:
    if p['type'] in {'DataModule.DataManager','GameModule.HexBehaviour','GameModule.BattleGameManager'}:
        print(p['type'],p['property'],[(p['proof'][k]['address'],p['proof'][k]['methodToken'],p['proof'][k]['fieldToken']) for k in (['getter','setter'] if p['autoProperty'] else ['native'])])
