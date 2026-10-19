bool GameModule_BattleGameSceneManager__CheckForBuilding(
        GameModule_BattleGameSceneManager_o *this,
        GameModule_HexBehaviour_o *aObject,
        bool isEnemy,
        int32_t depth,
        const MethodInfo *method)
{
  int32_t v5; // w8
  int v8; // w22
  int v9; // w26
  __int64 v10; // x8
  int isEnemyHex; // w8

  if ( depth <= 2 )
    v5 = 2;
  else
    v5 = depth;
  v8 = isEnemy;
  v9 = v5 - depth + 1;
  while ( 1 )
  {
    if ( (byte_8FFD7A8 & 1) == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
      byte_8FFD7A8 = 1;
    }
    if ( --v9 == 0 )
      return false;
    if ( aObject == nullptr )
      goto LABEL_27;
    if ( isEnemy )
      v10 = 128;
    else
      v10 = 120;
    aObject = *(GameModule_HexBehaviour_o **)((char *)&aObject->klass + v10);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(aObject, 0, 0) & 1) != 0 )
      return false;
    if ( aObject == nullptr )
LABEL_27:
      il2cpp_codegen_raise_null_reference_exception();
    isEnemyHex = aObject->fields.isEnemyHex;
    if ( aObject->fields._unknown_object_00A2_to_01D7[55] != 0 )
    {
      if ( isEnemyHex == v8 )
        return true;
      goto LABEL_22;
    }
    if ( isEnemyHex == v8 && aObject->fields._unknown_object_00A2_to_01D7[54] != 0 && aObject->fields.isOpened != 0 )
      return true;
LABEL_22:
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(aObject, 0, 0) & 1) == 0 )
      return false;
  }
}
