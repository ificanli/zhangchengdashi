void GameModule_GameManager__FetterSteerEnd(void *self, void *obj, const MethodInfo *method)
{
  void *Instance; // x0
  __int64 v4; // x1
  __int64 v5; // x2
  __int64 v6; // x0
  _BYTE v7[8]; // [xsp+8h] [xbp-18h] BYREF

  if ( (byte_8FFD89C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD89C = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance((const MethodInfo *)qword_8D17890);
  if ( Instance == nullptr )
    goto LABEL_10;
  if ( (SDKModule_ABTestManager__get_GameCenterIsBTest(Instance, 0) & 1) == 0 )
    return;
  v6 = ToolModule_ManagerBase_object___get_Instance(qword_8D12190, v4, v5);
  if ( v6 == 0 )
LABEL_10:
    il2cpp_codegen_raise_null_reference_exception();
  v7[0] = SDKModule_GameCenterManager__AllowGameCenter(v6, 0);
  Cysharp_Threading_Tasks_UniTaskVoid__Forget(v7, 0);
}
