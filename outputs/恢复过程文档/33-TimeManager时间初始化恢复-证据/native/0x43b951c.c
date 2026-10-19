unsigned __int8 L_Tools_ServerTimeMgr__get_IsUpdateFinish(const MethodInfo *method)
{
  _BYTE **v1; // x0

  if ( (byte_90009BA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CED280);
    byte_90009BA = 1;
  }
  v1 = (_BYTE **)off_8CED280;
  if ( *((_DWORD *)off_8CED280 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CED280);
    v1 = (_BYTE **)off_8CED280;
  }
  return *v1[23];
}
