void AssetsModule_AssetsManager__LoadAssetAsync_d__19_object___MoveNext(void *self, const MethodInfo *method)
{
  int v4; // w26
  _QWORD *v5; // x25
  __int64 v6; // x0
  __int64 v7; // x0
  __int64 v8; // x21
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x8
  __int64 v12; // x0
  __int64 *v13; // x21
  char IsDone; // w0
  __int64 v15; // x8
  __int64 v16; // x21
  __int64 v17; // x0
  __int64 v18; // x22
  __int64 v19; // x23
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 v22; // x0
  int Status; // w8
  __int64 v24; // x0
  __int16 v25; // w9
  __int64 v26; // x22
  __int64 v27; // x0
  __int64 v28; // x8
  __int64 v29; // x21
  __int64 v30; // x0
  __int64 v31; // x22
  char v32; // w24
  int v33; // w22
  __int64 v34; // x0
  __int64 v35; // x8
  __int64 v36; // x0
  _QWORD *v37; // x21
  __int64 Task; // x0
  __int64 v39; // x0
  __int64 v40; // x8
  __int64 Result; // x21
  __int64 v42; // x0
  __int64 v43; // x22
  __int64 v44; // x0
  __int64 v45; // x0
  __int64 *v46; // x20
  __int64 v47; // x0
  __int64 v48; // x1
  __int64 v49; // x8
  __int64 v50; // x9
  _DWORD *v51; // x10
  __int64 v52; // x0
  __int64 v53; // x21
  __int64 v54; // x0
  __int64 *v55; // x20
  __int64 v56; // x0
  __int64 v57; // x1
  __int64 v58; // x8
  __int64 v59; // x9
  _DWORD *v60; // x10
  __int64 v61; // x0
  __int64 v62; // x8
  __int64 v63; // x0
  char v64; // w0
  __int64 v65; // x8
  __int64 v66; // x21
  __int64 v67; // x0
  __int128 v68; // q0
  __int64 v69; // x24
  __int64 v70; // x22
  __int64 v71; // x0
  __int64 v72; // x1
  __int64 v73; // x8
  __int128 v74; // q0
  __int64 v75; // x23
  __int64 v76; // x8
  __int64 v77; // x0
  __int64 v78; // x22
  __int64 v79; // x0
  __int64 Item; // x0
  __int64 v81; // x8
  __int64 v82; // x0
  __int64 v83; // x8
  __int64 v84; // x23
  __int64 v85; // x22
  __int64 v86; // x24
  __int64 v87; // x8
  __int64 v88; // x0
  __int64 v89; // x0
  __int64 v90; // x8
  __int64 v91; // x1
  __int64 v92; // x8
  __int64 v93; // x10
  __int64 v94; // x0
  __int64 v95; // x22
  __int64 v96; // x0
  __int64 v97; // x23
  __int64 v98; // x0
  __int16 v99; // w9
  __int64 v100; // x8
  __int64 v101; // x24
  __int64 v102; // x0
  __int64 v103; // x0
  __int64 v104; // x21
  __int64 v105; // x0
  __int64 v106; // x0
  __int64 v107; // x0
  __int64 OperationException; // x8
  __int64 v109; // x0
  __int16 v110; // w9
  __int64 v111; // x0
  __int64 v112; // x21
  __int64 v113; // x0
  __int64 v114; // x0
  __int64 v115; // x8
  __int64 v116; // x21
  __int64 v117; // x0
  __int64 v118; // x21
  _DWORD *v119; // x0
  __int64 v120; // x21
  __int64 v121; // x22
  __int64 v122; // x0
  __int64 v123; // x21
  _DWORD *v124; // x0
  __int64 v125; // x8
  __int64 v126; // x0
  __int64 v127; // x8
  __int64 v128; // x21
  __int64 v129; // x8
  __int64 v130; // x22
  __int64 v131; // x23
  __int64 v132; // x0
  __int64 v133; // x22
  _DWORD *v134; // x0
  __int64 v135; // x21
  __int64 v136; // x22
  __int64 v137; // x0
  __int64 v138; // x8
  __int64 v139; // x21
  __int64 v140; // x22
  __int64 v141; // x0
  __int64 v142; // x21
  __int64 v143; // x0
  __int64 v144; // x22
  __int64 v145; // x21
  __int64 v146; // x0
  __int64 v147; // x0
  __int64 v148; // x22
  __int64 v149; // x8
  __int64 v150; // x22
  __int64 v151; // x23
  __int64 v152; // x0
  __int64 v153; // x8
  __int64 v154; // x22
  __int64 v155; // x23
  __int64 v156; // x0
  __int64 v157; // x21
  __int64 v158; // x0
  __int64 v159; // x22
  __int64 v160; // x22
  int v161; // w1
  __int64 v162; // x0
  __int64 v163; // x0
  __int128 v164; // [xsp+0h] [xbp-F0h]
  __int64 v165; // [xsp+10h] [xbp-E0h]
  __int128 v166; // [xsp+18h] [xbp-D8h] BYREF
  __int64 v167; // [xsp+28h] [xbp-C8h]
  __int128 v168; // [xsp+30h] [xbp-C0h]
  __int64 v169; // [xsp+40h] [xbp-B0h]
  __int128 v170; // [xsp+50h] [xbp-A0h]
  __int64 v171; // [xsp+60h] [xbp-90h]
  int v172; // [xsp+70h] [xbp-80h]
  __int64 v173; // [xsp+78h] [xbp-78h] BYREF
  __int128 v174; // [xsp+80h] [xbp-70h] BYREF
  __int64 v175; // [xsp+90h] [xbp-60h]
  __int64 Awaiter; // [xsp+A8h] [xbp-48h] BYREF

  if ( (byte_900719F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF1188);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE0C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFA20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE0C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFA28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D18698);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D186A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D18AF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D19850);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE23A0);
    byte_900719F = 1;
  }
  Awaiter = 0;
  v173 = 0;
  v172 = 0;
  v4 = *(_DWORD *)self;
  v5 = *((_QWORD **)self + 4);
  if ( *(_DWORD *)self >= 3u )
  {
    v6 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v6 + 309) & 1) == 0 )
      v6 = ((__int64 (*)(void))unk_3C503A0)();
    v7 = *(_QWORD *)(*(_QWORD *)(v6 + 192) + 8LL);
    if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
      v7 = ((__int64 (*)(void))unk_3C503A0)();
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v7);
    v9 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
      v9 = ((__int64 (*)(void))unk_3C503A0)();
    AssetsModule_AssetsManager___c__DisplayClass19_0_object____ctor(v8, *(_QWORD *)(*(_QWORD *)(v9 + 192) + 16LL));
    *((_QWORD *)self + 6) = v8;
    if ( v8 == 0 )
