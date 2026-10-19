__int64 __fastcall GameModule_BattleGameSceneManager_RoleTargetFrameCacheKey___ctor(
        __int64 result,
        char a2,
        int a3,
        int a4,
        int a5)
{
  *(_DWORD *)(result + 4) = a3;
  *(_DWORD *)(result + 8) = a4;
  *(_BYTE *)result = a2 & 1;
  *(_DWORD *)(result + 12) = a5;
  return result;
}
