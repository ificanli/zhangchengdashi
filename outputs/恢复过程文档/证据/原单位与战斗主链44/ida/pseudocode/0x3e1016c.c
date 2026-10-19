void __fastcall GameModule_SynergyEffectManager___ctor(_BYTE *a1, __int64 a2, __int64 a3)
{
  __int64 Instance; // x0

  if ( (byte_8FFD858 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12458);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD858 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  a1[32] = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1;
  ToolModule_ManagerBase_object____ctor(a1, (const MethodInfo *)qword_8D12458);
}
