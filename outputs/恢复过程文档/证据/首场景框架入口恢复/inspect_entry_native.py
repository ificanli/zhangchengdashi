"""Bounded read-only extraction of startup entry ARM64, reusing stage-23 ELF decoder."""
from pathlib import Path

workspace = Path(__file__).resolve().parents[2]
helper = (workspace / 'work/new-config-restore/inspect_native.py').read_text(encoding='utf-8')
helper = helper.split('\nentries=[e for e in mapping')[0]
helper = helper.replace("OUT = ROOT / 'work/new-config-restore'", "OUT = ROOT / 'work/start-entry-plan/native'")
helper = helper.replace('OUT.mkdir(exist_ok=True)', 'OUT.mkdir(parents=True, exist_ok=True)')
exec(compile(helper, str(__file__) + ':stage23-decoder', 'exec'))

prefixes = (
    'GameFramework.Base.GameStartEntry$$',
    'GameFramework.Base.IGameStart$$',
    'ljzs_lt.GameStart$$',
    'ljzs_lt.GameStart.<OpenLoadingUI>d__4$$',
)
extra_addresses = {
    0x715af54, 0x4c8c5c0, 0x4c8c90c, 0x715b680, 0x715b7c8, 0x715bae8,
    0x715af7c, 0x715b144, 0x715b260, 0x715a5d8,
    0x71eb634, 0x71eb730, 0x71eb770, 0x71ebbb4, 0x71ebacc, 0x71ebb24,
    0x711f97c, 0x711f824, 0x712fdec, 0x712fe70, 0x713b4ec,
}
entries = [row for row in mapping['ScriptMethod'] if row['Name'].startswith(prefixes) or row['Address'] in extra_addresses]
report = {
    'scope': 'Read-only original startup native bodies; no source edits, native SDK execution or Unity launch',
    'decoder': 'capstone ' + capstone.__version__,
    'elfSha256': hashlib.sha256(raw).hexdigest(),
    'methods': [dump_method(row) for row in entries]
}
(OUT.parent / 'native-evidence.json').write_text(json.dumps(report, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps({'methods': len(entries), 'nativeBytes': sum(row['bytes'] for row in report['methods']),
                  'output': str(OUT.parent / 'native-evidence.json')}, ensure_ascii=True))
