__int64 TimeModuleO_TimeManager__GetTimeSpanToWeek(void *self, const MethodInfo *method)
{
  __int64 v3; // x2
  int DayOfWeek; // w8
  int v5; // w19
  int v6; // w8
  __int64 Date; // x0
  __int64 v9; // [xsp+0h] [xbp-30h] BYREF
  __int64 LocalNetworkTime; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_8FFDA0F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    byte_8FFDA0F = 1;
  }
  v9 = 0;
  LocalNetworkTime = TimeModuleO_TimeManager__GetLocalNetworkTime(self, method);
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  DayOfWeek = System_DateTime__get_DayOfWeek(&LocalNetworkTime, 0, v3);
  v5 = (8 - DayOfWeek) / 7 - (DayOfWeek + 8 * ((8 - DayOfWeek) / 7)) + 8;
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  if ( v5 != 0 )
    v6 = v5;
  else
    v6 = 7;
  v9 = System_DateTime__AddDays(&LocalNetworkTime, 0, (double)v6);
  Date = System_DateTime__get_Date(&v9, 0);
  return System_DateTime__op_Subtraction(Date, LocalNetworkTime, 0);
}
