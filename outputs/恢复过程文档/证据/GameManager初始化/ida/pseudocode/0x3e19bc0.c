void GameModule_GameManager__StartCoreGame(void *self, void *obj, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x19
  __int64 v5; // x20
  __int64 v6; // x0
  __int64 v7; // x21
  __int64 v8; // x19
  __int64 v9; // x20
  __int64 v10; // x19
  __int64 v11; // x1
  __int64 v12; // x2
  __int64 Instance; // x0

  if ( (byte_8FFD895 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE4A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D120F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D47520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF2EC8);
    byte_8FFD895 = 1;
  }
  v3 = off_8CF2EC8;
  if ( *((_DWORD *)off_8CF2EC8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CF2EC8);
    v3 = off_8CF2EC8;
  }
  v4 = *(_QWORD *)(v3[23] + 8LL);
  if ( v4 == 0 )
  {
    if ( *((_DWORD *)v3 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v3);
      v3 = off_8CF2EC8;
    }
    v5 = *(_QWORD *)v3[23];
    v4 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CDB208, obj, method);
    System_Func_bool__object____ctor(v4, v5, qword_8D47520, 0);
    *(_QWORD *)(*((_QWORD *)off_8CF2EC8 + 23) + 8LL) = v4;
  }
  v6 = System_Delegate__Combine(0, v4, 0);
  if ( v6 == 0 )
    goto LABEL_12;
  v7 = qword_8CDB208;
  v8 = v6;
  v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v6, qword_8CDB208);
  if ( v9 == 0 )
  {
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v8, v7);
LABEL_12:
    v9 = 0;
  }
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE4A10);
  GameModule_BattleContext___ctor(v10, 1, 0, v9, 0, 0, 0);
  if ( v10 == 0
    || (*(_DWORD *)(v10 + 64) = 0,
        (Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D120F8, v11, v12)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  GameModule_CoreGameManager__StartGame(Instance, v10, 0);
}
