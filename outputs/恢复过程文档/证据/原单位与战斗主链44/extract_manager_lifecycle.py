"""Read actual selected candidate bodies; adapt only return/async dependency surface."""
import sys,json,hashlib,textwrap
from pathlib import Path
W=Path(__file__).resolve().parent; P=W/'manager-lifecycle-validation';P.mkdir(exist_ok=True)
sys.path.insert(0,str(W));from bootstrap import members
baseline='--baseline' in sys.argv
rel='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameManager.cs'; source=W/('source-before' if baseline else 'candidate')/rel
text=source.read_text(encoding='utf-8-sig');rows={x['rva'].lower():x for x in members(text)}
selected=[('0x3de3b50','Init'),('0x3de3fd8','GameEnd'),('0x3de6814','StartGame')];output=['// Generated from actual source. No gameplay implementation is maintained in this fixture.','using System;','using System.Collections.Generic;','using System.Threading.Tasks;','using ToolModule;','public partial class State {'];provenance=[]
for rva,name in selected:
 row=rows[rva];body=row['body'];adapt=[]
 if name=='Init':
  if baseline:
   assert body.strip()=='return default;';body=body.replace('return default;','return Task.CompletedTask;');sig='public Task Init()';adapt.append('default completed UniTask struct -> Task.CompletedTask')
  else:sig='public async Task Init()';adapt.append('async UniTask -> async Task')
 elif name=='GameEnd':sig='public async Task GameEnd(bool isVictory, bool doTxtAni)';adapt.append('async void -> async Task; await exception observation only')
 else:sig='public void StartGame(BattleContext battleContext)'
 output+=[sig+'\n{'+body+'\n}'];provenance.append({'name':name,'rva':rva,'token':row['token'],'sourceSignature':row['signature'],'bodyOriginal':row['body'],'bodySha256':hashlib.sha256(row['body'].encode()).hexdigest(),'adaptations':adapt})
output+=['}'];(P/'ExtractedLifecycle.cs').write_text('\n'.join(output),encoding='utf-8');(P/'fixture-provenance.json').write_text(json.dumps({'baseline':baseline,'source':str(source),'sourceSha256':hashlib.sha256(source.read_bytes()).hexdigest(),'methods':provenance},ensure_ascii=False,indent=2),encoding='utf-8');print('extracted',len(selected),'methods','baseline' if baseline else 'candidate')
