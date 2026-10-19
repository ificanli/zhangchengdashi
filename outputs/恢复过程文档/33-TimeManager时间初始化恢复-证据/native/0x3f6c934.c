void TimeModuleO_TimeManager_Timer__Restart(
        void *self,
        __int64 duration,
        unsigned __int8 countdown,
        const MethodInfo *method)
{
  void *Instance; // x0
  __int64 NetworkTime; // x0
  __int64 v9; // x22
  _QWORD *v10; // x0
  int v11; // w8
  __int64 v12; // x0
  void *v13; // x0
  __int64 v14; // x0

  if ( (byte_8FFE381 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    byte_8FFE381 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12478);
  if ( Instance == nullptr )
    goto LABEL_14;
  NetworkTime = TimeModuleO_TimeManager__GetNetworkTime(Instance, *((unsigned __int8 *)self + 40), 0);
  *((_QWORD *)self + 3) = NetworkTime;
  v9 = NetworkTime;
  v10 = off_8CE6460;
  v11 = *((_DWORD *)off_8CE6460 + 56);
  if ( (countdown & 1) != 0 )
  {
    if ( v11 == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
    v12 = System_DateTime__op_Addition(v9, duration, 0);
  }
  else
  {
    if ( v11 == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE6460);
      v10 = off_8CE6460;
    }
    v12 = *(_QWORD *)(v10[23] + 24LL);
  }
  *((_QWORD *)self + 4) = v12;
  v13 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12478);
  if ( v13 == nullptr
    || (TimeModuleO_TimeManager__InitAddTimeInfo(v13, self, 0), (v14 = **((_QWORD **)off_8CD9258 + 23)) == 0) )
  {
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
  DbtSaveDataManagerBase_object__object___Save(v14, qword_8CFB3E0);
}
