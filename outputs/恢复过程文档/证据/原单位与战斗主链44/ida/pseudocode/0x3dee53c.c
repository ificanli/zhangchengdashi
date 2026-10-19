void GameModule_BattleGameSceneManager__HideSkillIndicator(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x0

  if ( (byte_8FFD778 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD778 = 1;
  }
  v3 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[480];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v3, 0, 0) & 1) == 0 )
  {
    GameModule_BattleGameSceneManager__ApplySkillIndicatorColor(this, 1);
    v4 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[480];
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_GameObject__SetActive(v4, 0, 0);
  }
}
