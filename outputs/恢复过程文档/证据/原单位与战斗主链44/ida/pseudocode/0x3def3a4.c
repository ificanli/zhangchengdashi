void __fastcall GameModule_BattleGameSceneManager__CreatBothMainTower(__int64 a1)
{
  void *Instance; // x20
  void *v3; // x21
  void *v4; // x20
  void *v5; // x21

  if ( (byte_8FFD788 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD84E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D23E00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D624D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D624D8);
    byte_8FFD788 = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  v3 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8);
  System_Action_object____ctor(v3, a1, qword_8D23E00, 0);
  if ( Instance == nullptr
    || (EventModule_EventManager__StartListening(Instance, (void *)qword_8D624D8, v3, nullptr),
        v4 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148),
        v5 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD84E8),
        System_Action_object____ctor(v5, a1, qword_8D23E00, 0),
        v4 == nullptr) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  EventModule_EventManager__StartListening(v4, (void *)qword_8D624D0, v5, nullptr);
}
