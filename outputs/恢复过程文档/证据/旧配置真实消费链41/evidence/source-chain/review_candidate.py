"""Independent candidate diff/token/field review, read-only production sources."""
import difflib
import hashlib
import json
import re
from datetime import datetime, timezone
from pathlib import Path

ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
PROJECT=ROOT/'outputs/OccupyCityRecovered'
TASK=ROOT/'work/parallel-41-config'
OUT=TASK/'evidence/source-chain'
scope=json.loads((TASK/'owned-scope.json').read_text(encoding='utf-8-sig'))
plan=json.loads((TASK/'write-plan.json').read_text(encoding='utf-8-sig'))
scope_by_path={f['relativePath']:f for f in scope['files']}

def sha(path): return hashlib.sha256(path.read_bytes()).hexdigest()
def normalize(s): return re.sub(r'\s+',' ',s).strip()
def mask(text):
    pattern=r'//[^\n]*|/\*[\s\S]*?\*/|@"(?:[^"]|"")*"|"(?:\\.|[^"\\])*"|\'(?:\\.|[^\'\\])*\''
    return re.sub(pattern,lambda m:''.join('\n' if c=='\n' else ' ' for c in m[0]),text)
def parse(text):
    clean=mask(text); found=[]
    for m in re.finditer(r'\[Token\(Token = "(0x600[0-9A-Fa-f]+)"\)\]',text):
        start=clean.index('{',m.end()); level=1; i=start+1
        while level:
            if clean[i]=='{':level+=1
            elif clean[i]=='}':level-=1
            i+=1
        sig=text[m.end():start].strip()
        rva=re.search(r'RVA = "([^"]+)"',sig)
        found.append({'token':m[1],'rva':rva[1] if rva else None,'signature':sig,'body':text[start+1:i-1].strip(),'begin':m.start(),'end':i,'line':text[:m.start()].count('\n')+1})
    return found
def skeleton(text,methods):
    for method in sorted(methods,key=lambda x:x['begin'],reverse=True):text=text[:method['begin']]+text[method['end']:]
    return normalize(text)

records=[]; diffs=[]
for p in plan['files']:
    rel=p['path']; before=TASK/'source-before'/rel; candidate=TASK/'candidate'/rel; live=PROJECT/rel
    a=before.read_text(encoding='utf-8-sig'); b=candidate.read_text(encoding='utf-8-sig')
    old=parse(a); new=parse(b); old_by={x['token']:x for x in old}; new_by={x['token']:x for x in new}
    added=sorted(set(new_by)-set(old_by)); removed=sorted(set(old_by)-set(new_by))
    changed=[t for t in old_by if t in new_by and normalize(old_by[t]['body'])!=normalize(new_by[t]['body'])]
    signature_changes=[t for t in old_by if t in new_by and normalize(old_by[t]['signature'])!=normalize(new_by[t]['signature'])]
    planned=set(p['restoredTokens']); changed_unplanned=sorted((set(changed)|set(added))-planned)
    data={'path':rel,'sourceUnchanged':sha(live)==scope_by_path[rel]['sourceBeforeSHA256'],'candidateMatchesWritePlan':sha(candidate)==p['candidateSha256'],'metaMatchesWritePlan':sha(live.with_suffix(live.suffix+'.meta'))==p['metaSha256'],'oldMethodCount':len(old),'newMethodCount':len(new),'changedTokens':changed,'addedTokens':added,'removedTokens':removed,'signatureChanges':signature_changes,'unplannedChangedTokens':changed_unplanned,'fieldTypeAttributeSkeletonUnchanged':skeleton(a,old)==skeleton(b,new),'changedMethodDetails':[new_by[t] for t in changed+added]}
    for x in data['changedMethodDetails']:
        for key in ('begin','end'):x.pop(key,None)
    data['passed']=data['sourceUnchanged'] and data['candidateMatchesWritePlan'] and data['metaMatchesWritePlan'] and data['fieldTypeAttributeSkeletonUnchanged'] and not (removed or signature_changes or changed_unplanned)
    records.append(data)
    diffs.extend(difflib.unified_diff(a.splitlines(),b.splitlines(),fromfile='source-before/'+rel,tofile='candidate/'+rel,lineterm=''))

