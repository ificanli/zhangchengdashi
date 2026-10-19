__int64 __fastcall GameModule_BattleGameSceneManager_RoleTargetFrameCacheKey__GetHashCode(__int64 a1)
{
  int v1; // w8

  if ( *(_BYTE *)a1 != 0 )
    v1 = 157609;
  else
    v1 = 0;
  return (397 * ((397 * ((unsigned int)v1 ^ *(_DWORD *)(a1 + 4))) ^ *(_DWORD *)(a1 + 8))) ^ *(_DWORD *)(a1 + 12);
}
