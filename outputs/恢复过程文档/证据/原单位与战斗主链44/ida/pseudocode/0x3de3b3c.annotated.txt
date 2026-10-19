__int64 __fastcall GameModule_BattleGameManager__set_IsGamePaused(__int64 result, char a2)
{
  *(_BYTE *)(result + 218) = a2 & 1;
  return result;
}
