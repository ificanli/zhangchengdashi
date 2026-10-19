void GameFramework_DataManagerBase__T__LGZ(void *self, void *data, const MethodInfo *method)
{
  int **v5; // x0
  _QWORD *v6; // x0
  __int64 v7; // x0

  if ( (byte_900919B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
    byte_900919B = 1;
  }
  if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE8C58);
  if ( byte_9000A16 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
    byte_9000A16 = 1;
  }
  v5 = (int **)off_8CE8C58;
  if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE8C58);
    v5 = (int **)off_8CE8C58;
  }
  if ( *v5[23] >= 10 )
  {
    v6 = off_8CE6178;
    if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CE6178);
      v6 = off_8CE6178;
    }
    if ( *(_BYTE *)(v6[23] + 9LL) != 0 )
    {
      v7 = (*(__int64 (__fastcall **)(void *, _QWORD, const MethodInfo *))(*(_QWORD *)self + 376LL))(
             self,
             *(_QWORD *)(*(_QWORD *)self + 384LL),
             method);
      Oke____A____U(v7, data, *((unsigned __int8 *)self + 17));
    }
  }
}
