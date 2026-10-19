__int64 __fastcall GameModule_RoleBehaviour__AddTempHp(__int64 result, float a2)
{
  __int64 v2; // x8
  int v3; // w9
  int v4; // w10
  int v5; // w9
  float v6; // s0
  int v7; // w10
  int v8; // w9
  int v9; // w10
  int v10; // w11
  int v11; // w10

  v2 = *(_QWORD *)(result + 64);
  if ( v2 != 0 )
  {
    if ( a2 >= 0.0 )
    {
      v5 = *(_DWORD *)(v2 + 28);
      v6 = (float)v5 * a2;
      v7 = (int)v6;
      if ( v6 == INFINITY )
        v7 = 0x80000000;
      v8 = v7 + v5;
      v9 = v7 + *(_DWORD *)(v2 + 24);
      if ( v9 <= v8 )
        v10 = v9;
      else
        v10 = v8;
      if ( v9 >= 0 )
        v11 = v10;
      else
        v11 = 0;
      *(_DWORD *)(v2 + 24) = v11;
      *(_DWORD *)(v2 + 28) = v8;
    }
    else
    {
      v3 = *(_DWORD *)(result + 704);
      v4 = *(_DWORD *)(v2 + 24);
      *(_DWORD *)(v2 + 28) = v3;
      if ( v4 > v3 )
        *(_DWORD *)(v2 + 24) = v3;
    }
    return (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)result + 680LL))(
             result,
             *(_QWORD *)(*(_QWORD *)result + 688LL));
  }
  return result;
}
