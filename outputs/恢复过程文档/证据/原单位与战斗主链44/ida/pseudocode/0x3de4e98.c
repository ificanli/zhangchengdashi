void __fastcall GameModule_BattleGameManager__GameEndRewardUser(__int64 a1, __int64 a2)
{
  void *Instance; // x0

  if ( (byte_8FFD738 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123F0);
    byte_8FFD738 = 1;
  }
  if ( *(_DWORD *)(a1 + 240) <= 3u )
  {
    if ( a2 != 0 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D123F0);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_RewardManager__RewardUser(Instance, a2, 0);
      *(_QWORD *)(a1 + 192) = a2;
      *(_QWORD *)(a1 + 200) = a2;
    }
    else
    {
      *(_QWORD *)(a1 + 192) = 0;
      *(_QWORD *)(a1 + 200) = 0;
    }
  }
}
