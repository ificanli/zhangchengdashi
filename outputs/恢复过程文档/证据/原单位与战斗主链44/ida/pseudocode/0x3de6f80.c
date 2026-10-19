__int64 __fastcall GameModule_BattleGameManager__OnGUI(__int64 a1, __int64 a2)
{
  long double v2; // q8
  long double contentColor; // q9
  long double v4; // q10
  long double v5; // q12
  long double v6; // q13
  long double v7; // q14
  long double v8; // q15
  float v10; // s8
  float v11; // s8
  float v12; // s9
  float v13; // s9
  double v14; // d0
  double v15; // d0
  double v16; // d1
  double v17; // d1
  int v18; // w8
  __int64 result; // x0
  __int64 I; // x0
  __int64 v21; // x8
  __int64 v22; // x8
  __int64 v23; // x20
  __int64 v24; // x21
  long double dpi; // q0
  float v26; // s9
  long double v27; // q8
  __int64 v28; // x20
  __int64 Config; // x21
  __int64 v30; // x0
  __int64 v31; // x0
  int v32; // w22
  float v33; // s15
  long double v34; // q11
  float v35; // s9
  float v36; // s1
  float v37; // s2
  float v38; // s0
  float v39; // s3
  __int64 skin; // x0
  __int64 box; // x22
  __int64 v42; // x21
  float v43; // s10
  double v44; // d0
  double v45; // d0
  double v46; // d1
  double v47; // d1
  __int64 v48; // x1
  __int64 v49; // x0
  __int64 toggle; // x22
  __int64 v51; // x21
  float v52; // s12
  double v53; // d0
  double v54; // d0
  double v55; // d1
  double v56; // d1
  __int64 v57; // x1
  float v58; // s13
  double v59; // d0
  double v60; // d0
  double v61; // d1
  double v62; // d1
  unsigned int v63; // w22
  __int64 v64; // x23
  float v65; // s13
  double v66; // d0
  double v67; // d0
  double v68; // d1
  double v69; // d1
  unsigned int v70; // w22
  __int64 v71; // x23
  __int64 v72; // x0
  __int64 button; // x22
  __int64 v74; // x21
  double v75; // d0
  double v76; // d0
  double v77; // d1
  double v78; // d1
  __int64 v79; // x1
  __int64 v80; // x0
  __int64 label; // x22
  __int64 v82; // x21
  float v83; // s10
  double v84; // d0
  double v85; // d0
  double v86; // d1
  double v87; // d1
  __int64 v88; // x1
  __int64 v89; // x21
  __int64 v90; // x0
  __int64 v91; // x0
  __int64 v92; // x0
  __int64 v93; // x0
  __int64 v94; // x24
  float v95; // s5
  __int64 v96; // x22
  __int64 v97; // x23
  int v98; // w8
  long double v99; // q2
  long double v100; // q3
  long double v101; // q0
  long double v102; // q1
  __int64 v103; // x24
  __int64 normal; // x0
  float v105; // s10
  double v106; // d0
  double v107; // d0
  double v108; // d1
  double v109; // d1
  __int64 v110; // x1
  __int64 v111; // x0
  __int64 v112; // x25
  _QWORD *v113; // x0
  __int64 v114; // x8
  int v115; // w24
  char v116; // w0
  void *v117; // x8
  __int64 ObjectsOfType_object; // x0
  int v119; // w8
  __int64 v120; // x24
  unsigned int v121; // w22
  __int64 v122; // x8
  __int64 v123; // x25
  _QWORD *v124; // x0
  __int64 v125; // x0
  __int64 v126; // x24
  float v127; // s0
  float v128; // s10
  double v129; // d0
  double v130; // d0
  float v131; // s1
  __int64 v132; // x8
  float v133; // s0
  float v134; // s1
  __int64 v135; // x8
  __int64 v136; // x0
  __int64 v137; // x0
  float v138; // s0
  float v139; // s10
  double v140; // d0
  double v141; // d0
  float v142; // s1
  __int64 v143; // x8
  float v144; // s0
  float v145; // s1
  __int64 v146; // x8
  __int64 v147; // x0
  __int64 v148; // x0
  float v149; // s0
  float v150; // s9
  double v151; // d0
  double v152; // d0
  float v153; // s1
  __int64 v154; // x8
  float v155; // s0
  float v156; // s1
  __int64 v157; // x1
  __int64 v158; // x2
  __int64 *v159; // x8
  __int64 v160; // x24
  __int64 v161; // x1
  __int64 v162; // x2
  int v163; // w1
  _QWORD *Instance; // x24
  __int64 v165; // x25
  _QWORD *v166; // x0
  __int64 v167; // x26
  __int64 v168; // x27
  int v169; // w25
  __int64 v170; // x26
  _QWORD *v171; // x0
  __int64 v172; // x27
  __int64 v173; // x28
  int v174; // w26
  __int64 v175; // x27
  _QWORD *v176; // x0
  __int64 v177; // x28
  int v178; // w27
  __int64 v179; // x29
  __int64 v180; // x28
  _QWORD *v181; // x0
  __int64 v182; // x29
  __int64 v183; // x23
  void **v184; // x29
  __int64 v185; // x28
  __int64 v186; // x0
  __int64 v187; // x25
  __int64 v188; // x0
  __int64 v189; // x25
  __int64 v190; // x0
  __int64 v191; // x25
  __int64 v192; // x0
  __int64 v193; // x25
  __int64 v194; // x22
  __int64 v195; // x25
  long double v196; // q2
  __int64 v197; // x0
  __int64 v198; // x9
  __int64 v199; // x11
  __int64 v200; // x0
  __int64 v201; // x9
  __int64 v202; // x11
  float v203; // s10
  __int64 v204; // x0
  __int64 v205; // x0
  float v206; // s13
  const MethodInfo *v207; // x2
  long double v208; // q0
  void *v209; // x0
  __int64 v210; // x24
  __int64 *v211; // x8
  __int64 v212; // x24
  char v213; // w0
  int v214; // w8
  char IsEnable; // w24
  char v216; // w25
  char v217; // w0
  __int64 v218; // x0
  __int64 v219; // x1
  __int64 v220; // x24
  long double v221; // q2
  __int64 v222; // x0
  unsigned int v223; // w24
  __int64 v224; // x8
  __int64 v225; // x0
  __int64 v226; // x0
  __int64 Item; // x0
  __int64 v228; // x25
  __int64 *v229; // x8
  __int64 v230; // x26
  long double v231; // q1
  float v232; // s2
  float v233; // s14
  long double v234; // q3
  int v235; // w21
  __int64 DisplayName; // x0
  __int64 v237; // x26
  char v238; // w23
  _QWORD *v239; // x20
  __int64 v240; // x0
  __int64 v241; // x0
  __int64 v242; // x0
  __int64 v243; // x0
  __int64 v244; // x0
  _QWORD *v245; // x20
  __int64 v246; // x0
  __int64 v247; // x0
  __int64 v248; // x0
  __int64 v249; // x0
  __int64 v250; // x0
  __int64 v251; // x0
  __int64 v252; // x20
  long double v253; // q1
  __int64 v254; // x0
  __int64 v255; // x0
  __int64 v256; // x25
  int v257; // w1
  __int64 v258; // x26
  float v259; // [xsp+24h] [xbp-15Ch]
  float v260; // [xsp+28h] [xbp-158h]
  float v261; // [xsp+2Ch] [xbp-154h]
  __int64 v262; // [xsp+30h] [xbp-150h]
  float v263; // [xsp+38h] [xbp-148h]
  float v264; // [xsp+3Ch] [xbp-144h]
  __int64 v265; // [xsp+40h] [xbp-140h]
  float v266; // [xsp+48h] [xbp-138h]
  float v267; // [xsp+48h] [xbp-138h]
  float v268; // [xsp+4Ch] [xbp-134h]
  __int64 v269; // [xsp+50h] [xbp-130h]
  float v270; // [xsp+58h] [xbp-128h]
  int v271; // [xsp+5Ch] [xbp-124h] BYREF
  int v272; // [xsp+60h] [xbp-120h] BYREF
  int v273; // [xsp+64h] [xbp-11Ch] BYREF
  __int128 v274; // [xsp+68h] [xbp-118h] BYREF
  _BYTE *v275; // [xsp+78h] [xbp-108h]
  __int128 v276; // [xsp+80h] [xbp-100h] BYREF
  _BYTE *v277; // [xsp+90h] [xbp-F0h]
  __int128 v278; // [xsp+A0h] [xbp-E0h] BYREF
  _BYTE *v279; // [xsp+B0h] [xbp-D0h]
  __int128 v280; // [xsp+C0h] [xbp-C0h] BYREF
  _BYTE *v281; // [xsp+D0h] [xbp-B0h]

  if ( (byte_8FFD74B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2AAC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2AAE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B560);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02A60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02D88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01710);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01718);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02A68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02D90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02A70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01720);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB670);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7AB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7A60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D2C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08FD0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0D2C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D2D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34F50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEC440);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CED538);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D17838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45068);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45070);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45078);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D45080);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF1458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D864C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89410);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87E18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86F28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87D50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6BF70);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D85F40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87858);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D878D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D85F00);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D85F48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D502C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D523C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D864F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D878E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86E50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D864C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D878D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86498);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87D48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D523C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D878E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D85F50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D600A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86578);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86A58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C5B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86328);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87D60);
    byte_8FFD74B = 1;
  }
  v280 = 0u;
  v281 = nullptr;
  v278 = 0u;
  v279 = nullptr;
  v276 = 0u;
  v277 = nullptr;
  v10 = *(float *)(a1 + 312);
  ++*(_DWORD *)(a1 + 316);
  v11 = v10 + UnityEngine_Time__get_unscaledDeltaTime(0, a2);
  *(float *)(a1 + 312) = v11;
  if ( v11 >= 0.5 )
  {
    v12 = (float)*(int *)(a1 + 316);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v13 = v12 / v11;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&v2 = v13;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, v2);
    if ( v13 >= 0.0 )
    {
      if ( v14 == 0.5 )
      {
        v15 = *(double *)&v274;
        v16 = 1.0;
LABEL_13:
        v17 = v15 + v16;
        if ( ((__int64)v15 & 1) != 0 )
          v15 = v17;
        goto LABEL_18;
      }
      v15 = floor(*(double *)&v2 + 0.5);
    }
    else
    {
      if ( v14 == -0.5 )
      {
        v15 = *(double *)&v274;
        v16 = -1.0;
        goto LABEL_13;
      }
      v15 = ceil(*(double *)&v2 + -0.5);
    }
