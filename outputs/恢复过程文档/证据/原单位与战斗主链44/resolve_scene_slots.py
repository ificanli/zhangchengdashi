import json
from pathlib import Path
p=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
m=json.loads((p/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
s=set(int(x,16) for x in '8D6C1A0 8D5F228 8D624E8 8D624C8 8D86E30 8D573E8 8D6C100 8D5F178 8D6C1A8 8D5F230 8D5E5D0 8D6FDA0 8D61A80 8D5D2F8 8D23E08 8D2D398 8D2DC40 8D12400 8D12048 8D2DBF0'.split())
a=[dict(category=k,**x) for k in ('ScriptMetadata','ScriptMetadataMethod','ScriptString') for x in m[k] if x['Address'] in s]
print(json.dumps(a,ensure_ascii=False,indent=2))
(p/'work/parallel-44-battle/scene-metadata-slots.json').write_text(json.dumps(a,ensure_ascii=False,indent=2),encoding='utf-8')
