"""Independent read-only audit of task41 owned source/body/token/meta snapshots."""
import hashlib
import json
import re
from datetime import datetime, timezone
from pathlib import Path

ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
PROJECT=ROOT/'outputs/OccupyCityRecovered'
TASK=ROOT/'work/parallel-41-config'
OUT=TASK/'evidence/source-chain'
OUT.mkdir(parents=True,exist_ok=True)
scope_path=TASK/'owned-scope.json'
scope=json.loads(scope_path.read_text(encoding='utf-8-sig'))
plan_path=TASK/'write-plan.json'
plan=json.loads(plan_path.read_text(encoding='utf-8-sig')) if plan_path.exists() else {'files':[]}
plan_by_path={f['path']:f for f in plan['files']}

def digest(p):
    return hashlib.sha256(p.read_bytes()).hexdigest()

def bodies(text):
    result=[]
    for m in re.finditer(r'\[Token\(Token = "(0x600[0-9A-Fa-f]+)"\)\]',text):
        start=text.index('{',m.end())
        level=1
        i=start+1
        # Original three owned files have no braces inside source method strings.
        while level:
            if text[i]=='{': level+=1
            elif text[i]=='}': level-=1
            i+=1
        signature=text[m.end():start].strip()
        rva=re.search(r'RVA = "([^"]+)"',signature)
        result.append({'token':m[1],'rva':rva[1] if rva else None,'tokenLine':text[:m.start()].count('\n')+1,'bodyLine':text[:start].count('\n')+1,'signature':signature,'body':text[start+1:i-1].strip()})
    return result

records=[]
for spec in scope['files']:
    rel=spec['relativePath']; source=PROJECT/rel; snapshot=TASK/'source-before'/rel
    text=source.read_text(encoding='utf-8-sig')
    parsed=bodies(text)
    owned_by_token={m['token']:m for m in spec['methods']}
    parsed_by_token={m['token']:m for m in parsed}
    differences=[]
    for token in sorted(set(owned_by_token)|set(parsed_by_token)):
        a,b=owned_by_token.get(token),parsed_by_token.get(token)
        if a is None or b is None: differences.append({'token':token,'difference':'missing from independent parse or scope'})
        elif a['body'].replace('\r\n','\n') != b['body'].replace('\r\n','\n') or a['rva']!=b['rva']:
            differences.append({'token':token,'difference':'body or RVA differs'})
    meta=source.with_suffix(source.suffix+'.meta')
    snapshot_meta=snapshot.with_suffix(snapshot.suffix+'.meta')
    expected_meta=spec.get('metaSha256') or plan_by_path.get(rel,{}).get('metaSha256')
    records.append({'path':rel,'currentSha256':digest(source),'sourceBeforeSha256':spec['sourceBeforeSHA256'],'sourceMatchesOwnedScope':digest(source)==spec['sourceBeforeSHA256'],'snapshotExists':snapshot.exists(),'snapshotSha256':digest(snapshot) if snapshot.exists() else None,'snapshotMatchesSource':snapshot.exists() and digest(snapshot)==digest(source),'metaPath':str(meta),'metaSha256':digest(meta) if meta.exists() else None,'metaSnapshotSha256':digest(snapshot_meta) if snapshot_meta.exists() else None,'metaMatchesSnapshot':meta.exists() and snapshot_meta.exists() and digest(meta)==digest(snapshot_meta),'metaBaselineSource':'owned-scope.json metaSha256 and source-before meta snapshot','metaExpectedSha256':expected_meta,'metaMatchesRecordedPlan':bool(expected_meta) and meta.exists() and digest(meta)==expected_meta,'sourceMethodTokenCount':len(parsed),'ownedScopeMethodTokenCount':len(spec['methods']),'methodBodyRvaDifferences':differences,'allExistingNonemptyBodies':[m for m in parsed if m['body'] not in ('','return null;','return default;')],'methods':parsed})
result={'stage':41,'generatedUtc':datetime.now(timezone.utc).isoformat(),'auditType':'independent read-only owned scope/body/token/meta baseline audit','ownedScopeSha256':digest(scope_path),'metaPlanSha256':digest(plan_path) if plan_path.exists() else None,'productionWrites':False,'unityStarted':False,'sharedIdaOpened':False,'files':records,'passed':all(r['sourceMatchesOwnedScope'] and r['snapshotMatchesSource'] and r['metaMatchesSnapshot'] and r['metaMatchesRecordedPlan'] and not r['methodBodyRvaDifferences'] for r in records)}
(OUT/'owned-scope-independent-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'passed':result['passed'],'files':[{'path':r['path'],'tokens':r['sourceMethodTokenCount'],'sourceMatches':r['sourceMatchesOwnedScope'],'metaMatchesRecordedPlan':r['metaMatchesRecordedPlan'],'differences':r['methodBodyRvaDifferences']}for r in records]},ensure_ascii=False,indent=2))
