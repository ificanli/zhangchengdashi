__int64 __fastcall GameModule_BattleGameSceneManager__CacheNearestRoleTarget(
        __int64 a1,
        char a2,
        __int64 a3,
        long double a4,
        long double a5,
        long double a6,
        long double a7)
{
  __int64 result; // x0
  const MethodInfo *v15; // x1
  __int64 v16; // x0
  __int64 v17; // [xsp+0h] [xbp-60h] BYREF
  __int64 v18; // [xsp+8h] [xbp-58h]

  if ( (byte_8FFD79A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00A40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD79A = 1;
  }
  v17 = 0;
  v18 = 0;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Equality(a3, 0, 0);
  if ( (result & 1) == 0 )
  {
    GameModule_BattleGameSceneManager__PrepareRoleTargetFrameCache((GameModule_BattleGameSceneManager_o *)a1, v15);
    result = GameModule_BattleGameSceneManager__TryGetRoleTargetFrameCacheKey(a1, a2 & 1, &v17, a4, a5, a6, a7);
    if ( (result & 1) != 0 )
    {
      v16 = *(_QWORD *)(a1 + 80);
      if ( v16 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      return System_Collections_Generic_Dictionary_BattleGameSceneManager_RoleTargetFrameCacheKey__BattleGameSceneManager_RoleTargetFrameCacheValue___set_Item(
               v16,
               v17,
               v18,
               a3,
               qword_8D00A40);
    }
  }
  return result;
}
