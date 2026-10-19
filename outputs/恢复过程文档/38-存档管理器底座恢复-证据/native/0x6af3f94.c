void DbtSaveDataManagerBase_object__object___UpdateDataCallBack(void *self, void *data, const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x8
  _QWORD *v7; // x0
  __int64 v8; // x0
  _QWORD *NewReportJsonData_object; // x19
  __int64 MineGameName; // x0
  __int64 v11; // x8
  __int64 v12; // x0

  if ( (byte_9007B6D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA1F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBB08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D371A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D65BE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D76CF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87890);
    byte_9007B6D = 1;
  }
  v5 = sub_74FE7A4(qword_8D76CF8, data, 0);
  DbtSaveDataManagerBase_object__object___Log(self, 1, v5);
  if ( (System_String__IsNullOrEmpty(data, 0) & 1) == 0
    || (v6 = **((_QWORD **)off_8CEA1F0 + 23)) != 0 && *(_BYTE *)(v6 + 80) != 0 )
  {
    *((_QWORD *)self + 7) = data;
  }
  else if ( (System_String__IsNullOrEmpty(*((_QWORD *)self + 7), 0) & 1) == 0 && **((_BYTE **)off_8CEBB08 + 23) == 0 )
  {
    DbtSaveDataManagerBase_object__object___Log(self, 2, qword_8D87890);
    v7 = off_8CEC810;
    if ( *((_DWORD *)off_8CEC810 + 56) == 0 )
    {
      il2cpp_codegen_runtime_class_init(off_8CEC810);
      v7 = off_8CEC810;
    }
    v8 = *(_QWORD *)(v7[23] + 8LL);
    if ( v8 == 0 )
      goto LABEL_18;
    NewReportJsonData_object = (_QWORD *)DBTSDK_ReportManager__GetNewReportJsonData_object_(v8, 1, 0, qword_8D371A0);
    if ( *((_DWORD *)off_8CE40C8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE40C8);
    MineGameName = GameFramework_AppSetting__get_MineGameName(0);
    if ( NewReportJsonData_object == nullptr
      || (NewReportJsonData_object[2] = MineGameName,
          v11 = qword_8D65BE8,
          NewReportJsonData_object[11] = qword_8D65BE8,
          NewReportJsonData_object[8] = v11,
          (v12 = *(_QWORD *)(*((_QWORD *)off_8CEC810 + 23) + 8LL)) == 0) )
    {
LABEL_18:
      il2cpp_codegen_raise_null_reference_exception();
    }
    DBTSDK_ReportManager__NewReport_activity_complete(v12, NewReportJsonData_object, 0);
  }
}
