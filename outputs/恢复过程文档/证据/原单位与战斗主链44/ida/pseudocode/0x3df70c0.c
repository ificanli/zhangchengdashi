// local variable allocation has failed, the output may be wrong!
void GameModule_BattleGameSceneManager__TrySpawnFromWaitingBarracks(
        GameModule_BattleGameSceneManager_o *this,
        bool isEnemy,
        const MethodInfo *method)
{
  __int64 Instance; // x0
  const MethodInfo *v6; // x2
  __int64 v7; // x8
  __int64 v8; // x19
  int v9; // w8
  unsigned int v10; // w22
  __int64 Item; // x23
  __int64 v12; // x0
  __int64 v13; // x25
  __int64 v14; // x22
  __int64 v15; // x23
  __int64 v16; // x8
  _QWORD *v17; // x9
  __int64 v18; // x10
  __int64 v19; // x8
  _QWORD *v20; // x9
  __int64 v21; // x10
  __int64 v22; // x24
  __int64 v23; // x23
  __int64 CreatRoleID; // x25
  __int64 v25; // x26
  __int64 v26; // x0
  __int64 v27; // x8
  _QWORD *v28; // x9
  __int64 v29; // x10
  __int64 v30; // x23
  __int64 v31; // x24
  int v32; // w20
  __int64 v33; // x23
  int RareLevelValue; // w0
  __int64 v35; // x20
  int v36; // w22
  __int64 v37; // x21
  int v38; // w0
  bool v39; // [xsp+14h] [xbp-DCh]
  __int128 v40; // [xsp+18h] [xbp-D8h] BYREF
  __int128 v41; // [xsp+28h] [xbp-C8h]
  __int64 v42; // [xsp+38h] [xbp-B8h]
  __int128 v43; // [xsp+40h] [xbp-B0h] BYREF
  __int128 v44; // [xsp+50h] [xbp-A0h]
  __int64 v45; // [xsp+60h] [xbp-90h]
  __int128 v46; // [xsp+70h] [xbp-80h] BYREF
  __int64 v47; // [xsp+80h] [xbp-70h]

  if ( (byte_8FFD7C9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDC90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDC98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDC88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDCA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDCA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9B60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01800);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04990);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01808);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D049A0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D076A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D076A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D093B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093B0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D093E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD2E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7C9 = 1;
  }
  v46 = 0u;
  v47 = 0;
  v45 = 0;
  v43 = 0u;
  v44 = 0u;
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, isEnemy, method);
  if ( Instance == 0 )
    goto LABEL_83;
  if ( (SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0) & 1) == 0 )
    return;
  v7 = 528;
  if ( isEnemy )
    v7 = 536;
  v8 = *(__int64 *)((char *)&this->klass + v7);
  if ( v8 == 0 )
    goto LABEL_83;
  if ( *(_DWORD *)(v8 + 24) == 0 || !GameModule_BattleGameSceneManager__CanSpawnRole(this, isEnemy, v6) )
    return;
  v9 = *(_DWORD *)(v8 + 24);
  v10 = v9 - 1;
  if ( v9 - 1 >= 0 )
  {
    do
    {
      Item = System_Collections_Generic_List_object___get_Item(v8, v10, qword_8D093F0);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Equality(Item, 0, 0) & 1) != 0 )
        goto LABEL_18;
      v12 = System_Collections_Generic_List_object___get_Item(v8, v10, qword_8D093F0);
      if ( v12 == 0 )
        goto LABEL_83;
      if ( *(_BYTE *)(v12 + 33) != 0 )
