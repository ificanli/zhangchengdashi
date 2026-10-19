void GameModule_GameManager__CloseLoadPanel(void *self, void *obj, const MethodInfo *method)
{
  __int64 v4; // x0
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 Instance; // x0

  if ( (byte_8FFD89D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12348);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDA10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_8FFD89D = 1;
  }
  *((_BYTE *)self + 112) = 1;
  v4 = **((_QWORD **)off_8CECCD8 + 23);
  if ( v4 == 0 )
    goto LABEL_10;
  DBTSDK_SDKToolManager__ReportGameInteractive(v4, qword_8D4ECC0, 0);
  if ( *((_BYTE *)self + 33) == 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12348, v5, v6);
    if ( Instance == 0 )
LABEL_10:
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_PacksTipManager__FirstPopPacks(Instance, 0);
  }
  if ( *((_DWORD *)off_8CEDA10 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEDA10);
  DBT_StartupGift_StartupGiftSystem__CheckAndGrantGift(0);
}
