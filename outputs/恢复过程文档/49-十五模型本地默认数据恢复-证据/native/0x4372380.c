void DataModule_PlayerGuideData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20

  if ( (byte_9000734 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF5F0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA060);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F6A0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE438);
    byte_9000734 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9E48, method);
  System_Collections_Generic_Dictionary_object__int____ctor(v3, qword_8CFEA38);
  *((_QWORD *)self + 3) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE438);
  System_Collections_Generic_List_object____ctor(v4, qword_8D0F6A0);
  *((_QWORD *)self + 4) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDA060);
  System_Collections_Generic_Dictionary_object__object____ctor(v5, qword_8CFF5F0);
  *((_QWORD *)self + 5) = v5;
  ServerBaseData___ctor(self, 0);
}
