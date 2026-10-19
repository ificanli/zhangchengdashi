void __fastcall GameModule_RoleBehaviour__MyUpdate(__int64 a1)
{
  void *Instance; // x20
  void *v3; // x0
  __int64 v4; // x2
  __int64 v5; // x20
  __int64 v6; // x0
  __int64 v7; // x20
  __int64 v8; // x0
  __int64 transform; // x0
  __int64 v10; // x20
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x20
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x20
  __int64 v17; // x0
  __int64 v18; // x0
  float v19; // s8
  __int64 v20; // x20
  __int64 v21; // x1
  __int64 v22; // x2
  __int64 v23; // x0
  __int64 v24; // x1
  __int64 v25; // x2
  __int64 v26; // x3
  __int64 v27; // x20
  __int64 v28; // x8
  int v29; // w8
  __int64 v30; // x8
  float v31; // s0
  __int64 v32; // x1
  float v33; // s8
  __int64 v34; // x0
  __int64 v35; // x20
  __int64 v36; // x0
  __int64 v37; // x3
  float v38; // s8
  float v39; // s0
  __int64 v40; // x20
  __int64 v41; // x0
  __int64 v42; // x3
  __int64 v43; // x20
  __int64 v44; // x19

  if ( (byte_8FFD47A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537B0);
    byte_8FFD47A = 1;
  }
  if ( UnityEngine_Time__get_timeScale(0) != 0.0 && *(_BYTE *)(a1 + 328) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
    {
      v3 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12048);
      if ( v3 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      if ( GameModule_BattleGameManager__get_IsGamePaused((__int64)v3, 0, v4) )
      {
        if ( *(_BYTE *)(a1 + 440) != 0 )
        {
          GameModule_RoleBehaviour__SetAiCanMove(a1, 0);
          if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
          {
            v5 = *(_QWORD *)(a1 + 128);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Inequality(v5, 0, 0) & 1) != 0 )
            {
              v6 = *(_QWORD *)(a1 + 128);
              if ( v6 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              UnityEngine_Behaviour__set_enabled(v6, 0, 0);
            }
          }
        }
        return;
      }
    }
    v7 = *(_QWORD *)(a1 + 656);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) != 0 )
    {
      v8 = *(_QWORD *)(a1 + 656);
      if ( v8 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      transform = UnityEngine_GameObject__get_transform(v8, 0);
      if ( transform == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__Rotate(transform, 0, 0.0, 2.0, 0.0);
    }
    v10 = *(_QWORD *)(a1 + 672);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v10, 0, 0) & 1) != 0 )
    {
      v11 = *(_QWORD *)(a1 + 672);
      if ( v11 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v12 = UnityEngine_GameObject__get_transform(v11, 0);
      if ( v12 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      sub_82F9F68(v12, 1, 0, 0.0, 2.0, 0.0);
    }
    v13 = *(_QWORD *)(a1 + 680);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v13, 0, 0) & 1) != 0 )
    {
      v14 = *(_QWORD *)(a1 + 680);
      if ( v14 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v15 = UnityEngine_GameObject__get_transform(v14, 0);
      if ( v15 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__Rotate(v15, 0, 0.0, 2.0, 0.0);
    }
    v16 = *(_QWORD *)(a1 + 712);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v16, 0, 0) & 1) != 0 )
    {
      v17 = *(_QWORD *)(a1 + 712);
      if ( v17 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v18 = UnityEngine_GameObject__get_transform(v17, 0);
      if ( v18 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__Rotate(v18, 0, 0.0, 2.0, 0.0);
    }
    v19 = *(float *)(a1 + 556);
    if ( (float)(v19 + 0.2) < UnityEngine_Time__get_time(0) )
    {
      *(float *)(a1 + 556) = UnityEngine_Time__get_time(0);
      sub_3D847E4(a1);
    }
    if ( *(_BYTE *)(a1 + 688) != 0 )
    {
      v20 = *(_QWORD *)(a1 + 640);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(v20, 0, 0) & 1) != 0 )
      {
        DG_Tweening_TweenExtensions__Kill(*(_QWORD *)(a1 + 696), 0, 0);
        *(_BYTE *)(a1 + 688) = 0;
      }
    }
    GameModule_EntityBase__MyUpdate(a1, 0);
    if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1930);
    v23 = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, v21, v22);
    if ( v23 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( QuickTutor_TutorialManager__IsStepComplete(v23, qword_8D537B0, 0) )
    {
      GameModule_RoleBehaviour__SkillUpdate(a1);
      GameModule_RoleBehaviour__CheckReleaseSkill(a1, v24, v25, v26);
    }
    v27 = *(_QWORD *)(a1 + 88);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v27, 0, 0) & 1) != 0 )
    {
      v28 = *(_QWORD *)(a1 + 88);
      if ( v28 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v28 + 33) != 0 || *(unsigned __int8 *)(v28 + 32) == *(unsigned __int8 *)(a1 + 32) )
      {
        *(_QWORD *)(a1 + 88) = 0;
        *(_QWORD *)(a1 + 280) = 0;
        *(_DWORD *)(a1 + 288) = -1;
      }
    }
    v29 = *(_DWORD *)(a1 + 72);
    if ( v29 == 1 )
    {
      v30 = *(_QWORD *)(a1 + 64);
      if ( v30 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v31 = *(float *)(a1 + 152);
    }
    else
    {
      if ( v29 != 0 )
        goto LABEL_68;
      v30 = *(_QWORD *)(a1 + 64);
      if ( v30 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v31 = fmaxf(*(float *)(a1 + 152), 1.5);
    }
    *(float *)(v30 + 36) = v31 * (float)(*(float *)(a1 + 156) + 1.0);
LABEL_68:
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)a1 + 920LL))(a1, *(_QWORD *)(*(_QWORD *)a1 + 928LL));
    if ( *(_BYTE *)(a1 + 224) != 0 )
    {
      v33 = *(float *)(a1 + 228);
      if ( v33 <= UnityEngine_Time__get_time(0) )
      {
        v34 = *(_QWORD *)(a1 + 216);
        if ( v34 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        UnityEngine_GameObject__SetActive(v34, 0, 0);
        if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
        {
          v35 = *(_QWORD *)(a1 + 128);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(v35, 0, 0) & 1) != 0 )
          {
            v36 = *(_QWORD *)(a1 + 128);
            if ( v36 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            UnityEngine_Behaviour__set_enabled(v36, 1, 0);
          }
        }
        GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
        *(_BYTE *)(a1 + 224) = 0;
        sub_3D7F628(a1, 1, 0, v37);
      }
    }
    else if ( *(_BYTE *)(a1 + 404) != 0 )
    {
      v38 = *(float *)(a1 + 408);
      v39 = v38 - UnityEngine_Time__get_deltaTime(0, v32);
      *(float *)(a1 + 408) = v39;
      if ( v39 < 0.0 )
      {
        *(_DWORD *)(a1 + 408) = 0;
        *(_BYTE *)(a1 + 404) = 0;
        if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
        {
          v40 = *(_QWORD *)(a1 + 128);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(v40, 0, 0) & 1) != 0 )
          {
            v41 = *(_QWORD *)(a1 + 128);
            if ( v41 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            UnityEngine_Behaviour__set_enabled(v41, 1, 0);
          }
        }
        GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
        sub_3D7F628(a1, 1, 0, v42);
        v43 = *(_QWORD *)(a1 + 416);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(v43, 0, 0) & 1) != 0 )
        {
          v44 = *(_QWORD *)(a1 + 416);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          UnityEngine_Object__Destroy(v44, 0);
        }
      }
    }
    else if ( *(_BYTE *)(a1 + 33) == 0 )
    {
      ((void (__fastcall *)(__int64))GameModule_RoleBehaviour__Move)(a1);
    }
  }
}
