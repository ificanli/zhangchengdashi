"""Token-scoped structural review. No Unity/IDA and no production/evidence mutations."""
import argparse
import base64
import hashlib
import json
import re
from datetime import datetime, timezone
from pathlib import Path

ROOT = Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20")
WORK = ROOT / "work/stage51-config-keys"
PROJECT = ROOT / "outputs/OccupyCityRecovered"
SCOPE_PATH = ROOT / "work/parallel-coordination/stage41-getter-scope-review.json"
EXPECTED_SCOPE_SHA = "ed34cb16a650ee90b15a8af324075fbdea3b722a1e3d9b54c49a83156385f078"
BASELINE_PATH = WORK / "independent-source-baseline.json"
REPORT_PATH = WORK / "independent-scope-review.json"

def sha(data):
    return hashlib.sha256(data).hexdigest()

def load(path):
    return json.loads(path.read_text(encoding="utf-8-sig"))

def file_info(path):
    return {"path": str(path), "sha256": sha(path.read_bytes())}

def write(path, value):
    path.parent.mkdir(parents=True, exist_ok=True)
    path.write_text(json.dumps(value, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")

def getter_span(data, token):
    pattern = rb'\[Token\(Token = "' + token.encode() + rb'"\)\]\s*\[Address\((?P<address>[^\r\n]+)\)\]\s*get\s*\{(?P<body>[^}]+)\}'
    matches = list(re.finditer(pattern, data))
    assert len(matches) == 1, (token, len(matches))
    return matches[0]

FIXTURE_SUGGESTIONS = [
    {"name": "every-type-int32-boundaries", "scope": "all 38 row types", "values": [-2147483648, -1, 0, 1, 2147483647], "expectation": "Set the exact native-selected field by reflection. Each UniqueID is non-null System.Int32 and equals the field value."},
    {"name": "same-integer-boxed-key-equality", "scope": "all 38 row types", "expectation": "Two separate rows with the same selected int produce equal Dictionary<object,T> keys; ContainsKey detects the duplicate. Do not assert reference identity between boxes."},
    {"name": "boxed-type-separation", "scope": "all 38 row types", "expectation": "The key from integer 1 equals (object)1 but does not equal (object)1L, (object)1u, or string 1. This guards type-changing conversions."},
    {"name": "getter-rereads-field", "scope": "all 38 row types", "expectation": "Get key at A, mutate selected field to B, get again. Prior boxed key remains A; subsequent value is B. Existing dictionary entry at key A remains at A."},
    {"name": "nonkey-fields-do-not-select-key", "scope": "all 38 row types", "expectation": "When another int field exists, give it a distinct sentinel. Getter must select the field determined by native +0x10, including Level, Type, and arnenaLevel cases."},
    {"name": "real-payload-chain", "scope": "38 tables plus 3 objects", "expectation": "Consume the 927 real table rows, compare boxed key type and key value plus row identity, preserve three direct object reads. This remains adapter-only until Unity JsonUtility is exercised."},
]

def precheck():
    assert not BASELINE_PATH.exists(), "Baseline already exists; do not overwrite frozen independent evidence"
    scope = load(SCOPE_PATH)
    assert sha(SCOPE_PATH.read_bytes()) == EXPECTED_SCOPE_SHA
    assert scope["decision"] == "supported" and not scope["findings"]
    assert len(scope["minimalTargets"]) == 38
    rows = []
    for t in scope["minimalTargets"]:
        path = PROJECT / t["file"]
        meta = Path(str(path) + ".meta")
        data = path.read_bytes()
        assert sha(data) == t["source"]["sha256"]
        g = getter_span(data, t["token"])
        assert g["body"].strip() == b"return null;"
        meta_data = meta.read_bytes()
        guids = re.findall(rb"^guid: ([0-9a-fA-F]{32})\s*$", meta_data, re.M)
        assert len(guids) == 1
        rows.append({"type": t["type"], "file": t["file"], "source": file_info(path), "sourceBytesBase64": base64.b64encode(data).decode(), "meta": {**file_info(meta), "guid": guids[0].decode()}, "token": t["token"], "rva": t["native"]["rva"], "nativeEndRvaExclusive": t["native"]["endRvaExclusive"], "nativeCodeSha256": t["native"]["codeSha256"], "field": t["field"], "candidateBody": t["candidateBody"]})
    assert len({r["meta"]["guid"] for r in rows}) == 38
    baseline = {"stage": 51, "createdAt": datetime.now(timezone.utc).isoformat(), "scopeReport": file_info(SCOPE_PATH), "targets": rows, "exclusions": {"objects": scope["excludedObjects"], "extraResourceTables": scope["excludedExtraResourceTables"]}}
    write(BASELINE_PATH, baseline)
    report = {"stage": 51, "createdAt": datetime.now(timezone.utc).isoformat(), "decision": "pending_candidate_ready", "scope": "38 getter bodies only", "baseline": file_info(BASELINE_PATH), "priorNativeScope": file_info(SCOPE_PATH), "counts": {"targets": len(rows), "sourceHashMatches": len(rows), "metaFiles": len(rows), "uniqueMetaGuids": len({r["meta"]["guid"] for r in rows})}, "boxedInt32FixtureSuggestions": FIXTURE_SUGGESTIONS, "candidateRead": False, "constraints": {"productionEdited": False, "unityUsed": False, "idaUsed": False}}
    write(REPORT_PATH, report)
    print(json.dumps({"report": file_info(REPORT_PATH), "decision": report["decision"], "counts": report["counts"]}, ensure_ascii=False, indent=2))

def review():
    baseline = load(BASELINE_PATH)
    candidate_root = WORK / "candidate"
    expected_paths = {t["file"] for t in baseline["targets"]}
    all_candidate_files = [p for p in candidate_root.rglob("*") if p.is_file()]
    candidate_cs = {p.relative_to(candidate_root).as_posix() for p in all_candidate_files if p.suffix == ".cs"}
    findings = []
    if candidate_cs != expected_paths:
        findings.append({"candidateSourceSetMismatch": {"missing": sorted(expected_paths - candidate_cs), "extra": sorted(candidate_cs - expected_paths)}})
    non_cs_files = [str(p.relative_to(candidate_root)) for p in all_candidate_files if p.suffix != ".cs"]
    unexpected = [p for p in non_cs_files if not p.endswith(".cs.meta")]
    if unexpected:
        findings.append({"unexpectedCandidateFiles": unexpected})
    rows = []
    for t in baseline["targets"]:
        candidate = candidate_root / t["file"]
        original = base64.b64decode(t["sourceBytesBase64"])
        assert sha(original) == t["source"]["sha256"]
        data = candidate.read_bytes()
        before = getter_span(original, t["token"])
        after = getter_span(data, t["token"])
        # Restore only the exact getter's expression, preserving all other bytes.
        desired = t["candidateBody"].encode()
        assert after["body"].strip() == desired
        expression_matches = list(re.finditer(re.escape(desired), after["body"]))
        assert len(expression_matches) == 1
        exp = expression_matches[0]
        reverse_body = after["body"][:exp.start()] + b"return null;" + after["body"][exp.end():]
        inverse = data[:after.start("body")] + reverse_body + data[after.end("body"):]
        outside_before = original[:before.start("body")] + original[before.end("body"):]
        outside_after = data[:after.start("body")] + data[after.end("body"):]
        meta = Path(t["meta"]["path"])
        meta_data = meta.read_bytes()
        guid = re.findall(rb"^guid: ([0-9a-fA-F]{32})\s*$", meta_data, re.M)
        candidate_meta = Path(str(candidate) + ".meta")
        checks = {"onlyTokenGetterBodyDiffers": outside_before == outside_after, "exactReturnExpression": after["body"].strip() == desired, "inverseTokenBodyRestoresEntireOriginalBytes": inverse == original, "allTokenAttributesPreserved": re.findall(rb'\[Token\(Token = "([^"]+)"', original) == re.findall(rb'\[Token\(Token = "([^"]+)"', data), "allAddressAttributesPreserved": re.findall(rb'\[Address\(([^\r\n]+)\)\]', original) == re.findall(rb'\[Address\(([^\r\n]+)\)\]', data), "selectedGetterAddressPreserved": before["address"] == after["address"], "productionMetaHashUnchanged": sha(meta_data) == t["meta"]["sha256"], "productionGuidUnchanged": len(guid) == 1 and guid[0].decode() == t["meta"]["guid"], "candidateMetaAbsentOrByteIdentical": not candidate_meta.exists() or candidate_meta.read_bytes() == meta_data}
        if not all(checks.values()):
            findings.append({"type": t["type"], "failedChecks": [k for k, v in checks.items() if not v]})
        production = PROJECT / t["file"]
        production_hash = sha(production.read_bytes())
        rows.append({"type": t["type"], "file": t["file"], "token": t["token"], "rva": t["rva"], "nativeEndRvaExclusive": t["nativeEndRvaExclusive"], "nativeCodeSha256": t["nativeCodeSha256"], "field": t["field"], "candidateBody": t["candidateBody"], "baselineSourceSha256": sha(original), "candidate": file_info(candidate), "inverseSourceSha256": sha(inverse), "productionSourceSha256AtReview": production_hash, "productionState": "baseline" if production_hash == sha(original) else "candidate" if production_hash == sha(data) else "other", "meta": {**file_info(meta), "guid": guid[0].decode() if len(guid) == 1 else None}, "checks": checks})
    fixture_evidence = []
    for mode in ("before", "candidate", "actual"):
        result_path = WORK / "getter-fixture" / mode / "result.json"
        summary_path = WORK / "getter-fixture" / mode / "run-summary.json"
        if result_path.exists() and summary_path.exists():
            result = load(result_path)
            summary = load(summary_path)
            fixture_evidence.append({"mode": mode, "result": file_info(result_path), "runSummary": file_info(summary_path), "buildExitCode": summary["buildExitCode"], "harnessExitCode": summary["harnessExitCode"], "summary": {k: result[k] for k in ("passed", "expectedNegative", "observedExpectedNegative", "typeCount", "failedTypeCount", "failedTestCount", "totalTestCount", "nullGetterTypeCount")}})
    report = {"stage": 51, "createdAt": datetime.now(timezone.utc).isoformat(), "decision": "supported" if not findings else "findings_require_review", "scope": "Exactly 38 UniqueID.get method bodies; all other bytes, fields, JSON declarations, constructors, other methods, token/RVA attributes and production .meta/GUID are preserved", "baseline": file_info(BASELINE_PATH), "priorNativeScope": baseline["scopeReport"], "counts": {"targets": len(rows), "candidateCsFiles": len(candidate_cs), "exactInverseMatches": sum(r["checks"]["inverseTokenBodyRestoresEntireOriginalBytes"] for r in rows), "allOutsideBodyByteMatches": sum(r["checks"]["onlyTokenGetterBodyDiffers"] for r in rows), "metaHashAndGuidMatches": sum(r["checks"]["productionMetaHashUnchanged"] and r["checks"]["productionGuidUnchanged"] for r in rows)}, "targets": rows, "findings": findings, "candidateNonCsFiles": non_cs_files, "boxedInt32FixtureSuggestions": FIXTURE_SUGGESTIONS, "directGetterFixtureEvidence": fixture_evidence, "constraints": {"productionEdited": False, "existingEvidenceEdited": False, "unityUsed": False, "idaUsed": False}, "limitations": ["Structural byte audit and native evidence reuse plus direct managed getter fixtures. Root owns full config-chain compilation, hash-guarded production apply and runtime acceptance.", "Exact inverse match of the entire original file proves all non-getter content remains byte-identical; it is stronger than a declaration-only comparison."], "reviewScript": file_info(Path(__file__))}
    write(REPORT_PATH, report)
    print(json.dumps({"report": file_info(REPORT_PATH), "decision": report["decision"], "counts": report["counts"], "findings": findings}, ensure_ascii=False, indent=2))

parser = argparse.ArgumentParser()
parser.add_argument("mode", choices=["precheck", "review"])
args = parser.parse_args()
precheck() if args.mode == "precheck" else review()
