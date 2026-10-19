void _____d____ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x20

  if ( (byte_9009ED7 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D10170);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D101D0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE620);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CDE610);
    byte_9009ED7 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CDE610, method);
  System_Collections_Generic_List_object____ctor(v3, qword_8D10170);
  *((_QWORD *)self + 2) = v3;
  *((_BYTE *)self + 28) = 1;
  *((_QWORD *)self + 4) = 0x200000000003LL;
  v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CDE620);
  System_Collections_Generic_List__bv_C_____ctor(v4, qword_8D101D0);
  *((_QWORD *)self + 6) = v4;
  System_Object___ctor(self, 0);
}
