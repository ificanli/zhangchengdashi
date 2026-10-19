void GameFramework_Procedure_ProcedureBase__OnEnter_727a644(void *this, void *procedureOwner, const MethodInfo *method)
{
  __int64 v5; // x19
  __int64 Type; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x1
  __int64 v14; // x2
  float v15; // s0
  float v16; // s1

  if ( (byte_9009C2D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5F378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D519A8);
    byte_9009C2D = 1;
  }
  GameFramework_Fsm_FsmState_object___OnEnter(this, procedureOwner, qword_8D061C0);
  v5 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  Type = System_Object__GetType(this, 0);
  if ( Type == 0
    || (v7 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 776LL))(
               Type,
               *(_QWORD *)(*(_QWORD *)Type + 784LL)),
        v8 = sub_750A330(qword_8D5F378, v7, qword_8D519A8, 0),
        v5 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  v9 = v8;
  if ( v8 != 0 )
  {
    v10 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v8, *(_QWORD *)(*(_QWORD *)v5 + 64LL));
    if ( v10 == 0 )
      goto LABEL_13;
  }
  if ( *(_DWORD *)(v5 + 24) == 0 )
  {
    v10 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_13:
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v10);
    v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v11, 0);
    GameFramework_Procedure_ProcedureBase__OnUpdate(v12, v13, v14, v15, v16);
    return;
  }
  *(_QWORD *)(v5 + 32) = v9;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__LogProcedure(v5, 0);
}
