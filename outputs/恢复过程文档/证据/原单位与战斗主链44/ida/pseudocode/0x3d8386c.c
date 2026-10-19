__int64 __fastcall GameModule_RoleBehaviour__RemoveLinkPact(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  __int64 result; // x0
  __int64 v6; // x0

  if ( (byte_8FFD466 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DD98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDA8);
    byte_8FFD466 = 1;
  }
  v4 = *(_QWORD *)(a1 + 384);
  if ( v4 == 0 )
    goto LABEL_8;
  result = System_Collections_Generic_List_object___Contains(v4, a2, qword_8D0DD98);
  if ( (result & 1) != 0 )
  {
    v6 = *(_QWORD *)(a1 + 384);
    if ( v6 != 0 )
      return System_Collections_Generic_List_object___Remove(v6, a2, qword_8D0DDA8);
LABEL_8:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return result;
}
