import difflib
import hashlib
import json
import re
import shutil
from pathlib import Path

OWN = Path(__file__).resolve().parent
ROOT = OWN.parents[2]
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
SOURCE = PROJECT / 'Assets/Scripts/GFRunning/GameFramework/Utility.cs'
BEFORE = OWN / 'source-before/Utility.cs'
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()
assert SOURCE.read_bytes() == (OWN / 'Utility.candidate.cs').read_bytes()
assert SOURCE.with_suffix('.cs.meta').read_bytes() == BEFORE.with_suffix('.cs.meta').read_bytes()
def mask(text):
    for token in ['0x600603C', '0x600603D']:
        pos = text.index('[Token(Token = "' + token + '")]')
        start = text.index('{', pos)
        end, depth = start + 1, 1
        while depth:
            depth += (text[end] == '{') - (text[end] == '}')
            end += 1
        text = text[:start] + '<BODY>' + text[end:]
    return text
old, new = BEFORE.read_bytes().decode('utf-8'), SOURCE.read_bytes().decode('utf-8')
assert mask(old) == mask(new)
for attr in ['Token', 'Address', 'FieldOffset']:
    assert re.findall(r'\[' + attr + r'\([^\]]+\)\]', old) == re.findall(r'\[' + attr + r'\([^\]]+\)\]', new)
(OWN / 'Utility.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(), new.splitlines(), fromfile='before/Utility.cs', tofile='after/Utility.cs', lineterm='')), encoding='utf-8')
after = OWN / 'source-after'
after.mkdir(exist_ok=True)
shutil.copy2(SOURCE, after / SOURCE.name)
shutil.copy2(SOURCE.with_suffix('.cs.meta'), after / 'Utility.cs.meta')

build = json.loads((OWN / 'compile/actual/result.json').read_text(encoding='utf-8-sig'))
probe = json.loads((OWN / 'compile/actual/full-GF-probe.json').read_text(encoding='utf-8'))
native = json.loads((OWN / 'native-results.json').read_text(encoding='utf-8'))
assert build['errorCount'] == 0 and build['exitCode'] == 0 and probe['passed'] and probe['checks'] == 16 and native['passed'] == 27
for mode, expected in [('baseline', 'RESULT scenarios=9 checks=11 failures=9'), ('candidate', 'RESULT scenarios=9 checks=43 failures=0'), ('actual', 'RESULT scenarios=9 checks=43 failures=0')]:
    assert expected in (OWN / ('tests/' + mode + '-run.log')).read_text(encoding='utf-8-sig')

text = (OWN / 'compile/actual/GF.all.il.txt').read_text(encoding='utf-8-sig')
methods = []
for end in re.finditer(r'\} // end of method Text::GetFullName\n', text):
    start = text.rfind('.method ', 0, end.start())
    methods.append(text[start:end.end()])
assert len(methods) == 2
generic, typed = methods
(OWN / 'compile/actual/Utility.Text.GetFullName.il.txt').write_text('\n'.join(methods), encoding='utf-8')
il_checks = dict(
    generic_typeof_handle_before_typed_overload='ldtoken !!T' in generic and generic.index('System.Type::GetTypeFromHandle') < generic.index('Utility/Text::GetFullName(class [mscorlib]System.Type, string)'),
    typed_original_virtual_FullName_before_name_branch=typed.index('System.Type::get_FullName()') < typed.index('System.String::IsNullOrEmpty(string)') < typed.index('brfalse'),
    exact_original_format_and_two_object_overload='ldstr "{0}.{1}"' in typed and 'System.String::Format(string, object, object)' in typed,
    empty_branch_returns_original_FullName_local=bool(re.search(r'brfalse\.s IL_0016\s+IL_0012: ldloc.0\s+IL_0013: stloc.2', typed)),
    no_added_catch_guard_or_side_effect_store='catch ' not in generic + typed and 'stfld ' not in generic + typed and 'IsNullOrEmpty(string)' not in generic,
)
assert all(il_checks.values()), il_checks
result = dict(stage='42-required-Utility-leaf', status='stable-two-original-helpers-applied-and-verified', stable=True, source='Assets/Scripts/GFRunning/GameFramework/Utility.cs', sourceBeforeSha256=sha(BEFORE), sourceSha256=sha(SOURCE), metaSha256=sha(SOURCE.with_suffix('.cs.meta')), tokens=['0x0600603C', '0x0600603D'], nativeRanges=[dict(start='0x511D668', end='0x511D6DC', bytes=116), dict(start='0x71E37C0', end='0x71E3854', bytes=148)], sourceScope=dict(onlyTwoMethodBodies=True, allOtherRawBytesUnchanged=True, AssemblyUtilityBodiesProtected=True, originalAttributesPreserved=True, metaUnchanged=True), tests=dict(scenarios=9, checks=43, failures=0, baselineScenarios=9, baselineFailures=9), native=dict(passed=27, codeHashes=native['codeHashes'], boundaries=native['boundaries']), ILChecks=il_checks, fullGFCompile=build, fullGFActualUtilityProbe=probe, compileScope='Full GFRunning production sources with six stage42 candidates substituted and actual restored Utility.cs. Stage42 integration itself remains root-owned.', UnityOperations=0, experimentDllInstalled=False, runtimeAcceptance=False, coreGameplayAccepted=False, report='outputs/恢复过程文档/42A-原流程独立复核与命名依赖扩展.md', evidence='outputs/恢复过程文档/证据/Stage42独立复核与Utility叶子')
(OWN / 'final-audit.json').write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
handoff = ROOT / 'work/parallel-coordination/stage42-utility-handoff.json'
handoff.write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
review_file = ROOT / 'work/parallel-coordination/stage42-independent-review.json'
review = json.loads(review_file.read_text(encoding='utf-8'))
review['status'] = 'candidate-independent-review-pass-required-Utility-leaf-source-stable'
review['runtimeIntegrationBlockers'] = []
review['requiredUtilityLeaf'] = result
review['remainingLimits'] = ['No Unity PlayMode/runtime gameplay acceptance', 'GameFrameworkException(string) diagnostic Message is still an external stub', 'CLog.LogProcedure output and private reflection ProcedureTypeAttribute ctor are external known gaps; actual Register/Start/Update/Change/Shutdown probe passes without their restoration']
review['stage42ProductionStateObservedAfterHelper'] = [dict(path=f['path'], sha256=sha(PROJECT / f['path']), state='candidate-applied' if sha(PROJECT / f['path']) == f['candidateSha256'] else 'source-before' if sha(PROJECT / f['path']) == f['sourceBeforeSha256'] else 'other-live-state') for f in review['ownedFiles']]
review_file.write_text(json.dumps(review, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps(dict(status=result['status'], sourceSha256=result['sourceSha256'], metaSha256=result['metaSha256'], tests=result['tests'], nativeCases=27, ILChecks=len(il_checks), fullGFProbeChecks=16), ensure_ascii=True, indent=2))
