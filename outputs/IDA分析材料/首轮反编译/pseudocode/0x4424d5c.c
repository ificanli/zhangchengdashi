// local variable allocation has failed, the output may be wrong!
void GameModule_HexBehaviour__OpenHex(
        GameModule_HexBehaviour_o *self,
        ZCDS_Bool isEnemy,
        ZCDS_Bool isHard,
        const MethodInfo *method)
{
  _BYTE **v6; // x0
  __int64 v7; // x8
  int v8; // w21
  __int64 v9; // x1
  __int64 v10; // x2
  int isEnemyHex; // w23
  __int64 v12; // x1
  __int64 v13; // x2
  __int64 Instance; // x0
  __int64 v15; // x1
  __int64 v16; // x2
  __int64 v17; // x0
  __int64 v18; // x0
  __int64 v19; // x1
  __int64 v20; // x2
  int v21; // w8
  __int64 v22; // x0
  _QWORD *v23; // x8
  __int64 transform; // x20
  __int64 v25; // x0
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x21
  __int64 v29; // x20
  __int64 v30; // x22
  _QWORD *v31; // x0
  __int64 v32; // x1
  __int64 v33; // x0
  __int64 v34; // x20
  __int64 v35; // x0
  __int64 v36; // x20
  __int64 v37; // x0
  int v38; // w22
  __int64 v39; // x1
  __int64 v40; // x2
  __int64 v41; // x20
  __int64 gameObject; // x0
  __int64 v43; // x1
  __int64 v44; // x2
  __int64 v45; // x20
  __int64 v46; // x0
  __int64 v47; // x1
  __int64 v48; // x2
  __int64 v49; // x20
  __int64 v50; // x0

  if ( (byte_9000BBB & 1) == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **, ZCDS_Bool, ZCDS_Bool, const MethodInfo *))unk_3C3D280)(
      &off_8CE5E20,
      isEnemy,
      isHard,
      method);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D2EFD8);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D12058);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D12148);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CEB3E0);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D17890);
    ((void (__fastcall *)(_UNKNOWN **))unk_3C3D280)(&off_8CE1928);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8CEEA18);
    ((void (__fastcall *)(void *))unk_3C3D280)(&unk_8D5F188);
    ((void (__fastcall *)(void *))unk_3C3D280)(&unk_8D6C110);
    ((void (__fastcall *)(__int64 *))unk_3C3D280)(&qword_8D536B8);
    byte_9000BBB = 1;
  }
  if ( self->fields._unknown_object_00A2_to_01D7[258] != 0 || self->fields.isOpened != 0 )
    return;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( byte_8FFD1AB == 0 )
  {
    ((void (__fastcall *)(_UNKNOWN **, _QWORD, _QWORD, const MethodInfo *))unk_3C3D280)(
      &off_8CE5E20,
      isEnemy,
      isHard,
      method);
    byte_8FFD1AB = 1;
  }
  v6 = (_BYTE **)off_8CE5E20;
  if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
  {
    ((void (*)(void))unk_3C3D3B0)();
    v6 = (_BYTE **)off_8CE5E20;
  }
  if ( *v6[23] == 0 )
    return;
  v7 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[14];
  if ( v7 != 0 )
  {
    v8 = *(_DWORD *)&self->fields._unknown_object_0010_to_009F[140];
    if ( (System_String__op_Equality(*(_QWORD *)(v7 + 16), qword_8D536B8, 0, method) & 1) != 0 )
    {
      isEnemyHex = self->fields.isEnemyHex;
      if ( ToolModule_ManagerBase_object___get_Instance(qword_8D12058, v9, v10) == 0 )
        goto LABEL_61;
      if ( isEnemyHex != 0 )
        GameModule_BattleGameSceneManager__RecordEnemyUseGoldMine();
      else
        GameModule_BattleGameSceneManager__RecordPlayerUseGoldMine();
      if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
        ((void (*)(void))unk_3C3D3B0)();
      Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v12, v13);
      if ( Instance == 0 )
        goto LABEL_61;
      if ( (SDKModule_ABTestManager__get_GoldMinePriceV2IsBTest(Instance, 0) & 1) != 0 )
      {
        v17 = ToolModule_ManagerBase_object___get_Instance(qword_8D12058, v15, v16);
        if ( v17 == 0 )
          goto LABEL_61;
        GameModule_BattleGameSceneManager__UpdateAllGoldMinePrices(v17, 0);
      }
      *(_DWORD *)&self->fields._unknown_object_0010_to_009F[140] = v8;
    }
  }
  *(_WORD *)&self->fields._unknown_object_0010_to_009F[64] = 0;
  self->fields.isOpened = 1;
  *(_DWORD *)&self->fields._unknown_object_0010_to_009F[40] = 2;
  v18 = GameModule_SubGameBuffManager__get_Instance(0);
  if ( v18 == 0 )
    goto LABEL_61;
  GameModule_SubGameBuffManager__OnActiveHexOpened(v18, isEnemy & 1, 0);
  if ( (isEnemy & 1) == 0 )
    VibratorManager__Trigger(2, 0);
  v21 = *(_DWORD *)&self->fields._unknown_object_0010_to_009F[140];
  self->fields._unknown_object_00A2_to_01D7[259] = 1;
  if ( v21 <= 249 )
  {
    v22 = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, v19, v20);
    if ( v22 == 0 )
      goto LABEL_61;
    v23 = &unk_8D5F188;
    if ( (isEnemy & 1) == 0 )
      v23 = &unk_8D6C110;
    EventModule_EventManager__TriggerEvent(v22, *v23, 0, 0);
  }
  transform = UnityEngine_Component__get_transform(self, 0);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (__fastcall *)(void *))unk_3C3D3B0)(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(transform, 0, 0) & 1) != 0 )
  {
    v25 = UnityEngine_Component__get_transform(self, 0);
    DG_Tweening_ShortcutExtensions__DOMoveY(v25, 0, 0, 1.0, 0.2);
  }
  v26 = UnityEngine_Component__get_transform(self, 0);
  v27 = DG_Tweening_ShortcutExtensions__DOLocalRotate(v26, 0, 0, 0.0, 0.0, 180.0, 0.3);
  if ( v27 == 0 )
  {
LABEL_61:
    ((void (*)(void))unk_3C3D4CC)();
    JUMPOUT(0x4425210);
  }
  v28 = *(_QWORD *)(v27 + 128);
  v29 = v27;
  v30 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEEA18);
  DG_Tweening_TweenCallback___ctor(v30, self, qword_8D2EFD8, 0);
  v31 = (_QWORD *)System_Delegate__Combine(v28, v30, 0);
  if ( v31 != nullptr )
  {
    v32 = qword_8CEEA18;
    if ( *v31 == qword_8CEEA18 )
    {
      *(_QWORD *)(v29 + 128) = v31;
      if ( *v31 == v32 )
        goto LABEL_44;
    }
    v31 = (_QWORD *)((__int64 (*)(void))unk_3C3D868)();
  }
  *(_QWORD *)(v29 + 128) = v31;
