void GameFramework_Fsm_Fsm_object___Shutdown_52a8c18(void *this, const MethodInfo *method)
{
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  __int128 v8; // [xsp+0h] [xbp-60h] BYREF
  __int128 v9; // [xsp+10h] [xbp-50h]
  __int64 v10; // [xsp+20h] [xbp-40h]

  if ( (byte_9002566 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF758);
    byte_9002566 = 1;
  }
  v10 = 0;
  v8 = 0u;
  v9 = 0u;
  v4 = *((_QWORD *)this + 7);
  if ( v4 != 0 )
  {
    (*(void (__fastcall **)(__int64, void *, __int64, _QWORD))(*(_QWORD *)v4 + 440LL))(
      v4,
      this,
      1,
      *(_QWORD *)(*(_QWORD *)v4 + 448LL));
    *((_QWORD *)this + 7) = 0;
    *((_DWORD *)this + 16) = 0;
  }
  v5 = *((_QWORD *)this + 5);
  if ( v5 == 0 )
    goto LABEL_14;
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(
    &v8,
    v5,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 120LL));
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(
             &v8,
             *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 184LL))
         & 1) != 0 )
  {
    if ( *((_QWORD *)&v9 + 1) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(_QWORD, void *, _QWORD))(**((_QWORD **)&v9 + 1) + 456LL))(
      *((_QWORD *)&v9 + 1),
      this,
      *(_QWORD *)(**((_QWORD **)&v9 + 1) + 464LL));
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(
    &v8,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 192LL));
  v6 = *((_QWORD *)this + 5);
  if ( v6 == 0
    || (System_Collections_Generic_Dictionary_object__object___Clear(
          v6,
          *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 200LL)),
        (v7 = *((_QWORD *)this + 6)) == 0) )
  {
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
  System_Collections_Generic_Dictionary_object__object___Clear(v7, qword_8CFF758);
  *((_BYTE *)this + 68) = 1;
}
