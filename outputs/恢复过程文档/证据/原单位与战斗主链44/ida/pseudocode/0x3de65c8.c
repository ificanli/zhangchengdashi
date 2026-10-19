__int64 __fastcall GameModule_BattleGameManager__AddDeadUnit(__int64 a1, unsigned int a2, __int64 a3)
{
  __int64 v6; // x0
  __int64 result; // x0
  __int64 v8; // x0

  if ( (byte_8FFD745 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC670);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC680);
    byte_8FFD745 = 1;
  }
  v6 = *(_QWORD *)(a1 + 168);
  if ( v6 != 0 )
  {
    result = System_Collections_Generic_Dictionary_int__object___ContainsKey(v6, a2, qword_8CFC680);
    if ( (result & 1) != 0 )
      return result;
    v8 = *(_QWORD *)(a1 + 168);
    if ( v8 != 0 )
      return System_Collections_Generic_Dictionary_int__object___Add(v8, a2, a3, qword_8CFC670);
  }
  il2cpp_codegen_raise_null_reference_exception();
}
