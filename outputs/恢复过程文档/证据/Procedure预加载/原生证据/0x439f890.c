void ljzs_lt_Procedure_ProcedurePreLoad__PreLoad(void *self, const MethodInfo *method)
{
  _QWORD *v3; // x21
  __int64 v4; // x20
  __int64 v5; // x8
  __int64 v6; // x0
  __int64 v7; // x0

  if ( (byte_90008C6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D1D5E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89430);
    byte_90008C6 = 1;
  }
  ljzs_lt_Procedure_ProcedurePreLoad__PreLoadAsync(self, method);
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(qword_8D89430, 0);
  v3 = off_8D1D5E8;
  v4 = *((_QWORD *)self + 3);
  v5 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v5 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v5 = v3[7];
  }
  v6 = *(_QWORD *)(v5 + 16);
  if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
    v6 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v6 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v6);
  v7 = *(_QWORD *)(v3[7] + 16LL);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_Fsm_FsmState_object___ChangeState_object_(self, v4, **(_QWORD **)(v7 + 184), qword_8D061A8);
}
