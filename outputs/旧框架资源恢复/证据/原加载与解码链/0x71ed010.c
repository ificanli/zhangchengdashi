unsigned __int8 GameFramework_VersionMondule__LoadABFileStreaming_d__11__MoveNext(void *self, const MethodInfo *method)
{
  __int64 *v2; // x22
  __int64 *v3; // x23
  int v5; // w8
  _QWORD *v6; // x0
  __int64 v7; // x0
  __int128 v8; // kr00_16
  __int64 v9; // x20
  __int64 v10; // x0
  unsigned int v11; // w8
  __int64 v12; // x0
  __int64 v13; // x21
  __int64 v14; // x0
  __int64 v15; // x20
  void *v16; // x0
  __int64 v17; // x8
  __int64 error; // x0
  __int64 v19; // x0
  __int64 v20; // x20
  __int64 v21; // x0
  __int64 StreamingAssetsURL; // x0
  __int64 v23; // x20
  _QWORD *v24; // x0
  __int64 v25; // x21
  __int64 v26; // x0
  __int64 v27; // x20
  __int64 v28; // x0
  __int64 v29; // x21
  __int64 v30; // x0
  __int64 v31; // x1
  _QWORD *v32; // x0
  __int64 v33; // x9
  __int64 v34; // x0
  int v35; // w19
  __int64 data; // x19
  __int64 Instance; // x0
  __int64 v38; // x0
  _QWORD *v39; // x0
  __int64 v40; // x0
  _QWORD *v41; // x8
  __int64 v42; // x20
  __int64 v43; // x0
  __int64 v44; // x21
  __int64 v45; // x21
  __int64 v46; // x0
  __int64 v47; // x0
  __int64 v48; // x20
  __int64 v49; // x21
  __int64 v50; // x0
  __int64 v51; // x0
  __int64 v52; // x21
  __int64 v53; // x21
  _QWORD **v54; // x0
  __int64 v55; // x19
  __int64 MineGameName; // x0
  void *v57; // x0
  _QWORD **v58; // x0
  __int64 v59; // x19
  __int64 v60; // x0
  __int64 v61; // x0
  __int64 v62; // x0
  __int64 v63; // x0
  __int64 v64; // x20
  int v65; // w1
  __int64 v66; // x21
  __int64 v67; // x0
  _QWORD v69[5]; // [xsp+0h] [xbp-C0h] BYREF
  __int64 v70; // [xsp+28h] [xbp-98h] BYREF
  _QWORD v71[6]; // [xsp+30h] [xbp-90h] BYREF

  if ( (byte_90096EE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE970);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE978);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF300);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF318);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE6B50);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04F58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D04F60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D04F68);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D078B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D078B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3520);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF480);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D55610);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D55618);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5EBF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78F10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86EE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D70370);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5EBE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86708);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D55620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D78EA0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7E790);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF0910);
    byte_90096EE = 1;
  }
  memset(v71, 0, 40);
  v70 = 0;
  v5 = *((_DWORD *)self + 4);
  if ( v5 == 1 )
  {
    v15 = *((_QWORD *)self + 4);
    v14 = *((_QWORD *)self + 5);
    *((_DWORD *)self + 4) = -1;
    if ( v14 == 0 )
      goto LABEL_124;
    if ( UnityEngine_Networking_UnityWebRequest__get_error(v14, 0) != 0 )
    {
      v16 = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v17 = *((_QWORD *)self + 5);
      if ( v17 == 0 )
        goto LABEL_124;
      self = v16;
      error = UnityEngine_Networking_UnityWebRequest__get_error(v17, 0);
      v19 = sub_74FE7A4(qword_8D86708, error, 0);
      if ( self == nullptr )
        goto LABEL_124;
      v20 = v19;
      if ( v19 != 0 )
      {
        v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v19, *(_QWORD *)(*(_QWORD *)self + 64LL));
        if ( v21 == 0 )
          goto LABEL_126;
      }
      if ( *((_DWORD *)self + 6) == 0 )
        goto LABEL_125;
      *((_QWORD *)self + 4) = v20;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__Error(self, 0);
    }
    else
    {
      v2 = (__int64 *)&off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      if ( byte_9008B16 == 0 )
      {
        il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
        byte_9008B16 = 1;
      }
      v32 = off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v32 = off_8CE40C8;
      }
      if ( *((_QWORD *)self + 5) == 0 )
        goto LABEL_124;
      v33 = v32[23];
      v34 = *((_QWORD *)self + 5);
      v35 = *(unsigned __int8 *)(v33 + 88);
      if ( UnityEngine_Networking_UnityWebRequest__get_downloadHandler(v34, 0) == 0 )
        goto LABEL_124;
      if ( v35 != 0 )
      {
        data = UnityEngine_Networking_DownloadHandler__get_data();
        Instance = GameFramework_Tools_FileManager__get_Instance(0);
        if ( Instance == 0 )
          goto LABEL_124;
        self = (void *)GameFramework_Tools_FileManager__QnXgString(Instance, data, 0);
        v38 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v38 == 0 )
          goto LABEL_124;
        v3 = &qword_8D55610;
      }
      else
      {
        self = (void *)UnityEngine_Networking_DownloadHandler__get_text();
        v38 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v38 == 0 )
          goto LABEL_124;
        v3 = &qword_8D55618;
      }
      v52 = v38;
      if ( *v3 != 0 )
      {
        v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(*v3, *(_QWORD *)(*(_QWORD *)v38 + 64LL));
        if ( v21 == 0 )
          goto LABEL_126;
      }
      if ( *(_DWORD *)(v52 + 24) == 0 )
        goto LABEL_125;
      *(_QWORD *)(v52 + 32) = *v3;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__ReleaseLog(v52, 0);
      v53 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF0910);
      tf_w_k___ctor(v53, 0);
      if ( v53 == 0 )
        goto LABEL_124;
      tf_w_k__ReadStreamingPatchManifest(v53, self, 0);
      if ( v15 == 0 )
        goto LABEL_124;
      *(_QWORD *)(v15 + 48) = v53;
      v3 = (__int64 *)&off_8CEF480;
      v54 = (_QWORD **)off_8CEF480;
      if ( *((_DWORD *)off_8CEF480 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CEF480);
        v54 = (_QWORD **)off_8CEF480;
      }
      v55 = *v54[23];
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      MineGameName = GameFramework_AppSetting__get_MineGameName(0);
      if ( v55 == 0 )
