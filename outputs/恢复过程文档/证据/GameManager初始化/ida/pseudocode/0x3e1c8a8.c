void GameModule_GameManager___c___RegisterOnTimeToMonDayZero_b__22_3(void *self, const MethodInfo *method)
{
  __int64 v2; // x8
  __int64 v3; // x8
  __int64 v4; // x19
  __int64 Keys; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  __int64 Instance; // x0
  _QWORD v11[2]; // [xsp+8h] [xbp-68h] BYREF
  __int64 v12; // [xsp+18h] [xbp-58h]

  if ( (byte_8FFD8AA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE238);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE248);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B5A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03028);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D03030);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D03038);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E638);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6D400);
    byte_8FFD8AA = 1;
  }
  v11[0] = 0;
  v11[1] = 0;
  v12 = 0;
  v2 = **((_QWORD **)off_8CD9250 + 23);
  if ( v2 == 0 )
    goto LABEL_13;
  v3 = *(_QWORD *)(v2 + 48);
  if ( v3 == 0 )
    goto LABEL_13;
  v4 = *(_QWORD *)(v3 + 272);
  if ( v4 == 0 )
    goto LABEL_13;
  Keys = System_Collections_Generic_Dictionary_object__bool___get_Keys(v4, qword_8CFE238);
  v6 = System_Linq_Enumerable__ToList_object_(Keys, qword_8D2B5A0);
  if ( v6 == 0 )
    goto LABEL_13;
  System_Collections_Generic_List_object___GetEnumerator(v11, v6, qword_8D0E638);
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(v11, qword_8D03030) & 1) != 0 )
    System_Collections_Generic_Dictionary_object__bool___set_Item(v4, v12, 0, qword_8CFE248);
  System_Collections_Generic_List_Enumerator_object___Dispose(v11, qword_8D03028);
  v7 = **((_QWORD **)off_8CD9250 + 23);
  if ( v7 == 0
    || (DbtSaveDataManagerBase_object__object___Save(v7, qword_8CFB3A8),
        (Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v8, v9)) == 0) )
  {
LABEL_13:
    il2cpp_codegen_raise_null_reference_exception();
  }
  EventModule_EventManager__TriggerEvent(Instance, qword_8D6D400, 0, 0);
}
