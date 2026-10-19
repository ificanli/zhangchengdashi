void DataModule_DataCompareMgr__OnLTCompareFinish(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x0
  __int64 v5; // x20
  __int64 v6; // x0
  int v7; // w0
  int v8; // w20
  __int64 LoginUserID; // x0
  __int64 v10; // x21
  __int64 v11; // x8
  __int64 v12; // x0
  __int64 v13; // x21
  __int64 v14; // x1
  __int64 v15; // x21
  __int64 v16; // x8
  __int64 v17; // x9
  __int64 v18; // x21
  __int64 v19; // x0
  __int64 v20; // x8
  __int64 v21; // x0
  _BYTE v22[4]; // [xsp+Ch] [xbp-34h] BYREF

  if ( (byte_90005E4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE4D90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6548);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7D40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA1F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87A08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86130);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D878C8);
    byte_90005E4 = 1;
  }
  v3 = **((_QWORD **)off_8CEA1F0 + 23);
  if ( v3 == 0 )
    goto LABEL_36;
  v22[0] = CommonGameModule_Login_LoginProcedureBase__get_IsNewDevice(v3, 0) & 1;
  if ( *((_DWORD *)off_8CE4D90 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE4D90);
  v4 = System_Boolean__ToString(v22, 0);
  v5 = sub_74FE7A4(qword_8D87040, v4, 0);
  if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6548);
  v6 = ToolModule_DebugExtend__LogCompare(v5, 0);
  v7 = DataModule_DataCompareMgr__VersionConflict(v6);
  *((_DWORD *)self + 10) = v7;
  v8 = v7;
  if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7D40);
  LoginUserID = GameFramework_GlobalData__get_LoginUserID(0);
  v10 = sub_74FE7A4(qword_8D86130, LoginUserID, 0);
  if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6548);
  ToolModule_DebugExtend__LogCompareError(v10, 0);
  v11 = **((_QWORD **)off_8CEA1F0 + 23);
  if ( v11 == 0 )
    goto LABEL_36;
  v12 = *(_QWORD *)(v11 + 56);
  v13 = qword_8D878C8;
  if ( v12 != 0 )
    v14 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v12 + 360LL))(
            v12,
            *(_QWORD *)(*(_QWORD *)v12 + 368LL));
  else
    v14 = 0;
  v15 = sub_74FE7A4(v13, v14, 0);
  if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE6548);
  ToolModule_DebugExtend__LogCompareError(v15, 0);
  v16 = **((_QWORD **)off_8CEA1F0 + 23);
  if ( v16 == 0 )
    goto LABEL_36;
  v17 = *(_QWORD *)(v16 + 56);
  if ( v17 == 0 )
    goto LABEL_36;
  v18 = *(_QWORD *)(v16 + 120);
  v19 = System_Int64__ToString(v17 + 16, 0);
  if ( (System_String__op_Inequality(v18, v19, 0) & 1) != 0 )
  {
    v20 = *((_QWORD *)self + 4);
    goto LABEL_27;
  }
  v21 = **((_QWORD **)off_8CEA1F0 + 23);
  if ( v21 == 0 )
LABEL_36:
    il2cpp_codegen_raise_null_reference_exception();
  if ( (CommonGameModule_Login_LoginProcedureBase__get_IsNewDevice(v21, 0) & 1) != 0 && *((_DWORD *)self + 10) == 0 )
  {
    if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6548);
    ToolModule_DebugExtend__LogCompareError(qword_8D87A08, 0);
    *((_DWORD *)self + 10) = 2;
  }
  else if ( v8 != 2 )
  {
    v20 = *((_QWORD *)self + 4);
    if ( *((_DWORD *)self + 10) == 0 )
    {
      if ( v20 != 0 )
        (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v20 + 24))(*(_QWORD *)(v20 + 64), 1, *(_QWORD *)(v20 + 40));
      goto LABEL_29;
    }
LABEL_27:
    if ( v20 != 0 )
      (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v20 + 24))(*(_QWORD *)(v20 + 64), 2, *(_QWORD *)(v20 + 40));
LABEL_29:
    **((_BYTE **)off_8CE6168 + 23) = 1;
    return;
  }
  DataModule_DataCompareMgr__CompareData(self);
}
