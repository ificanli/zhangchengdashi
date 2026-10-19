__int64 __fastcall GameModule_SynergyEffectManager__OrcsFetter6_BuildingDamage(__int64 a1, int a2, char a3, char a4)
{
  float v5; // s0
  int v6; // w8

  if ( *(_BYTE *)(a1 + 32) != 0
    && (a4 & 1) != 0
    && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 0, a3 & 1) >= 6 )
  {
    v5 = (float)a2 * 0.75;
    v6 = (int)v5;
    if ( v5 == INFINITY )
      v6 = 0x80000000;
    a2 += v6;
  }
  return (unsigned int)a2;
}
