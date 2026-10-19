import difflib
import hashlib
import json
import re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/bundleassetinfo-recovery'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs';BEFORE=OWN/'source-before/BundleAssetInfo.cs'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
proof=json.loads((OWN/'candidate-provenance.json').read_text(encoding='utf-8'))
assert SOURCE.read_bytes()==(OWN/'BundleAssetInfo.candidate.cs').read_bytes()
assert SOURCE.with_suffix('.cs.meta').read_bytes()==BEFORE.with_suffix('.cs.meta').read_bytes()
old=BEFORE.read_text(encoding='utf-8-sig');new=SOURCE.read_text(encoding='utf-8-sig');tokens=lambda text:re.findall(r'\[Token\(Token = "([^"]+)"\)\]',text)
assert tokens(old)==tokens(new)
def span(text,token):
    start=text.rfind('[Token(Token = "'+token+'")]');begin=text.index('{',start);end=begin+1;depth=1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    return start,begin,end
reverse=new
for token in [r['token']for r in proof['accessors']]+proof['constructorTokens']:
    pos,a,b=span(reverse,token);op,oa,ob=span(old,token);reverse=reverse[:a]+old[oa:ob]+reverse[b:]
reverse=reverse.replace('internal bool h_00A1Y_0097_00A1_0093 = true;','internal bool h_00A1Y_0097_00A1_0093;')
assert reverse==old
for row in proof['accessors']:
    pos,a,b=span(new,row['token']);body=new[a+1:b-1].strip()
    expected='return '+row['field']+';'if row['operation']=='ldr'else row['field']+' = _00A3_0092T_007E_00ABc;'
    assert body==expected,(row,body)
oracle=json.loads((OWN/'native-oracle.json').read_text(encoding='utf-8'))
assert oracle['scalarAccessors']==52 and oracle['scalarCases']==156 and len(oracle['constructorCases'])==4
assert 'RESULT scenarios=6 checks=24 failures=0'in(OWN/'tests/actual-run.log').read_text(encoding='utf-8-sig')
assert 'RESULT scenarios=6 checks=8 failures=6'in(OWN/'tests/baseline-run.log').read_text(encoding='utf-8-sig')
build=json.loads((OWN/'compile/actual/result.json').read_text(encoding='utf-8-sig'));assert build['exitCode']==0 and build['errorCount']==0
native=json.loads((OWN/'native-consumer-evidence.json').read_text(encoding='utf-8'))
assert len(native['methods'])==54 and len({r['token']for r in proof['accessors']})==52
result=dict(scope='Authorized stage39 dependency extension recorded under stage40',status='actual-single-value-object-restored-and-verified',sourceSha256=sha(SOURCE),sourceBeforeSha256=sha(BEFORE),metaSha256=sha(SOURCE.with_suffix('.cs.meta')),restoredConstructors=2,nativeFieldAccessors=52,fieldInitializer='original inApp=true before Object constructor',tokenSequenceUnchanged=True,sourceScopeOutsideFileEdits=0,originalNativeMethodCount=54,originalNativeBytes=sum(m['bytes']for m in native['methods']),scalarNativeCases=156,constructorNativeCases=4,actualSourceScenarios=6,actualSourceChecks=24,baselineFailures=6,actualGFCompile=build,resourceRuntimeValidation='not-run by this extension; root/legacy own actual typed provider work',noAutomaticCompletionOrIO=True)
(OWN/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
(OWN/'BundleAssetInfo.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(),new.splitlines(),fromfile='before/BundleAssetInfo.cs',tofile='after/BundleAssetInfo.cs',lineterm='')),encoding='utf-8')
handoff=dict(result,ownedSource='Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs',publicFields=['BundleName','ObfuscatorName','LocalPath','RemoteURL','Version','IsEncrypAB'],shortConstructor='Retains actual name/localPath; RemoteURL=string.Empty, version=0, isInApp=true; no fabricated unavailable-success record',fullConstructor='All 8 args retained in original fields, exact native logging gate/tag/format retained')
(ROOT/'work/parallel-coordination/stage39-bundleassetinfo-handoff.json').write_text(json.dumps(handoff,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(result,ensure_ascii=True,indent=2))
