void *DbtSaveDataManagerBase_object__object___GetData(void *self, void *data, const MethodInfo *method)
{
  __int64 Instance_object; // x0
  void *v6; // x19
  __int64 v8; // x20

  if ( (byte_9007B6F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9998);
    byte_9007B6F = 1;
  }
  if ( (System_String__IsNullOrEmpty(data, 0) & 1) != 0 )
  {
    Instance_object = System_Activator__CreateInstance_object_(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL)
                                                                         + 64LL));
    if ( Instance_object == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    v6 = (void *)Instance_object;
    (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Instance_object + 392LL))(
      Instance_object,
      *(_QWORD *)(*(_QWORD *)Instance_object + 400LL));
    return v6;
  }
  else
  {
    if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6138);
    v8 = L_Tools_DataCompressTools__GZipDecompressString(data, 0);
    if ( *((_DWORD *)off_8CE9998 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE9998);
    return (void *)Newtonsoft_Json_JsonConvert__DeserializeObject_object_(
                     v8,
                     *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 80LL));
  }
}
