void *GameFramework_Utility_Text__GetFullName_71e37c0(void *type, void *name, const MethodInfo *method)
{
  void *v5; // x20

  if ( (byte_9009678 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D857D0);
    byte_9009678 = 1;
  }
  if ( type == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v5 = (void *)(*(__int64 (__fastcall **)(void *, _QWORD, const MethodInfo *))(*(_QWORD *)type + 776LL))(
                 type,
                 *(_QWORD *)(*(_QWORD *)type + 784LL),
                 method);
  if ( (System_String__IsNullOrEmpty(name, 0) & 1) != 0 )
    return v5;
  else
    return (void *)sub_750AA4C(qword_8D857D0, v5, name, 0);
}
