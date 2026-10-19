void CommonGameModule_Debugger_UGUI_QualityInformationWindowUGUI___ctor(
        void *self,
        void *arg0,
        const MethodInfo *method)
{
  __int64 v5; // x0
  __int64 v6; // x21
  __int64 v7; // x22
  __int64 v8; // x23
  __int64 v9; // x24
  __int64 names; // x0
  __int64 v11; // x0
  unsigned __int64 v12; // x28
  __int64 v13; // x21
  unsigned int *v14; // x26
  __int64 v15; // x0
  __int64 v16; // x23
  __int64 v17; // x22
  __int64 v18; // x24
  __int64 v19; // x21
  __int64 v20; // x0
  unsigned int QualityLevel; // w0
  __int64 v22; // x0

  if ( (byte_9001E21 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D36420);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE3640);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEE690);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D49958);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF4D30);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56480);
    byte_9001E21 = 1;
  }
  CommonGameModule_Debugger_UGUI_BaseInformationWindowUGUI___ctor(self, arg0, method);
  if ( arg0 == nullptr )
    goto LABEL_16;
  v5 = CommonGameModule_Debugger_UGUI_InformationWindowUGUI__AddButton(arg0, qword_8D56480, 0);
  v6 = **((_QWORD **)off_8CEDAE8 + 23);
  v7 = v5;
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8378);
  System_Action_bool____ctor(v8, self, qword_8D36420, 0);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEE690);
  CommonGameModule_Debugger_UGUI_ToggleBtn___ctor(v9, v7, 0, v6, v8);
  *((_QWORD *)self + 6) = v9;
  names = UnityEngine_QualitySettings__get_names(0);
  if ( names == 0
    || (v11 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D320)(qword_8CE3640, *(unsigned int *)(names + 24)),
        *((_QWORD *)self + 7) = v11,
        v11 == 0) )
  {
LABEL_16:
    il2cpp_codegen_raise_null_reference_exception();
  }
  v12 = 0;
  while ( (__int64)v12 < *(int *)(v11 + 24) )
  {
    v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CF4D30);
    System_Object___ctor(v13, 0);
    if ( v13 == 0 )
      goto LABEL_16;
    *(_QWORD *)(v13 + 24) = self;
    *(_DWORD *)(v13 + 16) = v12;
    v14 = *((unsigned int **)self + 7);
    v15 = UnityEngine_QualitySettings__get_names(0);
    if ( v15 == 0 )
      goto LABEL_16;
    if ( v12 >= *(unsigned int *)(v15 + 24) )
      goto LABEL_18;
    v16 = CommonGameModule_Debugger_UGUI_InformationWindowUGUI__AddButton(arg0, *(_QWORD *)(v15 + 8 * v12 + 32), 0);
    v17 = **((_QWORD **)off_8CEDAE8 + 23);
    v18 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD8378);
    System_Action_bool____ctor(v18, v13, qword_8D49958, 0);
    v19 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEE690);
    CommonGameModule_Debugger_UGUI_ToggleBtn___ctor(v19, v16, 0, v17, v18);
    if ( v14 == nullptr )
      goto LABEL_16;
    if ( v19 != 0 )
    {
      v20 = ((__int64 (__fastcall *)(__int64, _QWORD))unk_3C3D3B4)(v19, *(_QWORD *)(*(_QWORD *)v14 + 64LL));
      if ( v20 == 0 )
        goto LABEL_19;
    }
    if ( v12 >= v14[6] )
    {
LABEL_18:
      v20 = ((__int64 (*)(void))unk_3C3D4D4)();
LABEL_19:
      v22 = ((__int64 (__fastcall *)(__int64))unk_3C3D4F0)(v20);
      ((void (__fastcall *)(__int64, _QWORD))unk_3C3D3A0)(v22, 0);
      JUMPOUT(0x468CE00);
    }
    *(_QWORD *)&v14[2 * v12 + 8] = v19;
    v11 = *((_QWORD *)self + 7);
    ++v12;
    if ( v11 == 0 )
      goto LABEL_16;
  }
  QualityLevel = UnityEngine_QualitySettings__GetQualityLevel(0);
  CommonGameModule_Debugger_UGUI_QualityInformationWindowUGUI__OnSelectQuality(self, QualityLevel);
  *((_BYTE *)self + 32) = 0;
}
