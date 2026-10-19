void stage41_GameFramework_ConfigRead_B____D__MoveNext(void *a0, void *a1)
{
  _QWORD *v3; // x8
  __int64 v4; // x20
  __int64 v5; // x21
  __int64 v6; // x21
  __int64 Awaiter; // x0
  __int64 v8; // x8
  __int64 v9; // x10
  char *v10; // x19
  __int64 v11; // [xsp+8h] [xbp-38h] BYREF

  if ( (byte_900918D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDAD28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF3320);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45E18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF1BE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF690);
    byte_900918D = 1;
  }
  v11 = 0;
  if ( *(_DWORD *)a0 == 0 )
  {
    v8 = *((_QWORD *)a0 + 4);
    if ( v8 != 0
      && ((v9 = *((unsigned __int8 *)off_8CF3320 + 304), *(unsigned __int8 *)(*(_QWORD *)v8 + 304LL) < (unsigned int)v9)
       || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)v8 + 200LL) + 8 * v9 - 8) != off_8CF3320) )
    {
      ((void (__fastcall *)(_QWORD))unk_3C3D868)(*((_QWORD *)a0 + 4));
    }
    else
    {
      v11 = *((_QWORD *)a0 + 4);
      *((_QWORD *)a0 + 4) = 0;
      *(_DWORD *)a0 = -1;
      if ( v8 != 0 )
        goto LABEL_19;
    }
    il2cpp_codegen_raise_null_reference_exception();
  }
  v3 = off_8CF1BE8;
  if ( *((_DWORD *)off_8CF1BE8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CF1BE8);
    v3 = off_8CF1BE8;
  }
  v4 = *(_QWORD *)(v3[23] + 8LL);
  if ( v4 == 0 )
  {
    if ( *((_DWORD *)v3 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v3);
      v3 = off_8CF1BE8;
    }
    v5 = *(_QWORD *)v3[23];
    v4 = ((__int64 (__fastcall *)(__int64, void *))unk_3C3D4C4)(qword_8CDAD28, a1);
    System_Func_bool____ctor(v4, v5, qword_8D45E18, 0);
    *(_QWORD *)(*((_QWORD *)off_8CF1BE8 + 23) + 8LL) = v4;
  }
  v6 = ((__int64 (__fastcall *)(__int64, void *))unk_3C3D4C4)(qword_8CEF690, a1);
  UnityEngine_WaitUntil___ctor(v6, v4, 0);
  Awaiter = IEnumeratorAwaitExtensions__GetAwaiter(v6, 0);
  v8 = Awaiter;
  v11 = Awaiter;
  if ( Awaiter == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(Awaiter + 16) == 0 )
  {
    *(_DWORD *)a0 = 0;
    *((_QWORD *)a0 + 4) = Awaiter;
    if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4558);
    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitOnCompleted_object__ConfigRead_B____D_(
      (char *)a0 + 8,
      &v11,
      a0,
      qword_8D1E210);
    return;
  }
LABEL_19:
  IEnumeratorAwaitExtensions_SimpleCoroutineAwaiter__GetResult(v8, 0);
  *(_DWORD *)a0 = -2;
  v10 = (char *)a0 + 8;
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetResult(v10, 0);
}
