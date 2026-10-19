void GameFramework_Fsm_FsmState_object___ChangeState_object__47327b4(
        void *this,
        void *fsm,
        void *args,
        const MethodInfo *method)
{
  __int64 v7; // x1
  void *v8; // x1
  void *v9; // x0
  const MethodInfo *v10; // x2
  __int64 v11; // x0
  __int64 v12; // x20
  __int64 v13; // x0

  if ( *((_QWORD *)method + 7) == 0 )
    ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  v7 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 72LL);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 72LL));
  if ( fsm == nullptr )
  {
    v11 = ((__int64 (__fastcall *)(void *, __int64))unk_3C3D294)(&unk_8CE7B50, v7);
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v11);
    v13 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600D0);
    GameFramework_GameFrameworkException___ctor(v12, v13, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v12, method);
    goto LABEL_10;
  }
  if ( *(_QWORD *)fsm != v7 )
  {
LABEL_10:
    v9 = (void *)((__int64 (__fastcall *)(void *))unk_3C3D868)(fsm);
    goto LABEL_8;
  }
  v8 = args;
  v9 = fsm;
  v10 = **((const MethodInfo ***)method + 7);
LABEL_8:
  GameFramework_Fsm_Fsm_object___ChangeState_object_(v9, v8, v10);
}
