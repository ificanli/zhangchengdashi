__int64 __fastcall GameModule_BattleGameSceneManager__GetMainTowerNearArchitecture(_QWORD *a1, char a2)
{
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  __int64 v8; // x19
  long double v9; // q0
  float v10; // s8
  long double v11; // q0
  float v12; // s9
  __int64 v13; // x22
  long double v14; // q0
  long double v15; // q0
  long double v16; // q0
  float v17; // s10
  __int64 Item; // x0
  __int64 transform; // x0
  float v20; // s11
  float v21; // s1
  float v22; // s12
  float v23; // s2
  float v24; // s13
  __int64 v25; // x2
  unsigned int v26; // w21
  float v27; // s14
  int v28; // w22
  __int64 v29; // x0
  __int64 v30; // x0
  float v31; // s11
  float v32; // s1
  float v33; // s12
  float v34; // s2
  float v35; // s13
  float v36; // s0
  __int64 v38; // x0

  if ( (byte_8FFD78D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACF8);
    byte_8FFD78D = 1;
  }
  v4 = a1[44];
  if ( v4 == 0 )
    goto LABEL_42;
  v5 = System_String__Split(v4, 95, 0, 0);
  if ( a1[43] == 0 )
    goto LABEL_42;
  v6 = v5;
  v7 = System_String__Split(a1[43], 95, 0, 0);
  if ( (a2 & 1) != 0 )
  {
    if ( v6 == 0 )
      goto LABEL_42;
    if ( *(_DWORD *)(v6 + 24) != 0 )
    {
      v8 = a1[20];
      v9 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v6 + 32), 0);
      if ( *(_DWORD *)(v6 + 24) > 1u )
      {
        v10 = *(float *)&v9;
        v11 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v6 + 40), 0);
        if ( *(_DWORD *)(v6 + 24) > 2u )
        {
          v12 = *(float *)&v11;
          goto LABEL_16;
        }
      }
    }
LABEL_43:
    ((void (__fastcall *)(__int64))unk_3C3D4D4)(v7);
    JUMPOUT(0x3DF0358);
  }
  v13 = v7;
  if ( v7 == 0 )
    goto LABEL_42;
  if ( *(_DWORD *)(v7 + 24) == 0 )
    goto LABEL_43;
  v8 = a1[21];
  v14 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v7 + 32), 0);
  if ( *(_DWORD *)(v13 + 24) <= 1u )
    goto LABEL_43;
  v10 = *(float *)&v14;
  v15 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v13 + 40), 0);
  if ( *(_DWORD *)(v13 + 24) <= 2u )
    goto LABEL_43;
  v12 = *(float *)&v15;
  v6 = v13;
LABEL_16:
  v16 = ToolModule_StringTool__ToFloat(*(_QWORD *)(v6 + 48), 0);
  if ( v8 == 0 )
    goto LABEL_42;
  if ( *(int *)(v8 + 24) < 1 )
    return 0;
  v17 = *(float *)&v16;
  Item = System_Collections_Generic_List_object___get_Item(v8, 0, qword_8D0ACF8);
  if ( Item == 0 )
    goto LABEL_42;
  transform = UnityEngine_GameObject__get_transform(Item, 0);
  if ( transform == 0 )
    goto LABEL_42;
  LODWORD(v20) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
  v22 = v21;
  v24 = v23;
  if ( byte_8FFD020 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFD020 = 1;
  }
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA738);
  v25 = qword_8D0ACF8;
  if ( *(int *)(v8 + 24) >= 2 )
  {
    v26 = 0;
    v27 = sqrtf(
            (float)((float)(v17 - v24) * (float)(v17 - v24))
          + (float)((float)((float)(v10 - v20) * (float)(v10 - v20)) + (float)((float)(v12 - v22) * (float)(v12 - v22))));
    v28 = 1;
    while ( 1 )
    {
      v29 = System_Collections_Generic_List_object___get_Item(v8, (unsigned int)v28, v25);
      if ( v29 == 0 )
        goto LABEL_42;
      v30 = UnityEngine_GameObject__get_transform(v29, 0);
      if ( v30 == 0 )
        goto LABEL_42;
      LODWORD(v31) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v30, 0));
      v33 = v32;
      v35 = v34;
      if ( byte_8FFD020 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD020 = 1;
      }
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v25 = qword_8D0ACF8;
      v36 = sqrtf(
              (float)((float)(v17 - v35) * (float)(v17 - v35))
            + (float)((float)((float)(v10 - v31) * (float)(v10 - v31)) + (float)((float)(v12 - v33) * (float)(v12 - v33))));
      if ( v27 > v36 )
        v26 = v28;
      ++v28;
      if ( v27 > v36 )
        v27 = v36;
      if ( v28 >= *(_DWORD *)(v8 + 24) )
        goto LABEL_40;
    }
  }
  v26 = 0;
LABEL_40:
  v38 = System_Collections_Generic_List_object___get_Item(v8, v26, v25);
  if ( v38 == 0 )
LABEL_42:
    il2cpp_codegen_raise_null_reference_exception();
  return UnityEngine_GameObject__get_transform(v38, 0);
}
