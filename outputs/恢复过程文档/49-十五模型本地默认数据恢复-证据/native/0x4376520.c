void DataModule_PlayerShopData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20
  __int64 v9; // x20
  __int64 v10; // x20
  __int64 v11; // x20
  __int64 v12; // x20
  __int64 v13; // x20
  __int64 v14; // x20
  __int64 v15; // x20
  __int64 v16; // x20

  if ( (byte_9000748 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B638);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0E5E0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F540);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD8C0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE408);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE178);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    byte_9000748 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDE408, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0F540);
  *((_QWORD *)self + 2) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v4, qword_8CFEA38);
  *((_QWORD *)self + 3) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v5, qword_8CFEA38);
  *((_QWORD *)self + 4) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v6, qword_8CFEA38);
  *((_QWORD *)self + 5) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v7, qword_8CFEA38);
  *((_QWORD *)self + 6) = v7;
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v8, qword_8CFEA38);
  *((_QWORD *)self + 7) = v8;
  *((_QWORD *)self + 8) = **((_QWORD **)off_8CEDAE8 + 23);
  v9 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v9, qword_8D0E5E0);
  *((_QWORD *)self + 10) = v9;
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v10, qword_8CFEA38);
  *((_QWORD *)self + 11) = v10;
  v11 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v11, qword_8CFEA38);
  *((_QWORD *)self + 12) = v11;
  v12 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE178);
  System_Collections_Generic_List_object____ctor(v12, qword_8D0E5E0);
  *((_QWORD *)self + 15) = v12;
  *((_QWORD *)self + 18) = **((_QWORD **)off_8CEDAE8 + 23);
  v13 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD8C0);
  System_Collections_Generic_List_object____ctor(v13, qword_8D0B638);
  *((_QWORD *)self + 20) = v13;
  v14 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v14, qword_8CFC8D0);
  *((_QWORD *)self + 21) = v14;
  *((_WORD *)self + 128) = 257;
  v15 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v15, qword_8CFC8D0);
  *((_QWORD *)self + 35) = v15;
  *((_DWORD *)self + 72) = -1;
  v16 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v16, qword_8CFC8D0);
  *((_QWORD *)self + 37) = v16;
  ServerBaseData___ctor(self, 0);
}
