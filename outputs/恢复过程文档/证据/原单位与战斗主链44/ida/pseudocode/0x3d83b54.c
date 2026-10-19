bool __fastcall GameModule_RoleBehaviour__IsAiMovementBlockedByState(_BYTE *a1)
{
  void *Instance; // x19
  void *v4; // x0
  __int64 v5; // x2

  if ( (byte_8FFD468 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD468 = 1;
  }
  if ( a1[636] != 0 || a1[637] != 0 || a1[33] != 0 || a1[224] != 0 || a1[404] != 0 )
    return true;
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) == 0 )
    return false;
  v4 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
  if ( v4 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  return GameModule_BattleGameManager__get_IsGamePaused((__int64)v4, 0, v5);
}
