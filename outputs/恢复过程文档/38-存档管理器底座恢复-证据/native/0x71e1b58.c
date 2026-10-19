void *GameFramework_Utility_AssemblyUtility__LoadAssembly(void *name, const MethodInfo *method)
{
  _QWORD **v3; // x0
  __int64 v4; // x0
  _QWORD **v5; // x0
  __int64 v6; // x0
  void *v8; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_900965C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF6750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDFE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDFF0);
    byte_900965C = 1;
  }
  v3 = (_QWORD **)off_8CF6750;
  v8 = nullptr;
  if ( *((_DWORD *)off_8CF6750 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CF6750);
    v3 = (_QWORD **)off_8CF6750;
  }
  v4 = *v3[23];
  if ( v4 == 0 )
    goto LABEL_13;
  if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v4, name, &v8, qword_8CFDFF0) & 1) == 0 )
  {
    v8 = (void *)System_Reflection_Assembly__Load(name, 0);
    if ( (System_Reflection_Assembly__op_Inequality(v8, 0, 0) & 1) != 0 )
    {
      v5 = (_QWORD **)off_8CF6750;
      if ( *((_DWORD *)off_8CF6750 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CF6750);
        v5 = (_QWORD **)off_8CF6750;
      }
      v6 = *v5[23];
      if ( v6 != 0 )
      {
        System_Collections_Generic_Dictionary_object__object___Add(v6, name, v8, qword_8CFDFE8);
        return v8;
      }
LABEL_13:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
  return v8;
}
