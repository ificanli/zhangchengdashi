from pathlib import Path
import json
w=Path('work/stage49-model-defaults');plan=json.loads((w/'write-plan.json').read_text(encoding='utf-8'));(w/'owned-scope.json').write_text(json.dumps(dict(stage=49,productionWritesAuthorized=True,files=[x['path'] for x in plan['files']],methods=24,limits='Root authorized exact minimal24 original bodies in14 files; no complex10 Init, no Time ctor/accessors/SDK/45 changes'),ensure_ascii=False,indent=2),encoding='utf-8')
p=w/'compile-candidate.ps1';s=p.read_text(encoding='utf-8');s=s.replace("if($Assembly -eq 'Assembly-CSharp'){","if($false){");p.write_text(s,encoding='utf-8')
