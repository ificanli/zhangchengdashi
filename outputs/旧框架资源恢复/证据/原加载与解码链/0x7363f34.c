unsigned __int8 AssetBundles_AssetBundleManager__LoadAssetBundleInternal(
        void *name,
        unsigned __int8 flag1,
        unsigned __int8 flag2,
        const MethodInfo *method)
{
  _QWORD *v6; // x0
  __int64 v7; // x0
  _QWORD *v8; // x0
  __int64 v9; // x21
  int v10; // w8
  __int64 v11; // x21
  __int64 v13; // x0
  _QWORD *v14; // x0
  __int64 v15; // x0
  char v16; // w0
  _QWORD *v17; // x8
  char v18; // w21
  __int64 v19; // x20
  int Item; // w0
  __int64 v21; // x0
  __int64 v22; // x20
  __int64 Module_object; // x0
  __int64 v24; // x8
  __int64 v25; // x10
  __int64 StreamingAssetsURL; // x0
  _BYTE **v27; // x0
  __int64 v28; // x21
  __int64 v29; // x0
  __int64 v30; // x22
  __int64 v31; // x0
  __int64 v32; // x21
  _QWORD *v33; // x0
  __int64 v34; // x22
  _BYTE **v35; // x0
  __int64 v36; // x22
  __int64 v37; // x0
  __int64 v38; // x23
  __int64 v39; // x22
  _QWORD *v40; // x0
  __int64 v41; // x0
  __int64 v42; // x0
  __int64 v43; // x0
  __int64 v44; // [xsp+8h] [xbp-48h] BYREF

  if ( (byte_900A6D3 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE5208);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF920);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF930);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA68);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEC30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEAB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF0A40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF0B20);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEFAE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7E298);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7D248);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D890B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89270);
    byte_900A6D3 = 1;
  }
  v6 = off_8CE4408;
  v44 = 0;
  if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE4408);
    v6 = off_8CE4408;
  }
  v7 = *(_QWORD *)(v6[23] + 32LL);
  if ( v7 == 0 )
    goto LABEL_78;
  System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, name, &v44, qword_8CFEC30);
  v8 = off_8CE4408;
  v9 = v44;
  v10 = *((_DWORD *)off_8CE4408 + 56);
  if ( v44 != 0 )
  {
    if ( v10 == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE4408);
    AssetBundles_AssetBundleManager__j_VCkY(v9);
    goto LABEL_10;
  }
  if ( v10 == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE4408);
    v8 = off_8CE4408;
  }
  v13 = *(_QWORD *)(v8[23] + 40LL);
  if ( v13 == 0 )
    goto LABEL_78;
  if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v13, name, qword_8CFF930) & 1) != 0 )
  {
    if ( (flag2 & 1) != 0 )
      goto LABEL_10;
    v14 = off_8CE4408;
    if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE4408);
      v14 = off_8CE4408;
    }
    v15 = *(_QWORD *)(v14[23] + 88LL);
    if ( v15 != 0 )
    {
      v16 = System_Collections_Generic_Dictionary_object__int___ContainsKey(v15, name, qword_8CFEA68);
      v17 = off_8CE4408;
      v18 = v16;
      if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE4408);
        v17 = off_8CE4408;
      }
      v19 = *(_QWORD *)(v17[23] + 88LL);
      if ( v19 != 0 )
      {
        if ( (v18 & 1) == 0 )
        {
          LOBYTE(v11) = 1;
          System_Collections_Generic_Dictionary_object__int___Add(v19, name, 1, qword_8CFEA58);
          return v11;
        }
        Item = System_Collections_Generic_Dictionary_object__int___get_Item(v19, name, qword_8CFEA98);
        System_Collections_Generic_Dictionary_object__int___set_Item(v19, name, (unsigned int)(Item + 1), qword_8CFEAB0);
LABEL_10:
        LOBYTE(v11) = 1;
        return v11;
      }
    }
