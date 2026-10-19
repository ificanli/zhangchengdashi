void GameModule_GameManager___c___RegisterOnTimeToMonDayZero_b__22_1(void *self, const MethodInfo *method)
{
  __int64 v2; // x0
  __int64 v3; // x8
  __int64 v4; // x9

  if ( (byte_8FFD8A8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&unk_8CFB268);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9218);
    byte_8FFD8A8 = 1;
  }
  v2 = **((_QWORD **)off_8CD9218 + 23);
  if ( v2 == 0 || (v3 = *(_QWORD *)(v2 + 48)) == 0 || (v4 = *(_QWORD *)(v3 + 144), *(_QWORD *)(v3 + 56) = 0, v4 == 0) )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v4 + 16) = 0;
  *(_DWORD *)(v3 + 64) = 0;
  DbtSaveDataManagerBase_object__object___Save(v2, qword_8CFB260);
}
