float __fastcall GameModule_RoleBehaviour__get_WebGLNavigationAttackRange(__int64 a1)
{
  __int64 v1; // x8

  v1 = *(_QWORD *)(a1 + 64);
  if ( v1 != 0 )
    return *(float *)(v1 + 36);
  else
    return 0.0;
}
