void stage41_ljzs_lt_ConfigMgr__customRead(void *a0, void *a1)
{
  __int64 v3; // x0
  __int64 v4; // x0
  __int64 v5; // x20
  __int64 v6; // x21
  __int64 v7; // x0
  __int64 v8; // x8
  _QWORD *v9; // x9
  __int64 v10; // x10
  _QWORD v11[5]; // [xsp+8h] [xbp-B8h] BYREF
  _QWORD v12[6]; // [xsp+30h] [xbp-90h] BYREF
  __int64 v13; // [xsp+68h] [xbp-58h]

  if ( (byte_900085C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC1D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC1D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFD640);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC1E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04830);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D04840);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D075B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0D4E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D4D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDE58);
    byte_900085C = 1;
  }
  memset(v12, 0, 40);
  v13 = 0;
  v3 = *((_QWORD *)a0 + 44);
  if ( v3 == 0
    || (System_Collections_Generic_Dictionary_int__object___Clear(v3, qword_8CFC1D8), (v4 = *((_QWORD *)a0 + 11)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(v11, v4, qword_8CFD640);
  qmemcpy(v12, v11, 40);
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(v12, qword_8D04838) & 1) != 0 )
  {
    v5 = v12[3];
    if ( v12[3] != 0 && *(int *)(v12[3] + 20LL) >= 1 )
    {
      if ( *((_QWORD *)a0 + 44) == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (System_Collections_Generic_Dictionary_int__object___TryGetValue() & 1) == 0 )
      {
        v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDE58);
        System_Collections_Generic_List_object____ctor(v6, qword_8D0D4D0);
        v13 = v6;
        if ( *((_QWORD *)a0 + 44) == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        System_Collections_Generic_Dictionary_int__object___Add();
      }
      v7 = v13;
      if ( v13 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v8 = *(_QWORD *)(v13 + 16);
      v9 = off_8D0D4E0;
      ++*(_DWORD *)(v13 + 28);
      if ( v8 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v10 = *(int *)(v7 + 24);
      if ( (unsigned int)v10 >= *(_DWORD *)(v8 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(v7, v5, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v7 + 24) = v10 + 1;
        *(_QWORD *)(v8 + 8 * v10 + 32) = v5;
      }
    }
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v12, qword_8D04830);
}
