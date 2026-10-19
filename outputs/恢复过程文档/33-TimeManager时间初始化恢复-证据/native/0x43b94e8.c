void L_Tools_ServerTimeMgr__TryCheck(void *self, unsigned __int8 state, const MethodInfo *method)
{
  if ( (state & 1) != 0 )
  {
    L_Tools_ServerTimeMgr__GetCurrentServerTime(self);
    *((_DWORD *)self + 15) = 0;
  }
}
