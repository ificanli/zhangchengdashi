__int64 __fastcall GameModule_RoleBehaviour__LinkPact(__int64 a1, __int64 a2, float a3)
{
  __int64 result; // x0
  __int64 v7; // x8
  _QWORD *v8; // x9
  __int64 v9; // x10

  if ( (byte_8FFD465 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0DD80);
    byte_8FFD465 = 1;
  }
  result = *(_QWORD *)(a1 + 384);
  if ( result == 0 || (v7 = *(_QWORD *)(result + 16), v8 = off_8D0DD80, ++*(_DWORD *)(result + 28), v7 == 0) )
    il2cpp_codegen_raise_null_reference_exception();
  v9 = *(int *)(result + 24);
  if ( (unsigned int)v9 >= *(_DWORD *)(v7 + 24) )
  {
    result = System_Collections_Generic_List_object___AddWithResize(
               result,
               a2,
               *(_QWORD *)(*(_QWORD *)(v8[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(result + 24) = v9 + 1;
    *(_QWORD *)(v7 + 8 * v9 + 32) = a2;
  }
  *(float *)(a1 + 392) = a3;
  return result;
}
