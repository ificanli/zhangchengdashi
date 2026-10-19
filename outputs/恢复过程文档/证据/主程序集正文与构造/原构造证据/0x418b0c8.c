void TutorModule_FeatureWeeklyUnlock___ctor(void *self, void *arg0, unsigned __int8 arg1, const MethodInfo *method)
{
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 3) = arg0;
  *((_BYTE *)self + 16) = arg1 & 1;
  if ( arg0 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  *((_DWORD *)self + 8) = ToolModule_StringTool__ToInt(*((_QWORD *)arg0 + 5), 0);
  *((_BYTE *)self + 16) = TutorModule_FeatureWeeklyUnlock__GetIsUnlock(self) & 1;
}
