param(
    [ValidateSet('GFRunning','Assembly-CSharp')][string]$Assembly='GFRunning',
    [ValidateSet('Source','Candidate')][string]$SourceMode='Candidate',
    [string]$Stage='candidate'
)
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$ownedRoot=Join-Path $taskRoot 'work\parallel-41-config'
$compileRoot=Join-Path $ownedRoot ('evidence\source-chain\compile\'+$Stage)
New-Item -ItemType Directory -Path $compileRoot -Force | Out-Null
$sourceRsp=Join-Path $projectRoot ('Library\Bee\artifacts\1900b0aEDbg.dag\'+$Assembly+'.rsp')
if(-not (Test-Path -LiteralPath $sourceRsp)){throw "Live Unity response file missing: $sourceRsp"}
$ownedPaths=@(
    'Assets/Scripts/Assembly-CSharp/ljzs_lt/ConfigMgr.cs',
    'Assets/Scripts/GFRunning/GameFramework/ConfigRead.cs',
    'Assets/Scripts/GFRunning/GameFramework/BaseConfig.cs'
)
$taskArgs=[IO.File]::ReadAllLines($sourceRsp) | ForEach-Object {
    $line=$_
    if($line -match '^[-/]out:') { $line='-out:"'+(Join-Path $compileRoot ($Assembly+'.dll'))+'"' }
    elseif($line -match '^[-/]refout:') { $line='-refout:"'+(Join-Path $compileRoot ($Assembly+'.ref.dll'))+'"' }
    elseif($line -match '^[-/]generatedfilesout:') { $line=$null }
    elseif($SourceMode -eq 'Candidate' -and $line.Trim('"').Replace('\','/') -in $ownedPaths) {
        $candidatePath=Join-Path $ownedRoot ('candidate/'+$line.Trim('"').Replace('\','/'))
        if(-not (Test-Path -LiteralPath $candidatePath)){throw "Candidate missing: $candidatePath"}
        $line='"'+$candidatePath+'"'
    }
    elseif($Assembly -eq 'Assembly-CSharp' -and $line -match '^[-/]r:"?.*[/\\]GFRunning(?:\.ref)?\.dll"?$') {
        $candidateGF=Join-Path $compileRoot 'GFRunning.dll'
        if(-not (Test-Path -LiteralPath $candidateGF)){throw "Compile GFRunning first at the same Stage: $candidateGF"}
        $line='-r:"'+$candidateGF+'"'
    }
    if($null -ne $line){$line}
}
$generatedRoot=Join-Path $compileRoot 'generated'
New-Item -ItemType Directory -Path $generatedRoot -Force | Out-Null
$taskArgs+='-generatedfilesout:"'+$generatedRoot+'"'
$rsp=Join-Path $compileRoot ($Assembly+'.rsp')
[IO.File]::WriteAllLines($rsp,$taskArgs,[Text.UTF8Encoding]::new($false))
$compiler='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll'
$hostPath='C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe'
$log=Join-Path $compileRoot ($Assembly+'.log')
Push-Location $projectRoot
try {& $hostPath $compiler ('@'+$rsp) *> $log; $compilerExit=$LASTEXITCODE} finally {Pop-Location}
$errors=@([IO.File]::ReadAllLines($log) | Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'} | Sort-Object -Unique)
$result=[ordered]@{
    stage=$Stage; assembly=$Assembly; mode=$SourceMode; exitCode=$compilerExit; uniqueErrors=$errors.Count;
    sourceRsp=$sourceRsp; sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;
    candidateRsp=$rsp; candidateRspSha256=(Get-FileHash -LiteralPath $rsp -Algorithm SHA256).Hash;
    compiler=$compiler; compilerSha256=(Get-FileHash -LiteralPath $compiler -Algorithm SHA256).Hash;
    host=$hostPath; log=$log; output=(Join-Path $compileRoot ($Assembly+'.dll'));
    scope='Existing Unity references and generators, isolated output only; this does not import or run Unity';
    unityStarted=$false; sourceWrites=$false; errors=$errors
}
$result | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $compileRoot ($Assembly+'-result.json')) -Encoding utf8NoBOM
$result | ConvertTo-Json -Depth 4
exit $compilerExit
