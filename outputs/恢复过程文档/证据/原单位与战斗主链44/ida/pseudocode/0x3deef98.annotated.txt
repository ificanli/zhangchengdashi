void GameModule_BattleGameSceneManager__GoldMineCountLimitRecordHexCreat(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  int v2; // w8

  v2 = *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[412] - 1;
  if ( v2 >= 100 )
    v2 = 100;
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[412] = v2 & ~(v2 >> 31);
}
