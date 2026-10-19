__int64 __fastcall GameModule_RoleBehaviour__UpdateRoleTargetHexDistance(__int64 a1, __int64 a2)
{
  __int64 transform; // x0
  long double position; // q8
  long double v7; // q1
  long double v8; // q9
  long double v9; // q2
  long double v10; // q10
  HexManager_HexCoord_o *v11; // x21
  __int64 v12; // x0
  long double v13; // q8
  long double v14; // q1
  long double v15; // q9
  long double v16; // q2
  long double v17; // q10
  HexManager_HexCoord_o *v18; // x21
  HexManager_HexCoord_o v19; // x21
  HexManager_HexCoord_o v20; // x22
  ZCDS_Int32 v21; // w0
  __int64 v22; // x22
  ZCDS_Int32 v23; // w21
  ZCDS_Int32 v24; // w8
  HexManager_HexCoord_o *v25; // [xsp+8h] [xbp-58h] BYREF
  HexManager_HexCoord_o *v26; // [xsp+18h] [xbp-48h] BYREF

  if ( (byte_8FFD45B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD45B = 1;
  }
  v26 = nullptr;
  v25 = nullptr;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
  {
    *(_QWORD *)(a1 + 280) = 0;
    *(_DWORD *)(a1 + 288) = -1;
    return 0;
  }
  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform != 0 )
  {
    position = UnityEngine_Transform__get_position(transform, 0);
    v8 = v7;
    v10 = v9;
    if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE81E8);
    if ( (HexManager__TryGetHexAt(&v26, 0, position, v8, v10) & 1) == 0 )
      goto LABEL_22;
    v11 = v26;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v11, 0, 0) & 1) != 0 )
      goto LABEL_22;
    if ( a2 != 0 )
    {
      v12 = UnityEngine_Component__get_transform(a2, 0);
      if ( v12 != 0 )
      {
        v13 = UnityEngine_Transform__get_position(v12, 0);
        v15 = v14;
        v17 = v16;
        if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE81E8);
        if ( (HexManager__TryGetHexAt(&v25, 0, v13, v15, v17) & 1) == 0 )
          goto LABEL_22;
        v18 = v25;
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Equality(v18, 0, 0) & 1) != 0 )
        {
LABEL_22:
          *(_QWORD *)(a1 + 280) = a2;
          *(_DWORD *)(a1 + 288) = -1;
          return 1;
        }
        if ( v26 != nullptr && v25 != nullptr )
        {
          v19 = v26[4];
          v20 = v25[4];
          if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE81E8);
          v21 = HexManager__HexDistance(v19, v20, nullptr);
          v22 = *(_QWORD *)(a1 + 280);
          v23 = v21;
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(v22, a2, 0) & 1) != 0 || (v24 = *(_DWORD *)(a1 + 288)) < 0 )
          {
            *(_QWORD *)(a1 + 280) = a2;
LABEL_35:
            *(_DWORD *)(a1 + 288) = v23;
            return 1;
          }
          if ( v23 <= v24 + 1 )
          {
            if ( v23 >= v24 )
              return 1;
            goto LABEL_35;
          }
          return 0;
        }
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
