void TimeModuleO_TimeManager__CheckTimerToZero(void *self, const MethodInfo *method)
{
  void *v3; // x0
  const MethodInfo *v4; // x1
  void *v5; // x20
  __int64 TimeSpanToZero; // x0
  __int64 v7; // x8
  __int64 v8; // x8
  void *Instance; // x0
  const MethodInfo *v10; // x1
  __int64 v11; // x2
  const MethodInfo *v12; // x1
  void *v13; // x20
  __int64 TimeSpanToWeek; // x0
  __int64 v15; // x8
  void *v16; // x0
  void *v17; // x0
  const MethodInfo *v18; // x1
  void *v19; // x20
  __int64 TimeSpanToZeroStandardNetworkTime; // x0
  __int64 v21; // x8
  __int64 v22; // x8
  void *v23; // x0
  __int64 LocalNetworkTime; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFD9F4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73748);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73730);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73778);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86A60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73758);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87B68);
    byte_8FFD9F4 = 1;
  }
  LocalNetworkTime = 0;
  v3 = *((void **)self + 11);
  if ( v3 != nullptr && (TimeModuleO_TimeManager_Timer__IsCompleted(v3, nullptr) & 1) != 0 )
  {
    v5 = *((void **)self + 11);
    TimeSpanToZero = TimeModuleO_TimeManager__GetTimeSpanToZero(self, v4);
    if ( v5 == nullptr )
      goto LABEL_31;
    TimeModuleO_TimeManager_Timer__Restart(v5, TimeSpanToZero, 1u, nullptr);
    v7 = *((_QWORD *)self + 6);
    if ( v7 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD))(v7 + 24))(*(_QWORD *)(v7 + 64), *(_QWORD *)(v7 + 40));
    v8 = *((_QWORD *)self + 11);
    if ( v8 == 0 )
      goto LABEL_31;
    TimeModuleO_TimeManager__ChangeTimeInfoEndTime(qword_8D73750, *(_QWORD *)(v8 + 32));
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__Log(qword_8D87B68, 0);
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
    if ( Instance == nullptr )
      goto LABEL_31;
    EventModule_EventManager__TriggerEvent(Instance, (void *)qword_8D73748, nullptr, nullptr);
    LocalNetworkTime = TimeModuleO_TimeManager__GetLocalNetworkTime(self, v10);
    if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
    if ( (unsigned int)System_DateTime__get_DayOfWeek(&LocalNetworkTime, 0, v11) == 1 )
    {
      v13 = *((void **)self + 13);
      TimeSpanToWeek = TimeModuleO_TimeManager__GetTimeSpanToWeek(self, v12);
      if ( v13 == nullptr )
        goto LABEL_31;
      TimeModuleO_TimeManager_Timer__Restart(v13, TimeSpanToWeek, 1u, nullptr);
      v15 = *((_QWORD *)self + 8);
      if ( v15 != 0 )
        (*(void (__fastcall **)(_QWORD, _QWORD))(v15 + 24))(*(_QWORD *)(v15 + 64), *(_QWORD *)(v15 + 40));
      if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE64E8);
      UnityEngine_Debug__Log(qword_8D86A60, 0);
      v16 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
      if ( v16 == nullptr )
        goto LABEL_31;
      EventModule_EventManager__TriggerEvent(v16, (void *)qword_8D73730, nullptr, nullptr);
    }
  }
  v17 = *((void **)self + 12);
  if ( v17 != nullptr && (TimeModuleO_TimeManager_Timer__IsCompleted(v17, nullptr) & 1) != 0 )
  {
    v19 = *((void **)self + 12);
    TimeSpanToZeroStandardNetworkTime = TimeModuleO_TimeManager__GetTimeSpanToZeroStandardNetworkTime(self, v18);
    if ( v19 != nullptr )
    {
      TimeModuleO_TimeManager_Timer__Restart(v19, TimeSpanToZeroStandardNetworkTime, 1u, nullptr);
      v21 = *((_QWORD *)self + 7);
      if ( v21 != 0 )
        (*(void (__fastcall **)(_QWORD, _QWORD))(v21 + 24))(*(_QWORD *)(v21 + 64), *(_QWORD *)(v21 + 40));
      v22 = *((_QWORD *)self + 12);
      if ( v22 != 0 )
      {
        TimeModuleO_TimeManager__ChangeTimeInfoEndTime(qword_8D73758, *(_QWORD *)(v22 + 32));
        v23 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
        if ( v23 != nullptr )
        {
          EventModule_EventManager__TriggerEvent(v23, (void *)qword_8D73778, nullptr, nullptr);
          return;
        }
      }
    }
LABEL_31:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
