float GameModule_BattleGameSceneManager__GetSpawnHexSize(
        GameModule_BattleGameSceneManager_o *this,
        const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x0
  __int64 v6; // x20
  char v7; // w0
  float result; // s0
  __int64 v9; // x8

  if ( (byte_8FFD7A7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D9A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7A7 = 1;
  }
  v3 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[32];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v3, 0, 0) & 1) != 0 )
  {
    v4 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[24];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v4, 0, 0) & 1) != 0 )
    {
      v5 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[24];
      if ( v5 == 0 )
        goto LABEL_17;
      *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[32] = UnityEngine_GameObject__GetComponent_object_(
                                                                    v5,
                                                                    qword_8D2D9A8);
    }
  }
  v6 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[32];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v7 = UnityEngine_Object__op_Inequality(v6, 0, 0);
  result = 1.0;
  if ( (v7 & 1) != 0 )
  {
    v9 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[32];
    if ( v9 != 0 )
      return *(float *)(v9 + 32);
LABEL_17:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return result;
}
