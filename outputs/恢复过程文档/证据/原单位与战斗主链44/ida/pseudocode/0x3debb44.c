__int64 __fastcall GameModule_BattleGameManager__SettlementAnimationEnd_d__59__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  int v3; // w8
  void *Instance; // x0
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x2
  __int64 v10; // x0
  _BYTE *v11; // x0
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x1
  __int64 v15; // x2
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x2
  _DWORD *v19; // x0
  int v20; // w21
  __int64 v21; // x0
  void *v22; // x0
  float v23; // s0
  __int64 v24; // x22
  __int64 v25; // x0
  __int64 v26; // x1
  void *v27; // x21
  void *v28; // x0
  __int64 v29; // x1
  __int64 v30; // x2
  int v31; // w8
  __int64 v32; // x0
  void *v33; // x0
  __int64 v34; // x8
  void *v35; // x0
  void *v36; // x0
  void *v37; // x21
  __int64 v38; // x0
  __int64 v39; // x1
  __int64 v40; // x22
  __int64 v41; // x23
  __int64 v42; // x21
  __int64 v43; // x1
  __int64 v44; // x22
  __int64 v45; // x8
  __int64 v46; // x9
  int *v47; // x10
  __int64 v48; // x0
  __int64 v49; // x8
  __int64 v50; // x9
  _DWORD *v51; // x10
  __int64 v52; // x0
  void *v53; // x0
  int v54; // w8
  void *v55; // x0
  __int64 v56; // x1
  __int64 v57; // x2
  void *v58; // x0
  void *v59; // x0
  void *v60; // x0
  void *v61; // x0
  void *v62; // x0
  void *v64; // x0
  void *v65; // x0
  void *v66; // x0
  void *v67; // x0
  void *v68; // x0
  void *v69; // x0
  void *v70; // x0
  __int64 v71; // x0
  __int64 v72; // x1
  __int64 v73; // x2
  __int64 v74; // x0
  void *v75; // x0
  void *v76; // x0
  __int64 v77; // x0
  __int128 v78; // [xsp+0h] [xbp-50h] BYREF

  if ( (byte_8FFD75E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D221E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4AD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D121D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12450);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12358);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D178A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D537B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D59050);
    byte_8FFD75E = 1;
  }
  v78 = 0u;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 != 0 )
  {
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v3 = *(_DWORD *)(v2 + 240);
    if ( v3 == 0 || v3 == 3 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12358);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_PanelPopHandleManager__GameEndPanelPopHandle(Instance, 0);
      if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1930);
      v7 = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, v5, v6);
      if ( v7 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( QuickTutor_TutorialManager__IsStepComplete(v7, qword_8D537B0, 0) )
      {
        if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE1930);
        v10 = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, v8, v9);
        if ( v10 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( QuickTutor_TutorialManager__IsStepComplete(v10, qword_8D537B8, 0) )
        {
          v11 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D121D0);
          if ( v11 == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          v11[40] = 1;
        }
      }
    }
    v12 = *(_QWORD *)(v2 + 208);
    if ( v12 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_BattleContext__SetReward(v12, *(unsigned __int8 *)(v2 + 128));
    v13 = *(_QWORD *)(v2 + 208);
    if ( v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v2 + 192) = GameModule_BattleContext__GetRewardConfig(v13, 0);
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v16 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v14, v15);
    if ( v16 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (SDKModule_ABTestManager__get_NewMainCity2(v16, 0) & 1) != 0 && *(_BYTE *)(v2 + 128) != 0 )
    {
      v19 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      if ( v19 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      v20 = v19[122];
    }
    else
    {
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v21 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v17, v18);
      if ( v21 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (SDKModule_ABTestManager__get_NewMainCity2(v21, 0) & 1) != 0 )
      {
        v20 = 0;
      }
      else if ( *(_BYTE *)(v2 + 128) != 0 )
      {
        v20 = 100;
      }
      else
      {
        v20 = 0;
      }
    }
    v22 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D122F8);
    if ( v22 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (GameModule_MonthlyPassManager__HadBuyMonthPass(v22, 0) & 1) != 0 )
    {
      v23 = (float)v20 * 1.2;
      if ( v23 == INFINITY )
        v20 = 0x80000000;
      else
        v20 = (int)v23;
    }
    v24 = *(_QWORD *)(v2 + 192);
    if ( *((_DWORD *)off_8CE4AD0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4AD0);
    v25 = System_Numerics_BigInteger__op_Implicit((unsigned int)v20, 0);
    if ( v24 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_RewardConfig__AddResources(v24, qword_8D53C70, v25, v26, 0);
    if ( *(_DWORD *)(v2 + 240) == 3 )
    {
      v27 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12450);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v27, 0, 0) & 1) != 0 )
      {
        GameModule_SubGameChaosTrailsRewardBuilder__ApplyChaosTrailsRewardRatio(
          *(_QWORD *)(v2 + 192),
          *(unsigned __int8 *)(v2 + 128),
          0);
        if ( *(_BYTE *)(v2 + 128) != 0 )
        {
          v28 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12450);
          if ( v28 == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          GameModule_SubGameChaosTrailsManager__RecordDailyBaseRewardPlay(v28, 0);
        }
      }
    }
    GameModule_BattleGameManager__GameEndRewardUser(v2, *(_QWORD *)(v2 + 192));
    v31 = *(_DWORD *)(v2 + 240);
    if ( v31 == 0 || v31 == 3 )
    {
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1928);
      v32 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v29, v30);
      if ( v32 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (SDKModule_ABTestManager__get_NewArenaProcessIsBTest(v32, 0) & 1) != 0 )
      {
        v33 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D11FE8);
        if ( v33 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_ArenaProgressManager__ArenaProgressPlayerTrophyRefreshSync(v33, 0);
      }
    }
    GameModule_BattleGameManager__RecordGameResult(v2);
    v34 = *(_QWORD *)(v2 + 184);
    if ( v34 != 0 )
      (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))(v34 + 24))(
        *(_QWORD *)(v34 + 64),
        *(unsigned __int8 *)(v2 + 128),
        *(_QWORD *)(v34 + 40));
    v35 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
    if ( v35 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(v35, (void *)qword_8D59050, *(void **)(v2 + 248), nullptr);
    v36 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v36 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    DataModule_DataManager__SaveAllData(v36, 0);
    v37 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D124C8);
    v38 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v40 = v38;
    if ( v38 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v41 = *(_QWORD *)(v2 + 248);
    if ( v41 != 0 )
    {
      v38 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
              *(_QWORD *)(v2 + 248),
              *(_QWORD *)(*(_QWORD *)v38 + 64LL));
      if ( v38 == 0 )
      {
        v77 = ((__int64 (__fastcall *)(_QWORD, __int64))unk_3C3D4F0)(0, v39);
        ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v77, 0);
        goto LABEL_156;
      }
    }
    if ( *(_DWORD *)(v40 + 24) != 0 )
    {
      *(_QWORD *)(v40 + 32) = v41;
      if ( v37 != nullptr )
      {
        v42 = UIFramework_UIManager__ShowPanel(v37, qword_8D57E20, v40, 0);
        v44 = v43;
        if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEEDF8);
        *(_QWORD *)&v78 = v42;
        *((_QWORD *)&v78 + 1) = v44;
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
        if ( (_QWORD)v78 != 0 )
        {
          v45 = *(_QWORD *)v78;
          v46 = *(unsigned __int16 *)(*(_QWORD *)v78 + 302LL);
          if ( *(_WORD *)(*(_QWORD *)v78 + 302LL) != 0 )
          {
            v47 = (int *)(*(_QWORD *)(v45 + 176) + 8LL);
            while ( *((_QWORD *)v47 - 1) != qword_8CE91C8 )
            {
              --v46;
              v47 += 4;
              if ( v46 == 0 )
                goto LABEL_81;
            }
            v48 = v45 + 16LL * *v47 + 312;
          }
          else
          {
LABEL_81:
            v48 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v78, qword_8CE91C8, 0);
          }
          if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v48)(v78, WORD4(v78), *(_QWORD *)(v48 + 8)) == 0 )
          {
            *(_DWORD *)a1 = 0;
            *(_OWORD *)(a1 + 48) = v78;
            return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__BattleGameManager__SettlementAnimationEnd_d__59_(
                     a1 + 8,
                     &v78,
                     a1,
                     qword_8D221E8);
          }
        }
        goto LABEL_84;
      }
    }
    else
    {
      ((void (__fastcall *)(__int64, __int64))unk_3C3D4D4)(v38, v39);
    }
    il2cpp_codegen_raise_null_reference_exception();
  }
  v78 = *(_OWORD *)(a1 + 48);
  *(_QWORD *)(a1 + 48) = 0;
  *(_QWORD *)(a1 + 56) = 0;
  *(_DWORD *)a1 = -1;
