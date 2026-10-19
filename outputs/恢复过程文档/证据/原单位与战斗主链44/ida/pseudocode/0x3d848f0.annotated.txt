bool __fastcall GameModule_RoleBehaviour__ShouldSyncPathfindingTargetPosition(
        __int64 a1,
        char a2,
        float a3,
        float a4,
        float a5,
        float a6,
        float a7,
        float a8)
{
  bool UseWebGLNavigation; // w8
  _BOOL8 result; // x0
  float v18; // s0

  UseWebGLNavigation = Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0);
  result = true;
  if ( UseWebGLNavigation && (a2 & 1) == 0 )
  {
    v18 = (float)((float)(a8 - a5) * (float)(a8 - a5))
        + (float)((float)((float)(a6 - a3) * (float)(a6 - a3)) + (float)((float)(a7 - a4) * (float)(a7 - a4)));
    if ( v18 <= 0.0001 )
      return false;
    else
      return v18 >= 0.16 || (float)(UnityEngine_Time__get_time(0) - *(float *)(a1 + 460)) >= 0.15;
  }
  return result;
}
