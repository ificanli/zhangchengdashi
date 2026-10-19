void *GameFramework_DataManagerBase__get_DataKey(void *self, const MethodInfo *method)
{
  __int64 Type; // x0

  Type = System_Object__GetType(self, 0);
  if ( Type == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (*(void *(__fastcall **)(__int64, _QWORD))(*(_QWORD *)Type + 440LL))(
           Type,
           *(_QWORD *)(*(_QWORD *)Type + 448LL));
}
