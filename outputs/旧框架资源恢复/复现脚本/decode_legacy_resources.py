"""Reproduce the proven SplitColors chain on derived copies only.

Evidence RVAs: QnXgString 0x7241D94 -> 0x7175D04 -> 0x72633A4;
key encoding 0x72633C4 (UTF-16LE), uint conversion 0x7263658,
core 0x7264C4C, key padding 0x7264BB8, delta 0x7264DEC/.cctor,
output conversion bounded ASM [0x7263A50,0x7263C70).
"""
import argparse,collections,hashlib,json,re,struct,zipfile
from pathlib import Path
import UnityPy
from recovery_plan_io import write_json_atomic

root=Path(__file__).resolve().parents[2]
MASK=0xffffffff;DELTA=0x9e3779b9
KEY='WeDoBest' # ScriptString slot 0x8D778E8; no candidate-key search.

def to_words(data,include_length=False):
    padded=data+b'\0'*((-len(data))%4)
    words=list(struct.unpack('<'+'I'*(len(padded)//4),padded))
    if include_length:words.append(len(data))
    return words

def mx(z,y,total,key,p,e):
    return ((((z>>5)^(y<<2))+((y>>3)^(z<<4))) ^ ((total^y)+(key[(p&3)^e]^z))) & MASK

def split_colors(data,key_string):
    if not data:return data
    words=to_words(data,False)
    key=to_words(key_string.encode('utf-16le'),False)
    if len(key)<4:key.extend([0]*(4-len(key)))
    n=len(words)
    if n>=2:
        total=((6+52//n)*DELTA)&MASK
        y=words[0]
        while total:
            e=(total>>2)&3
            for p in range(n-1,0,-1):
                z=words[p-1]
                words[p]=(words[p]-mx(z,y,total,key,p,e))&MASK
                y=words[p]
            z=words[n-1]
            words[0]=(words[0]-mx(z,y,total,key,0,e))&MASK
            y=words[0]
            total=(total-DELTA)&MASK
    length=words[-1]
    capacity=(len(words)-1)*4
    if not 0<=capacity-length<4:
        raise ValueError(f'Original output-length check failed: length={length}, capacity={capacity}')
    return struct.pack('<'+'I'*len(words),*words)[:length]

def inverse_for_roundtrip(data,key_string):
    """Algebraic inverse of the proven loop; not a claim that BlendColors was recovered."""
    if not data:return data
    words=to_words(data,True);key=to_words(key_string.encode('utf-16le'))
    if len(key)<4:key.extend([0]*(4-len(key)))
    n=len(words);z=words[-1];total=0
    for _ in range(6+52//n):
        total=(total+DELTA)&MASK;e=(total>>2)&3
        for p in range(n-1):
            y=words[p+1];words[p]=(words[p]+mx(z,y,total,key,p,e))&MASK;z=words[p]
        y=words[0];words[-1]=(words[-1]+mx(z,y,total,key,n-1,e))&MASK;z=words[-1]
    return struct.pack('<'+'I'*n,*words)

def main(apk_path=None, output_dir=None):
    out=Path(output_dir) if output_dir else Path(__file__).resolve().parent/'legacy-decoded'
    out.mkdir(parents=True,exist_ok=True)
    texts=out/'textassets';texts.mkdir(exist_ok=True)
    apk_path=Path(apk_path) if apk_path else root/'work/apk-intake/zhancheng-dashi-1.04.apk'
    names=['ABFiles.txt','88f786fb5f53905f559260048dbfe059.unity3d','b1a1165a67f21d096a79a144bac38207.unity3d']
    results=[]
    with zipfile.ZipFile(apk_path) as z:
        for name in names:
            apk_entry='assets/Android/ljzs_lt/'+name;raw=z.read(apk_entry)
            row={'apkEntry':apk_entry,'sourceBytes':len(raw),'sourceSha256':hashlib.sha256(raw).hexdigest(),'codecEvidence':'proven ABFiles consumer chain; same exact codec applied once to two opaque bundle copies, with structure/roundtrip checks','codec':'XXTEA-like proven uint32 mixing loop; delta 0x9E3779B9; UTF16LE key; LE words; final word length','keyMetadataSlot':'0x8D778E8'}
            try:
                plain=split_colors(raw,KEY)
                target=out/name;target.write_bytes(plain)
                row.update(decodedBytes=len(plain),decodedSha256=hashlib.sha256(plain).hexdigest(),output=str(target),roundtripMatchesInput=inverse_for_roundtrip(plain,KEY)==raw,signature=repr(plain[:16]))
                if plain.startswith(b'UnityFS\0'):
                    env=UnityPy.load(plain)
                    row['unityTypeCounts']=dict(collections.Counter(o.type.name for o in env.objects))
                    row['serializedFiles']=[{'name':f.name,'version':f.unity_version,'objects':len(f.objects)} for f in env.assets]
                    row['textAssets']=[]
                    for obj in env.objects:
                        if obj.type.name!='TextAsset':continue
                        data=obj.read();b=data.m_Script
                        if isinstance(b,str):b=b.encode('utf-8',errors='surrogateescape')
                        safe=re.sub(r'[^A-Za-z0-9_.-]','_',data.m_Name)
                        p=texts/f'{Path(name).stem}-{obj.path_id}-{safe}.bytes';p.write_bytes(b)
                        row['textAssets'].append({'name':data.m_Name,'pathId':str(obj.path_id),'bytes':len(b),'sha256':hashlib.sha256(b).hexdigest(),'output':str(p)})
                    row['structureValid']=bool(row['unityTypeCounts'])
                else:
                    text=plain.decode('utf-8')
                    row['utf8Valid']=True
                    try:
                        parsed=json.loads(text)
                        row['jsonShape']=list(parsed) if isinstance(parsed,dict) else {'type':type(parsed).__name__,'length':len(parsed)}
                        row['structureValid']=True
                    except json.JSONDecodeError:
                        lines=text.splitlines();row['lineCount']=len(lines);row['structureValid']=False
                        if name=='ABFiles.txt' and lines:
                            header=lines[0].split('|');records=[]
                            for line in lines[1:]:
                                logical,stored,declared_hash,declared_size=line.split('|')
                                if stored.startswith('/') or '..' in stored.split('/'):raise ValueError('Manifest path outside bundle directory')
                                source_entry='assets/Android/ljzs_lt/'+stored
                                blob=z.read(source_entry)
                                records.append({'logicalName':logical,'storedName':stored,'declaredHash':declared_hash,'declaredSize':int(declared_size),'actualSize':len(blob),'sizeMatches':int(declared_size)==len(blob),'rawMd5':hashlib.md5(blob).hexdigest(),'rawMd5Matches':hashlib.md5(blob).hexdigest()==declared_hash,'logicalNameMd5Matches':hashlib.md5(logical.encode('utf-8')).hexdigest()==declared_hash,'apkEntry':source_entry})
                            row['manifestEntryCount']=len(records)
                            row['manifestAllFilesPresent']=True
                            row['manifestAllSizesMatch']=all(r['sizeMatches'] for r in records)
                            row['manifestRawMd5Matches']=sum(r['rawMd5Matches'] for r in records)
                            row['manifestLogicalNameMd5Matches']=sum(r['logicalNameMd5Matches'] for r in records)
                            row['structureValid']=len(header)==4 and bool(records) and row['manifestAllSizesMatch'] and len({r['logicalName'] for r in records})==len(records)
                            write_json_atomic(out/'manifest-structure.json',{'headerFields':header,'entries':records,'headerSemantics':'preserved as text; not inferred from numeric appearance'})
                row['success']=row['roundtripMatchesInput'] and row.get('structureValid',False)
            except Exception as error:
                row['success']=False;row['error']=f'{type(error).__name__}: {error}'
            results.append(row)
    write_json_atomic(out/'decode-report.json',results)
    print(json.dumps(results,ensure_ascii=True,indent=2))

if __name__ == "__main__":
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--apk',type=Path,help='Original APK to read; never modified')
    parser.add_argument('--out',type=Path,help='Directory for derived outputs')
    args=parser.parse_args()
    main(args.apk,args.out)
