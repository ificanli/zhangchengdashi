from pathlib import Path
p=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-44-battle\compile_candidates.py')
s=p.read_text(encoding='utf-8-sig').replace("out=W/'compile';", "out=W/'role-validation/compile-final';")
exec(compile(s,str(p),'exec'),{'__name__':'__main__','__file__':str(p)})
