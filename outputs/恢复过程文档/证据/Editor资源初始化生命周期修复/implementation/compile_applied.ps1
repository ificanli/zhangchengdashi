$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$candidateRoot=$projectRoot
$compileRoot=Join-Path $taskRoot 'work\stage39-lifecycle\applied-compile'
$rspRoot=Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag'
$results=@()
foreach($assemblyName in @('GFRunning','OccupyCity.Recovery.LocalResources.Editor')){
 $outputRoot=Join-Path $compileRoot $assemblyName
 New-Item -ItemType Directory -Path $outputRoot -Force | Out-Null
 $sourceRsp=Join-Path $rspRoot ($assemblyName+'.rsp')
 $lines=[Collections.Generic.List[string]]::new()
 foreach($line0 in [IO.File]::ReadAllLines($sourceRsp)){
  $line=$line0
  if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $outputRoot ($assemblyName+'.dll'))+'"'}
  elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $outputRoot ($assemblyName+'.ref.dll'))+'"'}
  elseif($line -match '^[-/]generatedfilesout:'){continue}
  elseif($assemblyName -ne 'GFRunning' -and $line -match '^[-/]r:.*[/\\]GFRunning\.(ref\.)?dll"?$'){$line='-r:"'+(Join-Path $compileRoot 'GFRunning\GFRunning.dll')+'"'}
  elseif($line.Trim('"').Replace('\','/') -eq 'Assets/Scripts/GFRunning/GameFramework/Recovery/LocalEditorResourceBridge.cs'){$line='"'+(Join-Path $candidateRoot 'Assets\Scripts\GFRunning\GameFramework\Recovery\LocalEditorResourceBridge.cs')+'"'}
  elseif($line.Trim('"').Replace('\','/') -eq 'Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesProvider.cs'){$line='"'+(Join-Path $candidateRoot 'Assets\RecoveryTools\Editor\LocalResources\LocalEditorResourcesProvider.cs')+'"'}
  $lines.Add($line)
 }
 if($assemblyName -ne 'GFRunning' -and -not ($lines | Where-Object {$_.Trim('"').Replace('\','/').EndsWith('Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesPlaySession.cs')})){$lines.Add('"'+(Join-Path $candidateRoot 'Assets\RecoveryTools\Editor\LocalResources\LocalEditorResourcesPlaySession.cs')+'"')}
 $rsp=Join-Path $outputRoot ($assemblyName+'.rsp')
 [IO.File]::WriteAllLines($rsp,$lines,[Text.UTF8Encoding]::new($false))
 $log=Join-Path $outputRoot 'compile.log'
 Push-Location $projectRoot
 try { & 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$rsp) *> $log;$code=$LASTEXITCODE } finally {Pop-Location}
 $errors=@([IO.File]::ReadAllLines($log)|Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
 $result=[ordered]@{stage=39;scope='applied production lifecycle sources';assembly=$assemblyName;exitCode=$code;errorCount=$errors.Count;errors=$errors;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;modifiedRspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;unityStarted=$false;productionEdits=3}
 $result|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $outputRoot 'result.json') -Encoding utf8NoBOM
 $results+=$result
 if($code -ne 0){break}
}
$results|ConvertTo-Json -Depth 5
