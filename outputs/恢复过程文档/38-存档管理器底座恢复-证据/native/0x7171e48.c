void GameFramework_DataManagerBase__SaveLocalData(void *self, void *data, const MethodInfo *method)
{
  void *v3; // x19
  __int64 v5; // x21
  __int64 v6; // x22
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x8
  __int64 v10; // x0
  __int64 v11; // x21
  __int64 v12; // x19
  __int64 v13; // x0
  __int64 v14; // x0
  __int64 v15; // x20
  __int64 v16; // x0
  __int64 v17; // x21
  __int64 v18; // x0
  __int64 v19; // x8
  _QWORD *v20; // x8
  int v21; // w21
  int v22; // w21
  _QWORD *v23; // x0
  __int64 Instance; // x21
  __int64 v25; // x0
  __int64 v26; // x21
  __int64 v27; // x0
  __int64 v28; // x1
  __int64 v29; // x0
  __int64 v30; // x0
  __int64 v31; // x0
  __int64 v32; // x1

  v3 = data;
  if ( (byte_900919A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF230);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D791F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D783B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86250);
    byte_900919A = 1;
  }
  if ( *((_BYTE *)self + 32) == 0
    && (GameFramework_DataManagerBase____F_dB(self, (const MethodInfo *)data) & 1) != 0
    && *((_BYTE *)self + 32) == 0 )
  {
    v5 = qword_8D86250;
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(v5, 0);
    v6 = **((_QWORD **)off_8CECCD8 + 23);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    if ( (UnityEngine_Object__op_Inequality(v6, 0, 0) & 1) != 0 )
    {
      v7 = **((_QWORD **)off_8CECCD8 + 23);
      if ( v7 == 0 )
        goto LABEL_60;
      DBTSDK_SDKToolManager__ShowToast(v7, v5, 0);
    }
  }
  v8 = **((_QWORD **)off_8CE40D0 + 23);
  if ( v8 == 0 )
LABEL_60:
    il2cpp_codegen_raise_null_reference_exception();
  v9 = *(_QWORD *)(v8 + 56);
  if ( v9 == 0 || *(_BYTE *)(v9 + 16) == 0 )
  {
    v10 = GameFramework_MD5Utils__MD5(v3, 0, method);
    if ( *((_QWORD *)self + 3) == 0 )
      goto LABEL_60;
    v11 = v10;
    if ( (System_String__Equals(*((_QWORD *)self + 3), v10, 0) & 1) != 0 )
    {
      v12 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
      v13 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(
              self,
              *(_QWORD *)(*(_QWORD *)self + 384LL));
      v14 = sub_750A330(qword_8D783B0, v13, qword_8D791F0, 0);
      if ( v12 != 0 )
      {
        v15 = v14;
        if ( v14 == 0
          || (v16 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v14, *(_QWORD *)(*(_QWORD *)v12 + 64LL))) != 0 )
        {
          if ( *(_DWORD *)(v12 + 24) != 0 )
          {
            *(_QWORD *)(v12 + 32) = v15;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Log(v12, 0);
            return;
          }
          v16 = ((__int64 (*)(void))unk_3C3D4D4)();
        }
        v30 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v16);
        v31 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v30, 0);
        GameFramework_DataManagerBase__T__LGZ(v31, v32);
        return;
      }
      goto LABEL_60;
    }
    *((_QWORD *)self + 3) = v11;
  }
  if ( *((_BYTE *)self + 18) != 0 )
  {
    v17 = (*(__int64 (__fastcall **)(void *, _QWORD, const MethodInfo *))(*(_QWORD *)self + 376LL))(
            self,
            *(_QWORD *)(*(_QWORD *)self + 384LL),
            method);
    if ( *((_DWORD *)off_8CEF230 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEF230);
    v3 = (void *)GameFramework_Utils__BrotliCompressData(v17, v3, 0);
  }
  v18 = **((_QWORD **)off_8CE40D0 + 23);
  if ( v18 == 0 )
    goto LABEL_60;
  v19 = *(_QWORD *)(v18 + 56);
  if ( v19 != 0 && *(_BYTE *)(v19 + 16) != 0 )
  {
    if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE8C58);
    if ( byte_90092BD == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
      byte_90092BD = 1;
    }
    v20 = off_8CE8C58;
    if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE8C58);
      v20 = off_8CE8C58;
    }
    if ( **((_QWORD **)off_8CE40D0 + 23) == 0 )
      goto LABEL_60;
    v21 = *(unsigned __int8 *)(v20[23] + 4LL);
  }
  else
  {
    v21 = 0;
  }
  if ( (v21 | DBTSDK_AppUserManager__get_IsUseServer() & 1) != 0 )
    v22 = *((unsigned __int8 *)self + 17);
  else
    v22 = 0;
  if ( *((_BYTE *)self + 16) != 0 )
  {
    v23 = off_8CE6178;
    if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE6178);
      v23 = off_8CE6178;
    }
    if ( *(_BYTE *)(v23[23] + 9LL) != 0 )
      GameFramework_DataManagerBase__T__LGZ(self, v3);
  }
  if ( v22 != 0 )
  {
    if ( *((_DWORD *)off_8CE7B18 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE7B18);
    Instance = GameFramework_GameData_GameDataVersionMgr__get_Instance(0);
    v25 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(
            self,
            *(_QWORD *)(*(_QWORD *)self + 384LL));
    if ( Instance != 0 )
    {
      GameFramework_GameData_GameDataVersionMgr____H__w(Instance, v25, 0);
      if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6178);
      v26 = GameFramework_DataManagerPool__get_Instance();
      v27 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(
              self,
              *(_QWORD *)(*(_QWORD *)self + 384LL));
      if ( v26 != 0 )
      {
        v28 = v27;
        v29 = *(_QWORD *)(v26 + 24);
        if ( v29 != 0 )
        {
          _____d____X_R_g(v29, v28, v3, 0);
          return;
        }
      }
    }
    goto LABEL_60;
  }
}
