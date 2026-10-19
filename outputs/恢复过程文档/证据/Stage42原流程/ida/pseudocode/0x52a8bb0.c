void *GameFramework_Fsm_Fsm_object___get_CurrentStateName_52a8bb0(void *this, const MethodInfo *method)
{
  void *result; // x0
  __int64 Type; // x0

  result = *((void **)this + 7);
  if ( result != nullptr )
  {
    Type = System_Object__GetType(result, 0);
    if ( Type == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    return (*(void *(__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 776LL))(
             Type,
             *(_QWORD *)(*(_QWORD *)Type + 784LL));
  }
  return result;
}
