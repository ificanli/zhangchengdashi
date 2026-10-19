__int64 __fastcall GameModule_BattleGameSceneManager__TryGetRoleTargetFrameCacheKey(
        __int64 a1,
        char a2,
        _QWORD *a3,
        long double a4,
        long double a5,
        long double a6,
        long double a7)
{
  char RoleTargetHexSearchRing; // w8
  __int64 result; // x0
  __int64 v16; // x21
  int v17; // w21
  int v18; // w22
  float v19; // s8
  unsigned int v20; // w8
  int v21; // w4
  __int128 v22; // [xsp+0h] [xbp-70h] BYREF
  int v23; // [xsp+14h] [xbp-5Ch] BYREF
  __int64 v24; // [xsp+18h] [xbp-58h] BYREF

  if ( (byte_8FFD798 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD798 = 1;
  }
  v24 = 0;
  v23 = 0;
  *a3 = 0;
  a3[1] = 0;
  RoleTargetHexSearchRing = GameModule_BattleGameSceneManager__TryGetRoleTargetHexSearchRing(a1, &v23, a7);
  result = 0;
  if ( (RoleTargetHexSearchRing & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE81E8);
    if ( (HexManager__TryGetHexAt(&v24, 0, a4, a5, a6) & 1) == 0 )
      return 0;
    v16 = v24;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v16, 0, 0) & 1) == 0 )
    {
      if ( v24 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v18 = *(_DWORD *)(v24 + 32);
      v17 = *(_DWORD *)(v24 + 36);
      if ( byte_8FFD1B2 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD1B2 = 1;
      }
      v19 = *(float *)&a7 * 100.0;
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v20 = vcvtps_s32_f32(v19);
      if ( ceilf(v19) == INFINITY )
        v21 = 0x80000000;
      else
        v21 = v20;
      v22 = 0u;
      GameModule_BattleGameSceneManager_RoleTargetFrameCacheKey___ctor((__int64)&v22, a2 & 1, v18, v17, v21);
      result = 1;
      *(_OWORD *)a3 = v22;
    }
    else
    {
      return 0;
    }
  }
  return result;
}
