import hashlib
import json
import re
import struct
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/stage42-independent-review'
PACKAGE = ROOT / 'work/parallel-42-fsm'
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
HANDOFF = ROOT / 'work/parallel-coordination/stage42-handoff.json'
handoff = json.loads(HANDOFF.read_text(encoding='utf-8'))
assert handoff['state'] == 'ready_for_integration'
methods = handoff['methods']
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()

def body(text, token):
    pos = text.index('[Token(Token = "' + token + '")]')
    start = text.index('{', pos)
    end, depth = start + 1, 1
    while depth:
        depth += (text[end] == '{') - (text[end] == '}')
        end += 1
    return start, end

def shape(text, tokens):
    for token in tokens:
        start, end = body(text, token)
        text = text[:start] + '<BODY>' + text[end:]
    return text

records = []
for file in handoff['owned_files']:
    rel = file['path']
    source, before, candidate = PROJECT / rel, PACKAGE / 'source-before' / rel, PACKAGE / 'candidate' / rel
    assert sha(before) == file['source_before_sha256']
    assert sha(source) == file['source_before_sha256'], 'production modified during review: ' + rel
    assert sha(source.with_suffix('.cs.meta')) == file['meta_sha256']
    assert sha(candidate) == file['candidate_sha256']
    old, new = before.read_bytes().decode('utf-8'), candidate.read_bytes().decode('utf-8')
    for attr in ['Token', 'Address', 'FieldOffset']:
        pattern = r'\[' + attr + r'\([^\]]+\)\]'
        assert re.findall(pattern, old) == re.findall(pattern, new), (rel, attr)
    selected = [row for row in methods if row['file'] == rel]
    tokens = [row['token'] for row in selected]
    restored_shape = shape(new, tokens)
    restored_shape = restored_shape.replace('public Fsm(string name, T owner, params FsmState<T>[] states) : base(name)', 'public Fsm(string name, T owner, params FsmState<T>[] states)')
    restored_shape = restored_shape.replace('public FsmBase() : this(null)', 'public FsmBase()')
    restored_shape = restored_shape.replace('private List<FsmBase> m_deleteFsm = new List<FsmBase>();', 'private List<FsmBase> m_deleteFsm;')
    assert restored_shape == shape(old, tokens), 'unexpected signature/field/source change: ' + rel
    for row in selected:
        start, end = body(new, row['token'])
        actual_body = new[start + 1:end - 1].strip().replace('\r\n', '\n')
        assert hashlib.sha256(actual_body.encode('utf-8')).hexdigest() == row['candidate_body_sha256']
        old_start, old_end = body(old, row['token'])
        baseline = re.sub(r'\s+', ' ', old[old_start + 1:old_end - 1]).strip()
        assert baseline in ['', 'return null;', 'return default;'], 'existing meaningful body overwritten: ' + row['token']
    records.append(dict(path=rel, sourceBeforeSha256=sha(source), candidateSha256=sha(candidate), metaSha256=file['meta_sha256'], originalAttributesAndGuidProtected=True, onlyMappedBodiesAndThreeNativeCtorInitializations=True, methods=len(selected)))
for file in handoff['unchanged_owned_files']:
    assert sha(PROJECT / file['path']) == file['source_before_sha256']
    assert sha((PROJECT / file['path']).with_suffix('.cs.meta')) == file['meta_sha256']

elf_path = ROOT / 'work/ida-input/libil2cpp-arm64.so'
elf = elf_path.read_bytes()
def elf_bytes(address, size):
    phoff = struct.unpack_from('<Q', elf, 32)[0]
    entry_size, count = struct.unpack_from('<HH', elf, 54)
    for index in range(count):
        typ, flags, off, va, physical, file_size, mem_size, align = struct.unpack_from('<IIQQQQQQ', elf, phoff + index * entry_size)
        if typ == 1 and va <= address and address + size <= va + file_size:
            return elf[off + address - va:off + address - va + size]
    raise ValueError(hex(address))

