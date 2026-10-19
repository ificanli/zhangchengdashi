void GameFramework_Fsm_FsmState_object___OnDestroy_52a84e0(void *this, void *fsm, const MethodInfo *method)
{
  __int64 v3; // x0

  v3 = *((_QWORD *)this + 2);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_int__object___Clear(
    v3,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 24LL));
}
