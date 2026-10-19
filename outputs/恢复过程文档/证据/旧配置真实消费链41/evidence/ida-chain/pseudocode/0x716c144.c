void stage41_GameFramework_ConfigRead___cctor(void *a0)
{
  _QWORD *v1; // x0
  __int64 v2; // x9
  __int64 v3; // x0
  __int64 v4; // x8

  if ( (byte_9009180 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5DBA0);
    byte_9009180 = 1;
  }
  **((_BYTE **)off_8CE5BB8 + 23) = 0;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_900876D == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_900876D = 1;
  }
  v1 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v1 = off_8CE40C8;
  }
  v2 = *((_QWORD *)off_8CE5BB8 + 23);
  *(_BYTE *)(v2 + 32) = *(_BYTE *)(v1[23] + 56LL);
  *(_DWORD *)(v2 + 36) = 0;
  *(_DWORD *)(v2 + 40) = 0;
  if ( qword_8D5DBA0 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v3 = System_String__TrimEnd(qword_8D5DBA0, 47, 0);
  v4 = *((_QWORD *)off_8CE5BB8 + 23);
  *(_QWORD *)(v4 + 48) = v3;
  *(_BYTE *)(v4 + 56) = 0;
}
