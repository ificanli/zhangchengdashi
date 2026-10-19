void TimeModuleO_TimeManager__SaveLastExitTime(void *self, const MethodInfo *method)
{
  __int64 LocalNetworkTime; // x0
  _QWORD **v4; // x8
  __int64 v5; // x9
  __int64 v6; // x9
  __int64 v7; // x0

  if ( (byte_8FFD9EE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    byte_8FFD9EE = 1;
  }
  LocalNetworkTime = TimeModuleO_TimeManager__GetLocalNetworkTime(self, method);
  v4 = (_QWORD **)off_8CD9258;
  v5 = **((_QWORD **)off_8CD9258 + 23);
  if ( v5 == 0 )
    goto LABEL_8;
  v6 = *(_QWORD *)(v5 + 48);
  if ( v6 != 0 )
  {
    *(_QWORD *)(v6 + 24) = LocalNetworkTime;
    v7 = *v4[23];
    if ( v7 != 0 )
    {
      DbtSaveDataManagerBase_object__object___Save(v7, qword_8CFB3E0);
      return;
    }
LABEL_8:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
