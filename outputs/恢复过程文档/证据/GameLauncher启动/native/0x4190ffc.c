void CoreModule_GameLauncher__SetOptimalPerformanceSettings(void *self, const MethodInfo *method)
{
  int systemMemorySize; // w21
  char supportsComputeShaders; // w19
  __int64 currentRenderPipeline; // x0
  __int64 v5; // x10
  __int64 v6; // x20
  char v7; // w22
  long double v8; // q0
  __int64 v9; // x0
  long double v10; // q0

  if ( (byte_8FFF6B0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEF28);
    byte_8FFF6B0 = 1;
  }
  systemMemorySize = UnityEngine_SystemInfo__get_systemMemorySize(0, method);
  supportsComputeShaders = UnityEngine_SystemInfo__get_supportsComputeShaders(0);
  currentRenderPipeline = UnityEngine_Rendering_GraphicsSettings__get_currentRenderPipeline(0);
  if ( currentRenderPipeline != 0
    && (v5 = *((unsigned __int8 *)off_8CEEF28 + 304),
        *(unsigned __int8 *)(*(_QWORD *)currentRenderPipeline + 304LL) >= (unsigned int)v5) )
  {
    if ( *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)currentRenderPipeline + 200LL) + 8 * v5 - 8) == off_8CEEF28 )
      v6 = currentRenderPipeline;
    else
      v6 = 0;
  }
  else
  {
    v6 = 0;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v7 = UnityEngine_Object__op_Inequality(v6, 0, 0);
  if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40D8);
  if ( (v7 & 1) == 0 )
  {
    if ( systemMemorySize <= 3071 )
      v9 = 30;
    else
      v9 = 60;
    goto LABEL_27;
  }
  if ( systemMemorySize <= 3071 )
  {
    UnityEngine_Application__set_targetFrameRate(30, 0);
    LODWORD(v8) = 0.75;
    if ( v6 != 0 )
      goto LABEL_21;
LABEL_28:
    il2cpp_codegen_raise_null_reference_exception();
  }
  UnityEngine_Application__set_targetFrameRate(60, 0);
  if ( v6 == 0 )
    goto LABEL_28;
  LODWORD(v8) = 1061997773;
LABEL_21:
  UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset__set_renderScale(v6, 0, v8);
  if ( (supportsComputeShaders & 1) != 0 )
    return;
  *(float *)&v10 = fmaxf(*(float *)(v6 + 96) + -0.1, 0.7);
  UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset__set_renderScale(v6, 0, v10);
  if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40D8);
  LODWORD(v9) = UnityEngine_Application__get_targetFrameRate(0);
  if ( (int)v9 >= 30 )
    v9 = 30;
  else
    v9 = (unsigned int)v9;
LABEL_27:
  UnityEngine_Application__set_targetFrameRate(v9, 0);
}
