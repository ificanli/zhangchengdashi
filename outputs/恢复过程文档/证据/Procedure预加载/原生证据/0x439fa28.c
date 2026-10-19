void ljzs_lt_Procedure_ProcedurePreLoad__InitGameSetting(void *self, const MethodInfo *method)
{
  __int64 CultureInfo; // x0
  __int64 v3; // x0
  __int64 CurrentThread; // x19
  __int64 v5; // x0
  __int64 v6; // x19
  __int64 v7; // x0

  if ( (byte_90008C8 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5F18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA0B8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D7DCC8);
    byte_90008C8 = 1;
  }
  if ( *((_DWORD *)off_8CEA0B8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA0B8);
  I2_Loc_LocalizationManager__EnableChangingCultureInfo(0, 0);
  LocalizationModule_StartupLanguageHelper__EnsureStartupLanguage(0);
  if ( *((_DWORD *)off_8CE5F18 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5F18);
  CultureInfo = System_Globalization_CultureInfo__GetCultureInfo(qword_8D7DCC8, 0);
  System_Globalization_CultureInfo__set_DefaultThreadCurrentCulture(CultureInfo, 0);
  v3 = System_Globalization_CultureInfo__GetCultureInfo(qword_8D7DCC8, 0);
  System_Globalization_CultureInfo__set_DefaultThreadCurrentUICulture(v3, 0);
  CurrentThread = System_Threading_Thread__get_CurrentThread(0);
  v5 = System_Globalization_CultureInfo__GetCultureInfo(qword_8D7DCC8, 0);
  if ( CurrentThread == 0
    || (System_Threading_Thread__set_CurrentCulture(CurrentThread, v5, 0),
        v6 = System_Threading_Thread__get_CurrentThread(0),
        v7 = System_Globalization_CultureInfo__GetCultureInfo(qword_8D7DCC8, 0),
        v6 == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  System_Threading_Thread__set_CurrentUICulture(v6, v7, 0);
  ToolModule_LitJsonExtent__Init(0);
}
