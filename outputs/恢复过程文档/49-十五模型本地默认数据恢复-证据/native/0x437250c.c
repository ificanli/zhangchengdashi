void DataModule_PlayerMainCityData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  _QWORD *v4; // x0
  __int64 v5; // x8
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x3
  __int64 v10; // x24
  __int64 v11; // x20
  __int64 v12; // x3
  _QWORD *Instance; // x0
  unsigned int v14; // w20
  __int64 v15; // x8
  __int64 v16; // x8
  __int64 v17; // x21
  _QWORD *v18; // x0
  __int64 v19; // x8
  __int64 v20; // x0
  __int64 Item; // x0
  _QWORD v22[2]; // [xsp+8h] [xbp-58h] BYREF
  __int64 v23; // [xsp+18h] [xbp-48h]

  if ( (byte_9000736 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D034D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D034E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D034E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F688);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0F690);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536A0);
    byte_9000736 = 1;
  }
  v22[0] = 0;
  v22[1] = 0;
  v23 = 0;
  ServerBaseData__Init(self, 0);
  v3 = *((_QWORD *)self + 2);
  if ( v3 == 0 )
    goto LABEL_33;
  if ( (int)System_Collections_Generic_Dictionary_object__int___get_Count(v3, qword_8CFEA90) <= 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( Instance != nullptr )
    {
      v14 = 0;
      do
      {
        v15 = Instance[5];
        if ( v15 == 0 )
          break;
        v16 = *(_QWORD *)(v15 + 40);
        if ( v16 == 0 )
          break;
        if ( (signed int)v14 >= *(_DWORD *)(v16 + 24) )
          goto LABEL_5;
        v17 = *((_QWORD *)self + 2);
        v18 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
        if ( v18 == nullptr )
          break;
        v19 = v18[5];
        if ( v19 == 0 )
          break;
        v20 = *(_QWORD *)(v19 + 40);
        if ( v20 == 0 )
          break;
        Item = System_Collections_Generic_List_object___get_Item(v20, v14, qword_8D0B198);
        if ( Item == 0 )
          break;
        if ( v17 == 0 )
          break;
        System_Collections_Generic_Dictionary_object__int___Add(v17, *(_QWORD *)(Item + 16), 1, qword_8CFEA58);
        ++v14;
        Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
      }
      while ( Instance != nullptr );
    }
    goto LABEL_33;
  }
LABEL_5:
  if ( (ToolModule_StringTool__IsNullOrEmpty(*((_QWORD *)self + 7), 1, 0) & 1) != 0 )
  {
    v4 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v4 == nullptr
      || (v5 = v4[5]) == 0
      || (v6 = *(_QWORD *)(v5 + 424)) == 0
      || (v7 = System_Collections_Generic_List_object___get_Item(v6, 0, qword_8D0B058)) == 0 )
    {
LABEL_33:
      il2cpp_codegen_raise_null_reference_exception();
    }
    *((_QWORD *)self + 7) = *(_QWORD *)(v7 + 16);
  }
  v8 = *((_QWORD *)self + 4);
  if ( v8 == 0 )
    goto LABEL_33;
  if ( *(int *)(v8 + 24) >= 1 && *((_DWORD *)self + 12) == 0 )
  {
    System_Collections_Generic_List_object___GetEnumerator(v22, v8, qword_8D0F688);
    while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(v22, qword_8D034E0) & 1) != 0 )
    {
      v10 = v23;
      if ( v23 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_DWORD *)((char *)&qword_60 + v23 + 4) != 1 )
      {
        if ( (v11 = *(__int64 *)((char *)&qword_20 + v23),
              (System_String__op_Equality(v11, qword_8D536A8, 0, v9) & 1) == 0)
          && (System_String__op_Equality(v11, qword_8D536A0, 0, v12) & 1) == 0
          || *(_DWORD *)((char *)&qword_60 + v10) == 1 )
        {
          ++*((_DWORD *)self + 12);
        }
      }
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(v22, qword_8D034D8);
  }
  DataModule_PlayerMainCityData__CheckTitleUpdate(self, 1);
}
