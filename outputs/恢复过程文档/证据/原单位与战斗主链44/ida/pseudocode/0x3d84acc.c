void __fastcall GameModule_RoleBehaviour__SetAiRadius(__int64 a1, long double a2)
{
  long double ScaledRadius; // q0
  float v5; // s9
  float v6; // s8

  if ( (byte_8FFD475 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFD475 = 1;
  }
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    ScaledRadius = GameModule_RoleBehaviour__GetScaledRadius(a1, a2);
    v5 = *(float *)(a1 + 448);
    v6 = *(float *)&ScaledRadius;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    if ( vabds_f32(v5, v6) > 0.01 )
      *(float *)(a1 + 448) = v6;
  }
}
