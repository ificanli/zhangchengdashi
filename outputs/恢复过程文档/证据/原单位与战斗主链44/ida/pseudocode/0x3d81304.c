__int64 __fastcall GameModule_RoleBehaviour__SetAiTarget(__int64 a1, __int64 a2)
{
  __int64 v4; // x20
  __int64 result; // x0
  __int64 v6; // x20
  __int64 v7; // x8
  __int64 v8; // x21
  char v9; // w21
  __int64 v10; // x21
  __int64 v11; // x0
  __int64 gameObject; // x21
  __int64 v13; // x21
  __int64 transform; // x21
  __int64 v15; // x0
  __int64 parent; // x0
  __int64 v17; // x0
  __int64 v18; // x0
  long double position; // q0
  float v20; // s1
  float v21; // s2
  float v22; // s11
  float v23; // s12
  float v24; // s13
  long double v25; // q0
  __int64 v26; // x21
  long double v27; // q8
  float v28; // s1
  float v29; // s9
  long double v30; // q2
  long double v31; // q10
  char v32; // w21
  _BOOL4 ShouldSyncPathfindingTargetPosition; // w20
  __int64 v34; // x0
  __int64 v35; // x0
  __int64 v36; // x0
  __int64 v37; // x22
  __int64 v38; // x23
  __int64 v39; // x0
  __int64 v40; // x0
  __int64 v41; // x8
  __int64 v42; // x20

  if ( (byte_8FFD471 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6BEF8);
    byte_8FFD471 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
  {
    v4 = *(_QWORD *)(a1 + 136);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Inequality(v4, 0, 0);
    if ( (result & 1) == 0 )
      goto LABEL_14;
    v6 = *(_QWORD *)(a1 + 120);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Inequality(v6, 0, 0);
    if ( (result & 1) == 0 )
      goto LABEL_14;
    v7 = *(_QWORD *)(a1 + 120);
    if ( v7 != 0 )
    {
      *(_QWORD *)(v7 + 40) = 0;
LABEL_14:
      *(_BYTE *)(a1 + 452) = 0;
      *(_QWORD *)(a1 + 424) = 0;
      *(_QWORD *)(a1 + 432) = 0;
      *(_DWORD *)(a1 + 460) = -998653952;
      return result;
    }
LABEL_52:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v8 = *(_QWORD *)(a1 + 432);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v9 = UnityEngine_Object__op_Inequality(v8, a2, 0);
    *(_QWORD *)(a1 + 424) = a2;
    *(_QWORD *)(a1 + 432) = a2;
    *(float *)(a1 + 460) = UnityEngine_Time__get_time(0);
    if ( (v9 & 1) != 0 )
      *(_BYTE *)(a1 + 452) = 1;
    return GameModule_WebGLNavigationManager__TryRegisterRole(a1, 0);
  }
  else
  {
    v10 = *(_QWORD *)(a1 + 136);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v10, 0, 0) & 1) != 0 )
      goto LABEL_29;
    v11 = *(_QWORD *)(a1 + 136);
    if ( v11 == 0 )
      goto LABEL_52;
    gameObject = UnityEngine_GameObject__get_gameObject(v11, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(gameObject, 0, 0) & 1) != 0 )
    {
LABEL_29:
      v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
      UnityEngine_GameObject___ctor(v13, qword_8D6BEF8, 0);
      *(_QWORD *)(a1 + 136) = v13;
      if ( v13 == 0 )
        goto LABEL_52;
      transform = UnityEngine_GameObject__get_transform(v13, 0);
      v15 = UnityEngine_Component__get_transform(a1, 0);
      if ( v15 == 0 )
        goto LABEL_52;
      parent = UnityEngine_Transform__get_parent(v15, 0);
      if ( transform == 0 )
        goto LABEL_52;
      UnityEngine_Transform__SetParent(transform, parent, 0);
    }
    v17 = *(_QWORD *)(a1 + 136);
    if ( v17 == 0 )
      goto LABEL_52;
    v18 = UnityEngine_GameObject__get_transform(v17, 0);
    if ( v18 == 0 )
      goto LABEL_52;
    position = UnityEngine_Transform__get_position(v18, 0);
    if ( a2 == 0 )
      goto LABEL_52;
    v22 = *(float *)&position;
    v23 = v20;
    v24 = v21;
    v25 = UnityEngine_Transform__get_position(a2, 0);
    v26 = *(_QWORD *)(a1 + 432);
    v27 = v25;
    v29 = v28;
    v31 = v30;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v32 = UnityEngine_Object__op_Inequality(v26, a2, 0);
    *(_QWORD *)(a1 + 432) = a2;
    ShouldSyncPathfindingTargetPosition = GameModule_RoleBehaviour__ShouldSyncPathfindingTargetPosition(
                                            a1,
                                            v32 & 1,
                                            v22,
                                            v23,
                                            v24,
                                            *(float *)&v27,
                                            v29,
                                            *(float *)&v31);
    if ( ShouldSyncPathfindingTargetPosition )
    {
      v34 = *(_QWORD *)(a1 + 136);
      if ( v34 == 0 )
        goto LABEL_52;
      v35 = UnityEngine_GameObject__get_transform(v34, 0);
      if ( v35 == 0 )
        goto LABEL_52;
      UnityEngine_Transform__set_position(v35, 0, v27, v29, v31);
      *(float *)(a1 + 460) = UnityEngine_Time__get_time(0);
    }
    v36 = *(_QWORD *)(a1 + 136);
    if ( v36 == 0 )
      goto LABEL_52;
    v37 = *(_QWORD *)(a1 + 424);
    v38 = UnityEngine_GameObject__get_transform(v36, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Inequality(v37, v38, 0);
    if ( ((ShouldSyncPathfindingTargetPosition | (unsigned int)result) & 1) != 0 )
    {
      v39 = *(_QWORD *)(a1 + 136);
      if ( v39 == 0 )
        goto LABEL_52;
      v40 = UnityEngine_GameObject__get_transform(v39, 0);
      v41 = *(_QWORD *)(a1 + 136);
      *(_QWORD *)(a1 + 424) = v40;
      if ( v41 == 0 )
        goto LABEL_52;
      v42 = *(_QWORD *)(a1 + 120);
      result = UnityEngine_GameObject__get_transform(v41, 0);
      if ( v42 == 0 )
        goto LABEL_52;
      *(_QWORD *)(v42 + 40) = result;
    }
    if ( (v32 & 1) != 0 )
      *(_BYTE *)(a1 + 452) = 1;
  }
  return result;
}
