void L_Tools_ServerTimeMgr__GetCurrentServerTime(void *self, const MethodInfo *method)
{
  _QWORD *v2; // x0
  _BYTE *v3; // x8
  __int64 Instance; // x0

  if ( (byte_90009C2 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8348);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_90009C2 = 1;
  }
  v2 = off_8CED280;
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CED280);
    v2 = off_8CED280;
  }
  v3 = (_BYTE *)v2[23];
  if ( *v3 != 0 )
  {
    if ( *((_DWORD *)v2 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v2);
      v3 = *((_BYTE **)off_8CED280 + 23);
    }
    *v3 = 0;
    if ( *((_DWORD *)off_8CE8348 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE8348);
    Instance = GameFramework_Net_Http_HttpManager__get_Instance(0, method);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    GameFramework_Net_Http_HttpManager__RequestServerTime(Instance, 0);
  }
}
