void EventModule_EventManager___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20

  if ( (byte_8FFE060 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDB60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9B18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12140);
    byte_8FFE060 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9B18, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFDB60);
  *((_QWORD *)self + 4) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9B18);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFDB60);
  *((_QWORD *)self + 5) = v4;
  ToolModule_ManagerBase_object____ctor(self, qword_8D12140);
}
