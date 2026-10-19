void TimeModuleO_TimeManager__CheckWeekPassed(void *self, const MethodInfo *method)
{
  __int64 v3; // x8
  __int64 v4; // x8
  __int64 v5; // x20
  const MethodInfo *v6; // x1
  void *LocalNetworkTime; // x21
  const MethodInfo *v8; // x2
  void *StartOfWeekForTimeManager; // x20
  const MethodInfo *v10; // x2
  __int64 v11; // x21
  __int64 v12; // x8

  if ( (byte_8FFD9F7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    byte_8FFD9F7 = 1;
  }
  if ( *((_QWORD *)self + 9) != 0 )
  {
    v3 = **((_QWORD **)off_8CD9258 + 23);
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v4 = *(_QWORD *)(v3 + 48);
    if ( v4 != 0 )
    {
      v5 = *(_QWORD *)(v4 + 24);
      if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6460);
      if ( (System_DateTime__op_Equality(v5, 0, 0) & 1) == 0 )
      {
        LocalNetworkTime = (void *)TimeModuleO_TimeManager__GetLocalNetworkTime(self, v6);
        StartOfWeekForTimeManager = (void *)TimeModuleO_TimeManager__GetStartOfWeekForTimeManager(
                                              LocalNetworkTime,
                                              v5,
                                              v8);
        v11 = TimeModuleO_TimeManager__GetStartOfWeekForTimeManager(
                StartOfWeekForTimeManager,
                (__int64)LocalNetworkTime,
                v10);
        if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE6460);
        if ( (System_DateTime__op_GreaterThan(v11, StartOfWeekForTimeManager, 0) & 1) != 0 )
        {
          v12 = *((_QWORD *)self + 9);
          if ( v12 != 0 )
            (*(void (__fastcall **)(_QWORD, _QWORD))(v12 + 24))(*(_QWORD *)(v12 + 64), *(_QWORD *)(v12 + 40));
          TimeModuleO_TimeManager__SaveLastExitTime(self);
        }
        if ( *((_BYTE *)self + 176) != 0 )
          return;
        *((_BYTE *)self + 176) = 1;
      }
      TimeModuleO_TimeManager__SaveLastExitTime(self);
    }
  }
}