LABEL_184:
      il2cpp_codegen_raise_null_reference_exception();
    *(_QWORD *)(v8 + 16) = *((_QWORD *)self + 4);
    *(_QWORD *)(v8 + 24) = *((_QWORD *)self + 5);
    if ( v5 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v10 = v5[8];
    if ( v10 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Threading_ReaderWriterLockSlim__EnterUpgradeableReadLock(v10, 0);
    v11 = *((_QWORD *)self + 6);
    if ( v11 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v12 = v5[7];
    if ( v12 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v13 = (__int64 *)((char *)self + 56);
    if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(
            v12,
            *(_QWORD *)(v11 + 24),
            (char *)self + 56,
            qword_8CFFA20)
        & 1) == 0 )
      goto LABEL_31;
    if ( *v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    IsDone = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_IsDone(*v13 + 16, 0);
    v15 = *v13;
    if ( (IsDone & 1) == 0 )
    {
      if ( v15 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Threading_Interlocked__Increment(v15 + 40, 0);
      if ( *v13 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Task(*v13 + 16, 0) == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      Awaiter = ((__int64 (*)(void))System_Threading_Tasks_Task_object___GetAwaiter)();
      if ( (System_Runtime_CompilerServices_TaskAwaiter_object___get_IsCompleted(&Awaiter, qword_8D186A0) & 1) != 0 )
      {
LABEL_81:
        System_Runtime_CompilerServices_TaskAwaiter_object___GetResult(&Awaiter, qword_8D18698);
        v40 = *((_QWORD *)self + 7);
        if ( v40 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        Result = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Result(v40 + 16, 0);
        v42 = *((_QWORD *)method + 4);
        if ( (*(_BYTE *)(v42 + 309) & 1) == 0 )
          v42 = ((__int64 (*)(void))unk_3C503A0)();
        v43 = *(_QWORD *)(*(_QWORD *)(v42 + 192) + 24LL);
        if ( (*(_BYTE *)(v43 + 309) & 1) == 0 )
          v43 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v42 + 192) + 24LL));
        if ( Result != 0 )
        {
          v19 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(Result, v43);
          if ( v19 != 0 )
            goto LABEL_88;
          ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(Result, v43);
LABEL_218:
          il2cpp_codegen_raise_null_reference_exception();
        }
LABEL_151:
        v19 = 0;
        v33 = 7;
        if ( (v4 & 0x80000000) == 0 )
          goto LABEL_93;
        goto LABEL_90;
      }
      *(_DWORD *)self = 0;
      *((_QWORD *)self + 8) = Awaiter;
      v39 = *((_QWORD *)method + 4);
      if ( (*(_BYTE *)(v39 + 309) & 1) == 0 )
        v39 = ((__int64 (*)(void))unk_3C503A0)();
LABEL_76:
      ((void (__fastcall *)(char *, __int64 *, void *, _QWORD))unk_4733804)(
        (char *)self + 8,
        &Awaiter,
        self,
        *(_QWORD *)(*(_QWORD *)(v39 + 192) + 40LL));
      return;
    }
    if ( v15 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (unsigned int)UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Status(v15 + 16, 0) != 1 )
    {
LABEL_31:
      v20 = v5[8];
      if ( v20 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Threading_ReaderWriterLockSlim__EnterWriteLock(v20, 0);
      goto LABEL_33;
    }
    if ( *v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Threading_Interlocked__Increment(*v13 + 40, 0);
    if ( *v13 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v16 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Result(*v13 + 16, 0);
    v17 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v17 + 309) & 1) == 0 )
      v17 = ((__int64 (*)(void))unk_3C503A0)();
    v18 = *(_QWORD *)(*(_QWORD *)(v17 + 192) + 24LL);
    if ( (*(_BYTE *)(v18 + 309) & 1) == 0 )
      v18 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v17 + 192) + 24LL));
    if ( v16 == 0 )
      goto LABEL_151;
    v19 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v16, v18);
    if ( v19 != 0 )
    {
LABEL_88:
      v33 = 7;
LABEL_89:
      if ( (v4 & 0x80000000) == 0 )
        goto LABEL_93;
      goto LABEL_90;
    }
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v16, v18);
  }
  if ( v4 == 0 )
  {
    v4 = -1;
    Awaiter = *((_QWORD *)self + 8);
    *((_QWORD *)self + 8) = 0;
    *(_DWORD *)self = -1;
    goto LABEL_81;
  }
