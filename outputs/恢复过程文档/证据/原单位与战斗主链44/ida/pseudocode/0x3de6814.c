__int64 __fastcall GameModule_BattleGameManager__StartGame(__int64 a1, __int64 a2)
{
  _QWORD *v4; // x0
  __int64 *v5; // x8
  _QWORD *v6; // x0
  __int64 v7; // x21
  _QWORD *Instance; // x0
  __int64 v9; // x8
  __int64 v10; // x0
  __int64 Item; // x0
  __int64 v12; // x0
  long double v13; // q0
  void *v14; // x21
  __int64 v15; // x22
  __int64 v16; // x0
  __int64 v17; // x23
  __int64 v18; // x0
  unsigned int v19; // w8
  __int64 v20; // x23
  __int64 v21; // x1
  void *v22; // x0
  int PlayerInitialCoin; // w0
  __int64 v24; // x8
  __int64 v25; // x9
  __int64 v26; // x8
  __int64 v27; // x0
  __int128 v28; // q0
  __int64 v29; // x20
  __int64 v30; // x0
  __int64 v31; // x8
  __int64 v32; // x0
  __int64 result; // x0
  __int64 v34; // x20
  __int64 v35; // x21
  unsigned int v36; // w21
  __int64 v37; // x22
  __int64 v38; // x0
  __int64 v39; // x0
  int v40; // [xsp+8h] [xbp-38h] BYREF
  int v41; // [xsp+Ch] [xbp-34h] BYREF

  if ( (byte_8FFD749 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB2B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFCF38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0BF08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BF10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D121C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D536B8);
    byte_8FFD749 = 1;
  }
  v41 = 0;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
  if ( byte_8FFD3A7 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    byte_8FFD3A7 = 1;
  }
  v4 = off_8CE5E20;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5E20);
    v4 = off_8CE5E20;
  }
  if ( (ToolModule_StringTool__IsNullOrEmpty(*(_QWORD *)(v4[23] + 8LL), 1, 0) & 1) != 0 )
  {
    v5 = &qword_8D536B8;
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
    v6 = off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      v6 = off_8CE5E20;
    }
    v5 = (__int64 *)(v6[23] + 8LL);
  }
  v7 = *v5;
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( Instance == nullptr )
    goto LABEL_68;
  v9 = Instance[5];
  if ( v9 == 0 )
    goto LABEL_68;
  v10 = *(_QWORD *)(v9 + 184);
  if ( v10 == 0 )
    goto LABEL_68;
  Item = System_Collections_Generic_Dictionary_object__object___get_Item(v10, v7, qword_8CFE650);
  if ( Item == 0 )
    goto LABEL_68;
  *(_DWORD *)(a1 + 64) = ToolModule_StringTool__ToInt(*(_QWORD *)(Item + 120), 0);
  v12 = GameModule_SubGameBuffManager__get_Instance(0);
  if ( v12 == 0 )
    goto LABEL_68;
  *(__n128 *)&v13 = GameModule_SubGameBuffManager__ModifyCountDownTime(v12, a1 + 64, 0);
  *(float *)&v13 = (float)*(int *)(a1 + 64);
  *(_DWORD *)(a1 + 60) = LODWORD(v13);
  *(_QWORD *)(a1 + 72) = GameModule_BattleGameManager__GetTimeCutDownString(a1, v13);
  v14 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D121C0);
  v15 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 2);
  v40 = *(_DWORD *)(a1 + 40);
  v16 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v40);
  if ( v15 == 0 )
    goto LABEL_68;
  v17 = v16;
  if ( v16 != 0 )
  {
    v18 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v15 + 64LL));
    if ( v18 == 0 )
      goto LABEL_70;
  }
  v19 = *(_DWORD *)(v15 + 24);
  if ( v19 == 0 )
  {
LABEL_69:
    v18 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_70;
  }
  *(_QWORD *)(v15 + 32) = v17;
  v20 = *(_QWORD *)(a1 + 72);
  if ( v20 != 0 )
  {
    v18 = ((__int64 (__fastcall *)(_QWORD, _QWORD))unk_3C3D3B4)(
            *(_QWORD *)(a1 + 72),
            *(_QWORD *)(*(_QWORD *)v15 + 64LL));
    if ( v18 != 0 )
    {
      v19 = *(_DWORD *)(v15 + 24);
      goto LABEL_30;
    }
LABEL_70:
    v39 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v18);
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v39, 0);
    JUMPOUT(0x3DE6DAC);
  }
