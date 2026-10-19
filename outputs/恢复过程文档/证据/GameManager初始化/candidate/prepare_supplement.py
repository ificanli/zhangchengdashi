import json
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(data['Addresses']);targets=[]
for m in data['ScriptMethod']:
    if not m['Name'].startswith('GameModule.GameManager'):continue
    a=m['Address'];end=next(e for e in ends if e>a)
    if end-a>2000:continue
    name=m['Name'];result='void';extra=''
    if a==0x3E1CAF4:result='unsigned char'
    elif a in {0x3E1CF4C,0x3E1CF8C,0x3E19928}:result='void*'
    if name.endswith('$$.cctor'):prototype=f'void GM_{a:x}(const MethodInfo* method);'
    else:
        if a==0x3E1984C:extra='void* action, '
        elif a==0x3E1A694:extra='void* title, void* content, void* button, unsigned char cancel, void* callback, '
        elif a in {0x3E19BC0,0x3E19D38,0x3E1A5B8,0x3E1A608,0x3E1A690,0x3E1A864,0x3E1A918,0x3E1A9EC}:extra='void* obj, '
        elif a==0x3E19988:extra='int state, '
        prototype=f'{result} GM_{a:x}(void* self, '+extra+'const MethodInfo* method);'
    targets.append(dict(name=name,address=a,end=end,signature=m['Signature'],prototype=prototype))
(own/'ida/targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8');print('Prepared',len(targets),'small complete methods; Init and reward lambda remain ASM-only')
