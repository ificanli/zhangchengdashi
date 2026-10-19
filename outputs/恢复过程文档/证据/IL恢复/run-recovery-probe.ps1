$ErrorActionPreference = 'Stop'
$taskRoot = Split-Path -Parent (Split-Path -Parent $PSScriptRoot)
Push-Location $taskRoot
try {
    dotnet build work/il-recovery/harness/RecoveryProbe.csproj -c Release --nologo
    if ($LASTEXITCODE -ne 0) { throw 'Harness build failed' }
    dotnet work/il-recovery/harness/bin/Release/net10.0/RecoveryProbe.dll work/ida-input/libil2cpp-arm64.so work/metadata-probe/global-metadata.decoded.dat work/il-recovery/verified-scalar-probe
    if ($LASTEXITCODE -ne 0) { throw 'Selected method recovery or scalar tests failed' }
    python work/il-recovery/emulate_damage.py
    if ($LASTEXITCODE -ne 0) { throw 'Native ARM64 emulation failed' }
    dotnet run --project work/il-recovery/native-verify/NativeVerify.csproj -c Release -- work/il-recovery/verified-scalar-probe/Assembly-CSharp.dll work/il-recovery/release21-parser-probe work/il-recovery/native-damage-golden.json
    if ($LASTEXITCODE -ne 0) { throw 'Recovered IL differs from original native method' }
} finally {
    Pop-Location
}