LABEL_30:
  if ( v19 <= 1 )
    goto LABEL_69;
  *(_QWORD *)(v15 + 40) = v20;
  if ( v14 == nullptr )
    goto LABEL_68;
  GameModule_GamePanelManager__UpdateInfo(v14, v15, 0);
  if ( (GameModule_TrainingGroundManager__get_IsInGuidedGame(0) & 1) != 0 )
  {
    v22 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12488);
    if ( v22 == nullptr )
      goto LABEL_68;
    PlayerInitialCoin = GameModule_TrainingGroundManager__GetPlayerInitialCoin(v22, 0);
    *(_DWORD *)(a1 + 40) = PlayerInitialCoin;
    v24 = **((_QWORD **)off_8CD9228 + 23);
  }
  else
  {
    v24 = **((_QWORD **)off_8CD9228 + 23);
    if ( v24 == 0 )
      goto LABEL_68;
    v25 = *(_QWORD *)(v24 + 48);
    if ( v25 == 0 )
      goto LABEL_68;
    if ( *(_BYTE *)(v25 + 16) != 0 )
      PlayerInitialCoin = 150;
    else
      PlayerInitialCoin = 50;
    *(_DWORD *)(a1 + 40) = PlayerInitialCoin;
  }
  *(_DWORD *)(a1 + 44) = PlayerInitialCoin;
  *(_DWORD *)(a1 + 48) = PlayerInitialCoin;
  *(_DWORD *)(a1 + 52) = 0;
  *(_BYTE *)(a1 + 56) = 1;
  if ( v24 == 0 )
    goto LABEL_68;
  v26 = *(_QWORD *)(v24 + 48);
  if ( v26 == 0 )
    goto LABEL_68;
  if ( *(_BYTE *)(v26 + 16) == 0 )
    GameModule_BattleGameManager__BeginStartCountDown(a1, v21);
  if ( a2 == 0
    || (v27 = *(_QWORD *)(a1 + 32),
        *(_DWORD *)(a1 + 240) = *(_DWORD *)(a2 + 64),
        v28 = *(_OWORD *)(a2 + 48),
        *(_QWORD *)(a1 + 208) = a2,
        *(_BYTE *)(a1 + 218) = 0,
        *(_OWORD *)(a1 + 176) = v28,
        v27 == 0) )
  {
LABEL_68:
    il2cpp_codegen_raise_null_reference_exception();
  }
  System_Collections_Generic_Dictionary_int__BattleGameManager_AnimationPauseSnapshot___Clear(v27, qword_8CFCF38);
  if ( *((_DWORD *)off_8CE5558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5558);
  CheatControl__ResetPerfStates(0);
  if ( byte_8FFD1AA == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A28);
    byte_8FFD1AA = 1;
  }
  v29 = **((_QWORD **)off_8CE4A28 + 23);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v29, 0, 0) & 1) != 0 )
  {
    if ( byte_8FFD1AA == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A28);
      byte_8FFD1AA = 1;
    }
    v30 = **((_QWORD **)off_8CE4A28 + 23);
    if ( v30 == 0 )
      goto LABEL_68;
    BattleFPSController__StartMonitoring(v30, 0);
  }
  v31 = **((_QWORD **)off_8CD9208 + 23);
  if ( v31 == 0 )
    goto LABEL_68;
  v32 = *(_QWORD *)(v31 + 48);
  if ( v32 == 0 )
    goto LABEL_68;
  result = DataModule_PlayerCardData__GetBattleCardIDList(v32, 0);
  v34 = result;
  if ( *(_QWORD *)(a1 + 152) == 0 )
  {
    v35 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
    result = System_Collections_Generic_Dictionary_object__int____ctor(v35, qword_8CFEA38);
    *(_QWORD *)(a1 + 152) = v35;
  }
  if ( v34 == 0 )
    goto LABEL_68;
  if ( *(int *)(v34 + 24) >= 1 )
  {
    v36 = 0;
    while ( 1 )
    {
      v37 = *(_QWORD *)(a1 + 152);
      v41 = System_Collections_Generic_List_int___get_Item(v34, v36, qword_8D0BF10);
      v38 = System_Int32__ToString(&v41, 0);
      if ( v37 == 0 )
        break;
      result = System_Collections_Generic_Dictionary_object__int___TryAdd(v37, v38, 0, qword_8CFEA80);
      if ( (signed int)++v36 >= *(_DWORD *)(v34 + 24) )
        return result;
    }
    goto LABEL_68;
  }
  return result;
}
