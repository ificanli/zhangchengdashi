import hashlib,json,re,sys
from pathlib import Path
WORK=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-44-battle')
sys.path.insert(0,str(WORK))
from bootstrap import members
REL='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameSceneManager.cs'
is_next='--next' in sys.argv
candidate_path=WORK/('candidate-next' if is_next else 'candidate')/REL
source=(WORK/'source-before'/REL).read_text(encoding='utf-8-sig')
candidate=candidate_path.read_text(encoding='utf-8-sig')
before=members(source);after={m['token']:m for m in members(candidate)}
protected=[m for m in before if not m['stub']]
assert all(m['body']==after[m['token']]['body'] for m in protected)
assert re.findall(r'\[Token\(Token = "(0x[0-9A-Fa-f]+)"\)\]',source)==re.findall(r'\[Token\(Token = "(0x[0-9A-Fa-f]+)"\)\]',candidate)
manifest=json.loads((WORK/('scene-recovery.next.json' if is_next else 'scene-recovery.json')).read_text(encoding='utf-8'))
native=json.loads((WORK/'ida/status-supplement.json').read_text(encoding='utf-8'))
status_by_rva={int(x['address']):x for x in native['methods']}
addresses=[int(m['rva'],16) for m in manifest['methods']]+[0x3DF9248,0x3DFC2C4,0x3DFE8C8,0x3DFF208,0x3DFFA6C,0x3DFF63C,0x3DFEDD4]
if len(manifest['methods'])>60:addresses += [0x3DFE48C,0x3DFCE18,0x3DFD310]
boundaries=[]
for addr in addresses:
    row=status_by_rva[addr]
    assert int(row['actual_function_start'],16)==addr
    assert int(row['actual_function_end'],16)==row['end']
    code=(WORK/'ida/pseudocode'/(hex(addr)+'.c')).read_text(encoding='utf-8')
    has_jumpout='JUMPOUT(' in code
    resolved=None
    if has_jumpout:
        assert addr==0x3DFD310 and 'JUMPOUT(0x3D313B0)' in code,(hex(addr),row['name'])
        tail=json.loads((WORK/'scene-validation/prewarm-builder-tail.json').read_text(encoding='utf-8'))
        assert tail['identified_as']=='AsyncUniTaskVoidMethodBuilder.SetResult'
        resolved='Exact native builder tail 0x3D313B0-0x3D31494; IStateMachineRunner.ReturnAction / AddContinuation(13) / runner=null; see prewarm-builder-tail.json and ASM.'
    boundaries.append(dict(rva=hex(addr),end=hex(row['end']),name=row['name'],prototype_applied=row.get('prototype_applied'),has_jumpout=has_jumpout,resolved=resolved))
test_suffix='-next' if is_next else ''
candidate_test=json.loads((WORK/f'scene-validation/candidate{test_suffix}-result.json').read_text(encoding='utf-8'))
baseline_test=json.loads((WORK/f'scene-validation/baseline{test_suffix}-result.json').read_text(encoding='utf-8'))
assert candidate_test['failed']==0 and baseline_test['failed']>0
source_path=WORK.parent.parent/'outputs/OccupyCityRecovered'/REL
assert source_path.read_bytes()==(WORK/'source-before'/REL).read_bytes(),'Shared source changed; do not merge without parent review'
golden=json.loads((WORK/'scene-validation/native-golden.json').read_text(encoding='utf-8'))
native_operations=len(golden['capacity'])*4+len(golden['hashes'])+(len(golden['goldmine'])if len(manifest['methods'])>60 else 0)
report=dict(candidate_sha256=hashlib.sha256(candidate_path.read_bytes()).hexdigest(),shared_source_unchanged=True,protected=[dict(token=x['token'],rva=x['rva'],signature=x['signature']) for x in protected],token_sequence_unchanged=True,boundaries=boundaries,candidate=dict(scenarios=candidate_test['scenarios'],checks=candidate_test['checks'],failed=candidate_test['failed']),baseline=dict(scenarios=baseline_test['scenarios'],checks=baseline_test['checks'],failed=baseline_test['failed'],natural_zero_passes=[r['name'] for r in baseline_test['results'] if r['passed']]),native_oracle_operations=native_operations,unity='not-run',independent_compile='Original Unity rsp references/analyzers; next batch result scene-validation/compile-next/result.json')
(WORK/f'scene-validation/scene-validation{test_suffix}-summary.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(dict(methods=len(manifest['methods']),boundaries=len(boundaries),protected=len(protected),candidate=report['candidate'],baseline=report['baseline']),ensure_ascii=False))
