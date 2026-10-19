__int64 __fastcall GameModule_BattleGameManager__OnResumeGame(__int64 result)
{
  if ( *(_BYTE *)(result + 218) != 0 )
  {
    *(_BYTE *)(result + 218) = 0;
    return GameModule_BattleGameManager__ApplyAnimationPauseToAllRoles();
  }
  return result;
}
