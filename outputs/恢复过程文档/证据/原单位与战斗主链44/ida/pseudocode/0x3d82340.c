float __fastcall GameModule_RoleBehaviour__GetFindTargetInterval(__int64 a1)
{
  float result; // s0
  __int64 v2; // x8

  result = 0.15;
  if ( *(_DWORD *)(a1 + 204) != 1 && *(float *)(a1 + 292) <= 0.0 )
  {
    v2 = *(_QWORD *)(a1 + 64);
    if ( v2 == 0 || *(_DWORD *)(v2 + 80) != 3 )
      return 0.25;
  }
  return result;
}
