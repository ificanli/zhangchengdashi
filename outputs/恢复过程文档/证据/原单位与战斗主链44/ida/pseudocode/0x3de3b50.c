__int64 __fastcall GameModule_BattleGameManager__Init(
        __int64 a1,
        __int64 a2,
        __int64 a3,
        __int64 a4,
        __int64 a5,
        __int64 a6)
{
  _DWORD v8[6]; // [xsp+0h] [xbp-50h] BYREF
  __int64 v9; // [xsp+18h] [xbp-38h]
  __int128 v10; // [xsp+20h] [xbp-30h]

  if ( (byte_8FFD72D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1FE68);
    byte_8FFD72D = 1;
  }
  memset(v8, 0, sizeof(v8));
  v10 = 0u;
  v9 = a1;
  v8[0] = -1;
  if ( *((_QWORD *)off_8D1FE68 + 7) == 0 )
    ((void (__fastcall *)(void *, __int64, __int64, __int64, __int64, __int64))unk_3C503FC)(
      off_8D1FE68,
      a2,
      a3,
      a4,
      a5,
      a6);
  GameModule_BattleGameManager__Init_d__43__MoveNext((__int64)v8);
  return ((__int64 (__fastcall *)(_DWORD *, _QWORD))unk_3D17780)(&v8[2], 0);
}
