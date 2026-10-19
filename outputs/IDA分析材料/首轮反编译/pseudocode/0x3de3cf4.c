// local variable allocation has failed, the output may be wrong!
void GameModule_BattleGameManager__ChangeCoin(void *self, int coinNum, const MethodInfo *method)
{
  int v3; // w20
  __int64 Instance; // x21
  int v6; // w8
  __int64 v7; // x0
  int v8; // w8
  int v9; // w21
  int v10; // w8
  int v11; // w8
  __int64 v12; // x1
  __int64 v13; // x2
  __int64 v14; // x20
  int v15; // [xsp+8h] [xbp-48h] BYREF
  int v16; // [xsp+Ch] [xbp-44h] BYREF

  v3 = coinNum;
  if ( (byte_8FFD73A & 1) == 0 )
  {
    ((void (__fastcall *)(__int64 *, int, const MethodInfo *))unk_3C3D280)(&qword_8CE95C0, coinNum, method);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D12148);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D5C020);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D6C128);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D6C138);
    byte_8FFD73A = 1;
  }
  if ( v3 < 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, *(_QWORD *)&coinNum, method);
    if ( byte_8FFD308 == 0 )
    {
      ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEA738);
      byte_8FFD308 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      ((void (*)(void))unk_3C3D3B0)();
    if ( v3 >= 0 )
      v6 = v3;
    else
      v6 = -v3;
    v16 = v6;
    v7 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v16);
    if ( Instance == 0 )
    {
LABEL_30:
      ((void (__fastcall *)(__int64))unk_3C3D4CC)(v7);
      JUMPOUT(0x3DE3F10);
    }
    EventModule_EventManager__TriggerEvent(Instance, qword_8D6C138, v7, 0);
    v8 = *((_DWORD *)self + 10);
    v9 = *((_DWORD *)self + 13);
    if ( v8 < -v3 )
      v3 = -v8;
    if ( byte_8FFD308 == 0 )
    {
      ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEA738);
      byte_8FFD308 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      ((void (*)(void))unk_3C3D3B0)();
    if ( v3 >= 0 )
      v10 = v3;
    else
      v10 = -v3;
    *((_DWORD *)self + 13) = v10 + v9;
  }
  else if ( v3 != 0 )
  {
    *((_DWORD *)self + 12) += v3;
  }
  v11 = *((_DWORD *)self + 10) + v3;
  if ( v11 >= 10000000 )
    v11 = 10000000;
  *((_DWORD *)self + 10) = v11 & ~(v11 >> 31);
  v7 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, *(_QWORD *)&coinNum, method);
  if ( v7 == 0 )
    goto LABEL_30;
  EventModule_EventManager__TriggerEvent(v7, qword_8D5C020, 0, 0);
  v14 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v12, v13);
  v15 = *((_DWORD *)self + 10);
  v7 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v15);
  if ( v14 == 0 )
    goto LABEL_30;
  EventModule_EventManager__TriggerEvent(v14, qword_8D6C128, v7, 0);
  v7 = GameModule_SubGameBuffManager__get_Instance(0);
  if ( v7 == 0 )
    goto LABEL_30;
  GameModule_SubGameBuffManager__OnCoinChanged(v7, 0, *((unsigned int *)self + 10), 0);
}
