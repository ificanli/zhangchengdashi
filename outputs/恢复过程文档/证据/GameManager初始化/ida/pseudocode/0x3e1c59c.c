void GameModule_GameManager___c___RegisterOnTimeToMonDayZero_b__22_0(void *self, const MethodInfo *method)
{
  __int64 v2; // x8
  __int64 v3; // x8
  __int64 v4; // x19
  __int64 Keys; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  _QWORD v8[2]; // [xsp+8h] [xbp-58h] BYREF
  __int64 v9; // [xsp+18h] [xbp-48h]

  if ( (byte_8FFD8A7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B5A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03028);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03030);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D03038);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E638);
    byte_8FFD8A7 = 1;
  }
  v8[0] = 0;
  v8[1] = 0;
  v9 = 0;
  v2 = **((_QWORD **)off_8CD9250 + 23);
  if ( v2 == 0 )
    goto LABEL_12;
  v3 = *(_QWORD *)(v2 + 48);
  if ( v3 == 0 )
    goto LABEL_12;
  v4 = *(_QWORD *)(v3 + 184);
  if ( v4 == 0 )
    goto LABEL_12;
  Keys = System_Collections_Generic_Dictionary_object__int___get_Keys(v4, qword_8CFEAA0);
  v6 = System_Linq_Enumerable__ToList_object_(Keys, qword_8D2B5A0);
  if ( v6 == 0 )
    goto LABEL_12;
  System_Collections_Generic_List_object___GetEnumerator(v8, v6, qword_8D0E638);
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(v8, qword_8D03030) & 1) != 0 )
    System_Collections_Generic_Dictionary_object__int___set_Item(v4, v9, 0, qword_8CFEAB0);
  System_Collections_Generic_List_Enumerator_object___Dispose(v8, qword_8D03028);
  v7 = **((_QWORD **)off_8CD9250 + 23);
  if ( v7 == 0 )
LABEL_12:
    il2cpp_codegen_raise_null_reference_exception();
  DbtSaveDataManagerBase_object__object___Save(v7, qword_8CFB3A8);
}
