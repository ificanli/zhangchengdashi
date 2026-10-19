void __fastcall GameModule_RoleBehaviour__SetRvoControllerEnable(__int64 a1, char a2)
{
  long double v2; // q8
  int v3; // w1

  v3 = a2 & 1;
  *(_BYTE *)(a1 + 554) = v3;
  if ( v3 != 0 )
    *(float *)&v2 = 0.25;
  else
    *(float *)&v2 = 0.5;
  GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, v3);
  GameModule_RoleBehaviour__SetAiRadius(a1, v2);
}