LABEL_78:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4408);
  v21 = AssetBundles_AssetBundleManager___PsI_n(name);
  v11 = v21;
  if ( v21 == 0 )
    return v11;
  if ( (System_String__IsNullOrEmpty(*(_QWORD *)(v21 + 32), 0) & 1) != 0 )
  {
LABEL_77:
    LOBYTE(v11) = 0;
    return v11;
  }
  v22 = *(_QWORD *)(v11 + 32);
  if ( *(_BYTE *)(v11 + 52) != 0 )
  {
    if ( name == nullptr )
      goto LABEL_78;
    if ( (System_String__StartsWith(name, qword_8D7D248, 0) & 1) != 0 )
    {
      if ( *(_BYTE *)(v11 + 64) == 0 )
      {
        StreamingAssetsURL = qword_8D7E298;
LABEL_61:
        v22 = sub_74FE7A4(StreamingAssetsURL, v22, 0);
        goto LABEL_62;
      }
      if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE7B30);
      Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D180);
      if ( Module_object == 0 )
        goto LABEL_78;
      v24 = *(_QWORD *)(Module_object + 112);
      if ( v24 == 0
        || (v25 = *((unsigned __int8 *)off_8CF0A40 + 304),
            *(unsigned __int8 *)(*(_QWORD *)v24 + 304LL) < (unsigned int)v25)
        || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)v24 + 200LL) + 8 * v25 - 8) != off_8CF0A40 )
      {
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
        StreamingAssetsURL = GameFramework_AppSetting__get_StreamingAssetsURL(0);
        v22 = *(_QWORD *)(v11 + 24);
        goto LABEL_61;
      }
LABEL_62:
      v35 = (_BYTE **)off_8CE5250;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE5250);
        v35 = (_BYTE **)off_8CE5250;
      }
      if ( *v35[23] == 0 )
        goto LABEL_72;
      v36 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v37 = sub_74FE7A4(qword_8D89270, v22, 0);
      if ( v36 == 0 )
        goto LABEL_78;
      v38 = v37;
      if ( v37 == 0
        || (v31 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v37, *(_QWORD *)(*(_QWORD *)v36 + 64LL))) != 0 )
      {
        if ( *(_DWORD *)(v36 + 24) != 0 )
        {
          *(_QWORD *)(v36 + 32) = v38;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          sub_71FF550(0x1000000, v36, 0);
LABEL_72:
          v39 = *(_QWORD *)(v11 + 56);
          v32 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEFAE0);
          W________ctor(v32, v22, v39);
LABEL_73:
          v40 = off_8CE4408;
          if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
          {
            il2cpp_codegen_runtime_class_init(off_8CE4408);
            v40 = off_8CE4408;
          }
          v41 = *(_QWORD *)(v40[23] + 40LL);
          if ( v41 == 0 )
            goto LABEL_78;
          System_Collections_Generic_Dictionary_object__object___Add(v41, name, v32, qword_8CFF920);
          goto LABEL_77;
        }
        goto LABEL_79;
      }
LABEL_80:
      v42 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v31);
      v43 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v42, 0);
      return AssetBundles_AssetBundleManager___PsI_n(v43);
    }
  }
  v27 = (_BYTE **)off_8CE5250;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5250);
    v27 = (_BYTE **)off_8CE5250;
  }
  if ( *v27[23] != 0 )
  {
    v28 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v29 = sub_74FE7A4(qword_8D890B0, v22, 0);
    if ( v28 == 0 )
      goto LABEL_78;
    v30 = v29;
    if ( v29 != 0 )
    {
      v31 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v29, *(_QWORD *)(*(_QWORD *)v28 + 64LL));
      if ( v31 == 0 )
        goto LABEL_80;
    }
    if ( *(_DWORD *)(v28 + 24) == 0 )
    {
LABEL_79:
      v31 = ((__int64 (*)(void))unk_3C3D4D4)();
      goto LABEL_80;
    }
    *(_QWORD *)(v28 + 32) = v30;
    if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5250);
    sub_71FF550(0x1000000, v28, 0);
  }
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( (GameFramework_AppSetting__get_IsDYResMode_Web(0) & 1) != 0 )
  {
    v32 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF0B20);
    ________ctor(v32, v22);
  }
  else
  {
    v33 = off_8CE4408;
    if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE4408);
      v33 = off_8CE4408;
    }
    v34 = *(_QWORD *)(v33[23] + 80LL);
    v32 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE5208);
    System_Object___ctor(v32, 0);
    *(_QWORD *)(v32 + 24) = UnityEngine_AssetBundle__LoadFromFileAsync(v22, 0, v34, 0);
  }
  goto LABEL_73;
}
