void *TimeModuleO_TimeManager__CreateTimer(
        void *self,
        void *key,
        __int64 duration,
        unsigned __int8 countdown,
        unsigned __int8 standard,
        const MethodInfo *method)
{
  void *v11; // x24
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x2

  if ( (byte_8FFDA01 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF5EC0);
    byte_8FFDA01 = 1;
  }
  v11 = nullptr;
  if ( (ToolModule_StringTool__IsNullOrEmpty(key, 1, 0) & 1) == 0 )
  {
    v12 = *((_QWORD *)self + 5);
    if ( v12 != 0 )
    {
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v12, key, qword_8CFFC98) & 1) != 0 )
        return nullptr;
      v11 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF5EC0);
      TimeModuleO_TimeManager_Timer___ctor(v11, key, duration, countdown & 1, standard & 1, nullptr);
      v13 = *((_QWORD *)self + 5);
      if ( v13 != 0 )
      {
        v14 = System_Collections_Generic_Dictionary_object__object___Add(v13, key, v11, qword_8CFFC88);
        TimeModuleO_TimeManager__InitAddTimeInfo(v14, v11, v15);
        return v11;
      }
    }
    il2cpp_codegen_raise_null_reference_exception();
  }
  return v11;
}
