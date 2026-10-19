void DbtSaveDataManagerBase_object__object___Log(void *self, int kind, void *msg, const MethodInfo *method)
{
  __int64 v7; // x0
  __int64 v8; // x8
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x19
  __int64 v12; // x0
  __int64 v13; // x0
  __int64 v14; // x8
  __int64 v15; // x20
  __int64 v16; // x0
  __int64 v17; // x19
  __int64 v18; // x0
  __int64 v19; // x8
  __int64 v20; // x20
  __int64 v21; // x0
  __int64 v22; // x19
  __int64 v23; // x0

  if ( (byte_9007B72 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4FB38);
    byte_9007B72 = 1;
  }
  if ( kind != 2 )
  {
    if ( kind != 1 )
    {
      if ( kind != 0 )
        return;
      v7 = ((__int64 (__fastcall *)(__int64, __int64, void *, const MethodInfo *))unk_3C3D320)(
             qword_8CE3258,
             1,
             msg,
             method);
      v8 = *((_QWORD *)self + 5);
      v9 = v7;
      v10 = sub_750A330(v8, qword_8D4FB38, msg, 0);
      if ( v9 != 0 )
      {
        v11 = v10;
        if ( v10 == 0
          || (v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v10, *(_QWORD *)(*(_QWORD *)v9 + 64LL))) != 0 )
        {
          if ( *(_DWORD *)(v9 + 24) != 0 )
          {
            *(_QWORD *)(v9 + 32) = v11;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Log(v9, 0);
            return;
          }
          goto LABEL_29;
        }
LABEL_30:
        v23 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v12);
        ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v23, 0);
        JUMPOUT(0x6AF47D0);
      }
LABEL_28:
      il2cpp_codegen_raise_null_reference_exception();
    }
    v18 = ((__int64 (__fastcall *)(__int64, __int64, void *, const MethodInfo *))unk_3C3D320)(
            qword_8CE3258,
            1,
            msg,
            method);
    v19 = *((_QWORD *)self + 5);
    v20 = v18;
    v21 = sub_750A330(v19, qword_8D4FB38, msg, 0);
    if ( v20 == 0 )
      goto LABEL_28;
    v22 = v21;
    if ( v21 != 0 )
    {
      v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v21, *(_QWORD *)(*(_QWORD *)v20 + 64LL));
      if ( v12 == 0 )
        goto LABEL_30;
    }
    if ( *(_DWORD *)(v20 + 24) != 0 )
    {
      *(_QWORD *)(v20 + 32) = v22;
      if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5250);
      GameFramework_CLog__Warning(v20, 0);
      return;
    }
LABEL_29:
    v12 = ((__int64 (*)(void))unk_3C3D4D4)();
    goto LABEL_30;
  }
  v13 = ((__int64 (__fastcall *)(__int64, __int64, void *, const MethodInfo *))unk_3C3D320)(
          qword_8CE3258,
          1,
          msg,
          method);
  v14 = *((_QWORD *)self + 5);
  v15 = v13;
  v16 = sub_750A330(v14, qword_8D4FB38, msg, 0);
  if ( v15 == 0 )
    goto LABEL_28;
  v17 = v16;
  if ( v16 != 0 )
  {
    v12 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v16, *(_QWORD *)(*(_QWORD *)v15 + 64LL));
    if ( v12 == 0 )
      goto LABEL_30;
  }
  if ( *(_DWORD *)(v15 + 24) == 0 )
    goto LABEL_29;
  *(_QWORD *)(v15 + 32) = v17;
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__Error(v15, 0);
}
