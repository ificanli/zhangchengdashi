void GameModule_GameManager__EnterMeta_d__20__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x1
  __int64 v4; // x2
  __int64 Instance; // x0
  __int64 v6; // x1
  __int64 v7; // x2
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x1
  __int64 v11; // x2
  __int64 v12; // x0
  __int64 v13; // x1
  __int64 v14; // x2
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x2
  __int64 v19; // x0
  __int64 v20; // x1
  __int64 v21; // x2
  __int64 v22; // x20
  __int64 v23; // x1
  __int64 v24; // x2
  __int64 v25; // x0

  if ( (byte_8FFD8AC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12450);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12358);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD8AC = 1;
  }
  if ( (GameModule_TrainingGroundManager__get_IsInTrainingGround(0, method) & 1) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v3, v4);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_MetaGameManager__ShowMetaSwitchPanel(Instance, 2, 0);
    v8 = ToolModule_ManagerBase_object___get_Instance(qword_8D12358, v6, v7);
    if ( v8 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
LABEL_6:
    GameModule_PanelPopHandleManager__PanelPopPlay(v8, 0);
  }
  else
  {
    v9 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v3, v4);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    switch ( *(_DWORD *)(v9 + 240) )
    {
      case 0:
        v12 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v10, v11);
        if ( v12 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_MetaGameManager__ShowMetaSwitchPanel(v12, 2, 0);
        v8 = ToolModule_ManagerBase_object___get_Instance(qword_8D12358, v13, v14);
        if ( v8 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        goto LABEL_6;
      case 1:
        v25 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v10, v11);
        if ( v25 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_MetaGameManager__ShowMetaSwitchPanel(v25, 3, 0);
        break;
      case 2:
        v15 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v10, v11);
        if ( v15 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_MetaGameManager__ShowMetaSwitchPanel(v15, 2, 0);
        break;
      case 3:
        v16 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v10, v11);
        if ( v16 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_MetaGameManager__ShowMetaSwitchPanel(v16, 2, 0);
        v19 = ToolModule_ManagerBase_object___get_Instance(qword_8D12358, v17, v18);
        if ( v19 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_PanelPopHandleManager__PanelPopPlay(v19, 0);
        v22 = ToolModule_ManagerBase_object___get_Instance(qword_8D12450, v20, v21);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(v22, 0, 0) & 1) != 0 )
        {
          if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12450, v23, v24) == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          GameModule_SubGameChaosTrailsManager__TryReturnToPanelAfterEnterMeta();
        }
        break;
      default:
        break;
    }
  }
  *(_DWORD *)self = -2;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
}
