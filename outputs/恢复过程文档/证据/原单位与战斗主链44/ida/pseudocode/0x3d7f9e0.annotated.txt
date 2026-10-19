long double __fastcall GameModule_RoleBehaviour__GetScaledRadius(__int64 a1, long double a2)
{
  long double v2; // q8
  __int64 transform; // x0
  float v4; // s0

  v2 = a2;
  if ( *(float *)&a2 >= 0.0 )
  {
    transform = UnityEngine_Component__get_transform(a1, 0);
    if ( transform == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    UnityEngine_Transform__get_localScale(transform, 0);
    *(float *)&v2 = (float)(0.5 / v4) * *(float *)&v2;
  }
  return v2;
}
