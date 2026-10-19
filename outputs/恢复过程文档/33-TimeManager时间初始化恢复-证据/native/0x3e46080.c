void TimeModuleO_TimeManager__SyncServerTime(void *self, const MethodInfo *method)
{
  __int64 v2; // x1
  __int64 v4; // x0

  if ( *((_BYTE *)self + 36) == 0 )
  {
    v2 = *((_QWORD *)self + 18);
    if ( v2 != 0 )
      UnityEngine_MonoBehaviour__StopCoroutine(self, v2, 0);
    v4 = TimeModuleO_TimeManager__SyncServerTimeCoroutine(self);
    *((_QWORD *)self + 18) = UnityEngine_MonoBehaviour__StartCoroutine(self, v4, 0);
  }
}
