__int64 TimeModuleO_TimeManager__GetTimeSpanToZeroStandardNetworkTime(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 Date; // [xsp+0h] [xbp-30h] BYREF
  __int64 StandardNetworkTime; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFDA0E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    byte_8FFDA0E = 1;
  }
  Date = 0;
  StandardNetworkTime = TimeModuleO_TimeManager__GetStandardNetworkTime(self, method);
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  Date = System_DateTime__get_Date(&StandardNetworkTime, 0);
  v3 = System_DateTime__AddDays(&Date, 0, 1.0);
  return System_DateTime__op_Subtraction(v3, StandardNetworkTime, 0);
}
