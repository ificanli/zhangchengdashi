__int64 TimeModuleO_TimeManager__GetLocalNetworkTime(void *self, const MethodInfo *method)
{
  int v3; // w19
  __int64 Now; // [xsp+8h] [xbp-18h] BYREF

  if ( (byte_8FFD9FE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_8FFD9FE = 1;
  }
  if ( *((_DWORD *)self + 8) == 1 )
  {
    if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
    Now = System_DateTime__get_Now(0, method);
    v3 = *((_DWORD *)self + 20);
  }
  else
  {
    if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64C0);
    Now = L_Tools_DateTools__GetNow(0, method);
    v3 = *((_DWORD *)self + 20);
    if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6460);
  }
  return System_DateTime__AddHours(&Now, 0, (double)v3);
}
