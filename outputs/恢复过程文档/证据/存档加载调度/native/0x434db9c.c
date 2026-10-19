void DataModule_DataManager__StopAllSave(void *self, const MethodInfo *method)
{
  __int64 v2; // x8
  __int64 v3; // x8
  __int64 v4; // x8
  __int64 v5; // x8
  __int64 v6; // x8
  __int64 v7; // x8
  __int64 v8; // x8
  __int64 v9; // x8
  __int64 v10; // x8
  __int64 v11; // x8
  __int64 v12; // x8
  __int64 v13; // x8
  __int64 v14; // x8
  __int64 v15; // x8
  __int64 v16; // x8

  if ( (byte_90005FE & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9230);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9220);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9218);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD91F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD91F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9240);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9238);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9248);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CD9208);
    byte_90005FE = 1;
  }
  v2 = **((_QWORD **)off_8CD9230 + 23);
  if ( v2 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v2 + 64) = 0;
  v3 = **((_QWORD **)off_8CD9208 + 23);
  if ( v3 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v3 + 64) = 0;
  v4 = **((_QWORD **)off_8CD9250 + 23);
  if ( v4 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v4 + 64) = 0;
  v5 = **((_QWORD **)off_8CD91F8 + 23);
  if ( v5 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v5 + 64) = 0;
  v6 = **((_QWORD **)off_8CD9240 + 23);
  if ( v6 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v6 + 64) = 0;
  v7 = **((_QWORD **)off_8CD9248 + 23);
  if ( v7 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v7 + 64) = 0;
  v8 = **((_QWORD **)off_8CD9210 + 23);
  if ( v8 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v8 + 64) = 0;
  v9 = **((_QWORD **)off_8CD9258 + 23);
  if ( v9 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v9 + 64) = 0;
  v10 = **((_QWORD **)off_8CD91F0 + 23);
  if ( v10 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v10 + 64) = 0;
  v11 = **((_QWORD **)off_8CD9200 + 23);
  if ( v11 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v11 + 64) = 0;
  v12 = **((_QWORD **)off_8CD9220 + 23);
  if ( v12 == 0 )
    goto LABEL_19;
  *(_BYTE *)(v12 + 64) = 0;
  v13 = **((_QWORD **)off_8CD9218 + 23);
  if ( v13 == 0
    || (*(_BYTE *)(v13 + 64) = 0, (v14 = **((_QWORD **)off_8CD9228 + 23)) == 0)
    || (*(_BYTE *)(v14 + 64) = 0, (v15 = **((_QWORD **)off_8CD9238 + 23)) == 0)
    || (*(_BYTE *)(v15 + 64) = 0, (v16 = **((_QWORD **)off_8CD9260 + 23)) == 0) )
  {
LABEL_19:
    il2cpp_codegen_raise_null_reference_exception();
  }
  *(_BYTE *)(v16 + 64) = 0;
}
