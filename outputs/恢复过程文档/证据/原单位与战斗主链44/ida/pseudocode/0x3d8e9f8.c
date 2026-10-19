__int64 __fastcall GameModule_RoleBehaviour__AddTempMiss_d__274__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x8
  float v4; // s0
  __int64 v5; // x20
  __int128 v6; // q0
  __int64 *v7; // x21
  unsigned int v8; // w22
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 v11; // x8
  __int64 v12; // x9
  int *v13; // x10
  __int64 v14; // x0
  __int64 v15; // x21
  void *Instance; // x0
  __int128 v17; // q0
  __int64 v19; // x1
  __int128 v20; // [xsp+8h] [xbp-88h] BYREF
  __int64 v21; // [xsp+18h] [xbp-78h]
  __int128 v22; // [xsp+20h] [xbp-70h]
  __int64 v23; // [xsp+30h] [xbp-60h]
  __int128 v24; // [xsp+40h] [xbp-50h] BYREF
  __int64 v25; // [xsp+50h] [xbp-40h]

  if ( (byte_8FFD4B9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF9920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF9928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57320);
    byte_8FFD4B9 = 1;
  }
  v24 = 0u;
  v25 = 0;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 == 0 )
  {
    v6 = *(_OWORD *)(a1 + 56);
    v25 = *(_QWORD *)(a1 + 72);
    v24 = v6;
    *(_QWORD *)(a1 + 64) = 0;
    *(_QWORD *)(a1 + 72) = 0;
    *(_QWORD *)(a1 + 56) = 0;
    *(_DWORD *)a1 = -1;
    goto LABEL_11;
  }
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v3 = *(_QWORD *)(v2 + 64);
  if ( v3 == 0 )
    goto LABEL_34;
  v4 = *(float *)(a1 + 48);
  if ( v4 >= 0.0 )
  {
    *(float *)(v3 + 64) = v4 + *(float *)(v3 + 64);
    v15 = *(_QWORD *)(v2 + 680);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v15, 0, 0) & 1) != 0 )
      goto LABEL_34;
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12008);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    AssetsModule_AssetsManager__LoadAssetAsync_object_(&v20, Instance, qword_8D57320, qword_8D1E008);
    v22 = v20;
    v23 = v21;
    if ( (*(_BYTE *)(*((_QWORD *)off_8D19980 + 4) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    v24 = v22;
    v25 = v23;
    if ( (((__int64 (__fastcall *)(__int128 *, __int64))unk_35BD764)(&v24, qword_8CF9928) & 1) == 0 )
    {
      *(_DWORD *)a1 = 0;
      v17 = v24;
      *(_QWORD *)(a1 + 72) = v25;
      *(_OWORD *)(a1 + 56) = v17;
      return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___RoleBehaviour__AddTempMiss_d__274_(
               a1 + 8,
               &v24,
               a1,
               qword_8D21C70);
    }
LABEL_11:
    v7 = (__int64 *)v24;
    if ( (_QWORD)v24 != 0 )
    {
      v8 = (unsigned __int16)v25;
      v9 = *((_QWORD *)off_8CF9920 + 4);
      if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
        v9 = ((__int64 (*)(void))unk_3C503A0)();
      v10 = *(_QWORD *)(*(_QWORD *)(v9 + 192) + 40LL);
      if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
        v10 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v9 + 192) + 40LL));
      v11 = *v7;
      v12 = *(unsigned __int16 *)(*v7 + 302);
      if ( *(_WORD *)(*v7 + 302) != 0 )
      {
        v13 = (int *)(*(_QWORD *)(v11 + 176) + 8LL);
        while ( *((_QWORD *)v13 - 1) != v10 )
        {
          --v12;
          v13 += 4;
          if ( v12 == 0 )
            goto LABEL_20;
        }
        v14 = v11 + 16LL * *v13 + 312;
      }
      else
      {
LABEL_20:
        v14 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v7, v10, 0);
      }
      v19 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v14)(v7, v8, *(_QWORD *)(v14 + 8));
    }
    else
    {
      v19 = *((_QWORD *)&v24 + 1);
    }
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_RoleBehaviour__AddEffHead(v2, v19, v2 + 680, 0);
    goto LABEL_34;
  }
  *(_DWORD *)(v3 + 64) = *(_DWORD *)(v2 + 244);
  v5 = *(_QWORD *)(v2 + 680);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  UnityEngine_Object__Destroy(v5, 0);
LABEL_34:
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
