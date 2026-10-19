__int64 GameFramework_VersionMondule___cctor()
{
  __int64 v0; // x19
  __int64 result; // x0

  if ( (byte_90096EB & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE968);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD9E18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF480);
    byte_90096EB = 1;
  }
  v0 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CD9E18);
  result = System_Collections_Generic_Dictionary_object__object____ctor(v0, qword_8CFE968);
  **((_QWORD **)off_8CEF480 + 23) = v0;
  return result;
}
