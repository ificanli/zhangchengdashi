void ljzs_lt_Procedure_ProcedureStarGame__GotoTestScene(void *self, const MethodInfo *method)
{
  if ( (byte_90008D0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D67788);
    byte_90008D0 = 1;
  }
  if ( *((_DWORD *)off_8CEC898 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEC898);
  GameFramework_ResLoadHelper__LoadScene(qword_8D67788, 0, 0, 0, 0);
}
