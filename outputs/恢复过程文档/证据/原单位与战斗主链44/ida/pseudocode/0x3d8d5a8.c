__int64 __fastcall GameModule_RoleBehaviour__SyncCurrentHexCampRegistration(__int64 a1)
{
  __int64 transform; // x0
  long double position; // q8
  long double v4; // q1
  long double v5; // q9
  long double v6; // q2
  long double v7; // q10
  __int64 v8; // x21
  __int64 v9; // x21
  __int64 v10; // x22
  __int64 v11; // x0
  __int64 v12; // x20
  __int64 result; // x0
  __int64 v14; // x8
  __int64 v15; // [xsp+8h] [xbp-48h] BYREF

  if ( (byte_8FFD4A6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD4A6 = 1;
  }
  v15 = 0;
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform == 0 )
    goto LABEL_20;
  position = UnityEngine_Transform__get_position(transform, 0);
  v5 = v4;
  v7 = v6;
  if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE81E8);
  HexManager__TryGetHexAt(&v15, 0, position, v5, v7);
  v8 = *(_QWORD *)(a1 + 640);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v8, 0, 0) & 1) != 0 )
  {
    v9 = *(_QWORD *)(a1 + 640);
    v10 = v15;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v9, v10, 0) & 1) != 0 )
    {
      v11 = *(_QWORD *)(a1 + 640);
      if ( v11 == 0 )
        goto LABEL_20;
      GameModule_HexBehaviour__RemoveRole(v11, *(unsigned int *)(a1 + 56));
    }
  }
  v12 = v15;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Equality(v12, 0, 0);
  v14 = 0;
  if ( (result & 1) == 0 )
  {
    if ( v15 != 0 )
    {
      result = GameModule_HexBehaviour__RefreshRoleCamp();
      v14 = v15;
      goto LABEL_19;
    }
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_19:
  *(_QWORD *)(a1 + 640) = v14;
  return result;
}
