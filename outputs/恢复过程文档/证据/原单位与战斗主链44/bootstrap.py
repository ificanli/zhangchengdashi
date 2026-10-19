import bisect, hashlib, json, os, re, shutil
from pathlib import Path
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
WORK=ROOT/'work/parallel-44-battle'
PROJECT=ROOT/'outputs/OccupyCityRecovered'
NAMES=['BattleGameSceneManager','BattleGameManager','RoleBehaviour','SynergyEffectManager']
def digest(p): return hashlib.sha256(p.read_bytes()).hexdigest()
def members(text):
    result=[]
    pattern=r'\[Token\(Token = "(0x600[0-9A-Fa-f]+)"\)\]\s*\[Address\(RVA = "(0x[0-9A-Fa-f]+)"[^\n]*\)\]'
    matches=list(re.finditer(pattern,text))
    for m in matches:
        start=text.find('{',m.end())
        semi=text.find(';',m.end())
        if start<0 or (semi>=0 and semi<start): continue
        depth=1; i=start+1
        # Decompiled stubs and recovered methods have no brace-bearing literals.
        while depth and i<len(text):
            if text[i]=='{': depth+=1
            elif text[i]=='}': depth-=1
            i+=1
        body=text[start+1:i-1]
        clean=re.sub(r'//[^\n]*','',body).strip()
        result.append(dict(token=m[1],rva=m[2],signature=text[m.end():start].strip(),body=body,
                           body_start=start+1,body_end=i-1,stub=clean in ('','return default;','return null;') or 'RECOVERY_UNIMPLEMENTED' in clean))
    return result
def main():
    mapping=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
    byaddr={r['Address']:r for r in mapping['ScriptMethod']}
    ends=sorted(set(mapping['Addresses']))
    owned=[]; targets=[]
    for name in NAMES:
        rel=f'Assets/Scripts/Assembly-CSharp/GameModule/{name}.cs'
        src=PROJECT/rel
        backup=WORK/'source-before'/rel
        backup.parent.mkdir(parents=True,exist_ok=True)
        if not backup.exists(): shutil.copyfile(src,backup)
        text=backup.read_text(encoding='utf-8-sig')
        rows=members(text)
        for r in rows:
            a=int(r['rva'],16); mapped=byaddr.get(a,{})
            r['native_name']=mapped.get('Name'); r['native_signature']=mapped.get('Signature')
            if a in byaddr:
                # Preserve exact script.json ABI (instance/static and struct values).
                targets.append(dict(address=a,end=ends[bisect.bisect_right(ends,a)],name=mapped['Name'],prototype=mapped['Signature']))
        owned.append(dict(path=rel,source_before_sha256=digest(backup),source_observed_sha256=digest(src),members=rows,
                          existing_non_stub=[r for r in rows if not r['stub']],meta_sha256=digest(Path(str(src)+'.meta'))))
    data=dict(task=44,thread_id=os.environ.get('CODEX_THREAD_ID'),project=str(PROJECT),work=str(WORK),files=owned)
    (WORK/'owned-scope.json').write_text(json.dumps(data,ensure_ascii=False,indent=2),encoding='utf-8')
    # All declared methods exported once; candidates may recover a conservative subset.
    (WORK/'ida/targets-supplement.json').write_text(json.dumps(targets,ensure_ascii=False,indent=2),encoding='utf-8')
    print(json.dumps(dict(thread_id=data['thread_id'],targets=len(targets),files=[dict(name=Path(r['path']).name,members=len(r['members']),non_stub=len(r['existing_non_stub'])) for r in owned]),ensure_ascii=False))
if __name__=='__main__': main()
