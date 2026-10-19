void TimeModuleO_TimeManager__InitializeTimeSource_d__31__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x22
  _QWORD *v4; // x8
  __int64 v5; // x20
  __int64 v6; // x21
  __int64 v7; // x20
  __int64 v8; // x1
  __int64 v9; // x21
  __int64 v10; // x2
  __int64 v11; // x7
  __int64 v12; // x20
  __int64 v13; // x1
  __int64 v14; // x21
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x8
  __int64 v19; // x9
  _DWORD *v20; // x10
  __int64 v21; // x0
  __int64 v22; // x0
  __int64 v23; // x1
  __int64 v24; // x8
  __int64 v25; // x9
  int *v26; // x10
  __int64 v27; // x0
  _QWORD *v28; // x20
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 OnlineParam; // x0
  __int64 v34; // x3
  int v35; // w8
  __int64 *v36; // x19
  __int64 v37; // x8
  __int64 v38; // x9
  _DWORD *v39; // x10
  __int64 v40; // x0
  __int128 v41; // [xsp+0h] [xbp-40h] BYREF

  if ( (byte_8FFE391 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1ED38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF98E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF98E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDAD28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D17878);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE590);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ACB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF5E90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76FF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53268);
    byte_8FFE391 = 1;
  }
  v41 = 0u;
  v3 = *((_QWORD *)self + 3);
  if ( *(_DWORD *)self != 0 )
  {
    v4 = off_8CF5E90;
    if ( *((_DWORD *)off_8CF5E90 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF5E90);
      v4 = off_8CF5E90;
    }
    v5 = *(_QWORD *)(v4[23] + 8LL);
    if ( v5 == 0 )
    {
      if ( *((_DWORD *)v4 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v4);
        v4 = off_8CF5E90;
      }
      v6 = *(_QWORD *)v4[23];
      v5 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDAD28, method);
      System_Func_bool____ctor(v5, v6, qword_8D4ACB8, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF5E90 + 23) + 8LL) = v5;
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    v7 = Cysharp_Threading_Tasks_UniTask__WaitUntil(v5, 8, 0, 0, 0);
    v9 = v8;
    if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEE590);
    v10 = System_TimeSpan__FromSeconds(0, 10.0);
    v12 = Cysharp_Threading_Tasks_UniTaskExtensions__TimeoutWithoutException(
            v7,
            v9,
            v10,
            0,
            8,
            0,
            0,
            v11,
            v41,
            *((_QWORD *)&v41 + 1));
    v14 = v13;
    if ( (*(_BYTE *)(*((_QWORD *)off_8D19928 + 4) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    *(_QWORD *)&v41 = v12;
    *((_QWORD *)&v41 + 1) = v14;
    v15 = *((_QWORD *)off_8CF98E8 + 4);
    if ( (*(_BYTE *)(v15 + 309) & 1) == 0 )
    {
      v15 = ((__int64 (*)(void))unk_3C503A0)();
      v12 = v41;
    }
    if ( v12 != 0 )
    {
      v16 = *(_QWORD *)(*(_QWORD *)(*(_QWORD *)(v15 + 192) + 24LL) + 32LL);
      if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
        v16 = ((__int64 (*)(void))unk_3C503A0)();
      v17 = *(_QWORD *)(*(_QWORD *)(v16 + 192) + 8LL);
      if ( (*(_BYTE *)(v17 + 309) & 1) == 0 )
        v17 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v16 + 192) + 8LL));
      v18 = *(_QWORD *)v12;
      v19 = *(unsigned __int16 *)(*(_QWORD *)v12 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v12 + 302LL) != 0 )
      {
        v20 = (_DWORD *)(*(_QWORD *)(v18 + 176) + 8LL);
        while ( *((_QWORD *)v20 - 1) != v17 )
        {
          --v19;
          v20 += 4;
          if ( v19 == 0 )
            goto LABEL_27;
        }
        v21 = v18 + 16LL * (*v20 + 1) + 312;
      }
      else
      {
LABEL_27:
        v21 = ((__int64 (__fastcall *)(__int64, __int64, __int64))unk_3C504A4)(v12, v17, 1);
      }
      if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v21)(v12, WORD5(v41), *(_QWORD *)(v21 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *((_OWORD *)self + 2) = v41;
        ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_3F84E68)(
          (char *)self + 8,
          &v41,
          self,
          qword_8D1ED38);
        return;
      }
    }
  }
  else
  {
    v41 = *((_OWORD *)self + 2);
    *((_QWORD *)self + 4) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
  }
  if ( (_QWORD)v41 == 0 )
  {
    if ( BYTE8(v41) == 0 )
      goto LABEL_46;
LABEL_42:
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    goto LABEL_61;
  }
  v22 = *((_QWORD *)off_8CF98E0 + 4);
  if ( (*(_BYTE *)(v22 + 309) & 1) == 0 )
    v22 = ((__int64 (*)(void))unk_3C503A0)();
  v23 = *(_QWORD *)(*(_QWORD *)(v22 + 192) + 40LL);
  if ( (*(_BYTE *)(v23 + 309) & 1) == 0 )
    v23 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v22 + 192) + 40LL));
  v24 = *(_QWORD *)v41;
  v25 = *(unsigned __int16 *)(*(_QWORD *)v41 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v41 + 302LL) != 0 )
  {
    v26 = (int *)(*(_QWORD *)(v24 + 176) + 8LL);
    while ( *((_QWORD *)v26 - 1) != v23 )
    {
      --v25;
      v26 += 4;
      if ( v25 == 0 )
        goto LABEL_40;
    }
    v27 = v24 + 16LL * *v26 + 312;
  }
  else
  {
LABEL_40:
    v27 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v41, v23, 0);
  }
  if ( ((*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v27)(v41, WORD5(v41), *(_QWORD *)(v27 + 8)) & 1) != 0 )
    goto LABEL_42;
