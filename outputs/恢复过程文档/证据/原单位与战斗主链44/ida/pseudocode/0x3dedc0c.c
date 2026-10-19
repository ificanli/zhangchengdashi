int32_t GameModule_BattleGameSceneManager__get_AllHexCount(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v3; // x8

  if ( (byte_8FFD76E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    byte_8FFD76E = 1;
  }
  v3 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[104];
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return *(_DWORD *)(v3 + 24);
}
