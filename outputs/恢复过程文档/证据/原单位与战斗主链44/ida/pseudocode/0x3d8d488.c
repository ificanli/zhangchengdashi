__int64 __fastcall GameModule_RoleBehaviour__OnDestroy(int32x2_t *a1, __int64 a2, __int64 a3)
{
  __int64 Instance; // x0
  int32x2_t v5; // d0
  int v6; // w8
  unsigned __int64 v7; // x20
  __int64 v8; // x1
  unsigned __int64 v9; // x20

  if ( (byte_8FFD4A5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD4A5 = 1;
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (SDKModule_ABTestManager__get_UnitCollisionEnableIsBTest(Instance, 0) & 1) != 0 )
    GameModule_RoleBehaviour__ApplyOccupancyPenalty((__int64)a1, 0);
  v5.n64_u64[0] = GameModule_RoleBehaviour__SetPathfindingEnabled(a1, 0).n64_u64[0];
  v6 = a1[79].n64_u8[4];
  a1[79].n64_u8[5] = 1;
  if ( v6 == 0 )
    (*(void (__fastcall **)(int32x2_t *, _QWORD, double))(a1->n64_u64[0] + 936))(
      a1,
      *(_QWORD *)(a1->n64_u64[0] + 944),
      v5.n64_f64[0]);
  v7 = a1[17].n64_u64[0];
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v7, 0, 0) & 1) != 0 )
  {
    v9 = a1[17].n64_u64[0];
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__Destroy(v9, 0);
    a1[17].n64_u64[0] = 0;
  }
  return GameModule_RoleBehaviour__RemoveHPUI((__int64)a1, v8);
}