LABEL_44:
  v33 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[78];
  if ( v33 == 0 )
    goto LABEL_61;
  UnityEngine_GameObject__SetActive(v33, 0, 0);
  v34 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[86];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( (UnityEngine_Object__op_Inequality(v34, 0, 0) & 1) != 0 )
  {
    v35 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[86];
    if ( v35 == 0 )
      goto LABEL_61;
    UnityEngine_GameObject__SetActive(v35, 0, 0);
  }
  v36 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[110];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    ((void (*)(void))unk_3C3D3B0)();
  if ( (UnityEngine_Object__op_Inequality(v36, 0, 0) & 1) != 0 )
  {
    v37 = *(_QWORD *)&self->fields._unknown_object_00A2_to_01D7[110];
    if ( v37 == 0 )
      goto LABEL_61;
    UnityEngine_GameObject__SetActive(v37, 0, 0);
  }
  GameModule_HexBehaviour__SyncLegendaryGridEffectWithPriceUi(self);
  v38 = self->fields.isEnemyHex;
  v41 = ToolModule_ManagerBase_object___get_Instance(qword_8D12058, v39, v40);
  gameObject = UnityEngine_Component__get_gameObject(self, 0);
  if ( v41 == 0 )
    goto LABEL_61;
  if ( v38 != 0 )
  {
    GameModule_BattleGameSceneManager__RemoveEnemyStayHex(v41, gameObject, 0);
    v45 = ToolModule_ManagerBase_object___get_Instance(qword_8D12058, v43, v44);
    v46 = UnityEngine_Component__get_gameObject(self, 0);
    if ( v45 != 0 )
    {
      GameModule_BattleGameSceneManager__AddEnemyHasHex(v45, v46, 0);
      return;
    }
    goto LABEL_61;
  }
  GameModule_BattleGameSceneManager__RemovePlayerStayHex(v41, gameObject, 0);
  v49 = ToolModule_ManagerBase_object___get_Instance(qword_8D12058, v47, v48);
  v50 = UnityEngine_Component__get_gameObject(self, 0);
  if ( v49 == 0 )
    goto LABEL_61;
  GameModule_BattleGameSceneManager__AddPlayerHasHex(v49, v50, 0);
}
