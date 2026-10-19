void DataModule_PlayerRankData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x10
  __int64 v5; // x1
  _QWORD *v6; // x9
  int v7; // w8
  __int64 v8; // x11
  unsigned int v9; // w9
  __int64 v10; // x1
  __int64 v11; // x11
  _QWORD *v12; // x12
  int v13; // w10
  unsigned int v14; // w8
  __int64 v15; // x1
  __int64 v16; // x11
  _QWORD *v17; // x9
  int v18; // w10
  unsigned int v19; // w9
  __int64 v20; // x1
  __int64 v21; // x11
  _QWORD *v22; // x12
  int v23; // w8
  unsigned int v24; // w10
  __int64 v25; // x1
  __int64 v26; // x9
  _QWORD *v27; // x11
  __int64 v28; // x21
  __int64 v29; // x2
  __int64 v30; // x10
  _QWORD *v31; // x9
  __int64 v32; // x1
  int v33; // w8
  __int64 v34; // x11
  unsigned int v35; // w9
  __int64 v36; // x1
  __int64 v37; // x11
  _QWORD *v38; // x12
  int v39; // w10
  unsigned int v40; // w8
  __int64 v41; // x1
  __int64 v42; // x11
  _QWORD *v43; // x12
  int v44; // w9
  unsigned int v45; // w10
  __int64 v46; // x1
  __int64 v47; // x8
  _QWORD *v48; // x11
  __int64 v49; // x8
  unsigned int v50; // w22
  __int64 Instance; // x0
  __int64 v52; // x1
  __int64 v53; // x2
  __int64 v54; // x0
  __int64 v55; // x0
  __int64 v56; // x0
  __int64 v57; // x1
  __int64 v58; // x2
  __int64 v59; // x0
  __int64 v60; // x0
  __int64 Item; // x0
  __int64 v62; // x0
  __int64 v63; // x0

  if ( (byte_900073B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0D788);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D790);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D538A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53728);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53870);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53878);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53868);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53880);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D538A8);
    byte_900073B = 1;
  }
  ServerBaseData__Init(self, 0);
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0E5E0);
  if ( v3 == 0 )
    goto LABEL_63;
  v4 = *(_QWORD *)(v3 + 16);
  v5 = qword_8D53888;
  v6 = off_8D0E5F8;
  v7 = *(_DWORD *)(v3 + 28) + 1;
  *(_DWORD *)(v3 + 28) = v7;
  if ( v4 == 0 )
    goto LABEL_63;
  v8 = *(int *)(v3 + 24);
  if ( (unsigned int)v8 >= *(_DWORD *)(v4 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v5, *(_QWORD *)(*(_QWORD *)(v6[4] + 192LL) + 112LL));
    v9 = *(_DWORD *)(v3 + 24);
    v7 = *(_DWORD *)(v3 + 28);
  }
  else
  {
    v9 = v8 + 1;
    *(_DWORD *)(v3 + 24) = v8 + 1;
    *(_QWORD *)(v4 + 8 * v8 + 32) = v5;
  }
  v10 = qword_8D53868;
  v11 = *(_QWORD *)(v3 + 16);
  v12 = off_8D0E5F8;
  v13 = v7 + 1;
  *(_DWORD *)(v3 + 28) = v7 + 1;
  if ( v11 == 0 )
    goto LABEL_63;
  if ( v9 >= *(_DWORD *)(v11 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v10, *(_QWORD *)(*(_QWORD *)(v12[4] + 192LL) + 112LL));
    v14 = *(_DWORD *)(v3 + 24);
    v13 = *(_DWORD *)(v3 + 28);
  }
  else
  {
    v14 = v9 + 1;
    *(_DWORD *)(v3 + 24) = v9 + 1;
    *(_QWORD *)(v11 + 8LL * (int)v9 + 32) = v10;
  }
  v15 = qword_8D53870;
  v16 = *(_QWORD *)(v3 + 16);
  v17 = off_8D0E5F8;
  v18 = v13 + 1;
  *(_DWORD *)(v3 + 28) = v18;
  if ( v16 == 0 )
    goto LABEL_63;
  if ( v14 >= *(_DWORD *)(v16 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v15, *(_QWORD *)(*(_QWORD *)(v17[4] + 192LL) + 112LL));
    v19 = *(_DWORD *)(v3 + 24);
    v18 = *(_DWORD *)(v3 + 28);
  }
  else
  {
    v19 = v14 + 1;
    *(_DWORD *)(v3 + 24) = v14 + 1;
    *(_QWORD *)(v16 + 8LL * (int)v14 + 32) = v15;
  }
  v20 = qword_8D53880;
  v21 = *(_QWORD *)(v3 + 16);
  v22 = off_8D0E5F8;
  v23 = v18 + 1;
  *(_DWORD *)(v3 + 28) = v18 + 1;
  if ( v21 == 0 )
    goto LABEL_63;
  if ( v19 >= *(_DWORD *)(v21 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v20, *(_QWORD *)(*(_QWORD *)(v22[4] + 192LL) + 112LL));
    v24 = *(_DWORD *)(v3 + 24);
    v23 = *(_DWORD *)(v3 + 28);
  }
  else
  {
    v24 = v19 + 1;
    *(_DWORD *)(v3 + 24) = v19 + 1;
    *(_QWORD *)(v21 + 8LL * (int)v19 + 32) = v20;
  }
  v25 = qword_8D53878;
  v26 = *(_QWORD *)(v3 + 16);
  v27 = off_8D0E5F8;
  *(_DWORD *)(v3 + 28) = v23 + 1;
  if ( v26 == 0 )
    goto LABEL_63;
  if ( v24 >= *(_DWORD *)(v26 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v3, v25, *(_QWORD *)(*(_QWORD *)(v27[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v3 + 24) = v24 + 1;
    *(_QWORD *)(v26 + 8LL * (int)v24 + 32) = v25;
  }
  v28 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v28, qword_8D0E5E0);
  if ( v28 == 0 )
    goto LABEL_63;
  v30 = *(_QWORD *)(v28 + 16);
  v31 = off_8D0E5F8;
  v32 = qword_8D538A8;
  v33 = *(_DWORD *)(v28 + 28) + 1;
  *(_DWORD *)(v28 + 28) = v33;
  if ( v30 == 0 )
    goto LABEL_63;
  v34 = *(int *)(v28 + 24);
  if ( (unsigned int)v34 >= *(_DWORD *)(v30 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v28, v32, *(_QWORD *)(*(_QWORD *)(v31[4] + 192LL) + 112LL));
    v35 = *(_DWORD *)(v28 + 24);
    v33 = *(_DWORD *)(v28 + 28);
  }
  else
  {
    v35 = v34 + 1;
    *(_DWORD *)(v28 + 24) = v34 + 1;
    *(_QWORD *)(v30 + 8 * v34 + 32) = v32;
  }
  v36 = qword_8D53898;
  v37 = *(_QWORD *)(v28 + 16);
  v38 = off_8D0E5F8;
  v39 = v33 + 1;
  *(_DWORD *)(v28 + 28) = v33 + 1;
  if ( v37 == 0 )
    goto LABEL_63;
  if ( v35 >= *(_DWORD *)(v37 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v28, v36, *(_QWORD *)(*(_QWORD *)(v38[4] + 192LL) + 112LL));
    v40 = *(_DWORD *)(v28 + 24);
    v39 = *(_DWORD *)(v28 + 28);
  }
  else
  {
    v40 = v35 + 1;
    *(_DWORD *)(v28 + 24) = v35 + 1;
    *(_QWORD *)(v37 + 8LL * (int)v35 + 32) = v36;
  }
  v41 = qword_8D538A0;
  v42 = *(_QWORD *)(v28 + 16);
  v43 = off_8D0E5F8;
  v44 = v39 + 1;
  *(_DWORD *)(v28 + 28) = v39 + 1;
  if ( v42 == 0 )
    goto LABEL_63;
  if ( v40 >= *(_DWORD *)(v42 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v28, v41, *(_QWORD *)(*(_QWORD *)(v43[4] + 192LL) + 112LL));
    v45 = *(_DWORD *)(v28 + 24);
    v44 = *(_DWORD *)(v28 + 28);
  }
  else
  {
    v45 = v40 + 1;
    *(_DWORD *)(v28 + 24) = v40 + 1;
    *(_QWORD *)(v42 + 8LL * (int)v40 + 32) = v41;
  }
  v46 = qword_8D53890;
  v47 = *(_QWORD *)(v28 + 16);
  v48 = off_8D0E5F8;
  *(_DWORD *)(v28 + 28) = v44 + 1;
  if ( v47 == 0 )
    goto LABEL_63;
  if ( v45 >= *(_DWORD *)(v47 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v28, v46, *(_QWORD *)(*(_QWORD *)(v48[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v28 + 24) = v45 + 1;
    *(_QWORD *)(v47 + 8LL * (int)v45 + 32) = v46;
  }
  v49 = *((_QWORD *)self + 2);
  if ( v49 == 0 )
LABEL_63:
    il2cpp_codegen_raise_null_reference_exception();
  v50 = 0;
  while ( (signed int)v50 < *(_DWORD *)(v49 + 24) )
  {
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v46, v29);
    if ( Instance == 0 )
      goto LABEL_63;
    if ( (SDKModule_ABTestManager__get_NewCardsV1IsB(Instance, 0) & 1) == 0 )
    {
      v60 = *((_QWORD *)self + 2);
      if ( v60 == 0 )
        goto LABEL_63;
      Item = System_Collections_Generic_List_object___get_Item(v60, v50, qword_8D0D790);
      if ( Item == 0 )
        goto LABEL_63;
      v57 = *(_QWORD *)(Item + 16);
      v58 = qword_8D0E618;
      v59 = v3;
      goto LABEL_58;
    }
    if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE1928);
    v54 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v52, v53);
    if ( v54 == 0 )
      goto LABEL_63;
    if ( (SDKModule_ABTestManager__get_WeeklyCardEventIsB(v54, 0) & 1) == 0 )
    {
      v55 = *((_QWORD *)self + 2);
      if ( v55 == 0 )
        goto LABEL_63;
      v56 = System_Collections_Generic_List_object___get_Item(v55, v50, qword_8D0D790);
      if ( v56 == 0 )
        goto LABEL_63;
      v57 = *(_QWORD *)(v56 + 16);
      v58 = qword_8D0E618;
      v59 = v28;
LABEL_58:
      if ( (System_Collections_Generic_List_object___Contains(v59, v57, v58) & 1) != 0 )
      {
        v62 = *((_QWORD *)self + 2);
        if ( v62 == 0 )
          goto LABEL_63;
        v63 = System_Collections_Generic_List_object___get_Item(v62, v50, qword_8D0D790);
        if ( v63 == 0 )
          goto LABEL_63;
        *(_QWORD *)(v63 + 16) = qword_8D53728;
      }
    }
    v49 = *((_QWORD *)self + 2);
    ++v50;
    if ( v49 == 0 )
      goto LABEL_63;
  }
}
