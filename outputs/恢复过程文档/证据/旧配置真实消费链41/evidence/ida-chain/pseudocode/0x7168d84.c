void *stage41_GameFramework_ConfigRead____it_W(void *a0, void *a1)
{
  _QWORD *v3; // x0
  _QWORD *v4; // x0
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  _DWORD *v8; // x0
  __int64 v9; // x8
  __int64 v10; // x0
  __int64 v11; // x20
  void *ConfigDataForNewResWebgl; // x0
  __int64 v13; // x10
  void *v14; // x19
  int v15; // w20
  __int64 v16; // x0
  __int64 Helper__LoadAssetSync_object; // x0
  __int64 v19; // x20
  __int64 mainObject; // x0
  __int64 v21; // x9
  __int64 v22; // x0

  if ( (byte_900917C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D34C80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D37CB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEE250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D6DB78);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7B618);
    byte_900917C = 1;
  }
  v3 = off_8CE5BB8;
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v3 = off_8CE5BB8;
  }
  if ( *(_QWORD *)(v3[23] + 16LL) == 0 )
  {
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    if ( byte_900876D == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
      byte_900876D = 1;
    }
    v4 = off_8CE40C8;
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
      v4 = off_8CE40C8;
    }
    if ( *(_BYTE *)(v4[23] + 56LL) == 0 )
    {
      v5 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      if ( v5 == 0 )
        goto LABEL_53;
      v6 = v5;
      if ( qword_8D6DB78 != 0 )
      {
        v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(qword_8D6DB78, *(_QWORD *)(*(_QWORD *)v5 + 64LL));
        if ( v7 == 0 )
          goto LABEL_56;
      }
      if ( *(_DWORD *)(v6 + 24) == 0 )
      {
LABEL_55:
        v7 = ((__int64 (*)(void))unk_3C3D4D4)();
        goto LABEL_56;
      }
      *(_QWORD *)(v6 + 32) = qword_8D6DB78;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__Error(v6, 0);
    }
  }
  v8 = off_8CE5BB8;
  if ( *((_DWORD *)off_8CE5BB8 + 56) != 0 )
  {
    v9 = *((_QWORD *)off_8CE5BB8 + 23);
    if ( *(_BYTE *)(v9 + 32) != 0 )
      goto LABEL_22;
LABEL_40:
    v16 = *(_QWORD *)(v9 + 16);
    if ( v16 != 0 )
      return GameFramework_Resources_ResourcesInfo__LoadAsset_object_(v16, 0, a0, qword_8D37CB8);
    goto LABEL_53;
  }
  il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  v8 = off_8CE5BB8;
  v9 = *((_QWORD *)off_8CE5BB8 + 23);
  v15 = *(unsigned __int8 *)(v9 + 32);
  if ( *((_DWORD *)off_8CE5BB8 + 56) != 0 )
  {
    if ( *(_BYTE *)(v9 + 32) == 0 )
      goto LABEL_40;
  }
  else
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v8 = off_8CE5BB8;
    v9 = *((_QWORD *)off_8CE5BB8 + 23);
    if ( v15 == 0 )
      goto LABEL_40;
  }
LABEL_22:
  if ( *(_BYTE *)(v9 + 56) != 0 )
  {
    if ( v8[56] == 0 )
    {
      il2cpp_codegen_runtime_class_init(v8);
      v8 = off_8CE5BB8;
      v9 = *((_QWORD *)off_8CE5BB8 + 23);
    }
    if ( *(_QWORD *)(v9 + 24) != 0 )
      goto LABEL_33;
    v10 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    if ( v10 != 0 )
    {
      v11 = v10;
      if ( qword_8D7B618 == 0
        || (v7 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(
                   qword_8D7B618,
                   *(_QWORD *)(*(_QWORD *)v10 + 64LL))) != 0 )
      {
        if ( *(_DWORD *)(v11 + 24) != 0 )
        {
          *(_QWORD *)(v11 + 32) = qword_8D7B618;
          if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5250);
          GameFramework_CLog__Error(v11, 0);
          v8 = off_8CE5BB8;
LABEL_33:
          if ( v8[56] == 0 )
            il2cpp_codegen_runtime_class_init(v8);
          ConfigDataForNewResWebgl = (void *)GameFramework_ConfigRead__GetConfigDataForNewResWebgl(a0, a1);
          if ( ConfigDataForNewResWebgl == nullptr )
            return nullptr;
          v13 = *((unsigned __int8 *)off_8CEE250 + 304);
          if ( *(unsigned __int8 *)(*(_QWORD *)ConfigDataForNewResWebgl + 304LL) < (unsigned int)v13 )
            return nullptr;
          if ( *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)ConfigDataForNewResWebgl + 200LL) + 8 * v13 - 8) == off_8CEE250 )
            return ConfigDataForNewResWebgl;
          return nullptr;
        }
        goto LABEL_55;
      }
LABEL_56:
      v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v7);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v22, 0);
      JUMPOUT(0x7169104);
    }
LABEL_53:
    il2cpp_codegen_raise_null_reference_exception();
  }
  Helper__LoadAssetSync_object = GameFramework_NewResLoadHelper__LoadAssetSync_object_(a0, qword_8D34C80);
  if ( Helper__LoadAssetSync_object == 0 )
    goto LABEL_53;
  v19 = Helper__LoadAssetSync_object;
  mainObject = YooAsset_AssetOperationHandle__get_mainObject(Helper__LoadAssetSync_object, 0);
  v14 = (void *)mainObject;
  if ( mainObject != 0 )
  {
    v21 = *((unsigned __int8 *)off_8CEE250 + 304);
    if ( *(unsigned __int8 *)(*(_QWORD *)mainObject + 304LL) < (unsigned int)v21
      || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)mainObject + 200LL) + 8 * v21 - 8) != off_8CEE250 )
    {
      ((void (__fastcall *)(__int64))unk_3C3D868)(mainObject);
      goto LABEL_55;
    }
  }
  YooAsset_AssetOperationHandle__Release(v19, 0);
  return v14;
}
