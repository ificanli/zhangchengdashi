void CoreModule_GameLauncher__ApplyThirtyFpsLightingSettings(void *self, void *asset, const MethodInfo *method)
{
  if ( (byte_8FFF6B2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D1D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D80620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D80690);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D80610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D806B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D83520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D83518);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D83510);
    byte_8FFF6B2 = 1;
  }
  if ( asset == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  UnityEngine_Rendering_Universal_UniversalRenderPipelineAsset__set_shadowDistance(asset, 0, method, 0.0);
  CoreModule_GameLauncher__TrySetPropertyOrField_bool_(
    self,
    asset,
    (void *)qword_8D83518,
    (void *)qword_8D80690,
    0,
    (const MethodInfo *)qword_8D2D1D8);
  CoreModule_GameLauncher__TrySetPropertyOrField_bool_(
    self,
    asset,
    (void *)qword_8D83510,
    (void *)qword_8D80610,
    0,
    (const MethodInfo *)qword_8D2D1D8);
  CoreModule_GameLauncher__TrySetPropertyOrField_bool_(
    self,
    asset,
    (void *)qword_8D83520,
    (void *)qword_8D806B8,
    0,
    (const MethodInfo *)qword_8D2D1D8);
  CoreModule_GameLauncher__TrySetPropertyOrField_bool_(
    self,
    asset,
    (void *)qword_8D80620,
    (void *)qword_8D80620,
    0,
    (const MethodInfo *)qword_8D2D1D8);
}
