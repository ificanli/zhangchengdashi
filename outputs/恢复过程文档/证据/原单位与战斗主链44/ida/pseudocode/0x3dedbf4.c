int32_t GameModule_BattleGameSceneManager__GetRareLevelValue(
        GameModule_BattleGameSceneManager_o *this,
        int32_t rareLevel,
        const MethodInfo *method)
{
  if ( (unsigned int)rareLevel > 3 )
    return 0;
  else
    return rareLevel + 1;
}
