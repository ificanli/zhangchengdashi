import json,subprocess,sys
from pathlib import Path
W=Path(__file__).resolve().parent;ROOT=W.parents[1];O=W/'manager-validation'
def call(cmd,log,expected):
 p=subprocess.run(cmd,cwd=ROOT,capture_output=True,text=True,encoding='utf-8');(O/log).write_text(p.stdout+p.stderr,encoding='utf-8')
 assert p.returncode==expected,(cmd,p.returncode,p.stdout,p.stderr)
 return dict(command=cmd,exit_code=p.returncode,log=str(O/log),summary=p.stdout.strip().splitlines()[-1])
py=[sys.executable,'-X','utf8']
call(py+[str(W/'make_manager_fixture.py'),'--baseline'],'baseline-extract.log',0)
baseline=call(['dotnet','run','--project',str(O/'ManagerTests.csproj'),'-c','Release','--',str(O/'native-oracle.json'),'baseline'],'baseline-tests.log',1)
call(py+[str(W/'make_manager_fixture.py')],'candidate-extract.log',0)
candidate=call(['dotnet','run','--project',str(O/'ManagerTests.csproj'),'-c','Release','--',str(O/'native-oracle.json')],'candidate-tests.log',0)
(O/'result.json').write_text(json.dumps(dict(candidate=candidate,baseline=baseline),ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(dict(candidate=candidate['summary'],baseline=baseline['summary']),ensure_ascii=False))
