__int64 __fastcall GameModule_BattleGameSceneManager__RemovePlayerStayHex(__int64 a1, __int64 a2)
{
  __int64 v4; // x0

  if ( (byte_8FFD7B9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACC8);
    byte_8FFD7B9 = 1;
  }
  v4 = *(_QWORD *)(a1 + 96);
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return System_Collections_Generic_List_object___Remove(v4, a2, qword_8D0ACC8);
}
