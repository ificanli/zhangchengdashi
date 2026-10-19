__int64 __fastcall GameModule_BattleGameSceneManager__GetSpecialNearHex(__int64 a1)
{
  __int64 v2; // x8
  __int64 v3; // x21
  __int64 v4; // x0
  unsigned int v5; // w22
  __int64 Item; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x8
  _QWORD *v10; // x9
  __int64 v11; // x10
  __int64 v12; // x0
  int v13; // w22
  unsigned int v14; // w25
  __int64 v15; // x24
  unsigned int v16; // w25
  __int64 v17; // x0
  __int64 transform; // x0
  __int64 v19; // x0
  __int64 v20; // x1
  __int64 v21; // x2
  __int64 v22; // x8
  _QWORD *v23; // x9
  __int64 v24; // x10
  __int64 v25; // x8
  _QWORD *v26; // x0
  __int64 v27; // x25
  __int64 v28; // x26
  __int64 v29; // x1
  __int64 v30; // x24
  __int64 v31; // x8
  _QWORD *v32; // x9
  __int64 v33; // x10
  __int64 v35; // [xsp+0h] [xbp-B0h]
  __int64 v36; // [xsp+8h] [xbp-A8h]
  __int64 v37; // [xsp+10h] [xbp-A0h] BYREF
  __int64 v38; // [xsp+18h] [xbp-98h]

  if ( (byte_8FFD7AB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8E30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0B4E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D08A30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08A38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08A28);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B4D0);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0F830);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0B528);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D08A40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B530);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F838);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D08A48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD888);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD0F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D450D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF1468);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1C4B8);
    byte_8FFD7AB = 1;
  }
  v2 = *(_QWORD *)(a1 + 376);
  if ( v2 == 0 )
    goto LABEL_51;
  if ( *(_DWORD *)(v2 + 24) == 0 )
    return 0;
  v36 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD888);
  System_Collections_Generic_List_object____ctor(v36, qword_8D0B4D0);
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD888);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0B4D0);
  v4 = *(_QWORD *)(a1 + 112);
  if ( v4 == 0 )
    goto LABEL_51;
  v5 = 0;
  while ( (signed int)v5 < *(_DWORD *)(v4 + 24) )
  {
    Item = System_Collections_Generic_List_object___get_Item(v4, v5, qword_8D0B530);
    if ( Item == 0 )
      goto LABEL_51;
    if ( *(_BYTE *)(Item + 80) != 0 )
    {
      v7 = *(_QWORD *)(a1 + 112);
      if ( v7 == 0 )
        goto LABEL_51;
      v8 = System_Collections_Generic_List_object___get_Item(v7, v5, qword_8D0B530);
      if ( v3 == 0 )
        goto LABEL_51;
      v9 = *(_QWORD *)(v3 + 16);
      v10 = off_8D0B4E8;
      ++*(_DWORD *)(v3 + 28);
      if ( v9 == 0 )
        goto LABEL_51;
      v11 = *(int *)(v3 + 24);
      if ( (unsigned int)v11 >= *(_DWORD *)(v9 + 24) )
      {
        System_Collections_Generic_List_object___AddWithResize(v3, v8, *(_QWORD *)(*(_QWORD *)(v10[4] + 192LL) + 112LL));
      }
      else
      {
        *(_DWORD *)(v3 + 24) = v11 + 1;
        *(_QWORD *)(v9 + 8 * v11 + 32) = v8;
      }
    }
    v4 = *(_QWORD *)(a1 + 112);
    ++v5;
    if ( v4 == 0 )
      goto LABEL_51;
  }
  v12 = *(_QWORD *)(a1 + 376);
  if ( v12 == 0 )
    goto LABEL_51;
  v13 = 0;
  v35 = a1;
  while ( v13 < *(_DWORD *)(v12 + 24) )
  {
    System_Collections_Generic_List_Vector3___get_Item();
    if ( v3 == 0 )
      goto LABEL_51;
    v14 = *(_DWORD *)(v3 + 24);
    v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD0F8);
    sub_568CBDC(v15, v14, qword_8D08A28);
    if ( *(int *)(v3 + 24) >= 1 )
    {
      v16 = 0;
      while ( 1 )
      {
        v17 = System_Collections_Generic_List_object___get_Item(v3, v16, qword_8D0B530);
        if ( v17 == 0 )
          break;
        transform = UnityEngine_Component__get_transform(v17, 0);
        if ( transform == 0 )
          break;
        UnityEngine_Transform__get_position(transform, 0);
        if ( byte_8FFD020 == 0 )
        {
          il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
          byte_8FFD020 = 1;
        }
        if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CEA738);
        v19 = System_Collections_Generic_List_object___get_Item(v3, v16, qword_8D0B530);
        v37 = 0;
        v38 = 0;
        System_ValueTuple_float__object____ctor(&v37, v19, qword_8D1C4B8);
        if ( v15 == 0 )
          break;
        v20 = v37;
        v21 = v38;
        v22 = *(_QWORD *)(v15 + 16);
        v23 = off_8D08A30;
        ++*(_DWORD *)(v15 + 28);
        if ( v22 == 0 )
          break;
        v24 = *(int *)(v15 + 24);
        if ( (unsigned int)v24 >= *(_DWORD *)(v22 + 24) )
        {
          System_Collections_Generic_List_ValueTuple_float__object____AddWithResize(
            v15,
            v20,
            v21,
            *(_QWORD *)(*(_QWORD *)(v23[4] + 192LL) + 112LL));
        }
        else
        {
          v25 = v22 + 16 * v24;
          *(_DWORD *)(v15 + 24) = v24 + 1;
          *(_QWORD *)(v25 + 32) = v20;
          *(_QWORD *)(v25 + 40) = v21;
        }
        if ( (signed int)++v16 >= *(_DWORD *)(v3 + 24) )
          goto LABEL_36;
      }
