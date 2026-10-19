void GameModule_BattleGameManager__ChangeCoin(void *self, int coinNum, const MethodInfo *method)
{
  void *Instance; // x21
  int v6; // w8
  void *v7; // x0
  int v8; // w8
  int v9; // w21
  int v10; // w8
  int v11; // w8
  void *v12; // x0
  void *v13; // x20
  void *v14; // x0
  __int64 v15; // x0
  int v16; // [xsp+8h] [xbp-48h] BYREF
  int v17; // [xsp+Ch] [xbp-44h] BYREF

  if ( (byte_8FFD73A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5C020);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C128);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6C138);
    byte_8FFD73A = 1;
  }
  if ( coinNum < 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
    if ( byte_8FFD308 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD308 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    if ( coinNum >= 0 )
      v6 = coinNum;
    else
      v6 = -coinNum;
    v17 = v6;
    v7 = (void *)((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v17);
    if ( Instance == nullptr )
LABEL_30:
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(Instance, (void *)qword_8D6C138, v7, nullptr);
    v8 = *((_DWORD *)self + 10);
    v9 = *((_DWORD *)self + 13);
    if ( v8 < -coinNum )
      coinNum = -v8;
    if ( byte_8FFD308 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
      byte_8FFD308 = 1;
    }
    if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA738);
    if ( coinNum >= 0 )
      v10 = coinNum;
    else
      v10 = -coinNum;
    *((_DWORD *)self + 13) = v10 + v9;
  }
  else if ( coinNum != 0 )
  {
    *((_DWORD *)self + 12) += coinNum;
  }
  v11 = *((_DWORD *)self + 10) + coinNum;
  if ( v11 >= 10000000 )
    v11 = 10000000;
  *((_DWORD *)self + 10) = v11 & ~(v11 >> 31);
  v12 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  if ( v12 == nullptr )
    goto LABEL_30;
  EventModule_EventManager__TriggerEvent(v12, (void *)qword_8D5C020, nullptr, nullptr);
  v13 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v16 = *((_DWORD *)self + 10);
  v14 = (void *)((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v16);
  if ( v13 == nullptr )
    goto LABEL_30;
  EventModule_EventManager__TriggerEvent(v13, (void *)qword_8D6C128, v14, nullptr);
  v15 = GameModule_SubGameBuffManager__get_Instance(0);
  if ( v15 == 0 )
    goto LABEL_30;
  GameModule_SubGameBuffManager__OnCoinChanged(v15, 0, *((unsigned int *)self + 10), 0);
}