candidate_files=sorted(p.relative_to(TASK/'candidate').as_posix()for p in (TASK/'candidate').rglob('*')if p.is_file())
native_review=[
 {'tokens':['0x6005AEA'],'native':'ida/pseudocode/0x4399f1c.c','finding':'Reference-null singleton allocation/return preserved'},
 {'tokens':['0x6005AE7'],'native':'ida/pseudocode/0x4399578.c','finding':'JSON flag true and AppSetting memorypack false before once guard; ReadConfig then customRead then completion flag true'},
 {'tokens':['0x6005AE8'],'native':'ida/pseudocode/0x4399658.c','finding':'38 table generic calls followed by Setting, WorldCupbase, Base objects in original metadata order'},
 {'tokens':['0x6005AE9'],'native':'ida/pseudocode/0x4399ebc.c','finding':'Original ResourcesInfo reference stored to ConfigRead.configRes; no replacement source'},
 {'tokens':['0x6005AEB'],'native':'ida/pseudocode/0x4399bec.c','finding':'Pool grouping clears first, skips null and pool_id<1, retains original row object in each list'},
 {'tokens':['0x6005AED'],'native':'ida/pseudocode/0x4399f90.c','finding':'38 typed object dictionaries and int->List pool map allocated in field order; existing fields unchanged'},
 {'tokens':['0x6005731'],'native':'ida/pseudocode/0x4b8d360.c','finding':'Exact typeof(T).Name; Unity object null check, substring from first brace, FromJson<T>; missing asset logs and null'},
 {'tokens':['0x6005735'],'native':'ida/pseudocode/0x4b8bf38.c and .asm.txt','finding':'No clear; null list no-op; repeated UniqueID evaluations preserved; duplicate key logs and retains first; null row/key exceptions propagate'},
 {'tokens':['0x6005737'],'native':'ida/pseudocode/0x4b8b9b0.c and .asm.txt','finding':'TextAsset Unity null gate and 0/1/2 parser dispatch; default enum/missing asset log paths preserved'},
 {'tokens':['0x6005750'],'native':'ida/pseudocode/0x4b8beb4.c','finding':'Substring from first brace then original UnSerialization<T>.Datas field; no replacement wrapper'},
 {'tokens':['0x600575E'],'native':'ida/pseudocode/0x7168d84.c and .asm.txt','finding':'Original configRes/AppSetting diagnostic gate, cached isUseNewRes gate, WebGL lookup, sync load cast-release-return order; old ResourcesInfo.LoadAsset<TextAsset>(null,name)'},
 {'tokens':['0x600575F'],'native':'ida/pseudocode/0x4b8cadc.c','finding':'Resolver then JSON dispatcher then counter increment; thrown parse/key failure prevents increment'},
 {'tokens':['0x6005734'],'native':'ida/pseudocode/0x7166f08.c','finding':'WebGL TryGetValue returns original Unity object; null/missing diagnostic paths return null'},
 {'tokens':['0x6005765'],'native':'ida/pseudocode/0x716c144.c and .asm.txt','finding':'Added missing original cctor; bool defaults, AppSetting-cached mode, both counters zero, Data/Config slash trim, WebGL flag false'},
 {'tokens':['0x600571D'],'native':'ida/pseudocode/0x71656c0.c and .asm.txt','finding':'Original NotImplementedException restored; derived UniqueID dependency left explicit'}
]
result={'stage':41,'generatedUtc':datetime.now(timezone.utc).isoformat(),'reviewerScope':'Independent source diff, declarations, original native exported pseudocode/ASM and csc evidence; no apply or Unity','files':records,'candidateDirectoryFiles':candidate_files,'candidateDirectoryOnlyOwnedFiles':candidate_files==sorted(scope['writeScope']),'nativeSemanticReview':native_review,'internalActionableFindings':[],'externalIntegrationGates':['38 table UniqueID overrides still return null; no fully typed real dictionary consumption until exact row dependency candidates are integrated','AppSetting UseNewRes and IsUseMemoryPack properties remain placeholders; candidate preserves original calls but their backing-field semantics are external','CLog.Error currently empty; controlled logger tests cannot imply production diagnostic emission','Unity JsonUtility and original resource provider integration remain runtime verification by root','Unrestored LitJson/MemoryPack and async methods retain baseline bodies; current ConfigMgr path uses synchronous UnityJson only'],'sourceWrites':False,'applyExecuted':False,'unityStarted':False,'passed':all(r['passed']for r in records) and candidate_files==sorted(scope['writeScope'])}
(OUT/'candidate-independent-review.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'candidate-independent.diff').write_text('\n'.join(diffs)+'\n',encoding='utf-8')
print(json.dumps({'passed':result['passed'],'files':[{'path':r['path'],'changedTokens':r['changedTokens'],'addedTokens':r['addedTokens'],'passed':r['passed']}for r in records],'internalActionableFindings':result['internalActionableFindings'],'externalIntegrationGates':result['externalIntegrationGates']},ensure_ascii=False,indent=2))