LABEL_18:
    v18 = (int)v15;
    if ( v15 == INFINITY )
      v18 = 0x80000000;
    *(_DWORD *)(a1 + 320) = v18;
    *(_QWORD *)(a1 + 312) = 0;
  }
  result = (__int64)off_8CE5558;
  if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5558);
    result = (__int64)off_8CE5558;
  }
  if ( **(_BYTE **)(result + 184) != 0 )
  {
    I = CommonGameModule_Debugger_DebuggerSystemUGUI__get_I(0);
    if ( I != 0 && (v21 = *(_QWORD *)(I + 72)) != 0 && (v22 = *(_QWORD *)(v21 + 64)) != 0 )
      v23 = *(_QWORD *)(v22 + 16);
    else
      v23 = 0;
    v24 = *(_QWORD *)(a1 + 296);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v24, v23, 0) & 1) != 0 )
    {
      *(_QWORD *)(a1 + 296) = v23;
      *(_QWORD *)(a1 + 256) = 0;
    }
    dpi = UnityEngine_Screen__get_dpi(0);
    v26 = *(float *)(a1 + 308);
    v27 = dpi;
    if ( byte_8FFD1AA == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A28);
      byte_8FFD1AA = 1;
    }
    v28 = **((_QWORD **)off_8CE4A28 + 23);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v28, 0, 0) & 1) == 0 )
      goto LABEL_48;
    if ( v28 == 0 )
      goto LABEL_454;
    Config = BattleFPSController__get_Config(v28, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(Config, 0, 0) & 1) != 0 )
    {
      v30 = BattleFPSController__get_Config(v28, 0);
      if ( v30 == 0 )
        goto LABEL_454;
      v31 = *(_QWORD *)(v30 + 48);
      if ( v31 == 0 )
        goto LABEL_454;
      System_Collections_Generic_List_object___GetEnumerator(&v274, v31, qword_8D0D2C0);
      v32 = 0;
      v280 = v274;
      v281 = v275;
      while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v280, qword_8D02A68) & 1) != 0 )
      {
        if ( v281 == nullptr )
          goto LABEL_498;
        v32 += (unsigned __int8)v281[24];
      }
      System_Collections_Generic_List_Enumerator_object___Dispose(&v280, qword_8D02A60);
    }
    else
    {
LABEL_48:
      v32 = 0;
    }
    v33 = v26 * fmaxf(*(float *)&v27 / 160.0, 1.0);
    *(float *)&v27 = v33 * 45.0;
    v34 = v27;
    v266 = v33 * 15.0;
    if ( *(_BYTE *)(a1 + 304) != 0 )
    {
      v34 = v27;
      if ( v32 >= 1 )
        *(float *)&v34 = *(float *)&v27 + (float)((float)(v266 * 3.0) + (float)(*(float *)&v27 * (float)(v32 + 4)));
    }
    if ( *(_QWORD *)(a1 + 256) != 0 )
    {
      v35 = *(float *)(a1 + 288);
      if ( byte_8FFD090 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA750);
        byte_8FFD090 = 1;
      }
      v36 = fabsf(v35);
      v37 = fabsf(v33);
      if ( v36 <= v37 )
        v36 = v37;
      v38 = v36 * 0.000001;
      v39 = **((float **)off_8CEA750 + 23);
      if ( (float)(v36 * 0.000001) <= (float)(v39 * 8.0) )
        v38 = v39 * 8.0;
      if ( vabds_f32(v33, v35) < v38 )
      {
LABEL_181:
        v94 = *(_QWORD *)(a1 + 256);
        v95 = v33 * 15.0;
        v269 = *(_QWORD *)(a1 + 264);
        *(float *)&v7 = *(float *)&v27 * 0.6;
        v96 = *(_QWORD *)(a1 + 272);
        v97 = *(_QWORD *)(a1 + 280);
        v259 = *(float *)&v27 * 0.7;
        *(float *)&v6 = v33 * 380.0;
        *(float *)&contentColor = (float)(v95 + v95)
                                + (float)(*(float *)&v27
                                        + (float)((float)(*(float *)&v27
                                                        + (float)((float)(*(float *)&v27 * 0.7)
                                                                + (float)((float)(*(float *)&v27 * 0.7)
                                                                        + (float)(*(float *)&v27
                                                                                + (float)((float)((float)(*(float *)&v27 * 0.5)
                                                                                                * 3.0)
                                                                                        + (float)((float)((float)(*(float *)&v27 * 12.0) + (float)(v266 * 8.0))
                                                                                                + (float)((float)(*(float *)&v27 * 0.6) * 3.0)))))))
                                                + *(float *)&v34));
        v268 = *(float *)&v27 * 0.5;
        v260 = v95 + v95;
        if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE7A60);
        UnityEngine_GUI__Box(qword_8D6BF70, v94, 0, 20.0, 20.0, v6, contentColor);
        v98 = *(_DWORD *)(a1 + 320);
        LODWORD(v99) = 1015054465;
        LODWORD(v100) = 1064037356;
        LODWORD(v101) = 0;
        LODWORD(v102) = 1.0;
        if ( v98 <= 14 )
        {
          *(float *)&v99 = 0.0;
          *(float *)&v100 = 0.0;
        }
        if ( v98 <= 29 )
          *(float *)&contentColor = 1.0;
        else
          *(float *)&contentColor = 0.0;
        if ( v98 <= 29 )
          *(float *)&v4 = *(float *)&v100;
        else
          *(float *)&v4 = 1.0;
        if ( v98 <= 29 )
          *(float *)&v34 = *(float *)&v99;
        else
          *(float *)&v34 = 0.0;
        v103 = ((__int64 (__fastcall *)(__int64, long double, long double, long double, long double))unk_3C3D4C4)(
                 qword_8CE7AB0,
                 v101,
                 v102,
                 v99,
                 v100);
        v265 = v97;
        UnityEngine_GUIStyle___ctor(v103, v97, 0);
        if ( v103 == 0 )
          goto LABEL_454;
        normal = UnityEngine_GUIStyle__get_normal(v103, 0);
        if ( normal == 0 )
          goto LABEL_454;
        UnityEngine_GUIStyleState__set_textColor(normal, 0, contentColor, v4, v34, 1.0);
        if ( byte_8FFD1A8 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD1A8 = 1;
        }
        v105 = v33 * 24.0;
        v262 = v96;
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        *(double *)&contentColor = v105;
        ((void (__fastcall *)(__int128 *, long double))modf)(&v274, contentColor);
        if ( v105 >= 0.0 )
        {
          if ( v106 != 0.5 )
          {
            v107 = floor(*(double *)&contentColor + 0.5);
            goto LABEL_210;
          }
          v107 = *(double *)&v274;
          v108 = 1.0;
        }
        else
        {
          if ( v106 != -0.5 )
          {
            v107 = ceil(*(double *)&contentColor + -0.5);
            goto LABEL_210;
          }
          v107 = *(double *)&v274;
          v108 = -1.0;
        }
        v109 = v107 + v108;
        if ( ((__int64)v107 & 1) != 0 )
          v107 = v109;
