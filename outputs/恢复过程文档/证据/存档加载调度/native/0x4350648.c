void DataModule_DataManager__LoadData_d__16__MoveNext(void *self, const MethodInfo *method)
{
  _QWORD *v2; // x19
  __int64 v3; // x22
  __int64 v4; // x8
  __int64 v5; // x9
  _DWORD *v6; // x10
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x9
  int *v10; // x10
  __int64 v11; // x0
  _QWORD *v12; // x8
  __int64 v13; // x9
  __int64 *v14; // x19
  __int64 v15; // x8
  __int64 v16; // x9
  _DWORD *v17; // x10
  __int64 v18; // x0
  __int64 v19; // x8
  __int64 v20; // x9
  int *v21; // x10
  __int64 v22; // x0
  __int64 v23; // x8
  __int64 v24; // x9
  _DWORD *v25; // x10
  __int64 v26; // x0
  __int128 v27; // [xsp+0h] [xbp-70h] BYREF

  v2 = self;
  if ( (byte_900060A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F3C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB268);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_900060A = 1;
  }
  v27 = 0u;
  v3 = v2[3];
  if ( *(_DWORD *)v2 == 0 )
  {
    v27 = *((_OWORD *)v2 + 2);
    v2[4] = 0;
    v2[5] = 0;
    *(_DWORD *)v2 = -1;
    goto LABEL_69;
  }
  if ( *(_DWORD *)v2 == 1 )
  {
    v27 = *((_OWORD *)v2 + 2);
    v2[4] = 0;
    v2[5] = 0;
    *(_DWORD *)v2 = -1;
    while ( 1 )
    {
      if ( byte_8FFD1AF == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AF = 1;
      }
      if ( (_QWORD)v27 != 0 )
      {
        v4 = *(_QWORD *)v27;
        v5 = *(unsigned __int16 *)(*(_QWORD *)v27 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v27 + 302LL) != 0 )
        {
          v6 = (_DWORD *)(*(_QWORD *)(v4 + 176) + 8LL);
          while ( *((_QWORD *)v6 - 1) != qword_8CE91C8 )
          {
            --v5;
            v6 += 4;
            if ( v5 == 0 )
              goto LABEL_14;
          }
          v7 = v4 + 16LL * (*v6 + 2) + 312;
        }
        else
        {
LABEL_14:
          v7 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v27, qword_8CE91C8, 2);
        }
        self = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v7)(v27, WORD4(v27), *(_QWORD *)(v7 + 8));
      }
