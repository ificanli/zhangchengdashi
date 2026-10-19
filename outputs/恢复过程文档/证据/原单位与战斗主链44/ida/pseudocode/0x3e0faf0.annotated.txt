bool __fastcall GameModule_SynergyEffectManager__UndeadFetter4_Revive(__int64 a1, char a2)
{
  return *(_BYTE *)(a1 + 32) != 0
      && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 1, a2 & 1) >= 4
      && (int)UnityEngine_Random__Range(0) < 10;
}
