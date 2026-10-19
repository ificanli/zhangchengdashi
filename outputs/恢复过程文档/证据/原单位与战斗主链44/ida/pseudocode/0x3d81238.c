__int64 __fastcall GameModule_RoleBehaviour__ClearDizzyState(__int64 a1)
{
  __int64 v2; // x20
  __int64 result; // x0
  __int64 v4; // x20

  if ( (byte_8FFD4AB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD4AB = 1;
  }
  *(_BYTE *)(a1 + 404) = 0;
  *(_DWORD *)(a1 + 408) = 0;
  v2 = *(_QWORD *)(a1 + 416);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(v2, 0, 0);
  if ( (result & 1) != 0 )
  {
    v4 = *(_QWORD *)(a1 + 416);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__Destroy(v4, 0);
    *(_QWORD *)(a1 + 416) = 0;
  }
  return result;
}
