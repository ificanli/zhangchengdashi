void *TimeModuleO_TimeManager__GetTimer(void *self, void *key, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x0

  if ( (byte_8FFDA0A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFCB0);
    byte_8FFDA0A = 1;
  }
  if ( (ToolModule_StringTool__IsNullOrEmpty(key, 1, 0) & 1) == 0 )
  {
    v5 = *((_QWORD *)self + 5);
    if ( v5 == 0 )
      goto LABEL_9;
    if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v5, key, qword_8CFFC98) & 1) != 0 )
    {
      v6 = *((_QWORD *)self + 5);
      if ( v6 != 0 )
        return (void *)System_Collections_Generic_Dictionary_object__object___get_Item(v6, key, qword_8CFFCB0);
LABEL_9:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
  return nullptr;
}