LABEL_84:
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v78 != 0 )
  {
    v49 = *(_QWORD *)v78;
    v50 = *(unsigned __int16 *)(*(_QWORD *)v78 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v78 + 302LL) != 0 )
    {
      v51 = (_DWORD *)(*(_QWORD *)(v49 + 176) + 8LL);
      while ( *((_QWORD *)v51 - 1) != qword_8CE91C8 )
      {
        --v50;
        v51 += 4;
        if ( v50 == 0 )
          goto LABEL_91;
      }
      v52 = v49 + 16LL * (*v51 + 2) + 312;
    }
    else
    {
LABEL_91:
      v52 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v78, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v52)(v78, WORD4(v78), *(_QWORD *)(v52 + 8));
  }
  v53 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
  if ( v53 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (GameModule_UserLableManager__UserLableIsOpen(v53, 0) & 1) == 0 )
    goto LABEL_135;
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v54 = *(_DWORD *)(v2 + 240);
  if ( v54 != 0 )
  {
    if ( v54 == 2 )
    {
      v64 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
      if ( v64 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      if ( (GameModule_UserLableManager__UserLableIsOpen(v64, 0) & 1) != 0 )
      {
        v65 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v65 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshUserLableFirstMatchData(v65, 0);
        if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508) == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RecordPlayerNear20GameSituation();
        v66 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v66 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshUserLableRecentWinRateData(v66, 0);
        v67 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v67 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshOrInitInactiveUserBuff(v67, 0, 0);
        v68 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v68 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshOrInitJustNowPaidUserBuff(v68, 0, 0);
        if ( *(_BYTE *)(v2 + 128) != 0 )
        {
          v69 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
          if ( v69 == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          GameModule_UserLableManager__RefreshUserLableWinStreakData(v69, 0);
        }
        else
        {
          v76 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
          if ( v76 == nullptr )
            il2cpp_codegen_raise_null_reference_exception();
          GameModule_UserLableManager__RefreshUserLableLoseStreakData(v76, 0);
        }
      }
      goto LABEL_135;
    }
    if ( v54 != 3 )
    {
LABEL_135:
      *(_DWORD *)a1 = -2;
      return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
    }
  }
  v55 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
  if ( v55 != nullptr )
  {
    if ( (GameModule_UserLableManager__UserLableIsOpen(v55, 0) & 1) != 0 )
    {
      v58 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
      if ( v58 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_UserLableManager__RefreshUserLableFirstMatchData(v58, 0);
      if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508) == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_UserLableManager__RecordPlayerNear20GameSituation();
      v59 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
      if ( v59 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_UserLableManager__RefreshUserLableRecentWinRateData(v59, 0);
      v60 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
      if ( v60 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_UserLableManager__RefreshOrInitInactiveUserBuff(v60, 0, 0);
      v61 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
      if ( v61 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      GameModule_UserLableManager__RefreshOrInitJustNowPaidUserBuff(v61, 0, 0);
      if ( *(_BYTE *)(v2 + 128) != 0 )
      {
        v62 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v62 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshUserLableWinStreakData(v62, 0);
      }
      else
      {
        v70 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12508);
        if ( v70 == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_UserLableManager__RefreshUserLableLoseStreakData(v70, 0);
      }
    }
    if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1930);
    v71 = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, v56, v57);
    if ( v71 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( QuickTutor_TutorialManager__IsStepComplete(v71, qword_8D537B0, 0) )
    {
      if ( *((_DWORD *)off_8CE1930 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE1930);
      v74 = QuickTutor_Singleton_object___get_Instance(qword_8D178A0, v72, v73);
      if ( v74 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( QuickTutor_TutorialManager__IsStepComplete(v74, qword_8D537B8, 0) )
      {
        if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D121D0) == nullptr )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_GameReadyManager__DoAnimation();
      }
    }
    v75 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v75 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    DataModule_DataManager__CheckDanChange(v75, 0, 0);
    goto LABEL_135;
  }
LABEL_156:
  il2cpp_codegen_raise_null_reference_exception();
}
