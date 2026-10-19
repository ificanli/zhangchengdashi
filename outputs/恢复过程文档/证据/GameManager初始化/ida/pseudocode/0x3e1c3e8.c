void GameModule_GameManager___c___RegisterOnTimeToZero_b__21_3(void *self, const MethodInfo *method)
{
  __int64 v2; // x0
  __int64 v3; // x8

  if ( (byte_8FFD8A5 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB238);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB240);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9210);
    byte_8FFD8A5 = 1;
  }
  v2 = **((_QWORD **)off_8CD9210 + 23);
  if ( v2 == 0 || (v3 = *(_QWORD *)(v2 + 48)) == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_DWORD *)(v3 + 52) = 0;
  DbtSaveDataManagerBase_object__object___Save(v2, qword_8CFB238);
}