LABEL_124:
        il2cpp_codegen_raise_null_reference_exception();
      if ( (System_Collections_Generic_Dictionary_object__object___ContainsKey(v55, MineGameName, qword_8CFE978) & 1) != 0 )
      {
        v57 = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        if ( v57 == nullptr )
          goto LABEL_124;
        self = v57;
        if ( qword_8D86EE8 != 0 )
        {
          v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                  qword_8D86EE8,
                  *(_QWORD *)(*(_QWORD *)v57 + 64LL));
          if ( v21 == 0 )
            goto LABEL_126;
        }
        if ( *((_DWORD *)self + 6) == 0 )
          goto LABEL_125;
        *((_QWORD *)self + 4) = qword_8D86EE8;
        if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5250);
        GameFramework_CLog__Warning(self, 0);
      }
      else
      {
        v58 = (_QWORD **)off_8CEF480;
        if ( *((_DWORD *)off_8CEF480 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CEF480);
          v58 = (_QWORD **)off_8CEF480;
        }
        v59 = *v58[23];
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v60 = GameFramework_AppSetting__get_MineGameName(0);
        if ( v59 == 0 )
          goto LABEL_124;
        System_Collections_Generic_Dictionary_object__object___Add(v59, v60, v53, qword_8CFE970);
      }
      GameFramework_VersionMondule__SetAssetBundleURL(v15);
    }
