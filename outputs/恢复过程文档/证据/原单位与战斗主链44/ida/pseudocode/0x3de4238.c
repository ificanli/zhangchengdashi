void GameModule_BattleGameManager__GetMinutesSinceInstall()
{
  __int64 v0; // x8
  __int64 v1; // x8
  __int64 v2; // x19
  void *Instance; // x0
  __int64 v4; // x19
  __int64 v5; // x20
  __int64 v6; // [xsp+8h] [xbp-38h] BYREF
  __int64 NetworkTime; // [xsp+10h] [xbp-30h] BYREF
  __int64 v8; // [xsp+18h] [xbp-28h] BYREF

  if ( (byte_8FFD733 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB268);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE590);
    byte_8FFD733 = 1;
  }
  NetworkTime = 0;
  v8 = 0;
  v6 = 0;
  v0 = **((_QWORD **)off_8CD9218 + 23);
  if ( v0 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v1 = *(_QWORD *)(v0 + 48);
  if ( v1 != 0 )
  {
    v2 = *(_QWORD *)(v1 + 24);
    v8 = v2;
    if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
    if ( (System_DateTime__op_Equality(v2, 0, 0) & 1) == 0 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12478);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      NetworkTime = TimeModuleO_TimeManager__GetNetworkTime(Instance, 0, nullptr);
      if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6460);
      if ( (unsigned int)System_DateTime__get_Kind(&v8, 0) == 1 )
      {
        v4 = v8;
      }
      else
      {
        if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE6460);
        v4 = System_DateTime__ToUniversalTime(&v8, 0);
      }
      if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6460);
      if ( (unsigned int)System_DateTime__get_Kind(&NetworkTime, 0) == 1 )
      {
        v5 = NetworkTime;
      }
      else
      {
        if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE6460);
        v5 = System_DateTime__ToUniversalTime(&NetworkTime, 0);
      }
      if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6460);
      v6 = System_DateTime__op_Subtraction(v5, v4, 0);
      if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEE590);
      System_TimeSpan__get_TotalMinutes(&v6, 0);
    }
  }
}
