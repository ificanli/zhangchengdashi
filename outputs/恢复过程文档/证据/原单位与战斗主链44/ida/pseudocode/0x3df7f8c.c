bool __fastcall GameModule_BattleGameSceneManager__CanSpawnLegendaryUnit(__int64 a1, __int64 a2, __int64 a3)
{
  char v3; // w21
  __int64 Instance; // x0
  unsigned int v7; // w21
  int LegendaryUnitCount; // w22

  v3 = a3;
  if ( (byte_8FFD7D1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7D1 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) == 0 )
    return true;
  v7 = v3 & 1;
  LegendaryUnitCount = GameModule_BattleGameSceneManager__GetLegendaryUnitCount(a1, a2, v7);
  return LegendaryUnitCount < (int)GameModule_BattleGameSceneManager__GetLegendaryBarracksCount(a1, a2, v7);
}
