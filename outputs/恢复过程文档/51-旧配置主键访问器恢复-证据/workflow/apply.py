from pathlib import Path
import argparse,datetime,hashlib,json
R=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');W=R/'work/stage51-config-keys';P=R/'outputs/OccupyCityRecovered'
def sha(p):return hashlib.sha256(Path(p).read_bytes()).hexdigest()
def read(p):return json.loads(Path(p).read_text(encoding='utf-8-sig'))
ap=argparse.ArgumentParser();ap.add_argument('--apply',action='store_true');args=ap.parse_args();plan=read(W/'write-plan.json')
review=read(W/'independent-scope-review.json');assert review['decision']=='supported' and not review['findings'] and review['counts']['exactInverseMatches']==38
assert read(W/'compile/candidate/result.json')['exitCode']==0 and read(W/'compile/candidate/result.json')['inputsStable']
assert read(W/'config-fixture/candidate/summary.json')['checks']==830
direct=read(W/'getter-fixture/candidate/result.json');assert direct['passed'] and direct['totalTestCount']==1178 and direct['failedTestCount']==0
negative=read(W/'getter-fixture/before/result.json');assert negative['observedExpectedNegative'] and negative['failedTypeCount']==38
rows=[]
for f in plan['files']:
    p=P/f['path'];c=W/'candidate'/f['path'];m=p.with_suffix('.cs.meta')
    assert sha(p)==f['sourceBeforeSha256'],f['path']
    assert sha(c)==f['candidateSha256'] and sha(m)==f['metaSha256'],f['path']
    assert sha(W/'source-before'/f['path'])==f['sourceBeforeSha256']
    rows.append({'file':f['path'],'beforeSha256':sha(p),'candidateSha256':sha(c),'metaSha256':sha(m)})
assert len(rows)==38
backup=R/'work/recovery-stubs/stage51-config-keys'
if args.apply:
    for f in plan['files']:
        p=P/f['path'];b=backup/f['path'];b.parent.mkdir(parents=True,exist_ok=True)
        if b.exists():assert sha(b)==f['sourceBeforeSha256']
        else:b.write_bytes(p.read_bytes())
    # All targets have been hash checked before the first production mutation.
    for f in plan['files']:
        p=P/f['path'];p.write_bytes((W/'candidate'/f['path']).read_bytes())
        assert sha(p)==f['candidateSha256'] and sha(p.with_suffix('.cs.meta'))==f['metaSha256']
result={'stage':51,'scope':'Exactly38 original UniqueID.get bodies','createdAt':datetime.datetime.now().astimezone().isoformat(),'preflightAll38BeforeFirstWrite':True,'applied':args.apply,'productionSourceWrites':38 if args.apply else 0,'productionMetaWrites':0,'backup':str(backup),'rows':rows}
(W/('apply-result.json' if args.apply else 'preflight-result.json')).write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'applied':args.apply,'sourceFiles':len(rows),'metaWrites':0,'backup':str(backup)},ensure_ascii=False))
