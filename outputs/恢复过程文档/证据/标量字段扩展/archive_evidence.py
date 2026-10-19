import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/scalar-expansion';out=root/'outputs/恢复过程文档/证据/标量字段扩展';out.mkdir(parents=True,exist_ok=True)
def copy(path,dest):
    dest.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(path,dest)
for p in own.iterdir():
    if p.is_file() and p.suffix in {'.json','.log','.py'}:copy(p,out/p.name)
for directory in ['audit','writer','preflight','readback']:
    for p in (own/directory).iterdir():
        if p.is_file() and p.suffix in {'.cs','.csproj','.json','.log'}:copy(p,out/directory/p.name)
audit=json.loads((own/'final-audit.json').read_text(encoding='utf-8'))
for file in audit['sourceFilesDetail']:
    relative=Path(file['path']);before=root/'work/recovery-stubs/scalar-expansion-before'/relative;after=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'/relative
    copy(before,out/'source-before'/relative);copy(before.with_suffix('.cs.meta'),out/'source-before'/relative.with_suffix('.cs.meta'))
    copy(after,out/'source-after'/relative)
print('Archived',len(audit['sourceFilesDetail']),'before and after source files with preserved meta')