LABEL_18:
        System_Collections_Generic_List_object___RemoveAt(v8, v10, qword_8D093E0);
      --v10;
    }
    while ( (v10 & 0x80000000) == 0 );
    v9 = *(_DWORD *)(v8 + 24);
  }
  if ( v9 == 0 )
    return;
  v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD2E0);
  System_Collections_Generic_List_object____ctor(v13, qword_8D093B0);
  v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD2E0);
  System_Collections_Generic_List_object____ctor(v14, qword_8D093B0);
  System_Collections_Generic_List_object___GetEnumerator(&v40, v8, qword_8D093D0);
  v46 = v40;
  v47 = v41;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v46, qword_8D01808) & 1) != 0 )
  {
    v15 = v47;
    if ( v47 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (GameModule_BarracksArchitectureBehaviour__IsLegendaryBarracks(v47, 0) & 1) != 0 )
    {
      if ( v13 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v16 = *(_QWORD *)(v13 + 16);
      v17 = off_8D093B8;
      ++*(_DWORD *)(v13 + 28);
      if ( v16 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v18 = *(int *)(v13 + 24);
      if ( (unsigned int)v18 >= *(_DWORD *)(v16 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v13,
          v15,
          *(_QWORD *)(*(_QWORD *)(v17[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v13 + 24) = v18 + 1;
        *(_QWORD *)(v16 + 8 * v18 + 32) = v15;
      }
    }
    else
    {
      if ( v14 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v19 = *(_QWORD *)(v14 + 16);
      v20 = off_8D093B8;
      ++*(_DWORD *)(v14 + 28);
      if ( v19 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v21 = *(int *)(v14 + 24);
      if ( (unsigned int)v21 >= *(_DWORD *)(v19 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v14,
          v15,
          *(_QWORD *)(*(_QWORD *)(v20[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v14 + 24) = v21 + 1;
        *(_QWORD *)(v19 + 8 * v21 + 32) = v15;
      }
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v46, qword_8D01800);
  if ( v13 == 0 )
LABEL_83:
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(int *)(v13 + 24) >= 1 )
  {
    v39 = isEnemy;
    v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9B60);
    System_Collections_Generic_Dictionary_object__object____ctor(v22, qword_8CFDC88);
    System_Collections_Generic_List_object___GetEnumerator(&v40, v13, qword_8D093D0);
    v46 = v40;
    v47 = v41;
    while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v46, qword_8D01808) & 1) != 0 )
    {
      v23 = v47;
      if ( v47 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      CreatRoleID = GameModule_BarracksArchitectureBehaviour__GetCreatRoleID(v47, 0);
      if ( (System_String__IsNullOrEmpty(CreatRoleID, 0) & 1) == 0 )
      {
        if ( v22 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v22, CreatRoleID, qword_8CFDC90) & 1) == 0 )
        {
          v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD2E0);
          System_Collections_Generic_List_object____ctor(v25, qword_8D093B0);
          System_Collections_Generic_Dictionary_object__object___set_Item(v22, CreatRoleID, v25, qword_8CFDCA8);
        }
        v26 = System_Collections_Generic_Dictionary_object__object___get_Item(v22, CreatRoleID, qword_8CFDCA0);
        if ( v26 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v27 = *(_QWORD *)(v26 + 16);
        v28 = off_8D093B8;
        ++*(_DWORD *)(v26 + 28);
        if ( v27 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v29 = *(int *)(v26 + 24);
        if ( (unsigned int)v29 >= *(_DWORD *)(v27 + 24) )
        {
          System_Collections_Generic_List_object___AddWithResize(
            v26,
            v23,
            *(_QWORD *)(*(_QWORD *)(v28[4] + 192LL) + 112LL));
        }
        else
        {
          *(_DWORD *)(v26 + 24) = v29 + 1;
          *(_QWORD *)(v27 + 8 * v29 + 32) = v23;
        }
      }
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(&v46, qword_8D01800);
    if ( v22 == 0 )
      goto LABEL_83;
    System_Collections_Generic_Dictionary_object__object___GetEnumerator(&v40, v22, qword_8CFDC98);
    v43 = v40;
    v44 = v41;
    v45 = v42;
    while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(&v43, qword_8D04998) & 1) != 0 )
    {
      v30 = *((_QWORD *)&v44 + 1);
      if ( (GameModule_BattleGameSceneManager__CanSpawnLegendaryUnit(this, v44, v39) & 1) != 0 )
      {
        if ( v30 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        System_Collections_Generic_List_object___GetEnumerator(&v40, v30, qword_8D093D0);
        v31 = 0;
        v32 = -1;
        v46 = v40;
        v47 = v41;
        while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v46, qword_8D01808) & 1) != 0 )
        {
          v33 = v47;
          if ( v47 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          RareLevelValue = GameModule_BarracksArchitectureBehaviour__GetRareLevelValue(v47, 0);
          if ( RareLevelValue > v32 )
          {
            v32 = RareLevelValue;
            v31 = v33;
          }
        }
        System_Collections_Generic_List_Enumerator_object___Dispose(&v46, qword_8D01800);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(v31, 0, 0) & 1) != 0 )
        {
          System_Collections_Generic_List_object___Remove(v8, v31, qword_8D093D8);
          if ( v31 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          GameModule_BarracksArchitectureBehaviour__OnCanSpawnRole(v31, 0);
          System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(&v43, qword_8D04990);
          return;
        }
      }
    }
    System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(&v43, qword_8D04990);
  }
  if ( v14 == 0 )
    goto LABEL_83;
  if ( *(int *)(v14 + 24) > 0 )
  {
    System_Collections_Generic_List_object___GetEnumerator(&v40, v14, qword_8D093D0);
    v35 = 0;
    v36 = -1;
    v46 = v40;
    v47 = v41;
    while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v46, qword_8D01808) & 1) != 0 )
    {
      v37 = v47;
      if ( v47 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v38 = GameModule_BarracksArchitectureBehaviour__GetRareLevelValue(v47, 0);
      if ( v38 > v36 )
      {
        v36 = v38;
        v35 = v37;
      }
    }
    System_Collections_Generic_List_Enumerator_object___Dispose(&v46, qword_8D01800);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v35, 0, 0) & 1) != 0 )
    {
      System_Collections_Generic_List_object___Remove(v8, v35, qword_8D093D8);
      if ( v35 != 0 )
      {
        GameModule_BarracksArchitectureBehaviour__OnCanSpawnRole(v35, 0);
        return;
      }
      goto LABEL_83;
    }
  }
}
