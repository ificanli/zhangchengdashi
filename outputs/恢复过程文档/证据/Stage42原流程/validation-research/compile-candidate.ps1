$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs/OccupyCityRecovered'
$validationRoot=Join-Path $taskRoot 'work/parallel-42-fsm/validation-research'
$outRoot=Join-Path $validationRoot 'unity-csc'
$candidateRoot=Join-Path $taskRoot 'work/parallel-42-fsm/candidate'
New-Item -ItemType Directory -Path $outRoot -Force|Out-Null
$sourceRsp=Join-Path $projectRoot 'Library/Bee/artifacts/1900b0aEDbg.dag/GFRunning.rsp'
$sources=@();$taskArgs=[Collections.Generic.List[string]]::new()
foreach($originalLine in [IO.File]::ReadAllLines($sourceRsp)){
 $line=$originalLine
 if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $outRoot 'GFRunning.Stage42.dll')+'"'}
 elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $outRoot 'GFRunning.Stage42.ref.dll')+'"'}
 elseif($line.Trim('"').EndsWith('.cs')){
  $rel=$line.Trim('"');$candidate=Join-Path $candidateRoot $rel
  if(Test-Path -LiteralPath $candidate){$line='"'+$candidate+'"';$sources += [ordered]@{relativePath=$rel;candidate=$candidate;sha256=(Get-FileHash -LiteralPath $candidate -Algorithm SHA256).Hash}}
 }
 $taskArgs.Add($line)
}
$generated=Join-Path $outRoot 'generated';New-Item -ItemType Directory -Path $generated -Force|Out-Null
$taskArgs.Add('-generatedfilesout:"'+$generated+'"')
$rsp=Join-Path $outRoot 'GFRunning.Stage42.rsp';[IO.File]::WriteAllLines($rsp,$taskArgs,[Text.UTF8Encoding]::new($false))
$hostPath='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe'
$compiler='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll'
$log=Join-Path $outRoot 'compile.log'
Push-Location $projectRoot
try{& $hostPath $compiler ('@'+$rsp) *> $log;$code=$LASTEXITCODE}finally{Pop-Location}
$errors=@([IO.File]::ReadAllLines($log)|Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
$result=[ordered]@{exitCode=$code;errorCount=$errors.Count;errors=$errors;sourceRsp=$sourceRsp;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;rsp=$rsp;rspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;compiler=$compiler;compilerSha256=(Get-FileHash -LiteralPath $compiler -Algorithm SHA256).Hash;candidateSources=$sources;allOriginalAnalyzersAndGeneratorsPreserved=$true;unityStarted=$false;runtimeAcceptance=$false}
$result|ConvertTo-Json -Depth 7|Set-Content -LiteralPath (Join-Path $outRoot 'result.json') -Encoding utf8NoBOM
$result|ConvertTo-Json -Depth 7
exit $code
