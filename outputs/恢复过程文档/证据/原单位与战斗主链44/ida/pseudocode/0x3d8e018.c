float __fastcall GameModule_RoleBehaviour__AddTempRange(__int64 a1, float result)
{
  __int64 v2; // x8
  int v3; // w9
  float v4; // s0
  float v5; // s1

  v2 = *(_QWORD *)(a1 + 64);
  if ( v2 != 0 )
  {
    if ( result < 0.0 )
    {
      *(_DWORD *)(a1 + 156) = 0;
      return result;
    }
    v3 = *(_DWORD *)(a1 + 72);
    *(float *)(a1 + 156) = result;
    if ( v3 == 1 )
    {
      v5 = *(float *)(a1 + 152);
      v4 = result + 1.0;
    }
    else
    {
      if ( v3 != 0 )
        return result;
      v4 = result + 1.0;
      v5 = fmaxf(*(float *)(a1 + 152), 1.5);
    }
    result = v4 * v5;
    *(float *)(v2 + 36) = result;
  }
  return result;
}
