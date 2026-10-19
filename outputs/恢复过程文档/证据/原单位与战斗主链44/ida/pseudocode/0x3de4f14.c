__int64 GameModule_BattleGameManager__GameSuccessGetTrophyNumber()
{
  _QWORD *Instance; // x0
  __int64 v1; // x8
  __int64 v2; // x19
  _QWORD *v3; // x0
  __int64 Item; // x0
  __int64 v5; // x19
  void *v6; // x0
  float v7; // s0
  int v8; // w8
  void *v9; // x20
  _QWORD *v10; // x0
  int v12; // [xsp+Ch] [xbp-24h] BYREF

  if ( (byte_8FFD739 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122F8);
    byte_8FFD739 = 1;
  }
  v12 = 0;
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance != nullptr )
  {
    v1 = Instance[5];
    if ( v1 != 0 )
    {
      v2 = *(_QWORD *)(v1 + 184);
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      v3 = off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v3 = off_8CE5E20;
      }
      if ( v2 != 0 )
      {
        Item = System_Collections_Generic_Dictionary_object__object___get_Item(
                 v2,
                 *(_QWORD *)(v3[23] + 8LL),
                 qword_8CFE650);
        if ( Item != 0 )
        {
          v5 = *(_QWORD *)(Item + 24);
          v6 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D122F8);
          if ( v6 != nullptr )
          {
            if ( (GameModule_MonthlyPassManager__HadBuyMonthPass(v6, 0) & 1) != 0 )
            {
              v7 = (float)(int)ToolModule_StringTool__ToInt(v5, 0) * 1.2;
              v8 = (int)v7;
              if ( v7 == INFINITY )
                v8 = 0x80000000;
              v12 = v8;
              v5 = System_Int32__ToString(&v12, 0);
            }
            v9 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FD8);
            if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5E20);
            if ( byte_8FFD3A7 == 0 )
            {
              il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
              byte_8FFD3A7 = 1;
            }
            v10 = off_8CE5E20;
            if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(off_8CE5E20);
              v10 = off_8CE5E20;
            }
            if ( v9 != nullptr )
            {
              GameModule_ArenaManager__GetArenaIsCollectAllTrophy(v9, *(_QWORD *)(v10[23] + 8LL), 0);
              return v5;
            }
          }
        }
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
