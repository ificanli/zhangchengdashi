void GameFramework_Utility_AssemblyUtility___cctor(const MethodInfo *method)
{
  __int64 v1; // x19

  if ( (byte_900965E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF6750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFDFE0);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9C08);
    byte_900965E = 1;
  }
  v1 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9C08);
  System_Collections_Generic_Dictionary_object__object____ctor(v1, qword_8CFDFE0);
  **((_QWORD **)off_8CF6750 + 23) = v1;
}
