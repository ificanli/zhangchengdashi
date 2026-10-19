void *DataModule_GlobalInfo__GlobalStringToConfig_object_(void *self, void *path, void *json, const MethodInfo *method)
{
  __int64 v6; // x20

  if ( *((_QWORD *)method + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7AE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9A10);
    if ( *((_QWORD *)method + 7) == 0 )
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  }
  if ( *((_DWORD *)off_8CE7AE8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7AE8);
  v6 = ToolModule_GZipTool__DecompressFromBase64(json, 0);
  if ( *((_DWORD *)off_8CE9A10 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE9A10);
  return (void *)LitJson_JsonMapper__ToObject_object_(v6, **((_QWORD **)method + 7));
}
