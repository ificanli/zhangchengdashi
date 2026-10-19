__int64 __fastcall GameModule_BattleGameSceneManager__LoadMapGround(__int64 a1, int a2)
{
  __int128 v5; // [xsp+0h] [xbp-70h] BYREF
  __int64 v6; // [xsp+10h] [xbp-60h]
  __int64 v7; // [xsp+18h] [xbp-58h]
  __int128 v8; // [xsp+20h] [xbp-50h]
  __int64 v9; // [xsp+30h] [xbp-40h]

  if ( (byte_8FFD77F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1FE78);
    byte_8FFD77F = 1;
  }
  v9 = 0;
  v6 = 0;
  v8 = 0u;
  v5 = 0u;
  v7 = a1;
  LODWORD(v8) = a2;
  LODWORD(v5) = -1;
  if ( *((_QWORD *)off_8D1FE78 + 7) == 0 )
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1FE78);
  GameModule_BattleGameSceneManager__LoadMapGround_d__147__MoveNext((__int64)&v5);
  return ((__int64 (__fastcall *)(char *, _QWORD))unk_3D17780)((char *)&v5 + 8, 0);
}
