"""Archive reviewable GameManager recovery evidence without experiment binaries."""
import hashlib
import json
import shutil
import sys
from pathlib import Path


ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / "work/gamemanager-recovery"
DEST = ROOT / "outputs/恢复过程文档/证据/GameManager初始化"
PRODUCTION = ROOT / "outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/GameManager.cs"
BEFORE = ROOT / "work/recovery-stubs/gamemanager-before/GameManager.cs"


def digest(path):
    return hashlib.sha256(path.read_bytes()).hexdigest()


actual = '--actual' in sys.argv
audit = json.loads((OWN / ("final-audit.json" if actual else "candidate-audit.json")).read_text(encoding="utf-8"))
assert audit["status"] == ("actual-source-written" if actual else "candidate-ready-production-source-unchanged")
assert digest(PRODUCTION) == audit["productionSourceSha256"]
assert digest(PRODUCTION) == (digest(OWN / "GameManager.candidate.cs") if actual else digest(BEFORE))
assert digest(PRODUCTION.with_suffix(".cs.meta")) == audit["metaSha256"]
assert digest(OWN / "GameManager.candidate.cs") == audit["candidateSha256"]

files = {}
for path in OWN.iterdir():
    if path.is_file():
        files[path] = Path("candidate") / path.name
for subdir in ["compile", "tests", "metadata", "ida"]:
    for path in (OWN / subdir).rglob("*"):
        if not path.is_file():
            continue
        relative = path.relative_to(OWN / subdir)
        if any(part in {"bin", "obj", "__pycache__"} for part in relative.parts):
            continue
        if path.suffix.lower() in {".dll", ".exe", ".pdb", ".i64", ".idb", ".pid"}:
            continue
        files[path] = Path(subdir) / relative
files[BEFORE] = Path("source-before/GameManager.cs")
files[BEFORE.with_suffix(".cs.meta")] = Path("source-before/GameManager.cs.meta")
if actual:
    files[PRODUCTION] = Path("source-after/GameManager.cs")
    files[PRODUCTION.with_suffix(".cs.meta")] = Path("source-after/GameManager.cs.meta")
files[ROOT / "outputs/恢复过程文档/29-GameManager原始初始化恢复.md"] = Path("29-GameManager原始初始化恢复.md")

manifest = []
for source, relative in sorted(files.items(), key=lambda item: str(item[1])):
    destination = DEST / relative
    destination.parent.mkdir(parents=True, exist_ok=True)
    shutil.copy2(source, destination)
    assert digest(source) == digest(destination)
    manifest.append({"path": relative.as_posix(), "bytes": destination.stat().st_size, "sha256": digest(destination)})

result = {
    "stage": 29,
    "status": audit["status"],
    "productionSourceUnchanged": not actual,
    "candidateSha256": audit["candidateSha256"],
    "productionSourceSha256": digest(PRODUCTION),
    "metaSha256": audit["metaSha256"],
    "files": manifest,
    "fileCount": len(manifest),
    "totalBytes": sum(item["bytes"] for item in manifest),
    "excluded": ["temporary IDA database", "compiled DLL/EXE/PDB", "bin/obj caches"],
}
(DEST / "archive-manifest.json").write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding="utf-8")
print(json.dumps({key: value for key, value in result.items() if key != "files"}, ensure_ascii=False, indent=2))
