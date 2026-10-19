unsigned __int8 DataModule_DataCompareMgr__StartCompare(void *self, void *handler, const MethodInfo *method)
{
  __int64 v5; // x8
  int v6; // w21

  if ( (byte_90005E1 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA1F0);
    byte_90005E1 = 1;
  }
  v5 = **((_QWORD **)off_8CEA1F0 + 23);
  if ( v5 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v6 = *(unsigned __int8 *)(v5 + 80);
  if ( *(_BYTE *)(v5 + 80) != 0 )
  {
    **((_BYTE **)off_8CE6168 + 23) = 1;
  }
  else
  {
    *((_QWORD *)self + 4) = handler;
    sub_4349900(self, handler, method);
  }
  return v6 == 0;
}
