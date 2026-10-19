__int64 __fastcall GameModule_BattleGameSceneManager__AddEnemyStayHex(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  __int64 v5; // x8
  _QWORD *v6; // x9
  __int64 v7; // x10
  __int64 v8; // x20
  __int64 result; // x0
  __int64 v10; // x8
  _QWORD *v11; // x9
  __int64 v12; // x10

  if ( (byte_8FFD7B8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D9E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0B4E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0AC98);
    byte_8FFD7B8 = 1;
  }
  v4 = *(_QWORD *)(a1 + 104);
  if ( v4 != 0 )
  {
    v5 = *(_QWORD *)(v4 + 16);
    v6 = off_8D0AC98;
    ++*(_DWORD *)(v4 + 28);
    if ( v5 != 0 )
    {
      v7 = *(int *)(v4 + 24);
      if ( (unsigned int)v7 >= *(_DWORD *)(v5 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(v4, a2, *(_QWORD *)(*(_QWORD *)(v6[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v4 + 24) = v7 + 1;
        *(_QWORD *)(v5 + 8 * v7 + 32) = a2;
      }
      if ( a2 != 0 )
      {
        v8 = *(_QWORD *)(a1 + 112);
        result = UnityEngine_GameObject__GetComponent_object_(a2, qword_8D2D9E8);
        if ( v8 != 0 )
        {
          v10 = *(_QWORD *)(v8 + 16);
          v11 = off_8D0B4E8;
          ++*(_DWORD *)(v8 + 28);
          if ( v10 != 0 )
          {
            v12 = *(int *)(v8 + 24);
            if ( (unsigned int)v12 >= *(_DWORD *)(v10 + 24) )
              return System_Collections_Generic_List_object___AddWithResize(
                       v8,
                       result,
                       *(_QWORD *)(*(_QWORD *)(v11[4] + 192LL) + 112LL));
            *(_DWORD *)(v8 + 24) = v12 + 1;
            *(_QWORD *)(v10 + 8 * v12 + 32) = result;
            return result;
          }
        }
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
