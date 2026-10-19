void GameFramework_Fsm_Fsm_object___ChangeState_52a9308(
        void *this,
        void *stateType,
        void *args,
        const MethodInfo *method)
{
  void *State; // x0
  void *v9; // x23
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x20
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x20
  __int64 v16; // x21
  __int64 v17; // x0
  __int64 v18; // x20
  __int64 v19; // x0
  __int64 v20; // x21

  if ( *((_QWORD *)this + 7) == 0 )
  {
    v11 = ((__int64 (__fastcall *)(void *, void *, void *))unk_3C3D294)(&unk_8CE7B50, stateType, args);
    v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v11);
    v13 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D5D620);
    GameFramework_GameFrameworkException___ctor(v12, v13, 0);
    v14 = v12;
LABEL_10:
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v14, method);
LABEL_11:
    il2cpp_codegen_raise_null_reference_exception();
  }
  State = GameFramework_Fsm_Fsm_object___GetState(
            this,
            stateType,
            *(const MethodInfo **)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 216LL));
  if ( State == nullptr )
  {
    ((void (__fastcall *)(void *))unk_35C5DE8)(this);
    v15 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_35FB8E0)(
            *((_QWORD *)this + 2),
            *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 48LL));
    ((void (__fastcall *)(void *))unk_35C5DE8)(stateType);
    v16 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)stateType + 776LL))(
            stateType,
            *(_QWORD *)(*(_QWORD *)stateType + 784LL));
    v17 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600B8);
    v18 = sub_750AA4C(v17, v15, v16, 0);
    v19 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v20 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v19);
    GameFramework_GameFrameworkException___ctor(v20, v18, 0);
    v14 = v20;
    goto LABEL_10;
  }
  v9 = State;
  v10 = *((_QWORD *)this + 7);
  if ( v10 == 0 )
    goto LABEL_11;
  (*(void (__fastcall **)(__int64, void *, _QWORD, _QWORD))(*(_QWORD *)v10 + 440LL))(
    v10,
    this,
    0,
    *(_QWORD *)(*(_QWORD *)v10 + 448LL));
  *((_DWORD *)this + 16) = 0;
  *((_QWORD *)this + 7) = v9;
  if ( args != nullptr && *((_QWORD *)args + 3) != 0 )
    (*(void (__fastcall **)(void *, void *, void *, _QWORD))(*(_QWORD *)v9 + 408LL))(
      v9,
      this,
      args,
      *(_QWORD *)(*(_QWORD *)v9 + 416LL));
  else
    (*(void (__fastcall **)(void *, void *, _QWORD))(*(_QWORD *)v9 + 392LL))(
      v9,
      this,
      *(_QWORD *)(*(_QWORD *)v9 + 400LL));
}
