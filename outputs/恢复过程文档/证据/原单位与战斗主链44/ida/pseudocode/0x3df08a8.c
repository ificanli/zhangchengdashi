__int64 __fastcall sub_3DF08A8(
        __int64 a1,
        char a2,
        __int64 a3,
        long double a4,
        long double a5,
        long double a6,
        long double a7)
{
  long double v7; // q12
  int v15; // w2
  int v16; // w8
  __int64 v17; // x8
  __int64 v18; // x22
  __int64 result; // x0
  _BYTE v20[4]; // [xsp+Ch] [xbp-54h] BYREF

  if ( (byte_8FFD794 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0DD90);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    byte_8FFD794 = 1;
  }
  v20[0] = 0;
  if ( a3 == 0 )
    return 0;
  v15 = *(_DWORD *)(a3 + 24);
  v16 = *(_DWORD *)(a3 + 28) + 1;
  *(_DWORD *)(a3 + 24) = 0;
  *(_DWORD *)(a3 + 28) = v16;
  if ( v15 >= 1 )
    System_Array__Clear(*(_QWORD *)(a3 + 16), 0);
  v17 = 192;
  if ( (a2 & 1) != 0 )
    v17 = 200;
  v18 = *(_QWORD *)(a1 + v17);
  if ( v18 == 0 )
    return 0;
  result = 0;
  if ( *(float *)&a7 >= 0.0 && *(_DWORD *)(v18 + 24) != 0 )
  {
    *(float *)&v7 = *(float *)&a7 * *(float *)&a7;
    if ( (GameModule_BattleGameSceneManager__TryCollectRoleTargetsInRangeFromHexRing(
            a1,
            (a2 & 1) == 0,
            a3,
            v20,
            a4,
            a5,
            a6,
            a7,
            v7)
        & 1) != 0
      || v20[0] != 0 )
    {
      return *(unsigned int *)(a3 + 24);
    }
    else
    {
      if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4A38);
      return GameModule_BattleGameSceneManager__CollectRoleTargetsInRangeFromList(v18, a3, a4, a5, a6, v7);
    }
  }
  return result;
}
