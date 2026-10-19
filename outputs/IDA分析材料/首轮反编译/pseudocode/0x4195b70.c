void CoreModule_GameLauncher__Start_d__5__MoveNext(void *self, const MethodInfo *method)
{
  _QWORD *v2; // x19
  __int64 v3; // x20
  __int64 v4; // x8
  __int64 v5; // x9
  int *v6; // x10
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  _DWORD *v10; // x10
  __int64 v11; // x0
  __int64 v12; // x1
  __int64 v13; // x2
  __int64 Instance; // x0
  __int64 v15; // x0
  int v16; // w1
  _QWORD **v17; // x20
  __int64 v18; // x0
  _QWORD *v19; // x20
  __int64 v20; // x0
  __int128 v21; // [xsp+0h] [xbp-40h] BYREF

  v2 = self;
  if ( (byte_8FFF6C0 & 1) == 0 )
  {
    ((void (__fastcall *)(__int64 *, const MethodInfo *))unk_3C3D280)(&qword_8D22320, method);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D12298);
    self = (void *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEEDF8);
    byte_8FFF6C0 = 1;
  }
  v21 = 0u;
  v3 = v2[5];
  if ( *(_DWORD *)v2 == 0 )
  {
    v21 = *((_OWORD *)v2 + 3);
    v2[6] = 0;
    v2[7] = 0;
    *(_DWORD *)v2 = -1;
LABEL_22:
    if ( byte_8FFD1AF == 0 )
    {
      ((void (__fastcall *)(__int64 *, const MethodInfo *))unk_3C3D280)(&qword_8CE91C8, method);
      byte_8FFD1AF = 1;
    }
    if ( (_QWORD)v21 != 0 )
    {
      v8 = *(_QWORD *)v21;
      v9 = *(unsigned __int16 *)(*(_QWORD *)v21 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v21 + 302LL) != 0 )
      {
        v10 = (_DWORD *)(*(_QWORD *)(v8 + 176) + 8LL);
        while ( *((_QWORD *)v10 - 1) != qword_8CE91C8 )
        {
          --v9;
          v10 += 4;
          if ( v9 == 0 )
            goto LABEL_29;
        }
        v11 = v8 + 16LL * (*v10 + 2) + 312;
      }
      else
      {
LABEL_29:
        v11 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v21, qword_8CE91C8, 2);
      }
      (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v11)(v21, WORD4(v21), *(_QWORD *)(v11 + 8));
    }
    if ( v3 != 0 )
    {
      CoreModule_GameLauncher__StartLoadingCompletedListening(v3, method);
      Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12298, v12, v13);
      if ( Instance != 0 )
      {
        LoadingModule_LoadingManager__StartLoading(Instance, 0);
        CoreModule_GameLauncher__Login(v3);
        *(_DWORD *)v2 = -2;
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(v2 + 1, 0);
        return;
      }
    }
    else
    {
      Instance = ((__int64 (*)(void))unk_3C3D4CC)();
    }
    self = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4CC)(Instance);
    goto LABEL_38;
  }
  if ( v3 != 0 )
  {
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      ((void (__fastcall *)(void *, const MethodInfo *))unk_3C3D3B0)(off_8CEEDF8, method);
    v21 = *(_OWORD *)(v3 + 32);
    if ( byte_8FFD1AD == 0 )
    {
      ((void (__fastcall *)(_UNKNOWN **, const MethodInfo *))unk_3C3D280)(&off_8CEEDF8, method);
      byte_8FFD1AD = 1;
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      ((void (*)(void))unk_3C3D3B0)();
    if ( byte_8FFD1AE == 0 )
    {
      ((void (__fastcall *)(__int64 *, const MethodInfo *))unk_3C3D280)(&qword_8CE91C8, method);
      byte_8FFD1AE = 1;
    }
    if ( (_QWORD)v21 != 0 )
    {
      v4 = *(_QWORD *)v21;
      v5 = *(unsigned __int16 *)(*(_QWORD *)v21 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v21 + 302LL) != 0 )
      {
        v6 = (int *)(*(_QWORD *)(v4 + 176) + 8LL);
        while ( *((_QWORD *)v6 - 1) != qword_8CE91C8 )
        {
          --v5;
          v6 += 4;
          if ( v5 == 0 )
            goto LABEL_18;
        }
        v7 = v4 + 16LL * *v6 + 312;
      }
      else
      {
LABEL_18:
        v7 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v21, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v7)(v21, WORD4(v21), *(_QWORD *)(v7 + 8)) == 0 )
      {
        *(_DWORD *)v2 = 0;
        *((_OWORD *)v2 + 3) = v21;
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__GameLauncher__Start_d__5_(
          v2 + 1,
          &v21,
          v2,
          qword_8D22320);
        return;
      }
    }
    goto LABEL_22;
  }
LABEL_38:
  v15 = ((__int64 (__fastcall *)(void *, const MethodInfo *))unk_3C3D4CC)(self, method);
  if ( v16 != 1 )
  {
    v20 = ((__int64 (__fastcall *)(__int64))unk_3CE73C4)(v15);
    ((void (__fastcall *)(__int64))unk_35BC500)(v20);
    JUMPOUT(0x75B007C);
  }
  v17 = (_QWORD **)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v15);
  v18 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
  if ( (((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D8F8)(v18, **v17) & 1) == 0 )
  {
    *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8) = *v17;
    ((void (__noreturn *)(void))__cxa_throw)();
  }
  v19 = *v17;
  ((void (*)(void))__cxa_end_catch)();
  *(_DWORD *)v2 = -2;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetException(v2 + 1, v19, 0);
}
