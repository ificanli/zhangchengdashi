void GameFramework_Fsm_FsmState_object___ChangeState_52a8758(
        void *this,
        void *fsm,
        void *stateType,
        void *args,
        const MethodInfo *method)
{
  __int64 v9; // x8
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x2
  __int64 v16; // x3
  __int64 v17; // x4
  __int64 v18; // x5

  v9 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 72LL);
  if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
    v9 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 72LL));
  if ( fsm != nullptr )
  {
    if ( *(_QWORD *)fsm == v9 )
    {
      GameFramework_Fsm_Fsm_object___ChangeState(
        fsm,
        stateType,
        args,
        *(const MethodInfo **)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 80LL));
      return;
    }
  }
  else
  {
    v10 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v10);
    v12 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600D0);
    GameFramework_GameFrameworkException___ctor(v11, v12, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v11, method);
  }
  v13 = ((__int64 (__fastcall *)(void *, __int64))unk_3C3D868)(fsm, v9);
  GameFramework_Fsm_FsmState_object___OnEvent(v13, v14, v15, v16, v17, v18);
}
