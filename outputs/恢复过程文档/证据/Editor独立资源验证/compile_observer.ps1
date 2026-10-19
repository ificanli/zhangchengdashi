$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$compileRoot=Join-Path $taskRoot 'work\version-resource-startup-plan\compile'
$outputRoot=Join-Path $taskRoot 'work\version-resource-startup-plan\observer-compile'
New-Item -ItemType Directory -Path $outputRoot -Force | Out-Null
$assemblyName='OccupyCity.Recovery.LocalResources.Editor'
$sourceRsp=Join-Path $compileRoot ($assemblyName+'\'+$assemblyName+'.rsp')
$lines=[Collections.Generic.List[string]]::new()
foreach($line0 in [IO.File]::ReadAllLines($sourceRsp)){
    $line=$line0
    if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $outputRoot ($assemblyName+'.dll'))+'"'}
    elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $outputRoot ($assemblyName+'.ref.dll'))+'"'}
    elseif($line -match '^[-/]generatedfilesout:'){continue}
    $lines.Add($line)
}
$lines.Add('"Assets/RecoveryTools/Editor/LocalResources/ObserveLocalResourcesInEditor.cs"')
$rsp=Join-Path $outputRoot ($assemblyName+'.rsp')
[IO.File]::WriteAllLines($rsp,$lines,[Text.UTF8Encoding]::new($false))
$log=Join-Path $outputRoot 'compile.log'
Push-Location $projectRoot
try { & 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$rsp) *> $log;$code=$LASTEXITCODE } finally {Pop-Location}
$errors=@([IO.File]::ReadAllLines($log)|Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
$result=[ordered]@{stage=39;scope='separate Editor resource observation; frozen10 sources unchanged';assembly=$assemblyName;exitCode=$code;errorCount=$errors.Count;errors=$errors;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;modifiedRspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;unityStarted=$false}
$result|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $outputRoot 'result.json') -Encoding utf8NoBOM
$result|ConvertTo-Json -Depth 5
