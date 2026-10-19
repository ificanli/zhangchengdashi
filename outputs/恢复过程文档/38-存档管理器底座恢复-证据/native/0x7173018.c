void GameFramework_DataManagerBase___ctor(void *self, const MethodInfo *method)
{
  if ( (byte_900919F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_900919F = 1;
  }
  *((_WORD *)self + 8) = 257;
  *((_QWORD *)self + 3) = **((_QWORD **)off_8CEDAE8 + 23);
  System_Object___ctor(self, 0);
}
