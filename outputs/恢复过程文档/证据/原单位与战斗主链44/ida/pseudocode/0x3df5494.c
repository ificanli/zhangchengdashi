GameModule_HexBehaviour_o *GameModule_BattleGameSceneManager__FindTopMostObject(
        GameModule_BattleGameSceneManager_o *this,
        GameModule_HexBehaviour_o *start,
        bool isEnemy,
        const MethodInfo *method)
{
  char v6; // w8
  GameModule_HexBehaviour_o *result; // x0
  unsigned __int8 *v8; // x8
  __int64 v9; // x21
  __int64 v10; // x25

  if ( (byte_8FFD7AC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7AC = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v6 = UnityEngine_Object__op_Equality(start, 0, 0);
  result = nullptr;
  if ( (v6 & 1) == 0 )
  {
    if ( start == nullptr )
LABEL_16:
      il2cpp_codegen_raise_null_reference_exception();
    while ( 1 )
    {
      v8 = &start->fields._unknown_object_0010_to_009F[112];
      if ( !isEnemy )
        v8 = &start->fields._unknown_object_0010_to_009F[104];
      v9 = *(_QWORD *)v8;
      v10 = isEnemy ? 128LL : 120LL;
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v9, 0, 0) & 1) == 0 )
        return start;
      start = *(GameModule_HexBehaviour_o **)((char *)&start->klass + v10);
      if ( start == nullptr )
        goto LABEL_16;
    }
  }
  return result;
}
