bool __fastcall GameModule_SynergyEffectManager__HumanFetter6_GoldPerSecond(__int64 a1, char a2)
{
  return *(_BYTE *)(a1 + 32) != 0 && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 2, a2 & 1) > 5;
}
