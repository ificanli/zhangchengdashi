__int64 __fastcall GameModule_RoleBehaviour__RecycleOnBattleEnd(_BYTE *a1)
{
  __int64 gameObject; // x0
  void *Instance; // x20
  __int64 v4; // x0

  if ( (byte_8FFD4A3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12338);
    byte_8FFD4A3 = 1;
  }
  if ( a1[636] == 0 )
    (*(void (__fastcall **)(_BYTE *, _QWORD))(*(_QWORD *)a1 + 936LL))(a1, *(_QWORD *)(*(_QWORD *)a1 + 944LL));
  a1[328] = 0;
  GameModule_RoleBehaviour__SetAiCanMove((__int64)a1, 0);
  gameObject = UnityEngine_Component__get_gameObject(a1, 0);
  if ( gameObject == 0
    || (UnityEngine_GameObject__SetActive(gameObject, 0, 0),
        Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12338),
        v4 = UnityEngine_Component__get_gameObject(a1, 0),
        Instance == nullptr) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  return AssetsModule_ObjPoolManager__Recycle(Instance, v4, 0);
}
