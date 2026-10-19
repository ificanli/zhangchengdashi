bool GameModule_BattleGameSceneManager__LegendaryTileV1HexPassesBaseFilters(
        GameModule_HexBehaviour_o *hex,
        const MethodInfo *method)
{
  if ( (byte_8FFD765 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD765 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(hex, 0, 0) & 1) != 0 )
    return false;
  if ( hex == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  return hex->fields._unknown_object_00A2_to_01D7[274] == 0
      && hex->fields._unknown_object_00A2_to_01D7[258] == 0
      && hex->fields._unknown_object_0010_to_009F[80] == 0
      && *(_DWORD *)&hex->fields._unknown_object_00A2_to_01D7[262] == 2;
}
