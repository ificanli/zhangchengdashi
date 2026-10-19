unsigned __int8 GameFramework_Fsm_FsmManager__DestroyFsm_object__4c80920(
        void *this,
        void *fsm,
        const MethodInfo *method)
{
  __int64 v6; // x1
  __int64 v7; // x8
  __int64 v8; // x9
  int *v9; // x10
  __int64 v10; // x0
  void *v11; // x1
  void *v12; // x0
  const MethodInfo *v13; // x2
  __int64 v14; // x0
  __int64 v15; // x20
  __int64 v16; // x0

  if ( *((_QWORD *)method + 7) == 0 )
    ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  if ( fsm != nullptr )
  {
    v6 = **((_QWORD **)method + 7);
    if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
      v6 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(**((_QWORD **)method + 7));
    v7 = *(_QWORD *)fsm;
    v8 = *(unsigned __int16 *)(*(_QWORD *)fsm + 302LL);
    if ( *(_WORD *)(*(_QWORD *)fsm + 302LL) != 0 )
    {
      v9 = (int *)(*(_QWORD *)(v7 + 176) + 8LL);
      while ( *((_QWORD *)v9 - 1) != v6 )
      {
        --v8;
        v9 += 4;
        if ( v8 == 0 )
          goto LABEL_10;
      }
      v10 = v7 + 16LL * *v9 + 312;
    }
    else
    {
LABEL_10:
      v10 = ((__int64 (__fastcall *)(void *, __int64, _QWORD))unk_3C504A4)(fsm, v6, 0);
    }
    v11 = (void *)(*(__int64 (__fastcall **)(void *, _QWORD))v10)(fsm, *(_QWORD *)(v10 + 8));
    v12 = this;
    v13 = *(const MethodInfo **)(*((_QWORD *)method + 7) + 16LL);
  }
  else
  {
    v14 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v14);
    v16 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600D0);
    GameFramework_GameFrameworkException___ctor(v15, v16, 0);
    v12 = (void *)((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v15, method);
  }
  return GameFramework_Fsm_FsmManager__DestroyFsm_object_(v12, v11, v13);
}
