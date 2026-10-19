"""Exercise the actual apply script against disposable stage50-only fixtures."""
from __future__ import annotations

from datetime import datetime, timezone
import hashlib
import json
from pathlib import Path
import shutil
import subprocess
import sys

TASK = Path(__file__).resolve().parent
PROJECT = TASK.parent.parent / 'outputs/OccupyCityRecovered'
MANIFEST = json.loads((TASK / 'apply-manifest.json').read_text(encoding='utf-8'))


def sha(p: Path) -> str:
    return hashlib.sha256(p.read_bytes()).hexdigest()


def snapshot(project: Path) -> dict:
    return {p.relative_to(project).as_posix(): sha(p) for p in sorted(project.rglob('*')) if p.is_file()}


def setup(base: Path, name: str) -> tuple[Path, Path]:
    case = base / name
    task = case / 'task'
    project = case / 'project'
    task.mkdir(parents=True)
    project.mkdir()
    for filename in ['apply_stage50.py', 'apply-manifest.json']:
        shutil.copyfile(TASK / filename, task / filename)
    for e in MANIFEST['files']:
        for rel, origin in [(e['path'], TASK / 'before' / e['path']),
                            (e['path'] + '.meta', TASK / 'before' / (e['path'] + '.meta')),
                            (e['officialSource'], PROJECT / e['officialSource']),
                            (e['serializedReference']['path'], PROJECT / e['serializedReference']['path'])]:
            p = project / rel
            p.parent.mkdir(parents=True, exist_ok=True)
            shutil.copyfile(origin, p)
        candidate = task / 'candidate' / e['path']
        candidate.parent.mkdir(parents=True, exist_ok=True)
        shutil.copyfile(TASK / 'candidate' / e['path'], candidate)
    return task, project


def run(task: Path, project: Path, apply: bool) -> subprocess.CompletedProcess:
    return subprocess.run([sys.executable, '-X', 'utf8', str(task / 'apply_stage50.py'),
                           '--project-root', str(project), *(['--apply'] if apply else [])],
                          text=True, encoding='utf-8', capture_output=True, timeout=30)


def main() -> int:
    base = TASK / 'guard-tests' / datetime.now(timezone.utc).strftime('%Y%m%dT%H%M%S%fZ')
    results = []
    task, project = setup(base, 'check_only')
    start = snapshot(project)
    p = run(task, project, False)
    results.append({'case': 'default_check_only', 'passed': p.returncode == 0 and snapshot(project) == start,
                    'exitCode': p.returncode, 'stdout': p.stdout, 'stderr': p.stderr})
    task, project = setup(base, 'successful_apply')
    start = snapshot(project)
    p = run(task, project, True)
    changed = sorted(k for k, v in snapshot(project).items() if start.get(k) != v)
    passed = p.returncode == 0 and changed == sorted(e['path'] for e in MANIFEST['files'])
    passed &= all(sha(project / e['path']) == e['candidateSha256'] and sha(Path(str(project / e['path']) + '.meta')) == e['metaSha256'] for e in MANIFEST['files'])
    results.append({'case': 'apply_writes_exactly_four_sources_preserves_metas', 'passed': passed,
                    'exitCode': p.returncode, 'changed': changed, 'stdout': p.stdout, 'stderr': p.stderr})
    start = snapshot(project)
    p = run(task, project, True)
    results.append({'case': 'already_changed_source_refused', 'passed': p.returncode == 2 and snapshot(project) == start,
                    'exitCode': p.returncode, 'stdout': p.stdout, 'stderr': p.stderr})
    for name in ['source_drift_last_file', 'meta_drift', 'candidate_drift', 'official_drift', 'binding_drift', 'source_missing', 'manifest_scope_drift']:
        task, project = setup(base, name)
        last = MANIFEST['files'][-1]
        if name == 'source_drift_last_file':
            target = project / last['path']
        elif name == 'meta_drift':
            target = project / (last['path'] + '.meta')
        elif name == 'candidate_drift':
            target = task / 'candidate' / last['path']
        elif name == 'official_drift':
            target = project / last['officialSource']
        else:
            target = None
        if target:
            target.write_bytes(target.read_bytes() + b'\n// test drift\n')
        if name == 'binding_drift':
            target = project / last['serializedReference']['path']
            target.write_text(target.read_text(encoding='utf-8').replace(last['guid'], 'f' * 32), encoding='utf-8')
        if name == 'source_missing':
            (project / last['path']).unlink()
        if name == 'manifest_scope_drift':
            target = task / 'apply-manifest.json'
            obj = json.loads(target.read_text(encoding='utf-8'))
            obj['files'][-1]['path'] = 'Assets/unowned.shader'
            target.write_text(json.dumps(obj), encoding='utf-8')
        start = snapshot(project)
        p = run(task, project, True)
        results.append({'case': name, 'passed': p.returncode == 2 and snapshot(project) == start,
                        'exitCode': p.returncode, 'zeroProjectWrites': snapshot(project) == start,
                        'stdout': p.stdout, 'stderr': p.stderr})
    summary = {'stage': 50, 'generatedUtc': datetime.now(timezone.utc).isoformat(), 'fixtureRoot': str(base),
               'actualApplyScriptSha256': sha(TASK / 'apply_stage50.py'),
               'sharedProjectWritten': False, 'unityStarted': False, 'cases': len(results),
               'passed': sum(bool(r['passed']) for r in results), 'failed': sum(not r['passed'] for r in results),
               'results': results}
    out = TASK / 'validation/apply-guard-results.json'
    out.parent.mkdir(exist_ok=True)
    out.write_text(json.dumps(summary, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
    print(json.dumps({k: summary[k] for k in ['stage', 'cases', 'passed', 'failed', 'sharedProjectWritten', 'unityStarted']}))
    return 1 if summary['failed'] else 0


if __name__ == '__main__':
    raise SystemExit(main())
