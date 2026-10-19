__int64 __fastcall GameModule_RoleBehaviour__ApplyHexPosition(__int64 a1, __int64 a2)
{
  __int64 result; // x0
  __int64 v5; // x21
  __int64 v6; // x0

  if ( (byte_8FFD4A8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD4A8 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Equality(a2, 0, 0);
  if ( (result & 1) == 0 )
  {
    v5 = *(_QWORD *)(a1 + 640);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Inequality(a2, v5, 0);
    if ( (result & 1) != 0 )
    {
      v6 = *(_QWORD *)(a1 + 640);
      if ( v6 != 0 )
        GameModule_HexBehaviour__RemoveRole(v6, *(unsigned int *)(a1 + 56));
      if ( a2 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      result = GameModule_HexBehaviour__AddRole(a2, *(unsigned int *)(a1 + 56), *(_BYTE *)(a1 + 32) == 0, a1, 0);
      *(_QWORD *)(a1 + 640) = a2;
    }
  }
  return result;
}
