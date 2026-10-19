__int64 __fastcall GameModule_RoleBehaviour__MeleeAtkCallBackLogic_d__248__MoveNext(__int64 a1)
{
  long double v1; // q8
  __int64 v3; // x20
  __int64 v4; // x3
  __int64 v5; // x8
  __int64 v6; // x0
  int v7; // w21
  __int64 v8; // x3
  __int64 v9; // x0
  __int64 v10; // x8
  __int64 v11; // x9
  _DWORD *v12; // x10
  __int64 v13; // x0
  __int64 v14; // x3
  int v15; // w0
  __int64 v16; // x8
  int *v17; // x21
  _QWORD *v18; // x8
  int v19; // w22
  float v20; // s9
  double v21; // d0
  double v22; // d0
  double v23; // d1
  __int64 v24; // x21
  __int64 transform; // x21
  __int64 v26; // x0
  long double v27; // q0
  long double v28; // q1
  long double v29; // q2
  long double v30; // q3
  __int64 v31; // x0
  long double v32; // q8
  long double v33; // q9
  long double v34; // q10
  long double v35; // q11
  __int64 v36; // x0
  long double position; // q0
  long double XZDirection; // q12
  long double v39; // q1
  long double v40; // q13
  long double v41; // q2
  long double v42; // q14
  long double v43; // q4
  long double v44; // q1
  long double v45; // q2
  long double v46; // q3
  __int64 v47; // x3
  __int64 v48; // x8
  __int64 v49; // x21
  unsigned int v50; // w22
  __int64 v51; // x23
  char v52; // w0
  void *Instance; // x21
  __int64 v54; // x0
  long double v55; // q0
  long double v56; // q1
  long double v57; // q2
  __int64 ArchitectureTarget; // x0
  __int64 v59; // x21
  __int64 v60; // x21
  __int64 v61; // x0
  __int64 v62; // x0
  float v63; // s8
  float v64; // s1
  float v65; // s9
  float v66; // s2
  float v67; // s10
  __int64 v68; // x0
  float v69; // s11
  float v70; // s1
  float v71; // s12
  float v72; // s2
  float v73; // s13
  __int64 v74; // x8
  __int64 v75; // x21
  __int64 v76; // x0
  long double v77; // q0
  long double v78; // q1
  long double v79; // q2
  long double v80; // q3
  __int64 v81; // x0
  long double v82; // q8
  long double v83; // q9
  long double v84; // q10
  long double v85; // q11
  __int64 v86; // x0
  long double v87; // q0
  long double v88; // q12
  long double v89; // q1
  long double v90; // q13
  long double v91; // q2
  long double v92; // q14
  long double v93; // q4
  long double v94; // q1
  long double v95; // q2
  long double v96; // q3
  unsigned int v97; // w0
  __int64 v98; // x3
  __int64 v99; // x8
  unsigned int v100; // w21
  __int64 v101; // x23
  __int64 v102; // x22
  char v103; // w0
  double v104; // d1
  int v105; // w8
  __int64 v106; // x22
  unsigned int v107; // w0
  __int64 v108; // x3
  __int64 v109; // x8
  unsigned int v110; // w21
  __int64 v111; // x23
  __int64 v112; // x22
  char v113; // w0
  __int64 v114; // x8
  __int64 v116; // x8
  __int64 v117; // x21
  __int64 v118; // x1
  __int64 v119; // x22
  __int64 v120; // x8
  __int64 v121; // x9
  int *v122; // x10
  __int64 v123; // x0
  double v124; // [xsp+0h] [xbp-A0h]
  __int128 v125; // [xsp+10h] [xbp-90h] BYREF
  double v126; // [xsp+28h] [xbp-78h] BYREF

  if ( (byte_8FFD4C3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D22520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53820);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D80100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53708);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53818);
    byte_8FFD4C3 = 1;
  }
  v125 = 0u;
  v3 = *(_QWORD *)(a1 + 48);
  if ( *(_DWORD *)a1 == 0 )
  {
    v125 = *(_OWORD *)(a1 + 72);
    *(_QWORD *)(a1 + 72) = 0;
    *(_QWORD *)(a1 + 80) = 0;
    *(_DWORD *)a1 = -1;
    goto LABEL_12;
  }
  if ( *((_DWORD *)off_8CE40D8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40D8);
  if ( (UnityEngine_Application__get_isPlaying(0) & 1) == 0 )
    goto LABEL_107;
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v5 = *(_QWORD *)(v3 + 64);
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v6 = *(_QWORD *)(v5 + 16);
  v7 = *(_DWORD *)(a1 + 40);
  *(_QWORD *)(a1 + 56) = v6;
  if ( (System_String__op_Equality(v6, qword_8D53820, 0, v4) & 1) != 0 )
  {
    v9 = qword_8D53810;
    *(_QWORD *)(a1 + 56) = qword_8D53810;
  }
  else
  {
    v9 = *(_QWORD *)(a1 + 56);
  }
  if ( (System_String__op_Equality(v9, qword_8D53708, 0, v8) & 1) != 0 && *(_BYTE *)(v3 + 552) != 0 )
    *(_QWORD *)(a1 + 56) = qword_8D53818;
  if ( (System_String__op_Equality(*(_QWORD *)(a1 + 56), qword_8D53708, 0, v14) & 1) != 0 && *(_BYTE *)(v3 + 553) != 0 )
    *(_QWORD *)(a1 + 56) = qword_8D53890;
  v15 = UnityEngine_Random__Range(0);
  v16 = *(_QWORD *)(v3 + 64);
  if ( v16 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(a1 + 64) = GameModule_RoleBehaviour__OnAttackTalentTrigger(
                           v3,
                           (unsigned int)(v7 << ((float)(*(float *)(v16 + 68) * 100.0) > (float)v15)),
                           0);
  v17 = (int *)(a1 + 64);
  v18 = off_8CE5558;
  if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5558);
    v18 = off_8CE5558;
  }
  LODWORD(v1) = *(_DWORD *)(v18[23] + 16LL);
  if ( *(float *)&v1 != 1.0 )
  {
    v19 = *v17;
    if ( *((_DWORD *)v18 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v18);
      LODWORD(v1) = *(_DWORD *)(*((_QWORD *)off_8CE5558 + 23) + 16LL);
    }
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    v20 = *(float *)&v1 * (float)v19;
    *(double *)&v1 = v20;
    ((void (__fastcall *)(double *, long double))modf)(&v126, v1);
    if ( v20 >= 0.0 )
    {
      if ( v21 == 0.5 )
      {
        v22 = v126;
        v23 = 1.0;
LABEL_84:
        v104 = v22 + v23;
        if ( ((__int64)v22 & 1) != 0 )
          v22 = v104;
        goto LABEL_89;
      }
      v22 = floor(*(double *)&v1 + 0.5);
    }
    else
    {
      if ( v21 == -0.5 )
      {
        v22 = v126;
        v23 = -1.0;
        goto LABEL_84;
      }
      v22 = ceil(*(double *)&v1 + -0.5);
    }
LABEL_89:
    if ( v22 == INFINITY )
      v105 = 0x80000000;
    else
      v105 = (int)v22;
    *v17 = v105;
  }
  if ( *(_BYTE *)(v3 + 396) != 0 )
    GameModule_RoleBehaviour__StealthAddAtkAndEnd(v3, a1 + 64, 0);
  v106 = *(_QWORD *)(v3 + 104);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v106, 0, 0) & 1) != 0 )
  {
    v107 = GameModule_RoleBehaviour__ApplyBuildingDamageMultiplierIfNeeded(
             v3,
             (unsigned int)*v17,
             *(_QWORD *)(v3 + 104),
             0);
    *(_DWORD *)(a1 + 64) = v107;
    v109 = *(_QWORD *)(v3 + 64);
    v110 = v107;
    if ( v109 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v111 = *(_QWORD *)(v3 + 104);
    v112 = *(_QWORD *)(a1 + 56);
    v113 = System_String__op_Equality(*(_QWORD *)(v109 + 56), qword_8D80100, 0, v108);
    if ( v111 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD, __int64, _QWORD, __int64, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v111 + 376LL))(
      v111,
      v110,
      v112,
      0,
      v3,
      v113 & 1,
      *(unsigned int *)(v3 + 204),
      *(unsigned int *)(v3 + 200),
      0,
      *(_QWORD *)(*(_QWORD *)v111 + 384LL),
      v125,
      *((_QWORD *)&v125 + 1));
LABEL_101:
    v114 = *(_QWORD *)(v3 + 64);
    if ( v114 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(float *)(v114 + 72) > 0.0 )
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v3 + 856LL))(v3, *(_QWORD *)(*(_QWORD *)v3 + 864LL));
    if ( *(_DWORD *)(v3 + 316) != 6 && *(_BYTE *)(v3 + 376) == 0 )
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)v3 + 888LL))(
        v3,
        *(unsigned int *)(a1 + 64),
        *(_QWORD *)(*(_QWORD *)v3 + 896LL));
