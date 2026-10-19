void stage41_GameFramework_ConfigRead_f___mX_object___MoveNext(void *a0, void *a1)
{
  __int64 Helper__LoadAssetAsync_object; // x0
  __int64 v5; // x0
  __int64 Result; // x0
  __int64 v7; // x21
  __int64 mainObject; // x0
  __int64 v9; // x10
  void *text; // x22
  __int64 v11; // x0
  _DWORD *it_g_object; // x22
  unsigned int i; // w23
  __int64 v14; // x0
  __int64 v15; // x24
  __int64 Item; // x0
  __int64 v17; // x0
  __int64 v18; // x25
  __int64 v19; // x0
  __int64 v20; // x24
  __int64 v21; // x0
  __int64 v22; // x25
  __int64 v23; // x0
  __int64 v24; // x2
  __int64 v25; // x0
  __int64 v26; // x25
  __int64 v27; // x0
  __int64 v28; // x24
  __int64 v29; // x0
  __int64 v30; // x25
  __int64 v31; // x0
  __int64 v32; // x0
  __int64 v33; // x26
  __int64 v34; // x0
  __int64 v35; // x20
  __int64 v36; // x0
  char *v37; // x19
  __int64 v38; // x0
  __int64 v39; // x0
  __int64 v40; // x0
  int v41; // w1
  _QWORD **v42; // x20
  __int64 v43; // x0
  _QWORD *v44; // x20
  char *v45; // x19
  _DWORD *v46; // x0
  __int64 Awaiter; // [xsp+8h] [xbp-68h] BYREF

  if ( (byte_9006FA6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4558);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34C78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D18618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D18620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D18A28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88368);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89258);
    byte_9006FA6 = 1;
  }
  Awaiter = 0;
  if ( *(_DWORD *)a0 != 0 )
  {
    Helper__LoadAssetAsync_object = GameFramework_NewResLoadHelper__LoadAssetAsync_object_(
                                      *((_QWORD *)a0 + 4),
                                      qword_8D34C78);
    if ( Helper__LoadAssetAsync_object == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    Awaiter = System_Threading_Tasks_Task_object___GetAwaiter(Helper__LoadAssetAsync_object, qword_8D18A28);
    if ( (System_Runtime_CompilerServices_TaskAwaiter_object___get_IsCompleted(&Awaiter, qword_8D18620) & 1) == 0 )
    {
      *(_DWORD *)a0 = 0;
      *((_QWORD *)a0 + 6) = Awaiter;
      if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4558);
      v5 = *((_QWORD *)a1 + 4);
      if ( (*(_BYTE *)(v5 + 309) & 1) == 0 )
        v5 = ((__int64 (*)(void))unk_3C503A0)();
      System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_TaskAwaiter_object___ConfigRead_f___mX_object__(
        (char *)a0 + 8,
        &Awaiter,
        a0,
        *(_QWORD *)(*(_QWORD *)(v5 + 192) + 8LL));
      return;
    }
  }
  else
  {
    Awaiter = *((_QWORD *)a0 + 6);
    *((_QWORD *)a0 + 6) = 0;
    *(_DWORD *)a0 = -1;
  }
  Result = System_Runtime_CompilerServices_TaskAwaiter_object___GetResult(&Awaiter, qword_8D18618);
  v7 = Result;
  if ( Result == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  mainObject = YooAsset_AssetOperationHandle__get_mainObject(Result, 0);
  if ( mainObject == 0
    || (v9 = *((unsigned __int8 *)off_8CEE250 + 304),
        *(unsigned __int8 *)(*(_QWORD *)mainObject + 304LL) < (unsigned int)v9)
    || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)mainObject + 200LL) + 8 * v9 - 8) != off_8CEE250 )
  {
LABEL_70:
    il2cpp_codegen_raise_null_reference_exception();
  }
  text = (void *)UnityEngine_TextAsset__get_text(mainObject, 0);
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  v11 = *((_QWORD *)a1 + 4);
  if ( (*(_BYTE *)(v11 + 309) & 1) == 0 )
    v11 = ((__int64 (*)(void))unk_3C503A0)();
  it_g_object = GameFramework_ConfigRead____it_g_object_(text, *(void **)(*(_QWORD *)(v11 + 192) + 24LL));
  if ( it_g_object != nullptr )
  {
    for ( i = 0; ; ++i )
    {
      if ( (*(_BYTE *)(*((_QWORD *)a1 + 4) + 309LL) & 1) == 0 )
        ((void (*)(void))unk_3C503A0)();
      if ( (signed int)i >= it_g_object[6] )
        goto LABEL_59;
      v14 = *((_QWORD *)a1 + 4);
      v15 = *((_QWORD *)a0 + 5);
      if ( (*(_BYTE *)(v14 + 309) & 1) == 0 )
        v14 = ((__int64 (*)(void))unk_3C503A0)();
      Item = System_Collections_Generic_List_object___get_Item(
               it_g_object,
               i,
               *(_QWORD *)(*(_QWORD *)(v14 + 192) + 48LL));
      if ( Item == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v17 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 376LL))(
              Item,
              *(_QWORD *)(*(_QWORD *)Item + 384LL));
      if ( v15 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v18 = v17;
      v19 = *((_QWORD *)a1 + 4);
      if ( (*(_BYTE *)(v19 + 309) & 1) == 0 )
        v19 = ((__int64 (*)(void))unk_3C503A0)();
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
              v15,
              v18,
              *(_QWORD *)(*(_QWORD *)(v19 + 192) + 64LL))
          & 1) != 0 )
      {
        v20 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        v21 = *((_QWORD *)a1 + 4);
        v22 = *((_QWORD *)a0 + 4);
        if ( (*(_BYTE *)(v21 + 309) & 1) == 0 )
          v21 = ((__int64 (*)(void))unk_3C503A0)();
        v23 = System_Collections_Generic_List_object___get_Item(
                it_g_object,
                i,
                *(_QWORD *)(*(_QWORD *)(v21 + 192) + 48LL));
        if ( v23 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v24 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v23 + 376LL))(
                v23,
                *(_QWORD *)(*(_QWORD *)v23 + 384LL));
        v25 = sub_750AA4C(qword_8D88368, v22, v24, 0);
        if ( v20 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v26 = v25;
        if ( v25 != 0
          && ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v25, *(_QWORD *)(*(_QWORD *)v20 + 64LL)) == 0 )
        {
          v38 = ((__int64 (*)(void))unk_3C3D4F0)();
          ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v38, 0);
          goto LABEL_70;
        }
        if ( *(_DWORD *)(v20 + 24) == 0 )
        {
          ((void (*)(void))unk_3C3D4D4)();
LABEL_66:
          il2cpp_codegen_raise_null_reference_exception();
        }
        *(_QWORD *)(v20 + 32) = v26;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v20, 0);
      }
      else
      {
        v27 = *((_QWORD *)a1 + 4);
        v28 = *((_QWORD *)a0 + 5);
        if ( (*(_BYTE *)(v27 + 309) & 1) == 0 )
          v27 = ((__int64 (*)(void))unk_3C503A0)();
        v29 = System_Collections_Generic_List_object___get_Item(
                it_g_object,
                i,
                *(_QWORD *)(*(_QWORD *)(v27 + 192) + 48LL));
        if ( v29 == 0 )
          goto LABEL_66;
        v30 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v29 + 376LL))(
                v29,
                *(_QWORD *)(*(_QWORD *)v29 + 384LL));
        v31 = *((_QWORD *)a1 + 4);
        if ( (*(_BYTE *)(v31 + 309) & 1) == 0 )
          v31 = ((__int64 (*)(void))unk_3C503A0)();
        v32 = System_Collections_Generic_List_object___get_Item(
                it_g_object,
                i,
                *(_QWORD *)(*(_QWORD *)(v31 + 192) + 48LL));
        if ( v28 == 0 )
          il2cpp_codegen_raise_null_reference_exception();
        v33 = v32;
        v34 = *((_QWORD *)a1 + 4);
        if ( (*(_BYTE *)(v34 + 309) & 1) == 0 )
          v34 = ((__int64 (*)(void))unk_3C503A0)();
        System_Collections_Generic_Dictionary_object__object___Add(
          v28,
          v30,
          v33,
          *(_QWORD *)(*(_QWORD *)(v34 + 192) + 72LL));
      }
    }
  }
  v35 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
  if ( v35 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( qword_8D89258 != 0 )
  {
    v36 = ((__int64 (*)(void))unk_3C3D3B4)();
    if ( v36 == 0 )
      goto LABEL_75;
  }
  if ( *(_DWORD *)(v35 + 24) == 0 )
  {
    v36 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_75:
    v39 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v36);
    v40 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v39, 0);
    if ( v41 != 1 )
      sub_3CE73C4(v40);
    v42 = (_QWORD **)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v40);
    v43 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE71D0);
    if ( (((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D8F8)(v43, **v42) & 1) == 0 )
    {
      *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_allocate_exception)(8) = *v42;
      ((void (__noreturn *)(void))__cxa_throw)();
    }
    v44 = *v42;
    ((void (*)(void))__cxa_end_catch)();
    *(_DWORD *)a0 = -2;
    v45 = (char *)a0 + 8;
    v46 = (_DWORD *)((__int64 (__fastcall *)(_UNKNOWN **))unk_3C3D294)(&off_8CE4558);
    if ( v46[56] == 0 )
      il2cpp_codegen_runtime_class_init(v46);
    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetException(v45, v44, 0);
    return;
  }
  *(_QWORD *)(v35 + 32) = qword_8D89258;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Error(v35, 0);
LABEL_59:
  YooAsset_AssetOperationHandle__Release(v7, 0);
  *(_DWORD *)a0 = -2;
  v37 = (char *)a0 + 8;
  if ( *((_DWORD *)off_8CE4558 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4558);
  System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetResult(v37, 0);
}
