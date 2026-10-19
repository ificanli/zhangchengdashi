long double __fastcall GameModule_SynergyEffectManager__HumanFetter2(__int64 a1, char a2, long double a3)
{
  if ( *(_BYTE *)(a1 + 32) == 0 && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 2, a2 & 1) >= 2 )
    *(float *)&a3 = *(float *)&a3 + (float)(*(float *)&a3 * -0.1);
  return a3;
}
