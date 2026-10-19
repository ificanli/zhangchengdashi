void DataModule_PlayerResourceData__InitFromDefaults(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_900073E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F4B0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE3F0);
    byte_900073E = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  if ( *((_QWORD *)self + 2) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE3F0);
    System_Collections_Generic_List_object____ctor(v3, qword_8D0F4B0);
    *((_QWORD *)self + 2) = v3;
  }
}
