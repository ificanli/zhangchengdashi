void ljzs_lt_Procedure_ProcedurePreLoad__OnLoginValid(void *self, int errorCode, const MethodInfo *method)
{
  __int64 Translation; // x19
  __int64 v5; // x20
  __int64 v6; // x21
  __int64 v7; // x22
  __int64 v8; // x0
  __int64 v9; // x1
  __int64 v10; // x2
  __int64 v11; // x3
  __int64 v12; // x4
  __int64 v13; // x5
  __int64 v14; // x19
  __int64 v15; // x20
  __int64 v16; // x21
  __int64 v17; // x20
  __int64 v18; // x0
  __int64 v19; // x19
  __int64 v20; // x21
  __int64 v21; // x22
  int v22; // [xsp+Ch] [xbp-34h] BYREF

  if ( (byte_90008C9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D1CD00);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3CE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE95C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA0B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D885F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5FC10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D667A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5F700);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D66798);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D667B0);
    byte_90008C9 = 1;
  }
  if ( errorCode == 1019 )
  {
    if ( *((_DWORD *)off_8CEA0B8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEA0B8);
    Translation = I2_Loc_LocalizationManager__GetTranslation(qword_8D667A8, 1, 0, 1, 0, 0, 0, 1, 0);
    v5 = I2_Loc_LocalizationManager__GetTranslation(qword_8D667B0, 1, 0, 1, 0, 0, 0, 1, 0);
    v6 = I2_Loc_LocalizationManager__GetTranslation(qword_8D5FC10, 1, 0, 1, 0, 0, 0, 1, 0);
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
    System_Action___ctor(v7, 0, qword_8D1CD00, 0);
    v8 = Translation;
    v9 = v5;
    v10 = v6;
    v11 = v7;
    v12 = 0;
    v13 = 0;
    goto LABEL_11;
  }
  if ( *((_DWORD *)off_8CEA0B8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA0B8);
  if ( errorCode == 3302 )
  {
    v14 = I2_Loc_LocalizationManager__GetTranslation(qword_8D667A8, 1, 0, 1, 0, 0, 0, 1, 0);
    v15 = I2_Loc_LocalizationManager__GetTranslation(qword_8D5FC10, 1, 0, 1, 0, 0, 0, 1, 0);
    v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
    System_Action___ctor(v16, 0, qword_8D1CD00, 0);
    v12 = 1;
    v13 = 1;
    v8 = v14;
    v9 = qword_8D885F8;
    v10 = v15;
    v11 = v16;
LABEL_11:
    AccountMsgCanvas__SetContent(v8, v9, v10, v11, v12, v13, 0);
    return;
  }
  v17 = I2_Loc_LocalizationManager__GetTranslation(qword_8D66798, 1, 0, 1, 0, 0, 0, 1, 0);
  v22 = errorCode;
  v18 = ((__int64 (__fastcall *)(__int64, int *))unk_3C3D3B8)(qword_8CE95C0, &v22);
  v19 = System_String__Format(qword_8D5F700, v18, 0);
  v20 = I2_Loc_LocalizationManager__GetTranslation(qword_8D5FC10, 1, 0, 1, 0, 0, 0, 1, 0);
  v21 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE3CE0);
  System_Action___ctor(v21, 0, qword_8D1CD00, 0);
  AccountMsgCanvas__SetContent(v17, v19, v20, v21, 0, 0, 0);
}
