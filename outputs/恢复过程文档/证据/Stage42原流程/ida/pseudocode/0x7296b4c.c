void GameFramework_Fsm_FsmBase___ctor_7296b4c(void *this, void *name, const MethodInfo *method)
{
  if ( (byte_9009D27 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_9009D27 = 1;
  }
  System_Object___ctor(this, 0);
  if ( name == nullptr )
    name = **((void ***)off_8CEDAE8 + 23);
  if ( this == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)this + 2) = name;
}
