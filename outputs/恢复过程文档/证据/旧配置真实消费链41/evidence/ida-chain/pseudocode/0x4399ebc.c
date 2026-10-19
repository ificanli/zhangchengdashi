void stage41_ljzs_lt_ConfigMgr__SetConfigABRes(void *a0, void *a1, void *a2)
{
  _QWORD *v4; // x0

  if ( (byte_900085A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    byte_900085A = 1;
  }
  v4 = off_8CE5BB8;
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
    v4 = off_8CE5BB8;
  }
  *(_QWORD *)(v4[23] + 16LL) = a1;
}
