void __fastcall GameModule_RoleBehaviour__CheckAndContinueAttackAdjacentWalls(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x1
  __int64 v4; // x2
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0
  _BYTE *v10; // x1
  __int64 transform; // x0
  long double position; // q0
  long double v13; // q1
  long double v14; // q2
  __int64 v15; // x8
  float v16; // s8
  long double v17; // q9
  long double v18; // q11
  long double v19; // q10
  __int64 v20; // x20
  __int64 v21; // x1
  __int64 v22; // x2
  __int64 v23; // x1
  __int64 v24; // x2
  __int64 Instance; // x0
  __int64 v26; // x20
  __int64 v27; // x0
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 v30; // x20
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 FirstEnemyWallInPath; // x20
  __int64 v34; // x1
  __int64 v35; // x2
  __int64 gameObject; // x0
  __int64 v37; // x0
  float v38; // s11
  __int64 v39; // x0
  float v40; // s2
  float v41; // s12
  float v42; // s11
  __int64 v43; // x0
  __int64 v44; // x20
  __int64 v45; // x0
  __int64 v46; // x0
  _BYTE v47[34]; // [xsp+0h] [xbp-210h] BYREF
  __int16 v48; // [xsp+22h] [xbp-1EEh]
  _BYTE v49[34]; // [xsp+30h] [xbp-1E0h] BYREF
  __int16 v50; // [xsp+52h] [xbp-1BEh]
  _BYTE v51[34]; // [xsp+60h] [xbp-1B0h] BYREF
  __int16 v52; // [xsp+82h] [xbp-18Eh]
  _BYTE v53[34]; // [xsp+90h] [xbp-180h] BYREF
  __int16 v54; // [xsp+B2h] [xbp-15Eh]
  _QWORD v55[4]; // [xsp+C0h] [xbp-150h] BYREF
  __int16 v56; // [xsp+E2h] [xbp-12Eh]
  _QWORD v57[24]; // [xsp+F0h] [xbp-120h] BYREF

  v57[23] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  if ( (byte_8FFD495 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F7C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE470);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD495 = 1;
  }
  memset(&v57[18], 0, 33);
  memset(&v57[12], 0, 33);
  memset(&v57[6], 0, 33);
  memset(v57, 0, 33);
  v2 = *(_QWORD *)(a1 + 112);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v2, 0, 0) & 1) == 0 && *(_BYTE *)(a1 + 33) == 0 )
  {
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( transform != 0 )
    {
      position = UnityEngine_Transform__get_position(transform, 0);
      v15 = *(_QWORD *)(a1 + 64);
      if ( v15 != 0 )
      {
        v16 = *(float *)(v15 + 36);
        v17 = position;
        v18 = v13;
        v19 = v14;
        v20 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE470);
        sub_5817A48(v20, 32, qword_8D0F7C0);
        if ( GameModule_RoleBehaviour__TryGetAstarRemainingPath(a1, v20) )
        {
          if ( (GameModule_RoleBehaviour__IsPathClear(a1, v20, v17, v18, v19) & 1) != 0 )
          {
            *(_BYTE *)(a1 + 592) = 0;
            *(_OWORD *)(a1 + 600) = 0u;
            if ( *(_BYTE *)(a1 + 440) != 0 )
              return;
            if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE1928);
            Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v23, v24);
            if ( Instance != 0 )
            {
              if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(Instance, 0) & 1) != 0 )
                GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
              if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
                goto LABEL_86;
              v26 = *(_QWORD *)(a1 + 128);
              if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEB3E0);
              if ( (UnityEngine_Object__op_Inequality(v26, 0, 0) & 1) == 0 )
                goto LABEL_86;
              v27 = *(_QWORD *)(a1 + 128);
              if ( v27 != 0 )
              {
                if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v27, 0) & 1) == 0 )
                  goto LABEL_86;
                v28 = *(_QWORD *)(a1 + 128);
                if ( v28 != 0 )
                {
                  Pathfinding_FollowerEntity__get_rvoSettings(v55, v28, 0);
                  qmemcpy(&v57[6], v55, 33);
                  v9 = *(_QWORD *)(a1 + 128);
                  if ( v9 != 0 )
                  {
                    v49[33] = 0;
                    v50 = v56;
                    qmemcpy(v49, v55, 33);
                    v10 = v49;
                    goto LABEL_22;
                  }
                }
              }
            }
          }
          else
          {
            FirstEnemyWallInPath = GameModule_RoleBehaviour__FindFirstEnemyWallInPath(a1, v20, v17, v18, v19, v16);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Inequality(FirstEnemyWallInPath, 0, 0) & 1) != 0 )
            {
              if ( FirstEnemyWallInPath == 0 )
                goto LABEL_89;
              if ( *(_BYTE *)(FirstEnemyWallInPath + 33) == 0 )
              {
                gameObject = UnityEngine_Component__get_gameObject(FirstEnemyWallInPath, 0);
                if ( gameObject == 0 )
                  goto LABEL_89;
                if ( (UnityEngine_GameObject__get_activeSelf(gameObject, 0) & 1) != 0 )
                {
                  v37 = UnityEngine_Component__get_transform(FirstEnemyWallInPath, 0);
                  if ( v37 == 0 )
                    goto LABEL_89;
                  LODWORD(v38) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v37, 0));
                  v39 = UnityEngine_Component__get_transform(FirstEnemyWallInPath, 0);
                  if ( v39 == 0 )
                    goto LABEL_89;
                  UnityEngine_Transform__get_position(v39, 0);
                  v41 = v40;
                  if ( byte_8FFD4B7 == 0 )
                  {
                    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
                    byte_8FFD4B7 = 1;
                  }
                  v42 = *(float *)&v17 - v38;
                  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CEA738);
                  if ( sqrtf((float)(v42 * v42) + (float)((float)(*(float *)&v19 - v41) * (float)(*(float *)&v19 - v41))) <= v16 )
                  {
                    *(_QWORD *)(a1 + 600) = FirstEnemyWallInPath;
                    *(_QWORD *)(a1 + 608) = *(_QWORD *)(FirstEnemyWallInPath + 72);
                    *(float *)(a1 + 616) = UnityEngine_Time__get_time(0);
                    GameModule_RoleBehaviour__AttackWall(a1);
                    return;
                  }
                }
              }
            }
            *(_BYTE *)(a1 + 592) = 0;
            *(_OWORD *)(a1 + 600) = 0u;
            if ( *(_BYTE *)(a1 + 440) != 0 )
              return;
            if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE1928);
            v43 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v34, v35);
            if ( v43 != 0 )
            {
              if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v43, 0) & 1) != 0 )
                GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
              if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
                goto LABEL_86;
              v44 = *(_QWORD *)(a1 + 128);
              if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEB3E0);
              if ( (UnityEngine_Object__op_Inequality(v44, 0, 0) & 1) == 0 )
                goto LABEL_86;
              v45 = *(_QWORD *)(a1 + 128);
              if ( v45 != 0 )
              {
                if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v45, 0) & 1) == 0 )
                  goto LABEL_86;
                v46 = *(_QWORD *)(a1 + 128);
                if ( v46 != 0 )
                {
                  Pathfinding_FollowerEntity__get_rvoSettings(v55, v46, 0);
                  qmemcpy(v57, v55, 33);
                  v9 = *(_QWORD *)(a1 + 128);
                  if ( v9 != 0 )
                  {
                    v10 = v47;
                    v47[33] = 0;
                    qmemcpy(v47, v55, 33);
                    v48 = v56;
                    goto LABEL_22;
                  }
                }
              }
            }
          }
        }
        else
        {
          *(_BYTE *)(a1 + 592) = 0;
          *(_OWORD *)(a1 + 600) = 0u;
          if ( *(_BYTE *)(a1 + 440) != 0 )
            return;
          if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE1928);
          v29 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v21, v22);
          if ( v29 != 0 )
          {
            if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v29, 0) & 1) != 0 )
              GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
            if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
              goto LABEL_86;
            v30 = *(_QWORD *)(a1 + 128);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Inequality(v30, 0, 0) & 1) == 0 )
              goto LABEL_86;
            v31 = *(_QWORD *)(a1 + 128);
            if ( v31 != 0 )
            {
              if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v31, 0) & 1) == 0 )
                goto LABEL_86;
              v32 = *(_QWORD *)(a1 + 128);
              if ( v32 != 0 )
              {
                Pathfinding_FollowerEntity__get_rvoSettings(v55, v32, 0);
                qmemcpy(&v57[12], v55, 33);
                v9 = *(_QWORD *)(a1 + 128);
                if ( v9 != 0 )
                {
                  v51[33] = 0;
                  v52 = v56;
                  qmemcpy(v51, v55, 33);
                  v10 = v51;
                  goto LABEL_22;
                }
              }
            }
          }
        }
      }
    }
