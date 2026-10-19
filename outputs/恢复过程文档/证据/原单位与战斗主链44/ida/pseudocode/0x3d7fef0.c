__int64 __fastcall GameModule_RoleBehaviour__GetAnimationBehaviour(__int64 a1)
{
  __int64 result; // x0

  result = *(_QWORD *)(a1 + 320);
  if ( result == 0 )
  {
    result = GameModule_RoleBehaviour__ResolveAnimationBehaviour(a1);
    *(_QWORD *)(a1 + 320) = result;
  }
  return result;
}
