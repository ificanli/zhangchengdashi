void GameModule_GameManager__DanChangeUpdateInfo(void *self, void *obj, const MethodInfo *method)
{
  __int64 Instance; // x0

  if ( (byte_8FFD899 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123B0);
    byte_8FFD899 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D123B0, obj, method);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameModule_RankManager__UpdateRankInfo(Instance, 0);
}
