__int64 __fastcall GameModule_BattleGameSceneManager__StartGame_d__142__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  _QWORD *Instance; // x0
  __int64 v4; // x8
  __int64 v5; // x21
  _QWORD *v6; // x0
  __int64 *v7; // x8
  _QWORD *v8; // x0
  __int64 Item; // x0
  __int64 v10; // x1
  __int64 v11; // x2
  __int64 v12; // x0
  char IsBTest; // w0
  int v14; // w9
  __int64 v15; // x21
  __int64 v16; // x21
  __int64 v17; // x0
  _BYTE v19[8]; // [xsp+8h] [xbp-38h] BYREF

  if ( (byte_8FFD7ED & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D398);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D9A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61A80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536B8);
    byte_8FFD7ED = 1;
  }
  v19[0] = 0;
  v2 = *(_QWORD *)(a1 + 40);
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(v2 + 32) = 0;
  *(_QWORD *)(v2 + 488) = 0;
  *(_QWORD *)(v2 + 512) = 0;
  *(_WORD *)(v2 + 360) = 0;
  GameModule_BattleGameSceneManager__EnsureWebGLNavigationManager(v2, 0);
  GameModule_BattleGameSceneManager__MarkWebGLNavigationDirty(v2, 0);
  v19[0] = GameModule_BattleGameSceneManager__PrewarmBattleRuntimePools(v2, 0);
  Cysharp_Threading_Tasks_UniTaskVoid__Forget(v19, 0);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = Instance[5];
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v5 = *(_QWORD *)(v4 + 184);
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
  if ( byte_8FFD3A7 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    byte_8FFD3A7 = 1;
  }
  v6 = off_8CE5E20;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
    v6 = off_8CE5E20;
  }
  if ( (ToolModule_StringTool__IsNullOrEmpty(*(_QWORD *)(v6[23] + 8LL), 1, 0) & 1) != 0 )
  {
    v7 = &qword_8D536B8;
  }
  else
  {
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
    if ( byte_8FFD3A7 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
      byte_8FFD3A7 = 1;
    }
    v8 = off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      v8 = off_8CE5E20;
    }
    v7 = (__int64 *)(v8[23] + 8LL);
  }
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Item = System_Collections_Generic_Dictionary_object__object___get_Item(v5, *v7, qword_8CFE650);
  if ( Item == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(v2 + 428) = ToolModule_StringTool__ToInt(*(_QWORD *)(Item + 232), 0);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v12 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v10, v11);
  if ( v12 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  IsBTest = SDKModule_ABTestManager__get_BalanceAdjustment01IsBTest(v12, 0);
  v14 = *(_DWORD *)(v2 + 428);
  if ( (IsBTest & 1) != 0 )
  {
    v14 &= ~1u;
    *(_DWORD *)(v2 + 428) = v14;
  }
  *(_DWORD *)(v2 + 432) = v14 / 2;
  v15 = *(_QWORD *)(v2 + 40);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v15, 0, 0) & 1) != 0 )
  {
    v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
    UnityEngine_GameObject___ctor(v16, qword_8D61A80, 0);
    *(_QWORD *)(v2 + 40) = v16;
    if ( v16 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_GameObject__AddComponent_object_(v16, qword_8D2D398);
  }
  v17 = *(_QWORD *)(v2 + 40);
  if ( v17 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( UnityEngine_GameObject__GetComponent_object_(v17, qword_8D2D9A8) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameModule_GenerateHexBehaviour__Generate();
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
