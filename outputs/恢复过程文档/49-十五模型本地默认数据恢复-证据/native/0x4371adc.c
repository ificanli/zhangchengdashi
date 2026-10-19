void DataModule_PlayerCoreData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_900072F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE288);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C90);
    byte_900072F = 1;
  }
  ServerBaseData__Init(self, 0);
  if ( *((_QWORD *)self + 23) == 0 )
  {
    v3 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C90);
    System_Collections_Generic_Dictionary_object__object____ctor(v3, qword_8CFE288);
    *((_QWORD *)self + 23) = v3;
  }
}
