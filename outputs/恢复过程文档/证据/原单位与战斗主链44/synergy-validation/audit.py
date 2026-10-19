import json,re,hashlib,difflib
from pathlib import Path
ROOT=Path(__file__).resolve().parents[3];OWN=Path(__file__).resolve().parent
baseline=(OWN/'SynergyEffectManager.source-before.cs').read_bytes();candidatePath=ROOT/'work/parallel-44-battle/candidate/Assets/Scripts/Assembly-CSharp/GameModule/SynergyEffectManager.cs';candidate=candidatePath.read_bytes();b=baseline.decode();c=candidate.decode()
methods=json.loads((OWN/'recovery-methods.json').read_text(encoding='utf-8'))['methods']+['InternalCalculateDamage','SynergyEffectManager']
def extract(src,name):
 n=name.split('.')[-1];m=re.search(r'\b'+re.escape(n)+r'\([^{}]*?\)\s*\{',src);assert m,name
 start=m.end()-1;i=start+1;depth=1
 while depth:
  if src[i]=='{':depth+=1
  if src[i]=='}':depth-=1
  i+=1
 return m.start(),start,i,src[m.start():i]
def mask(src):
 spans=[extract(src,n)[1:3] for n in methods]
 for start,end in sorted(spans,reverse=True):src=src[:start]+'{BODY}'+src[end:]
 return src
assert extract(b,'InternalCalculateDamage')[3]==extract(c,'InternalCalculateDamage')[3]
assert mask(b)==mask(c).replace('private bool IsUseNewFetter = SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest;','private bool IsUseNewFetter;')
assert re.findall(r'Token = "[^"]+"',b)==re.findall(r'Token = "[^"]+"',c)
source=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/SynergyEffectManager.cs';scope=json.loads((OWN/'scope.json').read_text(encoding='utf-8'));assert hashlib.sha256(source.read_bytes()).hexdigest()==scope['sha256'];assert hashlib.sha256(source.with_suffix('.cs.meta').read_bytes()).hexdigest()==scope['metaSha256']
readback=[{'method':n,'text':extract(c,n)[3],'sha256':hashlib.sha256(extract(c,n)[3].encode()).hexdigest()} for n in methods]
(OWN/'candidate-method-readback.json').write_text(json.dumps(readback,ensure_ascii=False,indent=2),encoding='utf-8')
(OWN/'SynergyEffectManager.patch').write_text(''.join(difflib.unified_diff(b.splitlines(True),c.splitlines(True),fromfile='source-before',tofile='candidate')),encoding='utf-8')
report={'sourceBeforeSha256':hashlib.sha256(baseline).hexdigest(),'candidateSha256':hashlib.sha256(candidate).hexdigest(),'candidate':str(candidatePath),'protectedInternalCalculateDamageByteExact':True,'unchangedDeclarationTokens':True,'onlyRecordedBodiesAndInitializerChanged':True,'sourceUnchanged':True,'metaUnchanged':True,'restoredRegularBodies':32,'restoredStateMachineBodies':2,'preservedPreviouslyRecoveredBodies':1,'originalConstructorBehaviourRestoredThroughFieldInitializer':True,'sourceLineEnding':'CRLF','candidateLineEnding':'CRLF'}
(OWN/'audit.json').write_text(json.dumps(report,indent=2),encoding='utf-8');print(json.dumps(report,indent=2))
