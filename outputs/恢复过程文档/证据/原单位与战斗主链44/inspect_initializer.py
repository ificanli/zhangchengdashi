import json,struct,hashlib
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];WORK=Path(__file__).resolve().parent
d=(ROOT/'work/metadata-probe/global-metadata.decoded.dat').read_bytes()
def section(i):
    off,n=struct.unpack_from('<II',d,8+i*8); return off,n
so,sn=section(2); fo,fn=section(11); do,dn=section(7); vo,vn=section(8)
name='6266F3AB8B88B2FDCDBA46AEF11DBE7FF2F6ACA4D4D12BC726B5206CFE429A3D'
si=d[so:so+sn].index(name.encode()+b'\0')
fields=[]
for i in range(fn//12):
    row=struct.unpack_from('<iii',d,fo+i*12)
    if row[0]==si: fields.append((i,row))
rows=[]
for field,row in fields:
    for at in range(do,do+dn,12):
        fi,ti,di=struct.unpack_from('<iii',d,at)
        if fi==field:
            raw=d[vo+di:vo+di+12]
            rows.append(dict(field_index=fi,type_index=ti,data_index=di,field_record=row,data_hex=raw.hex(),ints=list(struct.unpack('<3i',raw)),data_sha256=hashlib.sha256(raw).hexdigest()))
(WORK/'manager-initializer-evidence.json').write_text(json.dumps(rows,indent=2),encoding='utf-8')
print(json.dumps(rows))
