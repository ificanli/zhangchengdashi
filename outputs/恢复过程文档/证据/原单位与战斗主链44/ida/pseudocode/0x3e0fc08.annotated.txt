__int64 __fastcall GameModule_SynergyEffectManager__OrcsFetter6(__int64 result, char a2)
{
  if ( *(_BYTE *)(result + 32) == 0 )
    return GameModule_SynergyEffectManager__GetFetterCount(result, 0, a2 & 1);
  return result;
}
