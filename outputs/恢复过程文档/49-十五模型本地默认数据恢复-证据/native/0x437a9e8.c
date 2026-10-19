void DataModule_PlayerWorldCupActivityData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20

  if ( (byte_9000786 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0FC88);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE518);
    byte_9000786 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD96C8, method);
  System_Collections_Generic_Dictionary_int__int____ctor(v3, qword_8CFC8D0);
  *((_QWORD *)self + 4) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v4, qword_8CFC8D0);
  *((_QWORD *)self + 5) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE518);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0FC88);
  *((_QWORD *)self + 8) = v5;
  ServerBaseData___ctor(self, 0);
}
