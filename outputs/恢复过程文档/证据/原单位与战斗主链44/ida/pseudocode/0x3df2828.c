bool GameModule_BattleGameSceneManager__TryGetRoleTargetHexSearchRing(
        GameModule_BattleGameSceneManager_o *this,
        float range,
        int32_t *searchRing,
        const MethodInfo *method)
{
  float v6; // s9
  float v7; // s9
  float v8; // s0
  int32_t v9; // w8

  LODWORD(v6) = COERCE_UNSIGNED_INT128(GameModule_BattleGameSceneManager__GetSpawnHexSize(this, searchRing, method));
  if ( byte_8FFD1B2 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFD1B2 = 1;
  }
  v7 = v6 * 1.7321;
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA738);
  v8 = range / fmaxf(v7, 0.5);
  v9 = vcvtps_s32_f32(v8) + 2;
  if ( ceilf(v8) == INFINITY )
    v9 = -2147483646;
  *searchRing = v9;
  return v9 < 11;
}
