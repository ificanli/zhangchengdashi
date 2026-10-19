__int64 __fastcall GameFramework_AssetbundleModule__LoadManifest_d__6__MoveNext(__int64 a1)
{
  __int64 v2; // x21
  __int64 MineGameName; // x20
  __int64 Manifest; // x0
  __int64 v5; // x20
  __int64 Instance; // x0
  __int64 started; // x0
  unsigned int v8; // w20
  __int64 v9; // x0
  __int64 v10; // x19
  __int64 v11; // x0
  __int64 v12; // x8
  __int64 v14; // x19
  __int64 v15; // x0
  __int64 v16; // x0
  __int64 v17; // x20
  __int64 v18; // x0
  int v19; // [xsp+8h] [xbp-28h] BYREF
  int v20; // [xsp+Ch] [xbp-24h] BYREF

  if ( (byte_9008F50 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56BC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87EB0);
    byte_9008F50 = 1;
  }
  v2 = *(_QWORD *)(a1 + 32);
  switch ( *(_DWORD *)(a1 + 16) )
  {
    case 0:
      *(_DWORD *)(a1 + 16) = -1;
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      MineGameName = GameFramework_AppSetting__get_MineGameName();
      if ( *((_DWORD *)off_8CE4408 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE4408);
      Manifest = AssetBundles_AssetBundleManager__LoadManifest(MineGameName, 0);
      if ( Manifest != 0 )
      {
        v5 = Manifest;
        Instance = UpdateManager__get_Instance();
        if ( Instance != 0 )
        {
          started = UnityEngine_MonoBehaviour__StartCoroutine(Instance, v5, 0);
          v8 = 1;
          *(_QWORD *)(a1 + 24) = started;
          *(_DWORD *)(a1 + 16) = 1;
          return v8;
        }
LABEL_36:
        il2cpp_codegen_raise_null_reference_exception();
      }
      v14 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v15 = GameFramework_AppSetting__get_MineGameName();
      v16 = sub_74FE7A4(v15, qword_8D87EB0, 0);
      if ( v14 == 0 )
        goto LABEL_36;
      v17 = v16;
      if ( v16 != 0 )
      {
        v11 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
        if ( v11 == 0 )
          goto LABEL_38;
      }
      if ( *(_DWORD *)(v14 + 24) == 0 )
      {
LABEL_37:
        v11 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_38:
        v18 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v11);
        ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v18, 0);
        JUMPOUT(0x713C778);
      }
      *(_QWORD *)(v14 + 32) = v17;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__R__u_e(v14, 0);
      if ( v2 == 0 )
        goto LABEL_36;
      v12 = *(_QWORD *)(v2 + 24);
      *(_BYTE *)(v2 + 16) = 1;
      if ( v12 != 0 )
LABEL_22:
        (*(void (__fastcall **)(_QWORD, _QWORD))(v12 + 24))(*(_QWORD *)(v12 + 64), *(_QWORD *)(v12 + 40));
      return 0;
    case 1:
      *(_DWORD *)(a1 + 16) = -1;
      if ( v2 == 0 )
        goto LABEL_36;
      v8 = 1;
      *(_BYTE *)(v2 + 16) = 1;
      v20 = 0;
      *(_QWORD *)(a1 + 24) = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v20);
      *(_DWORD *)(a1 + 16) = 2;
      return v8;
    case 2:
      *(_DWORD *)(a1 + 16) = -1;
      v19 = 0;
      *(_QWORD *)(a1 + 24) = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v19);
      *(_DWORD *)(a1 + 16) = 3;
      return 1;
    case 3:
      *(_DWORD *)(a1 + 16) = -1;
      v9 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      if ( v9 == 0 )
        goto LABEL_36;
      v10 = v9;
      if ( qword_8D56BC8 != 0 )
      {
        v11 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D56BC8, *(_QWORD *)(*(_QWORD *)v9 + 64LL));
        if ( v11 == 0 )
          goto LABEL_38;
      }
      if ( *(_DWORD *)(v10 + 24) == 0 )
        goto LABEL_37;
      *(_QWORD *)(v10 + 32) = qword_8D56BC8;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__R__u_e(v10, 0);
      if ( v2 == 0 )
        goto LABEL_36;
      v12 = *(_QWORD *)(v2 + 24);
      if ( v12 != 0 )
        goto LABEL_22;
      return 0;
    default:
      return 0;
  }
}
