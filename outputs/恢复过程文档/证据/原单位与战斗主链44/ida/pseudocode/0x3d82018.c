bool __fastcall GameModule_RoleBehaviour__TryGetAstarRemainingPath(__int64 a1, __int64 a2)
{
  int v4; // w8
  __int64 v5; // x21
  __int64 v7; // x0
  _BYTE v8[4]; // [xsp+Ch] [xbp-24h] BYREF

  if ( (byte_8FFD492 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0F7D8);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F830);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD492 = 1;
  }
  if ( a2 == 0 )
    return false;
  v4 = *(_DWORD *)(a2 + 28) + 1;
  *(_DWORD *)(a2 + 24) = 0;
  *(_DWORD *)(a2 + 28) = v4;
  if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v5 = *(_QWORD *)(a1 + 128);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v5, 0, 0) & 1) == 0 )
    {
      v8[0] = 0;
      v7 = *(_QWORD *)(a1 + 128);
      if ( v7 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      Pathfinding_FollowerEntity__GetRemainingPath(v7, a2, v8, 0);
      return *(_DWORD *)(a2 + 24) > 0;
    }
    return false;
  }
  if ( (GameModule_WebGLNavigationManager__TryGetRemainingPath(a1, a2, 32, 0) & 1) == 0 )
    return false;
  return *(_DWORD *)(a2 + 24) > 0;
}
