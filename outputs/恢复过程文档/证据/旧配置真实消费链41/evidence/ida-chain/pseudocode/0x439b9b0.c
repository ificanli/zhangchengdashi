void stage41_ljzs_lt_GameStart__InitConfig(void *a0, void *a1, void *a2)
{
  void *Instance; // x0
  void *v6; // x2
  void *v7; // x0
  void *v8; // x0
  void *v9; // x1

  Instance = ljzs_lt_ConfigMgr__get_Instance(a0);
  if ( Instance == nullptr
    || (ljzs_lt_ConfigMgr__SetConfigABRes(Instance, a1, v6), (v8 = ljzs_lt_ConfigMgr__get_Instance(v7)) == nullptr) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  ljzs_lt_ConfigMgr__Initialize(v8, v9);
  GameFramework_Base_IGameStart__InitConfigOver(a0, 0);
}
