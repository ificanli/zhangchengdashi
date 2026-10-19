from pathlib import Path
import re,json,hashlib,difflib
W=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-41-config');P=W.parents[1]/'outputs/OccupyCityRecovered';plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8'));out=W/'verification';out.mkdir(exist_ok=True)
def span(text,token):
 a=text.index('{',text.index('[Token(Token = "'+token+'")'));b=a+1;depth=1;quote=None
 while depth:
  ch=text[b]
  if quote:
   if ch=='\\':b+=2;continue
   if ch==quote:quote=None
  elif ch in ('"', "'"):quote=ch
  elif text[b:b+2]=='//':
   b=text.index('\n',b);continue
  elif text[b:b+2]=='/*':
   b=text.index('*/',b+2)+2;continue
  else:depth+=(ch=='{')-(ch=='}')
  b+=1
 return a,b
records=[]
for row in plan['files']:
 rel=row['path'];a=(W/'source-before'/rel).read_text(encoding='utf-8-sig');b=(W/'candidate'/rel).read_text(encoding='utf-8-sig');restored=b
 tokens=re.findall(r'\[Token\(Token = "([^"]+)"\)\]',a);after=re.findall(r'\[Token\(Token = "([^"]+)"\)\]',b)
 assert [t for t in after if t!='0x6005765']==tokens
 for token in row['restoredTokens']:
  if token=='0x6005765':
   start=restored.index('        [Token(Token = "0x6005765")]');_,end=span(restored,token);restored=restored[:start]+restored[end+1:]
  else:
   sa,ea=span(a,token);sb,eb=span(restored,token);restored=restored[:sb]+a[sa:ea]+restored[eb:]
 normalize=lambda t:re.sub(r'\n(?:[ \t]*\n)+','\n',t)
 assert normalize(restored)==normalize(a),rel
 current=P/rel;assert hashlib.sha256(current.read_bytes()).hexdigest()==row['sourceBeforeSha256']
 assert hashlib.sha256(current.with_suffix('.cs.meta').read_bytes()).hexdigest()==row['metaSha256']
 patch='\n'.join(difflib.unified_diff(a.splitlines(),b.splitlines(),fromfile='before/'+rel,tofile='candidate/'+rel,lineterm=''))
 (out/(Path(rel).stem+'.patch')).write_text(patch,encoding='utf-8')
 records.append({'file':rel,'onlyListedMethodBodiesAndOriginalCctorChanged':True,'allOriginalTokenAndFieldIdentityPreserved':True,'liveSourceBeforeSHAUnchanged':True,'metaSHAUnchanged':True,'candidateSha256':hashlib.sha256((W/'candidate'/rel).read_bytes()).hexdigest(),'changedMethods':len(row['restoredTokens'])})
result={'stage':41,'allPassed':True,'changedMethodCount':sum(x['changedMethods'] for x in records),'files':records};(out/'scope-diff-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(result,ensure_ascii=False,indent=2))