LABEL_89:
    il2cpp_codegen_raise_null_reference_exception();
  }
  *(_BYTE *)(a1 + 592) = 0;
  *(_OWORD *)(a1 + 600) = 0u;
  if ( *(_BYTE *)(a1 + 440) != 0 )
    return;
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v5 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v3, v4);
  if ( v5 == 0 )
    goto LABEL_89;
  if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v5, 0) & 1) != 0 )
    GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    goto LABEL_86;
  v6 = *(_QWORD *)(a1 + 128);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) == 0 )
    goto LABEL_86;
  v7 = *(_QWORD *)(a1 + 128);
  if ( v7 == 0 )
    goto LABEL_89;
  if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v7, 0) & 1) != 0 )
  {
    v8 = *(_QWORD *)(a1 + 128);
    if ( v8 != 0 )
    {
      Pathfinding_FollowerEntity__get_rvoSettings(v55, v8, 0);
      qmemcpy(&v57[18], v55, 33);
      v9 = *(_QWORD *)(a1 + 128);
      if ( v9 != 0 )
      {
        v53[33] = 0;
        v54 = v56;
        qmemcpy(v53, v55, 33);
        v10 = v53;
LABEL_22:
        Pathfinding_FollowerEntity__set_rvoSettings(v9, v10, 0);
        goto LABEL_86;
      }
    }
    goto LABEL_89;
  }
LABEL_86:
  GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
  GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, 1);
  sub_3D7F628(a1, 1u, 0);
}
