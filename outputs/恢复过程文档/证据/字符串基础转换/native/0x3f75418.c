unsigned __int8 ToolModule_StringTool__IsNullOrEmpty(void *value, unsigned __int8 trimSpaces, const MethodInfo *method)
{
  if ( value == nullptr )
    return 1;
  if ( (trimSpaces & 1) != 0 )
  {
    value = (void *)System_String__Trim();
    if ( value == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
  }
  return *((_DWORD *)value + 4) == 0;
}
