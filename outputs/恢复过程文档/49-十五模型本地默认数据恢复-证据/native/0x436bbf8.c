void DataModule_PlayerArenaData__InitFromDefaults(void *self, const MethodInfo *method)
{
  __int64 v3; // x8
  __int64 v4; // x20

  if ( (byte_900070B & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0F480);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE3E8);
    byte_900070B = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  v3 = *((_QWORD *)self + 2);
  *((_DWORD *)self + 7) = 1;
  if ( v3 == 0 )
  {
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE3E8);
    System_Collections_Generic_List_object____ctor(v4, qword_8D0F480);
    *((_QWORD *)self + 2) = v4;
  }
}
