__int64 __fastcall GameModule_BattleGameManager__RecordCardCount(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  char v5; // w0
  __int64 v6; // x20
  __int64 v7; // x2

  if ( (byte_8FFD72E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    byte_8FFD72E = 1;
  }
  v4 = *(_QWORD *)(a1 + 152);
  if ( v4 == 0
    || (v5 = System_Collections_Generic_Dictionary_object__int___ContainsKey(v4, a2, qword_8CFEA68),
        (v6 = *(_QWORD *)(a1 + 152)) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( (v5 & 1) == 0 )
    return System_Collections_Generic_Dictionary_object__int___Add(v6, a2, 1, qword_8CFEA58);
  v7 = (unsigned int)System_Collections_Generic_Dictionary_object__int___get_Item(v6, a2, qword_8CFEA98) + 1;
  return System_Collections_Generic_Dictionary_object__int___set_Item(v6, a2, v7, qword_8CFEAB0);
}
