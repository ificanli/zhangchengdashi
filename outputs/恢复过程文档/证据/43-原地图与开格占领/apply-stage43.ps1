param(
 [switch]$Apply,
 [string]$ProjectRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered'
)
$ErrorActionPreference='Stop'
$workRoot='C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex'
$plan=Get-Content -LiteralPath (Join-Path $workRoot 'write-plan.json') -Raw | ConvertFrom-Json
$resolvedProject=[IO.Path]::GetFullPath($ProjectRoot)
$rows=@()
foreach($item in $plan.files){
 $destination=[IO.Path]::GetFullPath((Join-Path $resolvedProject $item.path))
 if(-not $destination.StartsWith($resolvedProject.TrimEnd('\')+'\',[StringComparison]::OrdinalIgnoreCase)){throw 'Destination escaped project root'}
 $candidate=Join-Path $workRoot ('candidate/'+$item.path)
 if(-not (Test-Path -LiteralPath $destination -PathType Leaf)){throw ('Missing source: '+$destination)}
 $candidateHash=(Get-FileHash -LiteralPath $candidate -Algorithm SHA256).Hash.ToLowerInvariant()
 if($candidateHash -ne $item.candidate_sha256){throw ('Candidate SHA mismatch: '+$item.path)}
 $sourceHash=(Get-FileHash -LiteralPath $destination -Algorithm SHA256).Hash.ToLowerInvariant()
 if($sourceHash -ne $item.source_before_sha256){
  [ordered]@{state='refused_source_changed';file=$item.path;expected=$item.source_before_sha256;actual=$sourceHash;written=0}|ConvertTo-Json -Compress|Write-Output
  exit 20
 }
 $rows+=[pscustomobject]@{path=$item.path;source=$destination;candidate=$candidate;sourceBeforeSha256=$sourceHash;candidateSha256=$candidateHash}
}
if(-not $Apply){
 [ordered]@{state='preflight_passed';apply=$false;files=$rows;written=0}|ConvertTo-Json -Depth 6|Write-Output
 exit 0
}
# The main integration owner invokes -Apply only after coordinating these three
# files. Check every source again immediately before any write.
foreach($item in $rows){
 if((Get-FileHash -LiteralPath $item.source -Algorithm SHA256).Hash.ToLowerInvariant() -ne $item.sourceBeforeSha256){throw ('Source changed after preflight: '+$item.path)}
 if((Get-FileHash -LiteralPath $item.candidate -Algorithm SHA256).Hash.ToLowerInvariant() -ne $item.candidateSha256){throw ('Candidate changed after preflight: '+$item.path)}
}
foreach($item in $rows){
 if((Get-FileHash -LiteralPath $item.source -Algorithm SHA256).Hash.ToLowerInvariant() -ne $item.sourceBeforeSha256){throw ('Source changed during integration: '+$item.path)}
 Copy-Item -LiteralPath $item.candidate -Destination $item.source -Force
 if((Get-FileHash -LiteralPath $item.source -Algorithm SHA256).Hash.ToLowerInvariant() -ne $item.candidateSha256){throw ('Applied SHA mismatch: '+$item.path)}
}
[ordered]@{state='applied';apply=$true;files=$rows;written=$rows.Count}|ConvertTo-Json -Depth 6|Set-Content -LiteralPath (Join-Path $workRoot 'apply-receipt.json') -Encoding utf8NoBOM
Get-Content -LiteralPath (Join-Path $workRoot 'apply-receipt.json') -Raw|Write-Output
