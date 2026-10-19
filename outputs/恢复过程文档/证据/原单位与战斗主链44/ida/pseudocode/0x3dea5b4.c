int32_t GameModule_BattleGameSceneManager__get_EnemyHasHex(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v3; // x8
  __int64 v4; // x9

  if ( (byte_8FFD769 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    byte_8FFD769 = 1;
  }
  v3 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[88];
  if ( v3 == 0 || (v4 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[136]) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return *(_DWORD *)(v4 + 24) + *(_DWORD *)(v3 + 24);
}
