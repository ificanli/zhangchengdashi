__int64 __fastcall GameModule_BattleGameManager__RecordBuildDamage(__int64 a1, __int64 a2, unsigned int a3)
{
  __int64 v6; // x0
  char v7; // w0
  __int64 v8; // x21
  __int64 v9; // x2

  if ( (byte_8FFD743 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    byte_8FFD743 = 1;
  }
  v6 = *(_QWORD *)(a1 + 120);
  if ( v6 == 0
    || (v7 = System_Collections_Generic_Dictionary_object__int___ContainsKey(v6, a2, qword_8CFEA68),
        (v8 = *(_QWORD *)(a1 + 120)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( (v7 & 1) == 0 )
    return System_Collections_Generic_Dictionary_object__int___Add(v8, a2, a3, qword_8CFEA58);
  v9 = (unsigned int)System_Collections_Generic_Dictionary_object__int___get_Item(v8, a2, qword_8CFEA98) + a3;
  return System_Collections_Generic_Dictionary_object__int___set_Item(v8, a2, v9, qword_8CFEAB0);
}
