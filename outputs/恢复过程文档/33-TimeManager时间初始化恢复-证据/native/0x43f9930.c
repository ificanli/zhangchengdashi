__int64 L_Tools_DateTools__GetNow(const MethodInfo *method)
{
  _QWORD *v1; // x0

  if ( (byte_9000A37 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000A37 = 1;
  }
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
  if ( byte_9000B51 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000B51 = 1;
  }
  v1 = off_8CE64C0;
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
    v1 = off_8CE64C0;
  }
  return *(_QWORD *)(v1[23] + 24LL);
}
