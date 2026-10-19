import base64
import gzip
import hashlib
import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];PROJECT=ROOT/'outputs/OccupyCityRecovered';OWN=ROOT/'work/stage48-new-ui'
panel='Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/NoInternetPanel.prefab'
registry=PROJECT/'Assets/Resources/AddressablesConfig.json'
config=json.loads(registry.read_text(encoding='utf-8-sig'))
registry_match=[row for row in config['items'] if row['assetPath']==panel]
table=PROJECT/'Assets/_Res/Addressable/01FirstBundle/JsonData/PanelConfig.json';data=table.read_bytes();decoded=data
try:decoded=gzip.decompress(base64.b64decode(data))
except Exception:pass
text=decoded.decode('utf-8-sig')
rows=json.loads(text)
matches=[]
def visit(value,path=''):
    if isinstance(value,dict):
        if any(isinstance(v,str)and 'NoInternetPanel'in v for v in value.values()):matches.append(dict(path=path,value=value))
        for k,v in value.items():visit(v,path+'/'+str(k))
    elif isinstance(value,list):
        for i,v in enumerate(value):visit(v,path+'/'+str(i))
visit(rows)
report=dict(panelAddress=panel,prefabSha256=hashlib.sha256((PROJECT/panel).read_bytes()).hexdigest(),addressablesConfigMatch=registry_match,panelConfigFile=str(table),panelConfigSourceSha256=hashlib.sha256(data).hexdigest(),panelConfigDecodedSha256=hashlib.sha256(decoded).hexdigest(),panelConfigMatchingRows=matches,readOnly=True,actualTypedUnityLoad=False)
(OWN/'first-panel-static-identity.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(report,ensure_ascii=True,indent=2))
