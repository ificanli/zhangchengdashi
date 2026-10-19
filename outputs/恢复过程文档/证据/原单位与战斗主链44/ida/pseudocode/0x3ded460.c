bool GameModule_BattleGameSceneManager__LegendaryTileV1QualityTierOk(
        int32_t q,
        int32_t tierMin,
        const MethodInfo *method)
{
  bool v4; // cf

  if ( q == 3 )
    return false;
  switch ( tierMin )
  {
    case 1:
      v4 = (unsigned int)q >= 3;
      break;
    case 2:
      v4 = (unsigned int)(q - 1) >= 2;
      break;
    case 3:
      return q == 2;
    default:
      return false;
  }
  return !v4;
}
