// local variable allocation has failed, the output may be wrong!
void *GameModule_GameManager___c___StartCoreGame_b__19_0(void *self, unsigned __int8 win, const MethodInfo *method)
{
  void *v4; // x20
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 v7; // x21
  __int64 v8; // x23
  __int64 v9; // x22
  __int64 v10; // x8
  _QWORD *v11; // x9
  __int64 v12; // x10
  __int64 v13; // x1
  __int64 v14; // x2
  __int64 Instance; // x0
  __int64 v16; // x1
  __int64 v17; // x2
  __int64 v18; // x0
  __int64 v19; // x1
  __int64 v20; // x2
  __int64 v21; // x0
  __int64 v22; // x8
  __int64 v23; // x21
  _QWORD *v24; // x0
  __int64 Item; // x0
  __int64 v26; // x1
  __int64 v27; // x2
  void *v28; // x24
  __int64 v29; // x0
  __int64 v30; // x8
  __int64 v31; // x21
  _QWORD *v32; // x0
  __int64 v33; // x0
  __int64 v34; // x1
  __int64 v35; // x2
  __int64 v36; // x23
  __int64 v37; // x0
  void *v38; // x0
  __int64 v39; // x1
  __int64 v40; // x2
  __int64 v41; // x0
  __int64 v42; // x1
  __int64 v43; // x2
  __int64 v44; // x21
  __int64 v45; // x0
  __int64 v46; // x1
  __int64 v47; // x2
  __int64 v48; // x0
  __int64 v49; // x8
  __int64 v50; // x21
  _QWORD *v51; // x0
  __int64 v52; // x0
  __int64 v53; // x1
  __int64 v54; // x2
  void *v55; // x22
  __int64 v56; // x0
  __int64 v57; // x21
  __int64 v58; // x24
  __int64 v59; // x23
  __int64 v60; // x1
  __int64 v61; // x2
  __int64 v62; // x8
  _QWORD *v63; // x9
  __int64 v64; // x10
  _QWORD *v65; // x0
  _QWORD *v66; // x0
  __int64 v67; // x0
  __int64 v68; // x0
  float v69; // s1
  int v70; // w8
  __int64 v71; // x25
  __int64 v72; // x8
  _QWORD *v73; // x9
  __int64 v74; // x10
  __int64 v75; // x23
  __int64 v76; // x1
  __int64 v77; // x2
  __int64 v78; // x0
  void *v79; // x0
  __int64 v80; // x1
  __int64 v81; // x2
  __int64 v82; // x23
  int v83; // w0
  int v84; // w23
  int v85; // w0
  int v86; // w8
  __int64 v87; // x1
  __int64 v88; // x0
  __int64 v89; // x24
  __int64 v90; // x8
  _QWORD *v91; // x9
  __int64 v92; // x10
  __int64 v93; // x24
  __int64 v94; // x23
  __int64 v95; // x1
  __int64 v96; // x2
  __int64 v97; // x8
  _QWORD *v98; // x9
  __int64 v99; // x10
  __int64 v100; // x23
  __int64 v101; // x23
  __int64 v102; // x8
  _QWORD *v103; // x9
  __int64 v104; // x10
  void *v105; // x0
  __int64 v106; // x1
  __int64 v107; // x2
  __int64 v108; // x23
  int ArenaTrophyNumber; // w23
  __int64 v110; // x1
  __int64 v111; // x2
  __int64 v112; // x0
  __int64 v113; // x8
  __int64 v114; // x24
  _QWORD *v115; // x0
  __int64 v116; // x0
  int v117; // w23
  int v118; // w0
  unsigned int v119; // w24
  __int64 v120; // x23
  __int64 v121; // x0
  __int64 v122; // x1
  __int64 v123; // x23
  _QWORD *v124; // x0
  __int64 v125; // x24
  __int64 v126; // x0
  void *v127; // x0
  __int64 v128; // x1
  __int64 v129; // x2
  __int64 v130; // x0
  __int64 v131; // x23
  __int64 v132; // x22
  __int64 v133; // x8
  _QWORD *v134; // x9
  __int64 v135; // x10
  __int64 v136; // x24
  __int64 v137; // x23
  __int64 v138; // x1
  __int64 v139; // x2
  __int64 v140; // x8
  _QWORD *v141; // x9
  __int64 v142; // x10
  __int64 v143; // x23
  _QWORD *v144; // x0
  __int64 v145; // x24
  __int64 v146; // x0
  __int64 v147; // x1
  __int64 v148; // x2
  __int64 v149; // x0
  __int64 v150; // x1
  __int64 v151; // x2
  __int64 v152; // x0
  __int64 v153; // x1
  __int64 v154; // x2
  __int64 v155; // x0
  void *value; // [xsp+0h] [xbp-80h]
  __int64 v158; // [xsp+8h] [xbp-78h] BYREF
  __int64 v159; // [xsp+10h] [xbp-70h] BYREF
  __int64 v160; // [xsp+18h] [xbp-68h] BYREF

  if ( (byte_8FFD8A1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4AD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0DCA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDFD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12048);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D121A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12410);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CECA48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CECA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68760);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53C40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D52658);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53C68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53CC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53C50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53C48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536B8);
    byte_8FFD8A1 = 1;
  }
  v159 = 0;
  v160 = 0;
  v158 = 0;
  v4 = nullptr;
  if ( (GameModule_TrainingGroundManager__get_IsInTrainingGround(0, win) & 1) != 0 )
  {
    v4 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA40);
    GameModule_RewardConfig___ctor(v4, 5, 0);
    if ( ToolModule_ManagerBase_object___get_Instance(qword_8D121A0, v5, v6) == 0 )
      goto LABEL_191;
    HIDWORD(v160) = ((__int64 (*)(void))GameConfigModule_GameConfigManager__GetConfigInt)();
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFD0);
    System_Collections_Generic_List_object____ctor(v7, qword_8D0DC98);
    v8 = System_Int32__ToString((char *)&v160 + 4, 0);
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
    GameModule_RewardConfigSingle___ctor(v9, qword_8D53C68, v8, 0, 0);
    if ( v7 == 0 )
      goto LABEL_191;
    v10 = *(_QWORD *)(v7 + 16);
    v11 = off_8D0DCA8;
    ++*(_DWORD *)(v7 + 28);
    if ( v10 == 0 )
      goto LABEL_191;
    v12 = *(int *)(v7 + 24);
    if ( (unsigned int)v12 >= *(_DWORD *)(v10 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v7, v9, *(_QWORD *)(*(_QWORD *)(v11[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v7 + 24) = v12 + 1;
      *(_QWORD *)(v10 + 8 * v12 + 32) = v9;
    }
    if ( v4 == nullptr )
      goto LABEL_191;
    GameModule_RewardConfig__AddAssetDataList(v4, v7, 0);
  }
  if ( (GameModule_TrainingGroundManager__get_IsInGuidedGame(0) & 1) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12488, v13, v14);
    if ( Instance == 0 )
      goto LABEL_191;
    GameModule_TrainingGroundManager__OnTrainingGameComplete(Instance, win & 1, 0);
  }
  if ( v4 == nullptr )
  {
    v4 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA40);
    GameModule_RewardConfig___ctor(v4, 5, 0);
    if ( (win & 1) != 0 )
    {
      v18 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v16, v17);
      if ( v18 == 0 )
        goto LABEL_191;
      value = (void *)GameModule_BattleGameManager__GameSuccessGetTrophyNumber(v18, 0);
      v21 = ToolModule_ManagerBase_object___get_Instance(qword_8D12118, v19, v20);
      if ( v21 == 0 )
        goto LABEL_191;
      v22 = *(_QWORD *)(v21 + 40);
      if ( v22 == 0 )
        goto LABEL_191;
      v23 = *(_QWORD *)(v22 + 184);
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      v24 = off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v24 = off_8CE5E20;
      }
      if ( v23 == 0 )
        goto LABEL_191;
      Item = System_Collections_Generic_Dictionary_object__object___get_Item(
               v23,
               *(_QWORD *)(v24[23] + 8LL),
               qword_8CFE650);
      if ( Item == 0 )
        goto LABEL_191;
      v28 = *(void **)(Item + 40);
      v29 = ToolModule_ManagerBase_object___get_Instance(qword_8D12118, v26, v27);
      if ( v29 == 0 )
        goto LABEL_191;
      v30 = *(_QWORD *)(v29 + 40);
      if ( v30 == 0 )
        goto LABEL_191;
      v31 = *(_QWORD *)(v30 + 184);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      v32 = off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v32 = off_8CE5E20;
      }
      if ( v31 == 0 )
        goto LABEL_191;
      v33 = System_Collections_Generic_Dictionary_object__object___get_Item(
              v31,
              *(_QWORD *)(v32[23] + 8LL),
              qword_8CFE650);
      if ( v33 == 0 )
        goto LABEL_191;
      v36 = *(_QWORD *)(v33 + 88);
      v37 = ToolModule_ManagerBase_object___get_Instance(qword_8D121A0, v34, v35);
      if ( v37 == 0 )
        goto LABEL_191;
      LODWORD(v160) = GameConfigModule_GameConfigManager__GetConfigInt(v37, qword_8D68768, 0);
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v38 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
      if ( v38 == nullptr )
        goto LABEL_191;
      if ( (SDKModule_ABTestManager__get_NoBetIsBTest(v38, 0) & 1) != 0 )
      {
        v41 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v39, v40);
        if ( v41 == 0 )
          goto LABEL_191;
        v28 = *(void **)(v41 + 232);
        v44 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v42, v43);
        v45 = ToolModule_StringTool__ToInt(v28, nullptr);
        if ( v44 == 0 )
          goto LABEL_191;
        GameModule_ArenaManager__ApplyNoBetVictoryGold(v45, (unsigned int)v45);
      }
      else
      {
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
        if ( byte_8FFD3A7 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
          byte_8FFD3A7 = 1;
        }
        v65 = off_8CE5E20;
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
          v65 = off_8CE5E20;
        }
        if ( (ToolModule_StringTool__IsNullOrEmpty(*(void **)(v65[23] + 8LL), 1u, nullptr) & 1) == 0 )
        {
          if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5E20);
          if ( byte_8FFD3A7 == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
            byte_8FFD3A7 = 1;
          }
          v66 = off_8CE5E20;
          if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE5E20);
            v66 = off_8CE5E20;
          }
          if ( (System_String__op_Inequality(*(_QWORD *)(v66[23] + 8LL), qword_8D536B8, 0) & 1) != 0 )
          {
            v67 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v46, v47);
            if ( v67 == 0 )
              goto LABEL_191;
            v28 = *(void **)(v67 + 232);
          }
        }
      }
      v68 = ToolModule_ManagerBase_object___get_Instance(qword_8D122F8, v46, v47);
      if ( v68 == 0 )
        goto LABEL_191;
      if ( (GameModule_MonthlyPassManager__HadBuyMonthPass(v68, 0) & 1) != 0 )
      {
        v69 = (float)ToolModule_StringTool__ToInt(v28, nullptr);
        v70 = (int)(float)(v69 * 1.2);
        if ( (float)(v69 * 1.2) == INFINITY )
          v70 = 0x80000000;
        HIDWORD(v159) = v70;
        v28 = (void *)System_Int32__ToString((char *)&v159 + 4, 0);
      }
      v57 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFD0);
      System_Collections_Generic_List_object____ctor(v57, qword_8D0DC98);
      v71 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
      GameModule_RewardConfigSingle___ctor(v71, qword_8D53C48, v28, 0, 0);
      if ( v57 == 0 )
        goto LABEL_191;
      v72 = *(_QWORD *)(v57 + 16);
      v73 = off_8D0DCA8;
      ++*(_DWORD *)(v57 + 28);
      if ( v72 == 0 )
        goto LABEL_191;
      v74 = *(int *)(v57 + 24);
      if ( (unsigned int)v74 >= *(_DWORD *)(v72 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v57,
          v71,
          *(_QWORD *)(*(_QWORD *)(v73[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v57 + 24) = v74 + 1;
        *(_QWORD *)(v72 + 8 * v74 + 32) = v71;
      }
      v89 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
      GameModule_RewardConfigSingle___ctor(v89, qword_8D53C50, v36, 0, 0);
      v90 = *(_QWORD *)(v57 + 16);
      v91 = off_8D0DCA8;
      ++*(_DWORD *)(v57 + 28);
      if ( v90 == 0 )
        goto LABEL_191;
      v92 = *(int *)(v57 + 24);
      if ( (unsigned int)v92 >= *(_DWORD *)(v90 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v57,
          v89,
          *(_QWORD *)(*(_QWORD *)(v91[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v57 + 24) = v92 + 1;
        *(_QWORD *)(v90 + 8 * v92 + 32) = v89;
      }
      v93 = System_Int32__ToString(&v160, 0);
      v94 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
      GameModule_RewardConfigSingle___ctor(v94, qword_8D53C68, v93, 0, 0);
      v97 = *(_QWORD *)(v57 + 16);
      v98 = off_8D0DCA8;
      ++*(_DWORD *)(v57 + 28);
      if ( v97 == 0 )
        goto LABEL_191;
      v99 = *(int *)(v57 + 24);
      if ( (unsigned int)v99 >= *(_DWORD *)(v97 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v57,
          v94,
          *(_QWORD *)(*(_QWORD *)(v98[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v57 + 24) = v99 + 1;
        *(_QWORD *)(v97 + 8 * v99 + 32) = v94;
      }
      v100 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v95, v96);
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( v100 == 0 )
LABEL_191:
        il2cpp_codegen_raise_null_reference_exception();
      if ( (GameModule_ArenaManager__GetArenaIsCollectAllTrophy() & 1) == 0 )
      {
        v101 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
        GameModule_RewardConfigSingle___ctor(v101, qword_8D53C40, value, 0, 0);
        v102 = *(_QWORD *)(v57 + 16);
        v103 = off_8D0DCA8;
        ++*(_DWORD *)(v57 + 28);
        if ( v102 == 0 )
          goto LABEL_191;
        v104 = *(int *)(v57 + 24);
        if ( (unsigned int)v104 >= *(_DWORD *)(v102 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v57,
            v101,
            *(_QWORD *)(*(_QWORD *)(v103[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v57 + 24) = v104 + 1;
          *(_QWORD *)(v102 + 8 * v104 + 32) = v101;
        }
        if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE1928);
        v105 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
        if ( v105 == nullptr )
          goto LABEL_191;
        if ( (SDKModule_ABTestManager__get_NewArenaProcessIsBTest(v105, 0) & 1) != 0 )
        {
          v108 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v106, v107);
          if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5E20);
          if ( byte_8FFD3A7 == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
            byte_8FFD3A7 = 1;
          }
          if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5E20);
          if ( v108 == 0 )
            goto LABEL_191;
          ArenaTrophyNumber = GameModule_ArenaManager__GetArenaTrophyNumber();
          v112 = ToolModule_ManagerBase_object___get_Instance(qword_8D12118, v110, v111);
          if ( v112 == 0 )
            goto LABEL_191;
          v113 = *(_QWORD *)(v112 + 40);
          if ( v113 == 0 )
            goto LABEL_191;
          v114 = *(_QWORD *)(v113 + 184);
          if ( byte_8FFD3A7 == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
            byte_8FFD3A7 = 1;
          }
          v115 = off_8CE5E20;
          if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE5E20);
            v115 = off_8CE5E20;
          }
          if ( v114 == 0 )
            goto LABEL_191;
          v116 = System_Collections_Generic_Dictionary_object__object___get_Item(
                   v114,
                   *(_QWORD *)(v115[23] + 8LL),
                   qword_8CFE650);
          if ( v116 == 0 )
            goto LABEL_191;
          v117 = ToolModule_StringTool__ToInt(*(void **)(v116 + 64), nullptr) - ArenaTrophyNumber;
          v118 = ToolModule_StringTool__ToInt(value, nullptr);
          v119 = v118 - v117;
          if ( v118 > v117 )
          {
            v120 = ToolModule_ManagerBase_object___get_Instance(qword_8D12528, v106, v107);
            if ( *((_DWORD *)off_8CE4AD0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE4AD0);
            v121 = System_Numerics_BigInteger__op_Implicit(v119, 0);
            if ( v120 == 0 )
              goto LABEL_191;
            GameModule_UserResourcesManager__LoseResourceCount(v120, qword_8D53C40, v121, v122, 0, 0, 0);
          }
        }
        v123 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v106, v107);
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
        if ( byte_8FFD3A7 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
          byte_8FFD3A7 = 1;
        }
        v124 = off_8CE5E20;
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
          v124 = off_8CE5E20;
        }
        v125 = *(_QWORD *)(v124[23] + 8LL);
        v126 = ToolModule_StringTool__ToInt(value, nullptr);
        if ( v123 == 0 )
          goto LABEL_191;
        GameModule_ArenaManager__ChangeArenaTrophy(v126, v125, (unsigned int)v126, 0);
      }
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v127 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
      if ( v127 == nullptr )
        goto LABEL_191;
      if ( (SDKModule_ABTestManager__get_SeasonIsBTest(v127, 0) & 1) != 0 )
      {
        v130 = ToolModule_ManagerBase_object___get_Instance(qword_8D12410, v128, v129);
        if ( v130 == 0 )
          goto LABEL_191;
        LODWORD(v159) = GameModule_SeasonManager__CalculatePVPWinSeasonPassExpReward(v130, 0);
        if ( (int)v159 >= 1 )
        {
          v131 = System_Int32__ToString(&v159, 0);
          v132 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
          GameModule_RewardConfigSingle___ctor(v132, qword_8D53CC0, v131, 0, 0);
          v133 = *(_QWORD *)(v57 + 16);
          v134 = off_8D0DCA8;
          ++*(_DWORD *)(v57 + 28);
          if ( v133 == 0 )
            goto LABEL_191;
          v135 = *(int *)(v57 + 24);
          if ( (unsigned int)v135 >= *(_DWORD *)(v133 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v57,
              v132,
              *(_QWORD *)(*(_QWORD *)(v134[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v57 + 24) = v135 + 1;
            *(_QWORD *)(v133 + 8 * v135 + 32) = v132;
          }
        }
      }
    }
    else
    {
      v48 = ToolModule_ManagerBase_object___get_Instance(qword_8D12118, v16, v17);
      if ( v48 == 0 )
        goto LABEL_191;
      v49 = *(_QWORD *)(v48 + 40);
      if ( v49 == 0 )
        goto LABEL_191;
      v50 = *(_QWORD *)(v49 + 184);
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      v51 = off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v51 = off_8CE5E20;
      }
      if ( v50 == 0 )
        goto LABEL_191;
      v52 = System_Collections_Generic_Dictionary_object__object___get_Item(
              v50,
              *(_QWORD *)(v51[23] + 8LL),
              qword_8CFE650);
      if ( v52 == 0 )
        goto LABEL_191;
      v55 = *(void **)(v52 + 32);
      v56 = ToolModule_ManagerBase_object___get_Instance(qword_8D121A0, v53, v54);
      if ( v56 == 0 )
        goto LABEL_191;
      HIDWORD(v158) = GameConfigModule_GameConfigManager__GetConfigInt(v56, qword_8D68760, 0);
      v57 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDFD0);
      System_Collections_Generic_List_object____ctor(v57, qword_8D0DC98);
      v58 = System_Int32__ToString((char *)&v158 + 4, 0);
      v59 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
      GameModule_RewardConfigSingle___ctor(v59, qword_8D53C68, v58, 0, 0);
      if ( v57 == 0 )
        goto LABEL_191;
      v62 = *(_QWORD *)(v57 + 16);
      v63 = off_8D0DCA8;
      ++*(_DWORD *)(v57 + 28);
      if ( v62 == 0 )
        goto LABEL_191;
      v64 = *(int *)(v57 + 24);
      if ( (unsigned int)v64 >= *(_DWORD *)(v62 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v57,
          v59,
          *(_QWORD *)(*(_QWORD *)(v63[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v57 + 24) = v64 + 1;
        *(_QWORD *)(v62 + 8 * v64 + 32) = v59;
      }
      v75 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v60, v61);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( v75 == 0 )
        goto LABEL_191;
      if ( (GameModule_ArenaManager__GetArenaIsCollectAllTrophy() & 1) != 0 )
        goto LABEL_185;
      v78 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v76, v77);
      if ( v78 == 0 )
        goto LABEL_191;
      if ( GameModule_BattleGameManager__get_ElapseTime(v78, 0) <= 10.0 )
        goto LABEL_185;
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v79 = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
      if ( v79 == nullptr )
        goto LABEL_191;
      if ( (SDKModule_ABTestManager__get_NewArenaProcessIsBTest(v79, 0) & 1) != 0 )
      {
        v82 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v80, v81);
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
        if ( byte_8FFD3A7 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
          byte_8FFD3A7 = 1;
        }
        if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5E20);
        if ( v82 == 0 )
          goto LABEL_191;
        v83 = GameModule_ArenaManager__GetArenaTrophyNumber();
        if ( v83 < 1 )
          goto LABEL_185;
        v84 = v83;
        v85 = ToolModule_StringTool__ToInt(v55, nullptr);
        if ( v85 <= v84 )
          v86 = v85;
        else
          v86 = v84;
        LODWORD(v158) = v86;
        v87 = System_Int32__ToString(&v158, 0);
        v88 = qword_8D52658;
      }
      else
      {
        v87 = (__int64)v55;
        v88 = qword_8D52658;
      }
      v136 = sub_74FE7A4(v88, v87, 0);
      v137 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECA48);
      GameModule_RewardConfigSingle___ctor(v137, qword_8D53C40, v136, 0, 0);
      v140 = *(_QWORD *)(v57 + 16);
      v141 = off_8D0DCA8;
      ++*(_DWORD *)(v57 + 28);
      if ( v140 == 0 )
        goto LABEL_191;
      v142 = *(int *)(v57 + 24);
      if ( (unsigned int)v142 >= *(_DWORD *)(v140 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v57,
          v137,
          *(_QWORD *)(*(_QWORD *)(v141[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v57 + 24) = v142 + 1;
        *(_QWORD *)(v140 + 8 * v142 + 32) = v137;
      }
      v143 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FD8, v138, v139);
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
      if ( byte_8FFD3A7 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
        byte_8FFD3A7 = 1;
      }
      v144 = off_8CE5E20;
      if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5E20);
        v144 = off_8CE5E20;
      }
      v145 = *(_QWORD *)(v144[23] + 8LL);
      v146 = ToolModule_StringTool__ToInt(v55, nullptr);
      if ( v143 == 0 )
        goto LABEL_191;
      GameModule_ArenaManager__ChangeArenaTrophy(v146, v145, (unsigned int)-(int)v146, 0);
    }
LABEL_185:
    if ( v4 != nullptr )
    {
      GameModule_RewardConfig__AddAssetDataList(v4, v57, 0);
      v149 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v147, v148);
      if ( v149 != 0 )
      {
        *(_QWORD *)(v149 + 192) = v4;
        v152 = ToolModule_ManagerBase_object___get_Instance(qword_8D12048, v150, v151);
        if ( v152 != 0 )
        {
          *(_QWORD *)(v152 + 200) = v4;
          v155 = ToolModule_ManagerBase_object___get_Instance(qword_8D123D0, v153, v154);
          if ( v155 != 0 )
          {
            GameModule_ReportEventsManager__OnGameFinish(v155, win & 1, 0, 0, 0);
            return v4;
          }
        }
      }
    }
    goto LABEL_191;
  }
  return v4;
}
