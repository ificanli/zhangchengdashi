void *LoadingModule_LoadingManager__GetData(void *self, void *fileName, const MethodInfo *method)
{
  void *v5; // x20
  __int64 FilePath; // x19

  if ( (byte_8FFEDC7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_8FFEDC7 = 1;
  }
  v5 = (void *)qword_8D4ECC0;
  FilePath = LoadingModule_LoadingManager__GetFilePath(self, fileName, method);
  if ( (System_IO_File__Exists(FilePath, 0) & 1) != 0 )
    return System_IO_File__ReadAllText(FilePath, 0);
  else
    return v5;
}
