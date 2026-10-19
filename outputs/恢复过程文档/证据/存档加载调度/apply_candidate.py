from pathlib import Path
import hashlib
import json
import shutil

work=Path(__file__).resolve().parent
root=work.parents[1]
manifest=json.loads((work/'candidate-manifest.json').read_text())
tests=json.loads((work/'fixture/candidate/result.json').read_text())
compile_result=json.loads((work/'candidate-compile-result.json').read_text())
assert tests['failures']==0 and tests['scenarios']==45
assert compile_result['exitCode']==0 and compile_result['uniqueErrors']==0
for row in manifest['files']:
    source=root/'outputs/OccupyCityRecovered'/row['path']
    candidate=work/'candidate'/row['path']
    assert hashlib.sha256(source.read_bytes()).hexdigest()==row['beforeSha256'],'Source changed; refuse overwrite'
    assert hashlib.sha256(candidate.read_bytes()).hexdigest()==row['candidateSha256'],'Candidate changed'
    assert hashlib.sha256(Path(str(source)+'.meta').read_bytes()).hexdigest()==row['metaSha256'],'Meta changed'
    shutil.copyfile(candidate,source)
    assert source.read_bytes()==candidate.read_bytes()
    print(row['path'],row['candidateSha256'])
