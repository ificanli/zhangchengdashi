float __fastcall GameModule_RoleBehaviour__get_WebGLNavigationRadius(__int64 a1)
{
  float result; // s0

  result = *(float *)(a1 + 448);
  if ( result <= 0.01 )
    return 0.35;
  return result;
}
