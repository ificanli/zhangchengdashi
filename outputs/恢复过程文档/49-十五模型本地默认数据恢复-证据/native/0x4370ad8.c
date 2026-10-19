void DataModule_PlayerCardData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x9
  _QWORD *v9; // x8
  __int64 v10; // x10
  __int64 v11; // x10
  __int64 v12; // x10
  __int64 v13; // x10
  __int64 v14; // x10
  __int64 v15; // x10
  __int64 v16; // x10
  __int64 v17; // x10
  __int64 v18; // x20
  __int64 v19; // x20

  if ( (byte_9000729 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA068);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0BE78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F580);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE418);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    byte_9000729 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDE418, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0F580);
  *((_QWORD *)self + 2) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA068);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFF618);
  *((_QWORD *)self + 3) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0E5E0);
  *((_QWORD *)self + 4) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE400);
  System_Collections_Generic_List_object____ctor(v6, qword_8D0F520);
  *((_QWORD *)self + 5) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
  System_Collections_Generic_List_int____ctor(v7, qword_8D0BE60);
  if ( v7 == 0 )
    goto LABEL_30;
  v8 = *(_QWORD *)(v7 + 16);
  v9 = off_8D0BE78;
  ++*(_DWORD *)(v7 + 28);
  if ( v8 == 0 )
    goto LABEL_30;
  v10 = *(int *)(v7 + 24);
  if ( (unsigned int)v10 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1001, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v10 + 1;
    *(_DWORD *)(v8 + 4 * v10 + 32) = 1001;
    ++*(_DWORD *)(v7 + 28);
  }
  v11 = *(int *)(v7 + 24);
  if ( (unsigned int)v11 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1002, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v11 + 1;
    *(_DWORD *)(v8 + 4 * v11 + 32) = 1002;
    ++*(_DWORD *)(v7 + 28);
  }
  v12 = *(int *)(v7 + 24);
  if ( (unsigned int)v12 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1003, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v12 + 1;
    *(_DWORD *)(v8 + 4 * v12 + 32) = 1003;
    ++*(_DWORD *)(v7 + 28);
  }
  v13 = *(int *)(v7 + 24);
  if ( (unsigned int)v13 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1004, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v13 + 1;
    *(_DWORD *)(v8 + 4 * v13 + 32) = 1004;
    ++*(_DWORD *)(v7 + 28);
  }
  v14 = *(int *)(v7 + 24);
  if ( (unsigned int)v14 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1005, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v14 + 1;
    *(_DWORD *)(v8 + 4 * v14 + 32) = 1005;
    ++*(_DWORD *)(v7 + 28);
  }
  v15 = *(int *)(v7 + 24);
  if ( (unsigned int)v15 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1011, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
    v8 = *(_QWORD *)(v7 + 16);
    v9 = off_8D0BE78;
    ++*(_DWORD *)(v7 + 28);
    if ( v8 == 0 )
      goto LABEL_30;
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v15 + 1;
    *(_DWORD *)(v8 + 4 * v15 + 32) = 1011;
    ++*(_DWORD *)(v7 + 28);
  }
  v16 = *(int *)(v7 + 24);
  if ( (unsigned int)v16 < *(_DWORD *)(v8 + 24) )
  {
    *(_DWORD *)(v7 + 24) = v16 + 1;
    *(_DWORD *)(v8 + 4 * v16 + 32) = 1013;
    ++*(_DWORD *)(v7 + 28);
    goto LABEL_26;
  }
  System_Collections_Generic_List_int___AddWithResize(v7, 1013, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
  v8 = *(_QWORD *)(v7 + 16);
  v9 = off_8D0BE78;
  ++*(_DWORD *)(v7 + 28);
  if ( v8 == 0 )
LABEL_30:
    il2cpp_codegen_raise_null_reference_exception();
LABEL_26:
  v17 = *(int *)(v7 + 24);
  if ( (unsigned int)v17 >= *(_DWORD *)(v8 + 24) )
  {
    System_Collections_Generic_List_int___AddWithResize(v7, 1014, *(_QWORD *)(*(_QWORD *)(v9[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v7 + 24) = v17 + 1;
    *(_DWORD *)(v8 + 4 * v17 + 32) = 1014;
  }
  *((_QWORD *)self + 7) = v7;
  v18 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA058);
  System_Collections_Generic_Dictionary_object__object____ctor(v18, qword_8CFF5C0);
  *((_QWORD *)self + 8) = v18;
  v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v19, qword_8CFEA38);
  *((_QWORD *)self + 9) = v19;
  ServerBaseData___ctor(self, 0);
}