LABEL_210:
        if ( v107 == INFINITY )
          v110 = 0x80000000LL;
        else
          v110 = (unsigned int)(int)v107;
        v264 = v33;
        *(float *)&contentColor = *(float *)&v27 + 20.0;
        UnityEngine_GUIStyle__set_fontSize(v103, v110, 0);
        *(float *)&v5 = v266 + 20.0;
        LODWORD(v274) = *(_DWORD *)(a1 + 320);
        *(float *)&v4 = *(float *)&v6 - v260;
        v111 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(qword_8CE95C0, &v274);
        v112 = System_String__Format(qword_8D600A0, v111, 0);
        if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE7A60);
        v270 = *(float *)&v6 - v260;
        UnityEngine_GUI__Label(v112, v103, 0, v5, contentColor, v4, v27);
        v113 = off_8CE5558;
        *(float *)&v8 = *(float *)&v27 + *(float *)&contentColor;
        if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CE5558);
          v113 = off_8CE5558;
        }
        v114 = v113[23];
        v115 = *(unsigned __int8 *)(v114 + 6);
        v116 = UnityEngine_GUI__Toggle(
                 *(unsigned __int8 *)(v114 + 6),
                 qword_8D864C8,
                 v269,
                 0,
                 v5,
                 v8,
                 *(float *)&v4,
                 v27);
        v117 = off_8CE5558;
        *(_BYTE *)(*((_QWORD *)off_8CE5558 + 23) + 6LL) = v116 & 1;
        if ( v115 != (v116 & 1) )
        {
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          ObjectsOfType_object = UnityEngine_Object__FindObjectsOfType_object_(qword_8D34F50);
          if ( ObjectsOfType_object == 0 )
            goto LABEL_454;
          v119 = *(_DWORD *)(ObjectsOfType_object + 24);
          v120 = ObjectsOfType_object;
          if ( v119 >= 1 )
          {
            v121 = 0;
            while ( v121 < v119 )
            {
              v122 = v120 + 8LL * (int)v121;
              v123 = *(_QWORD *)(v122 + 32);
              if ( v123 == 0 )
                goto LABEL_454;
              if ( (unsigned int)UnityEngine_Canvas__get_renderMode(*(_QWORD *)(v122 + 32), 0) == 0
                || (unsigned int)UnityEngine_Canvas__get_renderMode(v123, 0) == 1 )
              {
                v124 = off_8CE5558;
                if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
                {
                  il2cpp_codegen_runtime_class_init(off_8CE5558);
                  v124 = off_8CE5558;
                }
                UnityEngine_Behaviour__set_enabled(v123, *(unsigned __int8 *)(v124[23] + 6LL) == 0, 0);
              }
              v119 = *(_DWORD *)(v120 + 24);
              if ( (int)++v121 >= v119 )
                goto LABEL_231;
            }
            goto LABEL_497;
          }
LABEL_231:
          v117 = off_8CE5558;
        }
        v261 = v264 * 8.0;
        v263 = *(float *)&v27 + (float)(v264 * 8.0);
        if ( *((_DWORD *)v117 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(v117);
          v117 = off_8CE5558;
        }
        *(float *)&contentColor = v263 + *(float *)&v8;
        v273 = *(_DWORD *)(*((_QWORD *)v117 + 23) + 12LL);
        v125 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CED538, &v273);
        v126 = System_String__Format(qword_8D86578, v125, 0);
        if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE7A60);
        *(float *)&v8 = *(float *)&v6 - v260;
        UnityEngine_GUI__Label(v126, v97, 0, v5, contentColor, v8, v7);
        *(float *)&contentColor = *(float *)&v7 + *(float *)&contentColor;
        v127 = UnityEngine_GUI__HorizontalSlider(
                 0,
                 v5,
                 contentColor,
                 v8,
                 v268,
                 *(float *)(*((_QWORD *)off_8CE5558 + 23) + 12LL),
                 0.5,
                 10.0);
        v128 = v127 * 10.0;
        *(float *)(*((_QWORD *)off_8CE5558 + 23) + 12LL) = v127;
        ((void (__fastcall *)(__int128 *, double))modf)(&v274, (float)(v127 * 10.0));
        if ( v128 >= 0.0 )
        {
          if ( v129 != 0.5 )
          {
            v133 = floorf(v128 + 0.5);
            goto LABEL_246;
          }
          v130 = *(double *)&v274;
          v131 = 1.0;
        }
        else
        {
          if ( v129 != -0.5 )
          {
            v133 = ceilf(v128 + -0.5);
            goto LABEL_246;
          }
          v130 = *(double *)&v274;
          v131 = -1.0;
        }
        v132 = (__int64)v130;
        v133 = v130;
        v134 = v133 + v131;
        if ( (v132 & 1) != 0 )
          v133 = v134;
