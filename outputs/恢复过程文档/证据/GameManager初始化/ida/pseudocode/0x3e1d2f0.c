void GameModule_GameManager__Init_d__9__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 v4; // x20
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x2
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x2
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x2
  __int64 v19; // x0
  __int64 v20; // x1
  __int64 v21; // x2
  __int64 v22; // x0
  __int64 v23; // x1
  __int64 v24; // x2
  __int64 v25; // x0
  __int64 v26; // x1
  __int64 v27; // x2
  __int64 v28; // x0
  __int64 v29; // x1
  __int64 v30; // x2
  __int64 v31; // x0
  __int64 v32; // x1
  __int64 v33; // x2
  __int64 v34; // x0
  __int64 v35; // x1
  __int64 v36; // x2
  __int64 v37; // x0
  __int64 v38; // x1
  __int64 v39; // x2
  __int64 v40; // x0
  __int64 v41; // x1
  __int64 v42; // x2
  __int64 v43; // x0
  __int64 v44; // x1
  __int64 v45; // x2
  __int64 v46; // x0
  __int64 v47; // x1
  __int64 v48; // x2
  __int64 v49; // x0
  __int64 v50; // x1
  __int64 v51; // x2
  __int64 v52; // x0
  __int64 v53; // x1
  __int64 v54; // x2
  __int64 v55; // x0
  __int64 v56; // x1
  __int64 v57; // x2
  __int64 v58; // x0
  __int64 v59; // x1
  __int64 v60; // x2
  __int64 v61; // x0
  __int64 v62; // x1
  __int64 v63; // x2
  __int64 v64; // x0
  __int64 v65; // x0
  __int64 v66; // x21
  void *v67; // x0
  char IsBTest; // w0
  __int64 v69; // x21
  void *v70; // x0
  char v71; // w0
  void *v72; // x0
  const MethodInfo *v73; // x1
  __int64 v74; // x8
  __int64 v75; // x8
  void *v76; // x0
  const MethodInfo *v77; // x1
  __int64 v78; // x1
  __int64 v79; // x2
  __int64 v80; // x8
  __int64 v81; // x9
  __int64 v82; // x8
  __int64 Timer; // x0
  __int64 v84; // x21
  __int64 v85; // x1
  __int64 v86; // x8
  __int64 v87; // x8
  __int64 v88; // x0
  __int64 v89; // x21
  __int64 v90; // x1
  __int64 v91; // x0
  __int64 v92; // x21
  __int64 v93; // x1
  __int64 v94; // x0
  __int64 v95; // x8
  __int64 v96; // x0
  void *v97; // x0
  __int64 v98; // x1
  __int64 v99; // x2
  __int64 v100; // x1
  __int64 v101; // x2
  __int64 v102; // x21
  __int64 v103; // x0
  __int64 v104; // x0
  __int64 v105; // x0
  __int64 v106; // x0
  __int64 v107; // x21
  const MethodInfo *v108; // x22
  __int64 v109; // x21
  __int64 v110; // x8
  unsigned int v111; // w22
  __int64 v112; // x9
  int *v113; // x10
  __int64 v114; // x0
  __int64 v115; // x21
  __int64 v116; // x8
  unsigned int v117; // w22
  __int64 v118; // x9
  _DWORD *v119; // x10
  __int64 v120; // x0
  __int64 Instance; // x0
  __int64 v122; // x1
  __int64 v123; // x2
  __int64 v124; // x0
  __int64 v125; // x1
  __int64 v126; // x2
  __int64 v127; // x0
  __int64 v128; // x1
  __int64 v129; // x2
  __int64 v130; // x0
  __int64 v131; // x0
  __int64 v132; // x1
  __int64 v133; // x2
  __int64 v134; // x0
  __int64 v135; // x21
  const MethodInfo *v136; // x22
  __int64 v137; // x21
  __int64 v138; // x8
  unsigned int v139; // w22
  __int64 v140; // x9
  int *v141; // x10
  __int64 v142; // x0
  __int64 v143; // x21
  __int64 v144; // x8
  unsigned int v145; // w22
  __int64 v146; // x9
  _DWORD *v147; // x10
  __int64 v148; // x0
  __int64 v149; // x0
  __int64 v150; // x1
  __int64 v151; // x2
  __int64 v152; // x0
  __int64 v153; // x0
  __int64 v154; // x1
  __int64 v155; // x2
  __int64 v156; // x0
  __int64 v157; // x1
  __int64 v158; // x2
  __int64 v159; // x0
  __int64 v160; // x1
  __int64 v161; // x2
  __int64 v162; // x0
  __int64 v163; // x1
  __int64 v164; // x2
  __int64 v165; // x0
  __int64 v166; // x1
  __int64 v167; // x2
  __int64 v168; // x0
  __int64 v169; // x1
  __int64 v170; // x2
  __int64 v171; // x0
  __int64 v172; // x1
  __int64 v173; // x2
  __int64 v174; // x0
  __int64 v175; // x1
  __int64 v176; // x2
  __int64 v177; // x0
  __int64 v178; // x1
  __int64 v179; // x2
  __int64 v180; // x0
  __int64 v181; // x1
  __int64 v182; // x2
  __int64 v183; // x0
  __int64 v184; // x1
  __int64 v185; // x2
  __int64 v186; // x21
  __int64 v187; // x22
  void *v188; // x0
  __int64 v189; // x1
  __int64 v190; // x2
  __int64 v191; // x21
  __int64 v192; // x22
  void *v193; // x0
  __int64 v194; // x1
  __int64 v195; // x2
  __int64 v196; // x21
  __int64 v197; // x22
  __int64 v198; // x21
  __int64 v199; // x22
  __int64 v200; // x1
  __int64 v201; // x2
  __int64 v202; // x0
  __int64 v203; // x21
  __int64 v204; // x22
  __int64 v205; // x1
  __int64 v206; // x2
  __int64 v207; // x21
  __int64 v208; // x22
  __int64 v209; // x1
  __int64 v210; // x2
  __int64 v211; // x21
  __int64 v212; // x22
  __int64 v213; // x1
  __int64 v214; // x2
  __int64 v215; // x21
  __int64 v216; // x22
  __int64 v217; // x1
  __int64 v218; // x2
  __int64 v219; // x8
  __int64 v220; // x0
  _QWORD *v221; // x21
  __int64 v222; // x0
  __int64 v223; // x0
  __int64 v224; // x0
  __int64 v225; // x0
  __int64 v226; // x0
  const MethodInfo *v227; // x1
  void *v228; // x1
  __int64 *v229; // x19
  __int64 v230; // x8
  __int64 v231; // x9
  _DWORD *v232; // x10
  __int64 v233; // x0
  __int64 v234; // x8
  __int64 v235; // x8
  __int64 v236; // x0
  __int64 v237; // x8
  __int64 v238; // x8
  __int64 v239; // x24
  __int64 v240; // x1
  __int64 v241; // x2
  __int64 v242; // x21
  __int64 v243; // x0
  __int64 v244; // x22
  __int64 v245; // x23
  __int64 RemainingTime; // x24
  _QWORD **v247; // x0
  __int64 v248; // x0
  __int64 v249; // x8
  __int64 v250; // x8
  __int64 v251; // x0
  __int64 v252; // x0
  __int64 v253; // x0
  __int64 v254; // x0
  __int64 v255; // x8
  __int64 v256; // x21
  __int64 v257; // x2
  __int64 v258; // x21
  __int64 v259; // x0
  __int64 v260; // x0
  _QWORD v261[3]; // [xsp+0h] [xbp-A0h] BYREF
  __int64 v262; // [xsp+18h] [xbp-88h] BYREF
  _QWORD v263[2]; // [xsp+20h] [xbp-80h] BYREF
  __int64 v264; // [xsp+38h] [xbp-68h] BYREF

  if ( (byte_8FFD8AD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB3B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB2B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D1E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D1F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D1F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D220);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12028);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12498);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12368);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D121F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12328);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12308);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D120F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12108);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12288);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12038);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12518);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12278);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12550);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12478);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12430);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12318);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11F98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12410);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12540);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12078);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D17868);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE590);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61ED0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D58ED8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D892F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78318);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5DA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88018);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5A640);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5B3E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D775F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D61EC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53800);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57448);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D58EE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D64308);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D690B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D605A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86220);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D681C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D698A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D619C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D782F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5BF68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66350);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78300);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57E58);
    byte_8FFD8AD = 1;
  }
  v264 = 0;
  *(_OWORD *)v263 = 0u;
  v4 = *((_QWORD *)self + 3);
  if ( *(_DWORD *)self == 0 )
  {
    *(_OWORD *)v263 = *((_OWORD *)self + 2);
    *((_QWORD *)self + 4) = 0;
    *((_QWORD *)self + 5) = 0;
    *(_DWORD *)self = -1;
LABEL_115:
    if ( byte_8FFD1AF == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AF = 1;
    }
    v115 = v263[0];
    if ( v263[0] != 0 )
    {
      v116 = *(_QWORD *)v263[0];
      v117 = LOWORD(v263[1]);
      v118 = *(unsigned __int16 *)(*(_QWORD *)v263[0] + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v263[0] + 302LL) != 0 )
      {
        v119 = (_DWORD *)(*(_QWORD *)(v116 + 176) + 8LL);
        while ( *((_QWORD *)v119 - 1) != qword_8CE91C8 )
        {
          --v118;
          v119 += 4;
          if ( v118 == 0 )
            goto LABEL_122;
        }
        v120 = v116 + 16LL * (*v119 + 2) + 312;
      }
      else
      {
LABEL_122:
        v120 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v263[0], qword_8CE91C8, 2);
      }
      (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v120)(v115, v117, *(_QWORD *)(v120 + 8));
    }
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D121F0, method, v2);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Instance + 376LL))(
      Instance,
      *(_QWORD *)(*(_QWORD *)Instance + 384LL));
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v4 + 33) == 0 )
    {
      v124 = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, v122, v123);
      if ( v124 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      UIFramework_UIManager__GetPanel(v261, v124, qword_8D57E58, 0);
      v127 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v125, v126);
      if ( v127 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_MetaGameManager__ShowMetaSwitchPanel(v127, 2, 0);
      v130 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v128, v129);
      if ( v130 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      EventModule_EventManager__TriggerEvent(v130, qword_8D64308, 0, 0);
    }
    v131 = ToolModule_ManagerBase_object___get_Instance(qword_8D124C8, v122, v123);
    if ( v131 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UIFramework_UIManager__GetPanel(v261, v131, qword_8D57448, 0);
    v134 = ToolModule_ManagerBase_object___get_Instance(qword_8D120F8, v132, v133);
    if ( v134 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v135 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v134 + 376LL))(
             v134,
             *(_QWORD *)(*(_QWORD *)v134 + 384LL));
    v136 = method;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    v263[0] = v135;
    v263[1] = v136;
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
    v137 = v263[0];
    if ( v263[0] != 0 )
    {
      v138 = *(_QWORD *)v263[0];
      v139 = LOWORD(v263[1]);
      v140 = *(unsigned __int16 *)(*(_QWORD *)v263[0] + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v263[0] + 302LL) != 0 )
      {
        v141 = (int *)(*(_QWORD *)(v138 + 176) + 8LL);
        while ( *((_QWORD *)v141 - 1) != qword_8CE91C8 )
        {
          --v140;
          v141 += 4;
          if ( v140 == 0 )
            goto LABEL_147;
        }
        v142 = v138 + 16LL * *v141 + 312;
      }
      else
      {
LABEL_147:
        v142 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v263[0], qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v142)(v137, v139, *(_QWORD *)(v142 + 8)) == 0 )
      {
        *(_DWORD *)self = 1;
        *((_OWORD *)self + 2) = *(_OWORD *)v263;
        ((void (__fastcall *)(char *, _QWORD *, void *, __int64))unk_3E2F3C4)(
          (char *)self + 8,
          v263,
          self,
          qword_8D1F458);
        return;
      }
    }
    goto LABEL_150;
  }
  if ( *(_DWORD *)self != 1 )
  {
    if ( (UnityEngine_PlayerPrefs__HasKey(qword_8D775F8, 0) & 1) == 0 )
      UnityEngine_PlayerPrefs__SetInt(qword_8D775F8, 0, 0);
    v7 = ToolModule_ManagerBase_object___get_Instance(qword_8D12250, v5, v6);
    if ( v7 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v7 + 376LL))(v7, *(_QWORD *)(*(_QWORD *)v7 + 384LL));
    v10 = ToolModule_ManagerBase_object___get_Instance(qword_8D12278, v8, v9);
    if ( v10 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v10 + 376LL))(v10, *(_QWORD *)(*(_QWORD *)v10 + 384LL));
    v13 = ToolModule_ManagerBase_object___get_Instance(qword_8D12288, v11, v12);
    if ( v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v13 + 376LL))(v13, *(_QWORD *)(*(_QWORD *)v13 + 384LL));
    v16 = ToolModule_ManagerBase_object___get_Instance(qword_8D12038, v14, v15);
    if ( v16 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v16 + 376LL))(v16, *(_QWORD *)(*(_QWORD *)v16 + 384LL));
    v19 = ToolModule_ManagerBase_object___get_Instance(qword_8D12078, v17, v18);
    if ( v19 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v19 + 376LL))(v19, *(_QWORD *)(*(_QWORD *)v19 + 384LL));
    v22 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v20, v21);
    if ( v22 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v22 + 376LL))(v22, *(_QWORD *)(*(_QWORD *)v22 + 384LL));
    v25 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FE8, v23, v24);
    if ( v25 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v25 + 376LL))(v25, *(_QWORD *)(*(_QWORD *)v25 + 384LL));
    v28 = ToolModule_ManagerBase_object___get_Instance(qword_8D12488, v26, v27);
    if ( v28 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v28 + 376LL))(v28, *(_QWORD *)(*(_QWORD *)v28 + 384LL));
    v31 = ToolModule_ManagerBase_object___get_Instance(qword_8D12498, v29, v30);
    if ( v31 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v31 + 376LL))(v31, *(_QWORD *)(*(_QWORD *)v31 + 384LL));
    v34 = ToolModule_ManagerBase_object___get_Instance(qword_8D12368, v32, v33);
    if ( v34 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v34 + 376LL))(v34, *(_QWORD *)(*(_QWORD *)v34 + 384LL));
    v37 = ToolModule_ManagerBase_object___get_Instance(qword_8D12378, v35, v36);
    if ( v37 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v37 + 376LL))(v37, *(_QWORD *)(*(_QWORD *)v37 + 384LL));
    v40 = ToolModule_ManagerBase_object___get_Instance(qword_8D12508, v38, v39);
    if ( v40 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v40 + 376LL))(v40, *(_QWORD *)(*(_QWORD *)v40 + 384LL));
    v43 = ToolModule_ManagerBase_object___get_Instance(qword_8D12518, v41, v42);
    if ( v43 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v43 + 376LL))(v43, *(_QWORD *)(*(_QWORD *)v43 + 384LL));
    v46 = ToolModule_ManagerBase_object___get_Instance(qword_8D122D8, v44, v45);
    if ( v46 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v46 + 376LL))(v46, *(_QWORD *)(*(_QWORD *)v46 + 384LL));
    v49 = ToolModule_ManagerBase_object___get_Instance(qword_8D12430, v47, v48);
    if ( v49 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v49 + 376LL))(v49, *(_QWORD *)(*(_QWORD *)v49 + 384LL));
    v52 = ToolModule_ManagerBase_object___get_Instance(qword_8D122F8, v50, v51);
    if ( v52 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v52 + 376LL))(v52, *(_QWORD *)(*(_QWORD *)v52 + 384LL));
    v55 = ToolModule_ManagerBase_object___get_Instance(qword_8D12108, v53, v54);
    if ( v55 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v55 + 376LL))(v55, *(_QWORD *)(*(_QWORD *)v55 + 384LL));
    v58 = ToolModule_ManagerBase_object___get_Instance(qword_8D12460, v56, v57);
    if ( v58 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v58 + 376LL))(v58, *(_QWORD *)(*(_QWORD *)v58 + 384LL));
    v61 = ToolModule_ManagerBase_object___get_Instance(qword_8D12400, v59, v60);
    if ( v61 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v61 + 376LL))(v61, *(_QWORD *)(*(_QWORD *)v61 + 384LL));
    v64 = ToolModule_ManagerBase_object___get_Instance(qword_8D12190, v62, v63);
    if ( v64 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v64 + 376LL))(v64, *(_QWORD *)(*(_QWORD *)v64 + 384LL));
    v65 = UnityEngine_GameObject__Find(qword_8D58ED8, 0);
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v4 + 48) = v65;
    *(_QWORD *)(v4 + 56) = UnityEngine_GameObject__Find(qword_8D58EE0, 0);
    v66 = *(_QWORD *)(v4 + 48);
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v67 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
    if ( v67 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    IsBTest = SDKModule_ABTestManager__get_WeeklyClashImprove02IsBTest(v67, 0);
    if ( v66 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_GameObject__SetActive(v66, (IsBTest & 1) == 0, 0);
    v69 = *(_QWORD *)(v4 + 56);
    v70 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
    if ( v70 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v71 = SDKModule_ABTestManager__get_WeeklyClashImprove02IsBTest(v70, 0);
    if ( v69 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v72 = (void *)UnityEngine_GameObject__SetActive(v69, v71 & 1, 0);
    v74 = **((_QWORD **)off_8CD9228 + 23);
    if ( v74 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v75 = *(_QWORD *)(v74 + 48);
    if ( v75 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_BYTE *)(v4 + 33) = *(_BYTE *)(v75 + 16);
    GameModule_GameManager__RegisterOnTimeToZero(v72, v73);
    GameModule_GameManager__RegisterOnTimeToMonDayZero(v76, v77);
    v80 = **((_QWORD **)off_8CD9250 + 23);
    if ( v80 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v81 = *(_QWORD *)(v80 + 48);
    if ( v81 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v81 + 131) != 0 )
    {
      *(_BYTE *)(v81 + 131) = 0;
      DbtSaveDataManagerBase_object__object___Save(v80, qword_8CFB3A8);
      v80 = **((_QWORD **)off_8CD9250 + 23);
      if ( v80 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
    }
    v82 = *(_QWORD *)(v80 + 48);
    if ( v82 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(_BYTE *)(v82 + 152) == 0 )
    {
      if ( *(_BYTE *)(v82 + 128) != 0 )
      {
        if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v78, v79) == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        Timer = TimeModuleO_TimeManager__GetTimer();
        v84 = Timer;
        if ( Timer != 0 )
        {
          v264 = *(_QWORD *)(Timer + 24);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) < 2025 )
            goto LABEL_53;
          v264 = *(_QWORD *)(v84 + 32);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) <= 2024 )
          {
LABEL_53:
            if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEE590);
            v85 = System_TimeSpan__FromDays(0, 2.0);
            TimeModuleO_TimeManager_Timer__Restart(v84, v85, 1, 0);
          }
        }
      }
      v86 = **((_QWORD **)off_8CD9250 + 23);
      if ( v86 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v87 = *(_QWORD *)(v86 + 48);
      if ( v87 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( *(_BYTE *)(v87 + 130) != 0 )
      {
        if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v78, v79) == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v88 = TimeModuleO_TimeManager__GetTimer();
        v89 = v88;
        if ( v88 != 0 )
        {
          v264 = *(_QWORD *)(v88 + 24);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) < 2025 )
            goto LABEL_67;
          v264 = *(_QWORD *)(v89 + 32);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) <= 2024 )
          {
LABEL_67:
            if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEE590);
            v90 = System_TimeSpan__FromDays(0, 2.0);
            TimeModuleO_TimeManager_Timer__Restart(v89, v90, 1, 0);
          }
        }
      }
      else
      {
        if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v78, v79) == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v91 = TimeModuleO_TimeManager__GetTimer();
        v92 = v91;
        if ( v91 != 0 )
        {
          v264 = *(_QWORD *)(v91 + 24);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) < 2025 )
            goto LABEL_78;
          v264 = *(_QWORD *)(v92 + 32);
          if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE6460);
          if ( (int)System_DateTime__get_Year(&v264, 0) <= 2024 )
          {
LABEL_78:
            if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEE590);
            v93 = System_TimeSpan__FromDays(0, 4.0);
            TimeModuleO_TimeManager_Timer__Restart(v92, v93, 1, 0);
          }
        }
      }
      v94 = **((_QWORD **)off_8CD9250 + 23);
      if ( v94 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v95 = *(_QWORD *)(v94 + 48);
      if ( v95 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      *(_BYTE *)(v95 + 152) = 1;
      DbtSaveDataManagerBase_object__object___Save(v94, qword_8CFB3A8);
      v96 = **((_QWORD **)off_8CD9258 + 23);
      if ( v96 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      DbtSaveDataManagerBase_object__object___Save(v96, qword_8CFB3E0);
    }
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v97 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
    if ( v97 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (SDKModule_ABTestManager__get_SelectableOfferIsOn(v97, 0) & 1) != 0 )
    {
      if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE64E8);
      UnityEngine_Debug__Log(qword_8D78318, 0);
      if ( *(_BYTE *)(v4 + 33) != 0 )
      {
        v102 = ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v100, v101);
        if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEE590);
        v103 = System_TimeSpan__FromDays(0, 4.0);
        if ( v102 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        *(_QWORD *)(v4 + 64) = TimeModuleO_TimeManager__CreateTimer(v102, qword_8D5A640, v103, 1, 0, 0);
        v104 = **((_QWORD **)off_8CD9250 + 23);
        if ( v104 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        DbtSaveDataManagerBase_object__object___Save(v104, qword_8CFB3A8);
        v105 = **((_QWORD **)off_8CD9258 + 23);
        if ( v105 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        DbtSaveDataManagerBase_object__object___Save(v105, qword_8CFB3E0);
      }
      else
      {
        v234 = **((_QWORD **)off_8CD9250 + 23);
        if ( v234 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v235 = *(_QWORD *)(v234 + 48);
        if ( v235 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( *(_BYTE *)(v235 + 128) != 0 )
        {
          if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v100, v101) == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v236 = TimeModuleO_TimeManager__GetTimer();
          *(_QWORD *)(v4 + 64) = v236;
          if ( v236 == 0 )
          {
            v237 = **((_QWORD **)off_8CD9250 + 23);
            if ( v237 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            v238 = *(_QWORD *)(v237 + 48);
            if ( v238 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            if ( *(_BYTE *)(v238 + 130) == 0 )
            {
              if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v98, v99) == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              v239 = TimeModuleO_TimeManager__GetTimer();
              v242 = ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v240, v241);
              if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CEE590);
              v243 = System_TimeSpan__FromDays(0, 4.0);
              v244 = qword_8D5A640;
              v245 = v243;
              if ( v239 != 0 )
              {
                RemainingTime = TimeModuleO_TimeManager_Timer__GetRemainingTime(v239, 0);
                v247 = (_QWORD **)off_8CEE590;
              }
              else
              {
                v247 = (_QWORD **)off_8CEE590;
                if ( *((_DWORD *)off_8CEE590 + 56) == 0 )
                {
                  il2cpp_codegen_runtime_class_init(off_8CEE590);
                  v247 = (_QWORD **)off_8CEE590;
                }
                RemainingTime = *v247[23];
              }
              if ( *((_DWORD *)v247 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(v247);
              v252 = System_TimeSpan__op_Subtraction(v245, RemainingTime, 0);
              if ( v242 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              v253 = TimeModuleO_TimeManager__CreateTimer(v242, v244, v252, 1, 0, 0);
              *(_QWORD *)(v4 + 64) = v253;
              if ( v253 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              v261[0] = *(_QWORD *)(v253 + 24);
              v254 = ((__int64 (__fastcall *)(void *, _QWORD *))unk_3C3D3B8)(off_8CE6460, v261);
              v255 = *(_QWORD *)(v4 + 64);
              if ( v255 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              v256 = v254;
              v262 = *(_QWORD *)(v255 + 32);
              v257 = ((__int64 (__fastcall *)(void *, __int64 *))unk_3C3D3B8)(off_8CE6460, &v262);
              v258 = System_String__Format(qword_8D78300, v256, v257, 0);
              if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE64E8);
              UnityEngine_Debug__Log(v258, 0);
              v259 = **((_QWORD **)off_8CD9250 + 23);
              if ( v259 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              DbtSaveDataManagerBase_object__object___Save(v259, qword_8CFB3A8);
              v260 = **((_QWORD **)off_8CD9258 + 23);
              if ( v260 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              DbtSaveDataManagerBase_object__object___Save(v260, qword_8CFB3E0);
            }
          }
        }
        else
        {
          if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v100, v101) == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v248 = TimeModuleO_TimeManager__GetTimer();
          *(_QWORD *)(v4 + 64) = v248;
          if ( v248 == 0 )
          {
            v249 = **((_QWORD **)off_8CD9250 + 23);
            if ( v249 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            v250 = *(_QWORD *)(v249 + 48);
            if ( v250 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            if ( *(_BYTE *)(v250 + 130) == 0 )
            {
              *(_BYTE *)(v250 + 130) = 1;
              if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12478, v98, v99) == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              TimeModuleO_TimeManager__GetTimer();
              if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
                il2cpp_codegen_runtime_class_init(off_8CE64E8);
              UnityEngine_Debug__Log(qword_8D782F8, 0);
              v251 = **((_QWORD **)off_8CD9250 + 23);
              if ( v251 == 0 )
                il2cpp_codegen_raise_null_reference_exception();
              DbtSaveDataManagerBase_object__object___Save(v251, qword_8CFB3A8);
            }
          }
        }
      }
    }
    v106 = ToolModule_ManagerBase_object___get_Instance(qword_8D122E8, v98, v99);
    if ( v106 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v107 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v106 + 376LL))(
             v106,
             *(_QWORD *)(*(_QWORD *)v106 + 384LL));
    v108 = method;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    v263[0] = v107;
    v263[1] = v108;
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
    v109 = v263[0];
    if ( v263[0] != 0 )
    {
      v110 = *(_QWORD *)v263[0];
      v111 = LOWORD(v263[1]);
      v112 = *(unsigned __int16 *)(*(_QWORD *)v263[0] + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v263[0] + 302LL) != 0 )
      {
        v113 = (int *)(*(_QWORD *)(v110 + 176) + 8LL);
        while ( *((_QWORD *)v113 - 1) != qword_8CE91C8 )
        {
          --v112;
          v113 += 4;
          if ( v112 == 0 )
            goto LABEL_112;
        }
        v114 = v110 + 16LL * *v113 + 312;
      }
      else
      {
LABEL_112:
        v114 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v263[0], qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v114)(v109, v111, *(_QWORD *)(v114 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *((_OWORD *)self + 2) = *(_OWORD *)v263;
        ((void (__fastcall *)(char *, _QWORD *, void *, __int64))unk_3E2F3C4)(
          (char *)self + 8,
          v263,
          self,
          qword_8D1F458);
        return;
      }
    }
    goto LABEL_115;
  }
  *(_OWORD *)v263 = *((_OWORD *)self + 2);
  *((_QWORD *)self + 4) = 0;
  *((_QWORD *)self + 5) = 0;
  *(_DWORD *)self = -1;
LABEL_150:
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  v143 = v263[0];
  if ( v263[0] != 0 )
  {
    v144 = *(_QWORD *)v263[0];
    v145 = LOWORD(v263[1]);
    v146 = *(unsigned __int16 *)(*(_QWORD *)v263[0] + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v263[0] + 302LL) != 0 )
    {
      v147 = (_DWORD *)(*(_QWORD *)(v144 + 176) + 8LL);
      while ( *((_QWORD *)v147 - 1) != qword_8CE91C8 )
      {
        --v146;
        v147 += 4;
        if ( v146 == 0 )
          goto LABEL_157;
      }
      v148 = v144 + 16LL * (*v147 + 2) + 312;
    }
    else
    {
LABEL_157:
      v148 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v263[0], qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v148)(v143, v145, *(_QWORD *)(v148 + 8));
  }
  v149 = ToolModule_ManagerBase_object___get_Instance(qword_8D12410, method, v2);
  if ( v149 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v149 + 376LL))(v149, *(_QWORD *)(*(_QWORD *)v149 + 384LL));
  v152 = ToolModule_ManagerBase_object___get_Instance(qword_8D12180, v150, v151);
  if ( v152 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v152 + 376LL))(v152, *(_QWORD *)(*(_QWORD *)v152 + 384LL));
  v153 = QuickTutor_Demo_ManagerBase_object___get_Instance(qword_8D11F98);
  if ( v153 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v153 + 376LL))(v153, *(_QWORD *)(*(_QWORD *)v153 + 384LL));
  v156 = ToolModule_ManagerBase_object___get_Instance(qword_8D12200, v154, v155);
  if ( v156 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v156 + 376LL))(v156, *(_QWORD *)(*(_QWORD *)v156 + 384LL));
  v159 = ToolModule_ManagerBase_object___get_Instance(qword_8D12210, v157, v158);
  if ( v159 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v159 + 376LL))(v159, *(_QWORD *)(*(_QWORD *)v159 + 384LL));
  v162 = ToolModule_ManagerBase_object___get_Instance(qword_8D12308, v160, v161);
  if ( v162 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v162 + 376LL))(v162, *(_QWORD *)(*(_QWORD *)v162 + 384LL));
  v165 = ToolModule_ManagerBase_object___get_Instance(qword_8D124F8, v163, v164);
  if ( v165 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v165 + 376LL))(v165, *(_QWORD *)(*(_QWORD *)v165 + 384LL));
  v168 = ToolModule_ManagerBase_object___get_Instance(qword_8D12318, v166, v167);
  if ( v168 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v168 + 376LL))(v168, *(_QWORD *)(*(_QWORD *)v168 + 384LL));
  v171 = ToolModule_ManagerBase_object___get_Instance(qword_8D12028, v169, v170);
  if ( v171 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v171 + 376LL))(v171, *(_QWORD *)(*(_QWORD *)v171 + 384LL));
  v174 = ToolModule_ManagerBase_object___get_Instance(qword_8D12540, v172, v173);
  if ( v174 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v174 + 376LL))(v174, *(_QWORD *)(*(_QWORD *)v174 + 384LL));
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(qword_8D892F8, 0);
  v177 = ToolModule_ManagerBase_object___get_Instance(qword_8D12328, v175, v176);
  if ( v177 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v177 + 376LL))(v177, *(_QWORD *)(*(_QWORD *)v177 + 384LL));
  UnityEngine_Debug__Log(qword_8D88018, 0);
  v180 = ToolModule_ManagerBase_object___get_Instance(qword_8D12550, v178, v179);
  if ( v180 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v180 + 376LL))(v180, *(_QWORD *)(*(_QWORD *)v180 + 384LL));
  UnityEngine_Debug__Log(qword_8D86220, 0);
  v183 = ToolModule_ManagerBase_object___get_Instance(qword_8D123D0, v181, v182);
  if ( v183 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameModule_ReportEventsManager__ArenaUnLockRbi(v183, 0);
  v186 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v184, v185);
  v187 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v187, v4, qword_8D2D218, 0);
  if ( v186 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v186, qword_8D619C8, v187, 0);
  if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1930);
  v188 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D178A0);
  if ( v188 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (QuickTutor_TutorialManager__IsStepComplete(v188, qword_8D537B8, 0) & 1) == 0 )
  {
    v191 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v189, v190);
    v192 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
    System_Action_object____ctor(v192, v4, qword_8D2D1E8, 0);
    if ( v191 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__StartListening(v191, qword_8D5B3E8, v192, 0);
  }
  if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1930);
  v193 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D178A0);
  if ( v193 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (QuickTutor_TutorialManager__IsStepComplete(v193, qword_8D53800, 0) & 1) == 0 )
  {
    v196 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v194, v195);
    v197 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
    System_Action_object____ctor(v197, v4, qword_8D2D208, 0);
    if ( v196 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__StartListening(v196, qword_8D605A0, v197, 0);
  }
  v198 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v194, v195);
  v199 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v199, v4, qword_8D2D1F8, 0);
  if ( v198 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v198, qword_8D5DA68, v199, 0);
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(v4 + 33) != 0 )
  {
    v202 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v200, v201);
    if ( v202 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(v202, qword_8D5DA68, 0, 0);
  }
  v203 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v200, v201);
  v204 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v204, v4, qword_8D2D220, 0);
  if ( v203 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v203, qword_8D690B8, v204, 0);
  v207 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v205, v206);
  v208 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v208, v4, qword_8D2D200, 0);
  if ( v207 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v207, qword_8D698A0, v208, 0);
  v211 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v209, v210);
  v212 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v212, v4, qword_8D2D1F0, 0);
  if ( v211 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v211, qword_8D5BF68, v212, 0);
  v215 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v213, v214);
  v216 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v216, v4, qword_8D2D210, 0);
  if ( v215 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__StartListening(v215, qword_8D66350, v216, 0);
  v219 = *(_QWORD *)(v4 + 88);
  if ( v219 != 0 )
    (*(void (__fastcall **)(_QWORD, _QWORD))(v219 + 24))(*(_QWORD *)(v219 + 64), *(_QWORD *)(v219 + 40));
  *(_BYTE *)(v4 + 32) = 1;
  v220 = ToolModule_ManagerBase_object___get_Instance(qword_8D123D0, v217, v218);
  if ( v220 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  GameModule_ReportEventsManager__AppOpenEvent(v220, 0);
  v221 = off_8D17868;
  v222 = *((_QWORD *)off_8D17868 + 4);
  if ( (*(_BYTE *)(v222 + 309) & 1) == 0 )
    v222 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v222);
  v223 = *(_QWORD *)(*(_QWORD *)(v222 + 192) + 16LL);
  if ( (*(_BYTE *)(v223 + 309) & 1) == 0 )
    v223 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v223);
  if ( *(_DWORD *)(v223 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v223);
  v224 = v221[4];
  if ( (*(_BYTE *)(v224 + 309) & 1) == 0 )
    v224 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v224);
  v225 = *(_QWORD *)(*(_QWORD *)(v224 + 192) + 16LL);
  if ( (*(_BYTE *)(v225 + 309) & 1) == 0 )
    v225 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v225);
  v226 = **(_QWORD **)(v225 + 184);
  if ( v226 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  ljzs_lt_LTEmailControl__InitEmail(v226, 0);
  FixedRandomTools__Load(0);
  v228 = GameModule_GameManager__CheckNetworkState((void *)v4, v227);
  UnityEngine_MonoBehaviour__StartCoroutine(v4, v228, 0);
  *(_DWORD *)self = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v229 = *((__int64 **)self + 1);
  if ( v229 != nullptr )
  {
    v230 = *v229;
    v231 = *(unsigned __int16 *)(*v229 + 302);
    if ( *(_WORD *)(*v229 + 302) != 0 )
    {
      v232 = (_DWORD *)(*(_QWORD *)(v230 + 176) + 8LL);
      while ( *((_QWORD *)v232 - 1) != qword_8CE9038 )
      {
        --v231;
        v232 += 4;
        if ( v231 == 0 )
          goto LABEL_218;
      }
      v233 = v230 + 16LL * (*v232 + 2) + 312;
    }
    else
    {
LABEL_218:
      v233 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v229, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v233)(v229, *(_QWORD *)(v233 + 8));
  }
}
