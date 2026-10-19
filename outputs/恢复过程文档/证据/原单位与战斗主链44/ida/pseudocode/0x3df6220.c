void __fastcall GameModule_BattleGameSceneManager__AddPlayerArchitecture(__int64 a1, __int64 a2)
{
  __int64 v4; // x0
  __int64 v5; // x8
  _QWORD *v6; // x9
  __int64 v7; // x10
  __int64 transform; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  const MethodInfo *v11; // x2

  if ( (byte_8FFD7BF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0AC98);
    byte_8FFD7BF = 1;
  }
  v4 = *(_QWORD *)(a1 + 160);
  if ( v4 == 0 )
    goto LABEL_12;
  v5 = *(_QWORD *)(v4 + 16);
  v6 = off_8D0AC98;
  ++*(_DWORD *)(v4 + 28);
  if ( v5 == 0 )
    goto LABEL_12;
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
  if ( a2 == 0
    || (transform = UnityEngine_GameObject__get_transform(a2, 0), *(_QWORD *)(a1 + 280) == 0)
    || (v9 = transform, v10 = UnityEngine_GameObject__get_transform(*(_QWORD *)(a1 + 280), 0), v9 == 0) )
  {
LABEL_12:
    il2cpp_codegen_raise_null_reference_exception();
  }
  sub_82F9798(v9, v10, 0, 0);
  GameModule_BattleGameSceneManager__MarkWebGLNavigationTargetFieldDirty(
    (GameModule_BattleGameSceneManager_o *)a1,
    false,
    v11);
}
