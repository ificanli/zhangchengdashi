void ___u____ctor(void *self, void *arg0, int arg1, int arg2, const MethodInfo *method)
{
  __int64 v7; // x0

  __Mpb___ctor(self, arg0, arg1, arg2, method);
  if ( arg0 == nullptr || (v7 = *((_QWORD *)arg0 + 2)) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)self + 16) = YooAsset_PackageBundle__get_TempDataFilePath(v7, 0);
}
