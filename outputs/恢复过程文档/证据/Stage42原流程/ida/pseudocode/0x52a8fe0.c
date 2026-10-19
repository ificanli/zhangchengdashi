void GameFramework_Fsm_Fsm_object___FireEvent_52a8fe0(void *this, void *sender, int eventId, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v7; // x0
  __int64 v8; // x20
  __int64 v9; // x0

  v5 = *((_QWORD *)this + 7);
  if ( v5 == 0 )
  {
    v7 = ((__int64 (__fastcall *)(void *, void *, int))unk_3C3D294)(&unk_8CE7B50, sender, eventId);
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v7);
    v9 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5D620);
    GameFramework_GameFrameworkException___ctor(v8, v9, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v8, method);
    JUMPOUT(0x52A9060);
  }
  GameFramework_Fsm_FsmState_object___OnEvent(
    v5,
    this,
    sender,
    (unsigned int)eventId,
    0,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 264LL));
}
