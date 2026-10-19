void TimeModuleO_TimeManager__CheckTimerEndEvent(void *self, const MethodInfo *method)
{
  __int64 v3; // x8
  int v4; // w2
  int v5; // w9
  __int64 v6; // x0
  void *v7; // x20
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x8
  _QWORD *v11; // x9
  __int64 v12; // x10
  __int64 v13; // x0
  int v14; // w20
  int v15; // w2
  __int64 Item; // x0
  __int64 v17; // x21
  char Value; // w0
  int v19; // w8
  _QWORD v20[5]; // [xsp+8h] [xbp-A8h] BYREF
  void *v21[6]; // [xsp+30h] [xbp-80h] BYREF
  __int64 v22; // [xsp+68h] [xbp-48h] BYREF

  if ( (byte_8FFD9F8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDF90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFCA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDFA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D05190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D05198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D051A0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D079A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D079B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0E610);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0E698);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E6A0);
    byte_8FFD9F8 = 1;
  }
  memset(v21, 0, 40);
  v22 = 0;
  v3 = *((_QWORD *)self + 17);
  if ( v3 == 0 )
    goto LABEL_26;
  v4 = *(_DWORD *)(v3 + 24);
  v5 = *(_DWORD *)(v3 + 28) + 1;
  *(_DWORD *)(v3 + 24) = 0;
  *(_DWORD *)(v3 + 28) = v5;
  if ( v4 >= 1 )
    System_Array__Clear(*(_QWORD *)(v3 + 16), 0);
  v6 = *((_QWORD *)self + 16);
  if ( v6 == 0 )
    goto LABEL_26;
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(v20, v6, qword_8CFFCA0);
  qmemcpy(v21, v20, 40);
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(v21, qword_8D05198) & 1) != 0 )
  {
    if ( v21[3] == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v7 = v21[2];
    if ( (TimeModuleO_TimeManager_Timer__IsCompleted(v21[3], nullptr) & 1) != 0 )
    {
      v8 = *((_QWORD *)self + 15);
      if ( v8 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v8, v7, qword_8CFDF90) & 1) != 0 )
      {
        v9 = *((_QWORD *)self + 17);
        if ( v9 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v10 = *(_QWORD *)(v9 + 16);
        v11 = off_8D0E5F8;
        ++*(_DWORD *)(v9 + 28);
        if ( v10 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v12 = *(int *)(v9 + 24);
        if ( (unsigned int)v12 >= *(_DWORD *)(v10 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v9,
            v7,
            *(_QWORD *)(*(_QWORD *)(v11[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v9 + 24) = v12 + 1;
          *(_QWORD *)(v10 + 8 * v12 + 32) = v7;
        }
      }
    }
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v21, qword_8D05190);
  v13 = *((_QWORD *)self + 17);
  if ( v13 == 0 )
LABEL_26:
    il2cpp_codegen_raise_null_reference_exception();
  v14 = 0;
  while ( 1 )
  {
    v15 = *(_DWORD *)(v13 + 24);
    if ( v14 >= v15 )
      break;
    Item = System_Collections_Generic_List_object___get_Item(v13, (unsigned int)v14, qword_8D0E6A0);
    if ( *((_QWORD *)self + 15) != 0 )
    {
      v17 = Item;
      Value = System_Collections_Generic_Dictionary_object__object___TryGetValue(
                *((_QWORD *)self + 15),
                Item,
                &v22,
                qword_8CFDFA8);
      if ( v22 != 0 && (Value & 1) != 0 )
        (*(void (__fastcall **)(_QWORD, _QWORD))(v22 + 24))(*(_QWORD *)(v22 + 64), *(_QWORD *)(v22 + 40));
      TimeModuleO_TimeManager__RemoveTimerEvent(self, v17);
      v13 = *((_QWORD *)self + 17);
      ++v14;
      if ( v13 != 0 )
        continue;
    }
    goto LABEL_26;
  }
  v19 = *(_DWORD *)(v13 + 28) + 1;
  *(_DWORD *)(v13 + 24) = 0;
  *(_DWORD *)(v13 + 28) = v19;
  if ( v15 >= 1 )
    System_Array__Clear(*(_QWORD *)(v13 + 16), 0);
}
