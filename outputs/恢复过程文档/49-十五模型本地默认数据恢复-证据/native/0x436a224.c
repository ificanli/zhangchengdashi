void DataModule_SeasonData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20

  if ( (byte_90006F9 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF258);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF240);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9FC8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9FC0);
    byte_90006F9 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9FC0, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFF240);
  *((_QWORD *)self + 5) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9FC8);
  System_Collections_Generic_Dictionary_object__object____ctor(v4, qword_8CFF258);
  *((_QWORD *)self + 7) = v4;
  System_Object___ctor(self, 0);
}
