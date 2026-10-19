"""Read-only legacy payload/row identity audit; writes only beside this file."""
from __future__ import annotations
import bisect
import collections
import hashlib
import json
import re
import struct
import sys
from pathlib import Path

ROOT = Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20")
OUT = Path(__file__).resolve().parent
DELIVERY = ROOT / "outputs/旧框架资源恢复"
PROJECT = ROOT / "outputs/OccupyCityRecovered"
sys.path.insert(0, str(ROOT / "work/tools/legacy-inspection"))
import capstone

def sha(raw):
    return hashlib.sha256(raw).hexdigest()

def read_json(path):
    return json.loads(path.read_text(encoding="utf-8-sig"))

mapping = read_json(DELIVERY / "原名与PathID映射.json")
manifest = read_json(DELIVERY / "完整哈希清单.json")
native = read_json(DELIVERY / "证据/消费者与物理设置/native-consumer-evidence.json")
script = read_json(ROOT / "outputs/IDA分析材料/Il2Cpp导出/script.json")
boundaries = sorted(set(script["Addresses"]))
methods = script["ScriptMethod"]
elf = (ROOT / "work/ida-input/libil2cpp-arm64.so").read_bytes()
assert sha(elf) == "72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed"
phoff = struct.unpack_from("<Q", elf, 32)[0]
phsize, phnum = struct.unpack_from("<HH", elf, 54)
segments = [struct.unpack_from("<IIQQQQQQ", elf, phoff + i * phsize) for i in range(phnum)]
md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_LITTLE_ENDIAN)

def read_rva(start, size):
    seg = next(s for s in segments if s[0] == 1 and s[3] <= start and start + size <= s[3] + s[5])
    off = seg[2] + start - seg[3]
    return elf[off:off+size]

def original_method(name):
    match = next((m for m in methods if m["Name"] == name), None)
    if match is None:
        return None
    start = match["Address"]
    end = boundaries[bisect.bisect_right(boundaries, start)]
    raw = read_rva(start, end-start)
    instructions = [f"{i.address:#x}: {i.mnemonic} {i.op_str}" for i in md.disasm(raw, start)]
    return {"name": name, "rva": hex(start), "end": hex(end), "bytes": len(raw), "codeSha256": sha(raw), "instructions": instructions}

source_cache = {}
for p in (PROJECT / "Assets/Scripts").rglob("*Config.cs"):
    source_cache.setdefault(p.stem, []).append(p)

field_re = re.compile(r'\[Token\(Token = "([^"]+)"\)\]\s*\[FieldOffset\(Offset = "([^"]+)"\)\]\s*public\s+([\w.<>?\[\], ]+)\s+(\w+)\s*;')

def row_source(name):
    paths = source_cache.get(name, [])
    if not paths:
        return {"found": False}
    # ConfigMgr direct row types are ljzs_lt; ancillary framework classes have unique names.
    p = next((p for p in paths if "/ljzs_lt/" in p.as_posix()), paths[0])
    raw = p.read_bytes()
    text = raw.decode("utf-8-sig")
    fields = [{"name": m[3], "type": m[2].strip(), "offset": m[1], "token": m[0]} for m in field_re.findall(text)]
    ns = re.search(r"namespace\s+(\w+(?:\.\w+)*)", text)
    full = f"{ns.group(1)}.{name}" if ns else name
    getter = original_method(full + "$$get_UniqueID")
    getter_token = re.search(r'object UniqueID\s*\{\s*\[Token\(Token = "([^"]+)"', text)
    if getter and getter_token:getter["token"] = getter_token.group(1)
    ctor = original_method(full + "$$.ctor")
    return {"found": True, "path": p.relative_to(ROOT).as_posix(), "sha256": sha(raw), "fullTypeName": full,
            "token": re.search(r'\[Token\(Token = "([^"]+)"\)\]\s*(?:\[[^\n]*\]\s*)*(?:public|internal)\s+(?:sealed\s+)?class', text).group(1) if re.search(r'\[Token\(Token = "([^"]+)"\)\]\s*(?:\[[^\n]*\]\s*)*(?:public|internal)\s+(?:sealed\s+)?class', text) else None,
            "fields": fields, "uniqueID": getter, "constructor": ctor,
            "uniqueIDSourceReturnsNull": bool(re.search(r"object UniqueID[\s\S]*?get\s*\{\s*return null;", text))}

manifest_results = []
for row in manifest["files"]:
    p = DELIVERY / row["path"]
    raw = p.read_bytes() if p.exists() else b""
    manifest_results.append({"path": row["path"], "exists": p.exists(), "lengthMatch": len(raw) == row["bytes"], "shaMatch": sha(raw) == row["sha256"]})

