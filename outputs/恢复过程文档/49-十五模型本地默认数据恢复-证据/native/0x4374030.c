void DataModule_PlayerShopData__InitFromDefaults(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20

  if ( (byte_9000741 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0B638);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDD8C0);
    byte_9000741 = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  *((_BYTE *)self + 128) = 1;
  v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDD8C0);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0B638);
  *((_QWORD *)self + 20) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v4, qword_8CFEA38);
  *((_QWORD *)self + 27) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v5, qword_8CFC8D0);
  *((_QWORD *)self + 21) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
  System_Collections_Generic_Dictionary_object__int____ctor(v6, qword_8CFEA38);
  *((_QWORD *)self + 12) = v6;
  *((_WORD *)self + 128) = 257;
}
