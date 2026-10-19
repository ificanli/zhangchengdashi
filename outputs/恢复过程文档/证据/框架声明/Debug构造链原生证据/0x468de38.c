void CommonGameModule_Debugger_UGUI_RuntimeMemorySummaryWindowUGUI___ctor(
        void *self,
        void *arg0,
        const MethodInfo *method)
{
  __int64 v5; // x21
  const MethodInfo *v6; // x2
  _QWORD *v7; // x0

  if ( (byte_9001E26 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE6460);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D11598);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDEA08);
    byte_9001E26 = 1;
  }
  v5 = ((__int64 (__fastcall *)(__int64, void *, const MethodInfo *))unk_3C3D4C4)(qword_8CDEA08, arg0, method);
  System_Collections_Generic_List_object____ctor(v5, qword_8D11598);
  *((_QWORD *)self + 6) = v5;
  v7 = off_8CE6460;
  if ( *((_DWORD *)off_8CE6460 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE6460);
    v7 = off_8CE6460;
  }
  *((_QWORD *)self + 7) = *(_QWORD *)(v7[23] + 16LL);
  CommonGameModule_Debugger_UGUI_BaseInformationWindowUGUI___ctor(self, arg0, v6);
}
