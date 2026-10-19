void GameModule_BattleGameSceneManager__MarkWebGLNavigationAllFieldsDirty(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  const MethodInfo *v3; // x1
  __int64 v4; // x0

  if ( (byte_8FFD774 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    byte_8FFD774 = 1;
  }
  if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4A38);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    GameModule_BattleGameSceneManager__EnsureWebGLNavigationManager(this, v3);
    v4 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[304];
    if ( v4 != 0 )
      GameModule_WebGLNavigationManager__MarkAllPathFieldsDirty(v4, 0);
  }
}
