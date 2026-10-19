void AssetsModule_AssetsManager___c__DisplayClass19_0_object____LoadAssetAsync_b__0(
        void *self,
        void *handle,
        const MethodInfo *method)
{
  __int64 v6; // x8
  __int64 v7; // x0
  __int64 v8; // x22
  __int64 v9; // x23
  __int64 OperationException; // x0
  __int64 v11; // x24
  __int64 v12; // x3
  __int64 v13; // x22
  __int64 v14; // x8
  __int64 v15; // x0
  __int64 v16; // x1
  __int64 v17; // x8
  __int64 v18; // x0
  __int64 v19; // x8
  __int64 v20; // x0
  __int64 v21; // x8
  __int64 v22; // x8
  __int64 v23; // x0
  __int128 v24; // [xsp+0h] [xbp-80h]
  __int64 v25; // [xsp+10h] [xbp-70h]
  __int128 v26; // [xsp+20h] [xbp-60h] BYREF
  __int64 v27; // [xsp+30h] [xbp-50h]

  if ( (byte_9002466 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE3D98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE4528);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFA18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDE40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E658);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D19858);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D866F8);
    byte_9002466 = 1;
  }
  v6 = *((_QWORD *)self + 2);
  if ( v6 == 0 )
    goto LABEL_28;
  v7 = *(_QWORD *)(v6 + 64);
  if ( v7 == 0 )
    goto LABEL_28;
  System_Threading_ReaderWriterLockSlim__EnterWriteLock(v7, 0);
  if ( (unsigned int)UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Status(
                       handle,
                       *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 16LL)) != 1 )
  {
    v8 = *((_QWORD *)self + 3);
    LODWORD(v26) = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_Status(
                     handle,
                     *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 16LL));
    v9 = ((__int64 (__fastcall *)(__int64, __int128 *))unk_3C3D3B8)(qword_8CE4528, &v26);
    OperationException = UnityEngine_ResourceManagement_AsyncOperations_AsyncOperationHandle_object___get_OperationException(
                           handle,
                           *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 32LL));
    v11 = qword_8D866F8;
    if ( OperationException != 0 )
      v12 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)OperationException + 392LL))(
              OperationException,
              *(_QWORD *)(*(_QWORD *)OperationException + 400LL));
    else
      v12 = 0;
    v13 = sub_750AA90(v11, v8, v9, v12, 0);
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(v13, 0);
    v14 = *((_QWORD *)self + 2);
    if ( v14 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v15 = *(_QWORD *)(v14 + 56);
    if ( v15 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    System_Collections_Generic_Dictionary_object__object___Remove(v15, *((_QWORD *)self + 3), qword_8CFFA18);
    v24 = *(_OWORD *)handle;
    v25 = *((_QWORD *)handle + 2);
    if ( *((_DWORD *)off_8CE3D98 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE3D98);
    v16 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 40LL);
    v26 = v24;
    v27 = v25;
    UnityEngine_AddressableAssets_Addressables__Release_object_(&v26, v16);
    v17 = *((_QWORD *)self + 2);
    if ( v17 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v18 = *(_QWORD *)(v17 + 80);
    if ( v18 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v18, *((_QWORD *)self + 4), qword_8CFDE38)
        & 1) != 0 )
    {
      v19 = *((_QWORD *)self + 2);
      if ( v19 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v20 = *(_QWORD *)(v19 + 80);
      if ( v20 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      if ( System_Collections_Generic_Dictionary_object__object___get_Item(v20, *((_QWORD *)self + 4), qword_8CFDE40) == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      System_Collections_Generic_List_object___Remove();
    }
  }
  v21 = *((_QWORD *)self + 5);
  if ( v21 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_QWORD *)(v21 + 48) != 0 )
    Cysharp_Threading_Tasks_UniTaskCompletionSource_object___TrySetResult();
  v22 = *((_QWORD *)self + 2);
  if ( v22 == 0 || (v23 = *(_QWORD *)(v22 + 64)) == 0 )
LABEL_28:
    il2cpp_codegen_raise_null_reference_exception();
  System_Threading_ReaderWriterLockSlim__ExitWriteLock(v23, 0);
}
