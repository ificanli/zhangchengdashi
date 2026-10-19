void L_Tools_DateTools__UpdateTime(__int64 stamp, const MethodInfo *method)
{
  _QWORD *v3; // x0
  __int64 v4; // x8
  __int64 v5; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_9000A34 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000A34 = 1;
  }
  v3 = off_8CE64C0;
  if ( *((_DWORD *)off_8CE64C0 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE64C0);
    v3 = off_8CE64C0;
  }
  v4 = v3[23];
  if ( *(_BYTE *)(v4 + 16) != 0 )
  {
    if ( *((_DWORD *)v3 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(v3);
      v3 = off_8CE64C0;
      v4 = *((_QWORD *)off_8CE64C0 + 23);
    }
    *(_BYTE *)(v4 + 16) = 0;
  }
  if ( *((_DWORD *)v3 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(v3);
  v5 = L_Tools_DateTools__StampToDatetime(stamp, 0);
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6460);
  *(_QWORD *)(*((_QWORD *)off_8CE64C0 + 23) + 24LL) = System_DateTime__ToLocalTime(&v5, 0);
  *(_QWORD *)(*((_QWORD *)off_8CE64C0 + 23) + 32LL) = L_Tools_DateTools__StampToDatetime(stamp, 0);
}
