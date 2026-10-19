void DbtSaveDataManagerBase_object__object___OnSave(void *self, const MethodInfo *method)
{
  if ( *((_BYTE *)self + 65) == 0 )
    (*(void (__fastcall **)(void *, _QWORD, _QWORD))(*(_QWORD *)self + 440LL))(
      self,
      *((_QWORD *)self + 7),
      *(_QWORD *)(*(_QWORD *)self + 448LL));
}
