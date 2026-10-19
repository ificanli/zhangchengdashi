void GameFramework_Fsm_FsmState_object___OnEvent_52a8814(
        void *this,
        void *fsm,
        void *sender,
        int eventId,
        void *userData,
        const MethodInfo *method)
{
  __int64 v6; // x0
  __int64 v10; // [xsp+8h] [xbp-28h] BYREF

  v10 = 0;
  v6 = *((_QWORD *)this + 2);
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_Collections_Generic_Dictionary_int__object___TryGetValue(
          v6,
          (unsigned int)eventId,
          &v10,
          *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 88LL))
      & 1) != 0
    && v10 != 0 )
  {
    (*(void (__fastcall **)(_QWORD, void *, void *, void *, _QWORD))(v10 + 24))(
      *(_QWORD *)(v10 + 64),
      fsm,
      sender,
      userData,
      *(_QWORD *)(v10 + 40));
  }
}