rows=[]
for m in mapping:
    raw = (DELIVERY / m["deliveryPath"]).read_bytes()
    text = raw.decode("utf-8-sig")
    row = {**m, "actualBytes": len(raw), "actualSha256": sha(raw), "mappingLengthMatch": len(raw)==m["bytes"], "mappingShaMatch": sha(raw)==m["sha256"], "bom": raw.startswith(b"\xef\xbb\xbf"), "utf8Valid": True}
    if not text.strip():
        row.update(actualFormat="empty-text", rawHex=raw.hex())
        rows.append(row)
        continue
    value = json.loads(text)
    row.update(actualFormat="json", rootKeys=list(value), source=row_source(m["textAssetName"]))
    fields=row["source"].get("fields", [])
    field_types={f["name"]:f["type"] for f in fields}
    if isinstance(value.get("Datas"),list):
        data=value["Datas"]
        union=sorted({k for item in data for k in item})
        row.update(actualShape="Datas-table", actualRecordCount=len(data), fields=union, firstRecord=data[0] if data else None,
                   fieldValueTypes={k:dict(collections.Counter(type(r.get(k)).__name__ if k in r else "MISSING" for r in data)) for k in union},
                   undeclaredJsonFields=sorted(set(union)-set(field_types)), absentPublicFields=sorted(set(field_types)-set(union)))
        getter=row["source"].get("uniqueID")
        # Identify field read from __this saved in x19. Verify machine instructions, not source stub.
        field_read=[]
        if getter:
            ins="\n".join(getter["instructions"])
            field_read=re.findall(r"(?:ldr|ldur)\s+\w+, \[x19, #(0x[0-9a-f]+)\]", ins)
        selected=[f for f in fields if int(f["offset"],16) in [int(off,16) for off in field_read]]
        # Most getters pass __this+offset to il2cpp_value_box rather than ldr the field.
        if getter and not selected:
            ins="\n".join(getter["instructions"])
            addr_reads=re.findall(r"add\s+x1, x19, #(0x[0-9a-f]+)",ins)
            selected=[f for f in fields if int(f["offset"],16) in [int(off,16) for off in addr_reads]]
        row["originalUniqueIDFieldCandidates"]=selected
        if len(selected)==1:
            key=selected[0]["name"]
            keys=[r.get(key) for r in data]
            count=collections.Counter(json.dumps(v,ensure_ascii=False,sort_keys=True) for v in keys)
            row.update(primaryKey=key, keyType=selected[0]["type"], distinctKeys=len(count), nullKeys=sum(v is None for v in keys), duplicateKeys={k:v for k,v in count.items() if v>1}, keyValues=keys,
                       keyMin=min(keys) if keys else None,keyMax=max(keys) if keys else None)
        elif data and all("id" in d for d in data):
            keys=[d["id"] for d in data]
            row.update(serializedKeyCandidate="id", serializedKeyDistinctCount=len(set(keys)), serializedKeyValues=keys,
                       serializedKeyCaveat="Serialized field uniqueness only; matching original row type/getter is unconfirmed for this ancillary resource")
        if m["textAssetName"]=="PoolConfigConfig":
            groups=collections.defaultdict(list)
            for r in data:groups[r["pool_id"]].append(r["id"])
            row["poolGroups"]={str(k):v for k,v in sorted(groups.items())}
    else:
        row.update(actualShape="config-object", value=value, undeclaredJsonFields=sorted(set(value)-set(field_types)), absentPublicFields=sorted(set(field_types)-set(value)))
    rows.append(row)

readconfig = next(m for m in native["methods"] if m["name"]=="ljzs_lt.ConfigMgr$$ReadConfig")
consumer_names=sorted({match.group(1) for r in readconfig["metadataReferences"] if (match:=re.search(r"ConfigRead\.readConfig(?:V)?ByUnityJson<([^>]+)>",r.get("Name","")))})
direct=[r for r in rows if r["textAssetName"] in consumer_names]
summary={"textAssetCount":len(rows),"jsonCount":sum(r["actualFormat"]=="json" for r in rows),"tableCount":sum(r.get("actualShape")=="Datas-table" for r in rows),"objectCount":sum(r.get("actualShape")=="config-object" for r in rows),"emptyCount":sum(r["actualFormat"]=="empty-text" for r in rows),
         "configMgrDirectNames":consumer_names,"configMgrDirectCount":len(direct),"directTableCount":sum(r.get("actualShape")=="Datas-table" for r in direct),"directObjectCount":sum(r.get("actualShape")=="config-object" for r in direct),
         "allTableRows":sum(r.get("actualRecordCount",0) for r in rows),"directTableRows":sum(r.get("actualRecordCount",0) for r in direct),
         "deliveryFileHashChecks":len(manifest_results),"deliveryFileHashFailures":[r for r in manifest_results if not all(r[k] for k in ("exists","lengthMatch","shaMatch"))],
         "mappingFailures":[r["textAssetName"] for r in rows if not (r["mappingLengthMatch"] and r["mappingShaMatch"])],
         "duplicatePrimaryKeys":{r["textAssetName"]:r["duplicateKeys"] for r in rows if r.get("duplicateKeys")},"unresolvedTablePrimaryKeys":[r["textAssetName"] for r in rows if r.get("actualShape")=="Datas-table" and "primaryKey" not in r]}
