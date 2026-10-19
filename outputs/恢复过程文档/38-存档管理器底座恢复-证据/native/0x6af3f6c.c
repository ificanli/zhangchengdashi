void *DbtSaveDataManagerBase_object__object___ReLoadLocalData(void *self, const MethodInfo *method)
{
  void *result; // x0

  if ( self == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  result = (void *)(*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)self + 456LL))(
                     self,
                     *(_QWORD *)(*(_QWORD *)self + 464LL));
  *((_QWORD *)self + 7) = result;
  return result;
}
