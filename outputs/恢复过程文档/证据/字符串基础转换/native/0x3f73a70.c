int ToolModule_StringTool__ToInt(void *value, const MethodInfo *method)
{
  __int64 InvariantCulture; // x0
  int v5; // [xsp+Ch] [xbp-24h] BYREF

  if ( (byte_8FFE424 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5F18);
    byte_8FFE424 = 1;
  }
  v5 = 0;
  if ( *((_DWORD *)off_8CE5F18 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5F18);
  InvariantCulture = System_Globalization_CultureInfo__get_InvariantCulture(0, method);
  System_Int32__TryParse(value, 167, InvariantCulture, &v5, 0);
  return v5;
}
