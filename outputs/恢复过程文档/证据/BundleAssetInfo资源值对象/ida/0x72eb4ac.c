__int64 __fastcall sub_72EB4AC(__int64 a1, __int64 a2, __int64 a3)
{
  __int64 result; // x0
  __int64 v7; // x8

  if ( (byte_900A061 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_900A061 = 1;
  }
  *(_BYTE *)(a1 + 64) = 1;
  result = System_Object___ctor(a1, 0);
  *(_QWORD *)(a1 + 16) = a2;
  *(_QWORD *)(a1 + 32) = a3;
  v7 = **((_QWORD **)off_8CEDAE8 + 23);
  *(_DWORD *)(a1 + 48) = 0;
  *(_QWORD *)(a1 + 40) = v7;
  return result;
}
