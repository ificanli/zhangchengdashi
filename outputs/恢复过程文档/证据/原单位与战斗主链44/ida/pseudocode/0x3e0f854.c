__int64 __fastcall GameModule_SynergyEffectManager__HumanFetter2_BuildingHp(__int64 a1, int a2, char a3)
{
  float v4; // s0
  int v5; // w8

  if ( *(_BYTE *)(a1 + 32) != 0 && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 2, a3 & 1) >= 2 )
  {
    v4 = (float)a2 * 0.5;
    v5 = (int)v4;
    if ( v4 == INFINITY )
      v5 = 0x80000000;
    a2 += v5;
  }
  return (unsigned int)a2;
}
