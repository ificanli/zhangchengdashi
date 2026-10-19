float __fastcall GameModule_RoleBehaviour__GetFollowerEntityMoveSpeed(__int64 a1, float a2)
{
  float v2; // s1

  v2 = *(float *)(a1 + 184);
  if ( v2 > 0.001 )
    a2 = a2 / v2;
  return a2 * 0.8;
}
