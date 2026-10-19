float __fastcall GameModule_SynergyEffectManager__InternalCalculateProductionSpeed(
        float result,
        __int64 a2,
        __int64 a3,
        int a4,
        int a5)
{
  if ( a4 >= a5 )
    return result + (float)(result * -0.1);
  return result;
}
