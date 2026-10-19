"""Decode only data/ bundles through their proven original consumer chain.

PatchManifest ctor 0x72ECFD8: header[3] -> RandomSeed at +0x18.
GetAssetBundleInfo 0x72EF2A0 -> BundleAssetInfo ctor 0x72EB0D0: seed -> +0x38.
LoadAssetBundleInternal 0x7363F34 -> loader ctor 0x73622FC -> +0x20.
IsDone 0x736221C -> 0x71758D0 -> SplitColors 0x72633A4.
The default XiaoBuDing is used only when the actual manifest seed is empty.
Original APK and extracted inputs are never written.
"""
import argparse
import collections
import hashlib
import json
import re
import zipfile
from pathlib import Path

import UnityPy
from UnityPy.streams import EndianBinaryReader

from decode_legacy_resources import inverse_for_roundtrip, split_colors
from recovery_plan_io import write_json_atomic

ROOT = Path(__file__).resolve().parents[2]
OUT = Path(__file__).resolve().parent / 'legacy-decoded'


def sha256(data):
    return hashlib.sha256(data).hexdigest()


def inspect_bundle(data, env):
    """Independently enumerate/decompress every UnityFS block and directory node."""
    reader = EndianBinaryReader(data)
    signature = reader.read_string_to_null()
    version = reader.read_u_int()
    unity_version = reader.read_string_to_null()
    revision = reader.read_string_to_null()
    size = reader.read_long()
    compressed_info_size = reader.read_u_int()
    uncompressed_info_size = reader.read_u_int()
    flags = reader.read_u_int()
    if signature != 'UnityFS' or size != len(data):
        raise ValueError('UnityFS signature or full declared length mismatch')
    if version >= 7:
        reader.align_stream(16)
    else:
        raise ValueError('This evidence reader only claims the observed version >= 7 layout')
    bundle = next(f for f in env.files.values() if getattr(f, 'signature', None) == 'UnityFS')
    if flags & 0x80:
        block_info = data[len(data)-compressed_info_size:]
    else:
        block_info = reader.read_bytes(compressed_info_size)
    info_bytes = bundle.decompress_data(block_info, uncompressed_info_size, flags)
    if len(info_bytes) != uncompressed_info_size:
        raise ValueError('Block-info decoded size mismatch')
    info = EndianBinaryReader(info_bytes)
    data_hash = info.read_bytes(16).hex()
    blocks = []
    for _ in range(info.read_int()):
        blocks.append({'uncompressedSize': info.read_u_int(), 'compressedSize': info.read_u_int(), 'flags': info.read_u_short()})
    nodes = []
    for _ in range(info.read_int()):
        nodes.append({'offset': info.read_long(), 'size': info.read_long(), 'flags': info.read_u_int(), 'path': info.read_string_to_null()})
    if info.Position != len(info_bytes):
        raise ValueError('Unconsumed block-info bytes')
    if flags & 0x200:
        reader.align_stream(16)
    decoded_blocks = []
    for i, block in enumerate(blocks):
        raw = reader.read_bytes(block['compressedSize'])
        decoded = bundle.decompress_data(raw, block['uncompressedSize'], block['flags'], i)
        if len(raw) != block['compressedSize'] or len(decoded) != block['uncompressedSize']:
            raise ValueError('Bundle block size mismatch')
        block.update(actualDecodedSize=len(decoded), sha256=sha256(decoded))
        decoded_blocks.append(decoded)
    block_data = b''.join(decoded_blocks)
    for node in nodes:
        if node['offset'] < 0 or node['size'] < 0 or node['offset']+node['size'] > len(block_data):
            raise ValueError('Directory node outside decoded blocks')
        node['sha256'] = sha256(block_data[node['offset']:node['offset']+node['size']])
    data_end = len(data)-compressed_info_size if flags & 0x80 else len(data)
    if reader.Position != data_end:
        raise ValueError('Unconsumed bundle data bytes')
    return {'signature': signature, 'formatVersion': version, 'unityVersion': unity_version, 'revision': revision,
            'declaredSize': size, 'actualSize': len(data), 'flags': flags, 'blockInfoHashField': data_hash,
            'compressedInfoSize': compressed_info_size, 'uncompressedInfoSize': uncompressed_info_size,
            'blocks': blocks, 'nodes': nodes, 'allBlockSizesMatch': True, 'allNodeBoundsValid': True}


