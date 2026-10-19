void __fastcall GameModule_BattleGameSceneManager__UpdateAllList_d__155__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x21
  __int64 updated; // x0
  __int64 v5; // x1
  __int64 v6; // x0
  __int64 v7; // x1
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x0
  __int64 v11; // x1
  __int64 v12; // x1
  __int64 v13; // x8
  __int64 v14; // x9
  int *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x8
  __int64 v18; // x9
  _DWORD *v19; // x10
  __int64 v20; // x0
  __int64 *v21; // x19
  __int64 v22; // x8
  __int64 v23; // x9
  _DWORD *v24; // x10
  __int64 v25; // x0
  __int64 v26; // x20
  int v27; // w1
  _QWORD **v28; // x20
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 v31; // x1
  _QWORD *v32; // x20
  __int64 *v33; // x21
  __int64 v34; // x8
  __int64 v35; // x9
  _DWORD *v36; // x10
  __int64 v37; // x0
  _QWORD *v38; // x0
  __int128 v39; // [xsp+0h] [xbp-40h] BYREF

  if ( (byte_8FFD7EE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1F320);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE36C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD7EE = 1;
  }
  v39 = 0u;
  v2 = *(_QWORD *)(a1 + 24);
  if ( *(_DWORD *)a1 == 0 )
  {
    v39 = *(_OWORD *)(a1 + 32);
    *(_QWORD *)(a1 + 32) = 0;
    *(_QWORD *)(a1 + 40) = 0;
    *(_DWORD *)a1 = -1;
LABEL_27:
    if ( byte_8FFD1AF == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AF = 1;
    }
    if ( (_QWORD)v39 != 0 )
    {
      v17 = *(_QWORD *)v39;
      v18 = *(unsigned __int16 *)(*(_QWORD *)v39 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v39 + 302LL) != 0 )
      {
        v19 = (_DWORD *)(*(_QWORD *)(v17 + 176) + 8LL);
        while ( *((_QWORD *)v19 - 1) != qword_8CE91C8 )
        {
          --v18;
          v19 += 4;
          if ( v18 == 0 )
            goto LABEL_34;
        }
        v20 = v17 + 16LL * (*v19 + 2) + 312;
      }
      else
      {
LABEL_34:
        v20 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v39, qword_8CE91C8, 2);
      }
      (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v20)(v39, WORD4(v39), *(_QWORD *)(v20 + 8));
    }
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_BYTE *)(v2 + 584) = 0;
    *(_DWORD *)a1 = -2;
    if ( byte_8FFD1B1 == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
      byte_8FFD1B1 = 1;
    }
    v21 = *(__int64 **)(a1 + 8);
    if ( v21 != nullptr )
    {
      v22 = *v21;
      v23 = *(unsigned __int16 *)(*v21 + 302);
      if ( *(_WORD *)(*v21 + 302) != 0 )
      {
        v24 = (_DWORD *)(*(_QWORD *)(v22 + 176) + 8LL);
        while ( *((_QWORD *)v24 - 1) != qword_8CE9038 )
        {
          --v23;
          v24 += 4;
          if ( v23 == 0 )
            goto LABEL_45;
        }
        v25 = v22 + 16LL * (*v24 + 2) + 312;
      }
      else
      {
LABEL_45:
        v25 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v21, qword_8CE9038, 2);
      }
      (*(void (__fastcall **)(__int64 *, _QWORD))v25)(v21, *(_QWORD *)(v25 + 8));
    }
    return;
  }
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_BYTE *)(v2 + 584) = 1;
  v3 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE36C0, 4);
  updated = GameModule_BattleGameSceneManager__UpdateEnemyRole(v2, 0);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_DWORD *)(v3 + 24) == 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(updated);
    goto LABEL_54;
  }
  *(_QWORD *)(v3 + 32) = updated;
  *(_QWORD *)(v3 + 40) = v5;
  v6 = GameModule_BattleGameSceneManager__UpdatePlayerRole(v2, 0);
  if ( *(_DWORD *)(v3 + 24) <= 1u )
  {
LABEL_54:
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v6);
    goto LABEL_55;
  }
  *(_QWORD *)(v3 + 48) = v6;
  *(_QWORD *)(v3 + 56) = v7;
  v8 = GameModule_BattleGameSceneManager__UpdateHexObj(v2, 0);
  if ( *(_DWORD *)(v3 + 24) <= 2u )
  {
LABEL_55:
    v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v8);
    goto LABEL_56;
  }
  *(_QWORD *)(v3 + 64) = v8;
  *(_QWORD *)(v3 + 72) = v9;
  v10 = GameModule_BattleGameSceneManager__UpdateArchitecture(v2, 0);
  if ( *(_DWORD *)(v3 + 24) > 3u )
  {
    *(_QWORD *)(v3 + 80) = v10;
    *(_QWORD *)(v3 + 88) = v11;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v39 = Cysharp_Threading_Tasks_UniTask__WhenAll(v3, 0);
    *((_QWORD *)&v39 + 1) = v12;
    if ( byte_8FFD1AD == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
      byte_8FFD1AD = 1;
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    if ( byte_8FFD1AE == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AE = 1;
    }
    if ( (_QWORD)v39 != 0 )
    {
      v13 = *(_QWORD *)v39;
      v14 = *(unsigned __int16 *)(*(_QWORD *)v39 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v39 + 302LL) != 0 )
      {
        v15 = (int *)(*(_QWORD *)(v13 + 176) + 8LL);
        while ( *((_QWORD *)v15 - 1) != qword_8CE91C8 )
        {
          --v14;
          v15 += 4;
          if ( v14 == 0 )
            goto LABEL_23;
        }
        v16 = v13 + 16LL * *v15 + 312;
      }
      else
      {
LABEL_23:
        v16 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v39, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v16)(v39, WORD4(v39), *(_QWORD *)(v16 + 8)) == 0 )
      {
        *(_DWORD *)a1 = 0;
        *(_OWORD *)(a1 + 32) = v39;
        ((void (__fastcall *)(__int64, __int128 *, __int64, __int64))unk_3E13CA0)(a1 + 8, &v39, a1, qword_8D1F320);
        return;
      }
    }
    goto LABEL_27;
  }
