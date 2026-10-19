import hashlib,json,re,subprocess,time
from pathlib import Path
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');WORK=ROOT/'work/parallel-44-battle';PROJECT=ROOT/'outputs/OccupyCityRecovered'
out=WORK/'scene-validation/compile-next';out.mkdir(exist_ok=True)
lines=(PROJECT/'Library/Bee/artifacts/1900b0aEDbg.dag/Assembly-CSharp.rsp').read_text(encoding='utf-8-sig').splitlines();new=[];replaced=[];sources=[]
for line in lines:
 path=line.strip('"').replace('\\','/');next_source=WORK/'candidate-next'/path;stable=WORK/'candidate'/path
 if line.startswith('-out:'):line=f'-out:"{out.as_posix()}/Assembly-CSharp.dll"'
 elif line.startswith('-refout:'):line=f'-refout:"{out.as_posix()}/Assembly-CSharp.ref.dll"'
 elif next_source.is_file()or stable.is_file():
  candidate=next_source if next_source.is_file() else stable
  line='"'+candidate.as_posix()+'"';replaced.append(path);sources.append(candidate)
 new.append(line)
assert len(replaced)==4,replaced
rsp=out/'candidate-next.rsp';rsp.write_text('\n'.join(new),encoding='utf-8')
command=[r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe',r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll','/nologo','/shared','@'+str(rsp)]
started=time.monotonic()
with (out/'candidate-next.log').open('w',encoding='utf-8')as log: result=subprocess.run(command,cwd=PROJECT,stdout=log,stderr=subprocess.STDOUT)
text=(out/'candidate-next.log').read_text(encoding='utf-8-sig');sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
summary=dict(command=command,cwd=str(PROJECT),exit_code=result.returncode,elapsed_seconds=time.monotonic()-started,candidate_sources={str(p):sha(p)for p in sources},errors=re.findall(r'^.*error [A-Z]+\d+.*$',text,re.M),warning_count=len(re.findall(r'warning [A-Z]+\d+',text)),rsp_sha256=sha(rsp),dll_sha256=sha(out/'Assembly-CSharp.dll')if(out/'Assembly-CSharp.dll').is_file()else None)
(out/'result.json').write_text(json.dumps(summary,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(summary,ensure_ascii=False,indent=2));raise SystemExit(result.returncode)
