__int64 __fastcall GameModule_BattleGameManager__OnPauseGame(__int64 result)
{
  if ( *(_BYTE *)(result + 218) != 1 )
  {
    *(_BYTE *)(result + 218) = 1;
    return GameModule_BattleGameManager__ApplyAnimationPauseToAllRoles();
  }
  return result;
}
