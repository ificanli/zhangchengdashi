"""Stage 50 integration: strict all-files preflight, default check-only.

No Unity APIs/processes are used. The root integrator chooses the reimport time.
"""
from __future__ import annotations

import argparse
import hashlib
import json
import os
from pathlib import Path
import re
import sys

TASK = Path(__file__).resolve().parent
ROOT = TASK.parent.parent
DEFAULT_PROJECT = ROOT / 'outputs/OccupyCityRecovered'
ALLOWED = {
    'Assets/Shader/Hidden_Universal_CoreBlit.shader',
    'Assets/Shader/Hidden_Universal_CoreBlit_0.shader',
    'Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth.shader',
    'Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth_0.shader',
}


def sha(path: Path) -> str:
    return hashlib.sha256(path.read_bytes()).hexdigest()


def confined(base: Path, rel: str) -> Path:
    p = (base / rel).resolve()
    if not p.is_relative_to(base.resolve()):
        raise ValueError(f'Path escapes intended root: {rel}')
    return p


def preflight(project: Path) -> tuple[list[tuple[Path, bytes]], dict]:
    manifest = json.loads((TASK / 'apply-manifest.json').read_text(encoding='utf-8'))
    entries = manifest['files']
    if manifest['stage'] != 50 or len(entries) != 4 or {e['path'] for e in entries} != ALLOWED:
        raise ValueError('Manifest scope must be exactly the four reviewed stage50 Shader files')
    errors = []
    payloads = []
    for e in entries:
        source = confined(project, e['path'])
        candidate = confined(TASK / 'candidate', e['path'])
        meta = Path(str(source) + '.meta')
        for label, p, expected in [
            ('source-before', source, e['sourceBeforeSha256']),
            ('candidate', candidate, e['candidateSha256']),
            ('original-meta', meta, e['metaSha256']),
            ('installed-official', confined(project, e['officialSource']), e['officialSha256']),
        ]:
            if not p.is_file():
                errors.append(f'{label} missing: {p}')
            elif sha(p) != expected:
                errors.append(f'{label} SHA256 mismatch: {p}; expected {expected}; actual {sha(p)}')
        ref = e['serializedReference']
        refpath = confined(project, ref['path'])
        pattern = rf'^\s*{re.escape(ref["field"])}:\s*\{{fileID:\s*4800000,\s*guid:\s*{ref["guid"]},\s*type:\s*3\}}\s*$'
        if not refpath.is_file() or not re.search(pattern, refpath.read_text(encoding='utf-8'), re.M):
            errors.append(f'Renderer binding changed: {refpath}: {ref["field"]} must point to {ref["guid"]}')
        if candidate.is_file():
            payloads.append((source, candidate.read_bytes()))
    if errors:
        raise ValueError('Preflight rejected all writes:\n' + '\n'.join(errors))
    return payloads, manifest


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--project-root', type=Path, default=DEFAULT_PROJECT,
                        help='Defaults to the actual x20 recovered project; override for isolated guard tests')
    parser.add_argument('--apply', action='store_true', help='Write four files after all preflight checks succeed')
    args = parser.parse_args()
    project = args.project_root.resolve()
    try:
        payloads, manifest = preflight(project)
        if not args.apply:
            print(json.dumps({'stage': 50, 'status': 'preflight_passed_check_only',
                              'projectRoot': str(project), 'files': len(payloads),
                              'writtenFiles': 0, 'unityTouched': False}, ensure_ascii=False))
            return 0
        # Recheck every source/meta/candidate/reference immediately before writes.
        payloads, manifest = preflight(project)
        for target, data in payloads:
            # Per-file SHA recheck; meta is never rewritten. Integrator owns
            # synchronization with the existing Unity editor's import operation.
            with target.open('r+b') as stream:
                expected = next(e['sourceBeforeSha256'] for e in manifest['files']
                                if e['path'] == target.relative_to(project).as_posix())
                current = stream.read()
                if hashlib.sha256(current).hexdigest() != expected:
                    raise ValueError(f'Source changed after preflight; refusing: {target}')
                stream.seek(0)
                stream.write(data)
                stream.truncate()
                stream.flush()
                os.fsync(stream.fileno())
        for e in manifest['files']:
            if sha(project / e['path']) != e['candidateSha256']:
                raise ValueError(f'Post-write SHA mismatch: {e["path"]}')
            if sha(Path(str(project / e['path']) + '.meta')) != e['metaSha256']:
                raise ValueError(f'Post-write meta changed: {e["path"]}')
        print(json.dumps({'stage': 50, 'status': 'applied_four_shaders', 'projectRoot': str(project),
                          'writtenFiles': len(payloads), 'metasWritten': 0, 'unityTouched': False,
                          'next': 'Root reimports four shaders, verifies compiled pass/keyword/bindings, then runs original Main6'},
                         ensure_ascii=False))
        return 0
    except (ValueError, OSError, KeyError) as exc:
        print(str(exc), file=sys.stderr)
        return 2


if __name__ == '__main__':
    raise SystemExit(main())
