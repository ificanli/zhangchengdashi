void sub_854F458(void *self, float transitionHeight, float quality, const MethodInfo *method)
{
  bool v4; // nf
  float v5; // s0
  float v6; // s2

  v4 = transitionHeight < 0.0;
  v5 = fminf(transitionHeight, 1.0);
  v6 = fminf(quality, 1.0);
  if ( v4 )
    v5 = 0.0;
  *(float *)self = v5;
  if ( quality < 0.0 )
    v6 = 0.0;
  *((_DWORD *)self + 1) = 0;
  *((_WORD *)self + 6) = 0;
  *((_QWORD *)self + 2) = 0;
  *((_BYTE *)self + 32) = 1;
  *((_DWORD *)self + 9) = 1;
  *((_BYTE *)self + 40) = 1;
  *((float *)self + 2) = v6;
  *((_QWORD *)self + 3) = 0x100000000LL;
  *(_QWORD *)((char *)self + 44) = 0x100000001LL;
}