LABEL_246:
        v135 = *((_QWORD *)off_8CE5558 + 23);
        *(float *)&contentColor = *(float *)&v7 + *(float *)&contentColor;
        *(float *)(v135 + 12) = v133 / 10.0;
        v272 = *(_DWORD *)(v135 + 16);
        v136 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CED538, &v272);
        v137 = System_String__Format(qword_8D86328, v136, 0);
        *(float *)&v34 = *(float *)&v6 - v260;
        UnityEngine_GUI__Label(v137, v97, 0, v5, contentColor, v34, v7);
        *(float *)&contentColor = *(float *)&v7 + *(float *)&contentColor;
        LODWORD(v8) = 1036831949;
        v138 = UnityEngine_GUI__HorizontalSlider(
                 0,
                 v5,
                 contentColor,
                 v34,
                 v268,
                 *(float *)(*((_QWORD *)off_8CE5558 + 23) + 16LL),
                 0.1,
                 2.0);
        v139 = v138 * 10.0;
        *(float *)(*((_QWORD *)off_8CE5558 + 23) + 16LL) = v138;
        ((void (__fastcall *)(__int128 *, double))modf)(&v274, (float)(v138 * 10.0));
        if ( v139 >= 0.0 )
        {
          if ( v140 != 0.5 )
          {
            v144 = floorf(v139 + 0.5);
            goto LABEL_256;
          }
          v141 = *(double *)&v274;
          v142 = 1.0;
        }
        else
        {
          if ( v140 != -0.5 )
          {
            v144 = ceilf(v139 + -0.5);
            goto LABEL_256;
          }
          v141 = *(double *)&v274;
          v142 = -1.0;
        }
        v143 = (__int64)v141;
        v144 = v141;
        v145 = v144 + v142;
        if ( (v143 & 1) != 0 )
          v144 = v145;
LABEL_256:
        v146 = *((_QWORD *)off_8CE5558 + 23);
        *(float *)&contentColor = *(float *)&v7 + *(float *)&contentColor;
        *(float *)(v146 + 16) = v144 / 10.0;
        v271 = *(_DWORD *)(v146 + 20);
        v147 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CED538, &v271);
        v148 = System_String__Format(qword_8D87D60, v147, 0);
        *(float *)&v34 = *(float *)&v6 - v260;
        UnityEngine_GUI__Label(v148, v97, 0, v5, contentColor, v34, v7);
        *(float *)&v7 = *(float *)&v7 + *(float *)&contentColor;
        v149 = UnityEngine_GUI__HorizontalSlider(
                 0,
                 v5,
                 v7,
                 v34,
                 v268,
                 *(float *)(*((_QWORD *)off_8CE5558 + 23) + 20LL),
                 0.1,
                 2.0);
        v150 = v149 * 10.0;
        *(float *)(*((_QWORD *)off_8CE5558 + 23) + 20LL) = v149;
        ((void (__fastcall *)(__int128 *, double))modf)(&v274, (float)(v149 * 10.0));
        if ( v150 >= 0.0 )
        {
          if ( v151 != 0.5 )
          {
            v155 = floorf(v150 + 0.5);
            goto LABEL_266;
          }
          v152 = *(double *)&v274;
          v153 = 1.0;
        }
        else
        {
          if ( v151 != -0.5 )
          {
            v155 = ceilf(v150 + -0.5);
            goto LABEL_266;
          }
          v152 = *(double *)&v274;
          v153 = -1.0;
        }
        v154 = (__int64)v152;
        v155 = v152;
        v156 = v155 + v153;
        if ( (v154 & 1) != 0 )
          v155 = v156;
