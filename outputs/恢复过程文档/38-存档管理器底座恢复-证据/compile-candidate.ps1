param([string]$Stage='initial',[string]$Assembly='Assembly-CSharp')
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$workRoot=Join-Path $taskRoot 'work\stage38-savebase'
$originalRsp=Join-Path $projectRoot ('Library\Bee\artifacts\1900b0aEDbg.dag\'+$Assembly+'.rsp')
$taskArgs=[IO.File]::ReadAllLines($originalRsp)
$taskArgs=$taskArgs | ForEach-Object {
 if($_ -match '^[-/]out:'){ '-out:"'+(Join-Path $workRoot ($Assembly+'.check.dll'))+'"' }
 elseif($_ -match '^[-/]refout:'){ '-refout:"'+(Join-Path $workRoot ($Assembly+'.check.ref.dll'))+'"' }
 else{ $_ }
}
# Only physically archived, explicitly recorded ILPP source artifacts may be removed from this snapshot.
$archiveList=Join-Path $workRoot 'archived-source-paths.json'
if(Test-Path -LiteralPath $archiveList){ $archived=Get-Content -LiteralPath $archiveList -Raw | ConvertFrom-Json; $taskArgs=$taskArgs | Where-Object {$candidate=$_.Trim('"').Replace('\','/'); $candidate -notin $archived} }
$taskArgs = $taskArgs | ForEach-Object { $line=$_; foreach($file in (Get-Content (Join-Path $workRoot 'write-plan.json') -Raw | ConvertFrom-Json).files){ if($line.Trim('"').Replace('\','/') -eq $file.path){ $line='"'+(Join-Path $workRoot ('candidate/'+$file.path))+'"' } }; $line }
if($Assembly -eq 'Assembly-CSharp'){
 $taskArgs = $taskArgs | ForEach-Object { if($_ -match '^[-/]r:"?.*[/\\]GFRunning(?:\.ref)?\.dll"?$'){ '-r:"'+(Join-Path $workRoot 'GFRunning.check.dll')+'"' }else{$_} }
}
$rsp=Join-Path $workRoot ($Stage+'.rsp')
$generatedRoot=Join-Path $taskRoot 'work\sg'
New-Item -ItemType Directory -Path (Join-Path $generatedRoot 'JobEntityGenerator\Unity.Entities.SourceGen.JobEntityGenerator.JobEntityGenerator') -Force | Out-Null
$taskArgs += '-generatedfilesout:"'+$generatedRoot+'"'
[IO.File]::WriteAllLines($rsp,$taskArgs,[Text.UTF8Encoding]::new($false))
$compiler='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll'
$hostPath='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe'
$output=Join-Path $workRoot ($Stage+'.log')
Push-Location $projectRoot
try { & $hostPath $compiler ('@'+$rsp) *> $output; $exitCode=$LASTEXITCODE } finally {Pop-Location}
$lines=[IO.File]::ReadAllLines($output)
$errors=@($lines | Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'} | Sort-Object -Unique)
$byCode=@{};foreach($errorLine in $errors){$code=[regex]::Match($errorLine,'error ([A-Z]+\d+)').Groups[1].Value;if(-not $byCode.ContainsKey($code)){$byCode[$code]=0};$byCode[$code]++}
$result=[ordered]@{stage=$Stage;exitCode=$exitCode;unique_errors=$errors.Count;by_error=$byCode;sourceRsp=$originalRsp;sourceRspSha256=(Get-FileHash -LiteralPath $originalRsp -Algorithm SHA256).Hash;copiedRspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;compiler=$compiler;compilerSha256=(Get-FileHash -LiteralPath $compiler -Algorithm SHA256).Hash;unityStarted=$false;errors=$errors}
$result | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath (Join-Path $workRoot ($Stage+'-errors.json')) -Encoding utf8NoBOM
Write-Output (([pscustomobject]$result) | Select-Object stage,exitCode,unique_errors,by_error | ConvertTo-Json -Depth 5)
