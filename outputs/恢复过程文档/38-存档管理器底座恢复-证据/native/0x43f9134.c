void *L_Tools_DataCompressTools__Decompress(void *bytes, const MethodInfo *method)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x23
  __int64 v6; // x21
  int v7; // w0
  void *v8; // x21
  __int64 v9; // x8
  __int64 v10; // x9
  int *v11; // x10
  __int64 v12; // x0
  __int64 v13; // x8
  __int64 v14; // x9
  int *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x8
  __int64 v18; // x9
  int *v19; // x10
  __int64 v20; // x0

  if ( (byte_9000A31 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE2BF0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7AE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEA878);
    byte_9000A31 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CEA878, method);
  sub_75CF1DC(v3, bytes, 0);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AE0);
  sub_7D18440(v4, v3, 0, 0);
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEA878);
  System_IO_MemoryStream___ctor(v5, 0);
  v6 = ((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE2BF0, 0x8000);
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  while ( 1 )
  {
    v7 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v4 + 856LL))(
           v4,
           v6,
           0,
           *(unsigned int *)(v6 + 24),
           *(_QWORD *)(*(_QWORD *)v4 + 864LL));
    if ( v7 < 1 )
      break;
    if ( v5 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, __int64, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v5 + 904LL))(
      v5,
      v6,
      0,
      (unsigned int)v7,
      *(_QWORD *)(*(_QWORD *)v5 + 912LL));
  }
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v8 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v5 + 1016LL))(
                 v5,
                 *(_QWORD *)(*(_QWORD *)v5 + 1024LL));
  v9 = *(_QWORD *)v5;
  v10 = *(unsigned __int16 *)(*(_QWORD *)v5 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v5 + 302LL) != 0 )
  {
    v11 = (int *)(*(_QWORD *)(v9 + 176) + 8LL);
    while ( *((_QWORD *)v11 - 1) != qword_8CE8998 )
    {
      --v10;
      v11 += 4;
      if ( v10 == 0 )
        goto LABEL_13;
    }
    v12 = v9 + 16LL * *v11 + 312;
  }
  else
  {
LABEL_13:
    v12 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v5, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v12)(v5, *(_QWORD *)(v12 + 8));
  v13 = *(_QWORD *)v4;
  v14 = *(unsigned __int16 *)(*(_QWORD *)v4 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v4 + 302LL) != 0 )
  {
    v15 = (int *)(*(_QWORD *)(v13 + 176) + 8LL);
    while ( *((_QWORD *)v15 - 1) != qword_8CE8998 )
    {
      --v14;
      v15 += 4;
      if ( v14 == 0 )
        goto LABEL_19;
    }
    v16 = v13 + 16LL * *v15 + 312;
  }
  else
  {
LABEL_19:
    v16 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v4, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v16)(v4, *(_QWORD *)(v16 + 8));
  if ( v3 != 0 )
  {
    v17 = *(_QWORD *)v3;
    v18 = *(unsigned __int16 *)(*(_QWORD *)v3 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v3 + 302LL) != 0 )
    {
      v19 = (int *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != qword_8CE8998 )
      {
        --v18;
        v19 += 4;
        if ( v18 == 0 )
          goto LABEL_26;
      }
      v20 = v17 + 16LL * *v19 + 312;
    }
    else
    {
LABEL_26:
      v20 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v3, qword_8CE8998, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v20)(v3, *(_QWORD *)(v20 + 8));
  }
  return v8;
}
