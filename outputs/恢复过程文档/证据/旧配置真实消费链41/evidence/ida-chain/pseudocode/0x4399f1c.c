void *stage41_ljzs_lt_ConfigMgr__get_Instance(void *a0)
{
  void *v1; // x8
  __int64 v2; // x19

  if ( (byte_900085B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB0);
    byte_900085B = 1;
  }
  v1 = **((void ***)off_8CE5BB0 + 23);
  if ( v1 == nullptr )
  {
    v2 = ((__int64 (*)(void))unk_3C3D4C4)();
    ljzs_lt_ConfigMgr___ctor();
    **((_QWORD **)off_8CE5BB0 + 23) = v2;
    return **((void ***)off_8CE5BB0 + 23);
  }
  return v1;
}
