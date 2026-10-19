void ljzs_lt_Procedure_ProcedureStarGame__OnLeave(
        void *self,
        void *owner,
        unsigned __int8 shutdown,
        const MethodInfo *method)
{
  __int64 Module_object; // x0
  unsigned int v8; // w20
  __int64 v9; // x21
  __int64 v10; // x22
  __int64 v11; // x20

  if ( (byte_90008D2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36050);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6D0D0);
    byte_90008D2 = 1;
  }
  GameFramework_Procedure_ProcedureBase__OnLeave(self, owner, shutdown & 1, 0);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D188);
  v8 = *((_DWORD *)self + 8);
  v9 = Module_object;
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8488);
  System_Action_int____ctor(v10, self, qword_8D36048, 0);
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameFramework_TimeModule__RemoveLoopTimer(v9, v8, v10, 0);
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4100);
  GameFramework_MsgDispatcher_EventHandler___ctor(v11, self, qword_8D36050, 0);
  GameFramework_MsgDispatcher__RemoveEventListener(qword_8D6D0D0, v11, 0);
}
