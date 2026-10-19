$ErrorActionPreference='Stop'
$validationRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\validation-research'
$buildRoot=Join-Path $validationRoot 'build/production-probe'
New-Item -ItemType Directory -Path $buildRoot -Force|Out-Null
& dotnet run --project (Join-Path $validationRoot 'ProductionDependencyProbe.csproj') -c Release ('-p:BaseIntermediateOutputPath='+$buildRoot+'/obj/') ('-p:OutputPath='+$buildRoot+'/bin/') *> (Join-Path $buildRoot 'run.log')
$code=$LASTEXITCODE
Get-Content -LiteralPath (Join-Path $buildRoot 'run.log')
exit $code
