unsigned __int8 L_Tools_DateTools__NowIsServerTime(const MethodInfo *method)
{
  _QWORD *v1; // x0

  if ( (byte_9000A33 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000A33 = 1;
  }
  v1 = off_8CE64C0;
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
    v1 = off_8CE64C0;
  }
  return *(_BYTE *)(v1[23] + 16LL) == 0;
}
