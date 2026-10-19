System_Collections_Generic_List_RoleBehaviour__o *GameModule_BattleGameSceneManager__GetRoleTargetList(
        GameModule_BattleGameSceneManager_o *this,
        bool sourceIsEnemy,
        const MethodInfo *method)
{
  __int64 v3; // x8

  v3 = 192;
  if ( sourceIsEnemy )
    v3 = 200;
  return *(GameModule_BattleGameSceneManager_c **)((char *)&this->klass + v3);
}
