__int64 __fastcall GameModule_SynergyEffectManager__HumanFetter4_DamageReduction(
        __int64 a1,
        int a2,
        _DWORD *a3,
        char a4,
        float a5)
{
  __int64 v10; // x10
  void *Instance; // x0
  __int64 v12; // x0
  float v13; // s0
  int v14; // w8

  if ( (byte_8FFD856 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECB08);
    byte_8FFD856 = 1;
  }
  if ( *(_BYTE *)(a1 + 32) != 0 && a3 != nullptr )
  {
    v10 = *((unsigned __int8 *)off_8CECB08 + 304);
    if ( *(unsigned __int8 *)(*(_QWORD *)a3 + 304LL) >= (unsigned int)v10
      && *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)a3 + 200LL) + 8 * v10 - 8) == off_8CECB08
      && a3[50] == 2
      && (int)GameModule_SynergyEffectManager__GetFetterCount(a1, 2, a4 & 1) >= 4 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      v12 = GameModule_BattleGameSceneManager__GetNearRole((__int64)Instance, a4 & 1, (__int64)a3, -1, a5);
      if ( v12 != 0 && *(int *)(v12 + 24) >= 1 )
      {
        v13 = (float)a2 * 0.2;
        v14 = (int)v13;
        if ( v13 == INFINITY )
          v14 = 0x80000000;
        a2 -= v14;
      }
    }
  }
  return (unsigned int)a2;
}
