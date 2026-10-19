void __fastcall GameModule_BattleGameSceneManager__UpdateEnemyRole_d__156__MoveNext(__int64 a1)
{
  __int64 v2; // x22
  __int64 v3; // x8
  int v4; // w8
  int v5; // w8
  __int64 v6; // x9
  __int64 Item; // x20
  int v8; // w9
  __int64 *v9; // x19
  __int64 v10; // x8
  __int64 v11; // x9
  _DWORD *v12; // x10
  __int64 v13; // x0
  int v14; // [xsp+8h] [xbp-38h] BYREF
  int Awaiter; // [xsp+18h] [xbp-28h] BYREF

  if ( (byte_8FFD7F0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1FAB0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD7F0 = 1;
  }
  Awaiter = 0;
  v14 = 0;
  v2 = *(_QWORD *)(a1 + 24);
  if ( *(_DWORD *)a1 == 0 )
  {
    Awaiter = *(_DWORD *)(a1 + 40);
    *(_DWORD *)(a1 + 40) = 0;
    *(_DWORD *)a1 = -1;
    goto LABEL_28;
  }
  *(_DWORD *)(a1 + 32) = 0;
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v3 = *(_QWORD *)(v2 + 192);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = *(_DWORD *)(v3 + 24);
  while ( 1 )
  {
    v5 = v4 - 1;
    *(_DWORD *)(a1 + 36) = v5;
    if ( v5 < 0 )
      break;
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v6 = *(_QWORD *)(v2 + 192);
    if ( v6 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( v5 >= *(_DWORD *)(v6 + 24) )
      break;
    Item = System_Collections_Generic_List_object___get_Item(*(_QWORD *)(v2 + 192), (unsigned int)v5, qword_8D0DDC8);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(Item, 0, 0) & 1) != 0 )
    {
      if ( Item == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 392LL))(Item, *(_QWORD *)(*(_QWORD *)Item + 400LL));
    }
    v4 = *(_DWORD *)(a1 + 36);
    v8 = *(_DWORD *)(a1 + 32) + 1;
    *(_DWORD *)(a1 + 32) = v8;
    if ( v4 >= 1 && v8 % 50 == 0 )
    {
      if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEEDF8);
      v14 = Cysharp_Threading_Tasks_UniTask__Yield(0);
      Awaiter = Cysharp_Threading_Tasks_YieldAwaitable__GetAwaiter(&v14, 0);
      if ( (Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
      {
        *(_DWORD *)a1 = 0;
        *(_DWORD *)(a1 + 40) = Awaiter;
        ((void (__fastcall *)(__int64, int *, __int64, __int64))unk_3E13EB0)(a1 + 8, &Awaiter, a1, qword_8D1FAB0);
        return;
      }
LABEL_28:
      Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__GetResult(&Awaiter, 0);
      v4 = *(_DWORD *)(a1 + 36);
    }
  }
  *(_DWORD *)a1 = -2;
  if ( byte_8FFD1B1 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B1 = 1;
  }
  v9 = *(__int64 **)(a1 + 8);
  if ( v9 != nullptr )
  {
    v10 = *v9;
    v11 = *(unsigned __int16 *)(*v9 + 302);
    if ( *(_WORD *)(*v9 + 302) != 0 )
    {
      v12 = (_DWORD *)(*(_QWORD *)(v10 + 176) + 8LL);
      while ( *((_QWORD *)v12 - 1) != qword_8CE9038 )
      {
        --v11;
        v12 += 4;
        if ( v11 == 0 )
          goto LABEL_36;
      }
      v13 = v10 + 16LL * (*v12 + 2) + 312;
    }
    else
    {
LABEL_36:
      v13 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v9, qword_8CE9038, 2);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD))v13)(v9, *(_QWORD *)(v13 + 8));
  }
}
