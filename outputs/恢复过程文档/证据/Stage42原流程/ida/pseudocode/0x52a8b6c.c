int GameFramework_Fsm_Fsm_object___get_FsmStateCount_52a8b6c(void *this, const MethodInfo *method)
{
  __int64 v2; // x0

  v2 = *((_QWORD *)this + 5);
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return System_Collections_Generic_Dictionary_object__object___get_Count(
           v2,
           *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 96LL));
}
