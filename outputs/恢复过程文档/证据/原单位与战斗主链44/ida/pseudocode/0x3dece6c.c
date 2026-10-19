GameModule_HexBehaviour_o *GameModule_BattleGameSceneManager__LegendaryTileV1PickOneHalf(
        GameModule_BattleGameSceneManager_o *this,
        bool enemyHalf,
        HexManager_HexCoord_o mainCoord,
        const MethodInfo *method)
{
  __int64 v7; // x22
  __int64 v8; // x0
  __int64 v9; // x8
  unsigned __int64 v10; // x24
  __int64 v11; // x23
  __int64 v12; // x21
  __int64 v13; // x0
  int v14; // w27
  __int64 v15; // x20
  const MethodInfo *v16; // x1
  __int64 v17; // x3
  __int64 v18; // x3
  __int64 v19; // x8
  _QWORD *v20; // x9
  __int64 v21; // x10
  __int64 v22; // x1
  __int64 v23; // x0
  __int128 v25; // [xsp+0h] [xbp-E0h] BYREF
  __int64 v26; // [xsp+10h] [xbp-D0h]
  __int64 v27; // [xsp+18h] [xbp-C8h] BYREF
  __int64 v28; // [xsp+20h] [xbp-C0h] BYREF
  __int64 v29; // [xsp+28h] [xbp-B8h] BYREF
  __int64 v30; // [xsp+30h] [xbp-B0h] BYREF
  __int64 v31; // [xsp+38h] [xbp-A8h] BYREF
  __int64 v32; // [xsp+40h] [xbp-A0h] BYREF
  __int64 v33; // [xsp+48h] [xbp-98h] BYREF
  __int64 v34; // [xsp+50h] [xbp-90h] BYREF
  __int64 v35; // [xsp+58h] [xbp-88h] BYREF
  __int64 v36; // [xsp+60h] [xbp-80h] BYREF
  __int64 v37; // [xsp+68h] [xbp-78h] BYREF
  __int128 v38; // [xsp+70h] [xbp-70h] BYREF
  __int64 v39; // [xsp+80h] [xbp-60h]

  if ( (byte_8FFD767 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0B4E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B500);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4D0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B530);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1C458);
    byte_8FFD767 = 1;
  }
  v38 = 0u;
  v39 = 0;
  v7 = ((__int64 (__fastcall *)(_QWORD, _QWORD, _QWORD, _QWORD))unk_3C3D320)(qword_8CE2A10, 12, mainCoord, method);
  *(_QWORD *)&v25 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v25, 4, 3, qword_8D1C458);
  if ( v7 == 0 )
    goto LABEL_49;
  if ( *(_DWORD *)(v7 + 24) == 0 )
    goto LABEL_48;
  *(_QWORD *)(v7 + 32) = v25;
  v37 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v37, 3, 3, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 1u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 40) = v37;
  v36 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v36, 2, 3, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 2u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 48) = v36;
  v35 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v35, 1, 3, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 3u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 56) = v35;
  v34 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v34, 4, 2, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 4u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 64) = v34;
  v33 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v33, 3, 2, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 5u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 72) = v33;
  v32 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v32, 2, 2, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 6u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 80) = v32;
  v31 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v31, 1, 2, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 7u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 88) = v31;
  v30 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v30, 4, 1, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 8u )
    goto LABEL_48;
  *(_QWORD *)(v7 + 96) = v30;
  v29 = 0;
  v8 = System_ValueTuple_int__int____ctor(&v29, 3, 1, qword_8D1C458);
  if ( *(_DWORD *)(v7 + 24) <= 9u
    || (*(_QWORD *)(v7 + 104) = v29,
        v28 = 0,
        v8 = System_ValueTuple_int__int____ctor(&v28, 2, 1, qword_8D1C458),
        *(_DWORD *)(v7 + 24) <= 0xAu)
    || (*(_QWORD *)(v7 + 112) = v28,
        v27 = 0,
        v8 = System_ValueTuple_int__int____ctor(&v27, 1, 1, qword_8D1C458),
        (unsigned int)(v9 = *(_QWORD *)(v7 + 24)) <= 0xB) )
  {
LABEL_48:
    ((void (__fastcall *)(__int64))unk_3C3D4D4)(v8);
    goto LABEL_49;
  }
  *(_QWORD *)(v7 + 120) = v27;
  if ( (int)v9 >= 1 )
  {
    v10 = 0;
    while ( 1 )
    {
      if ( v10 >= (unsigned int)v9 )
        goto LABEL_48;
      v8 = GameModule_BattleGameSceneManager__LegendaryTileV1BuildPool(
             this,
             enemyHalf,
             mainCoord,
             *(_DWORD *)(v7 + 32 + 8 * v10),
             *(_DWORD *)(v7 + 32 + 8 * v10 + 4));
      if ( v8 == 0 )
        goto LABEL_49;
      v11 = v8;
      if ( *(int *)(v8 + 24) >= 1 )
        break;
      LODWORD(v9) = *(_DWORD *)(v7 + 24);
      if ( (__int64)++v10 >= (int)v9 )
        goto LABEL_22;
    }
    v22 = (unsigned int)UnityEngine_Random__Range(0);
    v23 = v11;
    return (GameModule_HexBehaviour_o *)System_Collections_Generic_List_object___get_Item(v23, v22, qword_8D0B530);
  }
LABEL_22:
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD888);
  System_Collections_Generic_List_object____ctor(v12, qword_8D0B4D0);
  v13 = *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[112];
  if ( v13 == 0 )
    goto LABEL_49;
  System_Collections_Generic_List_object___GetEnumerator(&v25, v13, qword_8D0B500);
  v14 = enemyHalf;
  v38 = v25;
  v39 = v26;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v38, qword_8D02178) & 1) != 0 )
  {
    v15 = v39;
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v15, 0, 0) & 1) == 0 )
    {
      if ( *((_DWORD *)off_8CE4A38 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4A38);
      if ( GameModule_BattleGameSceneManager__LegendaryTileV1HexPassesBaseFilters((GameModule_HexBehaviour_o *)v15, v16) )
      {
        if ( v15 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( *(unsigned __int8 *)(v15 + 160) == v14
          && (System_String__op_Equality(
                *(_QWORD *)(v15 + 64),
                *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[336],
                0,
                v17)
            & 1) == 0
          && (System_String__op_Equality(
                *(_QWORD *)(v15 + 64),
                *(_QWORD *)&this->fields._unknown_object_0010_to_01FF[328],
                0,
                v18)
            & 1) == 0
          && *(_DWORD *)(v15 + 152) != 3 )
        {
          if ( v12 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v19 = *(_QWORD *)(v12 + 16);
          v20 = off_8D0B4E8;
          ++*(_DWORD *)(v12 + 28);
          if ( v19 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v21 = *(int *)(v12 + 24);
          if ( (unsigned int)v21 >= *(_DWORD *)(v19 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v12,
              v15,
              *(_QWORD *)(*(_QWORD *)(v20[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v12 + 24) = v21 + 1;
            *(_QWORD *)(v19 + 8 * v21 + 32) = v15;
          }
        }
      }
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v38, qword_8D02170);
  if ( v12 == 0 )
LABEL_49:
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(int *)(v12 + 24) > 0 )
  {
    v22 = (unsigned int)UnityEngine_Random__Range(0);
    v23 = v12;
    return (GameModule_HexBehaviour_o *)System_Collections_Generic_List_object___get_Item(v23, v22, qword_8D0B530);
  }
  return nullptr;
}
