void *tf_w_k__GetAssetBundleInfo(void *self, void *name, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 ABStreamingAssetsPath; // x0
  __int64 v7; // x0
  __int64 v8; // x9
  __int64 v9; // x21
  unsigned int v10; // w22
  unsigned int v11; // w23
  __int64 v12; // x24
  __int64 v13; // x25
  __int64 v14; // x26
  void *v15; // x20
  __int64 v16; // x20
  __int64 v17; // x0
  __int64 v18; // x21
  __int64 v19; // x0
  __int64 v20; // x21
  __int64 v22; // x0
  __int64 v23; // [xsp+18h] [xbp-58h] BYREF

  if ( (byte_900A098 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE5110);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D68938);
    byte_900A098 = 1;
  }
  v23 = 0;
  v5 = *((_QWORD *)self + 2);
  if ( v5 != 0 && (GameFramework_Resources_PatchManifest__TryGetValue(v5, name, &v23) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    ABStreamingAssetsPath = GameFramework_AppSetting__get_ABStreamingAssetsPath(0);
    if ( v23 != 0 )
    {
      v7 = sub_74FE7A4(ABStreamingAssetsPath, *(_QWORD *)(v23 + 24), 0);
      if ( v23 != 0 )
      {
        v8 = *((_QWORD *)self + 2);
        if ( v8 != 0 )
        {
          v9 = v7;
          v10 = *(_DWORD *)(v23 + 48);
          v11 = *(unsigned __int8 *)(v8 + 16);
          v12 = *(_QWORD *)(v23 + 24);
          v13 = *(_QWORD *)(v8 + 24);
          v14 = **((_QWORD **)off_8CEDAE8 + 23);
          v15 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE5110);
          GameFramework_Resources_BundleAssetInfo___ctor(v15, name, v9, v14, v10, v11, v12, v13, 1);
          return v15;
        }
      }
    }
LABEL_19:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v16 = ((__int64 (__fastcall *)(__int64, __int64, const MethodInfo *))unk_3C3D320)(qword_8CE3258, 1, method);
  v17 = sub_74FE7A4(qword_8D68938, name, 0);
  if ( v16 == 0 )
    goto LABEL_19;
  v18 = v17;
  if ( v17 != 0 )
  {
    v19 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v17, *(_QWORD *)(*(_QWORD *)v16 + 64LL));
    if ( v19 == 0 )
    {
LABEL_21:
      v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v19);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v22, 0);
      JUMPOUT(0x72EF4C0);
    }
  }
  if ( *(_DWORD *)(v16 + 24) == 0 )
  {
    v19 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_21;
  }
  *(_QWORD *)(v16 + 32) = v18;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Warning(v16, 0);
  v20 = **((_QWORD **)off_8CEDAE8 + 23);
  v15 = (void *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE5110);
  sub_72EB4AC(v15, name, v20);
  return v15;
}
