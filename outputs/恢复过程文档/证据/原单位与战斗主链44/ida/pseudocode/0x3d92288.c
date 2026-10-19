__int64 __fastcall GameModule_RoleBehaviour__InitAnimationAsync_d__70__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  int v4; // [xsp+0h] [xbp-30h] BYREF
  int Awaiter; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFD4C2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD4C2 = 1;
  }
  Awaiter = 0;
  v4 = 0;
  v2 = *(_QWORD *)(a1 + 16);
  if ( *(_DWORD *)a1 != 0 )
  {
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    v4 = Cysharp_Threading_Tasks_UniTask__Yield(0);
    Awaiter = Cysharp_Threading_Tasks_YieldAwaitable__GetAwaiter(&v4, 0);
    if ( (Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
    {
      *(_DWORD *)a1 = 0;
      *(_DWORD *)(a1 + 24) = Awaiter;
      return ((__int64 (__fastcall *)(__int64, int *, __int64, __int64))unk_3DA3B88)(
               a1 + 8,
               &Awaiter,
               a1,
               qword_8D21610);
    }
  }
  else
  {
    Awaiter = *(_DWORD *)(a1 + 24);
    *(_DWORD *)(a1 + 24) = 0;
    *(_DWORD *)a1 = -1;
  }
  Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__GetResult(&Awaiter, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v2, 0, 0) & 1) == 0 )
  {
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v2 + 33) == 0 && *(_BYTE *)(v2 + 636) == 0 )
      sub_3D7F628(v2, 0, 0, 0);
  }
  *(_DWORD *)a1 = -2;
  return ((__int64 (__fastcall *)(__int64, _QWORD))unk_3D313B0)(a1 + 8, 0);
}
