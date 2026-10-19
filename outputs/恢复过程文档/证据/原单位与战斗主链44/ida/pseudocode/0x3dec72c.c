bool GameModule_BattleGameSceneManager__get_IsNoneTutorGame(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v3; // x8
  __int64 v4; // x8
  __int64 Instance; // x0

  if ( (byte_8FFD75F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB2B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537F8);
    byte_8FFD75F = 1;
  }
  v3 = **((_QWORD **)off_8CD9228 + 23);
  if ( v3 != 0 )
  {
    v4 = *(_QWORD *)(v3 + 48);
    if ( v4 != 0 )
    {
      if ( *(_BYTE *)(v4 + 16) != 0 )
        return false;
      if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1930);
      Instance = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, method, v2);
      if ( Instance != 0 )
        return QuickTutor_TutorialManager__IsStepComplete(Instance, qword_8D537F8, 0);
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
