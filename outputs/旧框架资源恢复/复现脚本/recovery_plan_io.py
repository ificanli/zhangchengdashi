import json
from pathlib import Path

def write_json_atomic(path: Path, data):
    """Keep the last complete plan visible while the coordinating agent may read it."""
    temporary=path.with_name(path.name+'.tmp')
    temporary.write_text(json.dumps(data,ensure_ascii=False,indent=2),encoding='utf-8')
    temporary.replace(path)
