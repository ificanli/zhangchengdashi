import difflib,hashlib,json,sys
from pathlib import Path
sys.stdout.reconfigure(encoding='utf-8')
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';proof=json.loads((own/'candidate-provenance.json').read_text(encoding='utf-8'));source=Path(proof['source']);sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
assert sha(source)==proof['sourceBeforeSha256'];assert sha(source.with_suffix('.cs.meta'))==proof['metaSha256']
backup=root/'work/recovery-stubs/gzip-before';backup.mkdir(parents=True,exist_ok=True)
assert not (backup/'GZipTool.cs').exists();(backup/'GZipTool.cs').write_bytes(source.read_bytes());(backup/'GZipTool.cs.meta').write_bytes(source.with_suffix('.cs.meta').read_bytes())
old=source.read_text(encoding='utf-8-sig');new=(own/'GZipTool.candidate.cs').read_text(encoding='utf-8-sig');lines=list(difflib.unified_diff(old.splitlines(),new.splitlines(),lineterm=''))[2:]
print('*** Begin Patch\n*** Update File: '+source.as_posix())
for line in lines:print('@@' if line.startswith('@@') else line)
print('*** End Patch')
