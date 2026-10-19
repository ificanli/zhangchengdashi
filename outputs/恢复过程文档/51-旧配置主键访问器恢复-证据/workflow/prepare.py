from pathlib import Path
import argparse,hashlib,json,re
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');W=ROOT/'work/stage51-config-keys';P=ROOT/'outputs/OccupyCityRecovered'
SCOPE=ROOT/'work/parallel-coordination/stage41-required-getter-targets.json'
def sha(p):return hashlib.sha256(Path(p).read_bytes()).hexdigest()
def span(text,token):
    a=text.index('{',text.index('[Token(Token = "'+token+'")'));b=a+1;depth=1;quote=None
    while depth:
        c=text[b]
        if quote:
            if c=='\\':b+=2;continue
            if c==quote:quote=None
        elif c in ('"',"'"):quote=c
        elif text[b:b+2]=='//':b=text.index('\n',b);continue
        elif text[b:b+2]=='/*':b=text.index('*/',b+2)+2;continue
        else:depth+=(c=='{')-(c=='}')
        b+=1
    return a,b
def snapshot():
    scope=json.loads(SCOPE.read_text(encoding='utf-8-sig'));assert scope['count']==38
    files=[]
    for x in scope['targets']:
        p=P/x['file'];m=p.with_suffix('.cs.meta');assert sha(p)==x['sourceSha256'] and sha(m)==x['metaSha256']
        for source in [p,m]:
            target=W/'source-before'/source.relative_to(P);target.parent.mkdir(parents=True,exist_ok=True)
            if target.exists():assert sha(target)==sha(source)
            else:target.write_bytes(source.read_bytes())
        text=p.read_bytes().decode('utf-8-sig');a,b=span(text,x['token']);assert re.sub(r'\s+','',text[a+1:b-1])=='returnnull;'
        files.append({'path':x['file'],'type':x['type'],'sourceBeforeSha256':sha(p),'metaSha256':sha(m),'guid':x['guid'],'restoredTokens':[x['token']],'token':x['token'],'rva':x['rva'],'endRva':x['endRva'],'candidateBody':x['candidateBody'],'field':x['field'],'nativeCodeSha256':x['codeSha256'],'nativeEvidence':x['evidence']})
    plan={'stage':41,'extension':'38-row-uniqueid-getters','workRoot':str(W),'scopeFile':str(SCOPE),'scopeSha256':sha(SCOPE),'fileCount':38,'bodyCount':38,'files':files}
    (W/'write-plan.json').write_text(json.dumps(plan,ensure_ascii=False,indent=2),encoding='utf-8')
    print('SNAPSHOT 38 source/meta files and exact native scope; production writes0')
def candidate():
    plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8-sig'))
    for x in plan['files']:
        p=W/'source-before'/x['path'];raw=p.read_bytes();bom=raw.startswith(b'\xef\xbb\xbf');text=raw.decode('utf-8-sig');a,b=span(text,x['token']);body=text[a+1:b-1]
        assert re.sub(r'\s+','',body)=='returnnull;'
        newbody=body.replace('return null;',x['candidateBody']);assert newbody!=body
        updated=text[:a+1]+newbody+text[b-1:]
        q=W/'candidate'/x['path'];q.parent.mkdir(parents=True,exist_ok=True);q.write_bytes((b'\xef\xbb\xbf' if bom else b'')+updated.encode('utf-8'))
        ca,cb=span(updated,x['token']);assert updated[:ca+1]+body+updated[cb-1:]==text
        assert re.findall(r'\[Token\(Token = "([^\"]+)"\)\]',updated)==re.findall(r'\[Token\(Token = "([^\"]+)"\)\]',text)
        x['candidateSha256']=sha(q);x['onlyGetterBodyChanged']=True
    (W/'write-plan.json').write_text(json.dumps(plan,ensure_ascii=False,indent=2),encoding='utf-8');print('CANDIDATE 38 original boxedInt32 getters only; source bytes outside body preserved')
if __name__=='__main__':
    ap=argparse.ArgumentParser();ap.add_argument('--snapshot',action='store_true');ap.add_argument('--candidate',action='store_true');args=ap.parse_args()
    if args.snapshot:snapshot()
    if args.candidate:candidate()
