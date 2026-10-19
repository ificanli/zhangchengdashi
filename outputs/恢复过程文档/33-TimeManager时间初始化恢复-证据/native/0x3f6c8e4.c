void TimeModuleO_TimeManager_Timer___ctor(
        void *self,
        void *key,
        __int64 duration,
        unsigned __int8 countdown,
        unsigned __int8 standard,
        const MethodInfo *method)
{
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 2) = key;
  *((_BYTE *)self + 40) = standard & 1;
  TimeModuleO_TimeManager_Timer__Restart(self, duration, countdown & 1);
}
