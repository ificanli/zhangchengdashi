import json,re,sys
from pathlib import Path
from bootstrap import members
W=Path(__file__).resolve().parent;O=W/'manager-validation';O.mkdir(exist_ok=True)
baseline='--baseline' in sys.argv
REL='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameManager.cs'
source=W/('source-before' if baseline else 'candidate')/REL
rows={r['rva'].lower():r for r in members(source.read_text(encoding='utf-8-sig'))}
selected=['3de3cf4','3de3c0c','3de3f10','3de3f20','3de3f2c','3de3f34','3de4088','3de50f8','3de5108','3de5278','3de5e20','3de6088','3de6178','3de65c8','3de666c','3de66fc','3de6788','3de6dac','3de3bdc','3de3cec','3de5300','3de5424','3de5444','3de531c','3de545c','3de5540','3de5d94']
blocks=[]
for key in selected:
 r=rows['0x'+key];sig=r['signature'].splitlines()[-1].strip()
 sig=re.sub(r'^(private|protected)\s+','public ',sig)
 if key=='3de6788':sig='public async System.Threading.Tasks.Task BeginStartCountDown(object o)'
 if key=='3de66fc':sig='public void CountDownEnd()'
 blocks.append(sig+'\n{'+r['body']+'\n}')
props='public float ElapseTime { get {'+rows['0x3de3a9c']['body']+'} }\npublic bool IsGamePaused { get {'+rows['0x3de3aac']['body']+'} set { _isGamePaused=value; } }'
(O/'ExtractedManager.cs').write_text('using System; using System.Collections; using System.Collections.Generic; using System.Threading.Tasks;\npublic partial class State {\n'+props+'\n'+'\n'.join(blocks)+'\n}',encoding='utf-8')
(O/'fixture-provenance.json').write_text(json.dumps(dict(baseline=baseline,source=str(source),rvas=['0x'+k for k in selected]+['0x3de3a9c','0x3de3aac'],adaptation='Dependency adapters; BeginStartCountDown async void -> Task; no-await CountDownEnd async void -> void. All selected business bodies re-extracted unchanged.'),indent=2),encoding='utf-8')
print('Extracted manager methods:',len(selected)+2,'baseline:',baseline)
