$ErrorActionPreference = 'Stop'
$projectRoot = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered'
$auditRoot = $PSScriptRoot
$shaderPaths = @(
 'Assets/Shader/Hidden_Universal_CoreBlit.shader',
 'Assets/Shader/Hidden_Universal_CoreBlit_0.shader',
 'Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth.shader',
 'Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth_0.shader'
)
$shaderFacts = foreach ($relative in $shaderPaths) {
 $absolute = Join-Path $projectRoot $relative
 $body = Get-Content -LiteralPath $absolute -Raw
 $meta = Get-Content -LiteralPath ($absolute + '.meta') -Raw
 $guid = [regex]::Match($meta, '(?m)^guid: ([0-9a-f]{32})').Groups[1].Value
 $references = & rg -n -F $guid (Join-Path $projectRoot 'Assets') (Join-Path $projectRoot 'ProjectSettings') (Join-Path $projectRoot 'Packages')
 [ordered]@{
  path=$relative; shaderName=[regex]::Match($body, 'Shader\s+"([^"]+)"').Groups[1].Value
  guid=$guid; sha256=(Get-FileHash -LiteralPath $absolute -Algorithm SHA256).Hash.ToLowerInvariant()
  metaSha256=(Get-FileHash -LiteralPath ($absolute+'.meta') -Algorithm SHA256).Hash.ToLowerInvariant()
  dummyExporter=$body.Contains('DummyShaderTextExporter')
  passCount=[regex]::Matches($body, '(?m)^\s*Pass\b').Count
  hdrDecodeKeyword=$body.Contains('BLIT_DECODE_HDR')
  references=@($references)
 }
}
$guidIndex = @{}
foreach ($metaFile in (& rg --files (Join-Path $projectRoot 'Assets/Shader') -g '*.meta')) {
 $metaBody = Get-Content -LiteralPath $metaFile -Raw
 $guid = [regex]::Match($metaBody, '(?m)^guid: ([0-9a-f]{32})').Groups[1].Value
 $guidIndex[$guid] = $metaFile.Substring(0, $metaFile.Length - 5)
}
$rendererFacts = foreach ($relative in @('Assets/MonoBehaviour/SamplesForwardRenderer.asset', 'Assets/_Res/Addressable/01FirstBundle/Config/SamplesForwardRenderer.asset')) {
 $absolute = Join-Path $projectRoot $relative
 $lineNumber = 0
 foreach ($line in (Get-Content -LiteralPath $absolute)) {
  $lineNumber++
  $match = [regex]::Match($line, '^\s+([A-Za-z0-9_]+): \{fileID: 4800000, guid: ([0-9a-f]{32}), type: 3\}')
  if (!$match.Success) { continue }
  $guid = $match.Groups[2].Value
  $source = $guidIndex[$guid]
  $body = if ($source) { Get-Content -LiteralPath $source -Raw } else { '' }
  [ordered]@{renderer=$relative; line=$lineNumber; field=$match.Groups[1].Value; guid=$guid; shaderPath=$source; isDummy=$body.Contains('DummyShaderTextExporter')}
 }
}
$sourceQueries = @(
 @('ProjectSettings/GraphicsSettings.asset', 'm_CustomRenderPipeline|m_SRPDefaultSettings'),
 @('ProjectSettings/QualitySettings.asset', 'm_CurrentQuality|customRenderPipeline'),
 @('Assets/MonoBehaviour/SamplesPipelineAsset.asset', 'm_RendererDataList|e0e3c0bc|m_DefaultRendererIndex|m_RequireDepthTexture|m_RequireOpaqueTexture|m_OpaqueDownsampling|m_SupportsHDR|m_RenderScale'),
 @('Assets/_Res/Addressable/01FirstBundle/Config/SamplesPipelineAsset.asset', 'm_RendererDataList|157d03f6|m_DefaultRendererIndex'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/Data/UniversalRenderPipelineAsset.cs', 'Blitter.Initialize|enum Downsampling|_2xBilinear'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/UniversalRenderer.cs', 'CreateEngineMaterial|copyColorPass|requiresDepthCopyPass|m_CopyColorPass.Setup|m_FinalBlitPass.Setup'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/UniversalRendererData.cs', 'coreBlit|ReloadAllNull'),
 @('Library/PackageCache/com.unity.render-pipelines.core@14.0.12/Runtime/Utilities/Blitter.cs', 's_Blit =|s_BlitColorAndDepth =|BLIT_DECODE_HDR|BlitColorAndDepth\(|blitDepth \?|DrawProcedural'),
 @('Library/PackageCache/com.unity.render-pipelines.core@14.0.12/Runtime/Utilities/CoreUtils.cs', 'CreateEngineMaterial\(|Shader.Find'),
 @('Library/PackageCache/com.unity.render-pipelines.core@14.0.12/Runtime/Utilities/ResourceReloader.cs', 'SetAndLoadIfNull|IsNull\(container, info\)|AssetDatabase.LoadAssetAtPath|Shader.Find'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/Passes/CopyColorPass.cs', 'Downsampling\.|BlitCameraTexture'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/Passes/FinalBlitPass.cs', 'NearestDebugDraw|BilinearDebugDraw|FindPass|shaderPassIndex'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Shaders/Utils/CoreBlit.shader', '^Shader|Pass|Name|BLIT_DECODE_HDR|include'),
 @('Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Shaders/Utils/CoreBlitColorAndDepth.shader', '^Shader|Pass|fragment|include'),
 @('Assets/gameres/bundleres/Scene/MineGameMain.unity', 'm_RequiresDepthTextureOption|m_RequiresOpaqueTextureOption|m_RendererIndex|m_RenderPostProcessing')
)
$sourceEvidence = foreach ($query in $sourceQueries) {
 $absolute = Join-Path $projectRoot $query[0]
 [ordered]@{path=$query[0]; sha256=(Get-FileHash -LiteralPath $absolute -Algorithm SHA256).Hash.ToLowerInvariant(); lines=@(& rg -n $query[1] $absolute)}
}
$report = [ordered]@{
 generatedUtc=[DateTime]::UtcNow.ToString('o'); mode='read_only_project_audit'; projectRoot=$projectRoot
 shaderFacts=@($shaderFacts); rendererShaderReferences=@($rendererFacts); sourceEvidence=@($sourceEvidence)
 configuredCurrentCoreBlitGuid='a44b6e872349fd24eb5ea9b6e58a802d'
 main5RuntimeGuidCaptured=$false
 exactNameOccurrences=@(& rg -n -F 'Hidden/Universal/CoreBlit' (Join-Path $projectRoot 'Assets') (Join-Path $projectRoot 'Packages'))
 blitColorAndDepthCallSites=@(& rg -n 'BlitColorAndDepth\(' (Join-Path $projectRoot 'Assets') (Join-Path $projectRoot 'Packages') (Join-Path $projectRoot 'Library/PackageCache/com.unity.render-pipelines.universal@14.0.12'))
}
$report | ConvertTo-Json -Depth 12 | Set-Content -LiteralPath (Join-Path $auditRoot 'binding-evidence.json') -Encoding utf8NoBOM
Write-Output ('Audit evidence: ' + (Join-Path $auditRoot 'binding-evidence.json'))
