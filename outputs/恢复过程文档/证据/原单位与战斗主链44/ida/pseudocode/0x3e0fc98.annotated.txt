bool __fastcall GameModule_SynergyEffectManager__OrcsFetter4_AttackSpeed(__int64 a1, int a2, int a3, char a4)
{
  int FetterCount; // w0
  _BOOL8 result; // x0

  result = false;
  if ( *(_BYTE *)(a1 + 32) != 0 )
  {
    FetterCount = GameModule_SynergyEffectManager__GetFetterCount(a1, 0, a4 & 1);
    if ( a3 >= 1 && FetterCount >= 4 && (float)((float)a2 / (float)a3) < 0.5 )
      return true;
  }
  return result;
}
