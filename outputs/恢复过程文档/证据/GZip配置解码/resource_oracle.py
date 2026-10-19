import base64,gzip,hashlib,json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';project=root/'outputs/OccupyCityRecovered'
evidence=json.loads((root/'work/new-config-restore/native-consumer-evidence.json').read_text(encoding='utf-8'))
addresses=sorted({r['Value'] for m in evidence['methods'] if m['address']=='0x435df2c' for r in m['metadataReferences'] if r.get('category')=='ScriptString' and '/JsonData/' in r.get('Value','')});assert len(addresses)==81
sha=lambda b:hashlib.sha256(b).hexdigest()
records=[]
def inspect(path,address,category):
    raw=path.read_bytes();text=raw.decode('utf-8-sig');assert re.fullmatch(r'[A-Za-z0-9+/=\s]*',text)
    compressed=base64.b64decode(text);assert compressed[:3]==b'\x1f\x8b\x08'
    plain=gzip.decompress(compressed);decoded=plain.decode('utf-8');data=json.loads(decoded);assert isinstance(data,list)
    records.append(dict(address=address,path=str(path),category=category,sourceSha256=sha(raw),compressedSha256=sha(compressed),decodedUtf8Sha256=sha(plain),compressedBytes=len(compressed),decodedBytes=len(plain),rowCount=len(data),jsonKind='Array'))
for address in addresses:inspect(project/address,address,'original-addressable-81')
for address in addresses:
    paths=list((project/'Assets/Resources/JsonData').glob(Path(address).stem+'.*'))
    paths=[p for p in paths if p.suffix!='.meta']
    assert len(paths)==1,(address,paths)
    inspect(paths[0],'JsonData/'+paths[0].stem,'resources-matching-original-81')
(own/'resource-oracle.json').write_text(json.dumps(records,ensure_ascii=False,indent=2),encoding='utf-8')
print('Independent Python Base64+gzip+UTF8+JSON oracle:',len(records),'files; original addresses=',len(addresses),'resources=',len(records)-len(addresses),'rows=',sum(r['rowCount'] for r in records))
