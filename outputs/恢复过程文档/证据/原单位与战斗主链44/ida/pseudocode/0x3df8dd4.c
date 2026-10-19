__int64 __fastcall GameModule_BattleGameSceneManager__RemoveHellfire(__int64 a1, __int64 a2)
{
  __int64 result; // x0
  __int64 v5; // x0
  __int64 v6; // x0

  if ( (byte_8FFD7D5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7D5 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(a2, 0, 0);
  if ( (result & 1) != 0 )
  {
    v5 = *(_QWORD *)(a1 + 240);
    if ( v5 == 0 )
      goto LABEL_11;
    result = System_Collections_Generic_List_object___Contains(v5, a2, qword_8D0B4B0);
    if ( (result & 1) != 0 )
    {
      v6 = *(_QWORD *)(a1 + 240);
      if ( v6 != 0 )
        return System_Collections_Generic_List_object___Remove(v6, a2, qword_8D0B4B8);
LABEL_11:
      il2cpp_codegen_raise_null_reference_exception();
    }
  }
  return result;
}