LABEL_113:
    LOBYTE(v51) = 0;
    return v51;
  }
  if ( v5 != 0 )
    goto LABEL_113;
  *((_DWORD *)self + 4) = -1;
  v6 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v6 = off_8CE40C8;
  }
  v7 = *(_QWORD *)(v6[23] + 32LL);
  if ( v7 == 0 )
    goto LABEL_124;
  System_Collections_Generic_Dictionary_object__object___GetEnumerator(v69, v7, qword_8CFF300);
  v2 = &qword_8CE3258;
  qmemcpy(v71, v69, 40);
  v3 = (__int64 *)&off_8CE5250;
  while ( (System_Collections_Generic_Dictionary_Enumerator_object__object___MoveNext(v71, qword_8D04F60) & 1) != 0 )
  {
    v8 = *(_OWORD *)&v71[2];
    v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v10 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3520, 5);
    if ( v10 == 0 )
      goto LABEL_119;
    v11 = *(_DWORD *)(v10 + 24);
    if ( v11 == 0 )
    {
      v12 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_121:
      v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v12);
LABEL_122:
      v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4D4)(v10);
LABEL_123:
      v61 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v12);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v61, 0);
      goto LABEL_124;
    }
    *(_QWORD *)(v10 + 32) = qword_8D7E790;
    if ( v11 == 1 )
    {
      v10 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_118:
      ((void (__fastcall *)(__int64))unk_3C3D4D4)(v10);
LABEL_119:
      il2cpp_codegen_raise_null_reference_exception();
    }
    *(_QWORD *)(v10 + 40) = v8;
    if ( v11 <= 2 )
    {
      ((void (*)(void))unk_3C3D4D4)();
LABEL_116:
      il2cpp_codegen_raise_null_reference_exception();
    }
    *(_QWORD *)(v10 + 48) = qword_8D78F10;
    if ( v11 == 3 )
      goto LABEL_118;
    *(_QWORD *)(v10 + 56) = *((_QWORD *)&v8 + 1);
    if ( v11 <= 4 )
      goto LABEL_122;
    *(_QWORD *)(v10 + 64) = qword_8D78EA0;
    v12 = System_String__Concat();
    if ( v9 == 0 )
      goto LABEL_116;
    v13 = v12;
    if ( v12 != 0 )
    {
      v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v12, *(_QWORD *)(*(_QWORD *)v9 + 64LL));
      if ( v12 == 0 )
        goto LABEL_123;
    }
    if ( *(_DWORD *)(v9 + 24) == 0 )
      goto LABEL_121;
    *(_QWORD *)(v9 + 32) = v13;
    if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5250);
    GameFramework_CLog__Log(v9, 0);
  }
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v71, qword_8D04F58);
  do
  {
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    StreamingAssetsURL = GameFramework_AppSetting__get_StreamingAssetsURL(0);
    v23 = sub_74FE7A4(StreamingAssetsURL, qword_8D55620, 0);
    if ( (GameFramework_AppSetting__get_IsDYResMode_Web(0) & 1) != 0 )
    {
      v24 = off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v24 = off_8CE40C8;
      }
      v25 = *(_QWORD *)(v24[23] + 32LL);
      v26 = GameFramework_AppSetting__get_MineGameName(0);
      if ( v25 == 0 )
        goto LABEL_124;
      if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v25, v26, &v70, qword_8CFF318) & 1) != 0 )
      {
        v27 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(*v2, 1);
        v28 = sub_74FE7A4(qword_8D5EBF0, v70, 0);
        if ( v27 == 0 )
          goto LABEL_124;
        v29 = v28;
        if ( v28 != 0 )
        {
          v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v28, *(_QWORD *)(*(_QWORD *)v27 + 64LL));
          if ( v21 == 0 )
            goto LABEL_126;
        }
        if ( *(_DWORD *)(v27 + 24) == 0 )
          goto LABEL_125;
        *(_QWORD *)(v27 + 32) = v29;
        if ( *(_DWORD *)(*v3 + 224) == 0 )
          il2cpp_codegen_runtime_class_init((void *)*v3);
        GameFramework_CLog__Log(v27, 0);
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v30 = GameFramework_AppSetting__get_StreamingAssetsURL(0);
        v31 = v70;