LABEL_266:
        *(float *)(*((_QWORD *)off_8CE5558 + 23) + 20LL) = v155 / 10.0;
        UnityEngine_Time__set_timeScale(0);
        *(float *)&v7 = (float)(*(float *)&v27 * 0.8) + *(float *)&v7;
        if ( GameModule_BattleGameManager__get_IsGamePaused(a1, v157, v158) )
          v159 = (__int64 *)&qword_8D85F48;
        else
          v159 = (__int64 *)&unk_8D85F00;
        v160 = *v159;
        if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE7A60);
        if ( (UnityEngine_GUI__Button(v160, v262, 0, v5, v7, v270, v27) & 1) != 0 )
        {
          v163 = !GameModule_BattleGameManager__get_IsGamePaused(a1, v161, v162);
          if ( *(unsigned __int8 *)(a1 + 218) != v163 )
          {
            *(_BYTE *)(a1 + 218) = v163;
            GameModule_BattleGameManager__ApplyAnimationPauseToAllRoles(a1, v163);
          }
        }
        Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
        {
          if ( Instance == nullptr )
            goto LABEL_454;
          v165 = Instance[25];
          v166 = off_8CF1458;
          if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CF1458);
            v166 = off_8CF1458;
          }
          v167 = *(_QWORD *)(v166[23] + 88LL);
          if ( v167 == 0 )
          {
            if ( *((_DWORD *)v166 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(v166);
              v166 = off_8CF1458;
            }
            v168 = *(_QWORD *)v166[23];
            v167 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB670);
            System_Func_object__bool____ctor(v167, v168, qword_8D45068, 0);
            *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 88LL) = v167;
          }
          v169 = System_Linq_Enumerable__Count_object_(v165, v167, qword_8D2AAE0);
        }
        else
        {
          v169 = 0;
        }
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
        {
          if ( Instance == nullptr )
            goto LABEL_454;
          v170 = Instance[24];
          v171 = off_8CF1458;
          if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CF1458);
            v171 = off_8CF1458;
          }
          v172 = *(_QWORD *)(v171[23] + 96LL);
          if ( v172 == 0 )
          {
            if ( *((_DWORD *)v171 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(v171);
              v171 = off_8CF1458;
            }
            v173 = *(_QWORD *)v171[23];
            v172 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB670);
            System_Func_object__bool____ctor(v172, v173, qword_8D45070, 0);
            *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 96LL) = v172;
          }
          v174 = System_Linq_Enumerable__Count_object_(v170, v172, qword_8D2AAE0);
        }
        else
        {
          v174 = 0;
        }
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
        {
          if ( Instance == nullptr )
            goto LABEL_454;
          v175 = Instance[28];
          v176 = off_8CF1458;
          if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CF1458);
            v176 = off_8CF1458;
          }
          v177 = *(_QWORD *)(v176[23] + 104LL);
          if ( v177 == 0 )
          {
            if ( *((_DWORD *)v176 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(v176);
              v176 = off_8CF1458;
            }
            v179 = *(_QWORD *)v176[23];
            v177 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB178);
            System_Func_object__bool____ctor(v177, v179, qword_8D45078, 0);
            *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 104LL) = v177;
          }
          v178 = System_Linq_Enumerable__Count_object_(v175, v177, qword_8D2AAC8);
        }
        else
        {
          v178 = 0;
        }
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
        {
          if ( Instance == nullptr )
            goto LABEL_454;
          v180 = Instance[29];
          v181 = off_8CF1458;
          if ( *((_DWORD *)off_8CF1458 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CF1458);
            v181 = off_8CF1458;
          }
          v182 = *(_QWORD *)(v181[23] + 112LL);
          if ( v182 == 0 )
          {
            if ( *((_DWORD *)v181 + 56) == 0 )
            {
              il2cpp_codegen_runtime_class_init(v181);
              v181 = off_8CF1458;
            }
            v183 = *(_QWORD *)v181[23];
            v182 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB178);
            System_Func_object__bool____ctor(v182, v183, qword_8D45080, 0);
            *(_QWORD *)(*((_QWORD *)off_8CF1458 + 23) + 112LL) = v182;
          }
          v184 = (void **)(unsigned int)System_Linq_Enumerable__Count_object_(v180, v182, qword_8D2AAC8);
        }
        else
        {
          v184 = nullptr;
        }
        v185 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 4);
        LODWORD(v274) = v169;
        v186 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(qword_8CE95C0, &v274);
        if ( v185 == 0 )
          goto LABEL_454;
        v187 = v186;
        if ( v186 == 0
          || ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v186, *(_QWORD *)(*(_QWORD *)v185 + 64LL)) != 0 )
        {
          if ( *(_DWORD *)(v185 + 24) == 0 )
            goto LABEL_497;
          *(_QWORD *)(v185 + 32) = v187;
          v273 = v178;
          v188 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v273);
          v189 = v188;
          if ( v188 == 0
            || ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v188, *(_QWORD *)(*(_QWORD *)v185 + 64LL)) != 0 )
          {
            if ( *(_DWORD *)(v185 + 24) <= 1u )
              goto LABEL_497;
            *(_QWORD *)(v185 + 40) = v189;
            v272 = v174;
            v190 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v272);
            v191 = v190;
            if ( v190 == 0
              || ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v190, *(_QWORD *)(*(_QWORD *)v185 + 64LL)) != 0 )
            {
              if ( *(_DWORD *)(v185 + 24) <= 2u )
                goto LABEL_497;
              *(_QWORD *)(v185 + 48) = v191;
              v271 = (int)v184;
              v192 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v271);
              v193 = v192;
              if ( v192 == 0
                || ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v192, *(_QWORD *)(*(_QWORD *)v185 + 64LL)) != 0 )
              {
                if ( *(_DWORD *)(v185 + 24) > 3u )
                {
                  *(_QWORD *)(v185 + 56) = v193;
                  v184 = (void **)&off_8CEB3E0;
                  *(float *)&contentColor = v263 + *(float *)&v7;
                  v194 = v262;
                  v195 = sub_750AAD4(qword_8D86E50, v185, 0);
                  if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE7A60);
                  *(float *)&v196 = *(float *)&v6 - v260;
                  UnityEngine_GUI__Label(v195, v265, 0, v5, contentColor, v196, v27);
                  *(float *)&v7 = *(float *)&v27 + *(float *)&contentColor;
                  *(float *)&v6 = (float)(*(float *)&v6 + (float)(v266 * -3.0)) * 0.5;
                  if ( (UnityEngine_GUI__Button(qword_8D878E0, v262, 0, v5, v7, *(float *)&v6, v27) & 1) != 0 )
                  {
                    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
                    if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
                    {
                      if ( Instance == nullptr )
                        goto LABEL_454;
                      v197 = System_Linq_Enumerable__ToList_object_(Instance[29], qword_8D2B400);
                      if ( v197 == 0 )
                        goto LABEL_454;
                      System_Collections_Generic_List_object___GetEnumerator(&v274, v197, qword_8D08FD0);
                      v278 = v274;
                      v279 = v275;
                      while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v278, qword_8D01718) & 1) != 0 )
                      {
                        if ( v279 == nullptr )
                          il2cpp_codegen_raise_null_reference_exception();
                        if ( v279[33] == 0 )
                        {
                          v198 = *(_QWORD *)v279;
                          v199 = *((unsigned __int8 *)off_8CE6838 + 304);
                          if ( *(unsigned __int8 *)(*(_QWORD *)v279 + 304LL) < (unsigned int)v199
                            || *(_UNKNOWN **)(*(_QWORD *)(v198 + 200) + 8 * v199 - 8) != off_8CE6838 )
                          {
                            (*(void (__fastcall **)(_BYTE *, __int64, __int64, __int64, _QWORD, _QWORD, _QWORD, __int64, _QWORD, _QWORD))(v198 + 376))(
                              v279,
                              999999,
                              qword_8D7C5B0,
                              1,
                              0,
                              0,
                              0,
                              4,
                              0,
                              *(_QWORD *)(v198 + 384));
                          }
                        }
                      }
                      System_Collections_Generic_List_Enumerator_object___Dispose(&v278, qword_8D01710);
                      v194 = v262;
                    }
                  }
                  *(float *)&v8 = (float)(v260 + 20.0) + *(float *)&v6;
                  if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE7A60);
                  if ( (UnityEngine_GUI__Button(qword_8D878D0, v194, 0, v8, v7, *(float *)&v6, v27) & 1) != 0 )
                  {
                    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
                      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
                    if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
                    {
                      if ( Instance == nullptr )
                        goto LABEL_454;
                      v200 = System_Linq_Enumerable__ToList_object_(Instance[28], qword_8D2B400);
                      if ( v200 == 0 )
                        goto LABEL_454;
                      System_Collections_Generic_List_object___GetEnumerator(&v274, v200, qword_8D08FD0);
                      v278 = v274;
                      v279 = v275;
                      while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v278, qword_8D01718) & 1) != 0 )
                      {
                        if ( v279 == nullptr )
                          il2cpp_codegen_raise_null_reference_exception();
                        if ( v279[33] == 0 )
                        {
                          v201 = *(_QWORD *)v279;
                          v202 = *((unsigned __int8 *)off_8CE6838 + 304);
                          if ( *(unsigned __int8 *)(*(_QWORD *)v279 + 304LL) < (unsigned int)v202
                            || *(_UNKNOWN **)(*(_QWORD *)(v201 + 200) + 8 * v202 - 8) != off_8CE6838 )
                          {
                            (*(void (__fastcall **)(_BYTE *, __int64, __int64, __int64, _QWORD, _QWORD, _QWORD, __int64, _QWORD, _QWORD))(v201 + 376))(
                              v279,
                              999999,
                              qword_8D7C5B0,
                              1,
                              0,
                              0,
                              0,
                              4,
                              0,
                              *(_QWORD *)(v201 + 384));
                          }
                        }
                      }
                      System_Collections_Generic_List_Enumerator_object___Dispose(&v278, qword_8D01710);
                      v194 = v262;
                    }
                  }
                  goto LABEL_368;
                }
LABEL_497:
                ((void (*)(void))unk_3C3D4D4)();
