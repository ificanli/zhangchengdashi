__int64 __fastcall GameModule_RoleBehaviour__AddTempAtkOffset(__int64 result, float a2)
{
  __int64 v2; // x8
  float v3; // s0
  float v4; // s0
  float v5; // s1
  bool v6; // nf

  v2 = *(_QWORD *)(result + 64);
  if ( v2 != 0 )
  {
    if ( a2 >= 0.0 )
    {
      v4 = *(float *)(v2 + 44) - (float)(*(float *)(v2 + 44) * a2);
      v5 = fminf(v4, 100.0);
      v6 = v4 < 0.0;
      v3 = 0.0;
      if ( !v6 )
        v3 = v5;
    }
    else
    {
      v3 = *(float *)(result + 708);
    }
    *(float *)(v2 + 44) = v3;
  }
  return result;
}
