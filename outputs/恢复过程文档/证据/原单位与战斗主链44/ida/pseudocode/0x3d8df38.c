__int64 __fastcall GameModule_RoleBehaviour__AddImmediateHp(__int64 a1, unsigned int a2)
{
  __int64 v2; // x8

  v2 = *(_QWORD *)(a1 + 64);
  if ( v2 != 0 && *(_DWORD *)(v2 + 24) != *(_DWORD *)(v2 + 28) )
    return GameModule_RoleBehaviour__AddHp(a1, a2);
  return a1;
}
