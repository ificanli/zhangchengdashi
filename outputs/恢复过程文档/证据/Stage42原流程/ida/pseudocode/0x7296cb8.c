int GameFramework_Fsm_FsmManager__get_Count_7296cb8(void *this, const MethodInfo *method)
{
  __int64 v3; // x0

  if ( (byte_9009D29 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4F8);
    byte_9009D29 = 1;
  }
  v3 = *((_QWORD *)this + 4);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return System_Collections_Generic_Dictionary_object__object___get_Count(v3, qword_8CFE4F8);
}
