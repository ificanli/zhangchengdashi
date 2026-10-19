void ljzs_lt_Procedure_ProcedureStarGame__ReadyExitGame(void *self, void *args, const MethodInfo *method)
{
  _QWORD *v4; // x21
  __int64 v5; // x20
  __int64 v6; // x8
  __int64 v7; // x0
  __int64 v8; // x0

  if ( (byte_90008D1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D67778);
    byte_90008D1 = 1;
  }
  GameFramework_MsgDispatcher__SendMessage(qword_8D67778, 0, method);
  v4 = off_8D1D5E8;
  v5 = *((_QWORD *)self + 3);
  v6 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v6 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v6 = v4[7];
  }
  v7 = *(_QWORD *)(v6 + 16);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v7 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v7);
  v8 = *(_QWORD *)(v4[7] + 16LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_Fsm_FsmState_object___ChangeState_object_(self, v5, **(_QWORD **)(v8 + 184), qword_8D061A0);
}
