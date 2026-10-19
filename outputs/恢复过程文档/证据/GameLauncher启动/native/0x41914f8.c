void CoreModule_GameLauncher__StartBackgroundManagersInit(void *self, const MethodInfo *method)
{
  __int64 v2; // x2
  __int64 Instance; // x0
  __int64 v4; // x0
  __int64 v5; // x1
  __int64 v6; // x2
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x2
  __int64 v11; // x0
  __int64 v12; // x0
  __int64 v13; // x1
  __int64 v14; // x2
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x1
  __int64 v18; // x2
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x1
  __int64 v22; // x2
  __int64 v23; // x0
  __int64 v24; // x0
  __int64 v25; // x1
  __int64 v26; // x2
  __int64 v27; // x0
  __int64 v28; // x0
  __int64 v29; // x1
  __int64 v30; // x2
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 v33; // x1
  __int64 v34; // x2
  __int64 v35; // x0
  __int64 v36; // x0
  __int64 v37; // x1
  __int64 v38; // x2
  __int64 v39; // x0
  __int64 v40; // x0
  __int64 v41; // x1
  __int64 v42; // x2
  __int64 v43; // x0
  __int64 v44; // x0
  __int64 v45; // x1
  __int64 v46; // x2
  __int64 v47; // x0
  __int64 v48; // x0
  __int64 v49; // x1
  __int64 v50; // x2
  __int64 v51; // x0
  __int64 v52; // x0
  __int64 v53; // x1
  __int64 v54; // x2
  __int64 v55; // x0
  __int64 v56; // x0
  __int64 v57; // x1
  __int64 v58; // x2
  __int64 v59; // x0
  __int64 v60; // x0
  __int64 v61; // x1
  __int64 v62; // x2
  __int64 v63; // x0
  __int64 v64; // x0
  __int64 v65; // x1
  __int64 v66; // x2
  __int64 v67; // x0
  __int64 v68; // x0

  if ( (byte_8FFF6AC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12128);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12440);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12018);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12348);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12158);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D120B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12450);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D124B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D123D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12390);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11FC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12358);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D120C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D122C8);
    byte_8FFF6AC = 1;
  }
  Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12158, method, v2);
  if ( Instance == 0 )
    goto LABEL_21;
  v4 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Instance + 376LL))(
         Instance,
         *(_QWORD *)(*(_QWORD *)Instance + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v4);
  v7 = ToolModule_ManagerBase_object___get_Instance(qword_8D12018, v5, v6);
  if ( v7 == 0 )
    goto LABEL_21;
  v8 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v7 + 376LL))(v7, *(_QWORD *)(*(_QWORD *)v7 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v8);
  v11 = ToolModule_ManagerBase_object___get_Instance(qword_8D124B8, v9, v10);
  if ( v11 == 0 )
    goto LABEL_21;
  v12 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v11 + 376LL))(v11, *(_QWORD *)(*(_QWORD *)v11 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v12);
  v15 = ToolModule_ManagerBase_object___get_Instance(qword_8D12128, v13, v14);
  if ( v15 == 0 )
    goto LABEL_21;
  v16 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v15 + 376LL))(v15, *(_QWORD *)(*(_QWORD *)v15 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v16);
  v19 = ToolModule_ManagerBase_object___get_Instance(qword_8D124D8, v17, v18);
  if ( v19 == 0 )
    goto LABEL_21;
  v20 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v19 + 376LL))(v19, *(_QWORD *)(*(_QWORD *)v19 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v20);
  v23 = ToolModule_ManagerBase_object___get_Instance(qword_8D122C8, v21, v22);
  if ( v23 == 0 )
    goto LABEL_21;
  v24 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v23 + 376LL))(v23, *(_QWORD *)(*(_QWORD *)v23 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v24);
  v27 = ToolModule_ManagerBase_object___get_Instance(qword_8D12440, v25, v26);
  if ( v27 == 0 )
    goto LABEL_21;
  v28 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v27 + 376LL))(v27, *(_QWORD *)(*(_QWORD *)v27 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v28);
  v31 = ToolModule_ManagerBase_object___get_Instance(qword_8D120C8, v29, v30);
  if ( v31 == 0 )
    goto LABEL_21;
  v32 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v31 + 376LL))(v31, *(_QWORD *)(*(_QWORD *)v31 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v32);
  v35 = ToolModule_ManagerBase_object___get_Instance(qword_8D123D0, v33, v34);
  if ( v35 == 0 )
    goto LABEL_21;
  v36 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v35 + 376LL))(v35, *(_QWORD *)(*(_QWORD *)v35 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v36);
  v39 = ToolModule_ManagerBase_object___get_Instance(qword_8D12358, v37, v38);
  if ( v39 == 0 )
    goto LABEL_21;
  v40 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v39 + 376LL))(v39, *(_QWORD *)(*(_QWORD *)v39 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v40);
  v43 = ToolModule_ManagerBase_object___get_Instance(qword_8D12348, v41, v42);
  if ( v43 == 0 )
    goto LABEL_21;
  v44 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v43 + 376LL))(v43, *(_QWORD *)(*(_QWORD *)v43 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v44);
  v47 = ToolModule_ManagerBase_object___get_Instance(qword_8D12390, v45, v46);
  if ( v47 == 0 )
    goto LABEL_21;
  v48 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v47 + 376LL))(v47, *(_QWORD *)(*(_QWORD *)v47 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v48);
  v51 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FB8, v49, v50);
  if ( v51 == 0 )
    goto LABEL_21;
  v52 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v51 + 376LL))(v51, *(_QWORD *)(*(_QWORD *)v51 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v52);
  v55 = ToolModule_ManagerBase_object___get_Instance(qword_8D11FC8, v53, v54);
  if ( v55 == 0 )
    goto LABEL_21;
  v56 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v55 + 376LL))(v55, *(_QWORD *)(*(_QWORD *)v55 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v56);
  v59 = ToolModule_ManagerBase_object___get_Instance(qword_8D123E0, v57, v58);
  if ( v59 == 0
    || (v60 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v59 + 376LL))(
                v59,
                *(_QWORD *)(*(_QWORD *)v59 + 384LL)),
        Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v60),
        (v63 = ToolModule_ManagerBase_object___get_Instance(qword_8D120B8, v61, v62)) == 0)
    || (v64 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v63 + 376LL))(
                v63,
                *(_QWORD *)(*(_QWORD *)v63 + 384LL)),
        Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v64),
        (v67 = ToolModule_ManagerBase_object___get_Instance(qword_8D12450, v65, v66)) == 0) )
  {
LABEL_21:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v68 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v67 + 376LL))(v67, *(_QWORD *)(*(_QWORD *)v67 + 384LL));
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v68);
}
