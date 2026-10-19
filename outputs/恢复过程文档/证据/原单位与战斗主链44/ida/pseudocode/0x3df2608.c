void GameModule_BattleGameSceneManager__PrepareRoleTargetFrameCache(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  int frameCount; // w0
  __int64 v4; // x8

  if ( (byte_8FFD797 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00A28);
    byte_8FFD797 = 1;
  }
  frameCount = UnityEngine_Time__get_frameCount(0, method);
  if ( *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[72] != frameCount )
  {
    v4 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[64];
    *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[72] = frameCount;
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_BattleGameSceneManager_RoleTargetFrameCacheKey__BattleGameSceneManager_RoleTargetFrameCacheValue___Clear(
      v4,
      qword_8D00A28);
  }
}
