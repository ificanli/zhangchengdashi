void *GameFramework_Tools_UIGradientBlender__hG_j_________(void *key, const MethodInfo *method)
{
  void *v3; // x20

  if ( (byte_9009AEA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE36B0);
    byte_9009AEA = 1;
  }
  if ( key == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  if ( *((int *)key + 6) <= 3 )
  {
    v3 = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D320)(qword_8CE36B0, 4);
    System_Array__CopyTo(key, v3, 0, 0);
    return v3;
  }
  return key;
}
