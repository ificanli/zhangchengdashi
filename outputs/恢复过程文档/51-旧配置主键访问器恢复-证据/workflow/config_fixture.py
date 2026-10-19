from pathlib import Path
import argparse,hashlib,json,subprocess,xml.etree.ElementTree as ET
R=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');W=R/'work/stage51-config-keys';P=R/'outputs/OccupyCityRecovered';OLD=R/'work/parallel-41-config'
def sha(p):return hashlib.sha256(Path(p).read_bytes()).hexdigest()
def run(mode):
    assert mode in ['before','candidate','actual']
    out=W/'config-fixture'/mode;out.mkdir(parents=True,exist_ok=True)
    plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8-sig'));owned={x['path']:x for x in plan['files']}
    # The reviewed final production41 chain is used, not a new reimplementation or test-local getter mutation.
    handoff=json.loads((R/'work/parallel-coordination/stage41-handoff.json').read_text(encoding='utf-8-sig'))
    for f in handoff['ownedFiles']:assert sha(P/f['path'])==f['candidateSha256']
    template=ET.parse(OLD/'tests/generated/candidate-current-getters/ConfigChainHarness.csproj')
    inputs={}
    for elem in template.findall('.//Compile'):
        path=Path(elem.attrib['Include'])
        if path.name=='Program.cs':continue
        if 'candidate/Assets/' in str(path).replace('\\','/'):
            path=P/Path(str(path).replace('\\','/').split('candidate/')[1])
        if path.is_relative_to(P):
            rel=path.relative_to(P).as_posix()
            if rel in owned:path=(W/'source-before'/rel if mode=='before' else W/'candidate'/rel if mode=='candidate' else P/rel)
        elem.attrib['Include']=str(path);inputs[str(path)]=sha(path)
    source=(OLD/'tests/Program.cs').read_text(encoding='utf-8-sig')
    source=source.replace('candidate-current-getters','stub-getters').replace('candidate-fixture-getters','restored-getters')
    source=source.replace('Standalone actual-source execution through controlled resource/TextAsset/JsonUtility adapters; does not prove Unity JsonUtility or Editor integration. Fixture getter mode changes only test-local copies of 38 native-proven row getters.','Original final production ConfigMgr/ConfigRead/BaseConfig plus actual38 before/candidate/production row source files. Only external resource/TextAsset/JsonUtility adapters are controlled. JSON is System.Text.Json, not Unity JsonUtility or Editor acceptance. No fixture getter business replacement is generated.')
    program=out/'Program.cs';program.write_text(source,encoding='utf-8')
    pe=next(e for e in template.findall('.//Compile') if Path(e.attrib['Include']).name=='Program.cs');pe.attrib['Include']=str(program);inputs[str(program)]=sha(program)
    proj=out/'ConfigChainHarness.csproj';template.write(proj,encoding='utf-8',xml_declaration=False)
    expected=OLD/'tests/generated/candidate-current-getters/expected.json';inputs[str(expected)]=sha(expected)
    (out/'inputs-before.json').write_text(json.dumps(inputs,ensure_ascii=False,indent=2),encoding='utf-8')
    args=['dotnet','run','--project',str(proj),'-c','Release','--','stub-getters' if mode=='before' else 'restored-getters',str(expected),str(out/'result.json')]
    p=subprocess.run(args,cwd=R,text=True,encoding='utf-8',errors='replace',capture_output=True)
    (out/'run.log').write_text(p.stdout+p.stderr,encoding='utf-8')
    after={k:sha(k) for k in inputs};assert after==inputs,'Configuration fixture input source mutated during run'
    (out/'inputs-after.json').write_text(json.dumps(after,ensure_ascii=False,indent=2),encoding='utf-8')
    assert p.returncode==0,(p.stdout,p.stderr)
    result=json.loads((out/'result.json').read_text(encoding='utf-8-sig'));assert result['passed'] and all(x['passed'] for x in result['checks'])
    if mode=='before':
        b=next(x for x in result['boundaries'] if x['scenario']=='candidate-current-row-getters')
        assert b['exception']=='ArgumentNullException' and b['readCount']==0 and b['ready']==False
    else:assert (result['rowsCompared'],result['fieldsCompared'],result['identitiesCompared'])==(927,7424,930)
    info={'mode':mode,'exitCode':p.returncode,'checks':len(result['checks']),'rowsCompared':result['rowsCompared'],'fieldsCompared':result['fieldsCompared'],'identitiesCompared':result['identitiesCompared'],'actualProduction41Chain':True,'generatedGetterBusinessSubstitutions':0,'sourceStable':True,'sourceCount':len(inputs),'command':args,'result':str(out/'result.json'),'log':str(out/'run.log'),'boundary':'System.Text.Json and external Unity/resource adapters; not Unity JsonUtility/provider runtime acceptance'}
    (out/'summary.json').write_text(json.dumps(info,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(info,ensure_ascii=False))
if __name__=='__main__':
    ap=argparse.ArgumentParser();ap.add_argument('mode',choices=['before','candidate','actual']);args=ap.parse_args();run(args.mode)
