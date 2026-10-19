void DataModule_GlobalInfo__LoadGlobalInfo_d__94_object___MoveNext(void *self, const MethodInfo *method)
{
  __int64 v4; // x21
  __int64 v5; // x22
  __int128 v6; // q0
  __int64 v7; // x0
  __int64 v8; // x1
  __int64 v9; // x8
  _QWORD *v10; // x9
  __int64 v11; // x10
  __int64 v12; // x0
  __int64 v13; // x1
  __int64 v14; // x8
  _QWORD *v15; // x9
  __int64 v16; // x10
  __int64 v17; // x0
  int IndexOf; // w22
  __int64 v19; // x0
  int v20; // w0
  __int64 v21; // x1
  __int64 v22; // x0
  __int64 object; // x22
  __int64 v24; // x22
  void *Instance; // x0
  __int64 *v26; // x22
  unsigned int v27; // w23
  __int64 v28; // x0
  __int64 v29; // x1
  __int64 v30; // x8
  __int64 v31; // x9
  int *v32; // x10
  __int64 v33; // x0
  __int128 v34; // q0
  __int64 v35; // x0
  __int64 v36; // x24
  __int64 v37; // x23
  __int64 text; // x0
  __int64 v39; // x22
  __int64 v40; // x0
  __int64 v41; // x22
  __int128 v42; // [xsp+8h] [xbp-98h] BYREF
  __int64 v43; // [xsp+18h] [xbp-88h]
  __int128 v44; // [xsp+20h] [xbp-80h]
  __int64 v45; // [xsp+30h] [xbp-70h]
  __int128 v46; // [xsp+40h] [xbp-60h] BYREF
  __int64 v47; // [xsp+50h] [xbp-50h]

  if ( (byte_90071A2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1E040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF9A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF9A18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0E5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E658);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D37C70);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D19A30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89268);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D658A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89260);
    byte_90071A2 = 1;
  }
  v46 = 0u;
  v47 = 0;
  v44 = 0u;
  v45 = 0;
  v4 = *((_QWORD *)self + 5);
  if ( *(_DWORD *)self == 0 )
  {
    v6 = *((_OWORD *)self + 4);
    v47 = *((_QWORD *)self + 10);
    v46 = v6;
    *((_QWORD *)self + 9) = 0;
    *((_QWORD *)self + 10) = 0;
    *((_QWORD *)self + 8) = 0;
    *(_DWORD *)self = -1;
    goto LABEL_33;
  }
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_QWORD *)(v4 + 752) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_Collections_Generic_List_object___Contains() & 1) != 0 )
  {
    v5 = sub_74FE7A4(qword_8D89268, *((_QWORD *)self + 6), 0);
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(v5, 0);
  }
  else
  {
    v7 = *(_QWORD *)(v4 + 752);
    if ( v7 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v8 = *((_QWORD *)self + 6);
    v9 = *(_QWORD *)(v7 + 16);
    v10 = off_8D0E5F8;
    ++*(_DWORD *)(v7 + 28);
    if ( v9 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v11 = *(int *)(v7 + 24);
    if ( (unsigned int)v11 >= *(_DWORD *)(v9 + 24) )
    {
      System_Collections_Generic_List_object___AddWithResize(v7, v8, *(_QWORD *)(*(_QWORD *)(v10[4] + 192LL) + 112LL));
    }
    else
    {
      *(_DWORD *)(v7 + 24) = v11 + 1;
      *(_QWORD *)(v9 + 8 * v11 + 32) = v8;
    }
  }
  v12 = *(_QWORD *)(v4 + 16);
  if ( v12 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v13 = *((_QWORD *)self + 6);
  v14 = *(_QWORD *)(v12 + 16);
  v15 = off_8D0E5F8;
  ++*(_DWORD *)(v12 + 28);
  if ( v14 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v16 = *(int *)(v12 + 24);
  if ( (unsigned int)v16 >= *(_DWORD *)(v14 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v12, v13, *(_QWORD *)(*(_QWORD *)(v15[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v12 + 24) = v16 + 1;
    *(_QWORD *)(v14 + 8 * v16 + 32) = v13;
  }
  v17 = *((_QWORD *)self + 6);
  if ( v17 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  IndexOf = System_String__LastIndexOf(v17, 47, 0);
  v19 = *((_QWORD *)self + 6);
  if ( v19 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v20 = System_String__LastIndexOf(v19, 46, 0);
  if ( *((_QWORD *)self + 6) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v21 = System_String__Substring(*((_QWORD *)self + 6), (unsigned int)(IndexOf + 1), (unsigned int)(v20 + ~IndexOf), 0);
  v22 = sub_74FE7A4(qword_8D658A8, v21, 0);
  object = UnityEngine_Resources__Load_object_(v22, qword_8D37C70);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Equality(object, 0, 0) & 1) == 0 )
  {
LABEL_49:
    v36 = *((_QWORD *)self + 7);
    if ( v36 != 0 )
    {
      if ( object == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v37 = *((_QWORD *)self + 6);
      text = UnityEngine_TextAsset__get_text(object, 0);
      if ( v4 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v39 = text;
      v40 = *((_QWORD *)method + 4);
      if ( (*(_BYTE *)(v40 + 309) & 1) == 0 )
        v40 = ((__int64 (*)(void))unk_3C503A0)();
      v41 = DataModule_GlobalInfo__GlobalStringToConfig_object_(
              v4,
              v37,
              v39,
              *(_QWORD *)(*(_QWORD *)(v40 + 192) + 32LL));
      if ( (*(_BYTE *)(*((_QWORD *)method + 4) + 309LL) & 1) == 0 )
        ((void (*)(void))unk_3C503A0)();
      (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v36 + 24))(*(_QWORD *)(v36 + 64), v41, *(_QWORD *)(v36 + 40));
    }
    else if ( v4 == 0 )
    {
      il2cpp_codegen_raise_null_reference_exception();
    }
    if ( *(_QWORD *)(v4 + 16) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_List_object___Remove();
    *(_DWORD *)self = -2;
    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
    return;
  }
  v24 = sub_74FE7A4(qword_8D89260, *((_QWORD *)self + 6), 0);
  if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64E8);
  UnityEngine_Debug__LogWarning(v24, 0);
  Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12008);
  if ( Instance == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  AssetsModule_AssetsManager__LoadAssetAsync_object_(&v42, Instance, *((_QWORD *)self + 6), qword_8D1E040);
  v44 = v42;
  v45 = v43;
  if ( (*(_BYTE *)(*((_QWORD *)off_8D19A30 + 4) + 309LL) & 1) == 0 )
    ((void (*)(void))unk_3C503A0)();
  v46 = v44;
  v47 = v45;
  if ( (((__int64 (__fastcall *)(__int128 *, __int64))unk_3D31494)(&v46, qword_8CF9A18) & 1) != 0 )
  {
LABEL_33:
    v26 = (__int64 *)v46;
    if ( (_QWORD)v46 != 0 )
    {
      v27 = (unsigned __int16)v47;
      v28 = *((_QWORD *)off_8CF9A10 + 4);
      if ( (*(_BYTE *)(v28 + 309) & 1) == 0 )
        v28 = ((__int64 (*)(void))unk_3C503A0)();
      v29 = *(_QWORD *)(*(_QWORD *)(v28 + 192) + 40LL);
      if ( (*(_BYTE *)(v29 + 309) & 1) == 0 )
        v29 = ((__int64 (__fastcall *)(_QWORD))unk_3C503A0)(*(_QWORD *)(*(_QWORD *)(v28 + 192) + 40LL));
      v30 = *v26;
      v31 = *(unsigned __int16 *)(*v26 + 302);
      if ( *(_WORD *)(*v26 + 302) != 0 )
      {
        v32 = (int *)(*(_QWORD *)(v30 + 176) + 8LL);
        while ( *((_QWORD *)v32 - 1) != v29 )
        {
          --v31;
          v32 += 4;
          if ( v31 == 0 )
            goto LABEL_42;
        }
        v33 = v30 + 16LL * *v32 + 312;
      }
      else
      {
LABEL_42:
        v33 = ((__int64 (__fastcall *)(__int64 *, __int64, _QWORD))unk_3C504A4)(v26, v29, 0);
      }
      object = (*(__int64 (__fastcall **)(__int64 *, _QWORD, _QWORD))v33)(v26, v27, *(_QWORD *)(v33 + 8));
    }
    else
    {
      object = *((_QWORD *)&v46 + 1);
    }
    goto LABEL_49;
  }
  *(_DWORD *)self = 0;
  v34 = v46;
  *((_QWORD *)self + 10) = v47;
  *((_OWORD *)self + 4) = v34;
  v35 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v35 + 309) & 1) == 0 )
    v35 = ((__int64 (*)(void))unk_3C503A0)();
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___GlobalInfo__LoadGlobalInfo_d__94_object__(
    (char *)self + 8,
    &v46,
    self,
    *(_QWORD *)(*(_QWORD *)(v35 + 192) + 8LL));
}