LABEL_498:
                il2cpp_codegen_raise_null_reference_exception();
              }
            }
          }
        }
        v254 = ((__int64 (*)(void))unk_3C3D4F0)();
        v255 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v254, 0);
        v256 = v255;
        if ( v257 == 1 )
        {
          v258 = *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v255);
          ((void (*)(void))__cxa_end_catch)();
          System_Collections_Generic_List_Enumerator_object___Dispose(&v278, qword_8D01710);
          v194 = v262;
          if ( v258 == 0 )
          {
LABEL_368:
            v203 = *(float *)&v27 + (float)(v264 * 5.0);
            *(float *)&v7 = v203 + *(float *)&v7;
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D878E8, v194, 0, v5, v7, *(float *)&v6, v27) & 1) != 0 )
            {
              if ( *((_DWORD *)*v184 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(*v184);
              if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
              {
                if ( Instance == nullptr )
                  goto LABEL_454;
                v204 = System_Linq_Enumerable__ToList_object_(Instance[24], qword_8D2B560);
                if ( v204 == 0 )
                  goto LABEL_454;
                System_Collections_Generic_List_object___GetEnumerator(&v274, v204, qword_8D0DDA0);
                v276 = v274;
                v277 = v275;
                while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v276, qword_8D02D90) & 1) != 0 )
                {
                  if ( v277 == nullptr )
                    il2cpp_codegen_raise_null_reference_exception();
                  if ( v277[33] == 0 )
                    GameModule_RoleBehaviour__ImmediateDead(v277, 0);
                }
                System_Collections_Generic_List_Enumerator_object___Dispose(&v276, qword_8D02D88);
              }
            }
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D878D8, v194, 0, v8, v7, *(float *)&v6, v27) & 1) != 0 )
            {
              if ( *((_DWORD *)*v184 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(*v184);
              if ( (UnityEngine_Object__op_Inequality(Instance, 0, 0) & 1) != 0 )
              {
                if ( Instance == nullptr )
                  goto LABEL_454;
                v205 = System_Linq_Enumerable__ToList_object_(Instance[25], qword_8D2B560);
                if ( v205 == 0 )
                  goto LABEL_454;
                System_Collections_Generic_List_object___GetEnumerator(&v274, v205, qword_8D0DDA0);
                v276 = v274;
                v277 = v275;
                while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v276, qword_8D02D90) & 1) != 0 )
                {
                  if ( v277 == nullptr )
                    il2cpp_codegen_raise_null_reference_exception();
                  if ( v277[33] == 0 )
                    GameModule_RoleBehaviour__ImmediateDead(v277, 0);
                }
                System_Collections_Generic_List_Enumerator_object___Dispose(&v276, qword_8D02D88);
              }
            }
            *(float *)&v8 = v203 + *(float *)&v7;
            v206 = (float)(v270 - v261) * 0.5;
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D523C8, v194, 0, v5, v8, v206, v27) & 1) != 0 )
              GameModule_BattleGameManager__ChangeCoin((void *)a1, 1000, v207);
            *(float *)&contentColor = v261 + (float)(*(float *)&v5 + v206);
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D523C0, v194, 0, contentColor, v8, v206, v27) & 1) != 0 )
            {
              v209 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FA8);
              if ( v209 != nullptr )
                GameModule_AIBehaviourManager__ChangeCoin(v209, 1000, 0);
            }
            *(float *)&v208 = *(float *)&v27 + (float)(v264 * 10.0);
            if ( *((_DWORD *)*v184 + 56) == 0 )
            {
              v34 = v208;
              il2cpp_codegen_runtime_class_init(*v184);
              LODWORD(v208) = LODWORD(v34);
            }
            v267 = *(float *)&v208;
            *(float *)&v8 = *(float *)&v208 + *(float *)&v8;
            if ( (UnityEngine_Object__op_Inequality(v28, 0, 0) & 1) != 0 )
            {
              if ( v28 == 0 )
                goto LABEL_454;
              v210 = BattleFPSController__get_Config(v28, 0);
              if ( *((_DWORD *)*v184 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(*v184);
              if ( (UnityEngine_Object__op_Inequality(v210, 0, 0) & 1) != 0 )
              {
                if ( *(_BYTE *)(a1 + 304) != 0 )
                  v211 = (__int64 *)&unk_8D85F50;
                else
                  v211 = (__int64 *)&qword_8D85F40;
                v212 = *v211;
                if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                  il2cpp_codegen_runtime_class_init(off_8CE7A60);
                v213 = UnityEngine_GUI__Button(v212, v194, 0, v5, v8, v270, v27);
                v214 = *(unsigned __int8 *)(a1 + 304);
                if ( (v213 & 1) != 0 )
                {
                  v214 ^= 1u;
                  *(_BYTE *)(a1 + 304) = v214;
                }
                *(float *)&v8 = v203 + *(float *)&v8;
                if ( v214 != 0 )
                {
                  IsEnable = BattleFPSController__get_IsEnable(v28, 0);
                  v216 = BattleFPSController__get_IsEnable(v28, 0);
                  if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE7A60);
                  v217 = UnityEngine_GUI__Toggle(v216 & 1, qword_8D86A58, v269, 0, v5, v8, v270, v27);
                  BattleFPSController__set_IsEnable(v28, v217 & 1, 0);
                  if ( (IsEnable & 1) != (BattleFPSController__get_IsEnable(v28, 0) & 1)
                    && (BattleFPSController__get_IsEnable(v28, 0) & 1) == 0 )
                  {
                    BattleFPSController__StopMonitoring(v28, 0);
                  }
                  if ( (int)BattleFPSController__get_CurrentDegradeCount(v28, 0) <= 0 )
                  {
                    v219 = qword_8D87858;
                  }
                  else
                  {
                    LODWORD(v274) = BattleFPSController__get_CurrentDegradeCount(v28, 0);
                    v218 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(qword_8CE95C0, &v274);
                    v219 = System_String__Format(qword_8D86F28, v218, 0);
                  }
                  *(float *)&contentColor = *(float *)&v27 + *(float *)&v8;
                  v220 = sub_74FE7A4(qword_8D87E18, v219, 0);
                  if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE7A60);
                  *(float *)&v221 = v270;
                  UnityEngine_GUI__Label(v220, v265, 0, v5, contentColor, v221, v27);
                  v222 = BattleFPSController__get_Config(v28, 0);
                  if ( v222 == 0 )
                    goto LABEL_454;
                  v223 = 0;
                  *(float *)&v8 = v203 + *(float *)&contentColor;
                  while ( 1 )
                  {
                    v224 = *(_QWORD *)(v222 + 48);
                    if ( v224 == 0 )
                      goto LABEL_454;
                    if ( (signed int)v223 >= *(_DWORD *)(v224 + 24) )
                      break;
                    v225 = BattleFPSController__get_Config(v28, 0);
                    if ( v225 != 0 )
                    {
                      v226 = *(_QWORD *)(v225 + 48);
                      if ( v226 != 0 )
                      {
                        Item = System_Collections_Generic_List_object___get_Item(v226, v223, qword_8D0D2D0);
                        if ( Item != 0 )
                        {
                          v228 = Item;
                          if ( *(_BYTE *)(Item + 24) != 0 )
                          {
                            if ( *(_BYTE *)(Item + 25) != 0 )
                              v229 = (__int64 *)&unk_8D502C0;
                            else
                              v229 = &qword_8D4ECC0;
                            v230 = *v229;
                            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                              il2cpp_codegen_runtime_class_init(off_8CE7A60);
                            contentColor = UnityEngine_GUI__get_contentColor(0);
                            v4 = v231;
                            v233 = v232;
                            v34 = v234;
                            if ( *(_BYTE *)(v228 + 25) != 0 )
                            {
                              if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                                il2cpp_codegen_runtime_class_init(off_8CE7A60);
                              UnityEngine_GUI__set_contentColor(0, 1.0, 0.0, 0.0, 1.0);
                              v235 = *(unsigned __int8 *)(v228 + 25);
                            }
                            else
                            {
                              v235 = 0;
                            }
                            DisplayName = PerformanceFeature__get_DisplayName(v228, 0);
                            v237 = sub_750A330(qword_8D864C0, DisplayName, v230, 0);
                            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                              il2cpp_codegen_runtime_class_init(off_8CE7A60);
                            v238 = UnityEngine_GUI__Toggle(v235 != 0, v237, v269, 0, v5, v8, v270, v27);
                            UnityEngine_GUI__set_contentColor(
                              0,
                              *(float *)&contentColor,
                              *(float *)&v4,
                              v233,
                              *(float *)&v34);
                            if ( v235 != (v238 & 1) )
                              BattleFPSController__ManualToggleFeature(v28, v228);
                            *(float *)&v8 = *(float *)&v27 + *(float *)&v8;
                          }
                          ++v223;
                          v222 = BattleFPSController__get_Config(v28, 0);
                          if ( v222 != 0 )
                            continue;
                        }
                      }
                    }
                    goto LABEL_454;
                  }
                  *(float *)&contentColor = v261 + *(float *)&v8;
                  if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                    il2cpp_codegen_runtime_class_init(off_8CE7A60);
                  v194 = v262;
                  if ( (UnityEngine_GUI__Button(qword_8D86498, v262, 0, v5, contentColor, v270, v27) & 1) != 0 )
                  {
                    BattleFPSController__StopMonitoring(v28, 0);
                    BattleFPSController__StartMonitoring(v28, 0);
                  }
                  *(float *)&v8 = v267 + *(float *)&contentColor;
                  *(float *)&contentColor = v261 + (float)(*(float *)&v5 + v206);
                }
              }
            }
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D87D50, v194, 0, v5, v8, v206, v27) & 1) != 0 )
            {
              v239 = off_8D17838;
              v240 = *((_QWORD *)off_8D17838 + 4);
              if ( (*(_BYTE *)(v240 + 309) & 1) == 0 )
                v240 = ((__int64 (*)(void))unk_3C503A0)();
              v241 = *(_QWORD *)(*(_QWORD *)(v240 + 192) + 16LL);
              if ( (*(_BYTE *)(v241 + 309) & 1) == 0 )
                v241 = ((__int64 (*)(void))unk_3C503A0)();
              if ( *(_DWORD *)(v241 + 224) == 0 )
                il2cpp_codegen_runtime_class_init((void *)v241);
              v242 = v239[4];
              if ( (*(_BYTE *)(v242 + 309) & 1) == 0 )
                v242 = ((__int64 (*)(void))unk_3C503A0)();
              v243 = *(_QWORD *)(*(_QWORD *)(v242 + 192) + 16LL);
              if ( (*(_BYTE *)(v243 + 309) & 1) == 0 )
                v243 = ((__int64 (*)(void))unk_3C503A0)();
              v244 = **(_QWORD **)(v243 + 184);
              if ( v244 == 0 )
                goto LABEL_454;
              CheatControl__CheatBattleWin(v244, 0);
            }
            if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE7A60);
            if ( (UnityEngine_GUI__Button(qword_8D87D48, v194, 0, contentColor, v8, v206, v27) & 1) == 0 )
              goto LABEL_490;
            v245 = off_8D17838;
            v246 = *((_QWORD *)off_8D17838 + 4);
            if ( (*(_BYTE *)(v246 + 309) & 1) == 0 )
              v246 = ((__int64 (*)(void))unk_3C503A0)();
            v247 = *(_QWORD *)(*(_QWORD *)(v246 + 192) + 16LL);
            if ( (*(_BYTE *)(v247 + 309) & 1) == 0 )
              v247 = ((__int64 (*)(void))unk_3C503A0)();
            if ( *(_DWORD *)(v247 + 224) == 0 )
              il2cpp_codegen_runtime_class_init((void *)v247);
            v248 = v245[4];
            if ( (*(_BYTE *)(v248 + 309) & 1) == 0 )
              v248 = ((__int64 (*)(void))unk_3C503A0)();
            v249 = *(_QWORD *)(*(_QWORD *)(v248 + 192) + 16LL);
            if ( (*(_BYTE *)(v249 + 309) & 1) == 0 )
              v249 = ((__int64 (*)(void))unk_3C503A0)();
            v250 = **(_QWORD **)(v249 + 184);
            if ( v250 != 0 )
            {
              CheatControl__CheatBattleLose(v250, 0);
LABEL_490:
              LODWORD(v274) = *(_DWORD *)(a1 + 308);
              *(float *)&contentColor = v263 + *(float *)&v8;
              v251 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(qword_8CED538, &v274);
              v252 = System_String__Format(qword_8D89410, v251, 0);
              if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE7A60);
              *(float *)&v34 = v270;
              *(float *)&v4 = *(float *)&v27 * 0.7;
              UnityEngine_GUI__Label(v252, v265, 0, v5, contentColor, v34, v4);
              *(float *)&contentColor = v259 + *(float *)&contentColor;
              *(float *)(a1 + 308) = UnityEngine_GUI__HorizontalSlider(
                                       0,
                                       v5,
                                       contentColor,
                                       v34,
                                       v268,
                                       *(float *)(a1 + 308),
                                       0.3,
                                       1.5);
              *(float *)&v253 = v259 + *(float *)&contentColor;
              result = UnityEngine_GUI__Button(qword_8D864F0, v194, 0, v5, v253, v270, v27);
              if ( (result & 1) != 0 )
              {
                result = (__int64)off_8CE5558;
                if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
                {
                  il2cpp_codegen_runtime_class_init(off_8CE5558);
                  result = (__int64)off_8CE5558;
                }
                **(_BYTE **)(result + 184) = 0;
              }
              return result;
            }