def main(apk_path=None, output_dir=None):
    global OUT
    if output_dir is not None:
        OUT=Path(output_dir)
    apk_path=Path(apk_path) if apk_path else ROOT/'work/apk-intake/zhancheng-dashi-1.04.apk'
    manifest_bytes = (OUT/'ABFiles.txt').read_bytes()
    lines = manifest_bytes.decode('utf-8').splitlines()
    header = lines[0].split('|')
    if len(header) != 4:
        raise ValueError('Unexpected manifest header; not selecting another key')
    seed = header[3] or 'XiaoBuDing'
    semantic_header = {'ResourceVersion': int(header[0]), 'ResourceVersionData': header[1],
                       'GFVersion': header[2], 'RandomSeed': header[3], 'IsEncrypAB': True,
                       'evidenceRva': '0x72ECFD8', 'manifestSha256': sha256(manifest_bytes)}
    write_json_atomic(OUT/'manifest-header-semantics.json', semantic_header)
    results = []
    with zipfile.ZipFile(apk_path) as apk:
        for line in lines[1:]:
            logical, stored, md5, size = line.split('|')
            if not logical.startswith('data/'):
                continue
            row = {'logicalName': logical, 'apkEntry': 'assets/Android/ljzs_lt/'+stored,
                   'keySource': 'PatchManifest.RandomSeed = header[3]; full native producer/consumer chain',
                   'key': seed, 'sourceManifestMd5': md5, 'sourceManifestSize': int(size)}
            try:
                raw = apk.read(row['apkEntry'])
                row.update(sourceBytes=len(raw), sourceSha256=sha256(raw))
                if len(raw) != int(size) or hashlib.md5(raw).hexdigest() != md5:
                    raise ValueError('Raw APK bytes differ from original manifest')
                plain = split_colors(raw, seed)
                if inverse_for_roundtrip(plain, seed) != raw:
                    raise ValueError('Full ciphertext roundtrip mismatch')
                env = UnityPy.load(plain)
                row.update(decodedBytes=len(plain), decodedSha256=sha256(plain), roundtripMatchesInput=True,
                           bundle=inspect_bundle(plain, env),
                           unityTypeCounts=dict(collections.Counter(o.type.name for o in env.objects)),
                           serializedFiles=[{'name': f.name, 'unityVersion': f.unity_version, 'objects': len(f.objects)} for f in env.assets])
                row['objects'] = []
                row['textAssets'] = []
                for obj in env.objects:
                    tree = obj.read_typetree(check_read=True)
                    obj_row = {'pathId': str(obj.path_id), 'type': obj.type.name, 'treeReadComplete': True}
                    if isinstance(tree, dict) and 'm_Name' in tree:
                        obj_row['name'] = tree['m_Name']
                    row['objects'].append(obj_row)
                    if obj.type.name != 'TextAsset':
                        continue
                    text_asset = obj.read(check_read=True)
                    content = text_asset.m_Script
                    if isinstance(content, str):
                        content = content.encode('utf-8', errors='surrogateescape')
                    safe = re.sub(r'[^A-Za-z0-9_.-]', '_', text_asset.m_Name)
                    target = OUT/'textassets'/f'{Path(stored).stem}-{obj.path_id}-{safe}.bytes'
                    target.parent.mkdir(exist_ok=True)
                    target.write_bytes(content)
                    row['textAssets'].append({'name': text_asset.m_Name, 'pathId': str(obj.path_id),
                                              'bytes': len(content), 'sha256': sha256(content), 'output': str(target)})
                target = OUT/stored
                target.write_bytes(plain)
                row.update(success=True, output=str(target), allObjectTypeTreesRead=True)
            except Exception as error:
                row.update(success=False, error=f'{type(error).__name__}: {error}')
            results.append(row)
    write_json_atomic(OUT/'data-bundles-decode-report.json', results)
    print(json.dumps([{k:r[k] for k in ('logicalName','sourceBytes','decodedBytes','decodedSha256','roundtripMatchesInput','unityTypeCounts','success') if k in r} | ({'error':r['error']} if 'error' in r else {}) for r in results], ensure_ascii=True, indent=2))
    if not results or not all(r['success'] for r in results):
        raise SystemExit(1)


if __name__ == '__main__':
    parser=argparse.ArgumentParser(description=__doc__)
    parser.add_argument('--apk',type=Path,help='Original APK to read; never modified')
    parser.add_argument('--out',type=Path,help='Derived output directory containing ABFiles.txt')
    args=parser.parse_args()
    main(args.apk,args.out)
