void __fastcall GameModule_RoleBehaviour__CheckReleaseSkill(__int64 a1, __int64 a2, __int64 a3, __int64 a4)
{
  _BYTE **v5; // x0
  __int64 v6; // x8
  _QWORD *v7; // x0
  __int64 v8; // x8
  float time; // s0
  int v10; // w8
  __int64 v11; // x8
  __int64 v12; // x8
  __int64 v13; // x8
  _QWORD *Instance; // x0
  __int64 v15; // x8

  if ( (byte_8FFD479 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB2B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9228);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53840);
    byte_8FFD479 = 1;
  }
  if ( *(_BYTE *)(a1 + 376) == 0 && *(_DWORD *)(a1 + 316) == 6 && *(float *)(a1 + 292) != 0.0 )
  {
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
    if ( byte_8FFD1AB == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5E20);
      byte_8FFD1AB = 1;
    }
    v5 = (_BYTE **)off_8CE5E20;
    if ( *((_DWORD *)off_8CE5E20 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE5E20);
      v5 = (_BYTE **)off_8CE5E20;
    }
    if ( *v5[23] != 0 && *(_BYTE *)(a1 + 300) != 0 )
    {
      if ( *(_BYTE *)(a1 + 32) == 0 )
      {
        v11 = *(_QWORD *)(a1 + 64);
        if ( v11 != 0
          && *(_DWORD *)(v11 + 80) == 3
          && (GameModule_TrainingGroundManager__get_IsInGuidedGame(0) & 1) != 0 )
        {
          v12 = **((_QWORD **)off_8CD9228 + 23);
          if ( v12 == 0 )
            goto LABEL_37;
          v13 = *(_QWORD *)(v12 + 48);
          if ( v13 == 0 )
            goto LABEL_37;
          if ( *(_DWORD *)(v13 + 52) == 0 )
            return;
        }
      }
      v6 = *(_QWORD *)(a1 + 64);
      if ( v6 == 0 )
        goto LABEL_37;
      if ( (System_String__op_Equality(*(_QWORD *)(v6 + 16), qword_8D53840, 0, a4) & 1) == 0 )
      {
LABEL_22:
        *(_WORD *)(a1 + 300) = 0;
        time = UnityEngine_Time__get_time(0);
        v10 = *(unsigned __int8 *)(a1 + 32);
        *(float *)(a1 + 296) = time + *(float *)(a1 + 292);
        if ( v10 != 0 )
          GameModule_RoleBehaviour__EnemyEmitSkill(a1);
        else
          GameModule_RoleBehaviour__PlayerEmitSkill(a1);
        return;
      }
      if ( *(_BYTE *)(a1 + 32) == 0 )
      {
        Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
        if ( Instance == nullptr )
          goto LABEL_37;
        v15 = Instance[23];
        if ( v15 == 0 )
          goto LABEL_37;
        if ( *(int *)(v15 + 24) < 1 )
          return;
        if ( *(_BYTE *)(a1 + 32) == 0 )
          goto LABEL_22;
      }
      v7 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12058);
      if ( v7 != nullptr )
      {
        v8 = v7[22];
        if ( v8 != 0 )
        {
          if ( *(int *)(v8 + 24) < 1 )
            return;
          goto LABEL_22;
        }
      }
LABEL_37:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
}
