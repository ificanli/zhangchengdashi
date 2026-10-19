__int64 __fastcall GameModule_RoleBehaviour__RemoveHPUI(__int64 a1, __int64 a2)
{
  __int64 GameGlobalConfig; // x0
  void *Instance; // x20
  __int64 transform; // x0
  __int64 result; // x0
  __int64 v7; // x20
  void *v8; // x0

  if ( (byte_8FFD49D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD49D = 1;
  }
  GameGlobalConfig = GameConfigModule_GameConfigManager__get_GameGlobalConfig(0, a2);
  if ( GameGlobalConfig == 0 )
    goto LABEL_13;
  if ( *(_BYTE *)(GameGlobalConfig + 18) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12168);
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( Instance != nullptr )
      return GameModule_FloatingTextManager__RemoveTextByTarget(Instance, transform, 0);
LABEL_13:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v7 = *(_QWORD *)(a1 + 40);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(v7, 0, 0);
  if ( (result & 1) != 0 )
  {
    v8 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D124B8);
    if ( v8 == nullptr )
      goto LABEL_13;
    result = UIModuleO_UIHUDManager__RecycleHealthBatHUD(v8, *(_QWORD *)(a1 + 40), 0);
  }
  *(_QWORD *)(a1 + 40) = 0;
  return result;
}
