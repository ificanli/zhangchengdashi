void DataModule_PlayerTimeData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_900074D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFF448);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDA018);
    byte_900074D = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDA018, method);
  System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFF448);
  *((_QWORD *)self + 2) = v3;
  ServerBaseData___ctor(self, 0);
}
