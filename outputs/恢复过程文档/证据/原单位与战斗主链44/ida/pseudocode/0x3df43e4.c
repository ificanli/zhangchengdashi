void __fastcall GameModule_BattleGameSceneManager__GetRandomPositionOnHexEdge(__int64 a1, __int64 a2, __int64 a3)
{
  long double SpawnHexSize; // q0
  __int64 v5; // x0
  __int64 v6; // x8
  int v7; // w21
  unsigned int v8; // w20
  unsigned int v9; // w10
  __int64 v10; // x0
  int v11; // w1
  __int64 v12; // x19
  __int64 v13; // x0

  SpawnHexSize = GameModule_BattleGameSceneManager__GetSpawnHexSize(a1, a2, a3);
  ((void (__fastcall *)(__int64, long double))GameModule_BattleGameSceneManager__EnsureSpawnHexVertices)(
    a1,
    SpawnHexSize);
  if ( *(_QWORD *)(a1 + 56) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v5 = UnityEngine_Random__Range(0);
  v6 = *(_QWORD *)(a1 + 56);
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v7 = *(_DWORD *)(v6 + 24);
  v8 = v5;
  if ( byte_8FFCFFD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFCFFD = 1;
    v6 = *(_QWORD *)(a1 + 56);
  }
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v9 = *(_DWORD *)(v6 + 24);
  if ( v8 >= v9 )
  {
    v5 = ((__int64 (*)(void))unk_3C3D4D4)();
  }
  else if ( (int)(v8 + 1) % v7 < v9 )
  {
    sub_82E61B0(0, 0.0, 1.0);
    sub_82E61B0(0, 0.0, 1.0);
    return;
  }
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v5);
  if ( v11 != 1 )
    sub_3CE73C4(v10);
  v12 = *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v10);
  ((void (*)(void))__cxa_end_catch)();
  if ( v12 != 0 )
  {
    sub_3C38CF8(v12);
    v13 = sub_3C38CF8(v12);
    ((void (__fastcall *)(__int64))unk_35BC500)(v13);
    JUMPOUT(0x3DF45F8);
  }
}
