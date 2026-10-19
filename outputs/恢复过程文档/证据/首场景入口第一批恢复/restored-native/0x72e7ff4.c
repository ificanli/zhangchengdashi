void GameFramework_Base_GameStartEntry_____YW_(void *self, void *resources, const MethodInfo *method)
{
  __int64 v5; // x0

  if ( (byte_900A04A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5C588);
    byte_900A04A = 1;
  }
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D5C588);
  v5 = *((_QWORD *)self + 10);
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  (*(void (__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)v5 + 408LL))(
    v5,
    resources,
    *(_QWORD *)(*(_QWORD *)v5 + 416LL));
}
