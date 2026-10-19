unsigned __int8 TimeModuleO_TimeManager___c___InitializeTimeSource_b__31_0(void *self, const MethodInfo *method)
{
  __int64 v2; // x0

  if ( (byte_8FFE38B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C0);
    byte_8FFE38B = 1;
  }
  v2 = **((_QWORD **)off_8CE40C0 + 23);
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return DBTSDK_AppInfoManager__IsOnlineParamReady_Override(v2, 0);
}
