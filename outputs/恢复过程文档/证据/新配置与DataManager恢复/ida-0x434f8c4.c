void DataModule_DataManager__LoadConfig_d__15__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x21
  __int64 v4; // x20
  __int64 inited; // x0
  __int64 *v6; // x19
  __int64 v7; // x8
  __int64 v8; // x9
  _DWORD *v9; // x10
  __int64 v10; // x0
  __int64 Awaiter; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_9000609 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F1A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7D60);
    byte_9000609 = 1;
  }
  Awaiter = 0;
  v3 = *((_QWORD *)self + 3);
  if ( *(_DWORD *)self != 0 )
  {
    v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CE7D60, method);
    DataModule_GlobalInfo___ctor();
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v3 + 40) = v4;
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    inited = DataModule_GlobalInfo__InitInfo(v4);
    if ( inited == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Awaiter = System_Threading_Tasks_Task__GetAwaiter(inited, 0);
    if ( (System_Runtime_CompilerServices_TaskAwaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
    {
      *(_DWORD *)self = 0;
      *((_QWORD *)self + 4) = Awaiter;
      ((void (__fastcall *)(char *, __int64 *, void *, __int64))unk_4361FDC)(
        (char *)self + 8,
        &Awaiter,
        self,
        qword_8D1F1A8);
      return;
    }
  }
  else
  {
    Awaiter = *((_QWORD *)self + 4);
    *((_QWORD *)self + 4) = 0;
    *(_DWORD *)self = -1;
  }
  System_Runtime_CompilerServices_TaskAwaiter__GetResult(&Awaiter, 0);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_BYTE *)(v3 + 49) = 1;
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v6 = *((__int64 **)self + 1);
  if ( v6 != nullptr )
  {
    v7 = *v6;
    v8 = *(unsigned __int16 *)(*v6 + 302);
    if ( *(_WORD *)(*v6 + 302) != 0 )
    {
      v9 = (_DWORD *)(*(_QWORD *)(v7 + 176) + 8LL);
      while ( *((_QWORD *)v9 - 1) != qword_8CE9038 )
      {
        --v8;
        v9 += 4;
        if ( v8 == 0 )
          goto LABEL_18;
      }
      v10 = v7 + 16LL * (*v9 + 2) + 312;
    }
    else
    {
LABEL_18:
      v10 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v6, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v10)(v6, *(_QWORD *)(v10 + 8));
  }
}
