__int64 __fastcall GameModule_BattleGameSceneManager__GetNearObj(
        __int64 *a1,
        char a2,
        char a3,
        char a4,
        __int64 a5,
        float a6,
        float a7,
        float a8,
        float a9)
{
  __int64 v18; // x24
  __int64 *v19; // x8
  __int64 v20; // x24
  __int64 v21; // x19
  int v22; // w24
  __int64 Item; // x0
  __int64 Component_object; // x0
  unsigned int v25; // w21
  __int64 *v26; // x8
  __int64 v27; // x21
  int v28; // w20
  __int64 v29; // x0
  __int64 transform; // x0
  float v31; // s12
  float v32; // s1
  float v33; // s13
  float v34; // s2
  float v35; // s14
  __int64 v36; // x0
  __int64 v37; // x0
  float v38; // s11
  float v39; // s1
  float v40; // s12
  float v41; // s2
  float v42; // s13
  float v43; // s14
  int v44; // w22
  __int64 v45; // x0
  __int64 v46; // x0
  float v47; // s11
  float v48; // s1
  float v49; // s12
  float v50; // s2
  float v51; // s13
  float v52; // s0
  __int64 v53; // x0

  if ( (byte_8FFD7A2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D938);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2DBF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AC88);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD780);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD7A2 = 1;
  }
  if ( (int)UnityEngine_Random__Range(0) > 49 || (a3 & 1) != 0 )
  {
    v19 = a1 + 22;
    if ( (a2 & 1) == 0 )
      v19 = a1 + 23;
    v20 = *v19;
    v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD780);
    sub_574EE80(v21, v20, qword_8D0AC88);
    if ( v21 == 0 )
      goto LABEL_72;
    v22 = *(_DWORD *)(v21 + 24) - 1;
    if ( v22 >= 0 )
    {
      do
      {
        Item = System_Collections_Generic_List_object___get_Item(v21, (unsigned int)v22, qword_8D0ACF8);
        if ( Item == 0 )
          goto LABEL_72;
        Component_object = UnityEngine_GameObject__GetComponent_object_(Item, qword_8D2DBF0);
        if ( Component_object == 0 )
          goto LABEL_72;
        if ( *(_BYTE *)(Component_object + 396) != 0 )
          System_Collections_Generic_List_object___RemoveAt(v21, (unsigned int)v22, qword_8D0ACD8);
      }
      while ( --v22 >= 0 );
    }
  }
  else
  {
    if ( (a2 & 1) != 0 )
      v18 = a1[20];
    else
      v18 = a1[21];
    v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD780);
    sub_574EE80(v21, v18, qword_8D0AC88);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(a5, 0, 0) & 1) != 0 )
  {
    if ( v21 == 0 )
      goto LABEL_72;
    if ( (System_Collections_Generic_List_object___Contains(v21, a5, qword_8D0ACB0) & 1) != 0 )
      System_Collections_Generic_List_object___Remove(v21, a5, qword_8D0ACC8);
  }
  else if ( v21 == 0 )
  {
    goto LABEL_72;
  }
  if ( *(int *)(v21 + 24) <= 0 )
  {
    v26 = a1 + 20;
    if ( (a2 & 1) == 0 )
      v26 = a1 + 21;
    v27 = *v26;
    v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD780);
    sub_574EE80(v21, v27, qword_8D0AC88);
    if ( (a4 & 1) != 0 )
      goto LABEL_28;
  }
  else if ( (a4 & 1) != 0 )
  {
LABEL_28:
    if ( v21 == 0 )
      goto LABEL_72;
    v25 = UnityEngine_Random__Range(0);
    goto LABEL_68;
  }
  if ( a9 <= 0.0 )
  {
LABEL_45:
    if ( v21 == 0 )
      goto LABEL_72;
  }
  else
  {
    if ( v21 == 0 )
      goto LABEL_72;
    v28 = *(_DWORD *)(v21 + 24) - 1;
    if ( v28 >= 0 )
    {
      while ( 1 )
      {
        v29 = System_Collections_Generic_List_object___get_Item(v21, (unsigned int)v28, qword_8D0ACF8);
        if ( v29 == 0 )
          goto LABEL_72;
        transform = UnityEngine_GameObject__get_transform(v29, 0);
        if ( transform == 0 )
          goto LABEL_72;
        LODWORD(v31) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
        v33 = v32;
        v35 = v34;
        if ( byte_8FFD020 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD020 = 1;
        }
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        if ( sqrtf(
               (float)((float)(a8 - v35) * (float)(a8 - v35))
             + (float)((float)((float)(a6 - v31) * (float)(a6 - v31)) + (float)((float)(a7 - v33) * (float)(a7 - v33)))) > a9 )
          System_Collections_Generic_List_object___RemoveAt(v21, (unsigned int)v28, qword_8D0ACD8);
        if ( --v28 < 0 )
          goto LABEL_45;
      }
    }
  }
  if ( *(_DWORD *)(v21 + 24) == 0 )
    return 0;
  v36 = System_Collections_Generic_List_object___get_Item(v21, 0, qword_8D0ACF8);
  if ( v36 == 0 )
    goto LABEL_72;
  v37 = UnityEngine_GameObject__get_transform(v36, 0);
  if ( v37 == 0 )
    goto LABEL_72;
  LODWORD(v38) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v37, 0));
  v40 = v39;
  v42 = v41;
  if ( byte_8FFD020 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFD020 = 1;
  }
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA738);
  if ( *(int *)(v21 + 24) > 1 )
  {
    v25 = 0;
    v43 = sqrtf(
            (float)((float)(a8 - v42) * (float)(a8 - v42))
          + (float)((float)((float)(a6 - v38) * (float)(a6 - v38)) + (float)((float)(a7 - v40) * (float)(a7 - v40))));
    v44 = 1;
    while ( 1 )
    {
      v45 = System_Collections_Generic_List_object___get_Item(v21, (unsigned int)v44, qword_8D0ACF8);
      if ( v45 == 0 )
        goto LABEL_72;
      v46 = UnityEngine_GameObject__get_transform(v45, 0);
      if ( v46 == 0 )
        goto LABEL_72;
      LODWORD(v47) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(v46, 0));
      v49 = v48;
      v51 = v50;
      if ( byte_8FFD020 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
        byte_8FFD020 = 1;
      }
      if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEA738);
      v52 = sqrtf(
              (float)((float)(a8 - v51) * (float)(a8 - v51))
            + (float)((float)((float)(a6 - v47) * (float)(a6 - v47)) + (float)((float)(a7 - v49) * (float)(a7 - v49))));
      if ( v43 > v52 )
        v25 = v44;
      ++v44;
      if ( v43 > v52 )
        v43 = v52;
      if ( v44 >= *(_DWORD *)(v21 + 24) )
        goto LABEL_68;
    }
  }
  v25 = 0;
LABEL_68:
  if ( *(int *)(v21 + 24) >= 1 )
  {
    v53 = System_Collections_Generic_List_object___get_Item(v21, v25, qword_8D0ACF8);
    if ( v53 != 0 )
      return UnityEngine_GameObject__GetComponent_object_(v53, qword_8D2D938);
LABEL_72:
    il2cpp_codegen_raise_null_reference_exception();
  }
  return 0;
}
