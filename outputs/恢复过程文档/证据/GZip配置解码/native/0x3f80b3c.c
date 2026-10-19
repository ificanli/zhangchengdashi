void *ToolModule_GZipTool__DecompressCore(void *input, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x21
  __int64 v5; // x22
  _QWORD *v6; // x23
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x0
  __int64 v10; // x0
  __int64 v11; // x0
  __int64 v12; // x1
  int v13; // w0
  void *v14; // x23
  __int64 v15; // x8
  __int64 v16; // x9
  int *v17; // x10
  __int64 v18; // x0
  __int64 v19; // x8
  __int64 v20; // x9
  int *v21; // x10
  __int64 v22; // x0
  __int64 v23; // x8
  __int64 v24; // x9
  int *v25; // x10
  __int64 v26; // x0
  _QWORD v28[2]; // [xsp+8h] [xbp-58h] BYREF
  __int64 v29; // [xsp+18h] [xbp-48h] BYREF

  if ( (byte_8FFE416 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF7848);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD8980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7AE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D32258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEA878);
    byte_8FFE416 = 1;
  }
  v29 = 0;
  if ( (ToolModule_ListExtend__IsNullOrEmpty_byte_(input, (const MethodInfo *)qword_8D32258) & 1) != 0 )
    return input;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEA878);
  sub_75CF1DC(v3, input, 0);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AE0);
  sub_7D18440(v4, v3, 0, 0);
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEA878);
  System_IO_MemoryStream___ctor(v5, 0);
  if ( *((_DWORD *)off_8CD8980 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CD8980);
  v6 = off_8CF7848;
  v7 = *((_QWORD *)off_8CF7848 + 4);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  v8 = *(_QWORD *)(*(_QWORD *)(v7 + 192) + 8LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v8 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v8);
  v9 = v6[4];
  if ( (*(_BYTE *)(v9 + 309) & 1) == 0 )
    v9 = ((__int64 (*)(void))unk_3C503A0)();
  v10 = *(_QWORD *)(*(_QWORD *)(v9 + 192) + 8LL);
  if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
    v10 = ((__int64 (*)(void))unk_3C503A0)();
  v11 = **(_QWORD **)(v10 + 184);
  if ( v11 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v12 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)v11 + 376LL))(
          v11,
          81920,
          *(_QWORD *)(*(_QWORD *)v11 + 384LL));
  v28[0] = 0;
  v28[1] = &v29;
  v29 = v12;
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  while ( 1 )
  {
    v13 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD, __int64, _QWORD))(*(_QWORD *)v4 + 856LL))(
            v4,
            v12,
            0,
            81920,
            *(_QWORD *)(*(_QWORD *)v4 + 864LL));
    if ( v13 <= 0 )
      break;
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, __int64, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v5 + 904LL))(
      v5,
      v29,
      0,
      (unsigned int)v13,
      *(_QWORD *)(*(_QWORD *)v5 + 912LL));
    v12 = v29;
  }
  ((void (__fastcall *)(_QWORD *))unk_35C1130)(v28);
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v14 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v5 + 1016LL))(
                  v5,
                  *(_QWORD *)(*(_QWORD *)v5 + 1024LL));
  v15 = *(_QWORD *)v5;
  v16 = *(unsigned __int16 *)(*(_QWORD *)v5 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v5 + 302LL) != 0 )
  {
    v17 = (int *)(*(_QWORD *)(v15 + 176) + 8LL);
    while ( *((_QWORD *)v17 - 1) != qword_8CE8998 )
    {
      --v16;
      v17 += 4;
      if ( v16 == 0 )
        goto LABEL_26;
    }
    v18 = v15 + 16LL * *v17 + 312;
  }
  else
  {
LABEL_26:
    v18 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v5, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v18)(v5, *(_QWORD *)(v18 + 8));
  v19 = *(_QWORD *)v4;
  v20 = *(unsigned __int16 *)(*(_QWORD *)v4 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v4 + 302LL) != 0 )
  {
    v21 = (int *)(*(_QWORD *)(v19 + 176) + 8LL);
    while ( *((_QWORD *)v21 - 1) != qword_8CE8998 )
    {
      --v20;
      v21 += 4;
      if ( v20 == 0 )
        goto LABEL_37;
    }
    v22 = v19 + 16LL * *v21 + 312;
  }
  else
  {
LABEL_37:
    v22 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v4, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v22)(v4, *(_QWORD *)(v22 + 8));
  if ( v3 != 0 )
  {
    v23 = *(_QWORD *)v3;
    v24 = *(unsigned __int16 *)(*(_QWORD *)v3 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v3 + 302LL) != 0 )
    {
      v25 = (int *)(*(_QWORD *)(v23 + 176) + 8LL);
      while ( *((_QWORD *)v25 - 1) != qword_8CE8998 )
      {
        --v24;
        v25 += 4;
        if ( v24 == 0 )
          goto LABEL_44;
      }
      v26 = v23 + 16LL * *v25 + 312;
    }
    else
    {
LABEL_44:
      v26 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v3, qword_8CE8998, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v26)(v3, *(_QWORD *)(v26 + 8));
  }
  return v14;
}
