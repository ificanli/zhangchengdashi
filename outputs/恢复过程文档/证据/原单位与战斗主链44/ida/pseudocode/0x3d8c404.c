__int64 __fastcall GameModule_RoleBehaviour__MeleeInitInfo(__int64 a1)
{
  __int64 v2; // x21
  void *Instance; // x0
  __int64 v4; // x8
  int v5; // w0
  void *v6; // x0
  __int64 v7; // x8
  __int64 result; // x0
  __int64 v9; // x8

  if ( (byte_8FFD49F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12460);
    byte_8FFD49F = 1;
  }
  v2 = *(_QWORD *)(a1 + 64);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12460);
  v4 = *(_QWORD *)(a1 + 64);
  if ( v4 == 0
    || Instance == nullptr
    || (v5 = GameModule_SynergyEffectManager__MeleeFetter5(
               Instance,
               *(unsigned int *)(v4 + 32),
               *(unsigned __int8 *)(a1 + 32),
               0),
        v2 == 0)
    || (*(_DWORD *)(v2 + 32) = v5,
        v6 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12460),
        (v7 = *(_QWORD *)(a1 + 64)) == 0)
    || v6 == nullptr
    || (result = GameModule_SynergyEffectManager__MeleeFetter7(
                   v6,
                   *(unsigned int *)(v7 + 24),
                   *(unsigned __int8 *)(a1 + 32),
                   0),
        (v9 = *(_QWORD *)(a1 + 64)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( (_DWORD)result != *(_DWORD *)(v9 + 24) )
  {
    *(_DWORD *)(v9 + 24) = result;
    *(_DWORD *)(v9 + 28) = result;
  }
  return result;
}
