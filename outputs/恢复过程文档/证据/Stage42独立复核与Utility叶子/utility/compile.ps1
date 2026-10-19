param([switch]$Actual)
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$ownRoot=Join-Path $taskRoot 'work\stage42-independent-review\utility'
$mode=if($Actual){'actual'}else{'candidate'}
$outRoot=Join-Path $ownRoot ('compile\'+$mode)
$candidateRoot=Join-Path $taskRoot 'work\parallel-42-fsm\candidate'
New-Item -ItemType Directory -Path $outRoot -Force|Out-Null
$sourceRsp=Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag\GFRunning.rsp'
$sources=@()
$argsNew=@([IO.File]::ReadAllLines($sourceRsp)|ForEach-Object{
    $line=$_
    if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $outRoot 'GFRunning.Stage42.dll')+'"'}
    elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $outRoot 'GFRunning.Stage42.ref.dll')+'"'}
    elseif($line.Trim('"').EndsWith('.cs')){
        $relative=$line.Trim('"')
        $candidate=Join-Path $candidateRoot $relative
        if(Test-Path -LiteralPath $candidate){$line='"'+$candidate+'"';$sources+=[ordered]@{path=$relative;source=$candidate;sha256=(Get-FileHash -LiteralPath $candidate -Algorithm SHA256).Hash.ToLowerInvariant()}}
        if($relative.Replace('\','/') -eq 'Assets/Scripts/GFRunning/GameFramework/Utility.cs'){
            $utilitySource=if($Actual){Join-Path $projectRoot $relative}else{Join-Path $ownRoot 'Utility.candidate.cs'}
            $line='"'+$utilitySource+'"'
            $sources+=[ordered]@{path=$relative;source=$utilitySource;sha256=(Get-FileHash -LiteralPath $utilitySource -Algorithm SHA256).Hash.ToLowerInvariant()}
        }
    }
    $line
})
$generatedRoot=Join-Path $taskRoot ('work\t42u\'+$mode)
New-Item -ItemType Directory -Path $generatedRoot -Force|Out-Null
$argsNew+='-generatedfilesout:"'+$generatedRoot+'"'
$targetRsp=Join-Path $outRoot 'GFRunning.Stage42.rsp'
[IO.File]::WriteAllLines($targetRsp,$argsNew,[Text.UTF8Encoding]::new($false))
$log=Join-Path $outRoot 'compile.log'
Push-Location $projectRoot
try{& 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$targetRsp) *> $log;$code=$LASTEXITCODE}finally{Pop-Location}
$lines=[IO.File]::ReadAllLines($log)
$errors=@($lines|Where-Object{$_ -match '(?:^|: )error [A-Z]+\d+:'}|Sort-Object -Unique)
$warnings=@($lines|Where-Object{$_ -match '(?:^|: )warning [A-Z]+\d+:'}|Sort-Object -Unique)
$result=[ordered]@{mode=$mode;assembly='GFRunning';exitCode=$code;errorCount=$errors.Count;warningCount=$warnings.Count;errors=$errors;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash.ToLowerInvariant();rsp=$targetRsp;assemblyPath=(Join-Path $outRoot 'GFRunning.Stage42.dll');assemblySha256=(Get-FileHash -LiteralPath (Join-Path $outRoot 'GFRunning.Stage42.dll') -Algorithm SHA256).Hash.ToLowerInvariant();sources=$sources;UnityStarted=$false;experimentDllInstalled=$false}
$result|ConvertTo-Json -Depth 6|Set-Content -LiteralPath (Join-Path $outRoot 'result.json') -Encoding utf8NoBOM
$result|ConvertTo-Json -Depth 6
exit $code
