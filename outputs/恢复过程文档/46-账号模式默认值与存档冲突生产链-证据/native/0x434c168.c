void DataModule_DataCompareMgr__CompareData_d__13__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x21
  __int64 Awaiter; // x0
  __int64 v6; // x8
  __int64 v7; // x10
  __int64 v8; // x21
  __int64 v9; // x0
  __int64 LocalData; // x1
  __int64 XXX; // x0
  __int64 v12; // x8
  int v13; // w8
  __int64 v14; // x8
  __int64 v15; // [xsp+8h] [xbp-28h] BYREF

  if ( (byte_90005F0 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D21940);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6168);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6548);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9C48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEBB08);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF3320);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF650);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86358);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86360);
    byte_90005F0 = 1;
  }
  v15 = 0;
  v3 = *((_QWORD *)self + 5);
  if ( *(_DWORD *)self == 0 )
  {
    v6 = *((_QWORD *)self + 6);
    if ( v6 != 0
      && ((v7 = *((unsigned __int8 *)off_8CF3320 + 304), *(unsigned __int8 *)(*(_QWORD *)v6 + 304LL) < (unsigned int)v7)
       || *(_UNKNOWN **)(*(_QWORD *)(*(_QWORD *)v6 + 200LL) + 8 * v7 - 8) != off_8CF3320) )
    {
      ((void (__fastcall *)(_QWORD))unk_3C3D868)(*((_QWORD *)self + 6));
    }
    else
    {
      v15 = *((_QWORD *)self + 6);
      *((_QWORD *)self + 6) = 0;
      *(_DWORD *)self = -1;
      if ( v6 != 0 )
        goto LABEL_11;
    }
    il2cpp_codegen_raise_null_reference_exception();
  }
  v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CEF650, method);
  UnityEngine_WaitForEndOfFrame___ctor(v4, 0);
  Awaiter = IEnumeratorAwaitExtensions__GetAwaiter(v4, 0);
  v6 = Awaiter;
  v15 = Awaiter;
  if ( Awaiter == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *(_BYTE *)(Awaiter + 16) == 0 )
  {
    *(_DWORD *)self = 0;
    *((_QWORD *)self + 6) = Awaiter;
    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitOnCompleted_object__DataCompareMgr__CompareData_d__13_(
      (char *)self + 8,
      &v15,
      self,
      qword_8D21940);
    return;
  }
LABEL_11:
  IEnumeratorAwaitExtensions_SimpleCoroutineAwaiter__GetResult(v6, 0);
  v8 = ((__int64 (__fastcall *)(void *))unk_3C3D4C4)(off_8CEBB08);
  L_Tools_PlayerPrefs2RunTime___ctor(v8, 0, 0);
  v9 = **((_QWORD **)off_8CE9C48 + 23);
  if ( v9 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  LocalData = L_Tools_GameTest_LTPlayerPrefsDataManager__ReLoadLocalData(v9, 0);
  if ( v8 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  L_Tools_PlayerPrefs2RunTime__Init(v8, LocalData, 0);
  XXX = L_Tools_PlayerPrefs2RunTime__GetXXX(v8, 0);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (DataModule_DataCompareMgr__CheckSaveUserID(XXX, 1, XXX) & 1) != 0 )
  {
    v12 = *(_QWORD *)(v3 + 32);
    if ( v12 != 0 )
LABEL_26:
      (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v12 + 24))(*(_QWORD *)(v12 + 64), 2, *(_QWORD *)(v12 + 40));
  }
  else
  {
    v13 = *(_DWORD *)(v3 + 40);
    if ( v13 == 1 )
    {
      if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
        il2cpp_codegen_runtime_class_init(off_8CE6548);
      ToolModule_DebugExtend__LogCompareError(qword_8D86358, 0);
      v12 = *(_QWORD *)(v3 + 32);
      if ( v12 == 0 )
        goto LABEL_27;
      goto LABEL_26;
    }
    if ( v13 != 0 )
    {
      **((_BYTE **)off_8CEA258 + 23) = 1;
      DataModule_DataCompareMgr__RequestServerData(v3);
      goto LABEL_28;
    }
    if ( *((_DWORD *)off_8CE6548 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE6548);
    ToolModule_DebugExtend__LogCompareError(qword_8D86360, 0);
    v14 = *(_QWORD *)(v3 + 32);
    if ( v14 != 0 )
      (*(void (__fastcall **)(_QWORD, __int64, _QWORD))(v14 + 24))(*(_QWORD *)(v14 + 64), 1, *(_QWORD *)(v14 + 40));
  }
LABEL_27:
  **((_BYTE **)off_8CE6168 + 23) = 1;
LABEL_28:
  *(_DWORD *)self = -2;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
}
