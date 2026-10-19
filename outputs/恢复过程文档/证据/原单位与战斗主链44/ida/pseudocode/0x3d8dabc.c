void __fastcall GameModule_RoleBehaviour__ReduceTempSpeed(__int64 a1, float a2)
{
  __int64 v2; // x8
  float v3; // s0
  float v4; // s2
  float v5; // s0
  float v6; // s1
  bool v7; // cc
  float v8; // s2
  float v9; // s2

  v2 = *(_QWORD *)(a1 + 64);
  if ( v2 != 0 )
  {
    if ( a2 >= 0.0 )
    {
      v4 = *(float *)(a1 + 236);
      v5 = (float)(1.0 - a2) * *(float *)(a1 + 240);
      v6 = *(float *)(v2 + 40);
      v7 = v4 <= 0.0;
      v8 = v4 + -0.1;
      if ( v7 )
        v8 = 0.0;
      v9 = v6 - v8;
      if ( v5 >= v9 )
        v5 = v9;
      v3 = v6 - fmaxf(v5, 0.0);
    }
    else
    {
      v3 = *(float *)(a1 + 236);
    }
    *(float *)(v2 + 40) = v3;
    GameModule_RoleBehaviour__SetAiSPeed(a1, v3);
  }
}
