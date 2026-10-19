void TimeModuleO_TimeManager__Init_d__29__MoveNext(void *self, const MethodInfo *method)
{
  int v3; // w8
  __int64 v4; // x20
  __int64 v5; // x21
  __int64 v6; // x21
  __int64 v7; // x21
  __int64 v8; // x21
  __int64 v9; // x21
  __int64 v10; // x1
  __int64 v11; // x22
  __int64 v12; // x8
  __int64 v13; // x9
  int *v14; // x10
  __int64 v15; // x0
  __int64 v16; // x8
  __int64 v17; // x9
  _DWORD *v18; // x10
  __int64 v19; // x0
  __int64 Timers; // x1
  int Int; // w0
  int v22; // w8
  __int64 v23; // x1
  __int64 v24; // x8
  __int64 v25; // x9
  int *v26; // x10
  __int64 v27; // x0
  __int64 v28; // x8
  __int64 v29; // x9
  _DWORD *v30; // x10
  __int64 v31; // x0
  int v32; // w9
  int v33; // w8
  __int64 v34; // x1
  __int64 v35; // x8
  __int64 v36; // x9
  int *v37; // x10
  __int64 v38; // x0
  __int64 v39; // x8
  __int64 v40; // x9
  _DWORD *v41; // x10
  __int64 v42; // x0
  __int64 *v43; // x19
  __int64 v44; // x8
  __int64 v45; // x9
  _DWORD *v46; // x10
  __int64 v47; // x0
  __int128 v48; // [xsp+0h] [xbp-70h] BYREF

  if ( (byte_8FFE390 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F8F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDF78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFC80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9BF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA198);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBB00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68F30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78A08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87748);
    byte_8FFE390 = 1;
  }
  v48 = 0u;
  v3 = *(_DWORD *)self;
  v4 = *((_QWORD *)self + 3);
  if ( *(_DWORD *)self != 0 )
  {
    if ( v3 == 1 )
    {
      v48 = *((_OWORD *)self + 2);
      *((_QWORD *)self + 4) = 0;
      *((_QWORD *)self + 5) = 0;
      *(_DWORD *)self = -1;
      goto LABEL_60;
    }
    if ( v3 == 2 )
    {
      v48 = *((_OWORD *)self + 2);
      *((_QWORD *)self + 4) = 0;
      *((_QWORD *)self + 5) = 0;
      *(_DWORD *)self = -1;
      goto LABEL_95;
    }
    v5 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDA198, method);
    System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFFC80);
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v4 + 40) = v5;
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9BF8);
    System_Collections_Generic_Dictionary_object__object____ctor(v6, qword_8CFDF78);
    *(_QWORD *)(v4 + 120) = v6;
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA198);
    System_Collections_Generic_Dictionary_object__object____ctor(v7, qword_8CFFC80);
    *(_QWORD *)(v4 + 128) = v7;
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v8, qword_8D0E5E0);
    *(_QWORD *)(v4 + 136) = v8;
    v9 = TimeModuleO_TimeManager__InitializeTimeSource(v4, 0);
    v11 = v10;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v48 = v9;
    *((_QWORD *)&v48 + 1) = v11;
    if ( byte_8FFD1AD == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
      byte_8FFD1AD = 1;
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    if ( byte_8FFD1AE == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AE = 1;
    }
    if ( (_QWORD)v48 != 0 )
    {
      v12 = *(_QWORD *)v48;
      v13 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
      {
        v14 = (int *)(*(_QWORD *)(v12 + 176) + 8LL);
        while ( *((_QWORD *)v14 - 1) != qword_8CE91C8 )
        {
          --v13;
          v14 += 4;
          if ( v13 == 0 )
            goto LABEL_23;
        }
        v15 = v12 + 16LL * *v14 + 312;
      }
      else
      {
LABEL_23:
        v15 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v48, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v15)(v48, WORD4(v48), *(_QWORD *)(v15 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *((_OWORD *)self + 2) = v48;
        ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_3F84D60)(
          (char *)self + 8,
          &v48,
          self,
          qword_8D1F8F0);
        return;
      }
    }
  }
  else
  {
    v48 = *((_OWORD *)self + 2);
    *((_QWORD *)self + 4) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v48 != 0 )
  {
    v16 = *(_QWORD *)v48;
    v17 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
    {
      v18 = (_DWORD *)(*(_QWORD *)(v16 + 176) + 8LL);
      while ( *((_QWORD *)v18 - 1) != qword_8CE91C8 )
      {
        --v17;
        v18 += 4;
        if ( v17 == 0 )
          goto LABEL_33;
      }
      v19 = v16 + 16LL * (*v18 + 2) + 312;
    }
    else
    {
LABEL_33:
      v19 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v48, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v19)(v48, WORD4(v48), *(_QWORD *)(v19 + 8));
  }
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  TimeModuleO_TimeManager__SyncServerTime(v4, 0);
  Timers = TimeModuleO_TimeManager__LoadTimers(v4, 0);
  UnityEngine_MonoBehaviour__StartCoroutine(v4, Timers, 0);
  if ( *((_DWORD *)off_8CEBB00 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEBB00);
  Int = L_Tools_PlayerPrefs2Center__GetInt(qword_8D68F30, 0, 0);
  v22 = *(_DWORD *)(v4 + 32);
  *(_DWORD *)(v4 + 80) = Int;
  *(_BYTE *)(v4 + 112) = 1;
  if ( v22 == 0 )
  {
    *((_QWORD *)self + 6) = 0x6400000000LL;
    while ( 1 )
    {
      if ( v4 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v4 + 37) != 0 )
        break;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      *(_QWORD *)&v48 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.1);
      *((_QWORD *)&v48 + 1) = v23;
      if ( byte_8FFD1AD == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
        byte_8FFD1AD = 1;
      }
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      if ( byte_8FFD1AE == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AE = 1;
      }
      if ( (_QWORD)v48 != 0 )
      {
        v24 = *(_QWORD *)v48;
        v25 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
        {
          v26 = (int *)(*(_QWORD *)(v24 + 176) + 8LL);
          while ( *((_QWORD *)v26 - 1) != qword_8CE91C8 )
          {
            --v25;
            v26 += 4;
            if ( v25 == 0 )
              goto LABEL_57;
          }
          v27 = v24 + 16LL * *v26 + 312;
        }
        else
        {
LABEL_57:
          v27 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v48, qword_8CE91C8, 0);
        }
        if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v27)(v48, WORD4(v48), *(_QWORD *)(v27 + 8)) == 0 )
        {
          *(_DWORD *)self = 1;
          *((_OWORD *)self + 2) = v48;
          ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_3F84D60)(
            (char *)self + 8,
            &v48,
            self,
            qword_8D1F8F0);
          return;
        }
      }
