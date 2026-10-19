void *L_Tools_DataCompressTools__GZipCompressString(void *value, const MethodInfo *method)
{
  __int64 UTF8; // x20
  __int64 v4; // x0
  __int64 v5; // x19
  __int64 v6; // x19
  void *v7; // x0
  const MethodInfo *v8; // x1

  if ( (byte_9000A2E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5DB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_9000A2E = 1;
  }
  if ( (System_String__IsNullOrEmpty(value, 0) & 1) == 0 )
  {
    if ( value == nullptr )
      goto LABEL_13;
    if ( *((_DWORD *)value + 4) != 0 )
    {
      UTF8 = System_Text_Encoding__get_UTF8(0);
      v4 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)value + 360LL))(
             value,
             *(_QWORD *)(*(_QWORD *)value + 368LL));
      if ( UTF8 == 0 )
LABEL_13:
        il2cpp_codegen_raise_null_reference_exception();
      v5 = (*(__int64 (__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)UTF8 + 600LL))(
             UTF8,
             v4,
             *(_QWORD *)(*(_QWORD *)UTF8 + 608LL));
      if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6138);
      v6 = L_Tools_DataCompressTools__Compress(v5);
      if ( *((_DWORD *)off_8CE5DB0 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE5DB0);
      v7 = (void *)System_Convert__ToBase64String(v6, 0);
      return L_Tools_DataCompressTools__EncryptString(v7, v8);
    }
  }
  return (void *)qword_8D4ECC0;
}
