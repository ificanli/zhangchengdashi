__int64 __fastcall GameModule_BattleGameSceneManager__UpdateSkillIndicator(
        __int64 a1,
        __int64 a2,
        __int64 a3,
        long double a4,
        double a5,
        long double a6)
{
  char v6; // w19
  __int64 Instance; // x0
  __int64 result; // x0
  __int64 v12; // x21
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 transform; // x0

  v6 = a2;
  if ( (byte_8FFD777 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD777 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    goto LABEL_16;
  result = SDKModule_ABTestManager__get_NewArtifactsPlayIsBTest(Instance, 0);
  if ( (result & 1) != 0 )
  {
    v12 = *(_QWORD *)(a1 + 496);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Equality(v12, 0, 0);
    if ( (result & 1) == 0 )
    {
      v13 = *(_QWORD *)(a1 + 496);
      if ( v13 == 0 )
        goto LABEL_16;
      result = UnityEngine_GameObject__get_activeSelf(v13, 0);
      if ( (result & 1) != 0 )
      {
        v14 = *(_QWORD *)(a1 + 496);
        if ( v14 != 0 )
        {
          transform = UnityEngine_GameObject__get_transform(v14, 0);
          if ( transform != 0 )
          {
            UnityEngine_Transform__set_position(transform, 0, a4, 1.0, a6);
            return GameModule_BattleGameSceneManager__ApplySkillIndicatorColor(a1, v6 & 1);
          }
        }
LABEL_16:
        il2cpp_codegen_raise_null_reference_exception();
      }
    }
  }
  return result;
}
