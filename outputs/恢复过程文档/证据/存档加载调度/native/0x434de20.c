void DataModule_DataManager__SaveAllData(void *self, const MethodInfo *method)
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
  __int64 Instance; // x0

  if ( (byte_90005FF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB370);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB310);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB238);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB1D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB260);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB210);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB288);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB1A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB338);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3E0);
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
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17808);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1918);
    byte_90005FF = 1;
  }
  v2 = **((void ***)off_8CD9230 + 23);
  if ( v2 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v2, (const MethodInfo *)qword_8CFB2E8);
  v3 = **((void ***)off_8CD9208 + 23);
  if ( v3 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v3, (const MethodInfo *)qword_8CFB210);
  v4 = **((void ***)off_8CD9250 + 23);
  if ( v4 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v4, (const MethodInfo *)qword_8CFB3A8);
  v5 = **((void ***)off_8CD91F8 + 23);
  if ( v5 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v5, (const MethodInfo *)qword_8CFB1A0);
  v6 = **((void ***)off_8CD9240 + 23);
  if ( v6 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v6, (const MethodInfo *)qword_8CFB338);
  v7 = **((void ***)off_8CD9248 + 23);
  if ( v7 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v7, (const MethodInfo *)qword_8CFB370);
  v8 = **((void ***)off_8CD9210 + 23);
  if ( v8 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v8, (const MethodInfo *)qword_8CFB238);
  v9 = **((void ***)off_8CD9258 + 23);
  if ( v9 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v9, (const MethodInfo *)qword_8CFB3E0);
  v10 = **((void ***)off_8CD91F0 + 23);
  if ( v10 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v10, (const MethodInfo *)qword_8CFB168);
  v11 = **((void ***)off_8CD9200 + 23);
  if ( v11 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v11, (const MethodInfo *)qword_8CFB1D8);
  v12 = **((void ***)off_8CD9220 + 23);
  if ( v12 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v12, (const MethodInfo *)qword_8CFB288);
  v13 = **((void ***)off_8CD9218 + 23);
  if ( v13 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v13, (const MethodInfo *)qword_8CFB260);
  v14 = **((void ***)off_8CD9228 + 23);
  if ( v14 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v14, (const MethodInfo *)qword_8CFB2B0);
  v15 = **((void ***)off_8CD9238 + 23);
  if ( v15 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v15, (const MethodInfo *)qword_8CFB310);
  v16 = **((void ***)off_8CD9260 + 23);
  if ( v16 == nullptr )
    goto LABEL_22;
  DbtSaveDataManagerBase_object__object___Save(v16, (const MethodInfo *)qword_8CFB408);
  if ( *((_DWORD *)off_8CE1918 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1918);
  Instance = L_Tools_SingletonComponent_object___get_Instance(qword_8D17808);
  if ( Instance == 0 )
LABEL_22:
    il2cpp_codegen_raise_null_reference_exception();
  L_Tools_PlayerPrefs2Center__SaveRightNow(Instance, 0);
}
