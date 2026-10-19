void DataModule_PlayerResourceData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x20
  __int64 v5; // x0
  _QWORD *Instance; // x0
  __int64 v7; // x8
  __int64 v8; // x0
  __int64 v9; // x21
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x8
  _QWORD *v14; // x9
  __int64 v15; // x10
  __int64 v16; // x0
  __int128 v17; // [xsp+8h] [xbp-B8h] BYREF
  __int64 v18; // [xsp+18h] [xbp-A8h]
  __int128 v19; // [xsp+20h] [xbp-A0h] BYREF
  __int64 v20; // [xsp+30h] [xbp-90h]
  __int128 v21; // [xsp+40h] [xbp-80h] BYREF
  __int64 v22; // [xsp+50h] [xbp-70h]

  if ( (byte_900073F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF598);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01F48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03448);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01F50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03450);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01F58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D03458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F4B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F4C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ADE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF120);
    byte_900073F = 1;
  }
  v21 = 0u;
  v22 = 0;
  v19 = 0u;
  v20 = 0;
  ServerBaseData__Init(self, 0);
  v3 = *((_QWORD *)self + 2);
  if ( v3 == 0 )
    goto LABEL_34;
  System_Collections_Generic_List_object___GetEnumerator(&v17, v3, qword_8D0F4C8);
  v21 = v17;
  v22 = v18;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v21, qword_8D03450) & 1) != 0 )
  {
    v4 = v22;
    if ( v22 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v5 = *((_QWORD *)self + 3);
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___TryAdd(v5, *(_QWORD *)(v22 + 24), v22, qword_8CFF5A8);
    ((void (__fastcall *)(__int64))DataModule_UserAssetData__InitBigInt)(v4);
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v21, qword_8D03448);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance == nullptr || (v7 = Instance[5]) == 0 || (v8 = *(_QWORD *)(v7 + 80)) == 0 )
LABEL_34:
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_List_object___GetEnumerator(&v17, v8, qword_8D0ADE8);
  v19 = v17;
  v20 = v18;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v19, qword_8D01F50) & 1) != 0 )
  {
    v9 = v20;
    if ( v20 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v10 = *((_QWORD *)self + 3);
    if ( v10 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v10, *(_QWORD *)(v20 + 16), qword_8CFF598)
        & 1) == 0 )
    {
      v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF120);
      DataModule_UserAssetData___ctor(v11, v9);
      v12 = *((_QWORD *)self + 2);
      if ( v12 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v13 = *(_QWORD *)(v12 + 16);
      v14 = off_8D0F4B8;
      ++*(_DWORD *)(v12 + 28);
      if ( v13 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v15 = *(int *)(v12 + 24);
      if ( (unsigned int)v15 >= *(_DWORD *)(v13 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v12,
          v11,
          *(_QWORD *)(*(_QWORD *)(v14[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v12 + 24) = v15 + 1;
        *(_QWORD *)(v13 + 8 * v15 + 32) = v11;
      }
      if ( v11 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v16 = *((_QWORD *)self + 3);
      if ( v16 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Collections_Generic_Dictionary_object__object___TryAdd(v16, *(_QWORD *)(v11 + 24), v11, qword_8CFF5A8);
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v19, qword_8D01F48);
}
