void GameModule_BattleGameSceneManager__UpdateAllGoldMinePrices(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 Instance; // x0
  __int64 v5; // x0
  __int64 v6; // x19
  __int64 ArchitectureInfoId; // x0
  __int64 v8; // x3
  __int128 v9; // [xsp+8h] [xbp-68h] BYREF
  __int64 v10; // [xsp+18h] [xbp-58h]
  __int128 v11; // [xsp+20h] [xbp-50h] BYREF
  __int64 v12; // [xsp+30h] [xbp-40h]

  if ( (byte_8FFD787 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B500);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536B8);
    byte_8FFD787 = 1;
  }
  v11 = 0u;
  v12 = 0;
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, method, v2);
  if ( Instance == 0 )
    goto LABEL_20;
  if ( (SDKModule_ABTestManager__get_GoldMinePriceV2IsBTest(Instance, 0) & 1) == 0 )
    return;
  v5 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[112];
  if ( v5 == 0 )
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_List_object___GetEnumerator(&v9, v5, qword_8D0B500);
  v11 = v9;
  v12 = v10;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v11, qword_8D02178) & 1) != 0 )
  {
    v6 = v12;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v6, 0, 0) & 1) == 0 )
    {
      if ( v6 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( GameModule_HexBehaviour__get_ArchitectureInfoId(v6, 0) != 0 )
      {
        ArchitectureInfoId = GameModule_HexBehaviour__get_ArchitectureInfoId(v6, 0);
        if ( (System_String__op_Equality(ArchitectureInfoId, qword_8D536B8, 0, v8) & 1) != 0 )
          GameModule_HexBehaviour__RefreshSubGameInflationPrice(v6, 0);
      }
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v11, qword_8D02170);
}
