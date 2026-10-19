bool __fastcall GameModule_SynergyEffectManager__UndeadFetter6(__int64 a1, char a2)
{
  if ( (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 1, a2 & 1) < 6 )
    return false;
  if ( *(_BYTE *)(a1 + 32) != 0 )
    return true;
  return (int)UnityEngine_Random__Range(0) < 10;
}
