__int64 __fastcall GameModule_BattleGameManager__SettlementAnimationEnd(__int64 a1, __int64 a2)
{
  _QWORD v4[4]; // [xsp+0h] [xbp-80h] BYREF
  _QWORD v5[8]; // [xsp+20h] [xbp-60h] BYREF

  if ( (byte_8FFD736 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D228B0);
    byte_8FFD736 = 1;
  }
  memset(v5, 0, sizeof(v5));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v4, 0, a2);
  v5[5] = a1;
  qmemcpy(&v5[1], v4, 32);
  LODWORD(v5[0]) = -1;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BattleGameManager__SettlementAnimationEnd_d__59_(
           &v5[1],
           v5,
           qword_8D228B0);
}
