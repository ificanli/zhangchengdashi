__int64 __fastcall GameModule_BattleGameSceneManager__Init(__int64 a1)
{
  _DWORD v3[6]; // [xsp+0h] [xbp-60h] BYREF
  __int64 v4; // [xsp+18h] [xbp-48h]
  __int128 v5; // [xsp+20h] [xbp-40h]
  __int64 v6; // [xsp+30h] [xbp-30h]

  if ( (byte_8FFD76F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1FE70);
    byte_8FFD76F = 1;
  }
  v6 = 0;
  memset(v3, 0, sizeof(v3));
  v5 = 0u;
  v4 = a1;
  v3[0] = -1;
  if ( *((_QWORD *)off_8D1FE70 + 7) == 0 )
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1FE70);
  GameModule_BattleGameSceneManager__Init_d__129__MoveNext((__int64)v3);
  return ((__int64 (__fastcall *)(_DWORD *, _QWORD))unk_3D17780)(&v3[2], 0);
}
