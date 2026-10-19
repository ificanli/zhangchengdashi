$ErrorActionPreference = 'Stop'
$taskRoot = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'
$projectRoot = Join-Path $taskRoot 'outputs\OccupyCityRecovered'
$ownRoot = Join-Path $taskRoot 'work\stage48-new-ui'
$outRoot = Join-Path $ownRoot 'compile\actual'
New-Item -ItemType Directory -Path $outRoot -Force | Out-Null
$sourceRsp = Join-Path $projectRoot 'Library\Bee\artifacts\1900b0aEDbg.dag\Assembly-CSharp.rsp'
$generatedRoot = Join-Path $taskRoot 'work\t48g'
New-Item -ItemType Directory -Path (Join-Path $generatedRoot 'JobEntityGenerator\Unity.Entities.SourceGen.JobEntityGenerator.JobEntityGenerator') -Force | Out-Null
$argsNew = @([IO.File]::ReadAllLines($sourceRsp) | ForEach-Object {
    if ($_ -match '^[-/]out:') { '-out:"' + (Join-Path $outRoot 'Assembly-CSharp.dll') + '"' }
    elseif ($_ -match '^[-/]refout:') { '-refout:"' + (Join-Path $outRoot 'Assembly-CSharp.ref.dll') + '"' }
    elseif ($_ -notmatch '^[-/]generatedfilesout:') { $_ }
})
$argsNew += '-generatedfilesout:"' + $generatedRoot + '"'
$targetRsp = Join-Path $outRoot 'Assembly-CSharp.rsp'
[IO.File]::WriteAllLines($targetRsp, $argsNew, [Text.UTF8Encoding]::new($false))
$log = Join-Path $outRoot 'Assembly-CSharp.log'
Push-Location $projectRoot
try {
    & 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\NetCoreRuntime\dotnet.exe' 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Data\DotNetSdkRoslyn\csc.dll' ('@' + $targetRsp) *> $log
    $code = $LASTEXITCODE
} finally { Pop-Location }
$lines = [IO.File]::ReadAllLines($log)
$errors = @($lines | Where-Object { $_ -match '(?:^|: )error [A-Z]+\d+:' } | Sort-Object -Unique)
$warnings = @($lines | Where-Object { $_ -match '(?:^|: )warning [A-Z]+\d+:' } | Sort-Object -Unique)
$sourceFiles = @('UIManager', 'UIPanel' | ForEach-Object {
    $path = Join-Path $projectRoot ('Assets\Scripts\Assembly-CSharp\UIFramework\' + $_ + '.cs')
    [ordered]@{ path = $path; sha256 = (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash.ToLowerInvariant() }
})
$result = [ordered]@{
    assembly = 'Assembly-CSharp'; status = 'full-actual-source-csc-only'; exitCode = $code
    errorCount = $errors.Count; warningCount = $warnings.Count; errors = $errors
    sourceRspSha256 = (Get-FileHash -LiteralPath $sourceRsp -Algorithm SHA256).Hash.ToLowerInvariant()
    modifiedRspSha256 = (Get-FileHash -LiteralPath $targetRsp -Algorithm SHA256).Hash.ToLowerInvariant()
    assemblySha256 = if (Test-Path -LiteralPath (Join-Path $outRoot 'Assembly-CSharp.dll')) { (Get-FileHash -LiteralPath (Join-Path $outRoot 'Assembly-CSharp.dll') -Algorithm SHA256).Hash.ToLowerInvariant() } else { $null }
    sourceFiles = $sourceFiles; unityStarted = $false; installedExperimentDll = $false
}
$result | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $outRoot 'result.json') -Encoding utf8NoBOM
$result | ConvertTo-Json -Depth 6
exit $code
