void DataModule_PlayerShopData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x2
  __int64 Instance; // x0
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x20
  __int64 v15; // x21
  __int64 v16; // x20
  __int64 v17; // x21
  __int64 v18; // x20
  __int64 v19; // x21
  __int64 v20; // x20
  __int64 v21; // x21
  __int64 v22; // x20
  __int64 v23; // x21
  __int64 v24; // x0
  __int64 v25; // x20
  __int64 v26; // x20
  __int64 v27; // x20
  __int64 v28; // x0
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 v33; // x20
  _QWORD *v34; // x0
  __int64 v35; // x8
  __int64 v36; // x20
  unsigned int v37; // w21
  __int64 Item; // x0
  __int64 v39; // x3
  __int64 v40; // x22
  __int64 v41; // x0
  __int64 v42; // x20
  __int64 v43; // x20
  __int64 v44; // x1
  __int64 v45; // x2
  __int64 v46; // x0
  __int64 v47; // x20
  __int64 v48; // x0
  __int64 v49; // x10
  __int64 v50; // x1
  _QWORD *v51; // x9
  int v52; // w8
  __int64 v53; // x11
  unsigned int v54; // w9
  __int64 v55; // x11
  _QWORD *v56; // x12
  __int64 v57; // x1
  int v58; // w10
  unsigned int v59; // w8
  __int64 v60; // x11
  int v61; // w10
  __int64 v62; // x1
  _QWORD *v63; // x9
  unsigned int v64; // w9
  __int64 v65; // x11
  _QWORD *v66; // x12
  __int64 v67; // x1
  int v68; // w8
  unsigned int v69; // w10
  __int64 v70; // x9
  __int64 v71; // x1
  _QWORD *v72; // x11
  __int64 v73; // x0
  __int64 v74; // x0
  __int64 v75; // x0
  void *v76; // x0
  __int64 v77; // x8
  __int64 v78; // x8
  __int64 v79; // x8
  __int64 v80; // x20
  _QWORD *v81; // x0
  __int64 v82; // x8
  __int64 v83; // x8
  __int64 v84; // x8
  __int64 v85; // x21
  __int64 v86; // x22
  __int64 v87; // x0
  __int64 v88; // x21
  _QWORD *v89; // x8
  __int64 v90; // x22
  __int64 v91; // x23
  __int64 v92; // x0
  _QWORD *v93; // x8
  __int64 v94; // x22
  __int64 v95; // x23
  __int64 v96; // x24
  __int64 v97; // x24
  __int64 v98; // x25
  __int64 v99; // x0
  __int64 v100; // x8
  __int64 v101; // x22
  char v102; // w29
  unsigned int v103; // w23
  __int64 v104; // x0
  __int64 v105; // x24
  __int64 v106; // x3
  __int64 v107; // x0
  char Value; // w0
  __int64 v109; // x25
  unsigned int v110; // w0
  unsigned int v111; // w0
  __int64 v112; // x0
  void *v113; // x0
  _QWORD v114[5]; // [xsp+0h] [xbp-C0h] BYREF
  __int64 v115; // [xsp+28h] [xbp-98h] BYREF
  _QWORD v116[6]; // [xsp+30h] [xbp-90h] BYREF

  if ( (byte_9000742 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE738);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00AA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00AA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D00A90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE1F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA4D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2AD40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B7A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D053F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D053F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D05400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB080);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB818);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDB078);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7CA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7CB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D07A58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F558);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B160);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F5C0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0E698);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E6A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F560);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F5C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49360);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49368);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49370);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49380);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF4A08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C948);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C978);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C938);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C9C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53870);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7CA28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53878);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53868);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C940);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C8C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C908);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C8D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C8E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6E650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D530A8);
    byte_9000742 = 1;
  }
  memset(v116, 0, 40);
  v115 = 0;
  ServerBaseData__Init(self, 0);
  v3 = *((_QWORD *)self + 23);
  if ( v3 == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
    System_Collections_Generic_Dictionary_object__int____ctor(v3, qword_8CFEA38);
    *((_QWORD *)self + 23) = v3;
    if ( v3 == 0 )
      goto LABEL_137;
  }
  System_Collections_Generic_Dictionary_object__int___TryAdd(v3, qword_8D7C978, 0, qword_8CFEA80);
  v4 = *((_QWORD *)self + 23);
  if ( v4 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_object__int___TryAdd(v4, qword_8D7C9C8, 0, qword_8CFEA80);
  v5 = *((_QWORD *)self + 23);
  if ( v5 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_object__int___TryAdd(v5, qword_8D7CA28, 0, qword_8CFEA80);
  v6 = *((_QWORD *)self + 23);
  if ( v6 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_object__int___TryAdd(v6, qword_8D7C8D8, 0, qword_8CFEA80);
  v7 = *((_QWORD *)self + 23);
  if ( v7 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_object__int___TryAdd(v7, qword_8D7C8E8, 0, qword_8CFEA80);
  v8 = *((_QWORD *)self + 23);
  if ( v8 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_object__int___TryAdd(v8, qword_8D7C980, 0, qword_8CFEA80);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v9, v10);
  if ( Instance == 0 )
    goto LABEL_137;
  if ( (SDKModule_ABTestManager__get_ShopImproveV1IsBTest(Instance, 0) & 1) != 0 )
  {
    v12 = *((_QWORD *)self + 23);
    if ( v12 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__int___TryAdd(v12, qword_8D7C908, 0, qword_8CFEA80);
    v13 = *((_QWORD *)self + 23);
    if ( v13 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__int___TryAdd(v13, qword_8D7C8C8, 0, qword_8CFEA80);
  }
  v14 = *((_QWORD *)self + 22);
  if ( v14 == 0 )
  {
    v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA4D8);
    System_Collections_Generic_Dictionary_Int32Enum__object____ctor(v14, qword_8D00A90);
    *((_QWORD *)self + 22) = v14;
  }
  v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7898);
  DataModule_FundData___ctor(v15, 0);
  if ( v14 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___TryAdd(v14, 0, v15, qword_8D00AA8);
  v16 = *((_QWORD *)self + 22);
  v17 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7898);
  DataModule_FundData___ctor(v17, 1);
  if ( v16 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___TryAdd(v16, 1, v17, qword_8D00AA8);
  v18 = *((_QWORD *)self + 22);
  v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7898);
  DataModule_FundData___ctor(v19, 2);
  if ( v18 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___TryAdd(v18, 2, v19, qword_8D00AA8);
  v20 = *((_QWORD *)self + 22);
  v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7898);
  DataModule_FundData___ctor(v21, 3);
  if ( v20 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___TryAdd(v20, 3, v21, qword_8D00AA8);
  v22 = *((_QWORD *)self + 22);
  v23 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7898);
  DataModule_FundData___ctor(v23, 4);
  if ( v22 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___TryAdd(v22, 4, v23, qword_8D00AA8);
  v24 = *((_QWORD *)self + 22);
  if ( v24 == 0 )
    goto LABEL_137;
  System_Collections_Generic_Dictionary_Int32Enum__object___GetEnumerator(v114, v24, qword_8D00AA0);
  qmemcpy(v116, v114, 40);
  while ( (System_Collections_Generic_Dictionary_Enumerator_Int32Enum__object___MoveNext(v116, qword_8D053F8) & 1) != 0 )
  {
    if ( v116[3] == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    DataModule_FundData__Init();
  }
  System_Collections_Generic_Dictionary_Enumerator_Int32Enum__object___Dispose(v116, qword_8D053F0);
  if ( *((_QWORD *)self + 24) == 0 )
  {
    v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7CB0);
    DataModule_GiftChainData___ctor();
    *((_QWORD *)self + 24) = v25;
  }
  if ( *((_QWORD *)self + 25) == 0 )
  {
    v26 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7CA8);
    DataModule_GiftChain2Data___ctor();
    *((_QWORD *)self + 25) = v26;
  }
  if ( *((_QWORD *)self + 29) == 0 )
  {
    v27 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C70);
    System_Collections_Generic_Dictionary_object__bool____ctor(v27, qword_8CFE1F8);
    *((_QWORD *)self + 29) = v27;
    if ( v27 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v27, qword_8D7C920, 0, qword_8CFE208);
    v28 = *((_QWORD *)self + 29);
    if ( v28 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v28, qword_8D7C928, 0, qword_8CFE208);
    v29 = *((_QWORD *)self + 29);
    if ( v29 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v29, qword_8D7C930, 0, qword_8CFE208);
    v30 = *((_QWORD *)self + 29);
    if ( v30 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v30, qword_8D7C938, 0, qword_8CFE208);
    v31 = *((_QWORD *)self + 29);
    if ( v31 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v31, qword_8D7C940, 0, qword_8CFE208);
    v32 = *((_QWORD *)self + 29);
    if ( v32 == 0 )
      goto LABEL_137;
    System_Collections_Generic_Dictionary_object__bool___Add(v32, qword_8D7C948, 0, qword_8CFE208);
  }
  if ( *((_QWORD *)self + 34) == 0 )
  {
    v33 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C70);
    System_Collections_Generic_Dictionary_object__bool____ctor(v33, qword_8CFE1F8);
    *((_QWORD *)self + 34) = v33;
    v34 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v34 == nullptr )
      goto LABEL_137;
    v35 = v34[5];
    if ( v35 == 0 )
      goto LABEL_137;
    v36 = *(_QWORD *)(v35 + 296);
    if ( v36 == 0 )
      goto LABEL_137;
    if ( *(int *)(v36 + 24) >= 1 )
    {
      v37 = 0;
      do
      {
        Item = System_Collections_Generic_List_object___get_Item(v36, v37, qword_8D0B168);
        if ( Item == 0 )
          goto LABEL_137;
        if ( (System_String__op_Equality(*(_QWORD *)(Item + 40), qword_8D6E650, 0, v39) & 1) != 0 )
        {
          v40 = *((_QWORD *)self + 34);
          v41 = System_Collections_Generic_List_object___get_Item(v36, v37, qword_8D0B168);
          if ( v41 == 0 || v40 == 0 )
            goto LABEL_137;
          System_Collections_Generic_Dictionary_object__bool___Add(v40, *(_QWORD *)(v41 + 56), 0, qword_8CFE208);
        }
        ++v37;
      }
      while ( (signed int)v37 < *(_DWORD *)(v36 + 24) );
    }
  }
  if ( *((_QWORD *)self + 35) == 0 )
  {
    v42 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
    System_Collections_Generic_Dictionary_int__int____ctor(v42, qword_8CFC8D0);
    *((_QWORD *)self + 35) = v42;
  }
  if ( *((_QWORD *)self + 37) == 0 )
  {
    v43 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
    System_Collections_Generic_Dictionary_int__int____ctor(v43, qword_8CFC8D0);
    *((_QWORD *)self + 37) = v43;
  }
  ((void (__fastcall *)(void *))DataModule_PlayerShopData__NormalizeArtifactPackConfigForBGroup)(self);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v46 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v44, v45);
  if ( v46 == 0 )
