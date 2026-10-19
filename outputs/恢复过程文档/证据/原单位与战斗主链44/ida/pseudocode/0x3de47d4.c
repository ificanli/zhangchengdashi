_DWORD *__fastcall GameModule_BattleGameManager__RecordGameResult(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x8
  int v4; // w9
  __int64 v5; // x21
  _DWORD *Instance; // x0
  _DWORD *v7; // x0
  _DWORD *v8; // x0
  _QWORD *v9; // x0
  _QWORD *v10; // x0
  _QWORD *v11; // x0
  _QWORD *v12; // x0
  __int64 v13; // x22
  _QWORD *v14; // x0
  __int64 v15; // x23
  __int64 v16; // x24
  __int64 v17; // x24
  __int64 v18; // x25
  __int64 v19; // x0
  __int64 v20; // x8
  _QWORD *v21; // x0
  _QWORD *v22; // x8
  _QWORD *v23; // x0
  __int64 v24; // x22
  __int64 v25; // x23
  __int64 v26; // x24
  __int64 v27; // x24
  __int64 v28; // x25
  _QWORD *v29; // x0
  _QWORD *v30; // x8
  _QWORD *v31; // x0
  __int64 v32; // x22
  __int64 v33; // x23
  __int64 v34; // x24
  __int64 v35; // x24
  __int64 v36; // x25
  _QWORD *v37; // x0
  _QWORD *v38; // x8
  _QWORD *v39; // x0
  __int64 v40; // x22
  __int64 v41; // x23
  __int64 v42; // x24
  __int64 v43; // x24
  __int64 v44; // x25
  _QWORD *v45; // x0
  _DWORD *result; // x0
  __int64 v47; // x8

  if ( (byte_8FFD737 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE4A58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE6EC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B390);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B388);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B5A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB0B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB0D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB0B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB0D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45088);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45090);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45098);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF1458);
    byte_8FFD737 = 1;
  }
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE4A58);
  System_Object___ctor(v2, 0);
  if ( v2 == 0 )
    goto LABEL_74;
  v3 = *(_QWORD *)(a1 + 208);
  *(_QWORD *)(v2 + 16) = v3;
  *(_BYTE *)(v2 + 24) = *(_BYTE *)(a1 + 128);
  if ( v3 == 0 )
    goto LABEL_74;
  v4 = *(_DWORD *)(a1 + 240);
  *(_DWORD *)(v3 + 64) = v4;
  *(_BYTE *)(v3 + 16) = v4 != 1;
  *(_QWORD *)(v3 + 40) = *(_QWORD *)(a1 + 192);
  *(_OWORD *)(v3 + 48) = *(_OWORD *)(a1 + 176);
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE6EC8);
  System_Object___ctor(v5, 0);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( Instance == nullptr )
    goto LABEL_74;
  if ( v5 == 0 )
    goto LABEL_74;
  *(_DWORD *)(v5 + 16) = Instance[46];
  v7 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v7 == nullptr )
    goto LABEL_74;
  *(_DWORD *)(v5 + 20) = v7[47];
  v8 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v8 == nullptr )
    goto LABEL_74;
  *(_DWORD *)(v5 + 24) = v8[48];
  v9 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v9 == nullptr )
    goto LABEL_74;
  *(_QWORD *)(v5 + 32) = v9[8];
  v10 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v10 == nullptr )
    goto LABEL_74;
  *(_QWORD *)(v5 + 40) = v10[30];
  v11 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v11 == nullptr )
    goto LABEL_74;
  *(_QWORD *)(v5 + 64) = System_Linq_Enumerable__ToList_object_(v11[11], qword_8D2B5A0);
  v12 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v12 == nullptr )
    goto LABEL_74;
  v13 = v12[20];
  v14 = off_8CF1458;
  if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CF1458);
    v14 = off_8CF1458;
  }
  v15 = *(_QWORD *)(v14[23] + 24LL);
  if ( v15 == 0 )
  {
    if ( *((_DWORD *)v14 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v14);
      v14 = off_8CF1458;
    }
    v16 = *(_QWORD *)v14[23];
    v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0D8);
    System_Func_KeyValuePair_object__int___object____ctor(v15, v16, qword_8D45088, 0);
    v14 = off_8CF1458;
    *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 24LL) = v15;
  }
  if ( *((_DWORD *)v14 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(v14);
    v14 = off_8CF1458;
  }
  v17 = *(_QWORD *)(v14[23] + 32LL);
  if ( v17 == 0 )
  {
    if ( *((_DWORD *)v14 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v14);
      v14 = off_8CF1458;
    }
    v18 = *(_QWORD *)v14[23];
    v17 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0D0);
    System_Func_KeyValuePair_object__int___int____ctor(v17, v18, qword_8D45090, 0);
    *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 32LL) = v17;
  }
  v19 = System_Linq_Enumerable__ToDictionary_KeyValuePair_object__int___object__int_(v13, v15, v17, qword_8D2B390);
  v20 = *(_QWORD *)(v5 + 80);
  *(_QWORD *)(v5 + 72) = v19;
  if ( v20 != 0 )
  {
    v21 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
    if ( v21 == nullptr )
      goto LABEL_74;
    v22 = v21;
    v23 = off_8CF1458;
    v24 = v22[21];
    if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF1458);
      v23 = off_8CF1458;
    }
    v25 = *(_QWORD *)(v23[23] + 40LL);
    if ( v25 == 0 )
    {
      if ( *((_DWORD *)v23 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v23);
        v23 = off_8CF1458;
      }
      v26 = *(_QWORD *)v23[23];
      v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0D8);
      System_Func_KeyValuePair_object__int___object____ctor(v25, v26, qword_8D45098, 0);
      v23 = off_8CF1458;
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 40LL) = v25;
    }
    if ( *((_DWORD *)v23 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v23);
      v23 = off_8CF1458;
    }
    v27 = *(_QWORD *)(v23[23] + 48LL);
    if ( v27 == 0 )
    {
      if ( *((_DWORD *)v23 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v23);
        v23 = off_8CF1458;
      }
      v28 = *(_QWORD *)v23[23];
      v27 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0D0);
      System_Func_KeyValuePair_object__int___int____ctor(v27, v28, qword_8D450A0, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 48LL) = v27;
    }
    *(_QWORD *)(v5 + 80) = System_Linq_Enumerable__ToDictionary_KeyValuePair_object__int___object__int_(
                             v24,
                             v25,
                             v27,
                             qword_8D2B390);
  }
  if ( *(_QWORD *)(v5 + 88) != 0 )
  {
    v29 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
    if ( v29 == nullptr )
      goto LABEL_74;
    v30 = v29;
    v31 = off_8CF1458;
    v32 = v30[34];
    if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF1458);
      v31 = off_8CF1458;
    }
    v33 = *(_QWORD *)(v31[23] + 56LL);
    if ( v33 == 0 )
    {
      if ( *((_DWORD *)v31 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v31);
        v31 = off_8CF1458;
      }
      v34 = *(_QWORD *)v31[23];
      v33 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0B8);
      System_Func_KeyValuePair_object__object___object____ctor(v33, v34, qword_8D450A8, 0);
      v31 = off_8CF1458;
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 56LL) = v33;
    }
    if ( *((_DWORD *)v31 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v31);
      v31 = off_8CF1458;
    }
    v35 = *(_QWORD *)(v31[23] + 64LL);
    if ( v35 == 0 )
    {
      if ( *((_DWORD *)v31 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v31);
        v31 = off_8CF1458;
      }
      v36 = *(_QWORD *)v31[23];
      v35 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0B0);
      System_Func_KeyValuePair_object__object___object____ctor(v35, v36, qword_8D450B0, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 64LL) = v35;
    }
    *(_QWORD *)(v5 + 88) = System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(
                             v32,
                             v33,
                             v35,
                             qword_8D2B388);
  }
  if ( *(_QWORD *)(v5 + 96) != 0 )
  {
    v37 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
    if ( v37 == nullptr )
      goto LABEL_74;
    v38 = v37;
    v39 = off_8CF1458;
    v40 = v38[35];
    if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF1458);
      v39 = off_8CF1458;
    }
    v41 = *(_QWORD *)(v39[23] + 72LL);
    if ( v41 == 0 )
    {
      if ( *((_DWORD *)v39 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v39);
        v39 = off_8CF1458;
      }
      v42 = *(_QWORD *)v39[23];
      v41 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0B8);
      System_Func_KeyValuePair_object__object___object____ctor(v41, v42, qword_8D450B8, 0);
      v39 = off_8CF1458;
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 72LL) = v41;
    }
    if ( *((_DWORD *)v39 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v39);
      v39 = off_8CF1458;
    }
    v43 = *(_QWORD *)(v39[23] + 80LL);
    if ( v43 == 0 )
    {
      if ( *((_DWORD *)v39 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v39);
        v39 = off_8CF1458;
      }
      v44 = *(_QWORD *)v39[23];
      v43 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB0B0);
      System_Func_KeyValuePair_object__object___object____ctor(v43, v44, qword_8D450C0, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 80LL) = v43;
    }
    *(_QWORD *)(v5 + 96) = System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(
                             v40,
                             v41,
                             v43,
                             qword_8D2B388);
  }
  v45 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
  if ( v45 == nullptr
    || (*(_QWORD *)(v5 + 112) = v45[36],
        (result = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8)) == nullptr)
    || (*(_DWORD *)(v5 + 104) = result[21], (v47 = *(_QWORD *)(v2 + 16)) == 0) )
  {
LABEL_74:
    il2cpp_codegen_raise_null_reference_exception();
  }
  *(_QWORD *)(v47 + 24) = v5;
  *(_QWORD *)(a1 + 248) = v2;
  return result;
}
