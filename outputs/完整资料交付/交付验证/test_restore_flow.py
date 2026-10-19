from pathlib import Path
import hashlib
import io
import json
import shutil
import sys
import tarfile
import tempfile

import zstandard

root=Path(__file__).resolve().parents[2]
sys.path.insert(0,str(root/'outputs/完整资料交付'))
from restore_all_materials import restore,sha_file

fixture=root/'work/git-delivery/restore-fixture'
fixture.mkdir(exist_ok=True)
parts=fixture/'parts';parts.mkdir(exist_ok=True)
destination=fixture/'restored';destination.mkdir(exist_ok=True)
value='中文恢复资料\n原路径与哈希验证\n'.encode('utf-8')
digest=hashlib.sha256(value).hexdigest()
stream=io.BytesIO()
with tarfile.open(fileobj=stream,mode='w') as archive:
    info=tarfile.TarInfo('blobs/'+digest);info.size=len(value);archive.addfile(info,io.BytesIO(value))
compressed=zstandard.ZstdCompressor().compress(stream.getvalue())
spec=[]
for index,start in enumerate(range(0,len(compressed),31),1):
    name=f'fixture.part{index:03d}';data=compressed[start:start+31];(parts/name).write_bytes(data)
    spec.append(dict(name=name,bytes=len(data),sha256=hashlib.sha256(data).hexdigest()))
git_value=b'git source exact bytes\n';git_hash=hashlib.sha256(git_value).hexdigest()
(destination/'outputs').mkdir(exist_ok=True);(destination/'outputs/git.txt').write_bytes(git_value)
manifest=dict(files=[dict(path='work/中文资料.txt',bytes=len(value),sha256=digest,storage='archive'),
                     dict(path='outputs/另一份副本.txt',bytes=len(value),sha256=digest,storage='archive'),
                     dict(path='work/git-copy.txt',bytes=len(git_value),sha256=git_hash,storage='git-copy',sourceGitPath='outputs/git.txt')])
restore(destination,parts,manifest,spec)
assert (destination/'work/中文资料.txt').read_bytes()==value
assert (destination/'outputs/另一份副本.txt').read_bytes()==value
assert (destination/'work/git-copy.txt').read_bytes()==git_value
restore(destination,parts,manifest,spec)
changed=destination/'work/中文资料.txt';changed.write_bytes(b'user modified')
try:restore(destination,parts,manifest,spec)
except RuntimeError as error:
    assert 'refuse overwrite' in str(error)
else:raise AssertionError('Restore overwrote changed user file')
assert changed.read_bytes()==b'user modified'
bad=dict(files=[dict(path='../escaped.txt',bytes=len(value),sha256=digest,storage='archive')])
try:restore(destination,parts,bad,spec)
except RuntimeError as error:
    assert 'escaped destination' in str(error)
else:raise AssertionError('Restore accepted escaped manifest path')
result=dict(status='restore_flow_passed',cases=5,checks=['split-zstd-tar stream','unicode relative paths','deduplicated blob copies','git-copy mapping','existing changed file and escaped path refused'],failures=0)
(root/'work/git-delivery/restore-script-validation.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(result,ensure_ascii=False,indent=2))
