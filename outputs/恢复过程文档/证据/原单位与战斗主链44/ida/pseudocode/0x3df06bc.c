__int64 __fastcall sub_3DF06BC(
        __int64 a1,
        unsigned __int8 a2,
        _QWORD *a3,
        long double a4,
        long double a5,
        long double a6,
        long double a7)
{
  long double v7; // q12
  __int64 v15; // x8
  __int64 v16; // x22
  __int64 result; // x0
  _BYTE v18[4]; // [xsp+Ch] [xbp-54h] BYREF

  if ( (byte_8FFD792 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    byte_8FFD792 = 1;
  }
  v15 = 192;
  v18[0] = 0;
  *a3 = 0;
  if ( (a2 & 1) != 0 )
    v15 = 200;
  v16 = *(_QWORD *)(a1 + v15);
  if ( v16 == 0 )
    return 0;
  result = 0;
  if ( *(float *)&a7 >= 0.0 && *(_DWORD *)(v16 + 24) != 0 )
  {
    *(float *)&v7 = *(float *)&a7 * *(float *)&a7;
    if ( (GameModule_BattleGameSceneManager__TryGetCachedNearestRoleTarget(a1, a2 & 1, a3, a4, a5, a6, a7, v7) & 1) == 0 )
    {
      if ( (GameModule_BattleGameSceneManager__TryGetNearestRoleTargetFromHexRing(
              a1,
              (a2 ^ 1) & 1,
              a3,
              v18,
              a4,
              a5,
              a6,
              a7,
              v7)
          & 1) == 0 )
      {
        if ( v18[0] != 0 )
          return 0;
        if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE4A38);
        if ( (GameModule_BattleGameSceneManager__TryGetNearestRoleTargetFromList(v16, a3, a4, a5, a6, v7) & 1) == 0 )
          return 0;
      }
      GameModule_BattleGameSceneManager__CacheNearestRoleTarget(a1, a2 & 1, *a3, a4, a5, a6, a7);
    }
    return 1;
  }
  return result;
}
