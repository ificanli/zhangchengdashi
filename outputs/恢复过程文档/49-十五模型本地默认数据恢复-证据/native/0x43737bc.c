void DataModule_PlayerRankData___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_900073C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0D768);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDDEF0);
    byte_900073C = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDDEF0, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D0D768);
  *((_QWORD *)self + 2) = v3;
  ServerBaseData___ctor(self, 0);
}
