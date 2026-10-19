__int64 __fastcall GameModule_RoleBehaviour__ClearFreezeState(__int64 a1)
{
  __int64 v2; // x20
  __int64 result; // x0
  __int64 v4; // x0

  if ( (byte_8FFD4AC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD4AC = 1;
  }
  *(_BYTE *)(a1 + 224) = 0;
  *(_DWORD *)(a1 + 228) = 0;
  v2 = *(_QWORD *)(a1 + 216);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(v2, 0, 0);
  if ( (result & 1) != 0 )
  {
    v4 = *(_QWORD *)(a1 + 216);
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    return UnityEngine_GameObject__SetActive(v4, 0, 0);
  }
  return result;
}
