__int64 __fastcall GameModule_RoleBehaviour__Init(
        __int64 *a1,
        __int64 a2,
        char a3,
        unsigned int a4,
        unsigned int a5,
        __int64 a6,
        unsigned int a7,
        int a8)
{
  long double ScaledRadius; // q8
  long double v9; // q9
  __int64 gameObject; // x0
  __int64 v17; // x2
  __int64 v18; // x23
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 transform; // x0
  __int64 v23; // x0
  float v24; // s8
  __int64 v25; // x27
  __int64 v26; // x23
  __int64 v27; // x1
  __int64 v28; // x2
  __int64 v29; // x1
  __int64 v30; // x2
  __int64 Instance; // x0
  __int64 v32; // x0
  __int64 v33; // x27
  __int64 v34; // x1
  __int64 v35; // x2
  _QWORD *v36; // x24
  __int64 v37; // x0
  __int64 v38; // x0
  int v39; // w8
  __int64 v40; // x0
  __int64 v41; // x8
  __int64 v42; // x20
  int v43; // w9
  __int64 v44; // x0
  __int64 v45; // x0
  __int64 v46; // x8
  __int64 v47; // x27
  unsigned int v48; // w28
  unsigned __int64 v49; // x22
  __int64 v50; // x21
  __int64 v51; // x23
  __int64 v52; // x29
  __int64 v53; // x1
  __int64 v54; // x2
  long double v55; // q0
  __int64 v56; // x8
  _QWORD *v57; // x9
  __int64 v58; // x10
  __int64 v59; // x0
  char IsBTest; // w0
  __int64 v61; // x29
  long double Item; // q0
  __int64 v63; // x23
  char v64; // w27
  __int64 v65; // x25
  __int64 v66; // x0
  __int64 v67; // x0
  __int64 v68; // x0
  __int128 v69; // q1
  __int64 v70; // x8
  _QWORD *v71; // x0
  __int64 v72; // x8
  int v73; // w20
  _QWORD *v74; // x0
  __int64 v75; // x8
  __int64 v76; // x9
  __int128 v77; // q0
  __int64 v78; // x9
  int v79; // w21
  bool UseWebGLNavigation; // w8
  __int64 v81; // x0
  int v82; // w20
  float v83; // s0
  __int64 v84; // x0
  __int64 v85; // x0
  __int64 v86; // x1
  __int64 v87; // x2
  float v88; // s0
  int v89; // w8
  float v90; // s0
  __int64 v91; // x0
  int v92; // w8
  int v93; // w9
  __int64 v94; // x0
  int v95; // w8
  __int64 v96; // x0
  __int64 v97; // x8
  __int64 v98; // x27
  __int64 i; // x9
  __int64 v100; // x11
  __int64 v101; // x0
  __int64 v102; // x23
  __int64 result; // x0
  __int64 v104; // x8
  int v105; // s0
  __int64 v106; // x8
  __int64 v107; // x1
  __int64 v108; // x2
  __int64 v109; // x0
  __int64 Component_object; // x0
  int v111; // s0
  __int64 v112; // x0
  __int64 v113; // x0
  __int64 v114; // x0
  char v115; // w0
  void *v116; // x0
  long double EquippedArtifactTraitPercent; // q10
  void *v118; // x0
  long double v119; // q9
  __int64 v120; // x20
  float v121; // s11
  float v122; // s10
  float v123; // s11
  double v124; // d0
  double v125; // d0
  double v126; // d1
  __int64 v127; // x22
  __int64 v128; // x0
  __int64 v129; // x22
  __int64 v130; // x22
  __int64 v131; // x22
  __int64 v132; // x0
  __int64 parent; // x0
  __int64 v134; // x0
  __int64 v135; // x22
  __int64 v136; // x0
  long double position; // q0
  float v138; // s1
  long double v139; // q2
  void *v140; // x22
  __int64 v141; // x0
  long double v142; // q0
  long double v143; // q1
  long double v144; // q2
  __int64 ArchitectureTarget; // x0
  __int64 v146; // x8
  __int64 v147; // x22
  __int64 v148; // x0
  void *v149; // x0
  __int64 v150; // x0
  __int64 v151; // x2
  long double v152; // q0
  __int64 *v153; // x20
  __int64 v154; // x8
  long double v155; // q9
  __int64 v156; // x9
  int *v157; // x10
  __int64 v158; // x0
  double v159; // d1
  __int64 v160; // x8
  int *v161; // x8
  int v162; // s0
  __int64 v163; // x2
  __int64 v164; // x20
  __int64 v165; // x0
  _DWORD *v166; // x8
  __int64 v167; // x1
  __int64 v168; // x2
  __int64 v169; // x0
  __int64 *v170; // x20
  float v171; // s0
  __int64 v172; // x8
  __int64 v173; // x9
  _DWORD *v174; // x10
  __int64 v175; // x0
  __int64 v176; // x8
  __int64 v177; // x9
  int *v178; // x10
  __int64 v179; // x0
  int v180; // w8
  __int64 v181; // x8
  float v182; // s10
  float v183; // s9
  float v184; // s10
  double v185; // d0
  double v186; // d0
  double v187; // d1
  double v188; // d1
  int v189; // w9
  __int64 v190; // x8
  __int64 v191; // [xsp+18h] [xbp-228h]
  unsigned int v192; // [xsp+28h] [xbp-218h]
  char v195; // [xsp+34h] [xbp-20Ch]
  _DWORD v196[5]; // [xsp+38h] [xbp-208h] BYREF
  __int128 v197; // [xsp+4Ch] [xbp-1F4h]
  char v198; // [xsp+60h] [xbp-1E0h]
  __int16 v199; // [xsp+61h] [xbp-1DFh]
  char v200; // [xsp+63h] [xbp-1DDh]
  float v201; // [xsp+64h] [xbp-1DCh]
  __int128 v202; // [xsp+68h] [xbp-1D8h]
  __int16 v203; // [xsp+7Ch] [xbp-1C4h]
  char v204; // [xsp+7Eh] [xbp-1C2h]
  __int128 v205; // [xsp+80h] [xbp-1C0h]
  __int64 v206; // [xsp+90h] [xbp-1B0h]
  __int64 v207; // [xsp+98h] [xbp-1A8h]
  _BYTE v208[28]; // [xsp+A0h] [xbp-1A0h]
  _BYTE v209[34]; // [xsp+C0h] [xbp-180h] BYREF
  __int16 v210; // [xsp+E2h] [xbp-15Eh]
  _BYTE v211[8]; // [xsp+E8h] [xbp-158h] BYREF
  __int128 v212; // [xsp+F0h] [xbp-150h]
  unsigned __int64 v213; // [xsp+108h] [xbp-138h]
  __int128 v214; // [xsp+110h] [xbp-130h]
  __int16 v215; // [xsp+12Ch] [xbp-114h]
  char v216; // [xsp+12Eh] [xbp-112h]
  _BYTE v217[136]; // [xsp+130h] [xbp-110h] BYREF
  __int64 v218; // [xsp+1B8h] [xbp-88h]

  v218 = *(_QWORD *)(_ReadStatusReg(TPIDR_EL0) + 40);
  if ( (byte_8FFD456 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25DD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8430);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0E270);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0E290);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E298);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E2A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12108);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CECB18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE36B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6BEF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D630E0);
    byte_8FFD456 = 1;
  }
  v215 = 0;
  v216 = 0;
  v213 = 0;
  v211[0] = 0;
  memset(&v217[96], 0, 33);
  memset(&v217[64], 0, 28);
  v214 = 0u;
  v212 = 0u;
  *((_BYTE *)a1 + 636) = 0;
  *((_BYTE *)a1 + 576) = 0;
  *((_BYTE *)a1 + 33) = 0;
  *((_BYTE *)a1 + 188) = 0;
  *(_WORD *)((char *)a1 + 577) = 0;
  *((_DWORD *)a1 + 154) = -1082130432;
  *((_BYTE *)a1 + 592) = 0;
  a1[73] = 0;
  *(_OWORD *)(a1 + 75) = 0u;
  gameObject = UnityEngine_Component__get_gameObject(a1, 0);
  if ( gameObject == 0 )
    goto LABEL_255;
  UnityEngine_GameObject__SetActive(gameObject, 1, 0);
  GameModule_RoleBehaviour__SetPathfindingEnabled(a1, 1, v17);
  *((_BYTE *)a1 + 480) = 0;
  a1[59] = 0;
  *(__int64 *)((char *)a1 + 492) = 0;
  *(__int64 *)((char *)a1 + 500) = 0;
  *(__int64 *)((char *)a1 + 484) = 0;
  if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v18 = a1[16];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v18, 0, 0) & 1) != 0 )
    {
      v19 = a1[16];
      if ( v19 == 0 )
        goto LABEL_255;
      if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v19, 0) & 1) != 0 )
      {
        v20 = a1[16];
        if ( v20 == 0 )
          goto LABEL_255;
        Pathfinding_FollowerEntity__get_rvoSettings(v217, v20, 0);
        qmemcpy(&v217[96], v217, 33);
        v21 = a1[16];
        if ( v21 == 0 )
          goto LABEL_255;
        qmemcpy(v209, v217, 33);
        v209[33] = 0;
        v210 = *(_WORD *)&v217[34];
        Pathfinding_FollowerEntity__set_rvoSettings(v21, v209, 0);
      }
    }
  }
  v192 = a4;
  v195 = a3;
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform == 0 )
    goto LABEL_255;
  UnityEngine_Transform__set_localScale(transform, 0, *((float *)a1 + 46), *((float *)a1 + 46), *((float *)a1 + 46));
  v23 = UnityEngine_Component__get_transform(a1, 0);
  v24 = *((float *)a1 + 46);
  v25 = v23;
  if ( byte_8FFD01F == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFD01F = 1;
  }
  DG_Tweening_ShortcutExtensions__DOPunchScale(
    v25,
    1,
    0,
    (float)(v24 * 0.3) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 12LL),
    (float)(v24 * 0.3) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 16LL),
    (float)(v24 * 0.3) * *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 20LL),
    0.3,
    0.0);
  v26 = a1[16];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v26, 0, 0) & 1) != 0 && *((float *)a1 + 36) > 0.0 )
  {
    ScaledRadius = GameModule_RoleBehaviour__GetScaledRadius(a1);
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    if ( QuickTutor_Singleton_object___get_Instance(qword_8D17890, v27, v28) != 0 )
    {
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v29, v30);
      if ( Instance == 0 )
        goto LABEL_255;
      if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(Instance, 0) & 1) == 0 )
        *(float *)&ScaledRadius = *(float *)&ScaledRadius * 0.5;
    }
    *((_DWORD *)a1 + 112) = LODWORD(ScaledRadius);
    if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    {
      v32 = a1[16];
      if ( v32 == 0 )
        goto LABEL_255;
      Pathfinding_FollowerEntity__set_radius(v32, 0, ScaledRadius);
    }
  }
  v33 = UnityEngine_Component__get_transform(a1, 0);
  if ( byte_8FFCFFD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFCFFD = 1;
  }
  if ( v33 == 0 )
    goto LABEL_255;
  UnityEngine_Transform__set_localEulerAngles(
    v33,
    0,
    **((float **)off_8CEF3D8 + 23),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 4LL),
    *(float *)(*((_QWORD *)off_8CEF3D8 + 23) + 8LL));
  a1[10] = 0;
  v36 = a1 + 10;
  v37 = a1[27];
  a1[11] = 0;
  a1[34] = 0xBF80000000000000LL;
  a1[35] = 0;
  *((_DWORD *)a1 + 72) = -1;
  a1[21] = 0;
  a1[24] = 0;
  a1[26] = 0;
  a1[13] = 0;
  a1[14] = 0;
  if ( v37 != 0 )
  {
    v38 = UnityEngine_GameObject__get_gameObject(v37, 0);
    if ( v38 == 0 )
      goto LABEL_255;
    UnityEngine_GameObject__SetActive(v38, 0, 0);
  }
  v39 = *((unsigned __int8 *)a1 + 404);
  *((_BYTE *)a1 + 224) = 0;
  *((_DWORD *)a1 + 57) = 0;
  if ( v39 != 0 )
    GameModule_RoleBehaviour__ClearDizzyState(a1);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v40 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v34, v35);
  if ( v40 == 0 )
    goto LABEL_255;
  LODWORD(ScaledRadius) = 1.0;
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(v40, 0) & 1) != 0 )
  {
    if ( a2 == 0 )
      goto LABEL_255;
    if ( (System_String__IsNullOrEmpty(*(_QWORD *)(a2 + 144), 0) & 1) == 0 )
    {
      ScaledRadius = ToolModule_StringTool__ToFloat(*(_QWORD *)(a2 + 144), 0);
      if ( *(float *)&ScaledRadius <= 0.0 )
        LODWORD(ScaledRadius) = 1.0;
    }
  }
  v41 = a1[38];
  v191 = a6;
  *((_BYTE *)a1 + 648) = 0;
  if ( v41 == 0 )
    goto LABEL_255;
  v42 = a2;
  if ( *(_DWORD *)(v41 + 24) == 0 )
  {
    v43 = *(_DWORD *)(v41 + 28) + 1;
    *(_DWORD *)(v41 + 24) = 0;
    *(_DWORD *)(v41 + 28) = v43;
    if ( a2 == 0 )
      goto LABEL_255;
    v44 = *(_QWORD *)(a2 + 72);
    if ( v44 == 0 )
      goto LABEL_255;
    v45 = System_String__Split(v44, 59, 0, 0);
    if ( v45 == 0 )
      goto LABEL_255;
    v46 = *(_QWORD *)(v45 + 24);
    v47 = v45;
    if ( (int)v46 >= 1 )
    {
      v48 = 0;
      v49 = 0;
      v50 = v45 + 32;
      while ( v49 < (unsigned int)v46 )
      {
        v51 = *(_QWORD *)(v50 + 8 * v49);
        if ( (ToolModule_StringTool__IsNullOrEmpty(v51, 1, 0) & 1) == 0 )
        {
          v52 = a1[38];
          v55 = ToolModule_StringTool__ToFloat(v51, 0);
          if ( v52 == 0 )
            goto LABEL_255;
          v56 = *(_QWORD *)(v52 + 16);
          v57 = off_8D0E258;
          ++*(_DWORD *)(v52 + 28);
          if ( v56 == 0 )
            goto LABEL_255;
          v58 = *(int *)(v52 + 24);
          if ( (unsigned int)v58 >= *(_DWORD *)(v56 + 24) )
          {
            System_Collections_Generic_List_float___AddWithResize(
              v52,
              *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL),
              v55);
          }
          else
          {
            *(_DWORD *)(v52 + 24) = v58 + 1;
            *(_DWORD *)(v56 + 4 * v58 + 32) = LODWORD(v55);
          }
          if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE1928);
          v59 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v53, v54);
          if ( v59 == 0 )
            goto LABEL_255;
          IsBTest = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(v59, 0);
          if ( *(float *)&ScaledRadius != 1.0 && (IsBTest & 1) != 0 )
          {
            v61 = a1[38];
            if ( v61 == 0 )
              goto LABEL_255;
            Item = System_Collections_Generic_List_float___get_Item(a1[38], v48, qword_8D0E298);
            System_Collections_Generic_List_float___set_Item(
              v61,
              v48,
              qword_8D0E2A0,
              *(float *)&Item / *(float *)&ScaledRadius);
          }
          ++v48;
        }
        LODWORD(v46) = *(_DWORD *)(v47 + 24);
        if ( (__int64)++v49 >= (int)v46 )
          goto LABEL_68;
      }
