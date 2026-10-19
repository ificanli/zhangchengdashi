param([switch]$Actual)
$ErrorActionPreference='Stop'
$taskRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot=Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$workRoot=Join-Path $taskRoot 'work\stage37-entry'
$mode=if($Actual){'actual'}else{'candidate'}
$plan=Get-Content -LiteralPath (Join-Path $workRoot 'write-plan.json') -Raw | ConvertFrom-Json
$results=@()
foreach($assembly in @('GFRunning','Assembly-CSharp')) {
    $sourceRsp=Join-Path $projectRoot ('Library\Bee\artifacts\1900b0aEDbg.dag\'+$assembly+'.rsp')
    $argsNew=@([IO.File]::ReadAllLines($sourceRsp) | ForEach-Object {
        $line=$_
        if($line -match '^[-/]out:'){$line='-out:"'+(Join-Path $workRoot ('compile/'+$mode+'/'+$assembly+'.dll'))+'"'}
        elseif($line -match '^[-/]refout:'){$line='-refout:"'+(Join-Path $workRoot ('compile/'+$mode+'/'+$assembly+'.ref.dll'))+'"'}
        elseif($assembly -eq 'Assembly-CSharp' -and $line -match '^[-/]r:.*[/\\]GFRunning\.ref?\.dll"?$'){$line='-r:"'+(Join-Path $workRoot ('compile/'+$mode+'/GFRunning.ref.dll'))+'"'}
        elseif($assembly -eq 'Assembly-CSharp' -and $line -match '^[-/]r:.*[/\\]GFRunning\.dll"?$'){$line='-r:"'+(Join-Path $workRoot ('compile/'+$mode+'/GFRunning.dll'))+'"'}
        if(-not $Actual){
            foreach($file in $plan.files){
                if($line.Trim('"').Replace('\','/') -eq $file.path){$line='"'+(Join-Path $workRoot ('candidate/'+$file.path))+'"'}
            }
        }
        $line
    })
    $outRoot=Join-Path $workRoot ('compile/'+$mode)
    New-Item -ItemType Directory -Path $outRoot -Force | Out-Null
    $generatedRoot=Join-Path $taskRoot 'work\t37g'
    New-Item -ItemType Directory -Path (Join-Path $generatedRoot 'JobEntityGenerator\Unity.Entities.SourceGen.JobEntityGenerator.JobEntityGenerator') -Force | Out-Null
    $argsNew+='-generatedfilesout:"'+$generatedRoot+'"'
    $targetRsp=Join-Path $outRoot ($assembly+'.rsp')
    [IO.File]::WriteAllLines($targetRsp,$argsNew,[Text.UTF8Encoding]::new($false))
    $log=Join-Path $outRoot ($assembly+'.log')
    Push-Location $projectRoot
    try { & 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@'+$targetRsp) *> $log; $code=$LASTEXITCODE } finally {Pop-Location}
    $errors=@([IO.File]::ReadAllLines($log) | Where-Object {$_ -match '(?:^|: )error [A-Z]+\d+:'} | Sort-Object -Unique)
    $result=[ordered]@{assembly=$assembly;exitCode=$code;errors=$errors;errorCount=$errors.Count;sourceRspSha256=(Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash;modifiedRspSha256=(Get-FileHash -LiteralPath $targetRsp -Algorithm SHA256).Hash;unityStarted=$false}
    $result | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $outRoot ($assembly+'-result.json')) -Encoding utf8NoBOM
    $results+=$result
    Write-Output ($result | ConvertTo-Json -Depth 6)
    if($code -ne 0){break}
}
$results | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $workRoot ('compile/'+$mode+'/result.json')) -Encoding utf8NoBOM
