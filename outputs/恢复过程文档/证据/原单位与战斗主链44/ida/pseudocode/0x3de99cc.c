void __fastcall GameModule_BattleGameManager___ctor(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x8
  __int64 v4; // x20

  if ( (byte_8FFD74C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFCF28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3090);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4CD10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D541B8);
    byte_8FFD74C = 1;
  }
  v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9810);
  System_Collections_Generic_Dictionary_int__BattleGameManager_AnimationPauseSnapshot____ctor(v2, qword_8CFCF28);
  *(_QWORD *)(a1 + 32) = v2;
  v3 = qword_8D541B8;
  *(_DWORD *)(a1 + 104) = 1084227584;
  *(_QWORD *)(a1 + 72) = v3;
  v4 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3090, 3);
  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray(v4, qword_8D4CD10, 0);
  *(_QWORD *)(a1 + 224) = v4;
  *(_DWORD *)(a1 + 308) = 1065353216;
  ToolModule_ManagerBase_object____ctor((void *)a1, (const MethodInfo *)qword_8D12040);
}
