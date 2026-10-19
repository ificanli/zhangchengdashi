void DataModule_PlayerArenaData__Init(void *self, const MethodInfo *method)
{
  _QWORD *Instance; // x0
  __int64 v4; // x8
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x21
  __int64 v8; // x22
  __int64 v9; // x21
  __int64 v10; // x3
  __int64 v11; // x8
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x8
  _QWORD *v15; // x9
  __int64 v16; // x10
  __int128 v17; // [xsp+8h] [xbp-98h] BYREF
  __int64 v18; // [xsp+18h] [xbp-88h]
  __int128 v19; // [xsp+20h] [xbp-80h] BYREF
  __int64 v20; // [xsp+30h] [xbp-70h]

  if ( (byte_900070C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01F30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01F38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01F40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F490);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ADA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF2B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49288);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4940);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536B8);
    byte_900070C = 1;
  }
  v19 = 0u;
  v20 = 0;
  ServerBaseData__Init(self, 0);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance == nullptr || (v4 = Instance[5]) == 0 || (v5 = *(_QWORD *)(v4 + 160)) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_List_object___GetEnumerator(&v17, v5, qword_8D0ADA0);
  v19 = v17;
  v20 = v18;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v19, qword_8D01F38) & 1) != 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4940);
    System_Object___ctor(v6, 0);
    if ( v6 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v6 + 16) = v20;
    v7 = *((_QWORD *)self + 2);
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF2B0);
    System_Predicate_object____ctor(v8, v6, qword_8D49288, 0);
    if ( v7 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( System_Collections_Generic_List_object___Find(v7, v8, qword_8D0F490) == 0 )
    {
      v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF118);
      System_Object___ctor(v9, 0);
      v11 = *(_QWORD *)(v6 + 16);
      if ( v11 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v9 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v12 = *(_QWORD *)(v11 + 16);
      *(_QWORD *)(v9 + 16) = v12;
      if ( (System_String__op_Equality(v12, qword_8D536B8, 0, v10) & 1) != 0 )
        *(_BYTE *)(v9 + 29) = 1;
      v13 = *((_QWORD *)self + 2);
      if ( v13 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v14 = *(_QWORD *)(v13 + 16);
      v15 = off_8D0F488;
      ++*(_DWORD *)(v13 + 28);
      if ( v14 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v16 = *(int *)(v13 + 24);
      if ( (unsigned int)v16 >= *(_DWORD *)(v14 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v13,
          v9,
          *(_QWORD *)(*(_QWORD *)(v15[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v13 + 24) = v16 + 1;
        *(_QWORD *)(v14 + 8 * v16 + 32) = v9;
      }
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v19, qword_8D01F30);
}
