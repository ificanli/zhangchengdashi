__int64 __fastcall GameModule_RoleBehaviour__GetNearOneMTeamMate(__int64 a1)
{
  void *Instance; // x0

  if ( (byte_8FFD464 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    byte_8FFD464 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
  if ( Instance == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  return GameModule_BattleGameSceneManager__GetNearRole((__int64)Instance, *(_BYTE *)(a1 + 32), a1, -1, 1.0);
}
