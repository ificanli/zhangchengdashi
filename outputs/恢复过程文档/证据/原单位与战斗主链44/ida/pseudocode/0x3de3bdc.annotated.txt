__int64 __fastcall GameModule_BattleGameManager__BetRecordRewardNum(__int64 a1, __int64 a2)
{
  __int64 result; // x0

  if ( a2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  result = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)a2 + 360LL))(a2, *(_QWORD *)(*(_QWORD *)a2 + 368LL));
  *(_QWORD *)(a1 + 232) = result;
  return result;
}
