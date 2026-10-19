__int64 __fastcall GameModule_BattleGameSceneManager__EndGame_d__223__MoveNext(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x21
  __int64 v4; // x0
  __int64 Component_object; // x21
  __int64 v6; // x8
  unsigned int v7; // w21
  __int64 Item; // x22
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 gameObject; // x22
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x22
  int v15; // w2
  int v16; // w9
  __int64 v17; // x0
  unsigned int v18; // w21
  __int64 v19; // x22
  __int64 v20; // x0
  unsigned int v21; // w21
  __int64 v22; // x22
  __int64 v23; // x8
  unsigned int v24; // w21
  __int64 v25; // x22
  __int64 v26; // x21
  __int64 *v27; // x22
  __int64 v28; // x21
  __int64 v29; // x21
  __int64 v30; // x8
  int v31; // w2
  int v32; // w9
  __int64 v33; // x8
  int v34; // w2
  int v35; // w9
  __int64 v36; // x8
  int v37; // w2
  int v38; // w9
  __int64 v39; // x8
  int v40; // w2
  int v41; // w9
  __int64 v42; // x8
  int v43; // w2
  int v44; // w9
  __int64 v45; // x8
  int v46; // w2
  int v47; // w9
  __int64 v48; // x8
  int v49; // w2
  int v50; // w9
  __int64 v51; // x8
  int v52; // w2
  int v53; // w9
  __int64 v54; // x8
  int v55; // w2
  int v56; // w9
  __int64 v57; // x8
  int v58; // w2
  int v59; // w9
  __int64 v60; // x8
  int v61; // w2
  int v62; // w9
  __int64 v63; // x8
  int v64; // w2
  int v65; // w9
  __int64 v66; // x8
  int v67; // w2
  int v68; // w9
  __int64 v69; // x8
  int v70; // w2
  int v71; // w9
  __int64 v72; // x8
  int v73; // w2
  int v74; // w9
  __int64 v75; // x0
  __int64 v76; // x8
  int v77; // w2
  int v78; // w9
  __int64 v79; // x8
  int v80; // w2
  int v81; // w9
  __int64 v82; // x8
  int v83; // w2
  int v84; // w9
  __int64 v85; // x8
  int v86; // w2
  int v87; // w9
  __int64 v88; // x8
  int v89; // w9
  void *Instance; // x0
  void *v91; // x21
  void *v92; // x0
  void *v94; // x0
  void *v95; // x0
  __int64 v96; // x8
  int v97; // w2
  int v98; // w9
  __int64 v99; // x8
  int v100; // w2
  int v101; // w9
  __int64 v102; // x0
  char v103[4]; // [xsp+Ch] [xbp-74h] BYREF
  int v104; // [xsp+10h] [xbp-70h] BYREF
  int Awaiter; // [xsp+18h] [xbp-68h] BYREF

  if ( (byte_8FFD7E4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3FC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D22658);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE4D90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB628);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D9A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE81E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D093C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0ACA8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0B4F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0B4A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0F7D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0CA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D08FC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0DD90);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0ACF0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B4C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0ACF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76DE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76DF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76E78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76D78);
    byte_8FFD7E4 = 1;
  }
  Awaiter = 0;
  v104 = 0;
  v2 = *(_QWORD *)(a1 + 40);
  if ( *(_DWORD *)a1 != 0 )
  {
    if ( ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12400) == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_RoleShadowManager__RecycleAll();
    if ( v2 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameModule_BattleGameSceneManager__ShutdownWebGLNavigationManager(v2, 0);
    v3 = *(_QWORD *)(v2 + 40);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v3, 0, 0) & 1) != 0 )
    {
      v4 = *(_QWORD *)(v2 + 40);
      if ( v4 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      Component_object = UnityEngine_GameObject__GetComponent_object_(v4, qword_8D2D9A8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      if ( (UnityEngine_Object__op_Inequality(Component_object, 0, 0) & 1) != 0 )
      {
        if ( Component_object == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        GameModule_GenerateHexBehaviour__ReleaseReferences(Component_object, 0);
      }
    }
    if ( *((_DWORD *)off_8CE81E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE81E8);
    HexManager__Clear(0);
    v6 = *(_QWORD *)(v2 + 240);
    if ( v6 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( *(int *)(v6 + 24) >= 1 )
    {
      v7 = 0;
      do
      {
        Item = System_Collections_Generic_List_object___get_Item(v6, v7, qword_8D0B4C8);
        if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEB3E0);
        if ( (UnityEngine_Object__op_Inequality(Item, 0, 0) & 1) != 0 )
        {
          v9 = *(_QWORD *)(v2 + 240);
          if ( v9 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          v10 = System_Collections_Generic_List_object___get_Item(v9, v7, qword_8D0B4C8);
          if ( v10 == 0 )
            il2cpp_codegen_raise_null_reference_exception();
          gameObject = UnityEngine_Component__get_gameObject(v10, 0);
          if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CEB3E0);
          if ( (UnityEngine_Object__op_Inequality(gameObject, 0, 0) & 1) != 0 )
          {
            v12 = *(_QWORD *)(v2 + 240);
            if ( v12 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            v13 = System_Collections_Generic_List_object___get_Item(v12, v7, qword_8D0B4C8);
            if ( v13 == 0 )
              il2cpp_codegen_raise_null_reference_exception();
            v14 = UnityEngine_Component__get_gameObject(v13, 0);
            if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CEB3E0);
            UnityEngine_Object__Destroy(v14, 0);
          }
        }
        v6 = *(_QWORD *)(v2 + 240);
        if ( v6 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v15 = *(_DWORD *)(v6 + 24);
        ++v7;
      }
      while ( (int)v7 < v15 );
      v16 = *(_DWORD *)(v6 + 28) + 1;
      *(_DWORD *)(v6 + 24) = 0;
      *(_DWORD *)(v6 + 28) = v16;
      if ( v15 >= 1 )
        System_Array__Clear(*(_QWORD *)(v6 + 16), 0);
    }
    v17 = *(_QWORD *)(v2 + 120);
    if ( v17 == 0 )
LABEL_43:
      il2cpp_codegen_raise_null_reference_exception();
    v18 = 0;
    while ( (signed int)v18 < *(_DWORD *)(v17 + 24) )
    {
      v19 = System_Collections_Generic_List_object___get_Item(v17, v18, qword_8D0ACF8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      UnityEngine_Object__Destroy(v19, 0);
      v17 = *(_QWORD *)(v2 + 120);
      ++v18;
      if ( v17 == 0 )
        goto LABEL_43;
    }
    v20 = *(_QWORD *)(v2 + 160);
    if ( v20 == 0 )
LABEL_50:
      il2cpp_codegen_raise_null_reference_exception();
    v21 = 0;
    while ( (signed int)v21 < *(_DWORD *)(v20 + 24) )
    {
      v22 = System_Collections_Generic_List_object___get_Item(v20, v21, qword_8D0ACF8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      UnityEngine_Object__Destroy(v22, 0);
      v20 = *(_QWORD *)(v2 + 160);
      ++v21;
      if ( v20 == 0 )
        goto LABEL_50;
    }
    v23 = *(_QWORD *)(v2 + 168);
    if ( v23 == 0 )
LABEL_57:
      il2cpp_codegen_raise_null_reference_exception();
    v24 = 0;
    while ( (signed int)v24 < *(_DWORD *)(v23 + 24) )
    {
      v25 = System_Collections_Generic_List_object___get_Item(v23, v24, qword_8D0ACF8);
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      UnityEngine_Object__Destroy(v25, 0);
      v23 = *(_QWORD *)(v2 + 168);
      ++v24;
      if ( v23 == 0 )
        goto LABEL_57;
    }
    GameModule_BattleGameSceneManager__DestroyAllROle(v2, 0);
    v26 = *(_QWORD *)(v2 + 256);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    v27 = (__int64 *)(v2 + 256);
    if ( (UnityEngine_Object__op_Inequality(v26, 0, 0) & 1) != 0 )
    {
      v28 = *v27;
      if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CEB3E0);
      UnityEngine_Object__Destroy(v28, 0);
    }
    v29 = *(_QWORD *)(v2 + 264);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__Destroy(v29, 0);
    v30 = *(_QWORD *)(v2 + 272);
    if ( v30 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v31 = *(_DWORD *)(v30 + 24);
    v32 = *(_DWORD *)(v30 + 28) + 1;
    *(_DWORD *)(v30 + 24) = 0;
    *(_DWORD *)(v30 + 28) = v32;
    if ( v31 >= 1 )
      System_Array__Clear(*(_QWORD *)(v30 + 16), 0);
    *v27 = 0;
    *(_QWORD *)(v2 + 264) = 0;
    v33 = *(_QWORD *)(v2 + 96);
    if ( v33 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v34 = *(_DWORD *)(v33 + 24);
    v35 = *(_DWORD *)(v33 + 28) + 1;
    *(_DWORD *)(v33 + 24) = 0;
    *(_DWORD *)(v33 + 28) = v35;
    if ( v34 >= 1 )
      System_Array__Clear(*(_QWORD *)(v33 + 16), 0);
    v36 = *(_QWORD *)(v2 + 104);
    if ( v36 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v37 = *(_DWORD *)(v36 + 24);
    v38 = *(_DWORD *)(v36 + 28) + 1;
    *(_DWORD *)(v36 + 24) = 0;
    *(_DWORD *)(v36 + 28) = v38;
    if ( v37 >= 1 )
      System_Array__Clear(*(_QWORD *)(v36 + 16), 0);
    v39 = *(_QWORD *)(v2 + 120);
    if ( v39 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v40 = *(_DWORD *)(v39 + 24);
    v41 = *(_DWORD *)(v39 + 28) + 1;
    *(_DWORD *)(v39 + 24) = 0;
    *(_DWORD *)(v39 + 28) = v41;
    if ( v40 >= 1 )
      System_Array__Clear(*(_QWORD *)(v39 + 16), 0);
    v42 = *(_QWORD *)(v2 + 144);
    if ( v42 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v43 = *(_DWORD *)(v42 + 24);
    v44 = *(_DWORD *)(v42 + 28) + 1;
    *(_DWORD *)(v42 + 24) = 0;
    *(_DWORD *)(v42 + 28) = v44;
    if ( v43 >= 1 )
      System_Array__Clear(*(_QWORD *)(v42 + 16), 0);
    v45 = *(_QWORD *)(v2 + 152);
    if ( v45 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v46 = *(_DWORD *)(v45 + 24);
    v47 = *(_DWORD *)(v45 + 28) + 1;
    *(_DWORD *)(v45 + 24) = 0;
    *(_DWORD *)(v45 + 28) = v47;
    if ( v46 >= 1 )
      System_Array__Clear(*(_QWORD *)(v45 + 16), 0);
    v48 = *(_QWORD *)(v2 + 160);
    if ( v48 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v49 = *(_DWORD *)(v48 + 24);
    v50 = *(_DWORD *)(v48 + 28) + 1;
    *(_DWORD *)(v48 + 24) = 0;
    *(_DWORD *)(v48 + 28) = v50;
    if ( v49 >= 1 )
      System_Array__Clear(*(_QWORD *)(v48 + 16), 0);
    v51 = *(_QWORD *)(v2 + 168);
    if ( v51 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v52 = *(_DWORD *)(v51 + 24);
    v53 = *(_DWORD *)(v51 + 28) + 1;
    *(_DWORD *)(v51 + 24) = 0;
    *(_DWORD *)(v51 + 28) = v53;
    if ( v52 >= 1 )
      System_Array__Clear(*(_QWORD *)(v51 + 16), 0);
    v54 = *(_QWORD *)(v2 + 176);
    if ( v54 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v55 = *(_DWORD *)(v54 + 24);
    v56 = *(_DWORD *)(v54 + 28) + 1;
    *(_DWORD *)(v54 + 24) = 0;
    *(_DWORD *)(v54 + 28) = v56;
    if ( v55 >= 1 )
      System_Array__Clear(*(_QWORD *)(v54 + 16), 0);
    v57 = *(_QWORD *)(v2 + 184);
    if ( v57 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v58 = *(_DWORD *)(v57 + 24);
    v59 = *(_DWORD *)(v57 + 28) + 1;
    *(_DWORD *)(v57 + 24) = 0;
    *(_DWORD *)(v57 + 28) = v59;
    if ( v58 >= 1 )
      System_Array__Clear(*(_QWORD *)(v57 + 16), 0);
    v60 = *(_QWORD *)(v2 + 128);
    *(_QWORD *)(v2 + 248) = 0;
    if ( v60 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v61 = *(_DWORD *)(v60 + 24);
    v62 = *(_DWORD *)(v60 + 28) + 1;
    *(_DWORD *)(v60 + 24) = 0;
    *(_DWORD *)(v60 + 28) = v62;
    if ( v61 >= 1 )
      System_Array__Clear(*(_QWORD *)(v60 + 16), 0);
    v63 = *(_QWORD *)(v2 + 136);
    if ( v63 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v64 = *(_DWORD *)(v63 + 24);
    v65 = *(_DWORD *)(v63 + 28) + 1;
    *(_DWORD *)(v63 + 24) = 0;
    *(_DWORD *)(v63 + 28) = v65;
    if ( v64 >= 1 )
      System_Array__Clear(*(_QWORD *)(v63 + 16), 0);
    v66 = *(_QWORD *)(v2 + 200);
    if ( v66 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v67 = *(_DWORD *)(v66 + 24);
    v68 = *(_DWORD *)(v66 + 28) + 1;
    *(_DWORD *)(v66 + 24) = 0;
    *(_DWORD *)(v66 + 28) = v68;
    if ( v67 >= 1 )
      System_Array__Clear(*(_QWORD *)(v66 + 16), 0);
    v69 = *(_QWORD *)(v2 + 208);
    if ( v69 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v70 = *(_DWORD *)(v69 + 24);
    v71 = *(_DWORD *)(v69 + 28) + 1;
    *(_DWORD *)(v69 + 24) = 0;
    *(_DWORD *)(v69 + 28) = v71;
    if ( v70 >= 1 )
      System_Array__Clear(*(_QWORD *)(v69 + 16), 0);
    v72 = *(_QWORD *)(v2 + 192);
    if ( v72 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v73 = *(_DWORD *)(v72 + 24);
    v74 = *(_DWORD *)(v72 + 28) + 1;
    *(_DWORD *)(v72 + 24) = 0;
    *(_DWORD *)(v72 + 28) = v74;
    if ( v73 >= 1 )
      System_Array__Clear(*(_QWORD *)(v72 + 16), 0);
    v75 = *(_QWORD *)(v2 + 384);
    if ( v75 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___Clear(v75, qword_8CFB628);
    v76 = *(_QWORD *)(v2 + 112);
    if ( v76 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v77 = *(_DWORD *)(v76 + 24);
    v78 = *(_DWORD *)(v76 + 28) + 1;
    *(_DWORD *)(v76 + 24) = 0;
    *(_DWORD *)(v76 + 28) = v78;
    if ( v77 >= 1 )
      System_Array__Clear(*(_QWORD *)(v76 + 16), 0);
    v79 = *(_QWORD *)(v2 + 216);
    if ( v79 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v80 = *(_DWORD *)(v79 + 24);
    v81 = *(_DWORD *)(v79 + 28) + 1;
    *(_DWORD *)(v79 + 24) = 0;
    *(_DWORD *)(v79 + 28) = v81;
    if ( v80 >= 1 )
      System_Array__Clear(*(_QWORD *)(v79 + 16), 0);
    v82 = *(_QWORD *)(v2 + 224);
    if ( v82 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v83 = *(_DWORD *)(v82 + 24);
    v84 = *(_DWORD *)(v82 + 28) + 1;
    *(_DWORD *)(v82 + 24) = 0;
    *(_DWORD *)(v82 + 28) = v84;
    if ( v83 >= 1 )
      System_Array__Clear(*(_QWORD *)(v82 + 16), 0);
    v85 = *(_QWORD *)(v2 + 232);
    if ( v85 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v86 = *(_DWORD *)(v85 + 24);
    v87 = *(_DWORD *)(v85 + 28) + 1;
    *(_DWORD *)(v85 + 24) = 0;
    *(_DWORD *)(v85 + 28) = v87;
    if ( v86 >= 1 )
      System_Array__Clear(*(_QWORD *)(v85 + 16), 0);
    v88 = *(_QWORD *)(v2 + 376);
    if ( v88 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v89 = *(_DWORD *)(v88 + 28) + 1;
    *(_DWORD *)(v88 + 24) = 0;
    *(_DWORD *)(v88 + 28) = v89;
    *(_DWORD *)(v2 + 460) = 0;
    *(_OWORD *)(v2 + 428) = 0u;
    *(_OWORD *)(v2 + 444) = 0u;
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(Instance, (void *)qword_8D76DE8, nullptr, nullptr);
    v91 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
    v103[0] = 1;
    v92 = (void *)((__int64 (__fastcall *)(__int64, char *))unk_3C3D3B8)(qword_8CE4D90, v103);
    if ( v91 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(v91, (void *)qword_8D76E78, v92, nullptr);
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    v104 = Cysharp_Threading_Tasks_UniTask__Yield(0);
    Awaiter = Cysharp_Threading_Tasks_YieldAwaitable__GetAwaiter(&v104, 0);
    if ( (Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__get_IsCompleted(&Awaiter, 0) & 1) == 0 )
    {
      *(_DWORD *)a1 = 0;
      *(_DWORD *)(a1 + 48) = Awaiter;
      return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_YieldAwaitable_Awaiter__BattleGameSceneManager__EndGame_d__223_(
               a1 + 8,
               &Awaiter,
               a1,
               qword_8D22658);
    }
  }
  else
  {
    Awaiter = *(_DWORD *)(a1 + 48);
    *(_DWORD *)(a1 + 48) = 0;
    *(_DWORD *)a1 = -1;
  }
  Cysharp_Threading_Tasks_YieldAwaitable_Awaiter__GetResult(&Awaiter, 0);
  if ( *((_DWORD *)off_8CE3FC0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE3FC0);
  AnimationInstancing_AnimationManager__ClearRuntimeAnimationInfoIfExists(0);
  v94 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  if ( v94 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__TriggerEvent(v94, (void *)qword_8D76DF0, nullptr, nullptr);
  v95 = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12148);
  if ( v95 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  EventModule_EventManager__TriggerEvent(v95, (void *)qword_8D76D78, nullptr, nullptr);
  if ( v2 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v96 = *(_QWORD *)(v2 + 528);
  *(_DWORD *)(v2 + 32) = 0;
  *(_WORD *)(v2 + 360) = 0;
  *(_DWORD *)(v2 + 464) = 0;
  *(_QWORD *)(v2 + 512) = 0;
  if ( v96 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v97 = *(_DWORD *)(v96 + 24);
  v98 = *(_DWORD *)(v96 + 28) + 1;
  *(_DWORD *)(v96 + 24) = 0;
  *(_DWORD *)(v96 + 28) = v98;
  if ( v97 >= 1 )
    System_Array__Clear(*(_QWORD *)(v96 + 16), 0);
  v99 = *(_QWORD *)(v2 + 536);
  if ( v99 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v100 = *(_DWORD *)(v99 + 24);
  v101 = *(_DWORD *)(v99 + 28) + 1;
  *(_DWORD *)(v99 + 24) = 0;
  *(_DWORD *)(v99 + 28) = v101;
  if ( v100 >= 1 )
    System_Array__Clear(*(_QWORD *)(v99 + 16), 0);
  v102 = *(_QWORD *)(v2 + 544);
  *(_QWORD *)(v2 + 520) = 0;
  if ( v102 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__int___Clear();
  if ( *(_QWORD *)(v2 + 552) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__int___Clear();
  if ( *(_QWORD *)(v2 + 560) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__int___Clear();
  if ( *(_QWORD *)(v2 + 568) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__int___Clear();
  *(_DWORD *)a1 = -2;
  return System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult(a1 + 8, 0);
}