LABEL_33:
  if ( v4 == 1 )
  {
    v4 = -1;
    Awaiter = *((_QWORD *)self + 8);
    *((_QWORD *)self + 8) = 0;
    *(_DWORD *)self = -1;
    goto LABEL_50;
  }
  if ( v4 == 2 )
  {
    v4 = -1;
    v173 = *((_QWORD *)self + 13);
    *((_QWORD *)self + 13) = 0;
    *(_DWORD *)self = -1;
    goto LABEL_36;
  }
  if ( v5 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v35 = *((_QWORD *)self + 6);
  if ( v35 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v36 = v5[7];
  if ( v36 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v37 = (char *)self + 72;
  if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(
          v36,
          *(_QWORD *)(v35 + 24),
          (char *)self + 72,
          qword_8CFFA20)
      & 1) != 0 )
  {
    if ( *v37 == 0 )
      goto LABEL_218;
    System_Threading_Interlocked__Increment(*v37 + 40LL, 0);
    if ( *v37 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Task = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Task(*v37 + 16LL, 0);
    if ( Task == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Awaiter = System_Threading_Tasks_Task_object___GetAwaiter(Task, qword_8D18AF8);
    if ( (System_Runtime_CompilerServices_TaskAwaiter_object___get_IsCompleted(&Awaiter, qword_8D186A0) & 1) == 0 )
    {
      *(_DWORD *)self = 1;
      *((_QWORD *)self + 8) = Awaiter;
      v39 = *((_QWORD *)method + 4);
      if ( (*(_BYTE *)(v39 + 309) & 1) == 0 )
        v39 = ((__int64 (*)(void))unk_3C503A0)();
      goto LABEL_76;
    }
LABEL_50:
    System_Runtime_CompilerServices_TaskAwaiter_object___GetResult(&Awaiter, qword_8D18698);
    v28 = *((_QWORD *)self + 9);
    if ( v28 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v29 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle__get_Result(v28 + 16, 0);
    v30 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v30 + 309) & 1) == 0 )
      v30 = ((__int64 (*)(void))unk_3C503A0)();
    v31 = *(_QWORD *)(*(_QWORD *)(v30 + 192) + 24LL);
    if ( (*(_BYTE *)(v31 + 309) & 1) == 0 )
      v31 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v30 + 192) + 24LL));
    if ( v29 == 0 )
    {
      v32 = 0;
      v19 = 0;
LABEL_58:
      v33 = 7;
      if ( (v4 & 0x80000000) == 0 )
        goto LABEL_62;
      goto LABEL_59;
    }
    v19 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v29, v31);
    if ( v19 != 0 )
    {
LABEL_57:
      v29 = 0;
      v32 = 0;
      goto LABEL_58;
    }
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v29, v31);
    goto LABEL_209;
  }
  v62 = *((_QWORD *)self + 6);
  if ( v62 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v63 = v5[11];
  if ( v63 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v64 = System_Collections_Generic_Dictionary_object__object___ContainsKey(v63, *(_QWORD *)(v62 + 24), qword_8CFE0C0);
  v65 = *((_QWORD *)self + 6);
  if ( (v64 & 1) == 0 )
  {
    if ( v65 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v120 = *(_QWORD *)(v65 + 24);
    v121 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D890D8);
    v122 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D50FC0);
    v123 = sub_750A330(v121, v120, v122, 0);
    v124 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CE64E8);
    if ( v124[56] == 0 )
      il2cpp_codegen_runtime_class_init(v124);
    UnityEngine_Debug__LogError(v123, 0);
    v125 = *((_QWORD *)self + 6);
    if ( v125 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v139 = *(_QWORD *)(v125 + 24);
    v140 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D890D8);
    v141 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D51048);
    v142 = sub_750A330(v140, v139, v141, 0);
    v143 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
    v144 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v143);
    System_Exception___ctor(v144, v142, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v144, method);
    goto LABEL_267;
  }
  if ( v65 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v66 = *(_QWORD *)(v65 + 24);
  if ( *((_DWORD *)off_8CE3D98 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE3D98);
  v67 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v67 + 309) & 1) == 0 )
    v67 = ((__int64 (*)(void))unk_3C503A0)();
  UnityEngine_AddressableAssets_Addressables__LoadAssetAsync_object_(
    &v174,
    v66,
    *(_QWORD *)(*(_QWORD *)(v67 + 192) + 64LL));
  v68 = v174;
  v170 = v174;
  v171 = v175;
  *((_QWORD *)self + 12) = v175;
  *((_OWORD *)self + 5) = v68;
  v69 = *((_QWORD *)self + 6);
  v70 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF1188);
  AssetsModule_AssetsManager_AssetHandleInfo___ctor(v70, 0);
  v165 = *((_QWORD *)self + 12);
  v164 = *((_OWORD *)self + 5);
  v71 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v71 + 309) & 1) == 0 )
    v71 = ((__int64 (*)(void))unk_3C503A0)();
  v72 = *(_QWORD *)(*(_QWORD *)(v71 + 192) + 80LL);
  v174 = v164;
  v175 = v165;
  UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___op_Implicit(&v166, &v174, v72);
  v168 = v166;
  v169 = v167;
  if ( v70 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v73 = v169;
  v74 = v168;
  *(_DWORD *)(v70 + 40) = 1;
  *(_QWORD *)(v70 + 32) = v73;
  *(_OWORD *)(v70 + 16) = v74;
  v75 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE23A0);
  Cysharp_Threading_Tasks_UniTaskCompletionSource_object____ctor(v75, qword_8D19850);
  *(_QWORD *)(v70 + 48) = v75;
  if ( v69 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v69 + 40) = v70;
  v76 = *((_QWORD *)self + 6);
  if ( v76 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v77 = v5[7];
  if ( v77 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  System_Collections_Generic_Dictionary_object__object___set_Item(
    v77,
    *(_QWORD *)(v76 + 24),
    *(_QWORD *)(v76 + 40),
    qword_8CFFA28);
  v78 = *((_QWORD *)self + 6);
  if ( v78 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v79 = v5[11];
  if ( v79 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  Item = System_Collections_Generic_Dictionary_object__object___get_Item(v79, *(_QWORD *)(v78 + 24), qword_8CFE0C8);
  if ( Item == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v78 + 32) = *(_QWORD *)(Item + 24);
  v81 = *((_QWORD *)self + 6);
  if ( v81 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v82 = v5[10];
  if ( v82 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v82, *(_QWORD *)(v81 + 32), qword_8CFDE38) & 1) == 0 )
  {
    v83 = *((_QWORD *)self + 6);
    if ( v83 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v84 = *(_QWORD *)(v83 + 32);
    v85 = v5[10];
    v86 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
    System_Collections_Generic_List_object____ctor(v86, qword_8D0E5E0);
    if ( v85 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___set_Item(v85, v84, v86, qword_8CFDE48);
  }
  v87 = *((_QWORD *)self + 6);
  if ( v87 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v88 = v5[10];
  if ( v88 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v89 = System_Collections_Generic_Dictionary_object__object___get_Item(v88, *(_QWORD *)(v87 + 32), qword_8CFDE40);
  v90 = *((_QWORD *)self + 6);
  if ( v90 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( v89 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v91 = *(_QWORD *)(v90 + 24);
  v92 = *(_QWORD *)(v89 + 16);
  ++*(_DWORD *)(v89 + 28);
  if ( v92 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v93 = *(int *)(v89 + 24);
  if ( (unsigned int)v93 >= *(_DWORD *)(v92 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize();
  }
  else
  {
    *(_DWORD *)(v89 + 24) = v93 + 1;
    *(_QWORD *)(v92 + 8 * v93 + 32) = v91;
  }
  v94 = *((_QWORD *)method + 4);
  v95 = *((_QWORD *)self + 6);
  if ( (*(_BYTE *)(v94 + 309) & 1) == 0 )
    v94 = ((__int64 (*)(void))unk_3C503A0)();
  v96 = *(_QWORD *)(*(_QWORD *)(v94 + 192) + 104LL);
  if ( (*(_BYTE *)(v96 + 309) & 1) == 0 )
    v96 = ((__int64 (*)(void))unk_3C503A0)();
  v97 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v96);
  v98 = *((_QWORD *)method + 4);
  v99 = *(_WORD *)(v98 + 309);
  if ( (v99 & 1) != 0 )
  {
    v100 = *((_QWORD *)method + 4);
  }
  else
  {
    v100 = ((__int64 (*)(void))unk_3C503A0)();
    v98 = *((_QWORD *)method + 4);
    v99 = *(_WORD *)(v98 + 309);
  }
  v101 = *(_QWORD *)(*(_QWORD *)(v100 + 192) + 96LL);
  if ( (v99 & 1) == 0 )
    v98 = ((__int64 (*)(void))unk_3C503A0)();
  System_Action_AsyncOperationHandle_object_____ctor(v97, v95, v101, *(_QWORD *)(*(_QWORD *)(v98 + 192) + 112LL));
  v102 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v102 + 309) & 1) == 0 )
    v102 = ((__int64 (*)(void))unk_3C503A0)();
  UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___add_Completed(
    (char *)self + 80,
    v97,
    *(_QWORD *)(*(_QWORD *)(v102 + 192) + 120LL));
  v103 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v103 + 309) & 1) == 0 )
    v103 = ((__int64 (*)(void))unk_3C503A0)();
  v104 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Task(
           (char *)self + 80,
           *(_QWORD *)(*(_QWORD *)(v103 + 192) + 128LL));
  if ( v104 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v105 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v105 + 309) & 1) == 0 )
    v105 = ((__int64 (*)(void))unk_3C503A0)();
  v173 = System_Threading_Tasks_Task_object___GetAwaiter(v104, *(_QWORD *)(*(_QWORD *)(v105 + 192) + 144LL));
  v106 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v106 + 309) & 1) == 0 )
    v106 = ((__int64 (*)(void))unk_3C503A0)();
  if ( (System_Runtime_CompilerServices_TaskAwaiter_object___get_IsCompleted(
          &v173,
          *(_QWORD *)(*(_QWORD *)(v106 + 192) + 160LL))
      & 1) == 0 )
  {
    *(_DWORD *)self = 2;
    *((_QWORD *)self + 13) = v173;
    v107 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v107 + 309) & 1) == 0 )
      v107 = ((__int64 (*)(void))unk_3C503A0)();
    ((void (__fastcall *)(char *, __int64 *, void *, _QWORD))unk_4733804)(
      (char *)self + 8,
      &v173,
      self,
      *(_QWORD *)(*(_QWORD *)(v107 + 192) + 176LL));
    return;
  }
