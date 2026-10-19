long double __fastcall GameModule_SynergyEffectManager__OrcsFetter2_MoveSpeed(__int64 a1, char a2, long double a3)
{
  if ( *(_BYTE *)(a1 + 32) != 0 && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 0, a2 & 1) >= 2 )
    *(float *)&a3 = (float)(*(float *)&a3 * 0.2) + *(float *)&a3;
  return a3;
}
