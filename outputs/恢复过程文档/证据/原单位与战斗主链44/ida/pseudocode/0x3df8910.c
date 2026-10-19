__int64 __fastcall GameModule_BattleGameSceneManager__GetLegendaryUnitCount(__int64 a1, __int64 a2, __int64 a3)
{
  char v3; // w21
  __int64 Instance; // x0
  __int64 v7; // x8
  __int64 v8; // x20

  v3 = a3;
  if ( (byte_8FFD7CF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7CF = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance != 0 )
  {
    if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) == 0 )
      return 0;
    v7 = 544;
    if ( (v3 & 1) != 0 )
      v7 = 552;
    v8 = *(_QWORD *)(a1 + v7);
    if ( v8 != 0 )
    {
      if ( (System_Collections_Generic_Dictionary_object__int___ContainsKey(v8, a2, qword_8CFEA68) & 1) != 0 )
        return System_Collections_Generic_Dictionary_object__int___get_Item(v8, a2, qword_8CFEA98);
      return 0;
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
