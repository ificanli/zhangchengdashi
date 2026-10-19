__int64 __fastcall GameModule_BattleGameSceneManager__RemoveLegendaryUnit(
        GameModule_BattleGameSceneManager_o *a1,
        __int64 a2,
        __int64 a3)
{
  char v3; // w20
  __int64 Instance; // x0
  __int64 result; // x0
  __int64 v8; // x8
  __int64 v9; // x22
  int Item; // w0

  v3 = a3;
  if ( (byte_8FFD7CE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7CE = 1;
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
    v9 = *(__int64 *)((char *)&a1->klass + v8);
    if ( v9 != 0 )
    {
      result = System_Collections_Generic_Dictionary_object__int___ContainsKey(v9, a2, qword_8CFEA68);
      if ( (result & 1) != 0 )
      {
        Item = System_Collections_Generic_Dictionary_object__int___get_Item(v9, a2, qword_8CFEA98);
        System_Collections_Generic_Dictionary_object__int___set_Item(
          v9,
          a2,
          (Item - 1) & (unsigned int)~((Item - 1) >> 31),
          qword_8CFEAB0);
        if ( (unsigned int)System_Collections_Generic_Dictionary_object__int___get_Item(v9, a2, qword_8CFEA98) == 0 )
          System_Collections_Generic_Dictionary_object__int___Remove(v9, a2, qword_8CFEA78);
        return GameModule_BattleGameSceneManager__TrySpawnLegendaryFromWaitingBarracks(a1, a2, v3 & 1);
      }
      return result;
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
