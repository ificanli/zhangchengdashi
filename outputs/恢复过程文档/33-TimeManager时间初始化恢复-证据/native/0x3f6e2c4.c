unsigned __int8 TimeModuleO_TimeManager_Timer__IsCompleted(void *self, const MethodInfo *method)
{
  void *Instance; // x0
  __int64 NetworkTime; // x0
  __int64 v5; // x19
  __int64 v6; // x20

  if ( (byte_8FFE389 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    byte_8FFE389 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12478);
  if ( Instance == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  NetworkTime = TimeModuleO_TimeManager__GetNetworkTime(Instance, *((_BYTE *)self + 40), nullptr);
  v5 = *((_QWORD *)self + 4);
  v6 = NetworkTime;
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  return System_DateTime__op_GreaterThanOrEqual(v6, v5, 0);
}
