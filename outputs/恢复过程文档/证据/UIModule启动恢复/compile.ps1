param([switch]$Actual)
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$workRoot=Join-Path $taskRoot 'work\stage40-ui'
$mode=if($Actual){'actual'}else{'candidate'}
$sourceRsp=Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag\GFRunning.rsp'
$outRoot=Join-Path $workRoot ('compile/'+$mode)
New-Item -ItemType Directory -Path $outRoot -Force | Out-Null
$argsNew=@([IO.File]::ReadAllLines($sourceRsp)|ForEach-Object {
    $line=$_
    if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $outRoot 'GFRunning.dll')+'"'}
    elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $outRoot 'GFRunning.ref.dll')+'"'}
    elseif(-not $Actual -and $line.Trim('"').Replace('\','/') -eq 'Assets/Scripts/GFRunning/GameFramework/UIModule.cs'){$line='"'+(Join-Path $workRoot 'UIModule.candidate.cs')+'"'}
    $line
})
$generatedRoot=Join-Path $taskRoot 'work\t40g'
New-Item -ItemType Directory -Path $generatedRoot -Force | Out-Null
$argsNew+='-generatedfilesout:"'+$generatedRoot+'"'
$rsp=Join-Path $outRoot 'GFRunning.rsp'
[IO.File]::WriteAllLines($rsp,$argsNew,[Text.UTF8Encoding]::new($false))
$log=Join-Path $outRoot 'GFRunning.log'
Push-Location $projectRoot
try { & 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$rsp) *> $log;$code=$LASTEXITCODE } finally {Pop-Location}
$errors=@([IO.File]::ReadAllLines($log)|Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
$result=[ordered]@{stage=40;mode=$mode;exitCode=$code;errorCount=$errors.Count;errors=$errors;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;modifiedRspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;unityStarted=$false}
$result|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $outRoot 'result.json') -Encoding utf8NoBOM
$result|ConvertTo-Json -Depth 5
