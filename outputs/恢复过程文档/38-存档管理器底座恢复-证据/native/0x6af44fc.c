void DbtSaveDataManagerBase_object__object___Clear(void *self, const MethodInfo *method)
{
  if ( (byte_9007B71 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_9007B71 = 1;
  }
  if ( *((_BYTE *)self + 65) == 0 )
  {
    *((_BYTE *)self + 65) = 1;
    DbtSaveDataManagerBase_object__object___Log(self, 0, qword_8D5BE60);
    (*(void (__fastcall **)(void *, __int64, _QWORD))(*(_QWORD *)self + 440LL))(
      self,
      qword_8D4ECC0,
      *(_QWORD *)(*(_QWORD *)self + 448LL));
  }
}
