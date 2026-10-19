import hashlib
import json
import re
from pathlib import Path
OWN=Path(__file__).resolve().parent
results=[]
for filename,type_name in [('GameStartEntry','GameFramework.Base.GameStartEntry'),('GameFrameEntry','GameFramework.GameFrameEntry'),('IGameStart','GameFramework.Base.IGameStart'),('GameStart','ljzs_lt.GameStart')]:
    path=OWN/'compile/actual'/(filename+'.il.txt')
    text=path.read_text(encoding='utf-8-sig')
    end=re.search(r'\} // end of class '+re.escape(type_name)+r'\s*\n',text)
    assert end,type_name
    begin=text.rfind('\n.class ',0,end.start())+1
    selected=text[begin:end.end()]
    assert type_name in selected and len(selected)<200000
    path.write_text(selected,encoding='utf-8')
    results.append(dict(type=type_name,path=path.name,chars=len(selected),sha256=hashlib.sha256(path.read_bytes()).hexdigest()))
(OWN/'compile/actual/type-il-manifest.json').write_text(json.dumps(results,indent=2),encoding='utf-8')
print(json.dumps(results,indent=2))
