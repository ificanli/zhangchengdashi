void __fastcall GameModule_RoleBehaviour__Move(__int64 a1)
{
  int v2; // w23
  __int64 v3; // x20
  __int64 v4; // x20
  void *Instance; // x20
  __int64 transform; // x0
  long double position; // q0
  long double v8; // q1
  long double v9; // q2
  __int64 ArchitectureTarget; // x20
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x0
  int v15; // w8
  __int64 v16; // x0
  long double v17; // q0
  int v18; // s1
  int v19; // s2
  __int64 v20; // x20
  int v21; // w8
  _BYTE **v22; // x0
  __int64 v23; // x20
  __int64 v24; // x0
  __int64 v25; // x20
  __int64 v26; // x21
  __int64 v27; // x21
  int v28; // w8
  __int64 v29; // x20
  __int64 v30; // x8
  int v31; // w8
  __int64 v32; // x20
  int v33; // w8
  __int64 v34; // x8
  float v35; // s14
  __int64 v36; // x0
  long double v37; // q0
  float v38; // s1
  float v39; // s2
  __int64 v40; // x0
  long double v41; // q8
  float v42; // s9
  float v43; // s10
  __int64 v44; // x1
  __int64 v45; // x2
  float v46; // s11
  float v47; // s1
  float v48; // s12
  float v49; // s2
  float v50; // s13
  __int64 v51; // x0
  __int64 v52; // x20
  __int64 v53; // x0
  __int64 v54; // x0
  __int64 v55; // x0
  __int64 *v56; // x20
  __int64 v57; // x8
  __int64 v58; // x9
  _DWORD *v59; // x10
  __int64 v60; // x0
  __int64 v61; // x1
  __int64 v62; // x2
  __int64 v63; // x0
  __int64 v64; // x1
  __int64 v65; // x2
  __int64 v66; // x0
  __int64 v67; // x20
  __int64 v68; // x0
  __int64 v69; // x0
  __int64 v70; // x0
  float v71; // s0
  __int64 v72; // x8
  float v73; // s0
  __int64 v74; // x8
  __int64 v75; // x20
  __int64 v76; // x0
  long double v77; // q0
  float v78; // s1
  float v79; // s2
  __int64 v80; // x0
  float v81; // s9
  float v82; // s10
  float v83; // s11
  float v84; // s1
  float v85; // s12
  float v86; // s2
  float v87; // s13
  float v88; // s0
  float v89; // s1
  __int64 v90; // x20
  __int64 v91; // x0
  _BOOL4 v92; // w8
  __int64 v93; // x20
  __int64 v94; // x0
  __int64 *v95; // x20
  __int64 v96; // x8
  __int64 v97; // x9
  _DWORD *v98; // x10
  __int64 v99; // x0
  __int64 v100; // x8
  float time; // s8
  __int64 v102; // x0
  long double v103; // q0
  float v104; // s1
  float v105; // s2
  float v106; // s0
  __int64 v107; // x0
  long double v108; // q0
  int v109; // s1
  int v110; // s2
  _BYTE v111[34]; // [xsp+0h] [xbp-180h] BYREF
  __int16 v112; // [xsp+22h] [xbp-15Eh]
  _BYTE v113[34]; // [xsp+30h] [xbp-150h] BYREF
  __int16 v114; // [xsp+52h] [xbp-12Eh]
  _QWORD v115[4]; // [xsp+60h] [xbp-120h] BYREF
  __int16 v116; // [xsp+82h] [xbp-FEh]
  _QWORD v117[12]; // [xsp+90h] [xbp-F0h] BYREF

  v117[11] = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  if ( (byte_8FFD489 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8430);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA740);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D67B70);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D67B68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D87A60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D56670);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D6F908);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D5CE18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D883F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D880D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D86FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D87EE8);
    byte_8FFD489 = 1;
  }
  memset(&v117[6], 0, 33);
  memset(v117, 0, 33);
  if ( *(_BYTE *)(a1 + 188) != 0 )
    return;
  v2 = *(unsigned __int8 *)(a1 + 577);
  if ( *(_BYTE *)(a1 + 592) == 0 && *(_BYTE *)(a1 + 578) == 0 )
  {
    v3 = *(_QWORD *)(a1 + 112);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v3, 0, 0) & 1) != 0 && *(_BYTE *)(a1 + 577) == 0 )
      GameModule_RoleBehaviour__CheckAndAttackWall(a1);
  }
  v4 = *(_QWORD *)(a1 + 80);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v4, 0, 0) & 1) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( transform == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    position = UnityEngine_Transform__get_position(transform, 0);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    ArchitectureTarget = GameModule_BattleGameSceneManager__GetArchitectureTarget(
                           (__int64)Instance,
                           *(_BYTE *)(a1 + 32),
                           position,
                           v8,
                           v9);
    *(_QWORD *)(a1 + 80) = ArchitectureTarget;
  }
  else
  {
    ArchitectureTarget = *(_QWORD *)(a1 + 80);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(ArchitectureTarget, 0, 0) & 1) != 0 && *(_BYTE *)(a1 + 440) != 0 )
    GameModule_RoleBehaviour__SetAiCanMove(a1, 0);
  v11 = *(_QWORD *)(a1 + 88);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v11, 0, 0) & 1) != 0 )
  {
    v12 = *(_QWORD *)(a1 + 88);
    *(_DWORD *)(a1 + 72) = 1;
    if ( v12 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v13 = UnityEngine_Component__get_transform(v12, 0);
    GameModule_RoleBehaviour__SetAiTarget(a1, v13);
    v14 = *(_QWORD *)(a1 + 88);
    if ( v14 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(a1 + 112) = UnityEngine_Component__get_transform(v14, 0);
  }
  else
  {
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
    if ( byte_8FFD1AB == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
      byte_8FFD1AB = 1;
    }
    v22 = (_BYTE **)off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      v22 = (_BYTE **)off_8CE5E20;
    }
    if ( *v22[23] == 0 )
      return;
    v23 = *(_QWORD *)(a1 + 80);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v23, 0, 0) & 1) != 0 )
      return;
    v24 = *(_QWORD *)(a1 + 80);
    *(_DWORD *)(a1 + 72) = 0;
    if ( v24 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v25 = UnityEngine_Component__get_transform(v24, 0);
    v26 = *(_QWORD *)(a1 + 112);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v26, v25, 0) & 1) != 0 )
      goto LABEL_65;
    v27 = *(_QWORD *)(a1 + 432);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v27, v25, 0) & 1) != 0 )
    {
LABEL_65:
      GameModule_RoleBehaviour__SetAiTarget(a1, v25);
      *(_QWORD *)(a1 + 112) = v25;
    }
  }
  if ( *(_BYTE *)(a1 + 592) != 0 )
  {
    if ( *(float *)(a1 + 616) <= 0.0 || (float)(UnityEngine_Time__get_time(0) - *(float *)(a1 + 616)) <= 8.0 )
    {
      GameModule_RoleBehaviour__AttackWall(a1);
      return;
    }
    *(_BYTE *)(a1 + 592) = 0;
    *(_OWORD *)(a1 + 600) = 0u;
    v15 = *(unsigned __int8 *)(a1 + 440);
    *(_DWORD *)(a1 + 616) = -1082130432;
    if ( v15 == 0 )
    {
      GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
      GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
      GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, 1);
      sub_3D7F628(a1, 1u, 0);
    }
  }
  if ( *(_BYTE *)(a1 + 440) == 0
    || *(_BYTE *)(a1 + 577) != 0
    || *(_BYTE *)(a1 + 188) != 0
    || *(_BYTE *)(a1 + 224) != 0
    || *(_BYTE *)(a1 + 404) != 0
    || *(_BYTE *)(a1 + 33) == 1 )
  {
    v16 = UnityEngine_Component__get_transform(a1, 0);
    if ( v16 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v17 = UnityEngine_Transform__get_position(v16, 0);
    *(_DWORD *)(a1 + 620) = LODWORD(v17);
    *(_DWORD *)(a1 + 624) = v18;
    *(_DWORD *)(a1 + 628) = v19;
    *(float *)(a1 + 632) = UnityEngine_Time__get_time(0);
  }
  else
  {
    time = UnityEngine_Time__get_time(0);
    v102 = UnityEngine_Component__get_transform(a1, 0);
    if ( v102 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v103 = UnityEngine_Transform__get_position(v102, 0);
    if ( (float)((float)((float)((float)(*(float *)&v103 - *(float *)(a1 + 620))
                               * (float)(*(float *)&v103 - *(float *)(a1 + 620)))
                       + (float)((float)(v104 - *(float *)(a1 + 624)) * (float)(v104 - *(float *)(a1 + 624))))
               + (float)((float)(v105 - *(float *)(a1 + 628)) * (float)(v105 - *(float *)(a1 + 628)))) >= 0.01 )
    {
      v107 = UnityEngine_Component__get_transform(a1, 0);
      if ( v107 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v108 = UnityEngine_Transform__get_position(v107, 0);
      *(_DWORD *)(a1 + 620) = LODWORD(v108);
      *(_DWORD *)(a1 + 624) = v109;
      *(_DWORD *)(a1 + 628) = v110;
      *(float *)(a1 + 632) = time;
    }
    else
    {
      v106 = *(float *)(a1 + 632);
      if ( v106 > 0.0 && (float)(time - v106) > 2.0 )
      {
        *(_BYTE *)(a1 + 578) = 0;
        *(_QWORD *)(a1 + 584) = 0;
        *(_BYTE *)(a1 + 592) = 0;
        *(_DWORD *)(a1 + 616) = -1082130432;
        *(_OWORD *)(a1 + 600) = 0u;
        *(float *)(a1 + 632) = time;
        GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
        sub_3D7F628(a1, 1u, 0);
      }
    }
  }
  v20 = *(_QWORD *)(a1 + 112);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v20, 0, 0) & 1) != 0 )
  {
    v21 = *(unsigned __int8 *)(a1 + 440);
    *(_BYTE *)(a1 + 577) = 0;
    *(_QWORD *)(a1 + 88) = 0;
    *(_QWORD *)(a1 + 280) = 0;
    *(_DWORD *)(a1 + 288) = -1;
    if ( v21 != 0 )
      return;
    goto LABEL_81;
  }
  v28 = *(_DWORD *)(a1 + 72);
  if ( v28 == 1 )
  {
    v29 = *(_QWORD *)(a1 + 88);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v29, 0, 0) & 1) != 0 )
      goto LABEL_73;
    v30 = *(_QWORD *)(a1 + 88);
    if ( v30 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v30 + 33) != 0 )
    {
LABEL_73:
      v31 = *(unsigned __int8 *)(a1 + 440);
      *(_QWORD *)(a1 + 88) = 0;
      *(_QWORD *)(a1 + 280) = 0;
      *(_DWORD *)(a1 + 288) = -1;
      *(_QWORD *)(a1 + 112) = 0;
      *(_BYTE *)(a1 + 577) = 0;
      if ( v31 != 0 )
        return;
      goto LABEL_81;
    }
    v28 = *(_DWORD *)(a1 + 72);
  }
  if ( v28 == 0 )
  {
    v32 = *(_QWORD *)(a1 + 80);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v32, 0, 0) & 1) != 0 )
    {
      v33 = *(unsigned __int8 *)(a1 + 440);
      *(_QWORD *)(a1 + 112) = 0;
      *(_BYTE *)(a1 + 577) = 0;
      if ( v33 != 0 )
        return;
LABEL_81:
      GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
      return;
    }
  }
  v34 = *(_QWORD *)(a1 + 64);
  if ( v34 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v35 = *(float *)(v34 + 36);
  v36 = UnityEngine_Component__get_transform(a1, 0);
  if ( v36 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v37 = UnityEngine_Transform__get_position(v36, 0);
  v40 = *(_QWORD *)(a1 + 112);
  if ( v40 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v41 = v37;
  v42 = v38;
  v43 = v39;
  LODWORD(v46) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v40, 0));
  v48 = v47;
  v50 = v49;
  if ( byte_8FFD020 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFD020 = 1;
  }
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA738);
  if ( sqrtf(
         (float)((float)(v43 - v50) * (float)(v43 - v50))
       + (float)((float)((float)(*(float *)&v41 - v46) * (float)(*(float *)&v41 - v46))
               + (float)((float)(v42 - v48) * (float)(v42 - v48)))) <= v35 )
  {
    *(_BYTE *)(a1 + 577) = 1;
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    if ( QuickTutor_Singleton_object___get_Instance(qword_8D17890, v44, v45) != 0 )
    {
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v63 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v61, v62);
      if ( v63 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v63, 0) & 1) != 0 )
      {
        if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE1928);
        v66 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v64, v65);
        if ( v66 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v66, 0) & 1) != 0 )
          GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 1);
        if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
        {
          v67 = *(_QWORD *)(a1 + 128);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(v67, 0, 0) & 1) != 0 )
          {
            v68 = *(_QWORD *)(a1 + 128);
            if ( v68 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v68, 0) & 1) != 0 )
            {
              v69 = *(_QWORD *)(a1 + 128);
              if ( v69 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              Pathfinding_FollowerEntity__get_rvoSettings(v115, v69, 0);
              qmemcpy(&v117[6], v115, 33);
              v70 = *(_QWORD *)(a1 + 128);
              if ( v70 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              v113[33] = 1;
              qmemcpy(v113, v115, 33);
              v114 = v116;
              Pathfinding_FollowerEntity__set_rvoSettings(v70, v113, 0);
            }
          }
        }
      }
    }
    GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, 0);
    if ( *(_BYTE *)(a1 + 440) != 0 )
    {
      GameModule_RoleBehaviour__SetAiCanMove(a1, 0);
      sub_3D7F628(a1, 0, 0);
    }
    v71 = UnityEngine_Time__get_time(0);
    v72 = *(_QWORD *)(a1 + 64);
    if ( v72 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (float)(v71 - *(float *)(a1 + 148)) > *(float *)(v72 + 44) && *(_BYTE *)(a1 + 576) == 0 )
    {
      v73 = UnityEngine_Time__get_time(0);
      v74 = *(_QWORD *)(a1 + 64);
      *(float *)(a1 + 148) = v73;
      if ( v74 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)a1 + 776LL))(
        a1,
        *(unsigned int *)(v74 + 32),
        *(_QWORD *)(*(_QWORD *)a1 + 784LL));
    }
  }
  else
  {
    *(_BYTE *)(a1 + 577) = 0;
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v51 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v44, v45);
    if ( v51 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v51, 0) & 1) != 0 )
      GameModule_RoleBehaviour__ApplyOccupancyPenalty(a1, 0);
    if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    {
      v52 = *(_QWORD *)(a1 + 128);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v52, 0, 0) & 1) != 0 )
      {
        v53 = *(_QWORD *)(a1 + 128);
        if ( v53 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v53, 0) & 1) != 0 )
        {
          v54 = *(_QWORD *)(a1 + 128);
          if ( v54 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          Pathfinding_FollowerEntity__get_rvoSettings(v115, v54, 0);
          qmemcpy(v117, v115, 33);
          v55 = *(_QWORD *)(a1 + 128);
          if ( v55 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v111[33] = 0;
          v112 = v116;
          qmemcpy(v111, v115, 33);
          Pathfinding_FollowerEntity__set_rvoSettings(v55, v111, 0);
        }
      }
    }
    GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, 1);
    v56 = *(__int64 **)(a1 + 320);
    if ( v56 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v57 = *v56;
    v58 = *(unsigned __int16 *)(*v56 + 302);
    if ( *(_WORD *)(*v56 + 302) != 0 )
    {
      v59 = (_DWORD *)(*(_QWORD *)(v57 + 176) + 8LL);
      while ( *((_QWORD *)v59 - 1) != qword_8CE8430 )
      {
        --v58;
        v59 += 4;
        if ( v58 == 0 )
          goto LABEL_109;
      }
      v60 = v57 + 16LL * (*v59 + 3) + 312;
    }
    else
    {
LABEL_109:
      v60 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(*(_QWORD *)(a1 + 320), qword_8CE8430, 3);
    }
    if ( ((*(__int64 (__fastcall **)(__int64 *, __int64, _QWORD))v60)(v56, 3, *(_QWORD *)(v60 + 8)) & 1) != 0 )
    {
      v75 = *(_QWORD *)(a1 + 112);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v75, 0, 0) & 1) != 0 )
      {
        v76 = UnityEngine_Component__get_transform(a1, 0);
        if ( v76 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v77 = UnityEngine_Transform__get_position(v76, 0);
        v80 = *(_QWORD *)(a1 + 112);
        if ( v80 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v41 = v77;
        v81 = v78;
        v82 = v79;
        LODWORD(v83) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v80, 0));
        v85 = v84;
        v87 = v86;
        if ( byte_8FFD020 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD020 = 1;
        }
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        v88 = sqrtf(
                (float)((float)(v82 - v87) * (float)(v82 - v87))
              + (float)((float)((float)(*(float *)&v41 - v83) * (float)(*(float *)&v41 - v83))
                      + (float)((float)(v81 - v85) * (float)(v81 - v85))));
      }
      else
      {
        v88 = 3.4028e38;
      }
      v89 = v35 * 1.2;
      if ( (float)(v35 + 0.25) > (float)(v35 * 1.2) )
        v89 = v35 + 0.25;
      if ( v88 <= v89 )
      {
        if ( *(_BYTE *)(a1 + 440) != 0 )
          GameModule_RoleBehaviour__SetAiCanMove(a1, 0);
        return;
      }
      *(_BYTE *)(a1 + 576) = 0;
    }
    if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
      goto LABEL_161;
    v90 = *(_QWORD *)(a1 + 128);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v90, 0, 0) & 1) == 0 )
    {
LABEL_161:
      v92 = false;
    }
    else
    {
      v91 = *(_QWORD *)(a1 + 128);
      if ( v91 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v92 = (UnityEngine_Behaviour__get_enabled(v91, 0) & 1) == 0;
    }
    if ( (v92 | *(unsigned __int8 *)(a1 + 440) ^ 1) != 0 )
    {
      if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
      {
        v93 = *(_QWORD *)(a1 + 128);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(v93, 0, 0) & 1) != 0 )
        {
          v94 = *(_QWORD *)(a1 + 128);
          if ( v94 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          UnityEngine_Behaviour__set_enabled(v94, 1, 0);
        }
      }
      GameModule_RoleBehaviour__SetAiCanMove(a1, 1);
    }
    v95 = *(__int64 **)(a1 + 320);
    if ( v95 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v96 = *v95;
    v97 = *(unsigned __int16 *)(*v95 + 302);
    if ( *(_WORD *)(*v95 + 302) != 0 )
    {
      v98 = (_DWORD *)(*(_QWORD *)(v96 + 176) + 8LL);
      while ( *((_QWORD *)v98 - 1) != qword_8CE8430 )
      {
        --v97;
        v98 += 4;
        if ( v97 == 0 )
          goto LABEL_175;
      }
      v99 = v96 + 16LL * (*v98 + 3) + 312;
    }
    else
    {
LABEL_175:
      v99 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(*(_QWORD *)(a1 + 320), qword_8CE8430, 3);
    }
    if ( ((*(__int64 (__fastcall **)(__int64 *, __int64, _QWORD))v99)(v95, 1, *(_QWORD *)(v99 + 8)) & 1) == 0 )
      sub_3D7F628(a1, 1u, 0);
    if ( v2 != 0 )
      *(_BYTE *)(a1 + 452) = 1;
    GameModule_RoleBehaviour__TryRefreshSearchPath(a1);
    v100 = *(_QWORD *)(a1 + 64);
    if ( v100 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    LODWORD(v41) = *(_DWORD *)(v100 + 36);
    if ( *((_DWORD *)off_8CEA740 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA740);
    if ( byte_8FFD4B5 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD4B5 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    sub_7685A40(0, 6.0, v41);
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)a1 + 408LL))(a1, *(_QWORD *)(*(_QWORD *)a1 + 416LL));
  }
}
