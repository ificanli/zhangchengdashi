from pathlib import Path
import json, subprocess, sys, concurrent.futures, collections
ROOT=Path(__file__).resolve().parents[2]
folder=Path(sys.argv[1]).resolve() if len(sys.argv)>1 else ROOT/'work/il-recovery/sample100-probe'
manifest=json.loads((folder/'sample-manifest.json').read_text(encoding='utf-8'))
verifier=ROOT/'work/il-recovery/sample-verify/bin/Release/net10.0/SampleVerify.dll'
references=ROOT/'work/il-recovery/release21-parser-probe'
def run(index):
    try:
        process=subprocess.run(['dotnet',str(verifier),str(folder),str(references),str(index)],capture_output=True,text=True,encoding='utf-8',errors='replace',timeout=25)
        lines=process.stdout.strip().splitlines()
        if lines and lines[-1].startswith('{'): return json.loads(lines[-1])
        return dict(index=index,method=manifest[index]['Method'],kind=manifest[index]['Kind'],status='failed',category='isolated-process-failure',error=process.stdout+process.stderr,exitCode=process.returncode)
    except subprocess.TimeoutExpired:
        return dict(index=index,method=manifest[index]['Method'],kind=manifest[index]['Kind'],status='failed',category='timeout')
with concurrent.futures.ThreadPoolExecutor(max_workers=4) as pool:
    results=list(pool.map(run,range(len(manifest))))
summary=dict(methods=len(results),statuses=dict(collections.Counter(x['status'] for x in results)),failureCategories=dict(collections.Counter(x.get('category',x['status']) for x in results if x['status'] not in ['passed','constant-only-not-counted'])),byKind={kind:dict(collections.Counter(x['status'] for x in results if x['kind']==kind)) for kind in sorted({x['kind'] for x in results})},results=results)
(folder/'sample-validation.json').write_text(json.dumps(summary,indent=2,ensure_ascii=False),encoding='utf-8')
print(json.dumps({k:v for k,v in summary.items() if k!='results'},indent=2,ensure_ascii=False))
