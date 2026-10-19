__int64 __fastcall GameModule_BattleGameSceneManager__HideAllRole_d__214__MoveNext(int *a1)
{
  int v2; // w21
  _QWORD *v3; // x25
  __int64 v4; // x0
  __int64 v5; // x20
  int v6; // w8
  __int64 Item; // x20
  __int64 gameObject; // x0
  unsigned __int64 v9; // t2
  __int64 v10; // x1
  __int64 v11; // x20
  __int64 v12; // x8
  unsigned int v13; // w21
  __int64 v14; // x9
  int *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x20
  __int64 v18; // x8
  unsigned int v19; // w21
  __int64 v20; // x9
  _DWORD *v21; // x10
  __int64 v22; // x0
  __int64 v23; // x9
  int v24; // w8
  __int64 v26; // x20
  __int64 v27; // x0
  unsigned __int64 v28; // t2
  __int64 v29; // x1
  __int64 v30; // x20
  __int64 v31; // x8
  unsigned int v32; // w21
  __int64 v33; // x9
  int *v34; // x10
  __int64 v35; // x0
  __int64 v36; // x20
  __int64 v37; // x8
  unsigned int v38; // w21
  __int64 v39; // x9
  _DWORD *v40; // x10
  __int64 v41; // x0
  __int64 v42; // x9
  __int128 v43; // [xsp+8h] [xbp-A8h] BYREF
  __int64 v44; // [xsp+18h] [xbp-98h]
  __int128 v45; // [xsp+20h] [xbp-90h] BYREF
  __int128 v46; // [xsp+30h] [xbp-80h] BYREF
  __int64 v47; // [xsp+40h] [xbp-70h]

  if ( (byte_8FFD7E9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D221F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B500);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0DDC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0DDC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12230);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    byte_8FFD7E9 = 1;
  }
  v46 = 0u;
  v47 = 0;
  v45 = 0u;
  v2 = *a1;
  v3 = *((_QWORD **)a1 + 5);
  if ( *a1 == 0 )
  {
    v45 = *(_OWORD *)(a1 + 14);
    *((_QWORD *)a1 + 7) = 0;
    *((_QWORD *)a1 + 8) = 0;
    *a1 = -1;
    goto LABEL_49;
  }
  if ( v2 != 1 )
  {
    if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12230) == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_HWGPUInstancerManager__DestroyCrowdManager();
    if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12400) == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_RoleShadowManager__RecycleAll();
    if ( v3 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v4 = v3[16];
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_List_object___GetEnumerator(&v43, v4, qword_8D0B500);
    v46 = v43;
    v47 = v44;
    while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v46, qword_8D02178) & 1) != 0 )
    {
      v5 = v47;
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(v5, 0, 0) & 1) != 0 )
      {
        if ( v5 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_HexBehaviour__HideRole(v5, 0);
      }
    }
    if ( v2 < 0 )
      System_Collections_Generic_List_Enumerator_object___Dispose(&v46, qword_8D02170);
    v6 = 0;
    a1[12] = 0;
    while ( 1 )
    {
      v23 = v3[24];
      if ( v23 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v6 >= *(_DWORD *)(v23 + 24) )
      {
        v24 = 0;
        a1[12] = 0;
        goto LABEL_100;
      }
      Item = System_Collections_Generic_List_object___get_Item(v3[24], (unsigned int)v6, qword_8D0DDC8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(Item, 0, 0) & 1) == 0 )
      {
        if ( Item == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_RoleBehaviour__SetAiCanMove(Item, 0, 0);
        gameObject = UnityEngine_Component__get_gameObject(Item, 0);
        if ( gameObject == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        UnityEngine_GameObject__SetActive(gameObject, 0, 0);
        GameModule_RoleBehaviour__RemoveHPUI(Item, 0);
        HIDWORD(v9) = -1030792151 * a1[12] + 85899344;
        LODWORD(v9) = HIDWORD(v9);
        if ( (unsigned int)(v9 >> 2) < 0x28F5C29 )
        {
          if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEEDF8);
          *(_QWORD *)&v45 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.05);
          *((_QWORD *)&v45 + 1) = v10;
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
          v11 = v45;
          if ( (_QWORD)v45 != 0 )
          {
            v12 = *(_QWORD *)v45;
            v13 = WORD4(v45);
            v14 = *(unsigned __int16 *)(*(_QWORD *)v45 + 302LL);
            if ( *(_WORD *)(*(_QWORD *)v45 + 302LL) != 0 )
            {
              v15 = (int *)(*(_QWORD *)(v12 + 176) + 8LL);
              while ( *((_QWORD *)v15 - 1) != qword_8CE91C8 )
              {
                --v14;
                v15 += 4;
                if ( v14 == 0 )
                  goto LABEL_46;
              }
              v16 = v12 + 16LL * *v15 + 312;
            }
            else
            {
LABEL_46:
              v16 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v45, qword_8CE91C8, 0);
            }
            if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v16)(v11, v13, *(_QWORD *)(v16 + 8)) == 0 )
            {
              *a1 = 0;
              *(_OWORD *)(a1 + 14) = v45;
              return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__BattleGameSceneManager__HideAllRole_d__214_(
                       a1 + 2,
                       &v45,
                       a1,
                       qword_8D221F0);
            }
          }
