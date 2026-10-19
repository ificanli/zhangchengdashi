void *ToolModule_GZipTool__CompressToBase64(void *input, const MethodInfo *method)
{
  _QWORD **v4; // x0
  __int64 v5; // x0
  void *v6; // x0
  const MethodInfo *v7; // x1
  void *v8; // x0

  if ( (byte_8FFE411 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7AE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_8FFE411 = 1;
  }
  if ( (System_String__IsNullOrEmpty(input, 0) & 1) != 0 )
    return **((void ***)off_8CEDAE8 + 23);
  v4 = (_QWORD **)off_8CE7AE8;
  if ( *((_DWORD *)off_8CE7AE8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE7AE8);
    v4 = (_QWORD **)off_8CE7AE8;
  }
  v5 = *v4[23];
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v6 = (void *)(*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)v5 + 600LL))(
                 v5,
                 input,
                 *(_QWORD *)(*(_QWORD *)v5 + 608LL));
  v8 = ToolModule_GZipTool__CompressCore(v6, v7);
  return ToolModule_StringTool__ToBase64String(v8);
}
