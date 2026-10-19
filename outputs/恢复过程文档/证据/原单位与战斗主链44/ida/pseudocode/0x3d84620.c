float __fastcall GameModule_RoleBehaviour__get_WebGLNavigationMoveSpeed(__int64 a1)
{
  float result; // s0
  __int64 v2; // x8

  result = *(float *)(a1 + 444);
  if ( result <= 0.01 )
  {
    v2 = *(_QWORD *)(a1 + 64);
    if ( v2 != 0 )
      return *(float *)(v2 + 40) * 0.8;
    else
      return 0.0;
  }
  return result;
}
