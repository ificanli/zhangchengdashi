import shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/stringtool-recovery';out=root/'outputs/恢复过程文档/证据/字符串基础转换';out.mkdir(parents=True,exist_ok=True)
def copy(p,d):d.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(p,d)
for p in own.iterdir():
    if p.is_file() and p.suffix in {'.json','.py','.patch','.cs','.log'}:copy(p,out/p.name)
for folder in ['compile','tests','metadata']:
    for p in (own/folder).iterdir():
        if p.is_file() and p.suffix in {'.json','.cs','.csproj','.txt','.log'}:copy(p,out/folder/p.name)
for p in (own/'ida/pseudocode').iterdir():copy(p,out/'native'/p.name)
for name in ['targets.json','status-bounded.json','analyze.py']:copy(own/'ida'/name,out/'native'/name)
source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ToolModule/StringTool.cs';before=root/'work/recovery-stubs/stringtool-before'
copy(source,out/'source/StringTool.cs');copy(source.with_suffix('.cs.meta'),out/'source/StringTool.cs.meta');copy(before/'StringTool.cs',out/'source/StringTool.before.cs')
print('Report26 evidence archived')
