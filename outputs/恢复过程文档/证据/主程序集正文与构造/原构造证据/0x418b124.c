void TutorModule_FeatureCycleTypeUnlock___ctor(void *self, void *arg0, unsigned __int8 arg1, const MethodInfo *method)
{
  __int64 v7; // x0
  __int64 v8; // x0
  __int64 v9; // x20
  __int64 v10; // x0
  __int64 v11; // x0

  if ( (byte_8FFF687 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D2B5A0);
    byte_8FFF687 = 1;
  }
  System_Object___ctor(self, 0);
  *((_QWORD *)self + 3) = arg0;
  *((_BYTE *)self + 16) = arg1 & 1;
  if ( arg0 == nullptr || (v7 = *((_QWORD *)arg0 + 5)) == 0 || (v8 = System_String__Split(v7, 59, 0, 0)) == 0 )
LABEL_13:
    il2cpp_codegen_raise_null_reference_exception();
  v9 = v8;
  if ( *(_DWORD *)(v8 + 24) == 0
    || (*((_DWORD *)self + 8) = ToolModule_StringTool__ToInt(*(_QWORD *)(v8 + 32), 0), *(_DWORD *)(v9 + 24) <= 1u)
    || (*((_DWORD *)self + 9) = ToolModule_StringTool__ToInt(*(_QWORD *)(v9 + 40), 0), *(_DWORD *)(v9 + 24) <= 2u)
    || (*((_DWORD *)self + 10) = ToolModule_StringTool__ToInt(*(_QWORD *)(v9 + 48), 0), *(_DWORD *)(v9 + 24) <= 3u) )
  {
    ((void (*)(void))unk_3C3D4D4)();
    goto LABEL_13;
  }
  v10 = *(_QWORD *)(v9 + 56);
  if ( v10 == 0 )
    goto LABEL_13;
  v11 = System_String__Split(v10, 44, 0, 0);
  *((_QWORD *)self + 6) = System_Linq_Enumerable__ToList_object_(v11, qword_8D2B5A0);
  TutorModule_FeatureCycleTypeUnlock__LoadFromSaveData(self);
  *((_BYTE *)self + 16) = TutorModule_FeatureCycleTypeUnlock__GetIsUnlock(self) & 1;
}
