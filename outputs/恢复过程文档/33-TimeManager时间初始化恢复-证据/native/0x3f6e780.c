void TimeModuleO_TimeManager__HandleTimeToWeekCutDown_d__36__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x0
  void *v5; // x21
  __int64 TimeSpanToWeek; // x1
  const MethodInfo *v7; // x3
  int v8; // [xsp+0h] [xbp-30h] BYREF
  int Awaiter; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFE38F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D226F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFE38F = 1;
  }
  Awaiter = 0;
  v8 = 0;
  v3 = *((_QWORD *)self + 5);
  if ( *(_DWORD *)self == 0 )
  {
    Awaiter = *((_DWORD *)self + 12);
    *((_DWORD *)self + 12) = 0;
    *(_DWORD *)self = -1;
    goto LABEL_24;
  }
  if ( *(_DWORD *)self == 1 )
  {
    Awaiter = *((_DWORD *)self + 12);
    *((_DWORD *)self + 12) = 0;
    *(_DWORD *)self = -1;
    while ( 1 )
    {
      Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__GetResult(&Awaiter, 0);
LABEL_8:
      if ( v3 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v4 = *(_QWORD *)(v3 + 104);
      if ( v4 != 0 )
        break;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      v8 = Cysharp_Threading_Tasks_UniTask__Yield(0);
      Awaiter = Cysharp_Threading_Tasks_YieldAwaitable__GetAwaiter(&v8, 0);
      if ( (Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
      {
        *(_DWORD *)self = 1;
        *((_DWORD *)self + 12) = Awaiter;
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_YieldAwaitable_Awaiter__TimeManager__HandleTimeToWeekCutDown_d__36_(
          (char *)self + 8,
          &Awaiter,
          self,
          qword_8D226F0);
        return;
      }
    }
    if ( (TimeModuleO_TimeManager_Timer__IsCompleted(v4) & 1) != 0 )
    {
      v5 = *(void **)(v3 + 104);
      TimeSpanToWeek = TimeModuleO_TimeManager__GetTimeSpanToWeek(v3);
      if ( v5 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      TimeModuleO_TimeManager_Timer__Restart(v5, TimeSpanToWeek, 1u, v7);
    }
    *(_DWORD *)self = -2;
    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
  }
  else
  {
    while ( 1 )
    {
      if ( v3 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v3 + 37) != 0 )
        goto LABEL_8;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      v8 = Cysharp_Threading_Tasks_UniTask__Yield(0);
      Awaiter = Cysharp_Threading_Tasks_YieldAwaitable__GetAwaiter(&v8, 0);
      if ( (Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
        break;
LABEL_24:
      Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__GetResult(&Awaiter, 0);
    }
    *(_DWORD *)self = 0;
    *((_DWORD *)self + 12) = Awaiter;
    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_YieldAwaitable_Awaiter__TimeManager__HandleTimeToWeekCutDown_d__36_(
      (char *)self + 8,
      &Awaiter,
      self,
      qword_8D226F0);
  }
}
