void *GameFramework_Fsm_Fsm_object___GetState_52a8f74(void *this, void *stateType, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v5; // x0
  void *v7; // [xsp+8h] [xbp-18h] BYREF

  v7 = nullptr;
  if ( stateType == nullptr
    || (v3 = *((_QWORD *)this + 5),
        v5 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)stateType + 776LL))(
               stateType,
               *(_QWORD *)(*(_QWORD *)stateType + 784LL)),
        v3 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(
          v3,
          v5,
          &v7,
          *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 248LL))
      & 1) != 0 )
    return v7;
  else
    return nullptr;
}