LABEL_17:
      if ( **((_BYTE **)off_8CE6168 + 23) != 0 )
        break;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      *(_QWORD *)&v27 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.1);
      *((_QWORD *)&v27 + 1) = method;
      if ( byte_8FFD1AD == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
        byte_8FFD1AD = 1;
      }
      self = off_8CEEDF8;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      if ( byte_8FFD1AE == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AE = 1;
      }
      if ( (_QWORD)v27 != 0 )
      {
        v8 = *(_QWORD *)v27;
        v9 = *(unsigned __int16 *)(*(_QWORD *)v27 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v27 + 302LL) != 0 )
        {
          v10 = (int *)(*(_QWORD *)(v8 + 176) + 8LL);
          while ( *((_QWORD *)v10 - 1) != qword_8CE91C8 )
          {
            --v9;
            v10 += 4;
            if ( v9 == 0 )
              goto LABEL_31;
          }
          v11 = v8 + 16LL * *v10 + 312;
        }
        else
        {
LABEL_31:
          v11 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v27, qword_8CE91C8, 0);
        }
        self = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v11)(v27, WORD4(v27), *(_QWORD *)(v11 + 8));
        if ( (_DWORD)self == 0 )
        {
          *(_DWORD *)v2 = 1;
          *((_OWORD *)v2 + 2) = v27;
          ((void (__fastcall *)(_QWORD *, __int128 *, _QWORD *, __int64))unk_43620E4)(v2 + 1, &v27, v2, qword_8D1F3C8);
          return;
        }
      }
    }
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    DataModule_DataManager__LoadAllSaveData(self, method);
    v12 = **((_QWORD ***)off_8CD9218 + 23);
    if ( v12 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v13 = v12[6];
    if ( v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v13 + 105) == 0 )
    {
      *(_BYTE *)(v13 + 105) = 1;
      DbtSaveDataManagerBase_object__object___Save(v12, (const MethodInfo *)qword_8CFB260);
    }
    *(_BYTE *)(v3 + 32) = 1;
    *(_DWORD *)v2 = -2;
    if ( byte_8FFD1B1 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
      byte_8FFD1B1 = 1;
    }
    v14 = (__int64 *)v2[1];
    if ( v14 != nullptr )
    {
      v15 = *v14;
      v16 = *(unsigned __int16 *)(*v14 + 302);
      if ( *(_WORD *)(*v14 + 302) != 0 )
      {
        v17 = (_DWORD *)(*(_QWORD *)(v15 + 176) + 8LL);
        while ( *((_QWORD *)v17 - 1) != qword_8CE9038 )
        {
          --v16;
          v17 += 4;
          if ( v16 == 0 )
            goto LABEL_47;
        }
        v18 = v15 + 16LL * (*v17 + 2) + 312;
      }
      else
      {
LABEL_47:
        v18 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v14, qword_8CE9038, 2);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v18)(v14, *(_QWORD *)(v18 + 8));
    }
  }
  else
  {
    while ( 1 )
    {
      if ( v3 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v3 + 49) != 0 )
      {
        *(_BYTE *)(v3 + 32) = 0;
        goto LABEL_17;
      }
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      *(_QWORD *)&v27 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.1);
      *((_QWORD *)&v27 + 1) = method;
      if ( byte_8FFD1AD == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
        byte_8FFD1AD = 1;
      }
      self = off_8CEEDF8;
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      if ( byte_8FFD1AE == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AE = 1;
      }
      if ( (_QWORD)v27 != 0 )
      {
        v19 = *(_QWORD *)v27;
        v20 = *(unsigned __int16 *)(*(_QWORD *)v27 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v27 + 302LL) != 0 )
        {
          v21 = (int *)(*(_QWORD *)(v19 + 176) + 8LL);
          while ( *((_QWORD *)v21 - 1) != qword_8CE91C8 )
          {
            --v20;
            v21 += 4;
            if ( v20 == 0 )
              goto LABEL_66;
          }
          v22 = v19 + 16LL * *v21 + 312;
        }
        else
        {
LABEL_66:
          v22 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v27, qword_8CE91C8, 0);
        }
        self = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v22)(v27, WORD4(v27), *(_QWORD *)(v22 + 8));
        if ( (_DWORD)self == 0 )
          break;
      }
LABEL_69:
      if ( byte_8FFD1AF == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
        byte_8FFD1AF = 1;
      }
      if ( (_QWORD)v27 != 0 )
      {
        v23 = *(_QWORD *)v27;
        v24 = *(unsigned __int16 *)(*(_QWORD *)v27 + 302LL);
        if ( *(_WORD *)(*(_QWORD *)v27 + 302LL) != 0 )
        {
          v25 = (_DWORD *)(*(_QWORD *)(v23 + 176) + 8LL);
          while ( *((_QWORD *)v25 - 1) != qword_8CE91C8 )
          {
            --v24;
            v25 += 4;
            if ( v24 == 0 )
              goto LABEL_76;
          }
          v26 = v23 + 16LL * (*v25 + 2) + 312;
        }
        else
        {
LABEL_76:
          v26 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v27, qword_8CE91C8, 2);
        }
        self = (void *)(*(__int64 (__fastcall **)(_QWORD, _QWORD, _QWORD))v26)(v27, WORD4(v27), *(_QWORD *)(v26 + 8));
      }
    }
    *(_DWORD *)v2 = 0;
    *((_OWORD *)v2 + 2) = v27;
    ((void (__fastcall *)(_QWORD *, __int128 *, _QWORD *, __int64))unk_43620E4)(v2 + 1, &v27, v2, qword_8D1F3C8);
  }
}
