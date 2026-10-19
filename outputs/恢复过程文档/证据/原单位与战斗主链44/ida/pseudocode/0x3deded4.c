// local variable allocation has failed, the output may be wrong!
void GameModule_BattleGameSceneManager__TickWebGLNavigation(
        GameModule_BattleGameSceneManager_o *this,
        float deltaTime,
        const MethodInfo *method)
{
  long double v3; // q8
  const MethodInfo *v5; // x1
  __int64 v6; // x0

  v3 = *(long double *)&deltaTime;
  if ( (byte_8FFD772 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    byte_8FFD772 = 1;
  }
  if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4A38);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    GameModule_BattleGameSceneManager__EnsureWebGLNavigationManager(this, v5);
    v6 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[304];
    if ( v6 != 0 )
      GameModule_WebGLNavigationManager__Tick(v6, 0, v3);
  }
}
