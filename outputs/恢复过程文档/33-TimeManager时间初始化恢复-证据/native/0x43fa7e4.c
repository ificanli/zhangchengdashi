void L_Tools_DateTools___cctor(const MethodInfo *method)
{
  __int64 v1; // x9
  __int64 v2; // x8
  __int64 v3; // [xsp+8h] [xbp-28h] BYREF
  __int64 v4; // [xsp+18h] [xbp-18h] BYREF

  if ( (byte_9000A48 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64C0);
    byte_9000A48 = 1;
  }
  v4 = 0;
  System_DateTime___ctor(&v4, 1970, 1, 1, 8, 0, 0, 1, 0);
  **((_QWORD **)off_8CE64C0 + 23) = v4;
  v3 = 0;
  System_DateTime___ctor(&v3, 1970, 1, 1, 0, 0, 0, 1, 0);
  v1 = v3;
  v2 = *((_QWORD *)off_8CE64C0 + 23);
  *(_BYTE *)(v2 + 16) = 1;
  *(_QWORD *)(v2 + 8) = v1;
}