LABEL_137:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (SDKModule_ABTestManager__get_NewCardsV1IsB(v46, 0) & 1) == 0 )
  {
    v47 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    v48 = System_Collections_Generic_List_object____ctor(v47, qword_8D0E5E0);
    if ( v47 == 0 )
      goto LABEL_137;
    v49 = *(_QWORD *)(v47 + 16);
    v50 = qword_8D53878;
    v51 = off_8D0E5F8;
    v52 = *(_DWORD *)(v47 + 28) + 1;
    *(_DWORD *)(v47 + 28) = v52;
    if ( v49 == 0 )
      goto LABEL_137;
    v53 = *(int *)(v47 + 24);
    if ( (unsigned int)v53 >= *(_DWORD *)(v49 + 24) )
    {
      v48 = System_Collections_Generic_List_object___AddWithResize(
              v47,
              v50,
              *(_QWORD *)(*(_QWORD *)(v51[4] + 192LL) + 112LL));
      v54 = *(_DWORD *)(v47 + 24);
      v52 = *(_DWORD *)(v47 + 28);
    }
    else
    {
      v54 = v53 + 1;
      *(_DWORD *)(v47 + 24) = v53 + 1;
      *(_QWORD *)(v49 + 8 * v53 + 32) = v50;
    }
    v55 = *(_QWORD *)(v47 + 16);
    v56 = off_8D0E5F8;
    v57 = qword_8D53898;
    v58 = v52 + 1;
    *(_DWORD *)(v47 + 28) = v52 + 1;
    if ( v55 == 0 )
      goto LABEL_137;
    if ( v54 >= *(_DWORD *)(v55 + 24) )
    {
      v48 = System_Collections_Generic_List_object___AddWithResize(
              v47,
              v57,
              *(_QWORD *)(*(_QWORD *)(v56[4] + 192LL) + 112LL));
      v59 = *(_DWORD *)(v47 + 24);
      v58 = *(_DWORD *)(v47 + 28);
    }
    else
    {
      v59 = v54 + 1;
      *(_DWORD *)(v47 + 24) = v54 + 1;
      *(_QWORD *)(v55 + 8LL * (int)v54 + 32) = v57;
    }
    v60 = *(_QWORD *)(v47 + 16);
    v61 = v58 + 1;
    v62 = qword_8D53868;
    v63 = off_8D0E5F8;
    *(_DWORD *)(v47 + 28) = v61;
    if ( v60 == 0 )
      goto LABEL_137;
    if ( v59 >= *(_DWORD *)(v60 + 24) )
    {
      v48 = System_Collections_Generic_List_object___AddWithResize(
              v47,
              v62,
              *(_QWORD *)(*(_QWORD *)(v63[4] + 192LL) + 112LL));
      v64 = *(_DWORD *)(v47 + 24);
      v61 = *(_DWORD *)(v47 + 28);
    }
    else
    {
      v64 = v59 + 1;
      *(_DWORD *)(v47 + 24) = v59 + 1;
      *(_QWORD *)(v60 + 8LL * (int)v59 + 32) = v62;
    }
    v65 = *(_QWORD *)(v47 + 16);
    v66 = off_8D0E5F8;
    v67 = qword_8D53870;
    v68 = v61 + 1;
    *(_DWORD *)(v47 + 28) = v61 + 1;
    if ( v65 == 0 )
      goto LABEL_137;
    if ( v64 >= *(_DWORD *)(v65 + 24) )
    {
      v48 = System_Collections_Generic_List_object___AddWithResize(
              v47,
              v67,
              *(_QWORD *)(*(_QWORD *)(v66[4] + 192LL) + 112LL));
      v69 = *(_DWORD *)(v47 + 24);
      v68 = *(_DWORD *)(v47 + 28);
    }
    else
    {
      v69 = v64 + 1;
      *(_DWORD *)(v47 + 24) = v64 + 1;
      *(_QWORD *)(v65 + 8LL * (int)v64 + 32) = v67;
    }
    v70 = *(_QWORD *)(v47 + 16);
    v71 = qword_8D53888;
    v72 = off_8D0E5F8;
    *(_DWORD *)(v47 + 28) = v68 + 1;
    if ( v70 == 0 )
      goto LABEL_137;
    if ( v69 >= *(_DWORD *)(v70 + 24) )
    {
      v48 = System_Collections_Generic_List_object___AddWithResize(
              v47,
              v71,
              *(_QWORD *)(*(_QWORD *)(v72[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v47 + 24) = v69 + 1;
      *(_QWORD *)(v70 + 8LL * (int)v69 + 32) = v71;
    }
    v73 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD, __int64))DataModule_PlayerShopData__ReplaceBlackListKeys)(
            v48,
            1,
            *((_QWORD *)self + 6),
            v47);
    if ( v73 != 0 )
      *((_QWORD *)self + 6) = v73;
    v74 = DataModule_PlayerShopData__ReplaceBlackListKeys();
    if ( v74 != 0 )
      *((_QWORD *)self + 4) = v74;
    v75 = DataModule_PlayerShopData__ReplaceBlackListKeys();
    if ( v75 != 0 )
      *((_QWORD *)self + 3) = v75;
    v76 = **((void ***)off_8CD9250 + 23);
    if ( v76 == nullptr )
      goto LABEL_137;
    DbtSaveDataManagerBase_object__object___Save(v76, (const MethodInfo *)qword_8CFB3A8);
  }
  v77 = *((_QWORD *)self + 2);
  if ( v77 != 0 && *(int *)(v77 + 24) >= 1 )
  {
    v78 = **((_QWORD **)off_8CD9208 + 23);
    if ( v78 == 0 )
      goto LABEL_137;
    v79 = *(_QWORD *)(v78 + 48);
    if ( v79 == 0 )
      goto LABEL_137;
    if ( *(_QWORD *)(v79 + 16) == 0 )
      return;
    v80 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4A10);
    System_Object___ctor(v80, 0);
    v81 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v81 == nullptr )
      goto LABEL_137;
    v82 = v81[5];
    if ( v82 == 0 )
      goto LABEL_137;
    if ( v80 == 0 )
      goto LABEL_137;
    *(_QWORD *)(v80 + 16) = *(_QWORD *)(v82 + 104);
    v83 = **((_QWORD **)off_8CD9208 + 23);
    if ( v83 == 0 )
      goto LABEL_137;
    v84 = *(_QWORD *)(v83 + 48);
    if ( v84 == 0 )
      goto LABEL_137;
    v85 = *(_QWORD *)(v84 + 16);
    v86 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB810);
    System_Func_object__bool____ctor(v86, v80, qword_8D49380, 0);
    v87 = System_Linq_Enumerable__Where_object_(v85, v86, qword_8D2B7A0);
    v88 = System_Linq_Enumerable__ToList_object_(v87, qword_8D2B5E0);
    v89 = off_8CF4A08;
    if ( *((_DWORD *)off_8CF4A08 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF4A08);
      v89 = off_8CF4A08;
    }
    v90 = *(_QWORD *)(v89[23] + 8LL);
    if ( v90 == 0 )
    {
      if ( *((_DWORD *)v89 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v89);
        v89 = off_8CF4A08;
      }
      v91 = *(_QWORD *)v89[23];
      v90 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB818);
      System_Func_object__int____ctor(v90, v91, qword_8D49360, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF4A08 + 23) + 8LL) = v90;
    }
    v92 = System_Linq_Enumerable__GroupBy_object__int_(v88, v90, qword_8D2AD40);
    v93 = off_8CF4A08;
    v94 = v92;
    if ( *((_DWORD *)off_8CF4A08 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF4A08);
      v93 = off_8CF4A08;
    }
    v95 = *(_QWORD *)(v93[23] + 16LL);
    if ( v95 == 0 )
    {
      if ( *((_DWORD *)v93 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v93);
        v93 = off_8CF4A08;
      }
      v96 = *(_QWORD *)v93[23];
      v95 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB080);
      System_Func_object__int____ctor(v95, v96, qword_8D49368, 0);
      v93 = off_8CF4A08;
      *(_QWORD *)(*((_QWORD *)off_8CF4A08 + 23) + 16LL) = v95;
    }
    if ( *((_DWORD *)v93 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v93);
      v93 = off_8CF4A08;
    }
    v97 = *(_QWORD *)(v93[23] + 32LL);
    if ( v97 == 0 )
    {
      if ( *((_DWORD *)v93 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v93);
        v93 = off_8CF4A08;
      }
      v98 = *(_QWORD *)v93[23];
      v97 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDB078);
      System_Func_object__object____ctor(v97, v98, qword_8D49370, 0);
      *(_QWORD *)(*((_QWORD *)off_8CF4A08 + 23) + 32LL) = v97;
    }
    v99 = System_Linq_Enumerable__ToDictionary_object__int__object_(v94, v95, v97, qword_8D2B378);
    v100 = *((_QWORD *)self + 2);
    if ( v100 == 0 )
      goto LABEL_137;
    v101 = v99;
    v102 = 0;
    v103 = 0;
    while ( 1 )
    {
      if ( (signed int)v103 >= *(_DWORD *)(v100 + 24) )
      {
        DataModule_PlayerShopData__ReCountPayCount(self);
        if ( (v102 & 1) == 0 )
          return;
        v113 = **((void ***)off_8CD9250 + 23);
        if ( v113 != nullptr )
        {
          DbtSaveDataManagerBase_object__object___Save(v113, (const MethodInfo *)qword_8CFB3A8);
          return;
        }
        goto LABEL_137;
      }
      v104 = System_Collections_Generic_List_object___get_Item(v100, v103, qword_8D0F560);
      if ( v104 != 0 )
      {
        v105 = v104;
        if ( (ToolModule_StringTool__IsNullOrEmpty(*(_QWORD *)(v104 + 16), 1, 0) & 1) == 0
          && (System_String__op_Equality(*(_QWORD *)(v105 + 16), qword_8D530A8, 0, v106) & 1) == 0 )
        {
          v107 = *(_QWORD *)(v80 + 16);
          if ( v107 == 0 )
            goto LABEL_137;
          if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
                  v107,
                  *(_QWORD *)(v105 + 16),
                  qword_8CFE738)
              & 1) == 0 )
          {
            if ( v101 == 0 )
              goto LABEL_137;
            Value = System_Collections_Generic_Dictionary_int__object___TryGetValue(
                      v101,
                      *(unsigned int *)(v105 + 24),
                      &v115,
                      qword_8CFC260);
            v109 = v115;
            if ( v115 != 0 && (Value & 1) != 0 && *(int *)(v115 + 24) >= 1 )
            {
              v110 = UnityEngine_Random__Range(0);
              *(_QWORD *)(v105 + 16) = System_Collections_Generic_List_object___get_Item(v109, v110, qword_8D0E6A0);
            }
            else
            {
              if ( v88 == 0 )
                goto LABEL_137;
              if ( *(int *)(v88 + 24) < 1 )
                goto LABEL_136;
              v111 = UnityEngine_Random__Range(0);
              v112 = System_Collections_Generic_List_object___get_Item(v88, v111, qword_8D0F5C8);
              if ( v112 == 0 )
                goto LABEL_137;
              *(_QWORD *)(v105 + 16) = *(_QWORD *)(v112 + 16);
            }
            v102 = 1;
          }
        }
      }
LABEL_136:
      v100 = *((_QWORD *)self + 2);
      ++v103;
      if ( v100 == 0 )
        goto LABEL_137;
    }
  }
}
