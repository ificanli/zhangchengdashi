void stage41_GameFramework_ConfigRead__SM_yV_object___ai_FI_(void *a0, void *a1, void *a2)
{
  __int64 mainObject; // x0
  __int64 v7; // x10
  void *text; // x22
  int *it_g_object; // x0
  int *v10; // x22
  unsigned int v11; // w23
  __int64 v12; // x24
  __int64 Item; // x0
  __int64 v14; // x0
  __int64 v15; // x0
  __int64 v16; // x25
  __int64 v17; // x24
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x0
  __int64 v21; // x25
  __int64 v22; // x0
  __int64 v23; // x24
  __int64 v24; // x0
  __int64 v25; // x25
  __int64 v26; // x0
  __int64 v27; // x0
  __int64 v28; // x20
  __int64 v29; // x0

  if ( (byte_9006FE4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D88368);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89258);
    byte_9006FE4 = 1;
  }
  if ( a1 == nullptr )
    goto LABEL_36;
  mainObject = YooAsset_AssetOperationHandle__get_mainObject(a1, 0);
  if ( mainObject == 0 )
    goto LABEL_36;
  v7 = *((unsigned __int8 *)off_8CEE250 + 304);
  if ( *(unsigned __int8 *)(*(_QWORD *)mainObject + 304LL) < (unsigned int)v7
    || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)mainObject + 200LL) + 8 * v7 - 8) != off_8CEE250 )
  {
    goto LABEL_36;
  }
  text = (void *)UnityEngine_TextAsset__get_text(mainObject, 0);
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  it_g_object = (int *)GameFramework_ConfigRead____it_g_object_(text, **(void ***)(*((_QWORD *)a2 + 4) + 192LL));
  if ( it_g_object == nullptr )
  {
    v27 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    if ( v27 == 0 )
      goto LABEL_36;
    v28 = v27;
    if ( qword_8D89258 == 0
      || (v22 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                  qword_8D89258,
                  *(_QWORD *)(*(_QWORD *)v27 + 64LL))) != 0 )
    {
      if ( *(_DWORD *)(v28 + 24) != 0 )
      {
        *(_QWORD *)(v28 + 32) = qword_8D89258;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v28, 0);
        goto LABEL_35;
      }
LABEL_37:
      v22 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
LABEL_38:
    v29 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v22);
    ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v29, 0);
    JUMPOUT(0x685D888);
  }
  v10 = it_g_object;
  if ( it_g_object[6] >= 1 )
  {
    v11 = 0;
    while ( 1 )
    {
      v12 = *((_QWORD *)a0 + 2);
      Item = System_Collections_Generic_List_object___get_Item(
               v10,
               v11,
               *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 32LL));
      if ( Item == 0 )
        break;
      v14 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Item + 376LL))(
              Item,
              *(_QWORD *)(*(_QWORD *)Item + 384LL));
      if ( v12 == 0 )
        break;
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(
              v12,
              v14,
              *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 48LL))
          & 1) != 0 )
      {
        v15 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        v16 = *((_QWORD *)a0 + 3);
        v17 = v15;
        v18 = System_Collections_Generic_List_object___get_Item(
                v10,
                v11,
                *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 32LL));
        if ( v18 == 0 )
          break;
        v19 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v18 + 376LL))(
                v18,
                *(_QWORD *)(*(_QWORD *)v18 + 384LL));
        v20 = sub_750AA4C(qword_8D88368, v16, v19, 0);
        if ( v17 == 0 )
          break;
        v21 = v20;
        if ( v20 != 0 )
        {
          v22 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v20, *(_QWORD *)(*(_QWORD *)v17 + 64LL));
          if ( v22 == 0 )
            goto LABEL_38;
        }
        if ( *(_DWORD *)(v17 + 24) == 0 )
          goto LABEL_37;
        *(_QWORD *)(v17 + 32) = v21;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Error(v17, 0);
      }
      else
      {
        v23 = *((_QWORD *)a0 + 2);
        v24 = System_Collections_Generic_List_object___get_Item(
                v10,
                v11,
                *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 32LL));
        if ( v24 == 0 )
          break;
        v25 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v24 + 376LL))(
                v24,
                *(_QWORD *)(*(_QWORD *)v24 + 384LL));
        v26 = System_Collections_Generic_List_object___get_Item(
                v10,
                v11,
                *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 32LL));
        if ( v23 == 0 )
          break;
        System_Collections_Generic_Dictionary_object__object___Add(
          v23,
          v25,
          v26,
          *(_QWORD *)(*(_QWORD *)(*((_QWORD *)a2 + 4) + 192LL) + 56LL));
      }
      if ( (int)++v11 >= v10[6] )
        goto LABEL_35;
    }
LABEL_36:
    il2cpp_codegen_raise_null_reference_exception();
  }
LABEL_35:
  YooAsset_AssetOperationHandle__Release(a1, 0);
}
