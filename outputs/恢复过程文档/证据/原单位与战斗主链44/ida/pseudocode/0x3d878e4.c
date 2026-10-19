void __fastcall GameModule_RoleBehaviour__DeadCallBack(__int64 a1, int a2)
{
  __int64 v4; // x1
  __int64 v5; // x2
  __int64 Instance; // x0
  __int64 v7; // x8
  GameModule_BattleGameSceneManager_o *v8; // x0
  __int64 v9; // x8
  __int64 v10; // x8
  unsigned int v11; // w24
  __int64 v12; // x22
  int v13; // w28
  unsigned int v14; // w23
  __int64 v15; // x25
  unsigned int v16; // w26
  unsigned int v17; // w27
  __int64 v18; // x21
  void *v19; // x0
  _QWORD *v20; // x0
  void *v21; // x21
  __int64 transform; // x0
  long double position; // q0
  void *v24; // x21
  _BYTE *v25; // x0
  void *v26; // x0
  __int64 v27; // x0
  __int64 v28; // x21
  __int64 v29; // x8
  unsigned __int64 v30; // x24
  __int64 v31; // x22
  __int64 gameObject; // x0
  void *v33; // x21
  __int64 v34; // x1

  if ( (byte_8FFD481 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D26800);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE64D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12128);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12230);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57D18);
    byte_8FFD481 = 1;
  }
  if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40D8);
  if ( (UnityEngine_Application__get_isPlaying(0) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v4, v5);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) != 0 )
    {
      v7 = *(_QWORD *)(a1 + 64);
      if ( v7 != 0 && *(_DWORD *)(v7 + 80) == 3 )
      {
        v8 = (GameModule_BattleGameSceneManager_o *)ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
        v9 = *(_QWORD *)(a1 + 64);
        if ( v9 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( v8 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_BattleGameSceneManager__RemoveLegendaryUnit(v8, *(_QWORD *)(v9 + 16), *(unsigned __int8 *)(a1 + 32));
      }
    }
    if ( *(_DWORD *)(a1 + 316) != 6 && *(_BYTE *)(a1 + 376) == 0 )
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)a1 + 904LL))(a1, *(_QWORD *)(*(_QWORD *)a1 + 912LL));
    v10 = *(_QWORD *)(a1 + 64);
    if ( v10 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v11 = *(_DWORD *)(v10 + 80);
    v12 = *(_QWORD *)(a1 + 96);
    v13 = *(unsigned __int8 *)(a1 + 32);
    v14 = *(_DWORD *)(a1 + 164);
    v15 = *(_QWORD *)(a1 + 176);
    v16 = *(_DWORD *)(a1 + 200);
    v17 = *(_DWORD *)(a1 + 204);
    v18 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE64D0);
    GameModule_DeadUnitInfo___ctor(v18, v12, v13 != 0, v14, v11, v15, v16, v17, 0);
    if ( *(_BYTE *)(a1 + 32) != 0 )
    {
      if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8) == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_AIBehaviourManager__AddDeadUnit();
    }
    else
    {
      v19 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
      if ( v19 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_BattleGameManager__AddDeadUnit((__int64)v19, *(_DWORD *)(a1 + 56), v18);
    }
    v20 = off_8CE5558;
    if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5558);
      v20 = off_8CE5558;
    }
    if ( *(_BYTE *)(v20[23] + 2LL) == 0 )
    {
      v21 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12128);
      transform = UnityEngine_Component__get_transform(a1, 0);
      if ( transform == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      position = UnityEngine_Transform__get_position(transform, 0);
      if ( v21 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      AssetsModule_EffectManager__ShowEffect(v21, qword_8D57D18, 0, position);
    }
    v24 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12230);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v24, 0, 0) & 1) != 0 )
    {
      v25 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12230);
      if ( v25 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v25[72] != 0 )
        goto LABEL_71;
      v26 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12230);
      if ( v26 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (GameModule_HWGPUInstancerManager__get_IsCrowdManagerAlive(v26, 0) & 1) == 0 )
      {
LABEL_71:
        v27 = sub_4B844C4(a1, 1, qword_8D26800);
        v28 = v27;
        if ( v27 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v29 = *(_QWORD *)(v27 + 24);
        if ( (int)v29 >= 1 )
        {
          v30 = 0;
          do
          {
            if ( v30 >= (unsigned int)v29 )
            {
              ((void (*)(void))unk_3C3D4D4)();
LABEL_55:
              il2cpp_codegen_raise_null_reference_exception();
            }
            v31 = *(_QWORD *)(v28 + 32 + 8 * v30);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Inequality(v31, 0, 0) & 1) != 0 )
            {
              if ( v31 == 0 )
                goto LABEL_55;
              if ( *(_DWORD *)(v31 + 44) != 0 )
                *(_DWORD *)(v31 + 44) = 0;
            }
            LODWORD(v29) = *(_DWORD *)(v28 + 24);
            ++v30;
          }
          while ( (__int64)v30 < (int)v29 );
        }
      }
    }
    gameObject = UnityEngine_Component__get_gameObject(a1, 0);
    if ( gameObject == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_GameObject__SetActive(gameObject, 0, 0);
    v33 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12338);
    v34 = UnityEngine_Component__get_gameObject(a1, 0);
    if ( v33 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    AssetsModule_ObjPoolManager__Recycle(v33, v34, 0);
    if ( a2 == 1 )
      ((void (__fastcall *)(__int64))GameModule_RoleBehaviour__HellFireDeadCallBack)(a1);
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)a1 + 936LL))(a1, *(_QWORD *)(*(_QWORD *)a1 + 944LL));
    *(_BYTE *)(a1 + 328) = 0;
    GameModule_RoleBehaviour__SetAiCanMove(a1, 0);
  }
}
