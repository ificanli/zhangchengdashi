__int64 __fastcall GameModule_RoleBehaviour__StealthAddAtkAndEnd(__int64 result, int *a2)
{
  float v2; // s0
  int v3; // w8

  *(_BYTE *)(result + 396) = 0;
  v2 = *(float *)(result + 400) * (float)*a2;
  v3 = (int)v2;
  if ( v2 == INFINITY )
    v3 = 0x80000000;
  *a2 = v3;
  return result;
}
