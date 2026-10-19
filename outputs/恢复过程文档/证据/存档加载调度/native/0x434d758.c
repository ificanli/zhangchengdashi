void DataModule_DataManager__LoadAllSaveData(void *self, const MethodInfo *method)
{
  _BYTE *v2; // x0
  _BYTE *v3; // x0
  _BYTE *v4; // x0
  _BYTE *v5; // x0
  _BYTE *v6; // x0
  _BYTE *v7; // x0
  _BYTE *v8; // x0
  _BYTE *v9; // x0
  _BYTE *v10; // x0
  _BYTE *v11; // x0
  _BYTE *v12; // x0
  _BYTE *v13; // x0
  _BYTE *v14; // x0
  _BYTE *v15; // x0
  _BYTE *v16; // x0

  if ( (byte_90005FD & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB3D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB308);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB230);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB1C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB190);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB330);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB160);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB398);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB400);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB280);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB360);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB200);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB2D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFB258);
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
    byte_90005FD = 1;
  }
  v2 = **((_BYTE ***)off_8CD9230 + 23);
  if ( v2 == nullptr )
    goto LABEL_19;
  v2[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v2, (const MethodInfo *)qword_8CFB2D8);
  v3 = **((_BYTE ***)off_8CD9208 + 23);
  if ( v3 == nullptr )
    goto LABEL_19;
  v3[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v3, (const MethodInfo *)qword_8CFB200);
  v4 = **((_BYTE ***)off_8CD9250 + 23);
  if ( v4 == nullptr )
    goto LABEL_19;
  v4[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v4, (const MethodInfo *)qword_8CFB398);
  v5 = **((_BYTE ***)off_8CD91F8 + 23);
  if ( v5 == nullptr )
    goto LABEL_19;
  v5[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v5, (const MethodInfo *)qword_8CFB190);
  v6 = **((_BYTE ***)off_8CD9240 + 23);
  if ( v6 == nullptr )
    goto LABEL_19;
  v6[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v6, (const MethodInfo *)qword_8CFB330);
  v7 = **((_BYTE ***)off_8CD9248 + 23);
  if ( v7 == nullptr )
    goto LABEL_19;
  v7[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v7, (const MethodInfo *)qword_8CFB360);
  v8 = **((_BYTE ***)off_8CD9210 + 23);
  if ( v8 == nullptr )
    goto LABEL_19;
  v8[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v8, (const MethodInfo *)qword_8CFB230);
  v9 = **((_BYTE ***)off_8CD9258 + 23);
  if ( v9 == nullptr )
    goto LABEL_19;
  v9[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v9, (const MethodInfo *)qword_8CFB3D0);
  v10 = **((_BYTE ***)off_8CD91F0 + 23);
  if ( v10 == nullptr )
    goto LABEL_19;
  v10[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v10, (const MethodInfo *)qword_8CFB160);
  v11 = **((_BYTE ***)off_8CD9200 + 23);
  if ( v11 == nullptr )
    goto LABEL_19;
  v11[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v11, (const MethodInfo *)qword_8CFB1C8);
  v12 = **((_BYTE ***)off_8CD9220 + 23);
  if ( v12 == nullptr )
    goto LABEL_19;
  v12[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v12, (const MethodInfo *)qword_8CFB280);
  v13 = **((_BYTE ***)off_8CD9218 + 23);
  if ( v13 == nullptr )
    goto LABEL_19;
  v13[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v13, (const MethodInfo *)qword_8CFB258);
  v14 = **((_BYTE ***)off_8CD9228 + 23);
  if ( v14 == nullptr
    || (v14[64] = 1,
        DbtSaveDataManagerBase_object__object___Load(v14, (const MethodInfo *)qword_8CFB2A8),
        (v15 = **((_BYTE ***)off_8CD9238 + 23)) == nullptr)
    || (v15[64] = 1,
        DbtSaveDataManagerBase_object__object___Load(v15, (const MethodInfo *)qword_8CFB308),
        (v16 = **((_BYTE ***)off_8CD9260 + 23)) == nullptr) )
  {
LABEL_19:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v16[64] = 1;
  DbtSaveDataManagerBase_object__object___Load(v16, (const MethodInfo *)qword_8CFB400);
}
