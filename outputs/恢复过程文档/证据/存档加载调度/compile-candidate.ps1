param([string]$Stage='candidate')
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$workRoot=Join-Path $taskRoot 'work\stage45-data'
$sourceRsp=Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag\Assembly-CSharp.rsp'
$taskArgs=[IO.File]::ReadAllLines($sourceRsp) | ForEach-Object {
 if($_ -match '^[-/]out:'){ '-out:"'+(Join-Path $workRoot ($Stage+'.dll'))+'"' }
 elseif($_ -match '^[-/]refout:'){ '-refout:"'+(Join-Path $workRoot ($Stage+'.ref.dll'))+'"' }
 elseif($_.Trim('"').Replace('\','/') -eq 'Assets/Scripts/Assembly-CSharp/DataModule/DataManager.cs' -and $Stage -eq 'candidate'){
  '"'+(Join-Path $workRoot 'candidate\Assets\Scripts\Assembly-CSharp\DataModule\DataManager.cs')+'"'
 }
 else{$_}
}
$generated=Join-Path $workRoot ('generated-'+$Stage)
New-Item -ItemType Directory -Path $generated -Force | Out-Null
$taskArgs += '-generatedfilesout:"'+$generated+'"'
$rsp=Join-Path $workRoot ($Stage+'.rsp')
[IO.File]::WriteAllLines($rsp,$taskArgs,[Text.UTF8Encoding]::new($false))
$compiler='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll'
$hostPath='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe'
$log=Join-Path $workRoot ($Stage+'-compile.log')
Push-Location $projectRoot
try{ & $hostPath $compiler ('@'+$rsp) *> $log; $resultCode=$LASTEXITCODE }finally{Pop-Location}
$lines=[IO.File]::ReadAllLines($log)
$errors=@($lines | Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'} | Sort-Object -Unique)
$result=@{stage=$Stage;exitCode=$resultCode;errors=$errors;uniqueErrors=$errors.Count;originalRsp=$sourceRsp;sourceRspSha256=(Get-FileHash $sourceRsp).Hash;compilerSha256=(Get-FileHash $compiler).Hash;unityStarted=$false;analyzersPreserved=$true}
$result | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath (Join-Path $workRoot ($Stage+'-compile-result.json')) -Encoding utf8NoBOM
Write-Output ($result | ConvertTo-Json -Depth 5)
exit $resultCode
