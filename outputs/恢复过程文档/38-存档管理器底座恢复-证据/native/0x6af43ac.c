void DbtSaveDataManagerBase_object__object___LoadFormMemory(void *self, void *data, const MethodInfo *method)
{
  *((_QWORD *)self + 6) = data;
  if ( data == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(void *, _QWORD))(*(_QWORD *)data + 376LL))(data, *(_QWORD *)(*(_QWORD *)data + 384LL));
}