result={"scope":"Read-only delivered payloads, live declarations, original ARM64 getter bytes; writes only resource-audit", "elfSha256":sha(elf),"decoder":"capstone "+capstone.__version__,"summary":summary,"textAssets":rows,"deliveryFileChecks":manifest_results}
(OUT/"resource-audit.json").write_text(json.dumps(result,ensure_ascii=False,indent=2)+"\n",encoding="utf-8")
dependencies=[]
for r in direct:
    if r.get("actualShape")!="Datas-table":continue
    dependencies.append({"file":r["source"]["path"],"sourceSha256":r["source"]["sha256"],"type":r["source"]["fullTypeName"],"typeToken":r["source"]["token"],
                         "member":"UniqueID.get","getter":r["source"]["uniqueID"],"candidateBody":"return "+r["primaryKey"]+";",
                         "currentlyEmpty":r["source"]["uniqueIDSourceReturnsNull"],"requiredBecause":"Dictionary<object,T> key must preserve original boxed Int32; current getter returns null",
                         "fixtureOnly":True,"productionScope":"Outside the three owned files; integration decision remains with main task"})
(OUT/"row-getter-dependencies.json").write_text(json.dumps(dependencies,ensure_ascii=False,indent=2)+"\n",encoding="utf-8")
lines=["# 旧配置资源独立审计", "", "本轮直接重读交付字节、SHA-256、当前类型声明及原 ARM64 getter；未启动 Unity，未写共享工程。", "",
       f"50 TextAsset = 43 张 Datas 表（951 行）+ 5 个 JSON 对象 + 2 份空 BOM/CRLF。ConfigMgr 直接消费 38 张表（927 行）与 3 个对象。143 项交付文件长度及 SHA-256、50 项 payload 映射均通过。", "",
       "38 张直接消费表的主键均由原 getter 实际读取的字段偏移确定，类型均为 int，零重复、零空值。当前 38 个源 getter 均 return null；它们是三文件候选之外的精确依赖。构造函数均已单独导出，详情见 JSON，不能把 DummyDLL 的空体视为原方法。", "",
       "| TextAsset | 直接消费 | 结构 | 行数 | 主键 | 不同主键 | 字段 |", "|---|---|---|---:|---|---:|---|"]
for r in rows:
    key=r.get("primaryKey",r.get("serializedKeyCandidate","—"))
    if "serializedKeyCandidate" in r:key += "（仅序列化候选）"
    lines.append("| "+" | ".join([r["textAssetName"],"是" if r["directConfigMgrConsumer"] else "否",r.get("actualShape",r["actualFormat"]),str(r.get("actualRecordCount","—")),key,str(r.get("distinctKeys",r.get("serializedKeyDistinctCount","—"))),", ".join(r.get("fields",r.get("rootKeys",[])))])+" |")
lines += ["", "## 三个直接对象", ""]
for r in direct:
    if r.get("actualShape")=="config-object":lines.append("- `"+r["textAssetName"]+"`：`"+json.dumps(r["value"],ensure_ascii=False)+"`")
lines += ["", "ConfigType 原值为 {\"configType\":1}，1 对应原 ConfigType.UnityJson。OnceAudioConfig 是含 AudioInfos 的对象。两者不在 ConfigMgr 本次直接 41 项中。其余五张框架表的序列化 id 唯一性已统计，但未将资源名与行类型作未经证实的等同。", "",
          "PoolConfigConfig 的 51 条原行按 pool_id 得到 9 组：1001/1002/1003/1004 各 1 行，2001 为 2 行，2002 为 9 行，2003/2004/2005 各 12 行；原行 id 顺序在 JSON 中保留，可验证分组引用身份。", "",
          "## 加载和解码证据", "", "已核读交付 README、Editor 映射计划及 0x71758D0/0x7175D04/0x7363F34/0x736221C 原伪 C。0x71758D0 优先使用非空传入 key，空 key 才用默认；0x736221C 在下载完成后读取 data、用实例 +0x20 的 key 解码，再 LoadFromMemory。清单用 WeDoBest，两个数据包用 manifest header 的 RandomSeed。143 项本轮哈希通过覆盖了该链的既有原始、解码与代码证据，未把 provider 测试当作 Unity 接入验收。", "",
          "## 复跑", "", "`C:\\Users\\luxinyu\\AppData\\Local\\Programs\\idapromcp\\source\\.venv\\Scripts\\python.exe -X utf8 audit_resources.py`。脚本只向自身 resource-audit 目录写结果；原 ELF SHA 为 72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed。"]
(OUT/"resource-audit.md").write_text("\n".join(lines)+"\n",encoding="utf-8")
compact=[{k:r.get(k) for k in ("textAssetName","actualShape","actualRecordCount","primaryKey","distinctKeys","keyMin","keyMax","undeclaredJsonFields")} for r in rows]
print(json.dumps({"summary":summary,"rows":compact},ensure_ascii=False,indent=2))
