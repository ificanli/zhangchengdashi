float __fastcall GameModule_RoleBehaviour__GetAiSPeed(__int64 a1)
{
  __int64 v2; // x8
  __int64 v3; // x8

  if ( Pathfinding_AstarWebGLRuntimeConfig__get_UseWebGLNavigation(0) && (v2 = *(_QWORD *)(a1 + 64)) != 0 )
    v3 = v2 + 40;
  else
    v3 = a1 + 444;
  return *(float *)v3;
}
