void stage41_ljzs_lt_ConfigMgr__Initialize(void *a0, void *a1)
{
  _BYTE **v3; // x0
  _QWORD *v4; // x0

  if ( (byte_9000858 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    byte_9000858 = 1;
  }
  v3 = (_BYTE **)off_8CE5BB8;
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v3 = (_BYTE **)off_8CE5BB8;
  }
  *v3[23] = 1;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
  if ( byte_90008FE == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    byte_90008FE = 1;
  }
  v4 = off_8CE40C8;
  if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE40C8);
    v4 = off_8CE40C8;
  }
  *(_BYTE *)(v4[23] + 60LL) = 0;
  if ( *((_BYTE *)a0 + 16) == 0 )
  {
    ljzs_lt_ConfigMgr__ReadConfig(a0, a1);
    ljzs_lt_ConfigMgr__customRead(a0);
    *((_BYTE *)a0 + 16) = 1;
  }
}
