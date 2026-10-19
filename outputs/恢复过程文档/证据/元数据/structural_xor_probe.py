"""Validate one deterministic XOR key from standard-header constraints.
Original metadata is read from APK and never modified.
"""
import collections, hashlib, json, pathlib, struct, zipfile

base=pathlib.Path(__file__).resolve().parent
with zipfile.ZipFile(base.parent/'apk-intake'/'zhancheng-dashi-1.04.apk') as z:
    raw=z.read('assets/bin/Data/Managed/Metadata/global-metadata.dat')
key=bytes.fromhex('64627478696a6b00')
decoded=raw[:8]+bytes(v^key[i%8] for i,v in enumerate(raw[8:]))
names=['stringLiterals','stringLiteralData','strings','events','properties','methods','parameterDefaultValues','fieldDefaultValues','fieldAndParameterDefaultValueData','fieldMarshaledSizes','parameters','fields','genericParameters','genericParameterConstraints','genericContainers','nestedTypes','interfaces','vtableMethods','interfaceOffsets','typeDefinitions','images','assemblies','fieldRefs','referencedAssemblies','attributeData','attributeDataRanges','unresolvedIndirectCallParameterTypes','unresolvedIndirectCallParameterRanges','windowsRuntimeTypeNames','windowsRuntimeStrings','exportedTypeDefinitions']
pairs=[]
for i,name in enumerate(names):
    at=8+i*8
    off,size=struct.unpack_from('<II',decoded,at)
    pairs.append({'name':name,'header_byte':at,'offset':off,'size':size,'in_bounds':off<=len(raw) and size<=len(raw)-off,'offset_aligned4':off%4==0,'contiguous_with_next':None})
for p,q in zip(pairs,pairs[1:]):p['contiguous_with_next']=p['offset']+p['size']==q['offset']
pool=decoded[pairs[2]['offset']:pairs[2]['offset']+pairs[2]['size']]
def get_string(index):
    if not 0<=index<len(pool):return None
    end=pool.find(b'\0',index)
    if end<0:return None
    try:return pool[index:end].decode('utf-8')
    except UnicodeDecodeError:return None

type_info=pairs[19]
image_info=pairs[20]
types=[]
for at in range(type_info['offset'],type_info['offset']+type_info['size'],88):
    rec=struct.unpack_from('<16i8H2I',decoded,at)
    types.append({'name':get_string(rec[0]),'namespace':get_string(rec[1]),'token':hex(rec[-1]),'methodStart':rec[9],'methodCount':rec[16]})
images=[]
for at in range(image_info['offset'],image_info['offset']+image_info['size'],40):
    rec=struct.unpack_from('<10i',decoded,at)
    images.append({'name':get_string(rec[0]),'assemblyIndex':rec[1],'typeStart':rec[2],'typeCount':rec[3],'exportedTypeStart':rec[4],'exportedTypeCount':rec[5],'entryPointIndex':rec[6],'token':hex(rec[7]),'customAttributeStart':rec[8],'customAttributeCount':rec[9],'typeRangeInBounds':0<=rec[2]<=len(types) and 0<=rec[3]<=len(types)-rec[2]})
strings=[b'Assembly-CSharp.dll',b'mscorlib.dll',b'UnityEngine.CoreModule.dll',b'UnityEngine',b'GameObject']
result={'candidate_count_this_probe':1,'total_candidates_tested_across_bounded_probes':2,'key_hex':key.hex(),'key_derivation':'Column modes from first bounded probe; resolve FF/00 ambiguity using first table offset=0x100, table alignment and continuity; no key enumeration','header_pairs':pairs,'header_in_bounds_count':sum(p['in_bounds'] for p in pairs),'header_aligned4_count':sum(p['offset_aligned4'] for p in pairs),'contiguous_pairs_count':sum(p['contiguous_with_next'] is True for p in pairs),'last_section_end':pairs[-1]['offset']+pairs[-1]['size'],'file_size':len(decoded),'string_offsets':{n.decode():decoded.find(n) for n in strings},'type_record_size':88,'type_table_size_multiple':type_info['size']%88==0,'type_count':len(types),'type_valid_name_count':sum(t['name'] is not None and t['namespace'] is not None for t in types),'type_token_prefix_counts':dict(collections.Counter(t['token'][:3] for t in types)),'image_record_size':40,'image_table_size_multiple':image_info['size']%40==0,'image_count':len(images),'image_valid_name_count':sum(i['name'] is not None for i in images),'image_type_ranges_in_bounds':sum(i['typeRangeInBounds'] for i in images),'images':images,'type_samples':types[:12],'decoded_sha256':hashlib.sha256(decoded).hexdigest()}
game_image=next((i for i in images if i['name']=='Assembly-CSharp.dll'),None)
if game_image:
    game_types=types[game_image['typeStart']:game_image['typeStart']+game_image['typeCount']]
    result['assembly_csharp_image']=game_image
    result['assembly_csharp_type_samples']=game_types[:20]
checks=[result['header_in_bounds_count']==31,result['header_aligned4_count']==31,result['contiguous_pairs_count']==30,result['last_section_end']==len(decoded),result['type_table_size_multiple'],result['image_table_size_multiple'],result['type_valid_name_count']==len(types),result['image_valid_name_count']==len(images),result['image_type_ranges_in_bounds']==len(images),all(decoded.find(n)>=0 for n in strings),game_image is not None]
result['structural_validation_pass']=all(checks)
if all(checks):
    path=base/'global-metadata.decoded.dat'
    path.write_bytes(decoded)
    result['decoded_path']=str(path)
else:result['decoded_path']=None
(base/'structural-xor-report.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k not in ['images','header_pairs']},ensure_ascii=False,indent=2))
if not all(checks):print('HEADER_PAIRS',json.dumps(pairs,indent=2))
