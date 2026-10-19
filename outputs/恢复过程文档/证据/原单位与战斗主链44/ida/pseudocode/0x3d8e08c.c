__int64 __fastcall GameModule_RoleBehaviour__ImmediateDead(__int64 a1)
{
  void *Instance; // x19
  __int64 transform; // x0
  long double position; // q0

  if ( (byte_8FFD4B1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12128);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D57368);
    byte_8FFD4B1 = 1;
  }
  (*(void (__fastcall **)(__int64, _QWORD, _QWORD))(*(_QWORD *)a1 + 696LL))(a1, 0, *(_QWORD *)(*(_QWORD *)a1 + 704LL));
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12128);
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform == 0 || (position = UnityEngine_Transform__get_position(transform, 0), Instance == nullptr) )
    il2cpp_codegen_raise_null_reference_exception();
  return AssetsModule_EffectManager__ShowEffect(Instance, qword_8D57368, 0, position);
}
