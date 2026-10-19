void TimeModuleO_TimeManager__InitToWeekTimer(void *self, const MethodInfo *method)
{
  const MethodInfo *v2; // x2
  void *Timer; // x0
  __int64 TimeSpanToWeek; // x0
  const MethodInfo *v6; // x5

  if ( (byte_8FFD9F5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73740);
    byte_8FFD9F5 = 1;
  }
  Timer = TimeModuleO_TimeManager__GetTimer(self, (void *)qword_8D73740, v2);
  if ( Timer == nullptr )
  {
    TimeSpanToWeek = TimeModuleO_TimeManager__GetTimeSpanToWeek(self);
    Timer = TimeModuleO_TimeManager__CreateTimer(self, (void *)qword_8D73740, TimeSpanToWeek, 1u, 0, v6);
  }
  if ( self == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)self + 13) = Timer;
}
