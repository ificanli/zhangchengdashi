void GameModule_BattleGameSceneManager__ApplySkillIndicatorColor(
        GameModule_BattleGameSceneManager_o *this,
        bool isValid,
        const MethodInfo *method)
{
  __int64 v5; // x21
  __int64 v6; // x21
  __int64 v7; // x0
  __int64 v8; // x21
  __int64 v9; // x20
  void *v10; // x0
  __int64 v11; // x8
  __int64 v12; // x9
  __int64 v13; // x10
  __int64 v14; // x12
  float *v15; // x11

  if ( (byte_8FFD779 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DC40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD779 = 1;
  }
  v5 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[488];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v5, 0, 0) & 1) != 0 )
  {
    v6 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[480];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
    {
      v7 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[480];
      if ( v7 == 0 )
        goto LABEL_21;
      *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[488] = UnityEngine_GameObject__GetComponent_object_(
                                                                     v7,
                                                                     qword_8D2DC40);
    }
  }
  v8 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[488];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v8, 0, 0) & 1) == 0 )
  {
    v9 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[488];
    v10 = off_8CE4A38;
    if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE4A38);
      v10 = off_8CE4A38;
    }
    v11 = *((_QWORD *)v10 + 23);
    if ( isValid )
    {
      v12 = 12;
      v13 = 8;
      v14 = 4;
      v15 = *((float **)v10 + 23);
    }
    else
    {
      v15 = (float *)(v11 + 16);
      v12 = 28;
      v13 = 24;
      v14 = 20;
    }
    if ( v9 != 0 )
    {
      UnityEngine_SpriteRenderer__set_color(
        v9,
        0,
        *v15,
        *(float *)(v11 + v14),
        *(float *)(v11 + v13),
        *(float *)(v11 + v12));
      return;
    }
LABEL_21:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