LABEL_36:
  v21 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v21 + 309) & 1) == 0 )
    v21 = ((__int64 (*)(void))unk_3C503A0)();
  System_Runtime_CompilerServices_TaskAwaiter_object___GetResult(&v173, *(_QWORD *)(*(_QWORD *)(v21 + 192) + 192LL));
  v22 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v22 + 309) & 1) == 0 )
    v22 = ((__int64 (*)(void))unk_3C503A0)();
  Status = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Status(
             (char *)self + 80,
             *(_QWORD *)(*(_QWORD *)(v22 + 192) + 200LL));
  v24 = *((_QWORD *)method + 4);
  v25 = *(_WORD *)(v24 + 309);
  if ( Status == 1 )
  {
    if ( (v25 & 1) == 0 )
      v24 = ((__int64 (*)(void))unk_3C503A0)();
    v26 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Result(
            (char *)self + 80,
            *(_QWORD *)(*(_QWORD *)(v24 + 192) + 216LL));
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Equality(v26, 0, 0) & 1) == 0 )
    {
      v27 = *((_QWORD *)method + 4);
      if ( (*(_BYTE *)(v27 + 309) & 1) == 0 )
        v27 = ((__int64 (*)(void))unk_3C503A0)();
      v19 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Result(
              (char *)self + 80,
              *(_QWORD *)(*(_QWORD *)(v27 + 192) + 216LL));
      goto LABEL_57;
    }
    v115 = *((_QWORD *)self + 6);
    if ( v115 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
LABEL_209:
    v116 = *(_QWORD *)(v115 + 24);
    v117 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D86700);
    v118 = sub_74FE7A4(v117, v116, 0);
    v119 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CE64E8);
    if ( v119[56] == 0 )
      il2cpp_codegen_runtime_class_init(v119);
    UnityEngine_Debug__LogError(v118, 0);
    if ( v5 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v129 = *((_QWORD *)self + 6);
    if ( v129 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v135 = v5[7];
    if ( v135 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v136 = *(_QWORD *)(v129 + 24);
    v137 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CFFA18);
    System_Collections_Generic_Dictionary_object__object___Remove(v135, v136, v137);
    v138 = *((_QWORD *)self + 6);
    if ( v138 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
LABEL_267:
    v145 = *(_QWORD *)(v138 + 24);
    v146 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D86700);
    v128 = sub_74FE7A4(v146, v145, 0);
    v147 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
    v148 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v147);
    System_Exception___ctor(v148, v128, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v148, method);
    goto LABEL_268;
  }
  if ( (v25 & 1) == 0 )
    v24 = ((__int64 (*)(void))unk_3C503A0)();
  OperationException = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_OperationException(
                         (char *)self + 80,
                         *(_QWORD *)(*(_QWORD *)(v24 + 192) + 208LL));
  v109 = *((_QWORD *)method + 4);
  v110 = *(_WORD *)(v109 + 309);
  if ( OperationException != 0 )
  {
    if ( (v110 & 1) == 0 )
      v109 = ((__int64 (*)(void))unk_3C503A0)();
    v126 = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_OperationException(
             (char *)self + 80,
             *(_QWORD *)(*(_QWORD *)(v109 + 192) + 208LL));
    if ( v126 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v114 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v126 + 392LL))(
             v126,
             *(_QWORD *)(*(_QWORD *)v126 + 400LL));
  }
  else
  {
    if ( (v110 & 1) == 0 )
      v109 = ((__int64 (*)(void))unk_3C503A0)();
    LODWORD(v174) = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Status(
                      (char *)self + 80,
                      *(_QWORD *)(*(_QWORD *)(v109 + 192) + 200LL));
    v111 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE4528);
    v112 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(v111, &v174);
    v113 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D86768);
    v114 = System_String__Format(v113, v112, 0);
  }
  v127 = *((_QWORD *)self + 6);
  v128 = v114;
  if ( v127 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v130 = *(_QWORD *)(v127 + 24);
  v131 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D866F0);
  v132 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D523F0);
  v133 = sub_750A63C(v131, v130, v132, v128, 0);
  v134 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CE64E8);
  if ( v134[56] == 0 )
    il2cpp_codegen_runtime_class_init(v134);
  UnityEngine_Debug__LogError(v133, 0);
  if ( v5 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
LABEL_268:
  v149 = *((_QWORD *)self + 6);
  if ( v149 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v150 = v5[7];
  if ( v150 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v151 = *(_QWORD *)(v149 + 24);
  v152 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CFFA18);
  System_Collections_Generic_Dictionary_object__object___Remove(v150, v151, v152);
  v153 = *((_QWORD *)self + 6);
  if ( v153 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v154 = *(_QWORD *)(v153 + 24);
  v155 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D866F0);
  v156 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D523F0);
  v157 = sub_750A63C(v155, v154, v156, v128, 0);
  v158 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
  v159 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v158);
  System_Exception___ctor(v159, v157, 0);
  v160 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v159, method);
  if ( v161 != 1 )
  {
    if ( v4 < 0 )
    {
      v162 = v5[8];
      if ( v162 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Threading_ReaderWriterLockSlim__ExitWriteLock(v162, 0);
    }
    if ( v4 < 0 )
    {
      v163 = v5[8];
      if ( v163 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Threading_ReaderWriterLockSlim__ExitUpgradeableReadLock(v163, 0);
    }
    sub_3CE73C4(v160);
  }
  v29 = *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v160);
  ((void (*)(void))__cxa_end_catch)();
  v33 = 0;
  v19 = 0;
  v32 = 1;
  if ( v4 < 0 )
  {
LABEL_59:
    if ( v5 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v34 = v5[8];
    if ( v34 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Threading_ReaderWriterLockSlim__ExitWriteLock(v34, 0);
  }
LABEL_62:
  if ( v29 != 0 )
  {
    ((void (__fastcall *)(__int64))sub_3C38CF8)(v29);
    goto LABEL_184;
  }
  if ( (v32 & 1) == 0 )
    goto LABEL_89;
  v33 = 0;
  if ( v4 < 0 )
  {
LABEL_90:
    if ( v5 == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    v44 = v5[8];
    if ( v44 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Threading_ReaderWriterLockSlim__ExitUpgradeableReadLock(v44, 0);
  }
LABEL_93:
  if ( v33 != 0 )
  {
    *(_DWORD *)self = -2;
    *((_QWORD *)self + 6) = 0;
    v45 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v45 + 309) & 1) == 0 )
      v45 = ((__int64 (*)(void))unk_3C503A0)();
    v46 = *((__int64 **)self + 1);
    if ( v46 != nullptr )
    {
      v47 = *(_QWORD *)(*(_QWORD *)(*(_QWORD *)(v45 + 192) + 232LL) + 32LL);
      if ( (*(_BYTE *)(v47 + 309) & 1) == 0 )
        v47 = ((__int64 (*)(void))unk_3C503A0)();
      v48 = *(_QWORD *)(*(_QWORD *)(v47 + 192) + 8LL);
      if ( (*(_BYTE *)(v48 + 309) & 1) == 0 )
        v48 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v47 + 192) + 8LL));
      v49 = *v46;
      v50 = *(unsigned __int16 *)(*v46 + 302);
      if ( *(_WORD *)(*v46 + 302) != 0 )
      {
        v51 = (_DWORD *)(*(_QWORD *)(v49 + 176) + 8LL);
        while ( *((_QWORD *)v51 - 1) != v48 )
        {
          --v50;
          v51 += 4;
          if ( v50 == 0 )
            goto LABEL_105;
        }
        v52 = v49 + 16LL * (*v51 + 2) + 312;
      }
      else
      {
LABEL_105:
        v52 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v46, v48, 2);
      }
      (*(void (__fastcall **)(__int64 *, __int64, _QWORD))v52)(v46, v19, *(_QWORD *)(v52 + 8));
    }
    else
    {
      *((_QWORD *)self + 3) = v19;
    }
  }
  else
  {
    v53 = v171;
    *(_DWORD *)self = -2;
    *((_QWORD *)self + 6) = 0;
    v54 = *((_QWORD *)method + 4);
    if ( (*(_BYTE *)(v54 + 309) & 1) == 0 )
      v54 = ((__int64 (*)(void))unk_3C503A0)();
    v55 = *((__int64 **)self + 1);
    if ( v55 != nullptr )
    {
      v56 = *(_QWORD *)(*(_QWORD *)(*(_QWORD *)(v54 + 192) + 224LL) + 32LL);
      if ( (*(_BYTE *)(v56 + 309) & 1) == 0 )
        v56 = ((__int64 (*)(void))unk_3C503A0)();
      v57 = *(_QWORD *)(*(_QWORD *)(v56 + 192) + 8LL);
      if ( (*(_BYTE *)(v57 + 309) & 1) == 0 )
        v57 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v56 + 192) + 8LL));
      v58 = *v55;
      v59 = *(unsigned __int16 *)(*v55 + 302);
      if ( *(_WORD *)(*v55 + 302) != 0 )
      {
        v60 = (_DWORD *)(*(_QWORD *)(v58 + 176) + 8LL);
        while ( *((_QWORD *)v60 - 1) != v57 )
        {
          --v59;
          v60 += 4;
          if ( v59 == 0 )
            goto LABEL_117;
        }
        v61 = v58 + 16LL * (*v60 + 3) + 312;
      }
      else
      {
LABEL_117:
        v61 = ((__int64 (__fastcall *)(__int64 *, __int64, __int64))unk_3C504A4)(v55, v57, 3);
      }
      (*(void (__fastcall **)(__int64 *, __int64, _QWORD))v61)(v55, v53, *(_QWORD *)(v61 + 8));
    }
    else
    {
      *((_QWORD *)self + 2) = v53;
    }
  }
}