LABEL_107:
    *(_QWORD *)(a1 + 56) = 0;
    *(_DWORD *)a1 = -2;
    return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
  }
  v116 = *(_QWORD *)(v3 + 64);
  if ( v116 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v117 = (*(__int64 (__fastcall **)(__int64, _QWORD, float))(*(_QWORD *)v3 + 408LL))(
           v3,
           *(_QWORD *)(*(_QWORD *)v3 + 416LL),
           *(float *)(v116 + 36));
  v119 = v118;
  if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEDF8);
  *(_QWORD *)&v125 = v117;
  *((_QWORD *)&v125 + 1) = v119;
  if ( byte_8FFD1AD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD1AD = 1;
  }
  if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEDF8);
  if ( byte_8FFD1AE == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AE = 1;
  }
  if ( (_QWORD)v125 == 0 )
    goto LABEL_12;
  v120 = *(_QWORD *)v125;
  v121 = *(unsigned __int16 *)(*(_QWORD *)v125 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v125 + 302LL) != 0 )
  {
    v122 = (int *)(*(_QWORD *)(v120 + 176) + 8LL);
    while ( *((_QWORD *)v122 - 1) != qword_8CE91C8 )
    {
      --v121;
      v122 += 4;
      if ( v121 == 0 )
        goto LABEL_122;
    }
    v123 = v120 + 16LL * *v122 + 312;
  }
  else
  {
LABEL_122:
    v123 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v125, qword_8CE91C8, 0);
  }
  if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v123)(v125, WORD4(v125), *(_QWORD *)(v123 + 8)) != 0 )
  {
LABEL_12:
    if ( byte_8FFD1AF == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AF = 1;
    }
    if ( (_QWORD)v125 != 0 )
    {
      v10 = *(_QWORD *)v125;
      v11 = *(unsigned __int16 *)(*(_QWORD *)v125 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v125 + 302LL) != 0 )
      {
        v12 = (_DWORD *)(*(_QWORD *)(v10 + 176) + 8LL);
        while ( *((_QWORD *)v12 - 1) != qword_8CE91C8 )
        {
          --v11;
          v12 += 4;
          if ( v11 == 0 )
            goto LABEL_19;
        }
        v13 = v10 + 16LL * (*v12 + 2) + 312;
      }
      else
      {
LABEL_19:
        v13 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v125, qword_8CE91C8, 2);
      }
      (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v13)(v125, WORD4(v125), *(_QWORD *)(v13 + 8));
    }
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v24 = *(_QWORD *)(v3 + 88);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v24, 0, 0) & 1) != 0 )
    {
      *(_DWORD *)(v3 + 72) = 1;
      transform = UnityEngine_Component__get_transform(v3, 0);
      v26 = UnityEngine_Component__get_transform(v3, 0);
      if ( v26 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__get_rotation(v26, 0);
      v31 = *(_QWORD *)(v3 + 88);
      if ( v31 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v32 = v27;
      v33 = v28;
      v34 = v29;
      v35 = v30;
      v36 = UnityEngine_Component__get_transform(v31, 0);
      if ( v36 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      position = UnityEngine_Transform__get_position(v36, 0);
      XZDirection = GameModule_RoleBehaviour__GetXZDirection(v3, 0, position);
      v40 = v39;
      v42 = v41;
      if ( byte_8FFCFFE == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
        byte_8FFCFFE = 1;
      }
      v43 = UnityEngine_Quaternion__LookRotation(
              0,
              XZDirection,
              v40,
              v42,
              *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 24LL),
              *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 28LL),
              *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 32LL));
      LODWORD(v124) = 1061997773;
      UnityEngine_Quaternion__Lerp(0, v32, v33, v34, v35, v43, v44, v45, v46, v124);
      if ( transform == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UnityEngine_Transform__set_rotation(transform, 0);
      v48 = *(_QWORD *)(v3 + 64);
      if ( v48 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v49 = *(_QWORD *)(v3 + 88);
      v50 = *(_DWORD *)(a1 + 64);
      v51 = *(_QWORD *)(a1 + 56);
      v52 = System_String__op_Equality(*(_QWORD *)(v48 + 56), qword_8D80100, 0, v47);
      if ( v49 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      (*(void (__fastcall **)(__int64, _QWORD, __int64, _QWORD, __int64, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v49 + 376LL))(
        v49,
        v50,
        v51,
        0,
        v3,
        v52 & 1,
        *(unsigned int *)(v3 + 204),
        *(unsigned int *)(v3 + 200),
        0,
        *(_QWORD *)(*(_QWORD *)v49 + 384LL));
    }
    else
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      v54 = UnityEngine_Component__get_transform(v3, 0);
      if ( v54 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v55 = UnityEngine_Transform__get_position(v54, 0);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      ArchitectureTarget = GameModule_BattleGameSceneManager__GetArchitectureTarget(
                             (__int64)Instance,
                             *(_BYTE *)(v3 + 32),
                             v55,
                             v56,
                             v57);
      *(_QWORD *)(v3 + 80) = ArchitectureTarget;
      v59 = ArchitectureTarget;
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v59, 0, 0) & 1) != 0 )
        *(_DWORD *)(v3 + 72) = 0;
      v60 = *(_QWORD *)(v3 + 80);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v60, 0, 0) & 1) != 0 )
      {
        v61 = *(_QWORD *)(v3 + 80);
        if ( v61 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v62 = UnityEngine_Component__get_transform(v61, 0);
        if ( v62 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        LODWORD(v63) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v62, 0));
        v65 = v64;
        v67 = v66;
        v68 = UnityEngine_Component__get_transform(v3, 0);
        if ( v68 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        LODWORD(v69) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v68, 0));
        v71 = v70;
        v73 = v72;
        if ( byte_8FFD020 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD020 = 1;
        }
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        v74 = *(_QWORD *)(v3 + 64);
        if ( v74 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( sqrtf(
               (float)((float)(v67 - v73) * (float)(v67 - v73))
             + (float)((float)((float)(v63 - v69) * (float)(v63 - v69))
                     + (float)((float)(v65 - v71) * (float)(v65 - v71)))) <= *(float *)(v74 + 36) )
        {
          v75 = UnityEngine_Component__get_transform(v3, 0);
          v76 = UnityEngine_Component__get_transform(v3, 0);
          if ( v76 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          UnityEngine_Transform__get_rotation(v76, 0);
          v81 = *(_QWORD *)(v3 + 80);
          if ( v81 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v82 = v77;
          v83 = v78;
          v84 = v79;
          v85 = v80;
          v86 = UnityEngine_Component__get_transform(v81, 0);
          if ( v86 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v87 = UnityEngine_Transform__get_position(v86, 0);
          v88 = GameModule_RoleBehaviour__GetXZDirection(v3, 0, v87);
          v90 = v89;
          v92 = v91;
          if ( byte_8FFCFFE == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
            byte_8FFCFFE = 1;
          }
          v93 = UnityEngine_Quaternion__LookRotation(
                  0,
                  v88,
                  v90,
                  v92,
                  *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 24LL),
                  *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 28LL),
                  *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 32LL));
          LODWORD(v124) = 1061997773;
          UnityEngine_Quaternion__Lerp(0, v82, v83, v84, v85, v93, v94, v95, v96, v124);
          if ( v75 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          UnityEngine_Transform__set_rotation(v75, 0);
          v97 = GameModule_RoleBehaviour__ApplyBuildingDamageMultiplierIfNeeded(
                  v3,
                  *(unsigned int *)(a1 + 64),
                  *(_QWORD *)(v3 + 80),
                  0);
          *(_DWORD *)(a1 + 64) = v97;
          v99 = *(_QWORD *)(v3 + 64);
          v100 = v97;
          if ( v99 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v101 = *(_QWORD *)(v3 + 80);
          v102 = *(_QWORD *)(a1 + 56);
          v103 = System_String__op_Equality(*(_QWORD *)(v99 + 56), qword_8D80100, 0, v98);
          if ( v101 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          (*(void (__fastcall **)(__int64, _QWORD, __int64, _QWORD, __int64, _QWORD, _QWORD, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v101 + 376LL))(
            v101,
            v100,
            v102,
            0,
            v3,
            v103 & 1,
            *(unsigned int *)(v3 + 204),
            *(unsigned int *)(v3 + 200),
            0,
            *(_QWORD *)(*(_QWORD *)v101 + 384LL));
        }
      }
    }
    goto LABEL_101;
  }
  *(_DWORD *)a1 = 0;
  *(_OWORD *)(a1 + 72) = v125;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__RoleBehaviour__MeleeAtkCallBackLogic_d__248_(
           a1 + 8,
           &v125,
           a1,
           qword_8D22520);
}
