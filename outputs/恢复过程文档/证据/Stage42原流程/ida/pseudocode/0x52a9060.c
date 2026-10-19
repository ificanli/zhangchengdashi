void GameFramework_Fsm_Fsm_object___FireEvent_52a9060(
        void *this,
        void *sender,
        int eventId,
        void *userData,
        const MethodInfo *method)
{
  __int64 v6; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0

  v6 = *((_QWORD *)this + 7);
  if ( v6 == 0 )
  {
    v8 = ((__int64 (__fastcall *)(void *, void *, int, void *))unk_3C3D294)(&unk_8CE7B50, sender, eventId, userData);
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v8);
    v10 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5D620);
    GameFramework_GameFrameworkException___ctor(v9, v10, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v9, method);
    JUMPOUT(0x52A90E0);
  }
  GameFramework_Fsm_FsmState_object___OnEvent(
    v6,
    this,
    sender,
    (unsigned int)eventId,
    userData,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 264LL));
}
