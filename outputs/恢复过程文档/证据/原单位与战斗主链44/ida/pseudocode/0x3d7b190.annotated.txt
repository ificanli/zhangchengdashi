__int64 __fastcall GameModule_RoleBehaviour__PercentRestoreHp(__int64 result)
{
  __int64 v1; // x8

  v1 = *(_QWORD *)(result + 64);
  if ( v1 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_DWORD *)(v1 + 24) != *(_DWORD *)(v1 + 28) )
    return GameModule_RoleBehaviour__AddHp();
  return result;
}
