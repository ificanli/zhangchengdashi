void TimeModuleO_TimeManager__ChangeTimeInfoEndTime(void *key, __int64 endTime, const MethodInfo *method)
{
  __int64 v5; // x8
  __int64 v6; // x8
  __int64 v7; // x21
  _QWORD *Instance; // x0
  __int64 v9; // x0
  __int64 Item; // x0
  __int64 v11; // x0
  __int64 v12; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFDA12 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF478);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF448);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFCB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA018);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    byte_8FFDA12 = 1;
  }
  v12 = 0;
  v5 = **((_QWORD **)off_8CD9258 + 23);
  if ( v5 == 0 )
    goto LABEL_15;
  v6 = *(_QWORD *)(v5 + 48);
  if ( v6 == 0 )
    goto LABEL_15;
  v7 = *(_QWORD *)(v6 + 16);
  if ( v7 == 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDA018, endTime, method);
    System_Collections_Generic_Dictionary_object__object____ctor(v7, qword_8CFF448);
    if ( v7 == 0 )
      goto LABEL_15;
  }
  if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, key, &v12, qword_8CFF478) & 1) == 0 )
    return;
  if ( v12 == 0
    || (*(_QWORD *)(v12 + 32) = endTime,
        (Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12478)) == nullptr)
    || (v9 = Instance[5]) == 0
    || (Item = System_Collections_Generic_Dictionary_object__object___get_Item(v9, key, qword_8CFFCB0)) == 0
    || (TimeModuleO_TimeManager_Timer__SetTargetEndTime(Item, endTime, 0), (v11 = **((_QWORD **)off_8CD9258 + 23)) == 0) )
  {
LABEL_15:
    il2cpp_codegen_raise_null_reference_exception();
  }
  DbtSaveDataManagerBase_object__object___Save(v11, qword_8CFB3E0);
}
