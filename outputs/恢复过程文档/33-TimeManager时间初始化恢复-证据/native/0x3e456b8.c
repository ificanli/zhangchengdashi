void TimeModuleO_TimeManager__InitToZeroTimer(void *self, const MethodInfo *method)
{
  const MethodInfo *v2; // x2
  void *Timer; // x0
  const MethodInfo *v5; // x2
  __int64 TimeSpanToZero; // x0
  const MethodInfo *v7; // x5
  void *v8; // x0
  __int64 TimeSpanToZeroStandardNetworkTime; // x0
  const MethodInfo *v10; // x5

  if ( (byte_8FFD9F3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D73758);
    byte_8FFD9F3 = 1;
  }
  Timer = TimeModuleO_TimeManager__GetTimer(self, (void *)qword_8D73750, v2);
  if ( Timer == nullptr )
  {
    TimeSpanToZero = TimeModuleO_TimeManager__GetTimeSpanToZero(self);
    Timer = TimeModuleO_TimeManager__CreateTimer(self, (void *)qword_8D73750, TimeSpanToZero, 1u, 0, v7);
  }
  if ( self == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)self + 11) = Timer;
  v8 = TimeModuleO_TimeManager__GetTimer(self, (void *)qword_8D73758, v5);
  if ( v8 == nullptr )
  {
    TimeSpanToZeroStandardNetworkTime = TimeModuleO_TimeManager__GetTimeSpanToZeroStandardNetworkTime(self);
    v8 = TimeModuleO_TimeManager__CreateTimer(
           self,
           (void *)qword_8D73758,
           TimeSpanToZeroStandardNetworkTime,
           1u,
           1u,
           v10);
  }
  *((_QWORD *)self + 12) = v8;
}
