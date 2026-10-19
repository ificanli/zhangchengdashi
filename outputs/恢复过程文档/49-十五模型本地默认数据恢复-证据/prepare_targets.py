from pathlib import Path
import bisect,json
r=Path(__file__).resolve().parents[2];w=r/'work/stage49-model-defaults';s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));methods={m['Address']:m for m in s['ScriptMethod']};ends=sorted(set(s['Addresses']));models=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'))
targets=[];scope=[]
for model in models:
    candidates=[]
    for m in model['ownMethods']:
        if model['protectedExisting'] or m['sourceNonEmpty']:continue
        a=int(m['rva'],16);n=methods[a];static=m['IsStatic'];proto=f"void ModelDefaultsTarget{len(targets)}("+('' if static else 'void* self,')+'const MethodInfo* method);'
        targets.append(dict(name=n['Name'],address=a,end=ends[bisect.bisect_right(ends,a)],signature=n['Signature'],prototype=proto,method_token=m['token'],file=model['source'],dataType=model['dataType'],nativeLoadIndex=model['nativeLoadIndex'],note='Readonly initial constructor/default/init classification; no production write authorization; actual TD only'))
        candidates.append(dict(token=m['token'],name=m['Name'],rva=m['rva']))
    scope.append(dict(file=model['source'],dataType=model['dataType'],nativeLoadIndex=model['nativeLoadIndex'],protectedExisting=model['protectedExisting'],candidateMethods=candidates,sourceSha256=model['sourceSha256'],metaSha256=model['metaSha256']))
(w/'native-targets.json').write_text(json.dumps(targets,ensure_ascii=False,indent=2),encoding='utf-8')
(w/'proposed-scope.json').write_text(json.dumps(dict(stage=49,productionWritesAuthorized=False,protected=['PlayerTimeData ctor restored in38','Existing old108/new145 accessor bodies','Stage45 DataManager orchestration','Stage38 storage lifecycle','SDK/login/user-ID/remote callbacks'],files=scope),ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(targets),'original constructors/default/init targets across',len([x for x in scope if x['candidateMethods']]),'TD source files; PlayerTimeData protected, production unchanged')
for row in scope:print(row['nativeLoadIndex'],row['dataType'],len(row['candidateMethods']),'PROTECTED' if row['protectedExisting'] else '')
