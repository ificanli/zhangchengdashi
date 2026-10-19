void DataModule_PlayerCoreData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20

  if ( (byte_9000730 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE288);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C90);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CECFD8);
    byte_9000730 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDDA40, method);
  System_Collections_Generic_List_int____ctor(v3, qword_8D0BE60);
  *((_QWORD *)self + 12) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CECFD8);
  DataModule_SeasonData___ctor();
  *((_QWORD *)self + 18) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0E5E0);
  *((_QWORD *)self + 19) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C90);
  System_Collections_Generic_Dictionary_object__object____ctor(v6, qword_8CFE288);
  *((_QWORD *)self + 23) = v6;
  ServerBaseData___ctor(self, 0);
}
