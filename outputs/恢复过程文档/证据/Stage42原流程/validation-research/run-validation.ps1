param([ValidateSet('baseline','candidate')][string]$Mode='baseline')
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs/OccupyCityRecovered'
$validationRoot=Join-Path $taskRoot 'work/parallel-42-fsm/validation-research'
$buildRoot=Join-Path $validationRoot ('build/'+$Mode)
$fixture=Join-Path $buildRoot 'fixture'
New-Item -ItemType Directory -Path $fixture -Force | Out-Null
$baseline=Get-Content -LiteralPath (Join-Path $validationRoot 'baseline-provenance.json') -Raw|ConvertFrom-Json
$records=@()
foreach($entry in $baseline){
 $rel=$entry.path
 $source=if($Mode -eq 'baseline'){Join-Path $validationRoot ('baseline/'+$rel)}else{$candidate=Join-Path $taskRoot ('work/parallel-42-fsm/candidate/'+$rel);if(Test-Path -LiteralPath $candidate){$candidate}else{Join-Path $projectRoot $rel}}
 $destination=Join-Path $fixture $rel
 New-Item -ItemType Directory -Path (Split-Path $destination) -Force|Out-Null
 Copy-Item -LiteralPath $source -Destination $destination
 $records += [ordered]@{source=$source;fixture=$destination;sourceSha256=(Get-FileHash -LiteralPath $source -Algorithm SHA256).Hash;fixtureSha256=(Get-FileHash -LiteralPath $destination -Algorithm SHA256).Hash}
}
foreach($rel in @('Assets/Scripts/GFRunning/GameFramework/GameFrameModule.cs','Assets/Scripts/GFRunning/GameFramework/Variable.cs','Assets/Scripts/GFRunning/GameFramework/GameFrameworkException.cs','Assets/Scripts/GFRunning/GameFramework/Procedure/IProcedureManager.cs','Assets/Scripts/GFRunning/GameFramework/Procedure/ProcedureTypeAttribute.cs')){
 $source=Join-Path $projectRoot $rel;$destination=Join-Path $fixture $rel
 New-Item -ItemType Directory -Path (Split-Path $destination) -Force|Out-Null
 Copy-Item -LiteralPath $source -Destination $destination
 $records += [ordered]@{source=$source;fixture=$destination;sourceSha256=(Get-FileHash -LiteralPath $source -Algorithm SHA256).Hash;fixtureSha256=(Get-FileHash -LiteralPath $destination -Algorithm SHA256).Hash}
}
$records|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $buildRoot 'source-provenance.json') -Encoding utf8NoBOM
$harness=@('Program.cs','BoundaryAdapters.cs','FsmHarness.csproj','run-validation.ps1')|ForEach-Object {[ordered]@{path=$_;sha256=(Get-FileHash -LiteralPath (Join-Path $validationRoot $_) -Algorithm SHA256).Hash}}
$harness|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $buildRoot 'harness-provenance.json') -Encoding utf8NoBOM
$log=Join-Path $buildRoot 'run.log'
& dotnet run --project (Join-Path $validationRoot 'FsmHarness.csproj') -c Release ('-p:FixtureRoot='+$fixture) ('-p:BaseIntermediateOutputPath='+$buildRoot+'/obj/') ('-p:OutputPath='+$buildRoot+'/bin/') -- (Join-Path $buildRoot 'results.json') $Mode *> $log
$code=$LASTEXITCODE
Get-Content -LiteralPath $log | Select-Object -Last 14
Write-Output ('Harness exit='+$code)
exit $code
