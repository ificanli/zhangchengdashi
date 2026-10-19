void AssetsModule_AssetsManager__Init_d__15__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v4; // x20
  __int64 GroupsMap; // x21
  const MethodInfo *v6; // x22
  __int64 v7; // x8
  __int64 v8; // x9
  int *v9; // x10
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 v12; // x9
  _DWORD *v13; // x10
  __int64 v14; // x0
  __int64 Instance; // x0
  __int64 v16; // x1
  __int64 v17; // x2
  __int64 v18; // x0
  __int64 v19; // x3
  __int64 *v20; // x19
  __int64 v21; // x8
  __int64 v22; // x9
  _DWORD *v23; // x10
  __int64 v24; // x0
  __int128 v25; // [xsp+0h] [xbp-50h] BYREF

  if ( (byte_8FFE077 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F300);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D58208);
    byte_8FFE077 = 1;
  }
  v25 = 0u;
  v4 = *((_QWORD *)self + 3);
  if ( *(_DWORD *)self != 0 )
  {
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GroupsMap = AssetsModule_AssetsManager__GenerateGroupsMap(*((_QWORD *)self + 3), method);
    v6 = method;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v25 = GroupsMap;
    *((_QWORD *)&v25 + 1) = v6;
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
    if ( (_QWORD)v25 != 0 )
    {
      v7 = *(_QWORD *)v25;
      v8 = *(unsigned __int16 *)(*(_QWORD *)v25 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v25 + 302LL) != 0 )
      {
        v9 = (int *)(*(_QWORD *)(v7 + 176) + 8LL);
        while ( *((_QWORD *)v9 - 1) != qword_8CE91C8 )
        {
          --v8;
          v9 += 4;
          if ( v8 == 0 )
            goto LABEL_18;
        }
        v10 = v7 + 16LL * *v9 + 312;
      }
      else
      {
LABEL_18:
        v10 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v25, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v10)(v25, WORD4(v25), *(_QWORD *)(v10 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *((_OWORD *)self + 2) = v25;
        ((void (__fastcall *)(char *, __int128 *, void *, __int64))unk_3F1EA14)(
          (char *)self + 8,
          &v25,
          self,
          qword_8D1F300);
        return;
      }
    }
  }
  else
  {
    v25 = *((_OWORD *)self + 2);
    *((_QWORD *)self + 4) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v25 != 0 )
  {
    v11 = *(_QWORD *)v25;
    v12 = *(unsigned __int16 *)(*(_QWORD *)v25 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v25 + 302LL) != 0 )
    {
      v13 = (_DWORD *)(*(_QWORD *)(v11 + 176) + 8LL);
      while ( *((_QWORD *)v13 - 1) != qword_8CE91C8 )
      {
        --v12;
        v13 += 4;
        if ( v12 == 0 )
          goto LABEL_29;
      }
      v14 = v11 + 16LL * (*v13 + 2) + 312;
    }
    else
    {
LABEL_29:
      v14 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v25, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v14)(v25, WORD4(v25), *(_QWORD *)(v14 + 8));
  }
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(v4 + 72) = 1065353216;
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12338, method, v2);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Instance + 376LL))(
    Instance,
    *(_QWORD *)(*(_QWORD *)Instance + 384LL));
  v18 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v16, v17);
  if ( v18 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__TriggerEvent(v18, qword_8D58208, 0, v19);
  *(_BYTE *)(v4 + 77) = 1;
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v20 = *((__int64 **)self + 1);
  if ( v20 != nullptr )
  {
    v21 = *v20;
    v22 = *(unsigned __int16 *)(*v20 + 302);
    if ( *(_WORD *)(*v20 + 302) != 0 )
    {
      v23 = (_DWORD *)(*(_QWORD *)(v21 + 176) + 8LL);
      while ( *((_QWORD *)v23 - 1) != qword_8CE9038 )
      {
        --v22;
        v23 += 4;
        if ( v22 == 0 )
          goto LABEL_42;
      }
      v24 = v21 + 16LL * (*v23 + 2) + 312;
    }
    else
    {
LABEL_42:
      v24 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v20, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v24)(v20, *(_QWORD *)(v24 + 8));
  }
}
