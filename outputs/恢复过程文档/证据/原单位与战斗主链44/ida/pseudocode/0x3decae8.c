int32_t GameModule_BattleGameSceneManager__GetLegendaryTileV1ConfigPriceFallback(const MethodInfo *method)
{
  _QWORD *Instance; // x0
  __int64 v2; // x8
  __int64 v3; // x19
  unsigned int v4; // w20
  __int64 Item; // x0
  __int64 v6; // x3
  __int64 v7; // x21

  if ( (byte_8FFD763 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0AFD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AFD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53768);
    byte_8FFD763 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance == nullptr || (v2 = Instance[5]) == 0 || (v3 = *(_QWORD *)(v2 + 232)) == 0 )
LABEL_13:
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(int *)(v3 + 24) < 1 )
    return 350;
  v4 = 0;
  while ( 1 )
  {
    Item = System_Collections_Generic_List_object___get_Item(v3, v4, qword_8D0AFD8);
    if ( Item == 0 )
      goto LABEL_13;
    v7 = Item;
    if ( (System_String__op_Equality(*(_QWORD *)(Item + 16), qword_8D53768, 0, v6) & 1) != 0 )
      return ToolModule_StringTool__ToInt(*(_QWORD *)(v7 + 32), 0);
    if ( (signed int)++v4 >= *(_DWORD *)(v3 + 24) )
      return 350;
  }
}
