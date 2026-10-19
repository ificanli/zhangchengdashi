// local variable allocation has failed, the output may be wrong!
ZCDS_Int32 GameModule_BattleGameSceneManager__GetAvailableSlots(
        GameModule_BattleGameSceneManager_o *self,
        ZCDS_Bool isEnemy,
        const MethodInfo *method)
{
  __int64 Instance; // x0
  __int64 v6; // x8
  __int64 v7; // x9
  int v8; // w8

  if ( (byte_8FFD76B & 1) == 0 )
  {
    ((void (__fastcall *)(__int64 *, ZCDS_Bool, const MethodInfo *))unk_3C3D280)(&qword_8D17890, isEnemy, method);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE1928);
    byte_8FFD76B = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, isEnemy, method);
  if ( Instance == 0 )
  {
    ((void (*)(void))unk_3C3D4CC)();
    JUMPOUT(0x3DEDA74);
  }
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) == 0 )
    return 0x7FFFFFFF;
  v6 = 512;
  if ( (isEnemy & 1) != 0 )
  {
    v6 = 516;
    v7 = 524;
  }
  else
  {
    v7 = 520;
  }
  v8 = *(_DWORD *)((char *)&self->klass + v6) + *(_DWORD *)((char *)&self->klass + v7);
  return (100 - v8) & ~((100 - v8) >> 31);
}
