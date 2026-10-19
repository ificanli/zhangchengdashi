__int64 __fastcall GameModule_BattleGameSceneManager__GetArchitectureTarget(
        __int64 a1,
        char a2,
        long double a3,
        long double a4,
        long double a5)
{
  __int64 v10; // x8
  __int64 v11; // x19
  __int64 Item; // x20
  __int64 v14; // x0
  __int64 transform; // x0
  float v16; // s11
  float v17; // s1
  float v18; // s12
  float v19; // s2
  float v20; // s13
  float v21; // s12
  float v22; // s14
  __int64 v23; // x2
  unsigned int v24; // w20
  unsigned int v25; // w22
  __int64 v26; // x23
  __int64 v27; // x0
  __int64 v28; // x0
  long double position; // q0
  float v30; // s11
  float v31; // s1
  float v32; // s12
  float v33; // s2
  float v34; // s13
  float v35; // s0
  __int64 v36; // x0

  if ( (byte_8FFD78A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D750);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD78A = 1;
  }
  v10 = 168;
  if ( (a2 & 1) != 0 )
    v10 = 160;
  v11 = *(_QWORD *)(a1 + v10);
  if ( v11 == 0 )
    goto LABEL_40;
  if ( *(_DWORD *)(v11 + 24) == 0 )
    return 0;
  if ( (GameModule_WebGLNavigationManager__get_IsRuntimeEnabled(0) & 1) != 0
    && (GameModule_BattleGameSceneManager__TryGetWebGLArchitectureAtOrNearPosition(a3, a4, a5) & 1) != 0 )
  {
    return 0;
  }
  Item = System_Collections_Generic_List_object___get_Item(v11, 0, qword_8D0ACF8);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(Item, 0, 0) & 1) != 0 )
  {
    v14 = System_Collections_Generic_List_object___get_Item(v11, 0, qword_8D0ACF8);
    if ( v14 == 0 )
      goto LABEL_40;
    transform = UnityEngine_GameObject__get_transform(v14, 0);
    if ( transform == 0 )
      goto LABEL_40;
    LODWORD(v16) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
    v18 = v17;
    v20 = v19;
    if ( byte_8FFD020 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD020 = 1;
    }
    v21 = *(float *)&a4 - v18;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    v22 = sqrtf(
            (float)((float)(*(float *)&a5 - v20) * (float)(*(float *)&a5 - v20))
          + (float)((float)((float)(*(float *)&a3 - v16) * (float)(*(float *)&a3 - v16)) + (float)(v21 * v21)));
  }
  else
  {
    v22 = 3.4028e38;
  }
  v23 = qword_8D0ACF8;
  if ( *(int *)(v11 + 24) >= 2 )
  {
    v24 = 0;
    v25 = 1;
    while ( 1 )
    {
      v26 = System_Collections_Generic_List_object___get_Item(v11, v25, v23);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(v26, 0, 0) & 1) == 0 )
      {
        v27 = System_Collections_Generic_List_object___get_Item(v11, v25, qword_8D0ACF8);
        if ( v27 == 0 )
          goto LABEL_40;
        v28 = UnityEngine_GameObject__get_transform(v27, 0);
        if ( v28 == 0 )
          goto LABEL_40;
        position = UnityEngine_Transform__get_position(v28, 0);
        v30 = *(float *)&position;
        v32 = v31;
        v34 = v33;
        if ( byte_8FFD020 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD020 = 1;
        }
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        v35 = sqrtf(
                (float)((float)(*(float *)&a5 - v34) * (float)(*(float *)&a5 - v34))
              + (float)((float)((float)(*(float *)&a3 - v30) * (float)(*(float *)&a3 - v30))
                      + (float)((float)(*(float *)&a4 - v32) * (float)(*(float *)&a4 - v32))));
        if ( v22 > v35 )
        {
          v22 = v35;
          v24 = v25;
        }
      }
      v23 = qword_8D0ACF8;
      if ( (signed int)++v25 >= *(_DWORD *)(v11 + 24) )
        goto LABEL_38;
    }
  }
  v24 = 0;
LABEL_38:
  v36 = System_Collections_Generic_List_object___get_Item(v11, v24, v23);
  if ( v36 == 0 )
LABEL_40:
    il2cpp_codegen_raise_null_reference_exception();
  return UnityEngine_GameObject__GetComponent_object_(v36, qword_8D2D750);
}
