void ljzs_lt_GameStart__StartGame(void *self, const MethodInfo *method)
{
  __int64 Module_object; // x0

  if ( (byte_900088C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36008);
    byte_900088C = 1;
  }
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D170);
  if ( Module_object == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameFramework_Procedure_ProcedureManager__StartProcedure_object_(Module_object, qword_8D36008);
}
