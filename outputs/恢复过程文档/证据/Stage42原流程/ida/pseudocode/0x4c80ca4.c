unsigned __int8 GameFramework_Fsm_FsmManager__HasFsm_object__4c80ca4(void *this, void *name, const MethodInfo *method)
{
  _QWORD *v3; // x8
  __int64 v7; // x20
  __int64 FullName_object; // x0

  v3 = *((_QWORD **)method + 7);
  if ( v3 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4D8);
    v3 = *((_QWORD **)method + 7);
    if ( v3 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v3 = *((_QWORD **)method + 7);
    }
  }
  v7 = *((_QWORD *)this + 4);
  FullName_object = GameFramework_Utility_Text__GetFullName_object_(name, *v3);
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return System_Collections_Generic_Dictionary_object__object___ContainsKey(v7, FullName_object, qword_8CFE4D8);
}
