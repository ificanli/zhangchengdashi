void DataModule_DataCompareMgr__OnUseChoose(void *self, unsigned __int8 useLocal, const MethodInfo *method)
{
  __int64 v5; // x8

  if ( (byte_90005EB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA258);
    byte_90005EB = 1;
  }
  v5 = *((_QWORD *)self + 4);
  if ( (useLocal & 1) != 0 )
  {
    if ( v5 != 0 )
      (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v5 + 24))(*(_QWORD *)(v5 + 64), 1, *(_QWORD *)(v5 + 40));
  }
  else if ( v5 != 0 )
  {
    (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v5 + 24))(*(_QWORD *)(v5 + 64), 2, *(_QWORD *)(v5 + 40));
  }
  **((_BYTE **)off_8CEA258 + 23) = 0;
  **((_BYTE **)off_8CE6168 + 23) = 1;
}
