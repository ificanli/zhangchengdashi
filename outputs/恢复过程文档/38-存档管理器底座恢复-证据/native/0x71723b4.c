void *GameFramework_DataManagerPool__get_Instance(const MethodInfo *method)
{
  void *v1; // x0
  __int64 v2; // x19
  _QWORD **v3; // x0

  if ( (byte_90091DC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6178);
    byte_90091DC = 1;
  }
  v1 = off_8CE6178;
  if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6178);
    v1 = off_8CE6178;
  }
  if ( **((_QWORD **)v1 + 23) == 0 )
  {
    v2 = ((__int64 (*)(void))unk_3C3D4C4)();
    *(_BYTE *)(v2 + 32) = 1;
    System_Object___ctor(v2, 0);
    v3 = (_QWORD **)off_8CE6178;
    if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE6178);
      v3 = (_QWORD **)off_8CE6178;
    }
    *v3[23] = v2;
    v1 = off_8CE6178;
  }
  if ( *((_DWORD *)v1 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(v1);
    v1 = off_8CE6178;
  }
  return **((void ***)v1 + 23);
}
