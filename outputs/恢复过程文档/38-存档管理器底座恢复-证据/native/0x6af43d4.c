void DbtSaveDataManagerBase_object__object___Save(void *self, const MethodInfo *method)
{
  _BYTE **v3; // x0
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x8

  if ( (byte_9007B70 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6138);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9998);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9FD0);
    byte_9007B70 = 1;
  }
  if ( *((_BYTE *)self + 65) == 0 && *((_BYTE *)self + 64) != 0 )
  {
    v3 = (_BYTE **)off_8CE9FD0;
    if ( *((_DWORD *)off_8CE9FD0 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE9FD0);
      v3 = (_BYTE **)off_8CE9FD0;
    }
    if ( *v3[23] != 0 )
    {
      (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 520LL))(self, *(_QWORD *)(*(_QWORD *)self + 528LL));
      v4 = *((_QWORD *)self + 6);
      if ( *((_DWORD *)off_8CE9998 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE9998);
      v5 = Newtonsoft_Json_JsonConvert__SerializeObject(v4, 0);
      if ( *((_DWORD *)off_8CE6138 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6138);
      v6 = L_Tools_DataCompressTools__GZipCompressString(v5, 0);
      if ( (System_String__IsNullOrEmpty(v6, 0) & 1) == 0 )
      {
        v7 = *(_QWORD *)self;
        *((_QWORD *)self + 7) = v6;
        (*(void (__fastcall **)(void *, __int64, _QWORD))(v7 + 440))(self, v6, *(_QWORD *)(v7 + 448));
      }
    }
  }
}
