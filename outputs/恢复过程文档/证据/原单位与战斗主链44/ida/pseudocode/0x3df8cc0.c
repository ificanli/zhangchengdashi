__int64 __fastcall GameModule_BattleGameSceneManager__AddHellfire(__int64 a1, __int64 a2)
{
  __int64 result; // x0
  __int64 v5; // x0
  __int64 v6; // x8
  _QWORD *v7; // x9
  __int64 v8; // x10

  if ( (byte_8FFD7D4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0B4A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7D4 = 1;
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  result = UnityEngine_Object__op_Inequality(a2, 0, 0);
  if ( (result & 1) != 0 )
  {
    v5 = *(_QWORD *)(a1 + 240);
    if ( v5 == 0 )
      goto LABEL_14;
    result = System_Collections_Generic_List_object___Contains(v5, a2, qword_8D0B4B0);
    if ( (result & 1) != 0 )
      return result;
    result = *(_QWORD *)(a1 + 240);
    if ( result == 0 || (v6 = *(_QWORD *)(result + 16), v7 = off_8D0B4A0, ++*(_DWORD *)(result + 28), v6 == 0) )
LABEL_14:
      il2cpp_codegen_raise_null_reference_exception();
    v8 = *(int *)(result + 24);
    if ( (unsigned int)v8 >= *(_DWORD *)(v6 + 24) )
    {
      return System_Collections_Generic_List_object___AddWithResize(
               result,
               a2,
               *(_QWORD *)(*(_QWORD *)(v7[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(result + 24) = v8 + 1;
      *(_QWORD *)(v6 + 8 * v8 + 32) = a2;
    }
  }
  return result;
}
