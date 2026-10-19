void ljzs_lt_GameStart__InitConfig(void *self, void *resources, const MethodInfo *method)
{
  __int64 Instance; // x0
  __int64 v6; // x0
  __int64 v7; // x1
  __int64 v8; // x2

  Instance = ljzs_lt_ConfigMgr__get_Instance(self, resources, method);
  if ( Instance == 0
    || (v6 = ljzs_lt_ConfigMgr__SetConfigABRes(Instance, resources), ljzs_lt_ConfigMgr__get_Instance(v6, v7, v8) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  ljzs_lt_ConfigMgr__Initialize();
  GameFramework_Base_IGameStart__InitConfigOver(self, 0);
}
