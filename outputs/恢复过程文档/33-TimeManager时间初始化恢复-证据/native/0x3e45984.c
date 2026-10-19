void TimeModuleO_TimeManager__CheckTimerToWeek(void *self, const MethodInfo *method)
{
  void *v3; // x0
  const MethodInfo *v4; // x1
  void *v5; // x20
  __int64 TimeSpanToWeek; // x0
  __int64 v7; // x8
  __int64 v8; // x8
  void *Instance; // x0

  if ( (byte_8FFD9F6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73740);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73730);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86A60);
    byte_8FFD9F6 = 1;
  }
  v3 = *((void **)self + 13);
  if ( v3 == nullptr )
    goto LABEL_14;
  if ( (TimeModuleO_TimeManager_Timer__IsCompleted(v3, nullptr) & 1) != 0 )
  {
    v5 = *((void **)self + 13);
    TimeSpanToWeek = TimeModuleO_TimeManager__GetTimeSpanToWeek(self, v4);
    if ( v5 != nullptr )
    {
      TimeModuleO_TimeManager_Timer__Restart(v5, TimeSpanToWeek, 1u, nullptr);
      v7 = *((_QWORD *)self + 8);
      if ( v7 != 0 )
        (*(void (__fastcall **)(_QWORD, _QWORD))(v7 + 24))(*(_QWORD *)(v7 + 64), *(_QWORD *)(v7 + 40));
      v8 = *((_QWORD *)self + 13);
      if ( v8 != 0 )
      {
        TimeModuleO_TimeManager__ChangeTimeInfoEndTime(qword_8D73740, *(_QWORD *)(v8 + 32));
        if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE64E8);
        UnityEngine_Debug__Log(qword_8D86A60, 0);
        Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
        if ( Instance != nullptr )
        {
          EventModule_EventManager__TriggerEvent(Instance, (void *)qword_8D73730, nullptr, nullptr);
          return;
        }
      }
    }
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
