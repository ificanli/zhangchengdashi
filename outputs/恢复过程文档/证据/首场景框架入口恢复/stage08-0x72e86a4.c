void GameFramework_Base_GameStartEntry__Awake(void *self, const MethodInfo *method)
{
  char v3; // w21
  _QWORD *v4; // x0
  __int64 v5; // x21
  __int64 v6; // x21
  __int64 Component_object; // x21
  __int64 v8; // x0
  __int64 v9; // x19
  __int64 v10; // x0
  __int64 v11; // x8
  _QWORD *v12; // x0
  void *v13; // x8
  int32x2_t *v14; // x8
  unsigned __int64 v15; // x21
  _QWORD *v16; // x0
  __int64 v17; // x0
  __int64 Module_object; // x20
  __int64 v19; // x21
  _QWORD *v20; // x19
  __int64 v21; // x8
  __int64 v22; // x0
  __int64 v23; // x0
  __int64 v24; // x0

  if ( (byte_900A04E & 1) == 0 )
  {
    ((void (__fastcall *)(__int64 *, const MethodInfo *))unk_3C3D280)(&qword_8CE3CE0, method);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE40C8);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8D1D5E8);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE5250);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D26098);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D2D198);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE7B30);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D2E198);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE7D40);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8CE3258);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEB3E0);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEF158);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D87D40);
    byte_900A04E = 1;
  }
  v3 = *((_BYTE *)self + 76);
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( byte_900A1BA == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **, const MethodInfo *))unk_3C3D280)(&off_8CE40C8, method);
    byte_900A1BA = 1;
  }
  v4 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    ((void (*)(void))unk_3C3D3B0)();
    v4 = off_8CE40C8;
  }
  *(_BYTE *)(v4[23] + 58LL) = v3;
  v5 = *((_QWORD *)self + 6);
  if ( byte_900A1BB == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **, const MethodInfo *))unk_3C3D280)(&off_8CE40C8, method);
    v4 = off_8CE40C8;
    byte_900A1BB = 1;
  }
  if ( *((_DWORD *)v4 + 56) == 0 )
  {
    ((void (*)(void))unk_3C3D3B0)();
    v4 = off_8CE40C8;
  }
  *(_QWORD *)(v4[23] + 48LL) = v5;
  v6 = *((_QWORD *)self + 10);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( (UnityEngine_Object__op_Equality(v6, 0, 0) & 1) != 0 )
  {
    Component_object = UnityEngine_Component__GetComponent_object_(self, qword_8D26098);
    *((_QWORD *)self + 10) = Component_object;
  }
  else
  {
    Component_object = *((_QWORD *)self + 10);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( (UnityEngine_Object__op_Equality(Component_object, 0, 0) & 1) != 0 )
  {
    v8 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    if ( v8 != 0 )
    {
      v9 = v8;
      if ( qword_8D87D40 != 0 )
      {
        v10 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D87D40, *(_QWORD *)(*(_QWORD *)v8 + 64LL));
        if ( v10 == 0 )
        {
LABEL_64:
          v24 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v10);
          ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v24, 0);
          JUMPOUT(0x72E8B14);
        }
      }
      if ( *(_DWORD *)(v9 + 24) != 0 )
      {
        *(_QWORD *)(v9 + 32) = qword_8D87D40;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          ((void (*)(void))unk_3C3D3B0)();
        GameFramework_CLog__Error(v9, 0);
        return;
      }
LABEL_63:
      v10 = ((__int64 (*)(void))unk_3C3D4D4)();
      goto LABEL_64;
    }
LABEL_62:
    ((void (*)(void))unk_3C3D4CC)();
    goto LABEL_63;
  }
  v11 = *((_QWORD *)self + 10);
  if ( v11 == 0 )
    goto LABEL_62;
  *(_QWORD *)(v11 + 32) = self;
  *((_BYTE *)self + 72) = 0;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  GameFramework_AppSetting__SetCultureBasedOnSetting(0);
  if ( byte_9008D60 == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE40C8);
    byte_9008D60 = 1;
  }
  v12 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    ((void (*)(void))unk_3C3D3B0)();
    v12 = off_8CE40C8;
  }
  if ( *(_BYTE *)(v12[23] + 89LL) != 0 )
  {
    v13 = off_8CE7D40;
    if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
    {
      ((void (__fastcall *)(void *))unk_3C3D3B0)(off_8CE7D40);
      v13 = off_8CE7D40;
      v12 = off_8CE40C8;
    }
    v14 = *((int32x2_t **)v13 + 23);
    v15 = v14[1].n64_u64[0];
    *((_QWORD *)self + 5) = v15;
    *((int32x2_t *)self + 8) = vrev64_s32(v14[2]);
  }
  else
  {
    v15 = *((_QWORD *)self + 5);
  }
  if ( *((_DWORD *)v12 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( byte_900876C == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE40C8);
    byte_900876C = 1;
  }
  v16 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    ((void (*)(void))unk_3C3D3B0)();
    v16 = off_8CE40C8;
  }
  *(_QWORD *)(v16[23] + 40LL) = v15;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  UnityEngine_Object__DontDestroyOnLoad(self, 0);
  if ( *((_DWORD *)off_8CEF158 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  GameFramework_UserDataPrefs__OnInit(0);
  v17 = *((_QWORD *)self + 10);
  if ( v17 == 0 )
    goto LABEL_62;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v17 + 504LL))(v17, *(_QWORD *)(*(_QWORD *)v17 + 512LL));
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D198);
  v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
  System_Action___ctor(v19, self, qword_8D2E198, 0);
  v20 = off_8D1D5E8;
  v21 = *((_QWORD *)off_8D1D5E8 + 7);
  if ( v21 == 0 )
  {
    ((void (__fastcall *)(void *))unk_3C503FC)(off_8D1D5E8);
    v21 = v20[7];
  }
  v22 = *(_QWORD *)(v21 + 16);
  if ( (*(_BYTE *)(v22 + 309) & 1) == 0 )
    v22 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v22 + 224) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  v23 = *(_QWORD *)(v20[7] + 16LL);
  if ( (*(_BYTE *)(v23 + 309) & 1) == 0 )
    v23 = ((__int64 (*)(void))unk_3C503A0)();
  GameFramework_GameFrameEntry__Initialize(Module_object, v19, **(_QWORD **)(v23 + 184), 0);
}
