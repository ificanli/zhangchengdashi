float __fastcall GameModule_RoleBehaviour__AddTempBuildingDamageMultiplier(__int64 a1, float result)
{
  if ( *(_QWORD *)(a1 + 64) != 0 )
  {
    result = fmaxf(result, 0.0);
    *(float *)(a1 + 160) = result;
  }
  return result;
}
