void DataModule_DataManager__ChooseConflict(void *self, int status, const MethodInfo *method)
{
  __int64 v4; // x8

  if ( (byte_90005F9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    byte_90005F9 = 1;
  }
  v4 = *((_QWORD *)off_8CE6168 + 23);
  *(_DWORD *)(v4 + 4) = status;
  *(_BYTE *)v4 = 1;
}
