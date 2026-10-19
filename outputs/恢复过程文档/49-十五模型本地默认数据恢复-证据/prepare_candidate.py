from pathlib import Path
w=Path('work/stage49-model-defaults')
for name in ['Rewrite.cs','Rewrite.csproj','Verify.cs','Verify.csproj','compile-candidate.ps1']:
 s=(Path('work/stage38-savebase')/name).read_text(encoding='utf-8').replace('work/stage38-savebase','work/stage49-model-defaults').replace('work\\stage38-savebase','work\\stage49-model-defaults')
 (w/name).write_text(s,encoding='utf-8')
