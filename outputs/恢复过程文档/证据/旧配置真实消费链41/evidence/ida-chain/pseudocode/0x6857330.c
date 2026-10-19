void stage41_GameFramework_ConfigRead___slS__object___MoveNext(void *a0, void *a1)
{
  int v4; // w8
  void *v5; // x21
  void *v6; // x22
  __int64 v7; // x0
  void *CustomConfigByUnityJsonAsync_object; // x0
  __int64 v9; // x0
  char *v10; // x19
  __int64 v11; // x21
  __int64 v12; // x22
  __int64 v13; // x0
  __int64 CustomConfigByMemoryPackAsync_object; // x0
  __int64 Awaiter; // [xsp+8h] [xbp-38h] BYREF

  if ( (byte_9006FDF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    byte_9006FDF = 1;
  }
  Awaiter = 0;
  if ( *(_DWORD *)a0 == 0 )
  {
    Awaiter = *((_QWORD *)a0 + 7);
    *((_QWORD *)a0 + 7) = 0;
    *(_DWORD *)a0 = -1;
    goto LABEL_6;
  }
  if ( *(_DWORD *)a0 == 1 )
  {
    Awaiter = *((_QWORD *)a0 + 7);
    *((_QWORD *)a0 + 7) = 0;
    *(_DWORD *)a0 = -1;
    goto LABEL_6;
  }
  v4 = *((_DWORD *)a0 + 8);
  if ( v4 == 2 )
  {
    v12 = *((_QWORD *)a0 + 5);
    v11 = *((_QWORD *)a0 + 6);
    if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v13 = *((_QWORD *)a1 + 4);
    if ( (*(_BYTE *)(v13 + 309) & 1) == 0 )
      v13 = ((__int64 (*)(void))unk_3C503A0)();
    CustomConfigByMemoryPackAsync_object = GameFramework_ConfigRead__readCustomConfigByMemoryPackAsync_object_(
                                             v12,
                                             v11,
                                             *(_QWORD *)(*(_QWORD *)(v13 + 192) + 40LL));
    if ( CustomConfigByMemoryPackAsync_object == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Awaiter = System_Threading_Tasks_Task__GetAwaiter(CustomConfigByMemoryPackAsync_object, 0);
    if ( (System_Runtime_CompilerServices_TaskAwaiter__get_IsCompleted(&Awaiter, 0) & 1) != 0 )
      goto LABEL_6;
    *(_DWORD *)a0 = 1;
    *((_QWORD *)a0 + 7) = Awaiter;
    if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4558);
    v9 = *((_QWORD *)a1 + 4);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (*)(void))unk_3C503A0)();
LABEL_21:
    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_TaskAwaiter__ConfigRead___slS__object__(
      (char *)a0 + 8,
      &Awaiter,
      a0,
      *(_QWORD *)(*(_QWORD *)(v9 + 192) + 24LL));
    return;
  }
  if ( v4 != 1 )
    goto LABEL_22;
  v6 = *((void **)a0 + 5);
  v5 = *((void **)a0 + 6);
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  v7 = *((_QWORD *)a1 + 4);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  CustomConfigByUnityJsonAsync_object = GameFramework_ConfigRead__readCustomConfigByUnityJsonAsync_object_(
                                          v6,
                                          v5,
                                          *(void **)(*(_QWORD *)(v7 + 192) + 16LL));
  if ( CustomConfigByUnityJsonAsync_object == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  Awaiter = System_Threading_Tasks_Task__GetAwaiter(CustomConfigByUnityJsonAsync_object, 0);
  if ( (System_Runtime_CompilerServices_TaskAwaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
  {
    *(_DWORD *)a0 = 0;
    *((_QWORD *)a0 + 7) = Awaiter;
    if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4558);
    v9 = *((_QWORD *)a1 + 4);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (*)(void))unk_3C503A0)();
    goto LABEL_21;
  }
LABEL_6:
  System_Runtime_CompilerServices_TaskAwaiter__GetResult(&Awaiter, 0);
LABEL_22:
  *(_DWORD *)a0 = -2;
  v10 = (char *)a0 + 8;
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetResult(v10, 0);
}