LABEL_56:
  v26 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v10);
  if ( v27 != 1 )
    sub_3CE73C4(v26);
  v28 = (_QWORD **)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v26);
  v29 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
  v30 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D8F8)(v29, **v28);
  if ( (v30 & 1) == 0 )
  {
    v38 = (_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8);
    *v38 = *v28;
    ((void (__fastcall __noreturn *)(_QWORD *, __int64 **))__cxa_throw)(v38, &`typeinfo for'Il2CppExceptionWrapper);
  }
  v32 = *v28;
  ((void (__fastcall *)(__int64, __int64))__cxa_end_catch)(v30, v31);
  *(_DWORD *)a1 = -2;
  if ( byte_8FFD1B0 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE9038);
    byte_8FFD1B0 = 1;
  }
  v33 = *(__int64 **)(a1 + 8);
  if ( v33 != nullptr )
  {
    v34 = *v33;
    v35 = *(unsigned __int16 *)(*v33 + 302);
    if ( *(_WORD *)(*v33 + 302) != 0 )
    {
      v36 = (_DWORD *)(*(_QWORD *)(v34 + 176) + 8LL);
      while ( *((_QWORD *)v36 - 1) != qword_8CE9038 )
      {
        --v35;
        v36 += 4;
        if ( v35 == 0 )
          goto LABEL_65;
      }
      v37 = v34 + 16LL * (*v36 + 3) + 312;
    }
    else
    {
LABEL_65:
      v37 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(*(_QWORD *)(a1 + 8), qword_8CE9038, 3);
    }
    (*(void (__fastcall **)(__int64 *, _QWORD *, _QWORD))v37)(v33, v32, *(_QWORD *)(v37 + 8));
  }
  else
  {
    *(_QWORD *)(a1 + 16) = v32;
  }
}
