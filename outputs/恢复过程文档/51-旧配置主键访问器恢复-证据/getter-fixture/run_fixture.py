"""Compile actual 38 source files and exercise original/candidate getter bodies unchanged."""
import argparse
import hashlib
import json
import subprocess
import sys
from pathlib import Path
from xml.sax.saxutils import escape

ROOT = Path(r"C:\Users\luxinyu\Documents\Codex\2026-10-19\x20")
WORK = ROOT / "work/stage51-config-keys"
FIXTURE = Path(__file__).resolve().parent
PROJECT = ROOT / "outputs/OccupyCityRecovered"
BASELINE = WORK / "independent-source-baseline.json"

def sha(path):
    return hashlib.sha256(path.read_bytes()).hexdigest()

parser = argparse.ArgumentParser()
parser.add_argument("mode", choices=["before", "candidate", "actual"])
args = parser.parse_args()
source_root = WORK / "source-before" if args.mode == "before" else WORK / "candidate" if args.mode == "candidate" else PROJECT
baseline = json.loads(BASELINE.read_text(encoding="utf-8"))
out = FIXTURE / args.mode
out.mkdir(parents=True, exist_ok=True)
includes = []
provenance = []
expected = []
for t in baseline["targets"]:
    source = source_root / t["file"]
    if not source.exists():
        raise FileNotFoundError(source)
    if args.mode == "before":
        assert sha(source) == t["source"]["sha256"]
    includes.append(source)
    provenance.append({"path": str(source), "sha256": sha(source), "role": "actual-row-source-direct-include", "token": t["token"], "rva": t["rva"], "field": t["field"]})
    expected.append({"type": t["type"], "field": t["field"]["name"], "token": t["token"], "rva": t["rva"]})
for path, role in [(ROOT / "work/parallel-41-config/candidate/Assets/Scripts/GFRunning/GameFramework/BaseConfig.cs", "stage41-actual-baseconfig-candidate"), (ROOT / "work/parallel-41-config/tests/BoundaryAdapters.cs", "shared-external-boundary-declarations"), (FIXTURE / "Program.cs", "fixture-driver-no-getter-business-copy")]:
    includes.append(path)
    provenance.append({"path": str(path), "sha256": sha(path), "role": role})
project = out / "GetterBoundaryFixture.csproj"
items = "\n".join('    <Compile Include="' + escape(str(p), {'"': '&quot;'}) + '" />' for p in includes)
project.write_text('''<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <ImplicitUsings>enable</ImplicitUsings><Nullable>disable</Nullable>
    <NoWarn>CS8632;CS0067</NoWarn>
  </PropertyGroup>
  <ItemGroup>
''' + items + "\n  </ItemGroup>\n</Project>\n", encoding="utf-8")
expected_path = out / "expected.json"
expected_path.write_text(json.dumps(expected, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
provenance_path = out / "provenance.json"
provenance_path.write_text(json.dumps({"mode": args.mode, "baselineSha256": sha(BASELINE), "sourceRoot": str(source_root), "files": provenance}, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
build_cmd = ["dotnet", "build", str(project), "-c", "Release", "--nologo", "--verbosity", "quiet"]
build = subprocess.run(build_cmd, text=True, capture_output=True, encoding="utf-8", errors="replace")
(out / "build.log").write_text(build.stdout + build.stderr, encoding="utf-8")
if build.returncode != 0:
    print(build.stdout + build.stderr)
    print(json.dumps({"mode": args.mode, "buildExitCode": build.returncode, "result": "build_failed"}))
    sys.exit(build.returncode)
result_path = out / "result.json"
run_cmd = ["dotnet", str(out / "bin/Release/net10.0/GetterBoundaryFixture.dll"), args.mode, str(expected_path), str(result_path)]
run = subprocess.run(run_cmd, text=True, capture_output=True, encoding="utf-8", errors="replace")
(out / "run.log").write_text(run.stdout + run.stderr, encoding="utf-8")
result = json.loads(result_path.read_text(encoding="utf-8-sig")) if result_path.exists() else None
run_summary = {"mode": args.mode, "buildCommand": build_cmd, "buildExitCode": build.returncode, "runCommand": run_cmd, "harnessExitCode": run.returncode, "expectedNegative": args.mode == "before", "resultPath": str(result_path), "resultSha256": sha(result_path) if result_path.exists() else None, "provenancePath": str(provenance_path), "provenanceSha256": sha(provenance_path), "actualSummary": {k: result[k] for k in ("passed", "expectedNegative", "observedExpectedNegative", "typeCount", "failedTypeCount", "failedTestCount", "totalTestCount", "nullGetterTypeCount")} if result else None}
(out / "run-summary.json").write_text(json.dumps(run_summary, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")
print(json.dumps(run_summary, ensure_ascii=False, indent=2))
if run.stderr:
    print(run.stderr)
# Preserve a failing process for before: expected-negative is evidence, never a fake success.
sys.exit(run.returncode)
