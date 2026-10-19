void __fastcall GameModule_BattleGameSceneManager__AddArchitectureBehaviour(
        __int64 a1,
        __int64 a2,
        const MethodInfo *a3)
{
  __int64 v5; // x0
  __int64 v6; // x8
  _QWORD *v7; // x9
  __int64 v8; // x10
  __int64 v9; // x0
  __int64 v10; // x8
  _QWORD *v11; // x9
  __int64 v12; // x10

  if ( (byte_8FFD7D2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D08FC0);
    byte_8FFD7D2 = 1;
  }
  v5 = *(_QWORD *)(a1 + 216);
  if ( v5 == 0 )
    goto LABEL_18;
  v6 = *(_QWORD *)(v5 + 16);
  v7 = off_8D08FC0;
  ++*(_DWORD *)(v5 + 28);
  if ( v6 == 0 )
    goto LABEL_18;
  v8 = *(int *)(v5 + 24);
  if ( (unsigned int)v8 >= *(_DWORD *)(v6 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v5, a2, *(_QWORD *)(*(_QWORD *)(v7[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v5 + 24) = v8 + 1;
    *(_QWORD *)(v6 + 8 * v8 + 32) = a2;
  }
  if ( a2 == 0 )
LABEL_18:
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(a2 + 32) != 0 )
  {
    v9 = *(_QWORD *)(a1 + 232);
    if ( v9 == 0 )
      goto LABEL_18;
  }
  else
  {
    v9 = *(_QWORD *)(a1 + 224);
    if ( v9 == 0 )
      goto LABEL_18;
  }
  v10 = *(_QWORD *)(v9 + 16);
  v11 = off_8D08FC0;
  ++*(_DWORD *)(v9 + 28);
  if ( v10 == 0 )
    goto LABEL_18;
  v12 = *(int *)(v9 + 24);
  if ( (unsigned int)v12 >= *(_DWORD *)(v10 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v9, a2, *(_QWORD *)(*(_QWORD *)(v11[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v9 + 24) = v12 + 1;
    *(_QWORD *)(v10 + 8 * v12 + 32) = a2;
  }
  GameModule_BattleGameSceneManager__MarkWebGLNavigationTargetFieldDirty(
    (GameModule_BattleGameSceneManager_o *)a1,
    *(_BYTE *)(a2 + 32),
    a3);
}
