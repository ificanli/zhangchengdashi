__int64 __fastcall GameModule_RoleBehaviour__Charm_d__289__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  int v3; // w23
  void *Instance; // x21
  __int64 gameObject; // x1
  __int128 v6; // q0
  void *v7; // x21
  __int64 v8; // x1
  void *v9; // x21
  __int64 v10; // x1
  void *v11; // x21
  __int64 v12; // x1
  void *v13; // x0
  __int64 *v14; // x21
  unsigned int v15; // w22
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x8
  __int64 v19; // x9
  int *v20; // x10
  __int64 v21; // x0
  __int128 v22; // q0
  __int64 v24; // x21
  __int64 v25; // x22
  __int64 v26; // x0
  __int64 *v27; // x22
  __int64 v28; // x20
  __int128 v29; // [xsp+8h] [xbp-88h] BYREF
  __int64 v30; // [xsp+18h] [xbp-78h]
  __int128 v31; // [xsp+20h] [xbp-70h]
  __int64 v32; // [xsp+30h] [xbp-60h]
  __int128 v33; // [xsp+40h] [xbp-50h] BYREF
  __int64 v34; // [xsp+50h] [xbp-40h]

  if ( (byte_8FFD4BE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21C80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF9920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF9928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57330);
    byte_8FFD4BE = 1;
  }
  v33 = 0u;
  v34 = 0;
  v31 = 0u;
  v32 = 0;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 != 0 )
  {
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v3 = *(unsigned __int8 *)(v2 + 32);
    if ( *(_BYTE *)(v2 + 32) != 0 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      gameObject = UnityEngine_Component__get_gameObject(v2, 0);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_BattleGameSceneManager__RemoveEnemyRole((__int64)Instance, gameObject, 0);
    }
    else
    {
      v7 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      v8 = UnityEngine_Component__get_gameObject(v2, 0);
      if ( v7 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_BattleGameSceneManager__RemovePlayerRole((__int64)v7, v8, 0);
    }
    *(_BYTE *)(v2 + 32) ^= 1u;
    GameModule_RoleBehaviour__SyncCurrentHexCampRegistration(v2, v3 != 0, 0);
    if ( *(_BYTE *)(v2 + 32) != 0 )
    {
      v9 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      v10 = UnityEngine_Component__get_gameObject(v2, 0);
      if ( v9 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_BattleGameSceneManager__AddEnemyRole((__int64)v9, v10, 1, 0);
    }
    else
    {
      v11 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      v12 = UnityEngine_Component__get_gameObject(v2, 0);
      if ( v11 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_BattleGameSceneManager__AddPlayerRole((__int64)v11, v12, 1, 0);
    }
    *(_QWORD *)(v2 + 80) = 0;
    *(_QWORD *)(v2 + 88) = 0;
    GameModule_RoleBehaviour__ClearRoleTargetTracking(v2, 0);
    v13 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12008);
    if ( v13 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    AssetsModule_AssetsManager__LoadAssetAsync_object_(&v29, v13, qword_8D57330, qword_8D1E008);
    v31 = v29;
    v32 = v30;
    if ( (*(_BYTE *)(*((_QWORD *)off_8D19980 + 4) + 309LL) & 1) == 0 )
      ((void (*)(void))unk_3C503A0)();
    v33 = v31;
    v34 = v32;
    if ( (((__int64 (__fastcall *)(__int128 *, __int64))unk_35BD764)(&v33, qword_8CF9928) & 1) == 0 )
    {
      *(_DWORD *)a1 = 0;
      v22 = v33;
      *(_QWORD *)(a1 + 72) = v34;
      *(_OWORD *)(a1 + 56) = v22;
      return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___RoleBehaviour__Charm_d__289_(
               a1 + 8,
               &v33,
               a1,
               qword_8D21C80);
    }
  }
  else
  {
    v6 = *(_OWORD *)(a1 + 56);
    v34 = *(_QWORD *)(a1 + 72);
    v33 = v6;
    *(_QWORD *)(a1 + 64) = 0;
    *(_QWORD *)(a1 + 72) = 0;
    *(_QWORD *)(a1 + 56) = 0;
    *(_DWORD *)a1 = -1;
  }
  v14 = (__int64 *)v33;
  if ( (_QWORD)v33 != 0 )
  {
    v15 = (unsigned __int16)v34;
    v16 = *((_QWORD *)off_8CF9920 + 4);
    if ( (*(_BYTE *)(v16 + 309) & 1) == 0 )
      v16 = ((__int64 (*)(void))unk_3C503A0)();
    v17 = *(_QWORD *)(*(_QWORD *)(v16 + 192) + 40LL);
    if ( (*(_BYTE *)(v17 + 309) & 1) == 0 )
      v17 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v16 + 192) + 40LL));
    v18 = *v14;
    v19 = *(unsigned __int16 *)(*v14 + 302);
    if ( *(_WORD *)(*v14 + 302) != 0 )
    {
      v20 = (int *)(*(_QWORD *)(v18 + 176) + 8LL);
      while ( *((_QWORD *)v20 - 1) != v17 )
      {
        --v19;
        v20 += 4;
        if ( v19 == 0 )
          goto LABEL_29;
      }
      v21 = v18 + 16LL * *v20 + 312;
    }
    else
    {
LABEL_29:
      v21 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v14, v17, 0);
    }
    v24 = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v21)(v14, v15, *(_QWORD *)(v21 + 8));
  }
  else
  {
    v24 = *((_QWORD *)&v33 + 1);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v2, 0, 0) & 1) == 0 )
  {
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v25 = UnityEngine_Component__get_gameObject(v2, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v25, 0, 0) & 1) == 0 )
    {
      v26 = UnityEngine_Component__get_gameObject(v2, 0);
      if ( v26 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (UnityEngine_GameObject__get_activeInHierarchy(v26, 0) & 1) != 0 )
      {
        v27 = (__int64 *)(v2 + 712);
        if ( *(_BYTE *)(a1 + 48) != 0 )
        {
          GameModule_RoleBehaviour__AddEffHead(v2, v24, v2 + 712, 0);
        }
        else
        {
          v28 = *v27;
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          UnityEngine_Object__Destroy(v28, 0);
          *v27 = 0;
        }
      }
    }
  }
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
