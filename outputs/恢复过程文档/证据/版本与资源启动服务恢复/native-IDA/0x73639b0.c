_QWORD *__fastcall AssetBundles_AssetBundleManager__LoadManifest(__int64 a1)
{
  _QWORD *v2; // x0
  __int64 v3; // x0
  _QWORD *v4; // x0
  __int64 v5; // x0
  __int64 Item; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 TypeFromHandle; // x21
  __int64 v11; // x0
  __int64 v12; // x23
  _QWORD *v13; // x20
  __int64 v14; // x0
  __int64 v15; // x8
  _QWORD *v16; // x9
  __int64 v17; // x10

  if ( (byte_900A6CF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE43F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD2F68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEC20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEC28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEC40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D090A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56B90);
    byte_900A6CF = 1;
  }
  v2 = off_8CE4408;
  if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE4408);
    v2 = off_8CE4408;
  }
  v3 = *(_QWORD *)(v2[23] + 32LL);
  if ( v3 == 0 )
    goto LABEL_24;
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v3, a1, qword_8CFEC20) & 1) != 0 )
  {
    v4 = off_8CE4408;
    if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE4408);
      v4 = off_8CE4408;
    }
    v5 = *(_QWORD *)(v4[23] + 32LL);
    if ( v5 == 0
      || (Item = System_Collections_Generic_Dictionary_object__object___get_Item(v5, a1, qword_8CFEC40)) == 0
      || (v7 = *(_QWORD *)(Item + 16)) == 0
      || (UnityEngine_AssetBundle__Unload(v7, 1, 0), (v8 = *(_QWORD *)(*((_QWORD *)off_8CE4408 + 23) + 32LL)) == 0) )
    {
LABEL_24:
      il2cpp_codegen_raise_null_reference_exception();
    }
    System_Collections_Generic_Dictionary_object__object___Remove(v8, a1, qword_8CFEC28);
  }
  if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4408);
  AssetBundles_AssetBundleManager__LoadAssetBundle(a1, 1);
  v9 = qword_8CD2F68;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v9, 0);
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE43F8);
  v12 = qword_8D56B90;
  v13 = (_QWORD *)v11;
  System_Object___ctor(v11, 0);
  v13[2] = a1;
  v13[3] = v12;
  v13[5] = TypeFromHandle;
  v14 = *(_QWORD *)(*((_QWORD *)off_8CE4408 + 23) + 56LL);
  if ( v14 == 0 )
    goto LABEL_24;
  v15 = *(_QWORD *)(v14 + 16);
  v16 = off_8D090A8;
  ++*(_DWORD *)(v14 + 28);
  if ( v15 == 0 )
    goto LABEL_24;
  v17 = *(int *)(v14 + 24);
  if ( (unsigned int)v17 >= *(_DWORD *)(v15 + 24) )
  {
    System_Collections_Generic_List_object___AddWithResize(v14, v13, *(_QWORD *)(*(_QWORD *)(v16[4] + 192LL) + 112LL));
  }
  else
  {
    *(_DWORD *)(v14 + 24) = v17 + 1;
    *(_QWORD *)(v15 + 8 * v17 + 32) = v13;
  }
  return v13;
}
