void GameFramework_Fsm_Fsm_object___Start_52a8dbc(void *this, void *stateType, void *args, const MethodInfo *method)
{
  __int64 State; // x0
  __int64 v9; // x0
  __int64 v10; // x20
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x20
  __int64 v14; // x21
  __int64 v15; // x0
  __int64 v16; // x20
  __int64 v17; // x0
  __int64 v18; // x21

  if ( this == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( ((*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)this + 440LL))(
          this,
          *(_QWORD *)(*(_QWORD *)this + 448LL))
      & 1) != 0 )
  {
    v9 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v9);
    v11 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600D8);
    GameFramework_GameFrameworkException___ctor(v10, v11, 0);
    v12 = v10;
LABEL_11:
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v12, method);
    JUMPOUT(0x52A8F20);
  }
  State = GameFramework_Fsm_Fsm_object___GetState(
            this,
            stateType,
            *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 216LL));
  if ( State == 0 )
  {
    ((void (__fastcall *)(void *))unk_35C5DE8)(this);
    v13 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_35FB8E0)(
            *((_QWORD *)this + 2),
            *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 48LL));
    ((void (__fastcall *)(void *))unk_35C5DE8)(stateType);
    v14 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)stateType + 776LL))(
            stateType,
            *(_QWORD *)(*(_QWORD *)stateType + 784LL));
    v15 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D600C0);
    v16 = sub_750AA4C(v15, v13, v14, 0);
    v17 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v18 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v17);
    GameFramework_GameFrameworkException___ctor(v18, v16, 0);
    v12 = v18;
    goto LABEL_11;
  }
  *((_DWORD *)this + 16) = 0;
  *((_QWORD *)this + 7) = State;
  if ( args != nullptr && *((_QWORD *)args + 3) != 0 )
    (*(void (__fastcall **)(__int64, void *, void *, _QWORD))(*(_QWORD *)State + 408LL))(
      State,
      this,
      args,
      *(_QWORD *)(*(_QWORD *)State + 416LL));
  else
    (*(void (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)State + 392LL))(
      State,
      this,
      *(_QWORD *)(*(_QWORD *)State + 400LL));
}
