import difflib,hashlib,json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ToolModule/GZipTool.cs';before=root/'work/recovery-stubs/gzip-before/GZipTool.cs'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
text=source.read_text(encoding='utf-8-sig');old=before.read_text(encoding='utf-8-sig')
assert re.findall(r'Token\s*=\s*"(0x[0-9A-Fa-f]+)"',old)==re.findall(r'Token\s*=\s*"(0x[0-9A-Fa-f]+)"',text)
def body(text,name):
    i=text.index('{',text.index(name));j=i+1;depth=1
    while depth:depth+=(text[j]=='{')-(text[j]=='}');j+=1
    return text[i:j]
for name in ['CompressToBase64(', 'Compress(byte[]', 'CompressCore(']:assert body(old,name)==body(text,name)
assert sha(source.with_suffix('.cs.meta'))==sha(before.with_suffix('.cs.meta'))
assert text==(own/'GZipTool.candidate.cs').read_text(encoding='utf-8-sig')
native=json.loads((own/'ida/status-bounded.json').read_text(encoding='utf-8'));assert native['stage']=='complete' and len(native['methods'])==8;assert all(m['actual_function_start']==hex(m['address']) and m['actual_function_end']==hex(m['end']) for m in native['methods'])
il=(own/'compile/actual.il.txt').read_text(encoding='utf-8-sig')
core=il[il.index('uint8[] DecompressCore ('):il.index('// end of method GZipTool::DecompressCore')]
checks={'four_finally_regions':len(re.findall(r'^\s*finally$',core,re.M))==4,'three_stream_disposals':core.count('System.IDisposable::Dispose()')==3,'buffer_pool_return':'ArrayPool`1<uint8>::Return(!0[], bool)' in core,'UTF8_initializer':'Encoding::get_UTF8()' in il,'two_System_Exception_catches':il.count('catch [netstandard]System.Exception')==2,'base64_wrapper_rethrow':'rethrow' in il,'actual_Unity_Debug_LogError':'[UnityEngine.CoreModule]UnityEngine.Debug::LogError(object)' in il}
assert all(checks.values()),checks
resources=json.loads((own/'tests/resource-readback.json').read_text(encoding='utf-8'));oracle=json.loads((own/'resource-oracle.json').read_text(encoding='utf-8'));assert len(resources)==len(oracle)==162
assert sum(r['rows'] for r in resources)==6250
for r in oracle:assert sha(Path(r['path']))==r['sourceSha256']
log=(own/'tests/actual-run.log').read_text(encoding='utf-8-sig');assert 'RESULT scenarios=176 checks=677 failures=0 resourcesPassed=162' in log
result=dict(sourceBeforeSha256=sha(before),sourceAfterSha256=sha(source),metaBeforeSha256=sha(before.with_suffix('.cs.meta')),metaAfterSha256=sha(source.with_suffix('.cs.meta')),originalTokensRetained=True,compressionMethodsUnchanged=True,ILChecks=checks,nativeBoundariesVerified=8,actualSourceScenarios=176,actualSourceChecks=677,resourceFilesVerified=162,originalAddressablePaths=81,correspondingResourceFiles=81,jsonRowsAcrossBothCopies=6250,UnityOrTypedConfigConsumerValidation='not-run by this stage')
(own/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
(own/'GZipTool.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(),text.splitlines(),fromfile='before/GZipTool.cs',tofile='after/GZipTool.cs',lineterm='')),encoding='utf-8')
print(json.dumps(result,ensure_ascii=False,indent=2))
