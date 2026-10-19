void DataModule_GlobalInfo___InitInfo_b__92_10(void *self, void *list, const MethodInfo *method)
{
  __int64 v5; // x20
  __int64 v6; // x0
  unsigned int v7; // w20
  __int64 v8; // x21
  __int64 v9; // x0
  __int64 v10; // x22
  __int64 Item; // x0

  if ( (byte_900067D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE818);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9DC0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B188);
    byte_900067D = 1;
  }
  *((_QWORD *)self + 41) = list;
  v5 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CD9DC0, list, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFE810);
  v6 = *((_QWORD *)self + 41);
  *((_QWORD *)self + 47) = v5;
  if ( v6 == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  v7 = 0;
  while ( (signed int)v7 < *(_DWORD *)(v6 + 24) )
  {
    v8 = *((_QWORD *)self + 47);
    v9 = ((__int64 (*)(void))System_Collections_Generic_List_object___get_Item)();
    if ( v9 != 0 && *((_QWORD *)self + 41) != 0 )
    {
      v10 = *(_QWORD *)(v9 + 24);
      Item = System_Collections_Generic_List_object___get_Item(*((_QWORD *)self + 41), v7, qword_8D0B188);
      if ( v8 != 0 )
      {
        System_Collections_Generic_Dictionary_object__object___Add(v8, v10, Item, qword_8CFE818);
        v6 = *((_QWORD *)self + 41);
        ++v7;
        if ( v6 != 0 )
          continue;
      }
    }
    goto LABEL_10;
  }
}
