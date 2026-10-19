import difflib
import hashlib
import json
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/ecs-group-recovery'
SOURCE = ROOT / 'outputs/OccupyCityRecovered/Assets/Scripts/AstarPathfindingProject/Pathfinding/ECS/AIMovementSystemGroup.cs'
BEFORE = OWN / 'source-before/AIMovementSystemGroup.cs'
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()
old = BEFORE.read_text(encoding='utf-8-sig')
new = SOURCE.read_text(encoding='utf-8-sig')
tokens = lambda text: re.findall(r'\[Token\(Token = "(0x[\da-fA-F]+)"\)\]', text)
assert tokens(old) == tokens(new)
assert sha(SOURCE.with_suffix('.cs.meta')) == sha(BEFORE.with_suffix('.cs.meta'))
reverted = new.replace('private float maximumDt = 1f / 30f;', 'private float maximumDt;').replace('public double CustomTimeScale = 1d;', 'public double CustomTimeScale;')
restored = {
    'public TimeScaledRateManager()': ['cheapTimeDataQueue = new NativeList<TimeData>(Allocator.Persistent);','timeDataQueue = new NativeList<TimeData>(Allocator.Persistent);'],
    'public void Dispose()': ['cheapTimeDataQueue.Dispose();','timeDataQueue.Dispose();'],
    'protected override void OnDestroy()': ['base.OnDestroy();','(RateManager as TimeScaledRateManager).Dispose();'],
    'protected override void OnCreate()': ['base.OnCreate();','RateManager = new TimeScaledRateManager();'],
}
for signature, statements in restored.items():
    pos = reverted.index(signature)
    begin = reverted.index('{', pos)
    end = reverted.index('}', begin)
    assert [line.strip() for line in reverted[begin+1:end].strip().splitlines()] == statements
    reverted = reverted[:begin+1] + '\n' + ('\t\t\t' if signature.startswith('public ') else '\t\t') + reverted[end:]
assert reverted == old, 'unexpected change outside four method bodies and two field initializers'
metadata = json.loads((OWN/'metadata-identities.json').read_text())
base = next(t for t in metadata if t['type']=='Unity.Entities.ComponentSystemGroup')
rate_field = next(f for f in base['fields'] if f['Name']=='m_RateManager')
assert rate_field['Offset']==0x88 and rate_field['type']=='Unity.Entities.IRateManager' and rate_field['token']=='0x04000071'
native = []
for name in ['status-ecs-create.json','status-ecs-dispose.json']:
    data = json.loads((ROOT/'work/ida-framework-assets'/name).read_text())
    assert data['stage']=='complete'
    native += data['methods']
assert len(native)==4 and all(m['actual_function_start']==hex(m['address']) and m['actual_function_end']==hex(m['end']) and not m['unresolved_jumpout'] for m in native)
il = (OWN/'compile/actual.il.txt').read_text(encoding='utf-8-sig')
def method(owner,name):
    end = il.index('} // end of method '+owner+'::'+name)
    start = il.rfind('.method ',0,end)
    return il[start:end]
create = method('AIMovementSystemGroup','OnCreate')
destroy = method('AIMovementSystemGroup','OnDestroy')
ctor = method('TimeScaledRateManager','.ctor')
dispose = method('TimeScaledRateManager','Dispose')
checks = {
    'create_base_then_manager_then_set':create.index('ComponentSystemGroup::OnCreate()')<create.index('TimeScaledRateManager::.ctor()')<create.index('ComponentSystemGroup::set_RateManager'),
    'destroy_base_then_isinst_then_dispose':destroy.index('ComponentSystemGroup::OnDestroy()')<destroy.index('isinst Pathfinding')<destroy.index('TimeScaledRateManager::Dispose()'),
    'initializers_before_object_constructor':ctor.index('::maximumDt')<ctor.index('::CustomTimeScale')<ctor.index('System.Object::.ctor()'),
    'float32_original_maximum_dt':'ldc.r4 0.033333335' in ctor,
    'original_custom_time_scale':'ldc.r8 1' in ctor,
    'two_persistent_native_lists':ctor.count('ldc.i4.4')==2 and ctor.count('Unity.Core.TimeData>::.ctor')==2,
    'constructor_cheap_then_full':ctor.index('::cheapTimeDataQueue')<ctor.index('::timeDataQueue'),
    'dispose_cheap_then_full':dispose.index('::cheapTimeDataQueue')<dispose.index('::timeDataQueue') and dispose.count('Unity.Core.TimeData>::Dispose()')==2,
    'no_extra_lifecycle_branch':not re.search(r'IL_[\da-f]+: (br|beq|bne|leave)',create+destroy+dispose),
    'still_unrestored_update':'IL_0000: ret' in method('AIMovementSystemGroup','OnUpdate'),
}
assert all(checks.values()), checks
assert 'RESULT scenarios=8 checks=36 failures=0' in (OWN/'tests/actual-run.log').read_text(encoding='utf-8-sig')
assert 'RESULT scenarios=8 checks=2 failures=8' in (OWN/'tests/baseline-run.log').read_text(encoding='utf-8-sig')
oracle=json.loads((OWN/'native-lifecycle-oracle.json').read_text())
assert oracle['cases']==3 and len(oracle['methods'])==4
report = dict(stage=34,status='single-source-applied-and-independently-verified',sourceBeforeSha256=sha(BEFORE),sourceAfterSha256=sha(SOURCE),metaSha256=sha(SOURCE.with_suffix('.cs.meta')),sourceFile=str(SOURCE),preservedTokenSequence=True,restoredMethods=4,restoredFieldInitializers=2,nativeMethodBoundaries=4,nativeLifecycleCases=3,controlFlowScenarios=8,controlFlowChecks=36,baselineFailures=8,ILChecks=checks,baseRateManagerField=rate_field,unrestored=['OnUpdate','ShouldGroupUpdate','OnSimulationStepsFinished','CustomTimeScale get/set','RateManager static and scalar properties'],UnityValidation='not-run by this stage; root owns follow-up Play',pathfindingAcceptance=False)
(OWN/'final-audit.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OWN/'AIMovementSystemGroup.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(),new.splitlines(),fromfile='before/AIMovementSystemGroup.cs',tofile='after/AIMovementSystemGroup.cs',lineterm='')),encoding='utf-8')
print(json.dumps(report,ensure_ascii=False,indent=2))
