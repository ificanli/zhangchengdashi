[CmdletBinding()]
param(
    [string]$ProjectRoot = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered',
    [switch]$Apply
)
$ErrorActionPreference = 'Stop'
$stage42Package = $PSScriptRoot
$stage42Manifest = Get-Content -LiteralPath (Join-Path $stage42Package 'integration-manifest.json') -Raw | ConvertFrom-Json
$stage42Root = [IO.Path]::GetFullPath($ProjectRoot).TrimEnd([IO.Path]::DirectorySeparatorChar)
$stage42Prefix = $stage42Root + [IO.Path]::DirectorySeparatorChar
$stage42Plan = @()

# Validate the entire package before the first write, including unmodified
# interfaces and all original meta files. A stale source rejects the batch.
foreach ($stage42File in $stage42Manifest.files) {
    $stage42Destination = [IO.Path]::GetFullPath((Join-Path $stage42Root $stage42File.path))
    if (-not $stage42Destination.StartsWith($stage42Prefix, [StringComparison]::OrdinalIgnoreCase)) {
        throw "Path escapes project: $($stage42File.path)"
    }
    if (-not (Test-Path -LiteralPath $stage42Destination -PathType Leaf)) {
        throw "Missing source: $stage42Destination"
    }
    $stage42SourceHash = (Get-FileHash -LiteralPath $stage42Destination -Algorithm SHA256).Hash.ToLowerInvariant()
    if ($stage42SourceHash -ne $stage42File.source_before_sha256) {
        throw "SOURCE_BEFORE_MISMATCH: $($stage42File.path); expected=$($stage42File.source_before_sha256); actual=$stage42SourceHash"
    }
    $stage42MetaHash = (Get-FileHash -LiteralPath ($stage42Destination + '.meta') -Algorithm SHA256).Hash.ToLowerInvariant()
    if ($stage42MetaHash -ne $stage42File.meta_sha256) {
        throw "META_MISMATCH: $($stage42File.path)"
    }
    if ($stage42File.candidate_sha256) {
        $stage42Candidate = [IO.Path]::GetFullPath((Join-Path (Join-Path $stage42Package 'candidate') $stage42File.path))
        $stage42CandidateHash = (Get-FileHash -LiteralPath $stage42Candidate -Algorithm SHA256).Hash.ToLowerInvariant()
        if ($stage42CandidateHash -ne $stage42File.candidate_sha256) {
            throw "CANDIDATE_MISMATCH: $($stage42File.path)"
        }
        $stage42Plan += [pscustomobject]@{
            path = $stage42File.path
            source = $stage42Destination
            candidate = $stage42Candidate
            source_before_sha256 = $stage42SourceHash
            candidate_sha256 = $stage42CandidateHash
        }
    }
}

if ($Apply) {
    foreach ($stage42Item in $stage42Plan) {
        $stage42Now = (Get-FileHash -LiteralPath $stage42Item.source -Algorithm SHA256).Hash.ToLowerInvariant()
        if ($stage42Now -ne $stage42Item.source_before_sha256) {
            throw "SOURCE_CHANGED_AFTER_PREFLIGHT: $($stage42Item.path)"
        }
        [IO.File]::WriteAllBytes($stage42Item.source, [IO.File]::ReadAllBytes($stage42Item.candidate))
        $stage42Written = (Get-FileHash -LiteralPath $stage42Item.source -Algorithm SHA256).Hash.ToLowerInvariant()
        if ($stage42Written -ne $stage42Item.candidate_sha256) {
            throw "POST_WRITE_MISMATCH: $($stage42Item.path)"
        }
    }
}
[pscustomobject]@{
    task = 'stage42'
    mode = $(if ($Apply) { 'applied' } else { 'preflight_only' })
    project = $stage42Root
    files_validated = @($stage42Manifest.files).Count
    files_to_apply = $stage42Plan.Count
    files = $stage42Plan
} | ConvertTo-Json -Depth 8
