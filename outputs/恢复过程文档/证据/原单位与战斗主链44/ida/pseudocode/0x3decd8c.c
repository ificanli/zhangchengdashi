__int64 __fastcall GameModule_BattleGameSceneManager__GetMainTowerHexCoord(__int64 a1, char a2)
{
  __int64 v4; // x8
  __int64 DesignatedKeyHex; // x19
  __int64 v6; // x1
  __int64 v8; // [xsp+0h] [xbp-30h] BYREF
  int v9; // [xsp+8h] [xbp-28h]

  if ( (byte_8FFD7AE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D15DC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7AE = 1;
  }
  if ( a1 != 0 )
  {
    v4 = 352;
    if ( (a2 & 1) != 0 )
      v4 = 344;
    DesignatedKeyHex = GameModule_BattleGameSceneManager__GetDesignatedKeyHex(a1, *(_QWORD *)(a1 + v4));
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(DesignatedKeyHex, 0, 0) & 1) == 0 )
    {
      v9 = 0;
      return 0;
    }
    if ( DesignatedKeyHex != 0 )
    {
      v6 = *(_QWORD *)(DesignatedKeyHex + 32);
      v9 = 0;
      v8 = 0;
      System_Nullable_HexManager_HexCoord____ctor(&v8, v6, qword_8D15DC0);
      return v8;
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
