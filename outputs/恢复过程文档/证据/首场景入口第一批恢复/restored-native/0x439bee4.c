void ljzs_lt_GameStart__RegisterLogicCtr(void *self, const MethodInfo *method)
{
  __int64 Module_object; // x19
  __int64 I; // x0
  __int64 v5; // x19
  __int64 v6; // x0
  __int64 v7; // x19
  __int64 v8; // x0

  if ( (byte_900088B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB068);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D160);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D173B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D173C8);
    byte_900088B = 1;
  }
  GameFramework_Base_IGameStart__RegisterLogicCtr(self, 0);
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D160);
  I = L_Tools_RichControlBase_object___get_I(qword_8D173C8);
  if ( Module_object == 0
    || (GameFramework_MineGameLogicModule__RegisterLogicCtr(Module_object, I, 0, 0),
        v5 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D160),
        v6 = L_Tools_RichControlBase_object___get_I(qword_8D173B8),
        v5 == 0)
    || (GameFramework_MineGameLogicModule__RegisterLogicCtr(v5, v6, 0, 0),
        v7 = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D160),
        v8 = GameFramework_ControlBase_object___get_I(qword_8CFB068),
        v7 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  GameFramework_MineGameLogicModule__RegisterLogicCtr(v7, v8, 0, 0);
}
