void GameFramework_Procedure_ProcedureBase__OnLeave_727a800(
        void *this,
        void *procedureOwner,
        unsigned __int8 isShutdown,
        const MethodInfo *method)
{
  __int64 v7; // x19
  __int64 Type; // x0
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x1
  __int64 v16; // x2

  if ( (byte_9009C2F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D65E40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D519A8);
    byte_9009C2F = 1;
  }
  GameFramework_Fsm_FsmState_object___OnLeave(this, procedureOwner, isShutdown & 1, qword_8D061D0);
  v7 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  Type = System_Object__GetType(this, 0);
  if ( Type == 0
    || (v9 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 776LL))(
               Type,
               *(_QWORD *)(*(_QWORD *)Type + 784LL)),
        v10 = sub_750A330(qword_8D65E40, v9, qword_8D519A8, 0),
        v7 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  v11 = v10;
  if ( v10 != 0 )
  {
    v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v10, *(_QWORD *)(*(_QWORD *)v7 + 64LL));
    if ( v12 == 0 )
      goto LABEL_13;
  }
  if ( *(_DWORD *)(v7 + 24) == 0 )
  {
    v12 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_13:
    v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v12);
    v14 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v13, 0);
    GameFramework_Procedure_ProcedureBase__OnDestroy(v14, v15, v16);
    return;
  }
  *(_QWORD *)(v7 + 32) = v11;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__LogProcedure(v7, 0);
}
