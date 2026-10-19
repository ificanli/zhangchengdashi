// local variable allocation has failed, the output may be wrong!
void GameModule_BattleGameSceneManager__StartGame(
        GameModule_BattleGameSceneManager_o *this,
        int32_t gameType,
        const MethodInfo *method)
{
  _QWORD v5[4]; // [xsp+0h] [xbp-90h] BYREF
  _QWORD v6[6]; // [xsp+20h] [xbp-70h] BYREF
  __int64 v7; // [xsp+50h] [xbp-40h]

  if ( (byte_8FFD77A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D228D0);
    byte_8FFD77A = 1;
  }
  v7 = 0;
  memset(v6, 0, sizeof(v6));
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create(v5, 0, *(_QWORD *)&gameType);
  v6[5] = this;
  LODWORD(v7) = gameType;
  qmemcpy(&v6[1], v5, 32);
  LODWORD(v6[0]) = -1;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BattleGameSceneManager__StartGame_d__142_(
    &v6[1],
    v6,
    qword_8D228D0);
}
