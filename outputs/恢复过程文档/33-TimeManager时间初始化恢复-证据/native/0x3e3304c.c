void TimeModuleO_TimeManager__RemoveTimerEvent(void *self, void *key, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 v8; // x0

  if ( (byte_8FFDA03 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDF90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFCA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDFA0);
    byte_8FFDA03 = 1;
  }
  v5 = *((_QWORD *)self + 15);
  if ( v5 == 0 )
    goto LABEL_12;
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v5, key, qword_8CFDF90) & 1) != 0 )
  {
    v6 = *((_QWORD *)self + 15);
    if ( v6 == 0 )
      goto LABEL_12;
    System_Collections_Generic_Dictionary_object__object___Remove(v6, key, qword_8CFDFA0);
  }
  v7 = *((_QWORD *)self + 16);
  if ( v7 == 0 )
LABEL_12:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v7, key, qword_8CFFC98) & 1) != 0 )
  {
    v8 = *((_QWORD *)self + 16);
    if ( v8 != 0 )
    {
      System_Collections_Generic_Dictionary_object__object___Remove(v8, key, qword_8CFFCA8);
      return;
    }
    goto LABEL_12;
  }
}
