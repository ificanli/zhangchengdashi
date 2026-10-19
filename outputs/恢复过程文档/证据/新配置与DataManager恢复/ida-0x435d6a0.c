void DataModule_GlobalInfo___InitInfo_b__92_47(void *self, void *list, const MethodInfo *method)
{
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x20
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x8
  _QWORD *v13; // x9
  __int64 v14; // x10
  __int128 v15; // [xsp+8h] [xbp-B8h] BYREF
  __int64 v16; // [xsp+18h] [xbp-A8h]
  __int128 v17; // [xsp+20h] [xbp-A0h] BYREF
  __int64 v18; // [xsp+30h] [xbp-90h]
  __int128 v19; // [xsp+40h] [xbp-80h] BYREF
  __int64 v20; // [xsp+50h] [xbp-70h]

  if ( (byte_9000693 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE770);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE760);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02050);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02038);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02060);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D02048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D31568);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0B068);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B078);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B060);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD7D8);
    byte_9000693 = 1;
  }
  v19 = 0u;
  v20 = 0;
  v17 = 0u;
  v18 = 0;
  *((_QWORD *)self + 49) = list;
  v5 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CDD7D8, list, method);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0B060);
  *((_QWORD *)self + 50) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9D98);
  System_Collections_Generic_Dictionary_object__object____ctor(v6, qword_8CFE760);
  v7 = *((_QWORD *)self + 49);
  *((_QWORD *)self + 51) = v6;
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_List_object___GetEnumerator(&v15, v7, qword_8D0B040);
  v19 = v15;
  v20 = v16;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v19, qword_8D02040) & 1) != 0 )
  {
    if ( v20 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v8 = *(_QWORD *)(v20 + 24);
    if ( *((_DWORD *)off_8CE9A10 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE9A10);
    v9 = LitJson_JsonMapper__ToObject_object_(v8, qword_8D31568);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_List_object___GetEnumerator(&v15, v9, qword_8D0B078);
    v17 = v15;
    v18 = v16;
    while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v17, qword_8D02058) & 1) != 0 )
    {
      v10 = *((_QWORD *)self + 50);
      if ( v10 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v11 = v18;
      v12 = *(_QWORD *)(v10 + 16);
      v13 = off_8D0B068;
      ++*(_DWORD *)(v10 + 28);
      if ( v12 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v14 = *(int *)(v10 + 24);
      if ( (unsigned int)v14 >= *(_DWORD *)(v12 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v10,
          v11,
          *(_QWORD *)(*(_QWORD *)(v13[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v10 + 24) = v14 + 1;
        *(_QWORD *)(v12 + 8 * v14 + 32) = v11;
      }
      if ( v11 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *((_QWORD *)self + 51) == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Collections_Generic_Dictionary_object__object___TryAdd();
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(&v17, qword_8D02050);
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v19, qword_8D02038);
}
