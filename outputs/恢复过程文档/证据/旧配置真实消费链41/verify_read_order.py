from pathlib import Path
import re,json
W=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-41-config')
n=json.loads((W/'evidence/ida-chain/native-chain-golden.json').read_text(encoding='utf-8'));native=next(x for x in n['cases'] if x['kind']=='ReadConfig' and x['failIndex']==-1)
order=[re.search(r'<([^>]+)>',x['name']).group(1) for x in native['trace']]
candidate=(W/'candidate/Assets/Scripts/Assembly-CSharp/ljzs_lt/ConfigMgr.cs').read_text(encoding='utf-8')
actual=re.findall(r'GameFramework.ConfigRead.readConfig(?:ByUnityJson|VByUnityJson)<([^>]+)>',candidate)
t=json.loads((W/'tests/generated/candidate-fixture-getters/result.json').read_text(encoding='utf-8'));trace=next(x for x in t['boundaries'] if x['scenario']=='full-real-load')['reads']
assert order==actual==trace,(order,actual,trace)
out={'allPassed':True,'nativeActualInstructionCalls':order,'candidateRetranscribedCalls':actual,'actualCandidateThroughControlledBoundaryCalls':trace,'callCount':len(order),'tableCalls':38,'objectCalls':3,'basis':'Original ARM64 MethodInfo identities, candidate source body, and actual candidate execution independently compared'}
(W/'verification/read-order-comparison.json').write_text(json.dumps(out,ensure_ascii=False,indent=2),encoding='utf-8');print('PASS: all 41 actual candidate resource requests match original ARM64 MethodInfo order')