LABEL_74:
        v23 = sub_74FE7A4(v30, v31, 0);
        goto LABEL_75;
      }
      v39 = off_8CE40C8;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
        v39 = off_8CE40C8;
      }
      if ( (System_String__IsNullOrEmpty(*(_QWORD *)(v39[23] + 24LL), 0) & 1) == 0 )
      {
        v40 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(*v2, 1);
        v41 = off_8CE40C8;
        v42 = v40;
        if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        {
          il2cpp_codegen_runtime_class_init(off_8CE40C8);
          v41 = off_8CE40C8;
        }
        v43 = sub_74FE7A4(qword_8D5EBE8, *(_QWORD *)(v41[23] + 24LL), 0);
        if ( v42 == 0 )
          goto LABEL_124;
        v44 = v43;
        if ( v43 != 0 )
        {
          v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v43, *(_QWORD *)(*(_QWORD *)v42 + 64LL));
          if ( v21 == 0 )
            goto LABEL_126;
        }
        if ( *(_DWORD *)(v42 + 24) == 0 )
          goto LABEL_125;
        *(_QWORD *)(v42 + 32) = v44;
        if ( *(_DWORD *)(*v3 + 224) == 0 )
          il2cpp_codegen_runtime_class_init((void *)*v3);
        GameFramework_CLog__Log(v42, 0);
        v30 = GameFramework_AppSetting__get_StreamingAssetsURL(0);
        v31 = *(_QWORD *)(*((_QWORD *)off_8CE40C8 + 23) + 24LL);
        goto LABEL_74;
      }
    }
LABEL_75:
    v45 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(*v2, 1);
    v46 = sub_74FE7A4(qword_8D70370, v23, 0);
    if ( v45 == 0 )
      goto LABEL_124;
    v2 = (__int64 *)v46;
    if ( v46 == 0
      || (v21 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v46, *(_QWORD *)(*(_QWORD *)v45 + 64LL))) != 0 )
    {
      if ( *(_DWORD *)(v45 + 24) != 0 )
      {
        *(_QWORD *)(v45 + 32) = v2;
        if ( *(_DWORD *)(*v3 + 224) == 0 )
          il2cpp_codegen_runtime_class_init((void *)*v3);
        GameFramework_CLog__ReleaseLog(v45, 0);
        v47 = UnityEngine_Networking_UnityWebRequest__Get(v23, 0);
        *((_QWORD *)self + 5) = v47;
        v48 = v47;
        v49 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE6B50);
        UnityEngine_Networking_DownloadHandlerBuffer___ctor(v49, 0);
        if ( v48 != 0 )
        {
          UnityEngine_Networking_UnityWebRequest__set_downloadHandler(v48, v49, 0);
          v50 = *((_QWORD *)self + 5);
          if ( v50 != 0 )
          {
            *((_QWORD *)self + 3) = UnityEngine_Networking_UnityWebRequest__SendWebRequest(v50, 0);
            *((_DWORD *)self + 4) = 1;
            LOBYTE(v51) = 1;
            return v51;
          }
        }
        goto LABEL_124;
      }
LABEL_125:
      v21 = ((__int64 (*)(void))unk_3C3D4D4)();
    }
LABEL_126:
    v62 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v21);
    v63 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v62, 0);
    v64 = v63;
    if ( v65 != 1 )
      goto LABEL_129;
    v66 = *(_QWORD *)((__int64 (__fastcall *)(__int64))__cxa_begin_catch)(v63);
    ((void (*)(void))__cxa_end_catch)();
    System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v71, qword_8D04F58);
  }
  while ( v66 == 0 );
  ((void (__fastcall *)(__int64))unk_3C38CF8)(v66);
LABEL_129:
  System_Collections_Generic_Dictionary_Enumerator_object__object___Dispose(v71, qword_8D04F58);
  ((void (__fastcall *)(__int64))unk_3CE73C4)(v64);
  v67 = ((__int64 (__fastcall *)(_QWORD))unk_3C38CF8)(0);
  return *(_QWORD *)(((__int64 (__fastcall *)(__int64))unk_35BC500)(v67) + 24);
}
