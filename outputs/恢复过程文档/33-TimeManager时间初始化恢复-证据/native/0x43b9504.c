void L_Tools_ServerTimeMgr__MakeCheck(void *self, const MethodInfo *method)
{
  L_Tools_ServerTimeMgr__GetCurrentServerTime(self);
  *((_DWORD *)self + 15) = 0;
}
