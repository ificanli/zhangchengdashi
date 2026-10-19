__int64 __fastcall GameModule_RoleBehaviour__AttackWallWithNormalLogic(__int64 a1)
{
  __int128 v3; // [xsp+0h] [xbp-50h] BYREF
  __int64 v4; // [xsp+10h] [xbp-40h]
  __int64 v5; // [xsp+18h] [xbp-38h]
  __int128 v6; // [xsp+20h] [xbp-30h]

  if ( (byte_8FFD498 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21790);
    byte_8FFD498 = 1;
  }
  v3 = 0u;
  v5 = 0;
  v6 = 0u;
  v4 = a1;
  LODWORD(v3) = -1;
  Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskVoidMethodBuilder__Start_RoleBehaviour__AttackWallWithNormalLogic_d__236_(
    (char *)&v3 + 8,
    &v3,
    qword_8D21790);
  return 0;
}
