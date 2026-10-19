void __fastcall GameModule_RoleBehaviour__OnKillUnitCallBack(__int64 a1)
{
  if ( *(_BYTE *)(a1 + 33) == 0 )
    GameModule_RoleBehaviour__OnKillTalentTrigger(a1);
}
