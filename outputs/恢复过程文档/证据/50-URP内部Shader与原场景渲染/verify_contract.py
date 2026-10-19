"""Check preserved failing baseline and the actual four candidate Shader sources."""
from __future__ import annotations

import hashlib
import json
from pathlib import Path
import re
from datetime import datetime, timezone

TASK = Path(__file__).resolve().parent
PROJECT = TASK.parent.parent / 'outputs/OccupyCityRecovered'


def sha(p: Path) -> str:
    return hashlib.sha256(p.read_bytes()).hexdigest()


def inspect(p: Path, depth: bool) -> dict:
    s = p.read_text(encoding='utf-8')
    stripped = re.sub(r'/\*.*?\*/|//[^\n]*', '', s, flags=re.S)
    passes = re.findall(r'(?m)^\s*Pass\s*\{', stripped)
    blocks = re.findall(r'\bHLSLPROGRAM\b(.*?)\bENDHLSL\b', stripped, re.S)
    entries = []
    for block in blocks:
        v = re.search(r'#pragma\s+vertex\s+(\w+)', block)
        f = re.search(r'#pragma\s+fragment\s+(\w+)', block)
        entries.append({'vertex': v.group(1) if v else None, 'fragment': f.group(1) if f else None})
    checks = {
        'all_expected_passes': len(passes) == (2 if depth else 25),
        'pass1_exists': len(passes) > 1,
        'universal_pipeline_tag': '"RenderPipeline" = "UniversalPipeline"' in stripped,
        'official_package_include': 'Packages/com.unity.render-pipelines.' in stripped,
        'non_dummy': 'DummyShaderTextExporter' not in s,
    }
    if not depth:
        checks['local_BLIT_DECODE_HDR'] = bool(re.search(r'#pragma\s+multi_compile_local\s+_\s+BLIT_DECODE_HDR', stripped))
        checks['pass1_bilinear'] = len(entries) > 1 and entries[1] == {'vertex': 'Vert', 'fragment': 'FragBilinear'}
        checks['pass21_22_cube_hdr'] = len(entries) > 22 and [e['fragment'] for e in entries[21:23]] == ['FragOctahedralProjectNearestRepeat', 'FragOctahedralProjectBilinearRepeat']
        checks['named_final_blit_passes'] = 'Name "BilinearDebugDraw"' in stripped and 'Name "NearestDebugDraw"' in stripped
    else:
        checks['color_then_color_and_depth'] = [e['fragment'] for e in entries] == ['FragColorOnly', 'FragColorAndDepth']
        checks['depth_write_enabled'] = 'ZWrite On ZTest Always Blend Off Cull Off' in stripped
    return {'path': str(p), 'sha256': sha(p), 'passCount': len(passes), 'entries': entries,
            'checks': checks, 'failures': [k for k, v in checks.items() if not v]}


def main() -> int:
    scope = json.loads((TASK / 'owned-scope.json').read_text(encoding='utf-8'))
    results = []
    failures = []
    for entry in scope['ownedFiles']:
        rel = entry['path']
        depth = 'ColorAndDepth' in rel
        before = inspect(TASK / 'before' / rel, depth)
        candidate = inspect(TASK / 'candidate' / rel, depth)
        live_meta = Path(str(PROJECT / rel) + '.meta')
        ref = entry['serializedReference']
        reference = (PROJECT / ref['path']).read_text(encoding='utf-8')
        integrity = {
            'source_still_at_start_sha': sha(PROJECT / rel) == entry['sourceBeforeSha256'],
            'baseline_preserved': before['sha256'] == entry['sourceBeforeSha256'],
            'meta_preserved': sha(live_meta) == entry['metaSha256'],
            'official_byte_identical': (TASK / 'candidate' / rel).read_bytes() == (PROJECT / entry['officialSource']).read_bytes(),
            'renderer_guid_binding_intact': bool(re.search(rf'{ref["field"]}: \{{fileID: 4800000, guid: {ref["guid"]}, type: 3\}}', reference)),
            'negative_control_reproduces_contract_failure': not before['checks']['pass1_exists'] and (depth or not before['checks']['local_BLIT_DECODE_HDR']),
            'candidate_contract_passes': not candidate['failures'],
        }
        results.append({'path': rel, 'guid': entry['guid'], 'before': before, 'candidate': candidate, 'integrityChecks': integrity})
        failures.extend(f'{rel}:{k}' for k, v in integrity.items() if not v)
    summary = {'stage': 50, 'generatedUtc': datetime.now(timezone.utc).isoformat(), 'layer': 'actual source and serialized-reference contracts',
               'unityStarted': False, 'coreGameplayAccepted': False, 'files': results,
               'expectedBaselineFailures': sum(len(r['before']['failures']) for r in results),
               'candidateContractChecks': sum(len(r['candidate']['checks']) for r in results),
               'integrityChecks': sum(len(r['integrityChecks']) for r in results),
               'failures': failures, 'passed': not failures,
               'limitations': ['No Unity ShaderLab importer/compiler invoked', 'No GUI rendering or Main6 acceptance', 'Main5 logs did not record shader instance GUID']}
    target = TASK / 'validation/contract-results.json'
    target.parent.mkdir(exist_ok=True)
    target.write_text(json.dumps(summary, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
    print(json.dumps({k: summary[k] for k in ['stage', 'expectedBaselineFailures', 'candidateContractChecks', 'integrityChecks', 'failures', 'passed']}, ensure_ascii=False))
    return 0 if summary['passed'] else 1


if __name__ == '__main__':
    raise SystemExit(main())
