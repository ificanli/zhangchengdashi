bool __fastcall GameModule_BattleGameSceneManager_RoleTargetFrameCacheKey__Equals(__int64 a1, __int64 a2, __int64 a3)
{
  return (a2 & 1) == *(_BYTE *)a1
      && *(_QWORD *)(a1 + 4) == __PAIR64__(a3, HIDWORD(a2))
      && *(_DWORD *)(a1 + 12) == HIDWORD(a3);
}
