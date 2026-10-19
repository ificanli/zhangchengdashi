__int64 __fastcall GameModule_BattleGameManager__SetGamePaused(__int64 result, char a2)
{
  int v2; // w1

  v2 = a2 & 1;
  if ( *(unsigned __int8 *)(result + 218) != v2 )
  {
    *(_BYTE *)(result + 218) = v2;
    return GameModule_BattleGameManager__ApplyAnimationPauseToAllRoles();
  }
  return result;
}
