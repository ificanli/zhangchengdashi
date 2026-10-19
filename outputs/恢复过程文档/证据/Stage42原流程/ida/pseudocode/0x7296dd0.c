void GameFramework_Fsm_FsmManager__Shutdown_7296dd0(void *this, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x2
  __int64 v5; // x0
  __int64 v6; // x8
  int v7; // w2
  int v8; // w9
  __int128 v9; // [xsp+0h] [xbp-60h] BYREF
  __int128 v10; // [xsp+10h] [xbp-50h]
  __int64 v11; // [xsp+20h] [xbp-40h]

  if ( (byte_9009D2B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04BA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04BA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D04BB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07748);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0A820);
    byte_9009D2B = 1;
  }
  v11 = 0;
  v9 = 0u;
  v10 = 0u;
  v3 = *((_QWORD *)this + 4);
  if ( v3 == 0 )
    goto LABEL_14;
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(&v9, v3, qword_8CFE4E0);
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(&v9, qword_8D04BA8) & 1) != 0 )
  {
    if ( *((_QWORD *)&v10 + 1) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(_QWORD, _QWORD, __int64))(**((_QWORD **)&v10 + 1) + 520LL))(
      *((_QWORD *)&v10 + 1),
      *(_QWORD *)(**((_QWORD **)&v10 + 1) + 528LL),
      v4);
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(&v9, qword_8D04BA0);
  v5 = *((_QWORD *)this + 4);
  if ( v5 == 0
    || (System_Collections_Generic_Dictionary_object__object___Clear(v5, qword_8CFE4D0),
        (v6 = *((_QWORD *)this + 5)) == 0) )
  {
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v7 = *(_DWORD *)(v6 + 24);
  v8 = *(_DWORD *)(v6 + 28) + 1;
  *(_DWORD *)(v6 + 24) = 0;
  *(_DWORD *)(v6 + 28) = v8;
  if ( v7 >= 1 )
    System_Array__Clear(*(_QWORD *)(v6 + 16), 0);
  *((_BYTE *)this + 16) = 0;
}
