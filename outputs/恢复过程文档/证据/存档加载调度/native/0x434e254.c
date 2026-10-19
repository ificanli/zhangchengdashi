void DataModule_DataManager__ClearAllData(void *self, const MethodInfo *method)
{
  void *v2; // x0
  void *v3; // x0
  void *v4; // x0
  void *v5; // x0
  void *v6; // x0
  void *v7; // x0
  void *v8; // x0
  void *v9; // x0
  void *v10; // x0
  void *v11; // x0
  void *v12; // x0
  void *v13; // x0
  void *v14; // x0
  void *v15; // x0
  void *v16; // x0
  __int64 v17; // x0

  if ( (byte_9000600 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB300);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB328);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB158);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB228);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB180);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB1F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB1B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB278);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB388);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB350);
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
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9C48);
    byte_9000600 = 1;
  }
  v2 = **((void ***)off_8CD9230 + 23);
  if ( v2 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v2, (const MethodInfo *)qword_8CFB2C8);
  v3 = **((void ***)off_8CD9208 + 23);
  if ( v3 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v3, (const MethodInfo *)qword_8CFB1F0);
  v4 = **((void ***)off_8CD9250 + 23);
  if ( v4 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v4, (const MethodInfo *)qword_8CFB388);
  v5 = **((void ***)off_8CD91F8 + 23);
  if ( v5 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v5, (const MethodInfo *)qword_8CFB180);
  v6 = **((void ***)off_8CD9240 + 23);
  if ( v6 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v6, (const MethodInfo *)qword_8CFB328);
  v7 = **((void ***)off_8CD9248 + 23);
  if ( v7 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v7, (const MethodInfo *)qword_8CFB350);
  v8 = **((void ***)off_8CD9210 + 23);
  if ( v8 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v8, (const MethodInfo *)qword_8CFB228);
  v9 = **((void ***)off_8CD9258 + 23);
  if ( v9 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v9, (const MethodInfo *)qword_8CFB3C0);
  v10 = **((void ***)off_8CD91F0 + 23);
  if ( v10 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v10, (const MethodInfo *)qword_8CFB158);
  v11 = **((void ***)off_8CD9200 + 23);
  if ( v11 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v11, (const MethodInfo *)qword_8CFB1B8);
  v12 = **((void ***)off_8CD9220 + 23);
  if ( v12 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v12, (const MethodInfo *)qword_8CFB278);
  v13 = **((void ***)off_8CD9218 + 23);
  if ( v13 == nullptr )
    goto LABEL_20;
  DbtSaveDataManagerBase_object__object___Clear(v13, (const MethodInfo *)qword_8CFB250);
  v14 = **((void ***)off_8CD9228 + 23);
  if ( v14 == nullptr
    || (DbtSaveDataManagerBase_object__object___Clear(v14, (const MethodInfo *)qword_8CFB2A0),
        (v15 = **((void ***)off_8CD9238 + 23)) == nullptr)
    || (DbtSaveDataManagerBase_object__object___Clear(v15, (const MethodInfo *)qword_8CFB300),
        (v16 = **((void ***)off_8CD9260 + 23)) == nullptr)
    || (DbtSaveDataManagerBase_object__object___Clear(v16, (const MethodInfo *)qword_8CFB3F8),
        (v17 = **((_QWORD **)off_8CE9C48 + 23)) == 0) )
  {
LABEL_20:
    il2cpp_codegen_raise_null_reference_exception();
  }
  L_Tools_GameTest_LTPlayerPrefsDataManager__UploadEmptyData(v17, 0);
}
