void GameModule_GameManager__PauseGame(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 Instance; // x19
  __int64 v4; // x1
  __int64 v5; // x2
  __int64 v6; // x0
  __int64 v7; // x19
  __int64 v8; // x1
  __int64 v9; // x2
  __int64 v10; // x0

  if ( (byte_8FFD893 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD893 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, method, v2);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
  {
    v6 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v4, v5);
    if ( v6 == 0 )
      goto LABEL_14;
    GameModule_BattleGameManager__SetGamePaused(v6, 1, 0);
  }
  v7 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FA8, v4, v5);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) != 0 )
  {
    v10 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FA8, v8, v9);
    if ( v10 != 0 )
    {
      GameModule_AIBehaviourManager__SetGamePaused(v10, 1, 0);
      return;
    }
LABEL_14:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
