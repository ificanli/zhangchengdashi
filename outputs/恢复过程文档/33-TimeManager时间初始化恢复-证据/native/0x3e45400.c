__int64 TimeModuleO_TimeManager__GetStartOfWeekForTimeManager(void *self, __int64 datetime, const MethodInfo *method)
{
  int DayOfWeek; // w0
  __int64 v5; // [xsp+8h] [xbp-28h] BYREF
  __int64 v6; // [xsp+18h] [xbp-18h] BYREF

  v6 = datetime;
  if ( (byte_8FFD9ED & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    byte_8FFD9ED = 1;
  }
  v5 = 0;
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  DayOfWeek = System_DateTime__get_DayOfWeek(&v6, 0, method);
  v5 = System_DateTime__AddDays(&v6, 0, (double)(7 * ((DayOfWeek + 6) / 7) - (DayOfWeek + 6)));
  return System_DateTime__get_Date(&v5, 0);
}
