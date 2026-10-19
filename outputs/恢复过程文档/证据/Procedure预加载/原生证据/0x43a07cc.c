void ljzs_lt_Procedure_ProcedureStarGame__OnEnter(void *self, void *owner, const MethodInfo *method)
{
  __int64 v5; // x20
  __int64 Module_object; // x20
  __int64 v7; // x21
  _QWORD *v8; // x0
  __int64 v9; // x0
  __int64 v10; // x0

  if ( (byte_90008CD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7BE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7D40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36050);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6D0D0);
    byte_90008CD = 1;
  }
  GameFramework_Procedure_ProcedureBase__OnEnter(self, owner, 0);
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
  GameFramework_MsgDispatcher_EventHandler___ctor(v5, self, qword_8D36050, 0);
  GameFramework_MsgDispatcher__AddEventListener(qword_8D6D0D0, v5, 0);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D188);
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8488);
  System_Action_int____ctor(v7, self, qword_8D36058, 0);
  if ( Module_object == 0 )
    goto LABEL_12;
  *((_DWORD *)self + 8) = GameFramework_TimeModule__AddLoopTimer(Module_object, 30, 1, v7, 1, 0, 0);
  v8 = off_8CEC810;
  if ( *((_DWORD *)off_8CEC810 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CEC810);
    v8 = off_8CEC810;
  }
  v9 = *(_QWORD *)(v8[23] + 8LL);
  if ( v9 == 0 )
LABEL_12:
    il2cpp_codegen_raise_null_reference_exception();
  DBTSDK_ReportManager__StartGameModel(v9, 0, 0);
  **((_BYTE **)off_8CE7BE8 + 23) = 1;
  if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7D40);
  v10 = GameFramework_GlobalData__CheckNewDay(0);
  ljzs_lt_Procedure_ProcedureStarGame__StarGame(v10);
}
