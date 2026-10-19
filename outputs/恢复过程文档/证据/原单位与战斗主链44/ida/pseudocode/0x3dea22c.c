__int64 __fastcall GameModule_BattleGameManager__CountDownEnd_d__81__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x1
  GameModule_BattleGameSceneManager_o *Instance; // x0
  const MethodInfo *v5; // x1
  int32_t HasHex; // w21
  GameModule_BattleGameSceneManager_o *v7; // x0
  const MethodInfo *v8; // x1
  GameModule_BattleGameSceneManager_o *v9; // x0
  const MethodInfo *v10; // x1
  int32_t v11; // w21
  GameModule_BattleGameSceneManager_o *v12; // x0
  const MethodInfo *v13; // x1
  _QWORD *v14; // x0
  __int64 v15; // x8
  int v16; // w21
  _QWORD *v17; // x0
  __int64 v18; // x8
  _QWORD *v19; // x0
  __int64 v20; // x8
  int v21; // w21
  _QWORD *v22; // x0
  __int64 v23; // x8
  __int64 v24; // x1
  __int64 v25; // x1

  if ( (byte_8FFD75A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    byte_8FFD75A = 1;
  }
  v2 = *(_QWORD *)(a1 + 40);
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v3 = *(_QWORD *)(v2 + 88);
  if ( v3 != 0 )
    UnityEngine_MonoBehaviour__StopCoroutine(*(_QWORD *)(a1 + 40), v3, 0);
  if ( UnityEngine_Time__get_timeScale(0) != 0.0 )
  {
    Instance = (GameModule_BattleGameSceneManager_o *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    HasHex = GameModule_BattleGameSceneManager__get_PlayerHasHex(Instance, v5);
    v7 = (GameModule_BattleGameSceneManager_o *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v7 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    if ( HasHex > GameModule_BattleGameSceneManager__get_EnemyHasHex(v7, v8) )
      goto LABEL_10;
    v9 = (GameModule_BattleGameSceneManager_o *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v9 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v11 = GameModule_BattleGameSceneManager__get_PlayerHasHex(v9, v10);
    v12 = (GameModule_BattleGameSceneManager_o *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v12 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    if ( v11 < GameModule_BattleGameSceneManager__get_EnemyHasHex(v12, v13) )
      goto LABEL_14;
    v14 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v14 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v15 = v14[22];
    if ( v15 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v16 = *(_DWORD *)(v15 + 24);
    v17 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v17 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v18 = v17[23];
    if ( v18 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( v16 > *(_DWORD *)(v18 + 24) )
    {
LABEL_10:
      GameModule_BattleGameManager__GameEnd(v2, 1, 1);
      goto LABEL_29;
    }
    v19 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v19 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v20 = v19[22];
    if ( v20 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v21 = *(_DWORD *)(v20 + 24);
    v22 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    if ( v22 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v23 = v22[23];
    if ( v23 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( v21 < *(_DWORD *)(v23 + 24) )
    {
LABEL_14:
      GameModule_BattleGameManager__GameEnd(v2, 0, 1);
      goto LABEL_29;
    }
    if ( UnityEngine_Time__get_timeScale(0) != 0.0 )
    {
      v24 = *(_QWORD *)(v2 + 88);
      *(float *)(v2 + 60) = *(float *)(v2 + 60) + 10.0;
      *(_BYTE *)(v2 + 80) = 1;
      if ( v24 != 0 )
        UnityEngine_MonoBehaviour__StopCoroutine(v2, v24, 0);
      v25 = GameModule_BattleGameManager__Countdown(v2);
      *(_QWORD *)(v2 + 88) = UnityEngine_MonoBehaviour__StartCoroutine(v2, v25, 0);
    }
  }
LABEL_29:
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
