__int64 __fastcall GameModule_RoleBehaviour__RestoreAiAfterSkillRespectFreeze(__int64 a1, __int64 a2, __int64 a3)
{
  char v4; // w8

  if ( *(_BYTE *)(a1 + 188) != 0 )
    v4 = 0;
  else
    v4 = GameModule_RoleBehaviour__IsAiMovementBlockedByState(a1) ^ 1;
  GameModule_RoleBehaviour__SetAiCanMove(a1, v4 & 1, a3);
  return GameModule_RoleBehaviour__SetAiEnableLocalAvoidance(a1, 1);
}