native = json.loads((OWN / 'native-results.json').read_text(encoding='utf-8'))
assert native['passed'] == 43 and len(native['cases']) == 43
assert native['elfSha256'] == sha(elf_path)
samples = []
for address in [0x52a8890, 0x52a8dbc, 0x52a9308, 0x52a8c18, 0x4732868, 0x7296b44, 0x7296b4c, 0x7296bd0, 0x7296d08, 0x727aa18, 0x727aa3c, 0x727adc4]:
    row = next(m for m in methods if int(m['rva'], 16) == address)
    asm = PACKAGE / 'ida/pseudocode' / (hex(address) + '.asm.txt')
    asm_text = asm.read_text(encoding='utf-8-sig')
    assert asm_text.startswith(hex(address) + ':')
    digest = hashlib.sha256(elf_bytes(address, int(row['end'], 16) - address)).hexdigest()
    if hex(address) in native['codeHashes']:
        assert native['codeHashes'][hex(address)] == digest
    samples.append(dict(token=row['token'], name=row['name'], start=hex(address), end=row['end'], codeSha256=digest, asmSha256=sha(asm)))

tests = {}
for mode, passed, failed in [('baseline', 0, 52), ('candidate', 52, 0)]:
    log = OWN / ('validation/build/' + mode + '/run.log')
    assert f'RESULT tests=52 passed={passed} failed={failed}' in log.read_text(encoding='utf-8-sig')
    tests[mode] = dict(passed=passed, failed=failed, log=str(log.relative_to(ROOT)), logSha256=sha(log))
compile_result = json.loads((OWN / 'validation/unity-csc/result.json').read_text(encoding='utf-8-sig'))
assert compile_result['exitCode'] == 0 and compile_result['errorCount'] == 0
probe = json.loads((OWN / 'validation/unity-csc/production-dependency-negative.json').read_text(encoding='utf-8-sig'))
assert probe['passed'] and probe['actualExceptionParamName'] == 'key'
assert 'stage42-independent-review' in probe['fullProductionAssembly']
result = dict(stage=42, reviewer='game_launcher_restore_v2', status='candidate-review-pass-with-required-Utility-leaf-in-progress', candidateStateAtReview=handoff['state'], productionApplied=False, candidateBlockers=[], runtimeIntegrationBlockers=[dict(file='Assets/Scripts/GFRunning/GameFramework/Utility.cs', methods=['0x0600603C', '0x0600603D'], reproduced='Actual full GF candidate with no adapters throws ArgumentNullException(key) because GetFullName returns null', next='Root authorized exact two helper native recovery; separate implementation underway')], ownedFiles=records, totalMappedMethods=len(methods), preservedNativeRetMethods=8, ctorReview=['Fsm<T> base(name) before owner/state validation', 'FsmBase default delegates null; named ctor normalizes null only to string.Empty', 'FsmManager m_deleteFsm initializer precedes base ctor; dictionary and update list allocated after base'], nativeSamples=samples, nativeOriginalExecutions=dict(passed=43, cases=43, boundaries=native['boundaries']), independentTests=tests, fullCandidateGFCompile=dict(exitCode=0, errors=0, result='work/stage42-independent-review/validation/unity-csc/result.json'), actualDependencyProbe=probe, reviewedSemantics=['Initialize writes only own ready before callback; Procedure Initialize does not register/start', 'Procedure Register stores acquired FsmManager then actual generic CreateFsm<IProcedureManager>(this,procedures)', 'Target lookup precedes Leave; Leave failure preserves current/time; Enter failure preserves new state/zero time', 'Reentrant enter and leave remain synchronous; original outer target commit preserved', 'FsmManager uses live list iteration; remove-current skips shifted next; appended item can update same frame', 'Shutdown preserves original partial state on callback exceptions; no rollback/exception swallowing'], productionSourceWrites=0, UnityOperations=0, runtimeAcceptance=False, reviewScript='work/stage42-independent-review/review42.py')
target = ROOT / 'work/parallel-coordination/stage42-independent-review.json'
target.write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps(dict(status=result['status'], methods=len(methods), protectedSourceFiles=len(records), tests=tests, nativeCases=43, nativeSamples=len(samples)), ensure_ascii=True, indent=2))
