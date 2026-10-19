void DataModule_PlayerCardData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x20
  __int64 v12; // x21
  __int64 v13; // x22
  _QWORD *Instance; // x0
  __int64 v15; // x8
  __int64 v16; // x21
  __int64 v17; // x22
  __int64 v18; // x21
  __int64 v19; // x20
  __int64 v20; // x0
  __int64 v21; // x8
  _QWORD *v22; // x9
  __int64 v23; // x10
  _QWORD *v24; // x0
  __int64 v25; // x8
  __int64 v26; // x8
  __int64 v27; // x0
  __int64 v28; // x20
  _QWORD *v29; // x0
  __int64 v30; // x8
  __int64 v31; // x0
  __int64 v32; // x22
  __int64 v33; // x21
  __int64 v34; // x23
  __int64 v35; // x23
  __int64 v36; // x21
  __int64 v37; // x8
  __int64 v38; // x23
  __int64 v39; // x8
  __int64 v40; // x22
  __int64 String; // x0
  __int64 v42; // x0
  __int64 v43; // x22
  int v44; // w0
  __int64 v45; // x0
  __int64 v46; // x8
  _QWORD *v47; // x9
  __int64 v48; // x10
  __int64 v49; // x1
  __int64 v50; // x2
  __int64 v51; // x8
  __int64 v52; // x20
  int v53; // w22
  __int64 v54; // x20
  __int64 v55; // x21
  __int64 v56; // x9
  _QWORD *v57; // x8
  __int64 v58; // x10
  __int64 v59; // x10
  __int64 v60; // x10
  __int64 v61; // x10
  __int64 v62; // x10
  __int64 v63; // x10
  __int64 v64; // x10
  __int64 v65; // x10
  __int64 v66; // x0
  __int64 v67; // x8
  _QWORD *v68; // x9
  __int64 v69; // x10
  __int64 v70; // x0
  __int64 v71; // x1
  __int64 v72; // x2
  __int64 v73; // x20
  __int64 v74; // x10
  __int64 v75; // x1
  _QWORD *v76; // x9
  int v77; // w8
  __int64 v78; // x11
  unsigned int v79; // w9
  __int64 v80; // x10
  __int64 v81; // x1
  _QWORD *v82; // x11
  __int64 v83; // x0
  __int64 v84; // x1
  __int64 v85; // x2
  __int64 v86; // x20
  __int64 v87; // x10
  __int64 v88; // x1
  _QWORD *v89; // x9
  int v90; // w8
  __int64 v91; // x11
  unsigned int v92; // w9
  __int64 v93; // x11
  _QWORD *v94; // x12
  __int64 v95; // x1
  int v96; // w10
  unsigned int v97; // w8
  __int64 v98; // x11
  int v99; // w10
  __int64 v100; // x1
  _QWORD *v101; // x9
  unsigned int v102; // w9
  __int64 v103; // x11
  _QWORD *v104; // x12
  __int64 v105; // x1
  int v106; // w8
  unsigned int v107; // w10
  __int64 v108; // x9
  __int64 v109; // x1
  _QWORD *v110; // x11
  __int64 v111; // x0
  __int64 v112; // x20
  __int64 v113; // x10
  __int64 v114; // x1
  _QWORD *v115; // x9
  int v116; // w8
  __int64 v117; // x11
  unsigned int v118; // w9
  __int64 v119; // x11
  _QWORD *v120; // x12
  __int64 v121; // x1
  int v122; // w10
  unsigned int v123; // w8
  __int64 v124; // x11
  _QWORD *v125; // x12
  __int64 v126; // x1
  int v127; // w9
  unsigned int v128; // w10
  __int64 v129; // x8
  __int64 v130; // x1
  _QWORD *v131; // x11
  __int64 v132; // x0
  unsigned int v133; // w20
  __int64 v134; // x21
  __int64 Item; // x0
  _QWORD *v136; // x0
  __int64 v137; // x8
  __int64 v138; // x0
  __int64 v139; // x21
  __int64 v140; // x0
  __int64 v141; // x0
  __int64 v142; // x21
  __int64 v143; // x0
  __int64 v144; // x0
  __int64 v145; // x0
  __int64 v146; // x0
  __int64 v147; // x22
  __int64 v148; // x21
  __int64 v149; // x23
  __int64 v150; // x8
  unsigned __int64 v151; // x23
  unsigned int v152; // w0
  __int64 v153; // x0
  __int64 v154; // x22
  __int64 v155; // x0
  __int64 v156; // x0
  __int64 v157; // x21
  __int64 v158; // x0
  __int64 v159; // x0
  __int64 v160; // x19
  __int128 v161; // [xsp+8h] [xbp-B8h] BYREF
  __int64 v162; // [xsp+18h] [xbp-A8h]
  __int128 v163; // [xsp+20h] [xbp-A0h] BYREF
  __int64 v164; // [xsp+30h] [xbp-90h]
  int v165; // [xsp+3Ch] [xbp-84h] BYREF
  __int128 v166; // [xsp+40h] [xbp-80h] BYREF
  __int64 v167; // [xsp+50h] [xbp-70h]

  if ( (byte_9000725 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE6E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA058);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA068);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01FF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02500);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D02508);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D01FF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02510);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D02000);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0BE78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0F588);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AF88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F590);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0AF98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BEA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F580);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0F530);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F5C0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0AFB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F5C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE418);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBB00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF100);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDF2C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D492B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D492B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4968);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D492C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4970);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF130);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53858);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D538A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53860);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53898);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68BD0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7C3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53870);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53878);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53868);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53880);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D538A8);
    byte_9000725 = 1;
  }
  v166 = 0u;
  v167 = 0;
  v165 = 0;
  v163 = 0u;
  v164 = 0;
  ServerBaseData__Init(self, 0);
  if ( *((_QWORD *)self + 2) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE418);
    System_Collections_Generic_List_object____ctor(v3, qword_8D0F580);
    *((_QWORD *)self + 2) = v3;
  }
  if ( *((_QWORD *)self + 4) == 0 )
  {
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v4, qword_8D0E5E0);
    *((_QWORD *)self + 4) = v4;
  }
  if ( *((_QWORD *)self + 3) == 0 )
  {
    v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA068);
    System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFF618);
    *((_QWORD *)self + 3) = v5;
  }
  if ( *((_QWORD *)self + 5) == 0 )
  {
    v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE400);
    System_Collections_Generic_List_object____ctor(v6, qword_8D0F520);
    *((_QWORD *)self + 5) = v6;
  }
  if ( *((_QWORD *)self + 7) == 0 )
  {
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
    System_Collections_Generic_List_int____ctor(v7, qword_8D0BE60);
    *((_QWORD *)self + 7) = v7;
  }
  if ( *((_QWORD *)self + 8) == 0 )
  {
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA058);
    System_Collections_Generic_Dictionary_object__object____ctor(v8, qword_8CFF5C0);
    *((_QWORD *)self + 8) = v8;
  }
  if ( *((_QWORD *)self + 9) == 0 )
  {
    v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
    System_Collections_Generic_Dictionary_object__int____ctor(v9, qword_8CFEA38);
    *((_QWORD *)self + 9) = v9;
  }
  v10 = *((_QWORD *)self + 7);
  if ( v10 == 0 )
    goto LABEL_201;
  System_Collections_Generic_List_int___GetEnumerator(&v161, v10, qword_8D0BEA8);
  v166 = v161;
  v167 = v162;
  while ( (System_Collections_Generic_List_Enumerator_int___MoveNext(&v166, qword_8D02508) & 1) != 0 )
  {
    v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4968);
    System_Object___ctor(v11, 0);
    if ( v11 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_DWORD *)(v11 + 16) = v167;
    v12 = *((_QWORD *)self + 2);
    v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF2C8);
    System_Predicate_object____ctor(v13, v11, qword_8D492B0, 0);
    if ( v12 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( System_Collections_Generic_List_object___Find(v12, v13, qword_8D0F590) == 0 )
    {
      Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
      if ( Instance == nullptr )
        il2cpp_codegen_raise_null_reference_exception();
      v15 = Instance[5];
      if ( v15 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v16 = *(_QWORD *)(v15 + 88);
      v17 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF100);
      System_Predicate_object____ctor(v17, v11, qword_8D492B8, 0);
      if ( v16 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v18 = System_Collections_Generic_List_object___Find(v16, v17, qword_8D0AF88);
      v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF170);
      DataModule_UserHeroCardData___ctor(v19, v18, 1);
      if ( v19 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      DataModule_UserHeroCardData__AddCardLevel(v19);
      v20 = *((_QWORD *)self + 2);
      if ( v20 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v21 = *(_QWORD *)(v20 + 16);
      v22 = off_8D0F588;
      ++*(_DWORD *)(v20 + 28);
      if ( v21 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v23 = *(int *)(v20 + 24);
      if ( (unsigned int)v23 >= *(_DWORD *)(v21 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v20,
          v19,
          *(_QWORD *)(*(_QWORD *)(v22[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v20 + 24) = v23 + 1;
        *(_QWORD *)(v21 + 8 * v23 + 32) = v19;
      }
    }
  }
  System_Collections_Generic_List_Enumerator_int___Dispose(&v166, qword_8D02500);
  v24 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( v24 == nullptr )
    goto LABEL_201;
  v25 = v24[5];
  if ( v25 == 0 )
    goto LABEL_201;
  v26 = *(_QWORD *)(v25 + 88);
  if ( v26 == 0 )
    goto LABEL_201;
  v165 = *(_DWORD *)(v26 + 24);
  v27 = System_Int32__ToString(&v165, 0);
  v28 = sub_74FE7A4(qword_8D86610, v27, 0);
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(v28, 0);
  v29 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
  if ( v29 == nullptr )
    goto LABEL_201;
  v30 = v29[5];
  if ( v30 == 0 )
    goto LABEL_201;
  v31 = *(_QWORD *)(v30 + 88);
  if ( v31 == 0 )
    goto LABEL_201;
  System_Collections_Generic_List_object___GetEnumerator(&v161, v31, qword_8D0AF98);
  v163 = v161;
  v164 = v162;
  while ( (System_Collections_Generic_List_Enumerator_object___MoveNext(&v163, qword_8D01FF8) & 1) != 0 )
  {
    v32 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4970);
    System_Object___ctor(v32, 0);
    if ( v32 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v32 + 16) = v164;
    v33 = *((_QWORD *)self + 2);
    v34 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDF2C8);
    System_Predicate_object____ctor(v34, v32, qword_8D492C0, 0);
    if ( v33 == 0 )
      goto LABEL_206;
    if ( System_Collections_Generic_List_object___Find(v33, v34, qword_8D0F590) == 0 )
    {
      v35 = *(_QWORD *)(v32 + 16);
      v36 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF170);
      DataModule_UserHeroCardData___ctor(v36, v35, 0);
      v37 = *(_QWORD *)(v32 + 16);
      if ( v37 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v38 = sub_74FE7A4(qword_8D7C3E0, *(_QWORD *)(v37 + 16), 0);
      if ( *((_DWORD *)off_8CEBB00 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEBB00);
      if ( (L_Tools_PlayerPrefs2Center__HasKey(v38, 0) & 1) != 0 )
      {
        v39 = *(_QWORD *)(v32 + 16);
        if ( v39 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v40 = sub_74FE7A4(qword_8D7C3E0, *(_QWORD *)(v39 + 16), 0);
        if ( *((_DWORD *)off_8CEBB00 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEBB00);
        String = L_Tools_PlayerPrefs2Center__GetString(v40, qword_8D4ECC0, 0);
        if ( String == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v42 = System_String__Split(String, 95, 0, 0);
        v43 = v42;
        if ( v42 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        if ( *(_DWORD *)(v42 + 24) == 2 )
        {
          v44 = ToolModule_StringTool__ToInt(*(_QWORD *)(v42 + 32), 0);
          if ( v36 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          *(_DWORD *)(v36 + 112) = v44;
          if ( *(_DWORD *)(v43 + 24) <= 1u )
          {
            ((void (*)(void))unk_3C3D4D4)();
            *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8) = *(_QWORD *)v43;
            ((void (__noreturn *)(void))__cxa_throw)();
          }
          *(_QWORD *)(v36 + 32) = *(_QWORD *)(v43 + 40);
        }
      }
      v45 = *((_QWORD *)self + 2);
      if ( v45 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v46 = *(_QWORD *)(v45 + 16);
      v47 = off_8D0F588;
      ++*(_DWORD *)(v45 + 28);
      if ( v46 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v48 = *(int *)(v45 + 24);
      if ( (unsigned int)v48 >= *(_DWORD *)(v46 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v45,
          v36,
          *(_QWORD *)(*(_QWORD *)(v47[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v45 + 24) = v48 + 1;
        *(_QWORD *)(v46 + 8 * v48 + 32) = v36;
      }
    }
  }
  System_Collections_Generic_List_Enumerator_object___Dispose(&v163, qword_8D01FF0);
  v51 = *((_QWORD *)self + 5);
  if ( v51 == 0 || *(_DWORD *)(v51 + 24) == 0 )
  {
    v52 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE400);
    System_Collections_Generic_List_object____ctor(v52, qword_8D0F520);
    v53 = 5;
    *((_QWORD *)self + 5) = v52;
    do
    {
      v54 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF130);
      System_Object___ctor(v54, 0);
      v55 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
      System_Collections_Generic_List_int____ctor(v55, qword_8D0BE60);
      if ( v55 == 0 )
        goto LABEL_201;
      v56 = *(_QWORD *)(v55 + 16);
      v57 = off_8D0BE78;
      ++*(_DWORD *)(v55 + 28);
      if ( v56 == 0 )
        goto LABEL_201;
      v58 = *(int *)(v55 + 24);
      if ( (unsigned int)v58 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1001, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v58 + 1;
        *(_DWORD *)(v56 + 4 * v58 + 32) = 1001;
        ++*(_DWORD *)(v55 + 28);
      }
      v59 = *(int *)(v55 + 24);
      if ( (unsigned int)v59 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1002, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v59 + 1;
        *(_DWORD *)(v56 + 4 * v59 + 32) = 1002;
        ++*(_DWORD *)(v55 + 28);
      }
      v60 = *(int *)(v55 + 24);
      if ( (unsigned int)v60 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1003, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v60 + 1;
        *(_DWORD *)(v56 + 4 * v60 + 32) = 1003;
        ++*(_DWORD *)(v55 + 28);
      }
      v61 = *(int *)(v55 + 24);
      if ( (unsigned int)v61 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1004, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v61 + 1;
        *(_DWORD *)(v56 + 4 * v61 + 32) = 1004;
        ++*(_DWORD *)(v55 + 28);
      }
      v62 = *(int *)(v55 + 24);
      if ( (unsigned int)v62 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1005, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v62 + 1;
        *(_DWORD *)(v56 + 4 * v62 + 32) = 1005;
        ++*(_DWORD *)(v55 + 28);
      }
      v63 = *(int *)(v55 + 24);
      if ( (unsigned int)v63 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1011, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v63 + 1;
        *(_DWORD *)(v56 + 4 * v63 + 32) = 1011;
        ++*(_DWORD *)(v55 + 28);
      }
      v64 = *(int *)(v55 + 24);
      if ( (unsigned int)v64 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1013, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
        v56 = *(_QWORD *)(v55 + 16);
        v57 = off_8D0BE78;
        ++*(_DWORD *)(v55 + 28);
        if ( v56 == 0 )
          goto LABEL_201;
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v64 + 1;
        *(_DWORD *)(v56 + 4 * v64 + 32) = 1013;
        ++*(_DWORD *)(v55 + 28);
      }
      v65 = *(int *)(v55 + 24);
      if ( (unsigned int)v65 >= *(_DWORD *)(v56 + 24) )
      {
        System_Collections_Generic_List_int___AddWithResize(v55, 1014, *(_QWORD *)(*(_QWORD *)(v57[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v55 + 24) = v65 + 1;
        *(_DWORD *)(v56 + 4 * v65 + 32) = 1014;
      }
      if ( v54 == 0 )
        goto LABEL_201;
      *(_QWORD *)(v54 + 16) = v55;
      v66 = *((_QWORD *)self + 5);
      if ( v66 == 0 )
        goto LABEL_201;
      v67 = *(_QWORD *)(v66 + 16);
      v68 = off_8D0F528;
      ++*(_DWORD *)(v66 + 28);
      if ( v67 == 0 )
        goto LABEL_201;
      v69 = *(int *)(v66 + 24);
      if ( (unsigned int)v69 >= *(_DWORD *)(v67 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(
          v66,
          v54,
          *(_QWORD *)(*(_QWORD *)(v68[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v66 + 24) = v69 + 1;
        *(_QWORD *)(v67 + 8 * v69 + 32) = v54;
      }
    }
    while ( --v53 != 0 );
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v70 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v49, v50);
  if ( v70 == 0 )
    goto LABEL_201;
  if ( (SDKModule_ABTestManager__get_NewMachineCardIsB(v70, 0) & 1) == 0 )
  {
    v73 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v73, qword_8D0E5E0);
    if ( v73 == 0 )
      goto LABEL_201;
    v74 = *(_QWORD *)(v73 + 16);
    v75 = qword_8D53860;
    v76 = off_8D0E5F8;
    v77 = *(_DWORD *)(v73 + 28) + 1;
    *(_DWORD *)(v73 + 28) = v77;
    if ( v74 == 0 )
      goto LABEL_201;
    v78 = *(int *)(v73 + 24);
    if ( (unsigned int)v78 >= *(_DWORD *)(v74 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v73, v75, *(_QWORD *)(*(_QWORD *)(v76[4] + 192LL) + 112LL));
      v79 = *(_DWORD *)(v73 + 24);
      v77 = *(_DWORD *)(v73 + 28);
    }
    else
    {
      v79 = v78 + 1;
      *(_DWORD *)(v73 + 24) = v78 + 1;
      *(_QWORD *)(v74 + 8 * v78 + 32) = v75;
    }
    v80 = *(_QWORD *)(v73 + 16);
    v81 = qword_8D53858;
    v82 = off_8D0E5F8;
    *(_DWORD *)(v73 + 28) = v77 + 1;
    if ( v80 == 0 )
      goto LABEL_201;
    if ( v79 >= *(_DWORD *)(v80 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v73, v81, *(_QWORD *)(*(_QWORD *)(v82[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v73 + 24) = v79 + 1;
      *(_QWORD *)(v80 + 8LL * (int)v79 + 32) = v81;
    }
    DataModule_PlayerCardData__HandleBToAEquipCard(self, v73);
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v83 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v71, v72);
  if ( v83 == 0 )
    goto LABEL_201;
  if ( (SDKModule_ABTestManager__get_NewCardsV1IsB(v83, 0) & 1) == 0 )
  {
    v86 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v86, qword_8D0E5E0);
    if ( v86 == 0 )
      goto LABEL_201;
    v87 = *(_QWORD *)(v86 + 16);
    v88 = qword_8D53868;
    v89 = off_8D0E5F8;
    v90 = *(_DWORD *)(v86 + 28) + 1;
    *(_DWORD *)(v86 + 28) = v90;
    if ( v87 == 0 )
      goto LABEL_201;
    v91 = *(int *)(v86 + 24);
    if ( (unsigned int)v91 >= *(_DWORD *)(v87 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v86, v88, *(_QWORD *)(*(_QWORD *)(v89[4] + 192LL) + 112LL));
      v92 = *(_DWORD *)(v86 + 24);
      v90 = *(_DWORD *)(v86 + 28);
    }
    else
    {
      v92 = v91 + 1;
      *(_DWORD *)(v86 + 24) = v91 + 1;
      *(_QWORD *)(v87 + 8 * v91 + 32) = v88;
    }
    v93 = *(_QWORD *)(v86 + 16);
    v94 = off_8D0E5F8;
    v95 = qword_8D53870;
    v96 = v90 + 1;
    *(_DWORD *)(v86 + 28) = v90 + 1;
    if ( v93 == 0 )
      goto LABEL_201;
    if ( v92 >= *(_DWORD *)(v93 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v86, v95, *(_QWORD *)(*(_QWORD *)(v94[4] + 192LL) + 112LL));
      v97 = *(_DWORD *)(v86 + 24);
      v96 = *(_DWORD *)(v86 + 28);
    }
    else
    {
      v97 = v92 + 1;
      *(_DWORD *)(v86 + 24) = v92 + 1;
      *(_QWORD *)(v93 + 8LL * (int)v92 + 32) = v95;
    }
    v98 = *(_QWORD *)(v86 + 16);
    v99 = v96 + 1;
    v100 = qword_8D53878;
    v101 = off_8D0E5F8;
    *(_DWORD *)(v86 + 28) = v99;
    if ( v98 == 0 )
      goto LABEL_201;
    if ( v97 >= *(_DWORD *)(v98 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v86,
        v100,
        *(_QWORD *)(*(_QWORD *)(v101[4] + 192LL) + 112LL));
      v102 = *(_DWORD *)(v86 + 24);
      v99 = *(_DWORD *)(v86 + 28);
    }
    else
    {
      v102 = v97 + 1;
      *(_DWORD *)(v86 + 24) = v97 + 1;
      *(_QWORD *)(v98 + 8LL * (int)v97 + 32) = v100;
    }
    v103 = *(_QWORD *)(v86 + 16);
    v104 = off_8D0E5F8;
    v105 = qword_8D53880;
    v106 = v99 + 1;
    *(_DWORD *)(v86 + 28) = v99 + 1;
    if ( v103 == 0 )
      goto LABEL_201;
    if ( v102 >= *(_DWORD *)(v103 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v86,
        v105,
        *(_QWORD *)(*(_QWORD *)(v104[4] + 192LL) + 112LL));
      v107 = *(_DWORD *)(v86 + 24);
      v106 = *(_DWORD *)(v86 + 28);
    }
    else
    {
      v107 = v102 + 1;
      *(_DWORD *)(v86 + 24) = v102 + 1;
      *(_QWORD *)(v103 + 8LL * (int)v102 + 32) = v105;
    }
    v108 = *(_QWORD *)(v86 + 16);
    v109 = qword_8D53888;
    v110 = off_8D0E5F8;
    *(_DWORD *)(v86 + 28) = v106 + 1;
    if ( v108 == 0 )
      goto LABEL_201;
    if ( v107 >= *(_DWORD *)(v108 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v86,
        v109,
        *(_QWORD *)(*(_QWORD *)(v110[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v86 + 24) = v107 + 1;
      *(_QWORD *)(v108 + 8LL * (int)v107 + 32) = v109;
    }
    DataModule_PlayerCardData__HandleBToAEquipCard(self, v86);
  }
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  v111 = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v84, v85);
  if ( v111 == 0 )
LABEL_201:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (SDKModule_ABTestManager__get_WeeklyCardEventIsB(v111, 0) & 1) == 0 )
  {
    v112 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v112, qword_8D0E5E0);
    if ( v112 == 0 )
      goto LABEL_201;
    v113 = *(_QWORD *)(v112 + 16);
    v114 = qword_8D53890;
    v115 = off_8D0E5F8;
    v116 = *(_DWORD *)(v112 + 28) + 1;
    *(_DWORD *)(v112 + 28) = v116;
    if ( v113 == 0 )
      goto LABEL_201;
    v117 = *(int *)(v112 + 24);
    if ( (unsigned int)v117 >= *(_DWORD *)(v113 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v112,
        v114,
        *(_QWORD *)(*(_QWORD *)(v115[4] + 192LL) + 112LL));
      v118 = *(_DWORD *)(v112 + 24);
      v116 = *(_DWORD *)(v112 + 28);
    }
    else
    {
      v118 = v117 + 1;
      *(_DWORD *)(v112 + 24) = v117 + 1;
      *(_QWORD *)(v113 + 8 * v117 + 32) = v114;
    }
    v119 = *(_QWORD *)(v112 + 16);
    v120 = off_8D0E5F8;
    v121 = qword_8D53898;
    v122 = v116 + 1;
    *(_DWORD *)(v112 + 28) = v116 + 1;
    if ( v119 == 0 )
      goto LABEL_201;
    if ( v118 >= *(_DWORD *)(v119 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v112,
        v121,
        *(_QWORD *)(*(_QWORD *)(v120[4] + 192LL) + 112LL));
      v123 = *(_DWORD *)(v112 + 24);
      v122 = *(_DWORD *)(v112 + 28);
    }
    else
    {
      v123 = v118 + 1;
      *(_DWORD *)(v112 + 24) = v118 + 1;
      *(_QWORD *)(v119 + 8LL * (int)v118 + 32) = v121;
    }
    v124 = *(_QWORD *)(v112 + 16);
    v125 = off_8D0E5F8;
    v126 = qword_8D538A0;
    v127 = v122 + 1;
    *(_DWORD *)(v112 + 28) = v122 + 1;
    if ( v124 == 0 )
      goto LABEL_201;
    if ( v123 >= *(_DWORD *)(v124 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v112,
        v126,
        *(_QWORD *)(*(_QWORD *)(v125[4] + 192LL) + 112LL));
      v128 = *(_DWORD *)(v112 + 24);
      v127 = *(_DWORD *)(v112 + 28);
    }
    else
    {
      v128 = v123 + 1;
      *(_DWORD *)(v112 + 24) = v123 + 1;
      *(_QWORD *)(v124 + 8LL * (int)v123 + 32) = v126;
    }
    v129 = *(_QWORD *)(v112 + 16);
    v130 = qword_8D538A8;
    v131 = off_8D0E5F8;
    *(_DWORD *)(v112 + 28) = v127 + 1;
    if ( v129 == 0 )
      goto LABEL_201;
    if ( v128 >= *(_DWORD *)(v129 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(
        v112,
        v130,
        *(_QWORD *)(*(_QWORD *)(v131[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v112 + 24) = v128 + 1;
      *(_QWORD *)(v129 + 8LL * (int)v128 + 32) = v130;
    }
    DataModule_PlayerCardData__HandleBToAEquipCard(self, v112);
  }
  v132 = *((_QWORD *)self + 2);
  if ( v132 == 0 )
    goto LABEL_201;
  v133 = 0;
  while ( (signed int)v133 < *(_DWORD *)(v132 + 24) )
  {
    v134 = *((_QWORD *)self + 8);
    Item = System_Collections_Generic_List_object___get_Item(v132, v133, qword_8D0F5C8);
    if ( Item == 0 || v134 == 0 )
      goto LABEL_201;
    if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
            v134,
            *(_QWORD *)(Item + 16),
            qword_8CFF5D0)
        & 1) != 0 )
      goto LABEL_196;
    v136 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12118);
    if ( v136 == nullptr )
      goto LABEL_201;
    v137 = v136[5];
    if ( v137 == 0 )
      goto LABEL_201;
    v138 = *((_QWORD *)self + 2);
    if ( v138 == 0 )
      goto LABEL_201;
    v139 = *(_QWORD *)(v137 + 472);
    v140 = System_Collections_Generic_List_object___get_Item(v138, v133, qword_8D0F5C8);
    if ( v140 == 0 )
      goto LABEL_201;
    if ( v139 == 0 )
      goto LABEL_201;
    v141 = System_Collections_Generic_Dictionary_object__object___get_Item(v139, *(_QWORD *)(v140 + 16), qword_8CFE6E8);
    if ( v141 == 0 )
      goto LABEL_201;
    v142 = *(_QWORD *)(v141 + 24);
    if ( (ToolModule_StringTool__IsNullOrEmpty(v142, 1, 0) & 1) == 0 )
    {
      if ( v142 == 0 )
        goto LABEL_201;
      v143 = System_String__Split(v142, 59, 0, 0);
      if ( v143 == 0 )
        goto LABEL_201;
      if ( *(_DWORD *)(v143 + 24) == 0 )
        goto LABEL_205;
      v144 = *(_QWORD *)(v143 + 32);
      if ( v144 == 0 )
        goto LABEL_201;
      v145 = System_String__Split(v144, 58, 0, 0);
      if ( v145 == 0 )
        goto LABEL_201;
      if ( *(_DWORD *)(v145 + 24) <= 1u )
        goto LABEL_205;
      v146 = *(_QWORD *)(v145 + 40);
      if ( v146 == 0 )
        goto LABEL_201;
      v147 = System_String__Split(v146, 44, 0, 0);
      v148 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEF138);
      System_Object___ctor(v148, 0);
      v149 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
      System_Collections_Generic_List_int____ctor(v149, qword_8D0BE60);
      if ( v148 == 0 )
        goto LABEL_201;
      *(_QWORD *)(v148 + 24) = v149;
      if ( v147 == 0 )
        goto LABEL_201;
      v150 = *(_QWORD *)(v147 + 24);
      if ( (int)v150 >= 1 )
      {
        v151 = 0;
        while ( v151 < (unsigned int)v150 )
        {
          v152 = ToolModule_StringTool__ToInt(*(_QWORD *)(v147 + 32 + 8 * v151), 0);
          DataModule_UserCardTalentData__AddOneCardTalent(v148, v152);
          LODWORD(v150) = *(_DWORD *)(v147 + 24);
          if ( (__int64)++v151 >= (int)v150 )
            goto LABEL_192;
        }
LABEL_205:
        ((void (*)(void))unk_3C3D4D4)();
LABEL_206:
        il2cpp_codegen_raise_null_reference_exception();
      }
LABEL_192:
      v153 = *((_QWORD *)self + 2);
      if ( v153 == 0 )
        goto LABEL_201;
      v154 = *((_QWORD *)self + 8);
      v155 = System_Collections_Generic_List_object___get_Item(v153, v133, qword_8D0F5C8);
      if ( v155 == 0 || v154 == 0 )
        goto LABEL_201;
      System_Collections_Generic_Dictionary_object__object___Add(v154, *(_QWORD *)(v155 + 16), v148, qword_8CFF5C8);
LABEL_196:
      v156 = *((_QWORD *)self + 2);
      if ( v156 == 0 )
        goto LABEL_201;
      v157 = *((_QWORD *)self + 9);
      v158 = System_Collections_Generic_List_object___get_Item(v156, v133, qword_8D0F5C8);
      if ( v158 == 0 || v157 == 0 )
        goto LABEL_201;
      System_Collections_Generic_Dictionary_object__int___TryAdd(v157, *(_QWORD *)(v158 + 16), 0, qword_8CFEA80);
    }
    v132 = *((_QWORD *)self + 2);
    ++v133;
    if ( v132 == 0 )
      goto LABEL_201;
  }
  v165 = *(_DWORD *)(v132 + 24);
  v159 = System_Int32__ToString(&v165, 0);
  v160 = sub_74FE7A4(qword_8D68BD0, v159, 0);
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__Log(v160, 0);
}
