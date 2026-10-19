param([switch]$Apply,[string]$ProjectRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered')
$ErrorActionPreference='Stop'
$scriptPath=Join-Path $PSScriptRoot 'apply_candidates.py'
$taskArgs=@('-X','utf8',$scriptPath,'--project-root',$ProjectRoot)
if($Apply){$taskArgs+='--apply'}
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' @taskArgs
exit $LASTEXITCODE
