"""Read-only exported GUID/reference graph for the exact failed Addressables rows."""
from pathlib import Path
import collections
import hashlib
import json
import re
import subprocess
import sys

sys.stdout.reconfigure(encoding='utf-8')
root = Path(__file__).resolve().parents[2]
own = Path(__file__).resolve().parent
project = root / 'outputs/OccupyCityRecovered'
plan = json.loads((root / 'work/startup-restore/addressable-recovery-plan.json').read_text(encoding='utf-8'))
validation = json.loads((project / 'RecoveryReports/addressables-validation-report.json').read_text(encoding='utf-8-sig'))
build = json.loads((project / 'RecoveryReports/addressables-build-report.json').read_text(encoding='utf-8-sig'))
guid_paths = {}
for meta in (project / 'Assets').rglob('*.meta'):
    prefix = meta.read_bytes()[:1024].decode('utf-8', errors='replace')
    match = re.search(r'^guid: ([0-9a-f]{32})$', prefix, re.M)
    if match:
        guid_paths.setdefault(match[1], []).append(Path(str(meta)[:-5]))

def describe(path):
    raw = path.read_bytes()
    text = raw.decode('utf-8', errors='replace') if raw.startswith(b'%YAML') else ''
    cls = re.search(r'^--- !u!(\d+) &(-?\d+)', text, re.M)
    refs = []
    for line_number, line in enumerate(text.splitlines(), 1):
        for match in re.finditer(r'fileID: (-?\d+), guid: ([0-9a-f]{32}), type: (\d+)', line):
            refs.append({'line': line_number, 'field': line.strip(), 'fileId': match[1], 'guid': match[2],
                         'targets': [str(value.relative_to(project)).replace('\\', '/') for value in guid_paths.get(match[2], [])]})
    return {'path': str(path.relative_to(project)).replace('\\', '/'), 'bytes': len(raw), 'sha256': hashlib.sha256(raw).hexdigest(),
            'yamlClassId': cls[1] if cls else None, 'yamlLocalFileId': cls[2] if cls else None, 'references': refs}

affected = []
for issue in validation['validationFailures']:
    description = describe(project / issue['assetPath'])
    row = {**issue, 'currentRoot': description}
    if issue['requestedType'] == 'UnityEngine.Sprite':
        png = project / issue['assetPath']
        meta = Path(str(png) + '.meta').read_text(encoding='utf-8')
        row['textureImporter'] = {name: re.search(r'^  '+name+r': (.*)$', meta, re.M)[1] for name in ['textureType', 'spriteMode', 'spritePixelsToUnits']}
        row['spriteSheetEmpty'] = bool(re.search(r'^    sprites: \[\]$', meta, re.M))
        row['exportedSiblingSprites'] = [describe(value) for value in png.parent.glob(png.stem + '*.asset') if re.search(r'^--- !u!213 &', value.read_text(encoding='utf-8'), re.M)]
    affected.append(row)

ambiguities = []
for issue in build['locatorFailures']:
    sprite_path = project / issue['assetPath']
    png_path = sprite_path.with_suffix('.png')
    row = {**issue, 'sprite': describe(sprite_path), 'png': describe(png_path)}
    for kind, path in [('sprite', sprite_path), ('png', png_path)]:
        meta = Path(str(path) + '.meta').read_text(encoding='utf-8')
        guid = re.search(r'^guid: ([0-9a-f]{32})$', meta, re.M)[1]
        row[kind]['guid'] = guid
        result = subprocess.run(['rg', '-n', '-F', 'guid: ' + guid, str(project/'Assets'), '-g', '!*.meta', '-g', '!*.cs'], capture_output=True, text=True, encoding='utf-8')
        references = []
        for line in result.stdout.splitlines():
            match = re.match(r'^(.*?):(\d+):(.*)$', line)
            if not match: continue
            target = Path(match[1]); content = match[3]
            references.append({'path': str(target.relative_to(project)).replace('\\', '/'), 'line': int(match[2]),
                               'content': content.strip(), 'generatedAddressables': 'RecoveryTools/GeneratedAddressables' in str(target).replace('\\', '/')})
        row[kind]['allSerializedReferences'] = references
    ambiguities.append(row)

result = {'scope': 'Read-only current exported YAML/TextureImporter/GUID references; no AssetDatabase, Unity launch, plan or meta writes',
          'planSha256': hashlib.sha256((root/'work/startup-restore/addressable-recovery-plan.json').read_bytes()).hexdigest(),
          'guidCount': len(guid_paths), 'validationFailures': affected, 'locatorAmbiguities': ambiguities}
(own / 'current-reference-graph.json').write_text(json.dumps(result, ensure_ascii=False, indent=2)+'\n', encoding='utf-8')
print(json.dumps({'failedRows': len(affected), 'ambiguities': len(ambiguities), 'guidCount': len(guid_paths)}, ensure_ascii=True))
