int GameModule_SynergyEffectManager__InternalCalculateDamage(
        void *self,
        int originalAttack,
        unsigned __int8 isEnemy,
        int fetterCount,
        int requiredCount,
        const MethodInfo *method)
{
  int result; // w0
  float v7; // s0
  int v8; // w8

  result = originalAttack;
  if ( fetterCount >= requiredCount )
  {
    v7 = (float)originalAttack * 0.5;
    v8 = (int)v7;
    if ( v7 == INFINITY )
      v8 = 0x80000000;
    return v8 + originalAttack;
  }
  return result;
}
