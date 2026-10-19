import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';audit=json.loads((own/'final-audit.json').read_text(encoding='utf-8'));reports=root/'outputs/恢复过程文档';evidence=reports/'证据/GZip配置解码';evidence.mkdir(parents=True,exist_ok=True)
text=(own/'24-report.draft.md').read_text(encoding='utf-8')
text=text.replace('**候选已经完成原生核对、独立编译和配置/异常验证；等待主流程导入窗口解冻后写回真实工程并读回复测。**','**原工具的三个解码方法和 UTF8 字段初始化器已写回；实际源码独立编译 0 错误 / 0 警告，176 场景 / 677 检查通过，81 个原 Addressable 配置及其 81 份 Resources 副本全部解码一致。Unity 场景与具体类型消费仍待统一验收。**')
text=text.replace('| 待读回填入 | API、','| **0 错误 / 0 警告** | API、').replace('| 待读回填入 | 14 类','| **176 场景 / 677 检查 / 0 失败，162 资源通过** | 14 类').replace('| 待读回填入 | 四个','| **全部核对通过** | 四个').replace('| 待读回填入 | 原身份','| **全部保持；三个压缩方法未变** | 原身份')
text=text.replace('原源码与 .meta 备份将保存到','原源码与 .meta 备份已保存到').replace('复现命令（完成写回后）','在工程根目录复现').replace('将统一归档到','已统一归档到')
assert '待读回填入' not in text
text+='\n源码 SHA-256：恢复前 `'+audit['sourceBeforeSha256']+'`；恢复后 `'+audit['sourceAfterSha256']+'`。前后 .meta SHA-256 均为 `'+audit['metaAfterSha256']+'`。完整 Token、函数边界、实际源码和原资源哈希检查见 `final-audit.json`。\n'
(reports/'24-配置压缩解码工具恢复.md').write_text(text,encoding='utf-8')
def copy(p,d):d.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(p,d)
for p in own.iterdir():
    if p.is_file() and p.suffix in {'.json','.py','.txt','.patch'}:copy(p,evidence/p.name)
for folder in ['compile','tests','cleanup','metadata']:
    for p in (own/folder).iterdir():
        if p.is_file() and p.suffix in {'.cs','.csproj','.json','.txt','.log'}:copy(p,evidence/folder/p.name)
for p in (own/'ida/pseudocode').iterdir():copy(p,evidence/'native'/p.name)
for name in ['targets.json','status-bounded.json','analyze.py']:copy(own/'ida'/name,evidence/'native'/name)
source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ToolModule/GZipTool.cs';backup=root/'work/recovery-stubs/gzip-before'
copy(source,evidence/'source/GZipTool.cs');copy(source.with_suffix('.cs.meta'),evidence/'source/GZipTool.cs.meta');copy(backup/'GZipTool.cs',evidence/'source/GZipTool.before.cs')
print('Report 24 and native/source/resource/exception/cleanup evidence archived')
