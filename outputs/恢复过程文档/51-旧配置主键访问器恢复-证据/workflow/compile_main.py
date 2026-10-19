from pathlib import Path
import argparse,hashlib,json,re,subprocess
R=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');W=R/'work/stage51-config-keys';P=R/'outputs/OccupyCityRecovered'
def sha(p):return hashlib.sha256(Path(p).read_bytes()).hexdigest()
def compile_main(mode):
    out=W/'compile'/mode;out.mkdir(parents=True,exist_ok=True)
    plan=json.loads((W/'write-plan.json').read_text(encoding='utf-8-sig'));owned={x['path']:x for x in plan['files']}
    original=P/'Library/Bee/artifacts/1900b0aEDbg.dag/Assembly-CSharp.rsp';lines=original.read_text(encoding='utf-8-sig').splitlines();modified=[];replacements=[];inputs={}
    def actualpath(value):
        p=Path(value.strip('"'));return p if p.is_absolute() else P/p
    for line in lines:
        norm=line.strip('"').replace('\\','/')
        if re.match(r'^[-/]out:',line):line='-out:"'+str(out/'Assembly-CSharp.dll')+'"'
        elif re.match(r'^[-/]refout:',line):line='-refout:"'+str(out/'Assembly-CSharp.ref.dll')+'"'
        elif re.match(r'^[-/]generatedfilesout:',line):continue
        elif norm in owned and mode=='candidate':
            line='"'+str(W/'candidate'/norm)+'"';replacements.append(norm)
        modified.append(line)
        if not line.startswith(('-','/')) and line.strip('"').endswith('.cs'):
            p=actualpath(line);assert p.exists(),str(p);inputs[str(p)]=sha(p)
        elif re.match(r'^[-/]r:',line):
            p=actualpath(re.sub(r'^[-/]r:','',line));assert p.exists(),str(p);inputs[str(p)]=sha(p)
    if mode=='candidate':assert set(replacements)==set(owned) and len(replacements)==38
    else:assert not replacements
    gen=out/'generated';(gen/'JobEntityGenerator/Unity.Entities.SourceGen.JobEntityGenerator.JobEntityGenerator').mkdir(parents=True,exist_ok=True)
    modified.append('-generatedfilesout:"'+str(gen)+'"')
    rsp=out/'Assembly-CSharp.rsp';rsp.write_text('\n'.join(modified)+'\n',encoding='utf-8')
    (out/'inputs-before.json').write_text(json.dumps(inputs,ensure_ascii=False,indent=2),encoding='utf-8')
    compiler=Path(r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll')
    host=Path(r'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe')
    args=[str(host),str(compiler),'@'+str(rsp)];p=subprocess.run(args,cwd=P,text=True,encoding='utf-8',errors='replace',capture_output=True)
    log=out/'compile.log';log.write_text(p.stdout+p.stderr,encoding='utf-8');errors=sorted({x for x in (p.stdout+p.stderr).splitlines() if re.search(r'(?:^|: )error [A-Z]+\d+:',x)})
    after={k:sha(k) for k in inputs};changed=[k for k in inputs if inputs[k]!=after[k]]
    (out/'inputs-after.json').write_text(json.dumps(after,ensure_ascii=False,indent=2),encoding='utf-8')
    report={'mode':mode,'assembly':'Assembly-CSharp','exitCode':p.returncode,'errorCount':len(errors),'errors':errors,'fullOfficialRspCompile':True,'candidateSourceSubstitutionCount':len(replacements),'candidateSources':replacements,'sourceRsp':str(original),'sourceRspSha256':sha(original),'copiedRsp':str(rsp),'copiedRspSha256':sha(rsp),'compiler':str(compiler),'compilerSha256':sha(compiler),'host':str(host),'sourceAndReferenceInputCount':len(inputs),'inputsStable':not changed,'changedInputs':changed,'output':str(out/'Assembly-CSharp.dll'),'outputSha256':sha(out/'Assembly-CSharp.dll') if (out/'Assembly-CSharp.dll').exists() else None,'log':str(log),'unityStarted':False,'productionWrites':0}
    (out/'result.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps({k:report[k] for k in ['mode','exitCode','errorCount','candidateSourceSubstitutionCount','sourceAndReferenceInputCount','inputsStable','changedInputs','log']},ensure_ascii=False),flush=True)
    assert p.returncode==0 and not errors and not changed,report
if __name__=='__main__':
    ap=argparse.ArgumentParser();ap.add_argument('mode',choices=['candidate','actual']);a=ap.parse_args();compile_main(a.mode)
