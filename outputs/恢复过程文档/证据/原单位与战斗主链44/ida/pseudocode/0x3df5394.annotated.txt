GameModule_HexBehaviour_o *GameModule_BattleGameSceneManager__GetMainTowerForwardHex(
        GameModule_BattleGameSceneManager_o *this,
        bool isEnemy,
        const MethodInfo *method)
{
  _BOOL4 v3; // w19
  __int64 v4; // x8
  __int64 DesignatedKeyHex; // x0

  if ( this == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v3 = isEnemy;
  v4 = 352;
  if ( isEnemy )
    v4 = 344;
  DesignatedKeyHex = GameModule_BattleGameSceneManager__GetDesignatedKeyHex(
                       this,
                       *(GameModule_BattleGameSceneManager_c **)((char *)&this->klass + v4),
                       method);
  return GameModule_BattleGameSceneManager__FindTopMostObject(DesignatedKeyHex, DesignatedKeyHex, v3);
}