LABEL_256:
      ((void (*)(void))unk_3C3D4D4)();
    }
  }
LABEL_68:
  *((_DWORD *)a1 + 73) = 0;
  *((_WORD *)a1 + 150) = 256;
  v63 = a1[16];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  v64 = v195;
  v65 = v42;
  if ( (UnityEngine_Object__op_Inequality(v63, 0, 0) & 1) != 0
    && !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v66 = a1[16];
    if ( v66 != 0 )
    {
      LODWORD(v9) = 1036831949;
      Pathfinding_FollowerEntity__set_positionSmoothing(v66, 0, v9);
      v67 = a1[16];
      if ( v67 != 0 )
      {
        Pathfinding_FollowerEntity__set_rotationSmoothing(v67, 0, v9);
        v68 = a1[16];
        if ( v68 != 0 )
        {
          v69 = *(_OWORD *)(v68 + 80);
          *(_OWORD *)&v217[44] = *(_OWORD *)(v68 + 92);
          *(_OWORD *)&v217[32] = v69;
          *(_OWORD *)&v217[64] = v69;
          *(_OWORD *)&v217[76] = *(_OWORD *)&v217[44];
          v70 = *(_QWORD *)(v68 + 64);
          v205 = *(_OWORD *)(v68 + 48);
          v206 = v70;
          v207 = 0;
          qmemcpy(v208, &v217[64], sizeof(v208));
          Pathfinding_FollowerEntity__set_movementSettings();
          v71 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
          if ( v71 != nullptr )
          {
            v72 = v71[25];
            if ( v72 != 0 )
            {
              v73 = *(_DWORD *)(v72 + 24);
              v74 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
              if ( v74 != nullptr )
              {
                v75 = v74[24];
                if ( v75 != 0 )
                {
                  v76 = a1[16];
                  if ( v76 != 0 )
                  {
                    v77 = *(_OWORD *)(v76 + 168);
                    v78 = *(_QWORD *)(v76 + 184);
                    v79 = *(_DWORD *)(v75 + 24);
                    *(_OWORD *)v217 = v77;
                    *(_QWORD *)&v217[16] = v78;
                    v215 = (unsigned int)v77 >> 8;
                    v216 = BYTE3(v77);
                    v214 = *(_OWORD *)&v217[8];
                    UseWebGLNavigation = Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0);
                    v81 = a1[16];
                    v203 = v215;
                    v204 = v216;
                    *(_OWORD *)v217 = v214;
                    if ( v81 != 0 )
                    {
                      v82 = v79 + v73;
                      v83 = 2.0;
                      if ( v82 > 79 )
                        v83 = 3.0;
                      v198 = 2;
                      if ( !UseWebGLNavigation )
                        v83 = 1.0;
                      v199 = v203;
                      v200 = v204;
                      v201 = v83;
                      v202 = *(_OWORD *)v217;
                      Pathfinding_FollowerEntity__set_autoRepath();
                      v84 = a1[16];
                      if ( v84 != 0 )
                      {
                        if ( (Pathfinding_FollowerEntity__get_enableLocalAvoidance(v84, 0) & 1) != 0 )
                        {
                          v85 = a1[16];
                          if ( v85 == 0 )
                            goto LABEL_255;
                          Pathfinding_FollowerEntity__get_rvoSettings(v217, v85, 0);
                          v212 = *(_OWORD *)&v217[20];
                          if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
                          {
                            v88 = 1.5;
                            if ( v82 <= 59 )
                            {
                              v89 = 6;
                            }
                            else
                            {
                              v88 = 2.0;
                              v89 = 4;
                            }
                            v213 = __PAIR64__(LODWORD(v88), v89);
                            v90 = 0.75;
                          }
                          else
                          {
                            if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
                              il2cpp_codegen_runtime_class_init(off_8CE1928);
                            v91 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v86, v87);
                            if ( v91 == 0 )
                              goto LABEL_255;
                            if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(v91, 0) & 1) != 0 )
                            {
                              v92 = 1056964608;
                              v93 = 40;
                            }
                            else
                            {
                              v92 = 1065353216;
                              v93 = 10;
                            }
                            v90 = 0.5;
                            v213 = __PAIR64__(v92, v93);
                          }
                          v94 = a1[16];
                          if ( (v195 & 1) != 0 )
                            v95 = 4;
                          else
                            v95 = 8;
                          *(_OWORD *)v217 = v212;
                          if ( v94 == 0 )
                            goto LABEL_255;
                          v196[0] = HIDWORD(v213);
                          *(float *)&v196[1] = v90;
                          v196[2] = v213;
                          v196[3] = v95;
                          v196[4] = v95;
                          v197 = *(_OWORD *)v217;
                          Pathfinding_FollowerEntity__set_rvoSettings(v94, v196, 0);
                        }
                        v96 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE36B0, 32);
                        if ( v96 != 0 )
                        {
                          v97 = *(_QWORD *)(v96 + 24);
                          v98 = v96;
                          for ( i = 0; i != 128; i += 4 )
                          {
                            if ( 4LL * (unsigned int)v97 == i )
                              goto LABEL_256;
                            v100 = v96 + i;
                            *(_DWORD *)(v100 + 32) = 0;
                          }
                          if ( (v195 & 1) != 0 )
                          {
                            if ( (unsigned int)v97 <= 1 )
                              goto LABEL_256;
                            *(_DWORD *)(v96 + 36) = 99999;
                            if ( (unsigned int)v97 <= 3 )
                              goto LABEL_256;
                            *(_DWORD *)(v96 + 44) = 99999;
                          }
                          else
                          {
                            if ( (unsigned int)v97 <= 2 )
                              goto LABEL_256;
                            *(_DWORD *)(v96 + 40) = 99999;
                            if ( (unsigned int)v97 <= 4 )
                              goto LABEL_256;
                            *(_DWORD *)(v96 + 48) = 99999;
                          }
                          v101 = a1[16];
                          if ( v101 != 0 )
                          {
                            *(_QWORD *)(Pathfinding_FollowerEntity__get_pathfindingSettings(v101, 0) + 16) = v98;
                            v64 = v195;
                            goto LABEL_120;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
LABEL_255:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_120:
  v102 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECB18);
  DataModule_RolePropertyTemp___ctor(v102, v65, v192, a5, 0);
  a1[8] = v102;
  *((_DWORD *)a1 + 41) = v192;
  a1[12] = v65;
  a1[22] = v191;
  *((_DWORD *)a1 + 50) = a7;
  *((_DWORD *)a1 + 51) = a8;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
  if ( byte_8FFD1AB == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    byte_8FFD1AB = 1;
  }
  result = (__int64)off_8CE5E20;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
    result = (__int64)off_8CE5E20;
  }
  if ( **(_BYTE **)(result + 184) == 0 )
    return result;
  v104 = a1[8];
  if ( v104 == 0 )
    goto LABEL_255;
  v105 = *(_DWORD *)(v104 + 36);
  v106 = *a1;
  *((_BYTE *)a1 + 32) = v64 & 1;
  *((_DWORD *)a1 + 38) = v105;
  (*(void (__fastcall **)(__int64 *, _QWORD))(v106 + 712))(a1, *(_QWORD *)(v106 + 720));
  if ( (v64 & 1) == 0 )
  {
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v114 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v107, v108);
    if ( v114 == 0 )
      goto LABEL_255;
    v115 = SDKModule_ABTestManager__get_NewArtifactsPlayIsBTest(v114, 0);
    if ( a7 != 4 && (v115 & 1) != 0 )
    {
      v116 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D123A0);
      if ( v116 == nullptr )
        goto LABEL_255;
      EquippedArtifactTraitPercent = GameModule_PropManager__GetEquippedArtifactTraitPercent(v116, a7, 1, 0);
      v118 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D123A0);
      if ( v118 == nullptr )
        goto LABEL_255;
      v119 = GameModule_PropManager__GetEquippedArtifactTraitPercent(v118, a7, 2, 0);
      if ( *(float *)&EquippedArtifactTraitPercent <= 0.0 )
      {
LABEL_233:
        if ( *(float *)&v119 <= 0.0 )
          goto LABEL_129;
        v181 = a1[8];
        if ( v181 == 0 )
          goto LABEL_255;
        v182 = (float)*(int *)(v181 + 28);
        v183 = *(float *)&v119 + 1.0;
        if ( byte_8FFD1A8 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD1A8 = 1;
        }
        v184 = v183 * v182;
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        *(double *)&v119 = v184;
        ((void (__fastcall *)(_BYTE *, long double))modf)(v217, v119);
        if ( v184 >= 0.0 )
        {
          if ( v185 == 0.5 )
          {
            v186 = *(double *)v217;
            v187 = 1.0;
LABEL_244:
            v188 = v186 + v187;
            if ( ((__int64)v186 & 1) != 0 )
              v186 = v188;
            goto LABEL_249;
          }
          v186 = floor(*(double *)&v119 + 0.5);
        }
        else
        {
          if ( v185 == -0.5 )
          {
            v186 = *(double *)v217;
            v187 = -1.0;
            goto LABEL_244;
          }
          v186 = ceil(*(double *)&v119 + -0.5);
        }
LABEL_249:
        v189 = (int)v186;
        v190 = a1[8];
        if ( v186 == INFINITY )
          v189 = 0x80000000;
        if ( v189 <= 1 )
          v189 = 1;
        if ( v190 == 0 )
          goto LABEL_255;
        *(_DWORD *)(v190 + 24) = v189;
        *(_DWORD *)(v190 + 28) = v189;
        goto LABEL_129;
      }
      v120 = a1[8];
      if ( v120 == 0 )
        goto LABEL_255;
      v121 = (float)*(int *)(v120 + 32);
      v122 = *(float *)&EquippedArtifactTraitPercent + 1.0;
      if ( byte_8FFD1A8 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD1A8 = 1;
      }
      v123 = v122 * v121;
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      *(double *)&EquippedArtifactTraitPercent = v123;
      ((void (__fastcall *)(_BYTE *, long double))modf)(v217, EquippedArtifactTraitPercent);
      if ( v123 >= 0.0 )
      {
        if ( v124 == 0.5 )
        {
          v125 = *(double *)v217;
          v126 = 1.0;
LABEL_186:
          v159 = v125 + v126;
          if ( ((__int64)v125 & 1) != 0 )
            v125 = v159;
          goto LABEL_227;
        }
        v125 = floor(*(double *)&EquippedArtifactTraitPercent + 0.5);
      }
      else
      {
        if ( v124 == -0.5 )
        {
          v125 = *(double *)v217;
          v126 = -1.0;
          goto LABEL_186;
        }
        v125 = ceil(*(double *)&EquippedArtifactTraitPercent + -0.5);
      }
LABEL_227:
      if ( v125 == INFINITY )
        v180 = 0x80000000;
      else
        v180 = (int)v125;
      if ( v180 <= 1 )
        v180 = 1;
      *(_DWORD *)(v120 + 32) = v180;
      goto LABEL_233;
    }
  }
LABEL_129:
  v109 = GameModule_PropAttrBattleApplier__ResolveBattlePropAttrSnapshot(v64 & 1, 0);
  GameModule_PropAttrBattleApplier__ApplyToRole(v109, a1[8], 0);
  Component_object = UnityEngine_Component__GetComponent_object_(a1, qword_8D25DD0);
  v111 = *((_DWORD *)a1 + 112);
  a1[15] = Component_object;
  *((_DWORD *)a1 + 58) = v111;
  v112 = UnityEngine_Component__get_transform(a1, 0);
  if ( v112 == 0 )
    goto LABEL_255;
  v113 = UnityEngine_Transform__Find(v112, qword_8D630E0, 0);
  if ( v113 == 0 )
    goto LABEL_255;
  a1[27] = UnityEngine_Component__get_gameObject(v113, 0);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    goto LABEL_132;
  v127 = a1[17];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v127, 0, 0) & 1) != 0 )
    goto LABEL_157;
  v128 = a1[17];
  if ( v128 == 0 )
    goto LABEL_255;
  v129 = UnityEngine_GameObject__get_gameObject(v128, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(v129, 0, 0) & 1) != 0 )
  {
LABEL_157:
    v130 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
    UnityEngine_GameObject___ctor(v130, qword_8D6BEF8, 0);
    a1[17] = v130;
    if ( v130 == 0 )
      goto LABEL_255;
    v131 = UnityEngine_GameObject__get_transform(v130, 0);
    v132 = UnityEngine_Component__get_transform(a1, 0);
    if ( v132 == 0 )
      goto LABEL_255;
    parent = UnityEngine_Transform__get_parent(v132, 0);
    if ( v131 == 0 )
      goto LABEL_255;
    UnityEngine_Transform__SetParent(v131, parent, 0);
  }
  else
  {
LABEL_132:
    if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
      goto LABEL_165;
  }
  v134 = a1[17];
  if ( v134 == 0 )
    goto LABEL_255;
  v135 = UnityEngine_GameObject__get_transform(v134, 0);
  v136 = UnityEngine_Component__get_transform(a1, 0);
  if ( v136 == 0 )
    goto LABEL_255;
  position = UnityEngine_Transform__get_position(v136, 0);
  if ( v135 == 0 )
    goto LABEL_255;
  UnityEngine_Transform__set_position(v135, 0, position, v138, v139);
