void *ToolModule_GZipTool__CompressCore(void *input, const MethodInfo *method)
{
  __int64 v3; // x19
  __int64 v4; // x20
  __int64 v5; // x8
  __int64 v6; // x9
  int *v7; // x10
  __int64 v8; // x0
  __int64 v9; // x8
  __int64 v10; // x9
  int *v11; // x10
  __int64 v12; // x0

  if ( (byte_8FFE413 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7AE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE8998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D32258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEA878);
    byte_8FFE413 = 1;
  }
  if ( (ToolModule_ListExtend__IsNullOrEmpty_byte_(input, (const MethodInfo *)qword_8D32258) & 1) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEA878);
    System_IO_MemoryStream___ctor(v3, 0);
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7AE0);
    System_IO_Compression_GZipStream___ctor(v4, v3, 0, 1, 0);
    if ( input == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    if ( v4 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    (*(void (__fastcall **)(__int64, void *, _QWORD, _QWORD, _QWORD))(*(_QWORD *)v4 + 904LL))(
      v4,
      input,
      0,
      *((unsigned int *)input + 6),
      *(_QWORD *)(*(_QWORD *)v4 + 912LL));
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
          goto LABEL_10;
      }
      v8 = v5 + 16LL * *v7 + 312;
    }
    else
    {
LABEL_10:
      v8 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v4, qword_8CE8998, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v8)(v4, *(_QWORD *)(v8 + 8));
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    input = (void *)(*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v3 + 1016LL))(
                      v3,
                      *(_QWORD *)(*(_QWORD *)v3 + 1024LL));
    v9 = *(_QWORD *)v3;
    v10 = *(unsigned __int16 *)(*(_QWORD *)v3 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v3 + 302LL) != 0 )
    {
      v11 = (int *)(*(_QWORD *)(v9 + 176) + 8LL);
      while ( *((_QWORD *)v11 - 1) != qword_8CE8998 )
      {
        --v10;
        v11 += 4;
        if ( v10 == 0 )
          goto LABEL_17;
      }
      v12 = v9 + 16LL * *v11 + 312;
    }
    else
    {
LABEL_17:
      v12 = ((__int64 (__fastcall *)(__int64, __int64, _QWORD))unk_3C504A4)(v3, qword_8CE8998, 0);
    }
    (*(void (__fastcall **)(__int64, _QWORD))v12)(v3, *(_QWORD *)(v12 + 8));
  }
  return input;
}
