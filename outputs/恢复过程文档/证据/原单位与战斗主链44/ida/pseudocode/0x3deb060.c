void __fastcall GameModule_BattleGameManager__Init_d__43__MoveNext(__int64 a1)
{
  _QWORD *v2; // x20
  void *Instance; // x0
  __int64 v4; // x21
  __int64 v5; // x1
  __int64 v6; // x22
  __int64 v7; // x8
  __int64 v8; // x9
  int *v9; // x10
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 v12; // x9
  _DWORD *v13; // x10
  __int64 v14; // x0
  void *v15; // x21
  void *v16; // x22
  void *v17; // x21
  void *v18; // x22
  void *v19; // x21
  void *v20; // x22
  void *v21; // x21
  void *v22; // x22
  void *v23; // x21
  void *v24; // x22
  void *v25; // x21
  void *v26; // x22
  void *v27; // x21
  void *v28; // x22
  void *v29; // x21
  void *v30; // x22
  void *v31; // x21
  void *v32; // x22
  void *v33; // x21
  void *v34; // x22
  void *v35; // x21
  void *v36; // x22
  void *v37; // x21
  void *v38; // x22
  void *v39; // x21
  void *v40; // x22
  __int64 v41; // x21
  __int64 v42; // x21
  __int64 v43; // x21
  __int64 v44; // x21
  __int64 *v45; // x19
  __int64 v46; // x8
  __int64 v47; // x9
  _DWORD *v48; // x10
  __int64 v49; // x0
  __int128 v50; // [xsp+0h] [xbp-50h] BYREF

  if ( (byte_8FFD75D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F310);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23DF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC660);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9648);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5C020);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6DC30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6BF18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D624D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C110);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C140);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5BF70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6F410);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D698A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D619C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D59158);
    byte_8FFD75D = 1;
  }
  v50 = 0u;
  v2 = *(_QWORD **)(a1 + 24);
  if ( *(_DWORD *)a1 != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12168);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v4 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)Instance + 376LL))(
           Instance,
           *(_QWORD *)(*(_QWORD *)Instance + 384LL));
    v6 = v5;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v50 = v4;
    *((_QWORD *)&v50 + 1) = v6;
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
    if ( (_QWORD)v50 != 0 )
    {
      v7 = *(_QWORD *)v50;
      v8 = *(unsigned __int16 *)(*(_QWORD *)v50 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v50 + 302LL) != 0 )
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
        v10 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v50, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v10)(v50, WORD4(v50), *(_QWORD *)(v10 + 8)) == 0 )
      {
        *(_DWORD *)a1 = 0;
        *(_OWORD *)(a1 + 32) = v50;
        ((void (__fastcall *)(__int64, __int128 *, __int64, __int64))unk_3DF9548)(a1 + 8, &v50, a1, qword_8D1F310);
        return;
      }
    }
  }
  else
  {
    v50 = *(_OWORD *)(a1 + 32);
    *(_QWORD *)(a1 + 32) = 0;
    *(_QWORD *)(a1 + 40) = 0;
    *(_DWORD *)a1 = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v50 != 0 )
  {
    v11 = *(_QWORD *)v50;
    v12 = *(unsigned __int16 *)(*(_QWORD *)v50 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v50 + 302LL) != 0 )
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
      v14 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v50, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v14)(v50, WORD4(v50), *(_QWORD *)(v14 + 8));
  }
  v15 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v16 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v16, v2, qword_8D23DB0, 0);
  if ( v15 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v15, (void *)qword_8D5C020, v16, nullptr);
  v17 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v18 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v18, v2, qword_8D23DB8, 0);
  if ( v17 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v17, (void *)qword_8D624D0, v18, nullptr);
  v19 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v20 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v20, v2, qword_8D23DE8, 0);
  if ( v19 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v19, (void *)qword_8D6C110, v20, nullptr);
  v21 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v22 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v22, v2, qword_8D23DE0, 0);
  if ( v21 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v21, (void *)qword_8D6C148, v22, nullptr);
  v23 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v24 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v24, v2, qword_8D23DF8, 0);
  if ( v23 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v23, (void *)qword_8D698A0, v24, nullptr);
  v25 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v26 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v26, v2, qword_8D23DD8, 0);
  if ( v25 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v25, (void *)qword_8D6C140, v26, nullptr);
  v27 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v28 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v28, v2, qword_8D23DF0, 0);
  if ( v27 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v27, (void *)qword_8D6F410, v28, nullptr);
  v29 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v30 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v30, v2, qword_8D23DA0, 0);
  if ( v29 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v29, (void *)qword_8D59158, v30, nullptr);
  v31 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v32 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v32, v2, qword_8D23D98, 0);
  if ( v31 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v31, (void *)qword_8D619C8, v32, nullptr);
  v33 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v34 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v34, v2, qword_8D23DC0, 0);
  if ( v33 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v33, (void *)qword_8D619C8, v34, nullptr);
  v35 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v36 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v36, v2, qword_8D23DA8, 0);
  if ( v35 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v35, (void *)qword_8D5BF70, v36, nullptr);
  v37 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v38 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v38, v2, qword_8D23DC8, 0);
  if ( v37 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v37, (void *)qword_8D6BF18, v38, nullptr);
  v39 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v40 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v40, v2, qword_8D23DD0, 0);
  if ( v39 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v39, (void *)qword_8D6DC30, v40, nullptr);
  v41 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v41, qword_8CFEA38);
  if ( v2 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v2[14] = v41;
  v42 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v42, qword_8CFEA38);
  v2[15] = v42;
  v43 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v43, qword_8CFEA38);
  v2[19] = v43;
  v44 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9648);
  System_Collections_Generic_Dictionary_int__object____ctor(v44, qword_8CFC660);
  v2[21] = v44;
  *(_DWORD *)a1 = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v45 = *(__int64 **)(a1 + 8);
  if ( v45 != nullptr )
  {
    v46 = *v45;
    v47 = *(unsigned __int16 *)(*v45 + 302);
    if ( *(_WORD *)(*v45 + 302) != 0 )
    {
      v48 = (_DWORD *)(*(_QWORD *)(v46 + 176) + 8LL);
      while ( *((_QWORD *)v48 - 1) != qword_8CE9038 )
      {
        --v47;
        v48 += 4;
        if ( v47 == 0 )
          goto LABEL_53;
      }
      v49 = v46 + 16LL * (*v48 + 2) + 312;
    }
    else
    {
LABEL_53:
      v49 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v45, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v49)(v45, *(_QWORD *)(v49 + 8));
  }
}
