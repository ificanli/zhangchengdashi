float GameModule_RoleBehaviour__GetAutoRepathPeriod(int32_t roleCount, const MethodInfo *method)
{
  float result; // s0

  if ( !Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) )
    return 1.0;
  result = 2.0;
  if ( roleCount > 79 )
    return 3.0;
  return result;
}
