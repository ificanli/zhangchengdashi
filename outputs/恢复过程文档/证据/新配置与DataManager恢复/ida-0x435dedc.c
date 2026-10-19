unsigned __int8 DataModule_GlobalInfo___InitInfo_b__92_72(void *self, const MethodInfo *method)
{
  __int64 v3; // x8

  if ( (byte_9000697 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8D0E698);
    byte_9000697 = 1;
  }
  v3 = *((_QWORD *)self + 2);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return *(_DWORD *)(v3 + 24) < 1;
}