LABEL_51:
      il2cpp_codegen_raise_null_reference_exception();
    }
LABEL_36:
    v26 = off_8CF1468;
    if ( *((_DWORD *)off_8CF1468 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CF1468);
      v26 = off_8CF1468;
    }
    v27 = *(_QWORD *)(v26[23] + 8LL);
    if ( v27 == 0 )
    {
      if ( *((_DWORD *)v26 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(v26);
        v26 = off_8CF1468;
      }
      v28 = *(_QWORD *)v26[23];
      v27 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8E30);
      System_Comparison_ValueTuple_float__object_____ctor(v27, v28, qword_8D450D0, 0);
      a1 = v35;
      *(_QWORD *)(*((_QWORD *)off_8CF1468 + 23) + 8LL) = v27;
    }
    if ( v15 != 0 )
    {
      System_Collections_Generic_List_ValueTuple_float__object____Sort(v15, v27, qword_8D08A38);
      if ( *(int *)(v15 + 24) >= 1 )
      {
        System_Collections_Generic_List_ValueTuple_float__object____get_Item(v15, 0, qword_8D08A48);
        if ( v36 == 0 )
          goto LABEL_51;
        v30 = v29;
        if ( (System_Collections_Generic_List_object___Contains(v36, v29, qword_8D0B4F8) & 1) == 0 )
        {
          v31 = *(_QWORD *)(v36 + 16);
          v32 = off_8D0B4E8;
          ++*(_DWORD *)(v36 + 28);
          if ( v31 == 0 )
            goto LABEL_51;
          v33 = *(int *)(v36 + 24);
          if ( (unsigned int)v33 >= *(_DWORD *)(v31 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v36,
              v30,
              *(_QWORD *)(*(_QWORD *)(v32[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v36 + 24) = v33 + 1;
            *(_QWORD *)(v31 + 8 * v33 + 32) = v30;
          }
        }
      }
      v12 = *(_QWORD *)(a1 + 376);
      ++v13;
      if ( v12 != 0 )
        continue;
    }
    goto LABEL_51;
  }
  return v36;
}
