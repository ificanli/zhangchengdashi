from pathlib import Path
import re,json
r=Path.cwd();w=r/'work/stage49-model-defaults';src=(r/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/DataModule/SeasonData.cs').read_text(encoding='utf-8-sig');fields=[]
for m in re.finditer(r'\[Token\(Token = "(0x[0-9A-F]+)"\)\]\s*\[FieldOffset\(Offset = "(0x[0-9A-F]+)"\)\]\s*(?:\[JsonProperty\("([^"]+)"\)\]\s*)?public ([^;\n]+?) (\w+);',src):
 fields.append(dict(Name=m[5],type=m[4],IsStatic=False,IsPrivate=False,token=m[1],offset=m[2],jsonName=m[3]))
assert len(fields)==8,len(fields)
(w/'child-metadata.json').write_text(json.dumps(dict(dataType='DataModule.SeasonData',fields=fields,source='Assets/Scripts/Assembly-CSharp/DataModule/SeasonData.cs'),ensure_ascii=False,indent=2),encoding='utf-8')
