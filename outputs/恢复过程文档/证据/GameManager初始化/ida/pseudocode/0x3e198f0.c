void GameModule_GameManager__Update(void *self, const MethodInfo *method)
{
  __int64 v2; // x19

  if ( *((_BYTE *)self + 32) != 0 )
  {
    v2 = *((_QWORD *)self + 5);
    if ( v2 != 0 )
    {
      UnityEngine_Time__get_deltaTime(0, method);
      GameModule_UpdateController__ToUpdate(v2, 0);
    }
  }
}
