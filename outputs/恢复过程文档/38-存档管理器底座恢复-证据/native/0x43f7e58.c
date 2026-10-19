void *L_Tools_DataCompressTools__GZipDecompressString(void *value, const MethodInfo *method)
{
  const MethodInfo *v3; // x1
  void *v4; // x0
  __int64 v5; // x20
  __int64 v6; // x21
  __int64 UTF8; // x20
  __int64 v8; // x1

  if ( (byte_9000A30 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_9000A30 = 1;
  }
  if ( (System_String__IsNullOrEmpty(value, 0) & 1) != 0 )
    return (void *)qword_8D4ECC0;
  if ( value == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *((_DWORD *)value + 4) == 0 )
    return (void *)qword_8D4ECC0;
  if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6138);
  v4 = L_Tools_DataCompressTools__DecryptString(value, v3);
  if ( v4 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v5 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)v4 + 360LL))(v4, *(_QWORD *)(*(_QWORD *)v4 + 368LL));
  if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5DB0);
  v6 = System_Convert__FromBase64String(v5, 0);
  UTF8 = System_Text_Encoding__get_UTF8(0);
  v8 = L_Tools_DataCompressTools__Decompress(v6);
  if ( UTF8 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (void *)(*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)UTF8 + 888LL))(
                   UTF8,
                   v8,
                   *(_QWORD *)(*(_QWORD *)UTF8 + 896LL));
}
