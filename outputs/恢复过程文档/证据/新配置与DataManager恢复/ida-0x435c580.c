void DataModule_GlobalInfo___InitInfo_b__92_21(void *self, void *list, const MethodInfo *method)
{
  __int64 v5; // x20
  __int64 v6; // x0
  unsigned int v7; // w20
  __int64 v8; // x21
  __int64 Item; // x0
  __int64 v10; // x22
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x19
  int v14; // [xsp+Ch] [xbp-44h] BYREF

  if ( (byte_9000685 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE730);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE728);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9D90);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0AFB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AFC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68BC8);
    byte_9000685 = 1;
  }
  *((_QWORD *)self + 11) = list;
  v5 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CD9D90, list, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFE728);
  v6 = *((_QWORD *)self + 11);
  *((_QWORD *)self + 13) = v5;
  if ( v6 == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  v7 = 0;
  while ( (signed int)v7 < *(_DWORD *)(v6 + 24) )
  {
    v8 = *((_QWORD *)self + 13);
    Item = System_Collections_Generic_List_object___get_Item(v6, v7, qword_8D0AFC0);
    if ( Item != 0 && *((_QWORD *)self + 11) != 0 )
    {
      v10 = *(_QWORD *)(Item + 16);
      v11 = System_Collections_Generic_List_object___get_Item(*((_QWORD *)self + 11), v7, qword_8D0AFC0);
      if ( v8 != 0 )
      {
        System_Collections_Generic_Dictionary_object__object___Add(v8, v10, v11, qword_8CFE730);
        v6 = *((_QWORD *)self + 11);
        ++v7;
        if ( v6 != 0 )
          continue;
      }
    }
    goto LABEL_10;
  }
  v14 = *(_DWORD *)(v6 + 24);
  v12 = System_Int32__ToString(&v14, 0);
  v13 = sub_74FE7A4(qword_8D68BC8, v12, 0);
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(v13, 0);
}
