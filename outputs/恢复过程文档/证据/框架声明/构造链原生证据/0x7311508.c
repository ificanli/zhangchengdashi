void __KZ____ctor(void *self, void *arg0, const MethodInfo *method)
{
  __int64 v5; // x8
  __int64 v6; // x8

  __Mpb___ctor(self, arg0, 0, 0);
  *((_DWORD *)self + 20) = 1065353216;
  if ( arg0 == nullptr || (v5 = *((_QWORD *)arg0 + 2)) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v6 = *(_QWORD *)(v5 + 48);
  *((_DWORD *)self + 10) = 1;
  *((_QWORD *)self + 11) = v6;
}
