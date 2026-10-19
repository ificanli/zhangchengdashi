void *L_Tools_DataCompressTools__Compress(void *bytes, const MethodInfo *method)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x8
  __int64 v6; // x9
  int *v7; // x10
  __int64 v8; // x0
  void *v9; // x21
  __int64 v10; // x8
  __int64 v11; // x9
  int *v12; // x10
  __int64 v13; // x0

  if ( (byte_9000A2F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7AE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEA878);
    byte_9000A2F = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CEA878, method);
  System_IO_MemoryStream___ctor(v3, 0);
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AE0);
  System_IO_Compression_GZipStream___ctor(v4, v3, 1, 1, 0);
  if ( bytes == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( v4 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, void *, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v4 + 904LL))(
    v4,
    bytes,
    0,
    *((unsigned int *)bytes + 6),
    *(_QWORD *)(*(_QWORD *)v4 + 912LL));
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v4 + 664LL))(v4, *(_QWORD *)(*(_QWORD *)v4 + 672LL));
  v5 = *(_QWORD *)v4;
  v6 = *(unsigned __int16 *)(*(_QWORD *)v4 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v4 + 302LL) != 0 )
  {
    v7 = (int *)(*(_QWORD *)(v5 + 176) + 8LL);
    while ( *((_QWORD *)v7 - 1) != qword_8CE8998 )
    {
      --v6;
      v7 += 4;
      if ( v6 == 0 )
        goto LABEL_9;
    }
    v8 = v5 + 16LL * *v7 + 312;
  }
  else
  {
LABEL_9:
    v8 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v4, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v8)(v4, *(_QWORD *)(v8 + 8));
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v9 = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v3 + 1016LL))(
                 v3,
                 *(_QWORD *)(*(_QWORD *)v3 + 1024LL));
  v10 = *(_QWORD *)v3;
  v11 = *(unsigned __int16 *)(*(_QWORD *)v3 + 302LL);
  if ( *(_WORD *)(*(_QWORD *)v3 + 302LL) != 0 )
  {
    v12 = (int *)(*(_QWORD *)(v10 + 176) + 8LL);
    while ( *((_QWORD *)v12 - 1) != qword_8CE8998 )
    {
      --v11;
      v12 += 4;
      if ( v11 == 0 )
        goto LABEL_16;
    }
    v13 = v10 + 16LL * *v12 + 312;
  }
  else
  {
LABEL_16:
    v13 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v3, qword_8CE8998, 0);
  }
  (*(void (__fastcall **)(__int64, _QWORD))v13)(v3, *(_QWORD *)(v13 + 8));
  return v9;
}
