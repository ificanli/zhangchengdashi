import hashlib,json,re,subprocess,time
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent;P=ROOT/'outputs/OccupyCityRecovered'
out=W/'compile';out.mkdir(exist_ok=True)
lines=(P/'Library/Bee/artifacts/1900b0aEDbg.dag/Assembly-CSharp.rsp').read_text(encoding='utf-8-sig').splitlines()
replaced=[];new=[]
for line in lines:
    path=line.strip('"').replace('\\','/')
    if line.startswith('-out:'):line=f'-out:"{out.as_posix()}/Assembly-CSharp.dll"'
    elif line.startswith('-refout:'):line=f'-refout:"{out.as_posix()}/Assembly-CSharp.ref.dll"'
    elif (W/'candidate'/path).is_file():
        replaced.append(path);line='"'+(W/'candidate'/path).as_posix()+'"'
    new.append(line)
assert len(replaced)==4,replaced
rsp=out/'candidate.rsp';rsp.write_text('\n'.join(new),encoding='utf-8')
cmd=[r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe',r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll','/nologo','/shared', '@'+str(rsp)]
started=time.monotonic()
with (out/'candidate.log').open('w',encoding='utf-8') as log:result=subprocess.run(cmd,cwd=P,stdout=log,stderr=subprocess.STDOUT)
text=(out/'candidate.log').read_text(encoding='utf-8-sig')
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
summary=dict(command=cmd,cwd=str(P),exit_code=result.returncode,elapsed_seconds=time.monotonic()-started,candidate_sources=replaced,candidate_sha256={p:sha(W/'candidate'/p) for p in replaced},original_rsp_sha256=sha(P/'Library/Bee/artifacts/1900b0aEDbg.dag/Assembly-CSharp.rsp'),candidate_rsp_sha256=sha(rsp),errors=re.findall(r'^.*error [A-Z]+\d+.*$',text,re.M),warning_count=len(re.findall(r'warning [A-Z]+\d+',text)),dll_exists=(out/'Assembly-CSharp.dll').is_file(),dll_sha256=sha(out/'Assembly-CSharp.dll') if (out/'Assembly-CSharp.dll').is_file() else None)
(out/'result.json').write_text(json.dumps(summary,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(summary,ensure_ascii=False,indent=2));raise SystemExit(result.returncode)
