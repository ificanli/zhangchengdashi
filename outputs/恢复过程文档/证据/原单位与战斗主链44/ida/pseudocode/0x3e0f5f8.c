__int64 __fastcall GameModule_SynergyEffectManager__GetAtkWayTypeCount(__int64 a1, int a2, char a3)
{
  unsigned int *Instance; // x0
  unsigned int *v7; // x0
  unsigned int *v8; // x0
  unsigned int *v9; // x0

  if ( (byte_8FFD855 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12138);
    byte_8FFD855 = 1;
  }
  if ( (a3 & 1) != 0 )
  {
    if ( a2 != 0 )
    {
      if ( a2 == 1 )
      {
        Instance = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
        if ( Instance != nullptr )
          return Instance[53];
LABEL_17:
        il2cpp_codegen_raise_null_reference_exception();
      }
      return 0;
    }
    v8 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
    if ( v8 == nullptr )
      goto LABEL_17;
    return v8[52];
  }
  else if ( a2 != 0 )
  {
    if ( a2 != 1 )
      return 0;
    v7 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
    if ( v7 == nullptr )
      goto LABEL_17;
    return v7[24];
  }
  else
  {
    v9 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
    if ( v9 == nullptr )
      goto LABEL_17;
    return v9[23];
  }
}
