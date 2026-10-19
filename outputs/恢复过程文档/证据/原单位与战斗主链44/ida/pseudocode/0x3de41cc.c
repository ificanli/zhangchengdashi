__int64 GameModule_BattleGameManager__HideFoundEnemyPanel()
{
  void *Instance; // x0

  if ( (byte_8FFD732 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57448);
    byte_8FFD732 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D124C8);
  if ( Instance == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  return UIFramework_UIManager__HidePanel(Instance, qword_8D57448, 0);
}
