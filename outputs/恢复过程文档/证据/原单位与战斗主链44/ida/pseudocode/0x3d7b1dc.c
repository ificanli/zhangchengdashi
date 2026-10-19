__int64 __fastcall GameModule_RoleBehaviour__AddForeverSpeed(__int64 a1, float a2)
{
  float v4; // s0
  __int64 v5; // x2
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x8

  if ( (byte_8FFD46B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD46B = 1;
  }
  v4 = *(float *)(a1 + 236) + (float)(*(float *)(a1 + 236) * a2);
  *(float *)(a1 + 236) = v4;
  *(float *)(a1 + 444) = v4;
  if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v6 = *(_QWORD *)(a1 + 128);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
    {
      v7 = *(_QWORD *)(a1 + 128);
      if ( v7 == 0 )
        goto LABEL_11;
      Pathfinding_FollowerEntity__set_maxSpeed(v7, 0, *(float *)(a1 + 236));
    }
  }
  v8 = *(_QWORD *)(a1 + 64);
  if ( v8 == 0 )
LABEL_11:
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(v8 + 40) = *(_DWORD *)(a1 + 236);
  return GameModule_RoleBehaviour__SetAiSPeed(a1, 0, v5);
}
