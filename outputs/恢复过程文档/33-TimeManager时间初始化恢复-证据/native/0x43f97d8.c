__int64 L_Tools_DateTools__StampToDatetime(__int64 stamp, unsigned __int8 milliseconds, const MethodInfo *method)
{
  double v5; // d0
  __int64 v6; // x0

  if ( (byte_9000A3D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000A3D = 1;
  }
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  v5 = (double)stamp;
  v6 = *((_QWORD *)off_8CE64C0 + 23) + 8LL;
  if ( (milliseconds & 1) != 0 )
    return System_DateTime__AddMilliseconds(v6, 0, method, v5);
  else
    return System_DateTime__AddSeconds(v6, 0, method, v5);
}
