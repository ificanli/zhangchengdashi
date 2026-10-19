void *ToolModule_GZipTool__Decompress(void *input, const MethodInfo *method)
{
  if ( (byte_8FFE415 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7AE8);
    byte_8FFE415 = 1;
  }
  if ( *((_DWORD *)off_8CE7AE8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7AE8);
  return ToolModule_GZipTool__DecompressCore(input, method);
}
