void DataModule_PlayerMysteryAdventureData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20
  __int64 v5; // x20
  __int64 v6; // x20
  __int64 v7; // x20
  __int64 v8; // x20

  if ( (byte_90006E6 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFC8D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD96C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0CC58);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0BE60);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDA40);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDCD8);
    byte_90006E6 = 1;
  }
  *((_DWORD *)self + 10) = 1;
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDDA40, method);
  System_Collections_Generic_List_int____ctor(v3, qword_8D0BE60);
  *((_QWORD *)self + 8) = v3;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
  System_Collections_Generic_List_int____ctor(v4, qword_8D0BE60);
  *((_QWORD *)self + 9) = v4;
  v5 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD96C8);
  System_Collections_Generic_Dictionary_int__int____ctor(v5, qword_8CFC8D0);
  *((_QWORD *)self + 12) = v5;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
  System_Collections_Generic_List_int____ctor(v6, qword_8D0BE60);
  *((_QWORD *)self + 13) = v6;
  v7 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDA40);
  System_Collections_Generic_List_int____ctor(v7, qword_8D0BE60);
  *((_QWORD *)self + 14) = v7;
  v8 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDDCD8);
  System_Collections_Generic_List_object____ctor(v8, qword_8D0CC58);
  *((_QWORD *)self + 20) = v8;
  ServerBaseData___ctor(self, 0);
}
