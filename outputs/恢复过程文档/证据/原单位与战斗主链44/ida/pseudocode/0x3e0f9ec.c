long double __fastcall GameModule_SynergyEffectManager__UndeadFetter2(__int64 a1, char a2, long double a3)
{
  float v5; // s0

  if ( (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 1, a2 & 1) >= 2 )
  {
    if ( *(_BYTE *)(a1 + 32) != 0 )
      v5 = -0.2;
    else
      v5 = -0.1;
    *(float *)&a3 = *(float *)&a3 + (float)(*(float *)&a3 * v5);
  }
  return a3;
}
