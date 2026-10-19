"""Generate isolated projects that compile the actual owned sources unchanged.
The fixture mode replaces only 38 native-proven row getters in test-local copies.
No Unity process or production files are touched.
"""
from pathlib import Path
import argparse, hashlib, json, re
from xml.sax.saxutils import escape

ROOT=Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20")
BASE=Path(__file__).resolve().parent
WORK=BASE.parent
PROJECT=ROOT/"outputs/OccupyCityRecovered"
OWNED=["Assets/Scripts/Assembly-CSharp/ljzs_lt/ConfigMgr.cs", "Assets/Scripts/GFRunning/GameFramework/ConfigRead.cs", "Assets/Scripts/GFRunning/GameFramework/BaseConfig.cs"]
parser=argparse.ArgumentParser()
parser.add_argument("--mode",choices=["baseline","candidate-current-getters","candidate-fixture-getters"],required=True)
parser.add_argument("--candidate-root",type=Path,default=WORK/"candidate")
args=parser.parse_args()
audit=json.loads((WORK/"evidence/resource-audit/resource-audit.json").read_text(encoding="utf-8"))
rows=[r for r in audit["textAssets"] if r["directConfigMgrConsumer"]]
out=BASE/"generated"/args.mode
out.mkdir(parents=True,exist_ok=True)
owned_root=WORK/"source-before" if args.mode=="baseline" else args.candidate_root
includes=[]; provenance=[]
def include(p,role):
    if not p.exists():raise FileNotFoundError(p)
    includes.append(p)
    provenance.append({"path":str(p),"role":role,"sha256":hashlib.sha256(p.read_bytes()).hexdigest()})
for rel in OWNED:include(owned_root/rel,"owned-unchanged")
for row in rows:
    source=ROOT/row["source"]["path"]
    if args.mode=="candidate-fixture-getters" and row.get("actualShape")=="Datas-table":
        text=source.read_text(encoding="utf-8-sig")
        pattern=r"(public override object UniqueID\s*\{[\s\S]*?get\s*\{)\s*return null;"
        text,n=re.subn(pattern,lambda m:m.group(1)+"\n                return "+row["primaryKey"]+";",text,count=1)
        if n!=1:raise RuntimeError("Fixture getter source no longer matches: "+str(source))
        target=out/"fixture-rows"/source.name
        target.parent.mkdir(exist_ok=True)
        target.write_text(text,encoding="utf-8")
        include(target,"test-fixture-row-getter-only")
        provenance[-1].update(originalPath=str(source),originalSha256=hashlib.sha256(source.read_bytes()).hexdigest(),getterRva=row["source"]["uniqueID"]["rva"],field=row["primaryKey"])
    else:include(source,"live-row-unchanged")
include(PROJECT/"Assets/Scripts/GFRunning/GameFramework/ConfigType.cs","live-enum-unchanged")
include(PROJECT/"Assets/Scripts/GFRunning/GameFramework/UnSerialization.cs","live-wrapper-unchanged")
include(BASE/"BoundaryAdapters.cs","controlled-boundary")
include(BASE/"Program.cs","test-driver-no-business-copy")
items="\n".join('    <Compile Include="'+escape(str(p),{'"':'&quot;'})+'" />' for p in includes)
project='''<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><EnableDefaultCompileItems>false</EnableDefaultCompileItems><ImplicitUsings>enable</ImplicitUsings><Nullable>disable</Nullable><NoWarn>CS8981;CS0169;CS0649;CS0168;CS0067;CS8632</NoWarn></PropertyGroup>
  <ItemGroup>
'''+items+"\n  </ItemGroup>\n</Project>\n"
(out/"ConfigChainHarness.csproj").write_text(project,encoding="utf-8")
mgr_text=(owned_root/OWNED[0]).read_text(encoding="utf-8-sig")
dict_fields={typ:field for typ,field in re.findall(r"Dictionary<object,\s*(\w+)>\s+(\w+)",mgr_text)}
object_fields={typ:field for typ,field in re.findall(r"public\s+(\w+Config)\s+(\w+)\s*;",mgr_text)}
# ConfigConfig suffixes still end in Config, so this catches all three real objects.
expected=[]
for row in rows:
    expected.append({"type":row["textAssetName"],"shape":row["actualShape"],"field":dict_fields[row["textAssetName"]] if row["actualShape"]=="Datas-table" else object_fields[row["textAssetName"]],
                     "path":str(ROOT/"outputs/旧框架资源恢复"/row["deliveryPath"]),"sha256":row["actualSha256"],"count":row.get("actualRecordCount"),"key":row.get("primaryKey")})
(out/"expected.json").write_text(json.dumps(expected,ensure_ascii=False,indent=2),encoding="utf-8")
(out/"provenance.json").write_text(json.dumps({"mode":args.mode,"scope":"Compile actual owned source bodies; row fixtures only where explicitly marked; adapters are external boundaries", "files":provenance},ensure_ascii=False,indent=2),encoding="utf-8")
print(json.dumps({"mode":args.mode,"project":str(out/"ConfigChainHarness.csproj"),"expected":str(out/"expected.json"),"compileIncludes":len(includes),"fixtureRows":sum(p["role"]=="test-fixture-row-getter-only" for p in provenance)},ensure_ascii=False,indent=2))
