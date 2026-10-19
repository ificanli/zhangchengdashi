void ljzs_lt_Procedure_ProcedureStarGame__ReportGameTimes(void *self, int times, const MethodInfo *method)
{
  _QWORD *v4; // x0
  __int64 v5; // x0

  if ( (byte_90008CE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC810);
    byte_90008CE = 1;
  }
  v4 = off_8CEC810;
  if ( *((_DWORD *)off_8CEC810 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CEC810);
    v4 = off_8CEC810;
  }
  v5 = *(_QWORD *)(v4[23] + 8LL);
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  DBTSDK_ReportManager__ReportGamePlayTime(v5, (unsigned int)times, 0);
}