LABEL_165:
  v140 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
  v141 = UnityEngine_Component__get_transform(a1, 0);
  if ( v141 == 0 )
    goto LABEL_255;
  v142 = UnityEngine_Transform__get_position(v141, 0);
  if ( v140 == nullptr )
    goto LABEL_255;
  ArchitectureTarget = GameModule_BattleGameSceneManager__GetArchitectureTarget(
                         (__int64)v140,
                         v64 & 1,
                         v142,
                         v143,
                         v144);
  v146 = *a1;
  a1[10] = ArchitectureTarget;
  (*(void (__fastcall **)(__int64 *, _QWORD, float))(v146 + 408))(a1, *(_QWORD *)(v146 + 416), 8.0);
  v147 = a1[10];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v147, 0, 0) & 1) != 0 )
  {
    if ( *v36 == 0 )
      goto LABEL_255;
    v148 = UnityEngine_Component__get_transform(*v36, 0);
    GameModule_RoleBehaviour__SetAiTarget(a1, v148);
  }
  v149 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12108);
  if ( v149 == nullptr )
    goto LABEL_255;
  GameModule_DailyBlessManager__RoleUnitNumberHandle(
    v149,
    v64 & 1,
    a1[8],
    *((unsigned int *)a1 + 50),
    *((unsigned int *)a1 + 51),
    0);
  v150 = GameModule_SubGameBuffManager__get_Instance(0);
  if ( v150 == 0 )
    goto LABEL_255;
  GameModule_SubGameBuffManager__ModifyRoleProperty(
    v150,
    v64 & 1,
    a1[8],
    *((unsigned int *)a1 + 50),
    *((unsigned int *)a1 + 51),
    *((unsigned int *)a1 + 41),
    0);
  if ( a1[40] != 0 )
  {
    if ( v65 == 0 )
      goto LABEL_255;
    if ( (System_String__IsNullOrEmpty(*(_QWORD *)(v65 + 160), 0) & 1) == 0 )
    {
      v152 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v65 + 160), 0);
      if ( *(float *)&v152 > 0.0 )
      {
        v153 = (__int64 *)a1[40];
        if ( v153 == nullptr )
          goto LABEL_255;
        v154 = *v153;
        v155 = v152;
        v156 = *(unsigned __int16 *)(*v153 + 302);
        if ( *(_WORD *)(*v153 + 302) != 0 )
        {
          v157 = (int *)(*(_QWORD *)(v154 + 176) + 8LL);
          while ( *((_QWORD *)v157 - 1) != qword_8CE8430 )
          {
            --v156;
            v157 += 4;
            if ( v156 == 0 )
              goto LABEL_183;
          }
          v158 = v154 + 16LL * *v157 + 312;
        }
        else
        {
LABEL_183:
          v158 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(a1[40], qword_8CE8430, 0);
        }
        (*(void (__fastcall **)(__int64 *, __int64, _QWORD, long double))v158)(v153, 1, *(_QWORD *)(v158 + 8), v155);
      }
    }
  }
  if ( a1[8] == 0 )
    goto LABEL_255;
  GameModule_RoleBehaviour__SetAiSPeed(a1, 0, v151);
  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) && (v160 = a1[8]) != 0 )
    v161 = (int *)(v160 + 40);
  else
    v161 = (int *)a1 + 111;
  v162 = *v161;
  *((_DWORD *)a1 + 59) = *v161;
  *((_DWORD *)a1 + 60) = v162;
  v211[0] = GameModule_RoleBehaviour__InitAnimationAsync(a1);
  Cysharp_Threading_Tasks_UniTaskVoid__Forget(v211, 0);
  *((_BYTE *)a1 + 328) = 1;
  GameModule_RoleBehaviour__SetAiCanMove(a1, 1, v163);
  if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
  {
    v164 = a1[16];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v164, 0, 0) & 1) != 0 )
    {
      v165 = a1[16];
      if ( v165 == 0 )
        goto LABEL_255;
      *((_BYTE *)a1 + 440) = Pathfinding_FollowerEntity__get_canMove(v165, 0) & 1;
    }
  }
  GameModule_WebGLNavigationManager__TryRegisterRole(a1, 0);
  v166 = (_DWORD *)a1[8];
  if ( v166 != nullptr )
  {
    *((_DWORD *)a1 + 176) = v166[7];
    *((_DWORD *)a1 + 177) = v166[11];
    *((_DWORD *)a1 + 61) = v166[16];
  }
  (*(void (__fastcall **)(__int64 *, _QWORD))(*a1 + 648))(a1, *(_QWORD *)(*a1 + 656));
  (*(void (__fastcall **)(__int64 *, _QWORD))(*a1 + 664))(a1, *(_QWORD *)(*a1 + 672));
  GameModule_RoleBehaviour__OnInitTalentTrigger(a1);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v169 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v167, v168);
  if ( v169 == 0 )
    goto LABEL_255;
  result = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(v169, 0);
  if ( (result & 1) == 0 )
    return result;
  v170 = (__int64 *)a1[40];
  if ( v170 == nullptr )
    return result;
  v171 = *((float *)a1 + 83);
  if ( v171 <= 0.0 )
  {
    v172 = *v170;
    v173 = *(unsigned __int16 *)(*v170 + 302);
    if ( *(_WORD *)(*v170 + 302) != 0 )
    {
      v174 = (_DWORD *)(*(_QWORD *)(v172 + 176) + 8LL);
      while ( *((_QWORD *)v174 - 1) != qword_8CE8430 )
      {
        --v173;
        v174 += 4;
        if ( v173 == 0 )
          goto LABEL_214;
      }
      v175 = v172 + 16LL * (*v174 + 5) + 312;
    }
    else
    {
LABEL_214:
      v175 = ((__int64 (__fastcall *)(__int64, __int64, __int64))unk_3C504A4)(a1[40], qword_8CE8430, 5);
    }
    v171 = (*(float (__fastcall **)(__int64 *, _QWORD))v175)(v170, *(_QWORD *)(v175 + 8));
    v170 = (__int64 *)a1[40];
    *((float *)a1 + 83) = v171;
    if ( v170 == nullptr )
      goto LABEL_255;
  }
  v176 = *v170;
  *(float *)&ScaledRadius = *(float *)&ScaledRadius * v171;
  v177 = *(unsigned __int16 *)(*v170 + 302);
  if ( *(_WORD *)(*v170 + 302) != 0 )
  {
    v178 = (int *)(*(_QWORD *)(v176 + 176) + 8LL);
    while ( *((_QWORD *)v178 - 1) != qword_8CE8430 )
    {
      --v177;
      v178 += 4;
      if ( v177 == 0 )
        goto LABEL_221;
    }
    v179 = v176 + 16LL * *v178 + 312;
  }
  else
  {
LABEL_221:
    v179 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v170, qword_8CE8430, 0);
  }
  return (*(__int64 (__fastcall **)(__int64 *, __int64, _QWORD, long double))v179)(
           v170,
           3,
           *(_QWORD *)(v179 + 8),
           ScaledRadius);
}
