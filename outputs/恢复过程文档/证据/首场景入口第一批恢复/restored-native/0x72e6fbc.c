void GameFramework_Base_GameStartEntry__J_K_M_(void *self, const MethodInfo *method)
{
  __int64 v3; // x0
  char IsSupportLogStatic; // w20
  __int64 v5; // x0
  _QWORD *v6; // x0
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 Instance; // x0
  __int64 Module_object; // x0
  __int64 v11; // x0

  if ( (byte_900A040 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5250);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2D158);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7B30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE7D40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEC810);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CECCD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D884D8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D60ED0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D87980);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D884C8);
    byte_900A040 = 1;
  }
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  GameFramework_GameFrameEntry__Start(0, method);
  GameFramework_Base_GameStartEntry____M_a_(self, qword_8D87980);
  if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7D40);
  if ( (GameFramework_GlobalData__get_IsReleaseVersion(0) & 1) != 0 )
  {
    v3 = **((_QWORD **)off_8CECCD8 + 23);
    if ( v3 == 0 )
      goto LABEL_31;
    IsSupportLogStatic = DBTSDK_SDKToolManager__IsSupportLogStatic(v3, 0);
  }
  else
  {
    IsSupportLogStatic = 1;
  }
  if ( *((_DWORD *)off_8CE5250 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5250);
  GameFramework_CLog__SetIsShowLog(IsSupportLogStatic & 1, 0);
  if ( *((_DWORD *)off_8CE7D40 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7D40);
  if ( (GameFramework_GlobalData__get_IsReleaseVersion(0) & 1) != 0 )
  {
    if ( (IsSupportLogStatic & 1) != 0 )
    {
      v5 = **((_QWORD **)off_8CECCD8 + 23);
      if ( v5 == 0 )
        goto LABEL_31;
      DBTSDK_SDKToolManager__ShowToast(v5, qword_8D884D8, 0);
      v6 = off_8CEC810;
      if ( *((_DWORD *)off_8CEC810 + 56) == 0 )
      {
        il2cpp_codegen_runtime_class_init(off_8CEC810);
        v6 = off_8CEC810;
      }
      v7 = *(_QWORD *)(v6[23] + 8LL);
      if ( v7 == 0 )
LABEL_31:
        il2cpp_codegen_raise_null_reference_exception();
      DBTSDK_ReportManager__ReportGMLogOpen(v7, 0);
    }
  }
  else if ( (GameFramework_NewResLoadHelper__GetIsDeepObf(0) & 1) != 0 )
  {
    v8 = **((_QWORD **)off_8CECCD8 + 23);
    if ( v8 == 0 )
      goto LABEL_31;
    DBTSDK_SDKToolManager__ShowToast(v8, qword_8D884C8, 0);
  }
  Instance = GamePath__get_Instance(0);
  if ( Instance == 0 )
    goto LABEL_31;
  GamePath__FindMineGamePath(Instance, 0);
  *((_BYTE *)self + 74) = 1;
  if ( *((_DWORD *)off_8CE7B30 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE7B30);
  Module_object = GameFramework_GameFrameEntry__GetModule_object_(qword_8D2D158);
  if ( Module_object == 0 )
    goto LABEL_31;
  GameFramework_LangModule__SetLocalLangLibrary(
    Module_object,
    *((unsigned int *)self + 16),
    *((unsigned int *)self + 17),
    0);
  sub_7185594(qword_8D60ED0, 0);
  v11 = *((_QWORD *)self + 10);
  if ( v11 == 0 )
    goto LABEL_31;
  (*(void (__fastcall **)(__int64, _QWORD))(*(_QWORD *)v11 + 376LL))(v11, *(_QWORD *)(*(_QWORD *)v11 + 384LL));
}
