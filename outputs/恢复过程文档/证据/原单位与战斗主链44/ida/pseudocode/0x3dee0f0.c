__int64 __fastcall GameModule_BattleGameSceneManager__ShowSkillIndicator(
        __int64 a1,
        __int64 a2,
        __int64 a3,
        long double a4,
        double a5,
        long double a6,
        float a7)
{
  char v7; // w19
  __int64 Instance; // x0
  __int64 result; // x0
  __int64 v14; // x21
  __int64 v15; // x0
  __int64 transform; // x0
  __int64 v17; // x0
  __int64 v18; // x21
  __int64 v19; // x0

  v7 = a2;
  if ( (byte_8FFD776 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD776 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    goto LABEL_19;
  result = SDKModule_ABTestManager__get_NewArtifactsPlayIsBTest(Instance, 0);
  if ( (result & 1) != 0 )
  {
    v14 = *(_QWORD *)(a1 + 496);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Equality(v14, 0, 0);
    if ( (result & 1) == 0 )
    {
      v15 = *(_QWORD *)(a1 + 496);
      if ( v15 != 0 )
      {
        transform = UnityEngine_GameObject__get_transform(v15, 0);
        if ( transform != 0 )
        {
          UnityEngine_Transform__set_position(transform, 0, a4, 1.0, a6);
          v17 = *(_QWORD *)(a1 + 496);
          if ( v17 != 0 )
          {
            v18 = UnityEngine_GameObject__get_transform(v17, 0);
            if ( byte_8FFD01F == 0 )
            {
              il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
              byte_8FFD01F = 1;
            }
            if ( v18 != 0 )
            {
              UnityEngine_Transform__set_localScale(
                v18,
                0,
                *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 12LL) * a7,
                *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 16LL) * a7,
                *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 20LL) * a7);
              v19 = *(_QWORD *)(a1 + 496);
              if ( v19 != 0 )
              {
                UnityEngine_GameObject__SetActive(v19, 1, 0);
                return GameModule_BattleGameSceneManager__ApplySkillIndicatorColor(a1, v7 & 1);
              }
            }
          }
        }
      }
LABEL_19:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
  return result;
}