LABEL_454:
            il2cpp_codegen_raise_null_reference_exception();
          }
          sub_3C38CF8(v258);
          System_Collections_Generic_List_Enumerator_object___Dispose(&v278, qword_8D01710);
        }
        else
        {
          System_Collections_Generic_List_Enumerator_object___Dispose(&v278, qword_8D01710);
        }
        sub_3CE73C4(v256);
      }
    }
    *(float *)(a1 + 288) = v33;
    if ( *((_DWORD *)off_8CE7A60 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7A60);
    skin = UnityEngine_GUI__get_skin(0);
    if ( skin == 0 )
      goto LABEL_454;
    box = UnityEngine_GUISkin__get_box(skin, 0);
    v42 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AB0);
    UnityEngine_GUIStyle___ctor(v42, box, 0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v43 = v33 * 22.0;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&contentColor = v43;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, contentColor);
    if ( v43 >= 0.0 )
    {
      if ( v44 != 0.5 )
      {
        v45 = floor(*(double *)&contentColor + 0.5);
        goto LABEL_78;
      }
      v45 = *(double *)&v274;
      v46 = 1.0;
    }
    else
    {
      if ( v44 != -0.5 )
      {
        v45 = ceil(*(double *)&contentColor + -0.5);
        goto LABEL_78;
      }
      v45 = *(double *)&v274;
      v46 = -1.0;
    }
    v47 = v45 + v46;
    if ( ((__int64)v45 & 1) != 0 )
      v45 = v47;
