__int64 __fastcall GameModule_BattleGameSceneManager__RecoredSpecialHex(__int64 a1, float a2, float a3, float a4)
{
  __int64 result; // x0
  __int64 v9; // x8
  _QWORD *v10; // x9
  __int64 v11; // x10
  float *v12; // x8

  if ( (byte_8FFD7B4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F7C8);
    byte_8FFD7B4 = 1;
  }
  result = *(_QWORD *)(a1 + 376);
  if ( result == 0 || (v9 = *(_QWORD *)(result + 16), v10 = off_8D0F7C8, ++*(_DWORD *)(result + 28), v9 == 0) )
    il2cpp_codegen_raise_null_reference_exception();
  v11 = *(int *)(result + 24);
  if ( (unsigned int)v11 >= *(_DWORD *)(v9 + 24) )
    return System_Collections_Generic_List_Vector3___AddWithResize(
             result,
             *(_QWORD *)(*(_QWORD *)(v10[4] + 192LL) + 112LL));
  v12 = (float *)(v9 + 12 * v11);
  *(_DWORD *)(result + 24) = v11 + 1;
  v12[8] = a2;
  v12[9] = a3;
  v12[10] = a4;
  return result;
}
