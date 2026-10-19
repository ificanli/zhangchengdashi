void CoreModule_GameLauncher__ApplyThirtyFpsRenderingSettings(void *self, void *asset, const MethodInfo *method)
{
  const MethodInfo *v5; // x2
  void *v6; // x0
  const MethodInfo *v7; // x1
  const MethodInfo *v8; // x4

  if ( (byte_8FFF6B1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6D690);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D54198);
    byte_8FFF6B1 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(asset, 0, 0) & 1) == 0 )
  {
    if ( asset == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    *((_DWORD *)asset + 23) = 1;
    CoreModule_GameLauncher__ApplyThirtyFpsLightingSettings(self, asset, v5);
    CoreModule_GameLauncher__DisablePostProcessingForLoadedCameras(v6, v7);
    if ( (CoreModule_GameLauncher__TrySetRendererFeatureActive(self, asset, (void *)qword_8D6D690, 0, v8) & 1) == 0 )
    {
      if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE64E8);
      UnityEngine_Debug__LogWarning(qword_8D54198, 0);
    }
  }
}
