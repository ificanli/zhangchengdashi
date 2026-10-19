void DataModule_PlayerMainCityData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20

  if ( (byte_900073A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F5F8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F568);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F670);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE420);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE410);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE430);
    byte_900073A = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD9E48, method);
  System_Collections_Generic_Dictionary_object__int____ctor(v3, qword_8CFEA38);
  *((_QWORD *)self + 2) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE420);
  System_Collections_Generic_List_object____ctor(v4, qword_8D0F5F8);
  *((_QWORD *)self + 3) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE430);
  System_Collections_Generic_List_object____ctor(v5, qword_8D0F670);
  *((_QWORD *)self + 4) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE410);
  System_Collections_Generic_List_object____ctor(v6, qword_8D0F568);
  *((_QWORD *)self + 5) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v7, qword_8CFEA38);
  *((_QWORD *)self + 9) = v7;
  ServerBaseData___ctor(self, 0);
}
