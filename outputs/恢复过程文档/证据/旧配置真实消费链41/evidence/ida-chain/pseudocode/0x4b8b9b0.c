void stage41_GameFramework_ConfigRead__A____i_object_(void *a0, void *a1, void *a2, int a3, void *a4)
{
  void *v10; // x22
  __int64 v11; // x20
  __int64 v12; // x0
  __int64 v13; // x19
  __int64 v14; // x0
  __int64 bytes; // x22
  __int64 text; // x22
  __int64 v17; // x19
  __int64 v18; // x0
  __int64 v19; // x0
  __int64 v20; // x20
  __int64 v21; // x0
  _QWORD v22[2]; // [xsp+8h] [xbp-48h] BYREF
  int v23; // [xsp+18h] [xbp-38h]

  if ( *((_QWORD *)a4 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE5BC0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D89250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5C590);
    if ( *((_QWORD *)a4 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a4);
  }
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(a1, 0, 0) & 1) != 0 )
  {
    switch ( a3 )
    {
      case 2:
        if ( a1 == nullptr )
          goto LABEL_36;
        bytes = UnityEngine_TextAsset__get_bytes(a1, 0);
        if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5BB8);
        GameFramework_ConfigRead____f_I__object_(bytes, a0, a2, *(_QWORD *)(*((_QWORD *)a4 + 7) + 24LL));
        break;
      case 1:
        if ( a1 == nullptr )
          goto LABEL_36;
        text = UnityEngine_TextAsset__get_text(a1, 0);
        if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
          il2cpp_codegen_runtime_class_init(off_8CE5BB8);
        GameFramework_ConfigRead____it_g_object_(text, a0, a2, *(_QWORD *)(*((_QWORD *)a4 + 7) + 16LL));
        break;
      case 0:
        if ( a1 != nullptr )
        {
          v10 = (void *)UnityEngine_TextAsset__get_text(a1, 0);
          if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
            il2cpp_codegen_runtime_class_init(off_8CE5BB8);
          stage41_GameFramework_ConfigRead_________object_(v10, a0, a2, *(void **)(*((_QWORD *)a4 + 7) + 8LL));
          return;
        }
LABEL_36:
        il2cpp_codegen_raise_null_reference_exception();
      default:
        v17 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
        v23 = a3;
        v22[0] = qword_8CE5BC0;
        v22[1] = -1;
        v18 = System_Enum__ToString(v22, 0);
        v19 = sub_74FE7A4(qword_8D5C590, v18, 0);
        if ( v17 == 0 )
          goto LABEL_36;
        v20 = v19;
        if ( v19 == 0
          || (v14 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v19, *(_QWORD *)(*(_QWORD *)v17 + 64LL))) != 0 )
        {
          if ( *(_DWORD *)(v17 + 24) != 0 )
          {
            *(_QWORD *)(v17 + 32) = v20;
            if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
              il2cpp_codegen_runtime_class_init(off_8CE5250);
            GameFramework_CLog__Error(v17, 0);
            return;
          }
          goto LABEL_37;
        }
LABEL_38:
        v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v14);
        ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v21, 0);
        JUMPOUT(0x4B8BCEC);
    }
  }
  else
  {
    v11 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE3258, 1);
    v12 = sub_74FE7A4(qword_8D89250, a2, 0);
    if ( v11 == 0 )
      goto LABEL_36;
    v13 = v12;
    if ( v12 != 0 )
    {
      v14 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v12, *(_QWORD *)(*(_QWORD *)v11 + 64LL));
      if ( v14 == 0 )
        goto LABEL_38;
    }
    if ( *(_DWORD *)(v11 + 24) == 0 )
    {
LABEL_37:
      v14 = ((__int64 (*)(void))unk_3C3D4D4)();
      goto LABEL_38;
    }
    *(_QWORD *)(v11 + 32) = v13;
    if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE5250);
    GameFramework_CLog__Error(v11, 0);
  }
}
