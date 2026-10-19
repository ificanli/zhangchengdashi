__int64 __fastcall GameModule_BattleGameSceneManager__TrySpawnLegendaryFromWaitingBarracks(
        GameModule_BattleGameSceneManager_o *a1,
        __int64 a2,
        __int64 a3)
{
  char v3; // w22
  __int64 Instance; // x0
  __int64 result; // x0
  __int64 v8; // x8
  __int64 v9; // x19
  _BOOL4 v10; // w22
  const MethodInfo *v11; // x2
  int v12; // w8
  unsigned int v13; // w21
  __int64 Item; // x22
  __int64 v15; // x21
  int v16; // w23
  __int64 v17; // x22
  __int64 CreatRoleID; // x0
  __int64 v19; // x3
  int RareLevelValue; // w0
  __int128 v21; // [xsp+8h] [xbp-78h] BYREF
  __int64 v22; // [xsp+18h] [xbp-68h]
  __int128 v23; // [xsp+20h] [xbp-60h] BYREF
  __int64 v24; // [xsp+30h] [xbp-50h]

  v3 = a3;
  if ( (byte_8FFD7CA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01800);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01808);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D01810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093D8);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D093E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D093F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_8FFD7CA = 1;
  }
  v23 = 0u;
  v24 = 0;
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, a2, a3);
  if ( Instance == 0 )
    goto LABEL_37;
  result = SDKModule_ABTestManager__get_GamePlayImprove01IsBTest(Instance, 0);
  if ( (result & 1) == 0 )
    return result;
  v8 = 528;
  if ( (v3 & 1) != 0 )
    v8 = 536;
  v9 = *(__int64 *)((char *)&a1->klass + v8);
  if ( v9 == 0 )
    goto LABEL_37;
  if ( *(_DWORD *)(v9 + 24) != 0 )
  {
    v10 = v3 & 1;
    result = GameModule_BattleGameSceneManager__CanSpawnLegendaryUnit(a1, a2, v10);
    if ( (result & 1) != 0 )
    {
      result = GameModule_BattleGameSceneManager__CanSpawnRole(a1, v10, v11);
      if ( (result & 1) != 0 )
      {
        v12 = *(_DWORD *)(v9 + 24);
        v13 = v12 - 1;
        if ( v12 - 1 >= 0 )
        {
          do
          {
            Item = System_Collections_Generic_List_object___get_Item(v9, v13, qword_8D093F0);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            if ( (UnityEngine_Object__op_Equality(Item, 0, 0) & 1) != 0 )
              goto LABEL_19;
            result = System_Collections_Generic_List_object___get_Item(v9, v13, qword_8D093F0);
            if ( result == 0 )
              goto LABEL_37;
            if ( *(_BYTE *)(result + 33) != 0 )
LABEL_19:
              result = System_Collections_Generic_List_object___RemoveAt(v9, v13, qword_8D093E0);
            --v13;
          }
          while ( (v13 & 0x80000000) == 0 );
          v12 = *(_DWORD *)(v9 + 24);
        }
        if ( v12 != 0 )
        {
          System_Collections_Generic_List_object___GetEnumerator(&v21, v9, qword_8D093D0);
          v15 = 0;
          v23 = v21;
          v24 = v22;
          v16 = -1;
          while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v23, qword_8D01808) & 1) != 0 )
          {
            v17 = v24;
            if ( v24 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            if ( (GameModule_BarracksArchitectureBehaviour__IsLegendaryBarracks(v24, 0) & 1) != 0 )
            {
              CreatRoleID = GameModule_BarracksArchitectureBehaviour__GetCreatRoleID(v17, 0);
              if ( (System_String__op_Equality(CreatRoleID, a2, 0, v19) & 1) != 0 )
              {
                RareLevelValue = GameModule_BarracksArchitectureBehaviour__GetRareLevelValue(v17, 0);
                if ( RareLevelValue > v16 )
                {
                  v16 = RareLevelValue;
                  v15 = v17;
                }
              }
            }
          }
          System_Collections_Generic_List_Enumerator_object___Dispose(&v23, qword_8D01800);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          result = UnityEngine_Object__op_Inequality(v15, 0, 0);
          if ( (result & 1) != 0 )
          {
            System_Collections_Generic_List_object___Remove(v9, v15, qword_8D093D8);
            if ( v15 != 0 )
              return GameModule_BarracksArchitectureBehaviour__OnCanSpawnRole(v15, 0);
LABEL_37:
            il2cpp_codegen_raise_null_reference_exception();
          }
        }
      }
    }
  }
  return result;
}
