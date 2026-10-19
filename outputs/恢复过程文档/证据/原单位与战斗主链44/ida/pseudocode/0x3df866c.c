__int64 __fastcall GameModule_BattleGameSceneManager__AddLegendaryUnit(__int64 a1, __int64 a2, __int64 a3)
{
  char v3; // w21
  __int64 Instance; // x0
  __int64 result; // x0
  __int64 v8; // x8
  __int64 v9; // x20
  __int64 v10; // x2

  v3 = a3;
  if ( (byte_8FFD7CD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7CD = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance != 0 )
  {
    result = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0);
    if ( (result & 1) == 0 )
      return result;
    v8 = 544;
    if ( (v3 & 1) != 0 )
      v8 = 552;
    v9 = *(_QWORD *)(a1 + v8);
    if ( v9 != 0 )
    {
      if ( (System_Collections_Generic_Dictionary_object__int___ContainsKey(v9, a2, qword_8CFEA68) & 1) != 0 )
        v10 = (unsigned int)System_Collections_Generic_Dictionary_object__int___get_Item(v9, a2, qword_8CFEA98) + 1;
      else
        v10 = 1;
      return System_Collections_Generic_Dictionary_object__int___set_Item(v9, a2, v10, qword_8CFEAB0);
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
