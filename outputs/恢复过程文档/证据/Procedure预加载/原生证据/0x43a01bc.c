void ljzs_lt_Procedure_ProcedurePreLoad__PreLoadAsync_d__4__MoveNext(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x21
  void *v5; // x0
  const MethodInfo *v6; // x1
  void *Instance; // x0
  void *v8; // x21
  __int64 gameObject; // x22
  __int64 v10; // x21
  __int64 v11; // x1
  __int64 v12; // x22
  __int64 v13; // x8
  __int64 v14; // x9
  int *v15; // x10
  __int64 v16; // x0
  __int64 v17; // x8
  __int64 v18; // x9
  _DWORD *v19; // x10
  __int64 v20; // x0
  __int64 v21; // x0
  __int64 v22; // x0
  __int64 v23; // x21
  __int64 v24; // x22
  __int64 v25; // x21
  __int64 v26; // x20
  __int64 v27; // x0
  __int64 AppChannelGroup; // x20
  __int64 v29; // x8
  __int64 v30; // x8
  __int64 v31; // x0
  __int128 v32; // [xsp+0h] [xbp-50h] BYREF

  if ( (byte_90008CC & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8488);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE40C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D224C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D2F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEA1F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12008);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36040);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4C98);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D5DBB0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7F358);
    byte_90008CC = 1;
  }
  v32 = 0u;
  v3 = *((_QWORD *)self + 5);
  if ( *(_DWORD *)self != 0 )
  {
    v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CF4C98, method);
    v5 = (void *)System_Object___ctor(v4, 0);
    *((_QWORD *)self + 6) = v4;
    if ( v3 == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    ljzs_lt_Procedure_ProcedurePreLoad__InitGameSetting(v5, v6);
    Instance = ToolModule_ManagerBase_object___get_Instance((const MethodInfo *)qword_8D12008);
    v8 = Instance;
    if ( Instance == nullptr )
      il2cpp_codegen_raise_null_reference_exception();
    gameObject = UnityEngine_Component__get_gameObject(Instance, 0);
    if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEB3E0);
    UnityEngine_Object__DontDestroyOnLoad(gameObject, 0);
    v10 = (*(__int64 (__fastcall **)(void *, _QWORD))(*(_QWORD *)v8 + 376LL))(v8, *(_QWORD *)(*(_QWORD *)v8 + 384LL));
    v12 = v11;
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    *(_QWORD *)&v32 = v10;
    *((_QWORD *)&v32 + 1) = v12;
    if ( byte_8FFD1AD == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEDF8);
      byte_8FFD1AD = 1;
    }
    if ( *((_DWORD *)off_8CEEDF8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CEEDF8);
    if ( byte_8FFD1AE == 0 )
    {
      il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
      byte_8FFD1AE = 1;
    }
    if ( (_QWORD)v32 != 0 )
    {
      v13 = *(_QWORD *)v32;
      v14 = *(unsigned __int16 *)(*(_QWORD *)v32 + 302LL);
      if ( *(_WORD *)(*(_QWORD *)v32 + 302LL) != 0 )
      {
        v15 = (int *)(*(_QWORD *)(v13 + 176) + 8LL);
        while ( *((_QWORD *)v15 - 1) != qword_8CE91C8 )
        {
          --v14;
          v15 += 4;
          if ( v14 == 0 )
            goto LABEL_21;
        }
        v16 = v13 + 16LL * *v15 + 312;
      }
      else
      {
LABEL_21:
        v16 = ((__int64 (__fastcall *)(_QWORD, __int64, _QWORD))unk_3C504A4)(v32, qword_8CE91C8, 0);
      }
      if ( (*(unsigned int (__fastcall **)(_QWORD, _QWORD, _QWORD))v16)(v32, WORD4(v32), *(_QWORD *)(v16 + 8)) == 0 )
      {
        *(_DWORD *)self = 0;
        *(_OWORD *)((char *)self + 56) = v32;
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__ProcedurePreLoad__PreLoadAsync_d__4_(
          (char *)self + 8,
          &v32,
          self,
          qword_8D224C8);
        return;
      }
    }
  }
  else
  {
    v32 = *(_OWORD *)((char *)self + 56);
    *((_QWORD *)self + 7) = 0;
    *((_QWORD *)self + 8) = 0;
    *(_DWORD *)self = -1;
  }
  if ( byte_8FFD1AF == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE91C8);
    byte_8FFD1AF = 1;
  }
  if ( (_QWORD)v32 != 0 )
  {
    v17 = *(_QWORD *)v32;
    v18 = *(unsigned __int16 *)(*(_QWORD *)v32 + 302LL);
    if ( *(_WORD *)(*(_QWORD *)v32 + 302LL) != 0 )
    {
      v19 = (_DWORD *)(*(_QWORD *)(v17 + 176) + 8LL);
      while ( *((_QWORD *)v19 - 1) != qword_8CE91C8 )
      {
        --v18;
        v19 += 4;
        if ( v18 == 0 )
          goto LABEL_32;
      }
      v20 = v17 + 16LL * (*v19 + 2) + 312;
    }
    else
    {
LABEL_32:
      v20 = ((__int64 (__fastcall *)(_QWORD, __int64, __int64))unk_3C504A4)(v32, qword_8CE91C8, 2);
    }
    (*(void (__fastcall **)(_QWORD, _QWORD, _QWORD))v20)(v32, WORD4(v32), *(_QWORD *)(v20 + 8));
  }
  v21 = LocalizationModule_Runtime_CustomBundlesManager__get_Instance(0);
  if ( v21 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v22 = LocalizationModule_Runtime_CustomBundlesManager__Preload(v21, 0);
  Cysharp_Threading_Tasks_UniTaskExtensions__Forget(v22);
  v23 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B80);
  UnityEngine_GameObject___ctor(v23, qword_8D5DBB0, 0);
  if ( v23 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  UnityEngine_GameObject__AddComponent_object_(v23, qword_8D2D2F0);
  v24 = *((_QWORD *)self + 6);
  v25 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8488);
  System_Action_int____ctor(v25, v3, qword_8D36040, 0);
  v26 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEA1F0);
  L_Tools_LoginControl___ctor(v26, v25, 0);
  if ( v24 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v24 + 16) = v26;
  v27 = **((_QWORD **)off_8CE40C0 + 23);
  if ( v27 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  AppChannelGroup = DBTSDK_AppInfoManager__GetAppChannelGroup(v27, 0);
  if ( (System_String__IsNullOrEmpty(AppChannelGroup, 0) & 1) == 0 )
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__Log(AppChannelGroup, 0);
    if ( AppChannelGroup == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( System_String__ToLower(AppChannelGroup, 0) == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    if ( (System_String__Contains() & 1) != 0 )
    {
      v29 = *((_QWORD *)self + 6);
      if ( v29 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      v30 = *(_QWORD *)(v29 + 16);
      if ( v30 == 0 )
        il2cpp_codegen_raise_null_reference_exception();
      *(_BYTE *)(v30 + 40) = 0;
      *(_BYTE *)(v30 + 81) = 0;
    }
  }
  v31 = *((_QWORD *)self + 6);
  if ( v31 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  *(_QWORD *)(v31 + 24) = 0;
  ljzs_lt_Procedure_ProcedurePreLoad___c__DisplayClass4_0___PreLoadAsync_g__TryLogin_0();
  *((_QWORD *)self + 6) = 0;
  *(_DWORD *)self = -2;
  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult((char *)self + 8, 0);
}
