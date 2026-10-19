$ErrorActionPreference = 'Stop'
$stage41Python = 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe'
$stage41Tests = $PSScriptRoot
$stage41Results = @()
foreach ($stage41Mode in @('baseline', 'candidate-current-getters', 'candidate-fixture-getters')) {
    & $stage41Python -X utf8 (Join-Path $stage41Tests 'generate_harness.py') --mode $stage41Mode
    if ($LASTEXITCODE -ne 0) { throw "Generate failed: $stage41Mode" }
    $stage41Case = Join-Path $stage41Tests "generated\$stage41Mode"
    $stage41Inputs = Get-Content -LiteralPath (Join-Path $stage41Case 'provenance.json') -Raw | ConvertFrom-Json
    foreach ($stage41Input in $stage41Inputs.files) {
        if ((Get-FileHash -LiteralPath $stage41Input.path -Algorithm SHA256).Hash.ToLowerInvariant() -ne $stage41Input.sha256) {
            throw "Input changed before execution: $($stage41Input.path)"
        }
    }
    & dotnet run --project (Join-Path $stage41Case 'ConfigChainHarness.csproj') -- $stage41Mode (Join-Path $stage41Case 'expected.json') (Join-Path $stage41Case 'result.json') 2>&1 | Tee-Object -FilePath (Join-Path $stage41Case 'build-and-run.log')
    if ($LASTEXITCODE -ne 0) { throw "Harness failed: $stage41Mode" }
    foreach ($stage41Input in $stage41Inputs.files) {
        if ((Get-FileHash -LiteralPath $stage41Input.path -Algorithm SHA256).Hash.ToLowerInvariant() -ne $stage41Input.sha256) {
            throw "Input changed during execution: $($stage41Input.path)"
        }
    }
    $stage41Result = Get-Content -LiteralPath (Join-Path $stage41Case 'result.json') -Raw | ConvertFrom-Json
    if (-not $stage41Result.passed) { throw "Reported failure: $stage41Mode" }
    $stage41Results += [ordered]@{
        mode = $stage41Mode
        exitCode = 0
        passed = $stage41Result.passed
        assertions = $stage41Result.checks.Count
        rowsCompared = $stage41Result.rowsCompared
        fieldsCompared = $stage41Result.fieldsCompared
        identitiesCompared = $stage41Result.identitiesCompared
        provenance = Join-Path $stage41Case 'provenance.json'
        result = Join-Path $stage41Case 'result.json'
        log = Join-Path $stage41Case 'build-and-run.log'
        compileInputsUnchangedBeforeAndAfter = $true
    }
}
[ordered]@{
    verifiedLayer = 'standalone-net10-controlled-boundaries'
    unityRun = 'not-run'
    jsonParser = 'System.Text.Json field adapter; Unity JsonUtility not exercised'
    fixtureGetterProductionApplied = $false
    modes = $stage41Results
} | ConvertTo-Json -Depth 10 | Set-Content -LiteralPath (Join-Path $stage41Tests 'results-summary.json') -Encoding utf8
