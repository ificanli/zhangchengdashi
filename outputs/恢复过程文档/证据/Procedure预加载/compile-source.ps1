$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$workRoot=Join-Path $taskRoot 'work\procedure-review'
$originalRsp=Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag\Assembly-CSharp.rsp'
$taskArgs=@([IO.File]::ReadAllLines($originalRsp)|Where-Object {$_ -notmatch '^".*\.cs"$'}|ForEach-Object {if($_ -match '^[-/]out:'){'-out:"'+(Join-Path $workRoot 'Procedure.Source.ApiCheck.dll')+'"'}elseif($_ -match '^[-/]refout:'){'-refout:"'+(Join-Path $workRoot 'Procedure.Source.ApiCheck.ref.dll')+'"'}else{$_}})
$taskArgs += '-r:"'+(Join-Path $taskRoot 'work\il2cpp-dump-decoded\DummyDll\Assembly-CSharp.dll')+'"'
$taskArgs += '"Assets/Scripts/Assembly-CSharp/ljzs_lt/Procedure/ProcedurePreLoad.cs"'
$taskArgs += '"Assets/Scripts/Assembly-CSharp/ljzs_lt/Procedure/ProcedureStarGame.cs"'
$rsp=Join-Path $workRoot 'actual-source.rsp';[IO.File]::WriteAllLines($rsp,$taskArgs,[Text.UTF8Encoding]::new($false))
Push-Location $projectRoot
try{& 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$rsp) *> (Join-Path $workRoot 'actual-source.log');$compilerExit=$LASTEXITCODE}finally{Pop-Location}
$errors=@([IO.File]::ReadAllLines((Join-Path $workRoot 'actual-source.log'))|Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
[ordered]@{exitCode=$compilerExit;errorCount=$errors.Count;errors=$errors;source='Actual unchanged project ProcedurePreLoad.cs and ProcedureStarGame.cs';sameUnityCompilerAndRspReferences=$true;companionAssemblyTypes='Original DummyDll/Assembly-CSharp.dll metadata reference only; methods not executed';output='work/procedure-review/Procedure.Source.ApiCheck.dll';unityStarted=$false;wholeAssemblyOrRuntimeAcceptance=$false}|ConvertTo-Json -Depth 5|Set-Content -LiteralPath (Join-Path $workRoot 'actual-source-compilation.json') -Encoding utf8NoBOM
Write-Output ('Compiler exit='+$compilerExit+' errors='+$errors.Count)
$errors|Select-Object -First 5
