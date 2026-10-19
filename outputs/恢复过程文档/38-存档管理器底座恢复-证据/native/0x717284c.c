void *GameFramework_DataManagerBase__ReadLocalData(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  void *result; // x0
  void *v5; // x20
  __int64 v6; // x19

  if ( (byte_900919C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF230);
    byte_900919C = 1;
  }
  v3 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(self, *(_QWORD *)(*(_QWORD *)self + 384LL));
  result = (void *)Oke______D__S(v3, *((unsigned __int8 *)self + 17));
  v5 = result;
  if ( *((_BYTE *)self + 18) != 0 )
  {
    v6 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 376LL))(
           self,
           *(_QWORD *)(*(_QWORD *)self + 384LL));
    if ( *((_DWORD *)off_8CEF230 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEF230);
    return GameFramework_Utils__DecompressData(v6, v5, 0);
  }
  return result;
}
