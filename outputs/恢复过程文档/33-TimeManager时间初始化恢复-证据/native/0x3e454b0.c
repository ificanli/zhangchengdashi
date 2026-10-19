__int64 TimeModuleO_TimeManager__GetNetworkTime(void *self, unsigned __int8 standard, const MethodInfo *method)
{
  if ( (standard & 1) != 0 )
    return TimeModuleO_TimeManager__GetStandardNetworkTime(self);
  else
    return TimeModuleO_TimeManager__GetLocalNetworkTime(self);
}
