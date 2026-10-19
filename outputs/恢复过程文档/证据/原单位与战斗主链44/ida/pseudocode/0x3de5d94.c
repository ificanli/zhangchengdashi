__int64 __fastcall GameModule_BattleGameManager__TryApplyPauseToNewRole(__int64 a1, __int64 a2, __int64 a3)
{
  __int64 result; // x0

  if ( (byte_8FFD73F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD73F = 1;
  }
  result = GameModule_BattleGameManager__get_IsGamePaused(a1, a2, a3);
  if ( (result & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    result = UnityEngine_Object__op_Equality(a2, 0, 0);
    if ( (result & 1) == 0 )
      return GameModule_BattleGameManager__ApplyAnimationPauseToSingleRole(a1, a2, 1);
  }
  return result;
}