LABEL_49:
          if ( byte_8FFD1AF == 0 )
          {
            il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
            byte_8FFD1AF = 1;
          }
          v17 = v45;
          if ( (_QWORD)v45 != 0 )
          {
            v18 = *(_QWORD *)v45;
            v19 = WORD4(v45);
            v20 = *(unsigned __int16 *)(*(_QWORD *)v45 + 302LL);
            if ( *(_WORD *)(*(_QWORD *)v45 + 302LL) != 0 )
            {
              v21 = (_DWORD *)(*(_QWORD *)(v18 + 176) + 8LL);
              while ( *((_QWORD *)v21 - 1) != qword_8CE91C8 )
              {
                --v20;
                v21 += 4;
                if ( v20 == 0 )
                  goto LABEL_56;
              }
              v22 = v18 + 16LL * (*v21 + 2) + 312;
            }
            else
            {
LABEL_56:
              v22 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v45, qword_8CE91C8, 2);
            }
            (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v22)(v17, v19, *(_QWORD *)(v22 + 8));
          }
        }
      }
      v6 = a1[12] + 1;
      a1[12] = v6;
      if ( v3 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
    }
  }
  v45 = *(_OWORD *)(a1 + 14);
  *((_QWORD *)a1 + 7) = 0;
  *((_QWORD *)a1 + 8) = 0;
  *a1 = -1;
  while ( 1 )
  {
    if ( byte_8FFD1AF == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AF = 1;
    }
    v36 = v45;
    if ( (_QWORD)v45 == 0 )
      goto LABEL_99;
    v37 = *(_QWORD *)v45;
    v38 = WORD4(v45);
    v39 = *(unsigned __int16 *)(*(_QWORD *)v45 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v45 + 302LL) != 0 )
    {
      v40 = (_DWORD *)(*(_QWORD *)(v37 + 176) + 8LL);
      while ( *((_QWORD *)v40 - 1) != qword_8CE91C8 )
      {
        --v39;
        v40 += 4;
        if ( v39 == 0 )
          goto LABEL_96;
      }
      v41 = v37 + 16LL * (*v40 + 2) + 312;
    }
    else
    {
LABEL_96:
      v41 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v45, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(__int64, _QWORD, _QWORD))v41)(v36, v38, *(_QWORD *)(v41 + 8));
    while ( 1 )
    {
LABEL_99:
      v24 = a1[12] + 1;
      a1[12] = v24;
LABEL_100:
      if ( v3 == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      v42 = v3[25];
      if ( v42 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( v24 >= *(_DWORD *)(v42 + 24) )
      {
        *a1 = -2;
        return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 2, 0);
      }
      v26 = System_Collections_Generic_List_object___get_Item(v3[25], (unsigned int)v24, qword_8D0DDC8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(v26, 0, 0) & 1) == 0 )
      {
        if ( v26 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_RoleBehaviour__SetAiCanMove(v26, 0, 0);
        v27 = UnityEngine_Component__get_gameObject(v26, 0);
        if ( v27 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        UnityEngine_GameObject__SetActive(v27, 0, 0);
        GameModule_RoleBehaviour__RemoveHPUI(v26, 0);
        HIDWORD(v28) = -1030792151 * a1[12] + 85899344;
        LODWORD(v28) = HIDWORD(v28);
        if ( (unsigned int)(v28 >> 2) < 0x28F5C29 )
          break;
      }
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v45 = Cysharp_Threading_Tasks_UniTask__WaitForSeconds(0, 8, 0, 0, 0, 0.05);
    *((_QWORD *)&v45 + 1) = v29;
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
    v30 = v45;
    if ( (_QWORD)v45 != 0 )
    {
      v31 = *(_QWORD *)v45;
      v32 = WORD4(v45);
      v33 = *(unsigned __int16 *)(*(_QWORD *)v45 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v45 + 302LL) != 0 )
      {
        v34 = (int *)(*(_QWORD *)(v31 + 176) + 8LL);
        while ( *((_QWORD *)v34 - 1) != qword_8CE91C8 )
        {
          --v33;
          v34 += 4;
          if ( v33 == 0 )
            goto LABEL_86;
        }
        v35 = v31 + 16LL * *v34 + 312;
      }
      else
      {
LABEL_86:
        v35 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v45, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(__int64, _QWORD, _QWORD))v35)(v30, v32, *(_QWORD *)(v35 + 8)) == 0 )
        break;
    }
  }
  *a1 = 1;
  *(_OWORD *)(a1 + 14) = v45;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__BattleGameSceneManager__HideAllRole_d__214_(
           a1 + 2,
           &v45,
           a1,
           qword_8D221F0);
}
