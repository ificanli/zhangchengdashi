void AssetsModule_AssetsManager___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20

  if ( (byte_8FFE075 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFFA10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDC80);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9B58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA118);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12000);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEC3A0);
    byte_8FFE075 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9B58, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFDC80);
  *((_QWORD *)self + 4) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA118);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFFA10);
  *((_QWORD *)self + 7) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CEC3A0);
  System_Threading_ReaderWriterLockSlim___ctor(v5, 1, 0);
  *((_QWORD *)self + 8) = v5;
  *((_BYTE *)self + 120) = 1;
  *((_DWORD *)self + 31) = 1067030938;
  ToolModule_ManagerBase_object____ctor(self, (const MethodInfo *)qword_8D12000);
}
