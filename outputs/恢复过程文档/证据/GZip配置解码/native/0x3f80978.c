void *ToolModule_GZipTool__DecompressFromBase64(void *input, const MethodInfo *method)
{
  const MethodInfo *v4; // x1
  void *v5; // x20
  void *v6; // x1
  __int64 v7; // x0

  if ( (byte_8FFE414 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7AE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_8FFE414 = 1;
  }
  if ( (System_String__IsNullOrEmpty(input, 0) & 1) != 0 )
    return **((void ***)off_8CEDAE8 + 23);
  if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5DB0);
  v5 = (void *)System_Convert__FromBase64String(input, 0);
  if ( *((_DWORD *)off_8CE7AE8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7AE8);
  v6 = ToolModule_GZipTool__DecompressCore(v5, v4);
  v7 = **((_QWORD **)off_8CE7AE8 + 23);
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (void *)(*(__int64 (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)v7 + 888LL))(
                   v7,
                   v6,
                   *(_QWORD *)(*(_QWORD *)v7 + 896LL));
}