LABEL_60:
      if ( byte_8FFD1AF == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AF = 1;
      }
      if ( (_QWORD)v48 != 0 )
      {
        v28 = *(_QWORD *)v48;
        v29 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
        {
          v30 = (_DWORD *)(*(_QWORD *)(v28 + 176) + 8LL);
          while ( *((_QWORD *)v30 - 1) != qword_8CE91C8 )
          {
            --v29;
            v30 += 4;
            if ( v29 == 0 )
              goto LABEL_67;
          }
          v31 = v28 + 16LL * (*v30 + 2) + 312;
        }
        else
        {
LABEL_67:
          v31 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v48, qword_8CE91C8, 2);
        }
        (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v31)(v48, WORD4(v48), *(_QWORD *)(v31 + 8));
      }
      v32 = *((_DWORD *)self + 13);
      v33 = *((_DWORD *)self + 12) + 1;
      *((_DWORD *)self + 12) = v33;
      if ( v33 % v32 == 0 )
      {
        if ( **((_QWORD **)off_8CECCD8 + 23) == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        DBTSDK_SDKToolManager__ShowToast();
      }
    }
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__Log(qword_8D78A08, 0);
  }
  if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEDF8);
  *(_QWORD *)&v48 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.1);
  *((_QWORD *)&v48 + 1) = v34;
  if ( byte_8FFD1AD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD1AD = 1;
  }
  if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEDF8);
  if ( byte_8FFD1AE == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AE = 1;
  }
  if ( (_QWORD)v48 != 0 )
  {
    v35 = *(_QWORD *)v48;
    v36 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
    {
      v37 = (int *)(*(_QWORD *)(v35 + 176) + 8LL);
      while ( *((_QWORD *)v37 - 1) != qword_8CE91C8 )
      {
        --v36;
        v37 += 4;
        if ( v36 == 0 )
          goto LABEL_91;
      }
      v38 = v35 + 16LL * *v37 + 312;
    }
    else
    {
LABEL_91:
      v38 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v48, qword_8CE91C8, 0);
    }
    if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v38)(v48, WORD4(v48), *(_QWORD *)(v38 + 8)) == 0 )
    {
      *(_DWORD *)self = 2;
      *((_OWORD *)self + 2) = v48;
      ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_3F84D60)(
        (char *)self + 8,
        &v48,
        self,
        qword_8D1F8F0);
      return;
    }
  }
LABEL_95:
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v48 != 0 )
  {
    v39 = *(_QWORD *)v48;
    v40 = *(unsigned __int16 *)(*(_QWORD *)v48 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v48 + 302LL) != 0 )
    {
      v41 = (_DWORD *)(*(_QWORD *)(v39 + 176) + 8LL);
      while ( *((_QWORD *)v41 - 1) != qword_8CE91C8 )
      {
        --v40;
        v41 += 4;
        if ( v40 == 0 )
          goto LABEL_102;
      }
      v42 = v39 + 16LL * (*v41 + 2) + 312;
    }
    else
    {
LABEL_102:
      v42 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v48, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v42)(v48, WORD4(v48), *(_QWORD *)(v42 + 8));
  }
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  TimeModuleO_TimeManager__HandleTimeToWeekCutDown(v4, 0);
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v43 = *((__int64 **)self + 1);
  if ( v43 != nullptr )
  {
    v44 = *v43;
    v45 = *(unsigned __int16 *)(*v43 + 302);
    if ( *(_WORD *)(*v43 + 302) != 0 )
    {
      v46 = (_DWORD *)(*(_QWORD *)(v44 + 176) + 8LL);
      while ( *((_QWORD *)v46 - 1) != qword_8CE9038 )
      {
        --v45;
        v46 += 4;
        if ( v45 == 0 )
          goto LABEL_113;
      }
      v47 = v44 + 16LL * (*v46 + 2) + 312;
    }
    else
    {
LABEL_113:
      v47 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v43, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v47)(v43, *(_QWORD *)(v47 + 8));
  }
}