LABEL_46:
  v28 = off_8D17878;
  v29 = *((_QWORD *)off_8D17878 + 4);
  if ( (*(_BYTE *)(v29 + 309) & 1) == 0 )
    v29 = ((__int64 (*)(void))unk_3C503A0)();
  v30 = *(_QWORD *)(*(_QWORD *)(v29 + 192) + 16LL);
  if ( (*(_BYTE *)(v30 + 309) & 1) == 0 )
    v30 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v30 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v30);
  v31 = v28[4];
  if ( (*(_BYTE *)(v31 + 309) & 1) == 0 )
    v31 = ((__int64 (*)(void))unk_3C503A0)();
  v32 = *(_QWORD *)(*(_QWORD *)(v31 + 192) + 16LL);
  if ( (*(_BYTE *)(v32 + 309) & 1) == 0 )
    v32 = ((__int64 (*)(void))unk_3C503A0)();
  if ( **(_QWORD **)(v32 + 184) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  OnlineParam = L_Tools_OnlineParamControl__GetOnlineParam();
  if ( (System_String__op_Equality(OnlineParam, qword_8D53268, 0, v34) & 1) == 0 )
  {
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
LABEL_61:
    v35 = 0;
    goto LABEL_62;
  }
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v35 = 1;
LABEL_62:
  *(_DWORD *)(v3 + 32) = v35;
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v36 = *((__int64 **)self + 1);
  if ( v36 != nullptr )
  {
    v37 = *v36;
    v38 = *(unsigned __int16 *)(*v36 + 302);
    if ( *(_WORD *)(*v36 + 302) != 0 )
    {
      v39 = (_DWORD *)(*(_QWORD *)(v37 + 176) + 8LL);
      while ( *((_QWORD *)v39 - 1) != qword_8CE9038 )
      {
        --v38;
        v39 += 4;
        if ( v38 == 0 )
          goto LABEL_69;
      }
      v40 = v37 + 16LL * (*v39 + 2) + 312;
    }
    else
    {
LABEL_69:
      v40 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v36, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v40)(v36, *(_QWORD *)(v40 + 8));
  }
}
