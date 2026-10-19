import hashlib
import json
import re
import shutil
import sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/stage48-new-ui';PROJECT=ROOT/'outputs/OccupyCityRecovered'
panel_source=PROJECT/'Assets/Scripts/Assembly-CSharp/UIFramework/UIPanel.cs'
before=OWN/'source-before/UIPanel.cs'
if not before.exists():
    shutil.copy2(panel_source,before);shutil.copy2(panel_source.with_suffix('.cs.meta'),before.with_suffix('.cs.meta'))
def span(text,token):
    pos=text.index('[Token(Token = "'+token+'")]');begin=text.index('{',pos);end=begin+1;depth=1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    return pos,begin,end
old=before.read_text(encoding='utf-8-sig');pos,a,b=span(old,'0x6004C4C')
candidate=old[:a]+'{\n\t\t\tthis.panelConfig = panelConfig;\n\t\t}'+old[b:]
(OWN/'UIPanel.candidate.cs').write_text(candidate,encoding='utf-8')
mode='baseline'if'--baseline'in sys.argv else'actual'if'--actual'in sys.argv else'candidate'
manager_path=OWN/'source-before/UIManager.cs'if mode=='baseline'else PROJECT/'Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs'if mode=='actual'else OWN/'UIManager.candidate.cs'
panel_path=before if mode=='baseline'else panel_source if mode=='actual'else OWN/'UIPanel.candidate.cs'
manager=manager_path.read_text(encoding='utf-8-sig');panel=panel_path.read_text(encoding='utf-8-sig')
def body(text,token):
    pos,a,b=span(text,token);return text[a:b]
fields=[]
for token in ['0x400585B','0x400585C','0x400585E']:
    section=manager[manager.index('[Token(Token = "'+token+'")'):]
    match=re.search(r'(?:public|private) [\w<>, ]+ [\w]+;',section)
    assert match,token
    fields.append(match[0])
parts=['using System;','using System.Collections.Generic;','using System.Threading.Tasks;','using UnityEngine;','using ToolModule;','using DataModule;','namespace UIFramework {','public class UIManager : ManagerBase<UIManager> {',*fields]
for token,signature in [('0x6004C57',('public override async Task Init()'if'async UniTask Init()'in manager else'public override Task Init()')),('0x6004C58',('public async Task<UIPanel> GetPanel(string panelPath)'if'async UniTask<UIPanel> GetPanel'in manager else'public Task<UIPanel> GetPanel(string panelPath)')),('0x6004C5C',('private async Task<UIPanel> LoadPanel(string panelPath)'if'async Task<UIPanel> LoadPanel'in manager else'private Task<UIPanel> LoadPanel(string panelPath)'))]:
    parts.extend([signature,body(manager,token)])
parts+=['}','public class UIPanel : MonoBehaviour {','private PanelConfig panelConfig;','public void Init(PanelConfig panelConfig)',body(panel,'0x6004C4C'),'}','}']
out=OWN/'tests/ActualSource.fixture.cs';out.parent.mkdir(exist_ok=True);out.write_text('\n'.join(parts),encoding='utf-8')
provenance=dict(mode=mode,managerSource=str(manager_path),managerSha256=hashlib.sha256(manager_path.read_bytes()).hexdigest(),panelSource=str(panel_path),panelSha256=hashlib.sha256(panel_path.read_bytes()).hexdigest(),extractedManagerTokens=['0x6004C57','0x6004C58','0x6004C5C'],extractedPanelTokens=['0x6004C4C'],onlyAdaptation='UniTask return signatures -> Task for controlled non-Unity dependency tests; bodies are directly extracted')
(OWN/'tests'/('fixture-'+mode+'.json')).write_text(json.dumps(provenance,ensure_ascii=False,indent=2),encoding='utf-8')
print('extracted',mode,'three manager bodies and original leaf Init body')
