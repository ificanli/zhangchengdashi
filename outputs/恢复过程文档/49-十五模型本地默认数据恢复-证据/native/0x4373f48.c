void DataModule_PlayerResourceData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20

  if ( (byte_9000740 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF580);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA050);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F4B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE3F0);
    byte_9000740 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDE3F0, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0F4B0);
  *((_QWORD *)self + 2) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA050);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFF580);
  *((_QWORD *)self + 3) = v4;
  ServerBaseData___ctor(self, 0);
}
