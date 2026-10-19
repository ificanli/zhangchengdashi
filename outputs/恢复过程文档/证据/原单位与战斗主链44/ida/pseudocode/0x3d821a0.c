__int64 __fastcall GameModule_RoleBehaviour__IsRoleTargetValidInRange(__int64 a1, _BYTE *a2, float a3)
{
  __int64 v6; // x10
  __int64 v7; // x8
  float v8; // s0
  float v9; // s10
  __int64 transform; // x0
  float v11; // s8
  float v12; // s2
  float v13; // s9
  __int64 v14; // x0
  long double position; // q0
  float v16; // s2

  if ( (byte_8FFD45A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECB08);
    byte_8FFD45A = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, 0, 0) & 1) != 0 )
    return 0;
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(a2, a1, 0) & 1) != 0 )
    return 0;
  if ( a2 != nullptr )
  {
    if ( a2[33] != 0 )
      return 0;
    v6 = *((unsigned __int8 *)off_8CECB08 + 304);
    if ( *(unsigned __int8 *)(*(_QWORD *)a2 + 304LL) < (unsigned int)v6 )
      return 0;
    if ( *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)a2 + 200LL) + 8 * v6 - 8) != off_8CECB08 )
      a2 = nullptr;
    if ( a2 == nullptr || a2[396] != 0 )
      return 0;
    v7 = *(_QWORD *)(a1 + 64);
    v8 = a3;
    if ( v7 != 0 )
      v8 = *(float *)(v7 + 36);
    v9 = v8 >= a3 ? v8 : a3;
    transform = UnityEngine_Component__get_transform(a2, 0);
    if ( transform != 0 )
    {
      LODWORD(v11) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
      v13 = v12;
      v14 = UnityEngine_Component__get_transform(a1, 0);
      if ( v14 != 0 )
      {
        position = UnityEngine_Transform__get_position(v14, 0);
        if ( (float)((float)((float)(v13 - v16) * (float)(v13 - v16))
                   + (float)((float)((float)(v11 - *(float *)&position) * (float)(v11 - *(float *)&position)) + 0.0)) <= (float)(v9 * v9) )
          return GameModule_RoleBehaviour__UpdateRoleTargetHexDistance(a1, a2);
        return 0;
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
