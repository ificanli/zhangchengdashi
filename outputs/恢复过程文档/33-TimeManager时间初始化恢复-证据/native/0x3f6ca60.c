void sub_3F6CA60(void *self, void *info, const MethodInfo *method)
{
  System_Object___ctor(self, 0);
  if ( info == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  *((_QWORD *)self + 2) = *((_QWORD *)info + 2);
  *((_QWORD *)self + 3) = *((_QWORD *)info + 3);
  *((_QWORD *)self + 4) = *((_QWORD *)info + 4);
  *((_BYTE *)self + 40) = *((_BYTE *)info + 40);
}
