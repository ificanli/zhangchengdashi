// local variable allocation has failed, the output may be wrong!
void GameModule_BattleGameSceneManager__SettlementAnimation(
        GameModule_BattleGameSceneManager_o *this,
        bool isVictory,
        const MethodInfo *method)
{
  _QWORD v5[4]; // [xsp+0h] [xbp-A0h] BYREF
  _QWORD v6[8]; // [xsp+20h] [xbp-80h] BYREF
  __int64 v7; // [xsp+60h] [xbp-40h]

  if ( (byte_8FFD7B2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D228C8);
    byte_8FFD7B2 = 1;
  }
  v7 = 0;
  memset(v6, 0, sizeof(v6));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v5, 0, isVictory);
  v6[5] = this;
  LOBYTE(v6[6]) = isVictory;
  qmemcpy(&v6[1], v5, 32);
  LODWORD(v6[0]) = -1;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BattleGameSceneManager__SettlementAnimation_d__217_(
    &v6[1],
    v6,
    qword_8D228C8);
}