LABEL_78:
    if ( v42 == 0 )
      goto LABEL_454;
    v48 = v45 == INFINITY ? 0x80000000LL : (unsigned int)(int)v45;
    UnityEngine_GUIStyle__set_fontSize(v42, v48, 0);
    *(_QWORD *)(a1 + 256) = v42;
    v49 = UnityEngine_GUI__get_skin(0);
    if ( v49 == 0 )
      goto LABEL_454;
    toggle = UnityEngine_GUISkin__get_toggle(v49, 0);
    v51 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AB0);
    UnityEngine_GUIStyle___ctor(v51, toggle, 0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v52 = v33 * 20.0;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&contentColor = v52;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, contentColor);
    if ( v52 >= 0.0 )
    {
      if ( v53 != 0.5 )
      {
        v54 = floor(*(double *)&contentColor + 0.5);
        goto LABEL_97;
      }
      v54 = *(double *)&v274;
      v55 = 1.0;
    }
    else
    {
      if ( v53 != -0.5 )
      {
        v54 = ceil(*(double *)&contentColor + -0.5);
        goto LABEL_97;
      }
      v54 = *(double *)&v274;
      v55 = -1.0;
    }
    v56 = v54 + v55;
    if ( ((__int64)v54 & 1) != 0 )
      v54 = v56;
LABEL_97:
    if ( v51 == 0 )
      goto LABEL_454;
    if ( v54 == INFINITY )
      v57 = 0x80000000LL;
    else
      v57 = (unsigned int)(int)v54;
    UnityEngine_GUIStyle__set_fontSize(v51, v57, 0);
    UnityEngine_GUIStyle__set_fixedHeight(v51, 0, v33 * 40.0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v58 = v33 * 35.0;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&v4 = v58;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, v4);
    if ( v58 >= 0.0 )
    {
      if ( v59 != 0.5 )
      {
        v60 = floor(*(double *)&v4 + 0.5);
        goto LABEL_115;
      }
      v60 = *(double *)&v274;
      v61 = 1.0;
    }
    else
    {
      if ( v59 != -0.5 )
      {
        v60 = ceil(*(double *)&v4 + -0.5);
        goto LABEL_115;
      }
      v60 = *(double *)&v274;
      v61 = -1.0;
    }
    v62 = v60 + v61;
    if ( ((__int64)v60 & 1) != 0 )
      v60 = v62;
LABEL_115:
    if ( v60 == INFINITY )
      v63 = 0x80000000;
    else
      v63 = (int)v60;
    v64 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEC440);
    UnityEngine_RectOffset___ctor(v64, v63, 0, 0, 0, 0);
    UnityEngine_GUIStyle__set_padding(v51, v64, 0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v65 = v33 * -5.0;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&v4 = v65;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, v4);
    if ( v65 >= 0.0 )
    {
      if ( v66 != 0.5 )
      {
        v67 = floor(*(double *)&v4 + 0.5);
        goto LABEL_132;
      }
      v67 = *(double *)&v274;
      v68 = 1.0;
    }
    else
    {
      if ( v66 != -0.5 )
      {
        v67 = ceil(*(double *)&v4 + -0.5);
        goto LABEL_132;
      }
      v67 = *(double *)&v274;
      v68 = -1.0;
    }
    v69 = v67 + v68;
    if ( ((__int64)v67 & 1) != 0 )
      v67 = v69;
LABEL_132:
    if ( v67 == INFINITY )
      v70 = 0x80000000;
    else
      v70 = (int)v67;
    v71 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEC440);
    UnityEngine_RectOffset___ctor(v71, 0, 0, v70, 0, 0);
    UnityEngine_GUIStyle__set_overflow(v51, v71, 0);
    *(_QWORD *)(a1 + 264) = v51;
    v72 = UnityEngine_GUI__get_skin(0);
    if ( v72 == 0 )
      goto LABEL_454;
    button = UnityEngine_GUISkin__get_button(v72, 0);
    v74 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AB0);
    UnityEngine_GUIStyle___ctor(v74, button, 0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, contentColor);
    if ( v52 >= 0.0 )
    {
      if ( v75 != 0.5 )
      {
        v76 = floor(*(double *)&contentColor + 0.5);
        goto LABEL_150;
      }
      v76 = *(double *)&v274;
      v77 = 1.0;
    }
    else
    {
      if ( v75 != -0.5 )
      {
        v76 = ceil(*(double *)&contentColor + -0.5);
        goto LABEL_150;
      }
      v76 = *(double *)&v274;
      v77 = -1.0;
    }
    v78 = v76 + v77;
    if ( ((__int64)v76 & 1) != 0 )
      v76 = v78;
LABEL_150:
    if ( v74 == 0 )
      goto LABEL_454;
    v79 = v76 == INFINITY ? 0x80000000LL : (unsigned int)(int)v76;
    UnityEngine_GUIStyle__set_fontSize(v74, v79, 0);
    *(_QWORD *)(a1 + 272) = v74;
    v80 = UnityEngine_GUI__get_skin(0);
    if ( v80 == 0 )
      goto LABEL_454;
    label = UnityEngine_GUISkin__get_label(v80, 0);
    v82 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AB0);
    UnityEngine_GUIStyle___ctor(v82, label, 0);
    if ( byte_8FFD1A8 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD1A8 = 1;
    }
    v83 = v33 * 18.0;
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    *(double *)&contentColor = v83;
    ((void (__fastcall *)(__int128 *, long double))modf)(&v274, contentColor);
    if ( v83 >= 0.0 )
    {
      if ( v84 != 0.5 )
      {
        v85 = floor(*(double *)&contentColor + 0.5);
        goto LABEL_169;
      }
      v85 = *(double *)&v274;
      v86 = 1.0;
    }
    else
    {
      if ( v84 != -0.5 )
      {
        v85 = ceil(*(double *)&contentColor + -0.5);
        goto LABEL_169;
      }
      v85 = *(double *)&v274;
      v86 = -1.0;
    }
    v87 = v85 + v86;
    if ( ((__int64)v85 & 1) != 0 )
      v85 = v87;
LABEL_169:
    if ( v82 == 0 )
      goto LABEL_454;
    if ( v85 == INFINITY )
      v88 = 0x80000000LL;
    else
      v88 = (unsigned int)(int)v85;
    UnityEngine_GUIStyle__set_fontSize(v82, v88, 0);
    *(_QWORD *)(a1 + 280) = v82;
    v89 = *(_QWORD *)(a1 + 296);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v89, 0, 0) & 1) != 0 )
    {
      v90 = *(_QWORD *)(a1 + 256);
      if ( v90 == 0 )
        goto LABEL_454;
      UnityEngine_GUIStyle__set_font(v90, *(_QWORD *)(a1 + 296), 0);
      v91 = *(_QWORD *)(a1 + 264);
      if ( v91 == 0 )
        goto LABEL_454;
      UnityEngine_GUIStyle__set_font(v91, *(_QWORD *)(a1 + 296), 0);
      v92 = *(_QWORD *)(a1 + 272);
      if ( v92 == 0 )
        goto LABEL_454;
      UnityEngine_GUIStyle__set_font(v92, *(_QWORD *)(a1 + 296), 0);
      v93 = *(_QWORD *)(a1 + 280);
      if ( v93 == 0 )
        goto LABEL_454;
      UnityEngine_GUIStyle__set_font(v93, *(_QWORD *)(a1 + 296), 0);
    }
    goto LABEL_181;
  }
  return result;
}
