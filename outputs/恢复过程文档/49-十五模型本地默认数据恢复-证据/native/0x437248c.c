void DataModule_PlayerMainCityData__InitFromDefaults(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_9000735 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFEA38);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E48);
    byte_9000735 = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  if ( *((_QWORD *)self + 2) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E48);
    System_Collections_Generic_Dictionary_object__int____ctor(v3, qword_8CFEA38);
    *((_QWORD *)self + 2) = v3;
  }
}
