__int64 __fastcall GameModule_SynergyEffectManager__GetFetterCount(__int64 a1, int a2, char a3)
{
  unsigned int *Instance; // x0
  __int64 result; // x0
  unsigned int *v7; // x0
  unsigned int *v8; // x0
  unsigned int *v9; // x0
  unsigned int *v10; // x0
  unsigned int *v11; // x0
  unsigned int *v12; // x0
  unsigned int *v13; // x0

  if ( (byte_8FFD854 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12138);
    byte_8FFD854 = 1;
  }
  if ( (a3 & 1) != 0 )
  {
    switch ( a2 )
    {
      case 0:
        Instance = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
        if ( Instance == nullptr )
          goto LABEL_23;
        result = Instance[49];
        break;
      case 1:
        v10 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
        if ( v10 == nullptr )
          goto LABEL_23;
        result = v10[50];
        break;
      case 2:
        v8 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
        if ( v8 == nullptr )
          goto LABEL_23;
        result = v8[51];
        break;
      case 3:
        v11 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
        if ( v11 == nullptr )
          goto LABEL_23;
        result = v11[54];
        break;
      default:
        goto LABEL_10;
    }
  }
  else
  {
    switch ( a2 )
    {
      case 0:
        v7 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
        if ( v7 == nullptr )
          goto LABEL_23;
        result = v7[20];
        break;
      case 1:
        v12 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
        if ( v12 == nullptr )
          goto LABEL_23;
        result = v12[21];
        break;
      case 2:
        v9 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
        if ( v9 == nullptr )
          goto LABEL_23;
        result = v9[22];
        break;
      case 3:
        v13 = (unsigned int *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12138);
        if ( v13 == nullptr )
LABEL_23:
          il2cpp_codegen_raise_null_reference_exception();
        result = v13[25];
        break;
      default:
LABEL_10:
        result = 0;
        break;
    }
  }
  return result;
}
