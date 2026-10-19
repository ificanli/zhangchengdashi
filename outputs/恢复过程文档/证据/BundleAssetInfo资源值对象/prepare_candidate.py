import hashlib
import json
import re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/bundleassetinfo-recovery'
before=OWN/'source-before/BundleAssetInfo.cs'
text=before.read_text(encoding='utf-8-sig')
native=json.loads((OWN/'native-consumer-evidence.json').read_text(encoding='utf-8'))
fields={int(m[1],16):dict(type=m[2],name=m[3]) for m in re.finditer(r'\[FieldOffset\(Offset = "(0x[\da-fA-F]+)"\)\]\s*(?:private|public|internal)\s+(string|int|bool)\s+([\w]+)\s*;',text)}
def span(value,token,last=True):
    marker='[Token(Token = "'+token+'")]';pos=value.rfind(marker)if last else value.index(marker);begin=value.index('{',pos);depth=1;end=begin+1
    while depth:
        if value[end]=='{':depth+=1
        elif value[end]=='}':depth-=1
        end+=1
    return pos,begin,end
def replace(value,token,body):
    pos,begin,end=span(value,token)
    return value[:begin]+'{\n\t\t\t'+body+'\n\t\t}'+value[end:]
proof=[]
for item in native['methods']:
    if item['bytes']!=8:continue
    line=(ROOT/item['assembly']).read_text(encoding='utf-8').splitlines()[0]
    instruction=re.search(r'\b(ldr|str)\s+([xw][01]), \[x0, #0x([\da-f]+)\]',line)
    assert instruction,line
    op,register,offset=instruction.groups();offset=int(offset,16)
    field=fields[offset]
    assert register==('x0'if op=='ldr'else'x1') if field['type']=='string' else register==('w0'if op=='ldr'else'w1')
    address=int(item['address'],16)
    source_match=list(re.finditer(r'\[Token\(Token = "(0x6[\da-fA-F]+)"\)\]\s*\[Address\(RVA = "0x'+format(address,'X')+'"',text))
    assert source_match,(hex(address),item['name'])
    token=source_match[-1][1]
    if op=='ldr':body='return '+field['name']+';'
    else:
        pos,begin,end=span(text,token)
        signature=text[pos:begin]
        parameter=re.search(r'\((?:string|int) ([\w]+)\)\s*$',signature).group(1)
        body=field['name']+' = '+parameter+';'
    text=replace(text,token,body)
    proof.append(dict(token=token,address=item['address'],fieldOffset=hex(offset),field=field['name'],fieldType=field['type'],operation=op,codeSha256=item['codeSha256']))
assert len(proof)==52,len(proof)
full='''
f_008Bn_00ADHW = _00A7r_0091R_007EE;
_005E_00A4Ui_00A6o = pgtmLu;
_00B7_00BBTZdÂ = V_00B2_00BEHJA;
IsEncrypAB = CSNb_0094_00B4;
_008F_00BB_007FT_007Ec = j_0081xY_0088_0088;
_0092nÁs_0081g = Olts_00BCª;
RK_0099_0083r_00A3 = _008F_00BEs_007E_0086_0095;
h_00A1Y_0097_00A1_0093 = X_00A5Á_007B_0090_00BB;
if (CLog._00AEDzn_00B4E)
    CLog.Log(LogTAG.AssetBundlesDetailed, string.Format("CreateBundleAssetInfo:BundleName=[{0}] LocalPath=[{1}] RemoteURL=[{2}] Version=[{3}]  IsEncrypAB=[{4}] obfuscatorName[{5}] randomSeed[{6}] isInApp[{7}]", new object[] { BundleName, LocalPath, RemoteURL, Version, IsEncrypAB, Olts_00BCª, _008F_00BEs_007E_0086_0095, X_00A5Á_007B_0090_00BB }));
'''.strip()
short='''
_008F_00BB_007FT_007Ec = j_0081xY_0088_0088;
f_008Bn_00ADHW = _00A7r_0091R_007EE;
_00B7_00BBTZdÂ = 0;
_005E_00A4Ui_00A6o = string.Empty;
'''.strip()
text=replace(text,'0x600725F',full.replace('\n','\n\t\t\t'))
text=replace(text,'0x6007272',short.replace('\n','\n\t\t\t'))
text=text.replace('internal bool h_00A1Y_0097_00A1_0093;','internal bool h_00A1Y_0097_00A1_0093 = true;')
(OWN/'BundleAssetInfo.candidate.cs').write_text(text,encoding='utf-8')
result=dict(accessors=proof,constructorTokens=['0x600725F','0x6007272'],fieldInitializer='h_00A1Y_0097_00A1_0093=true',sourceBeforeSha256=hashlib.sha256(before.read_bytes()).hexdigest(),candidateSha256=hashlib.sha256((OWN/'BundleAssetInfo.candidate.cs').read_bytes()).hexdigest())
(OWN/'candidate-provenance.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
compiler=(ROOT/'work/stage40-ui/compile.ps1').read_text(encoding='utf-8').replace('work\\stage40-ui','work\\bundleassetinfo-recovery').replace('work\\t40g','work\\tbig').replace("'UIModule.candidate.cs'","'BundleAssetInfo.candidate.cs'").replace('Assets/Scripts/GFRunning/GameFramework/UIModule.cs','Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs').replace('stage=40','stage=39')
(OWN/'compile.ps1').write_text(compiler,encoding='utf-8')
print('candidate:',len(proof),'proven native 8-byte scalar accessors + 2 original constructors')
