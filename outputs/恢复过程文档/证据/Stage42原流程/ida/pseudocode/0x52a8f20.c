unsigned __int8 GameFramework_Fsm_Fsm_object___HasState_52a8f20(void *this, void *stateType, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v5; // x0

  if ( stateType == nullptr
    || (v3 = *((_QWORD *)this + 5),
        v5 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)stateType + 776LL))(
               stateType,
               *(_QWORD *)(*(_QWORD *)stateType + 784LL)),
        v3 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  return System_Collections_Generic_Dictionary_object__object___ContainsKey(
           v3,
           v5,
           *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL));
}
