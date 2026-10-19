"""Reproduce the final, evidence-proven legacy decode from an original APK.

This entry point decodes ABFiles with its own proven key, verifies all manifest
rows, then decodes only the two data/ bundles with PatchManifest.RandomSeed.
It does not reuse the manifest key on encrypted bundles.
"""
import argparse
import hashlib
import json
import zipfile
from pathlib import Path, PurePosixPath

from decode_legacy_resources import KEY, inverse_for_roundtrip, split_colors
from decode_data_bundles import main as decode_data
from recovery_plan_io import write_json_atomic

def main(apk_path, out):
    out=Path(out).resolve(); out.mkdir(parents=True,exist_ok=True)
    apk_path=Path(apk_path).resolve()
    with zipfile.ZipFile(apk_path) as apk:
        entry='assets/Android/ljzs_lt/ABFiles.txt'; raw=apk.read(entry)
        plain=split_colors(raw,KEY)
        if inverse_for_roundtrip(plain,KEY)!=raw:raise ValueError('ABFiles roundtrip mismatch')
        lines=plain.decode('utf-8').splitlines()
        if len(lines[0].split('|'))!=4:raise ValueError('ABFiles header is not the observed four fields')
        rows=[]
        for line in lines[1:]:
            logical,stored,md5,size=line.split('|')
            if PurePosixPath(stored).is_absolute() or '..' in PurePosixPath(stored).parts or '\\' in stored:raise ValueError('Unexpected stored filename')
            data=apk.read('assets/Android/ljzs_lt/'+stored)
            if len(data)!=int(size) or hashlib.md5(data).hexdigest()!=md5:raise ValueError('Original manifest size/MD5 mismatch')
            rows.append({'logicalName':logical,'storedName':stored,'declaredSize':int(size),'declaredMd5':md5,'sha256':hashlib.sha256(data).hexdigest()})
        (out/'ABFiles.txt').write_bytes(plain)
        write_json_atomic(out/'manifest-reproduction.json',{'apkEntry':entry,'sourceBytes':len(raw),'sourceSha256':hashlib.sha256(raw).hexdigest(),'decodedBytes':len(plain),'decodedSha256':hashlib.sha256(plain).hexdigest(),'roundtripMatchesInput':True,'manifestRows':len(rows),'allOriginalSizeAndMd5ChecksPassed':True,'entries':rows})
    decode_data(apk_path,out)
    print(json.dumps({'manifestRows':len(rows),'manifestBytes':len(plain),'output':str(out),'success':True},ensure_ascii=True,indent=2))

if __name__=='__main__':
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--apk',type=Path,required=True)
    parser.add_argument('--out',type=Path,required=True)
    args=parser.parse_args()
    main(args.apk,args.out)
