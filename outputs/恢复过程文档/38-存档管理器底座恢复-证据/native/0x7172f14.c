void GameFramework_DataManagerBase___l_DD_(void *self, void *data, const MethodInfo *method)
{
  __int64 v5; // x21
  const MethodInfo *v6; // x2
  _QWORD *v7; // x0

  if ( (byte_900919E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF230);
    byte_900919E = 1;
  }
  if ( *((_BYTE *)self + 18) != 0 )
  {
    v5 = (*(__int64 (__fastcall **)(void *, _QWORD, const MethodInfo *))(*(_QWORD *)self + 376LL))(
           self,
           *(_QWORD *)(*(_QWORD *)self + 384LL),
           method);
    if ( *((_DWORD *)off_8CEF230 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEF230);
    data = GameFramework_Utils__DecompressData(v5, data, 0);
  }
  (*(void (__fastcall **)(void *, void *, _QWORD))(*(_QWORD *)self + 488LL))(
    self,
    data,
    *(_QWORD *)(*(_QWORD *)self + 496LL));
  v7 = off_8CE6178;
  if ( *((_DWORD *)off_8CE6178 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6178);
    v7 = off_8CE6178;
  }
  if ( *(_BYTE *)(v7[23] + 9LL) != 0 )
    GameFramework_DataManagerBase__T__LGZ(self, data, v6);
}
