__int64 __fastcall GameModule_SynergyEffectManager__MeleeFetter7(__int64 a1, int a2, char a3)
{
  float v4; // s0
  int v5; // w8

  if ( (int)GameModule_SynergyEffectManager__GetAtkWayTypeCount(a1, 0, a3 & 1) >= 7 )
  {
    v4 = (float)a2 * 0.2;
    v5 = (int)v4;
    if ( v4 == INFINITY )
      v5 = 0x80000000;
    a2 += v5;
  }
  return (unsigned int)a2;
}
