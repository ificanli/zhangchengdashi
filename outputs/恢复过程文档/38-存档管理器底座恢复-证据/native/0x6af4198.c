void DbtSaveDataManagerBase_object__object___Load(void *self, const MethodInfo *method)
{
  __int64 v4; // x0
  __int64 Instance_object; // x0
  __int64 v6; // x0
  __int64 v7; // x21
  __int64 v8; // x21

  if ( (byte_9007B6E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9998);
    byte_9007B6E = 1;
  }
  if ( *((_QWORD *)self + 6) == 0 )
  {
    if ( (System_String__IsNullOrEmpty(*((_QWORD *)self + 7), 0) & 1) != 0 )
    {
      v4 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 456LL))(
             self,
             *(_QWORD *)(*(_QWORD *)self + 464LL));
      *((_QWORD *)self + 7) = v4;
    }
    else
    {
      v4 = *((_QWORD *)self + 7);
    }
    if ( (System_String__IsNullOrEmpty(v4, 0) & 1) != 0 )
    {
      Instance_object = System_Activator__CreateInstance_object_(*(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL)
                                                                           + 64LL));
      *((_QWORD *)self + 6) = Instance_object;
      if ( Instance_object == 0 )
        goto LABEL_17;
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)Instance_object + 392LL))(
        Instance_object,
        *(_QWORD *)(*(_QWORD *)Instance_object + 400LL));
      v6 = *((_QWORD *)self + 6);
    }
    else
    {
      v7 = *((_QWORD *)self + 7);
      if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6138);
      v8 = L_Tools_DataCompressTools__GZipDecompressString(v7, 0);
      if ( *((_DWORD *)off_8CE9998 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE9998);
      v6 = Newtonsoft_Json_JsonConvert__DeserializeObject_object_(
             v8,
             *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 80LL));
      *((_QWORD *)self + 6) = v6;
    }
    if ( v6 != 0 )
    {
      (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v6 + 376LL))(v6, *(_QWORD *)(*(_QWORD *)v6 + 384LL));
      return;
    }
LABEL_17:
    il2cpp_codegen_raise_null_reference_exception();
  }
}
