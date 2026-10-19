__int64 __fastcall GameModule_RoleBehaviour__RestoreAiAfterControlStateReleased(_BYTE *a1, __int64 a2, __int64 a3)
{
  __int64 v5; // x3

  if ( a1[188] != 0 || GameModule_RoleBehaviour__IsAiMovementBlockedByState(a1) )
    return GameModule_RoleBehaviour__SetAiCanMove(a1, 0, a3);
  GameModule_RoleBehaviour__SetAiCanMove(a1, 1, a3);
  return sub_3D7F628(a1, 1, 0, v5);
}
