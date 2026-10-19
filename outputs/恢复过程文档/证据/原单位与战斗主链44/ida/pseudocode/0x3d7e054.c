void __fastcall GameModule_RoleBehaviour__GetXZDirection(__int64 a1, float a2, double a3, float a4)
{
  __int64 transform; // x0
  float v7; // s10
  float v8; // s2
  float v9; // s11
  float v10; // s9
  float v11; // s8

  transform = UnityEngine_Component__get_transform(a1, 0);
  if ( transform == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  LODWORD(v7) = COERCE_UNSIGNED_INT128(UnityEngine_Transform__get_position(transform, 0));
  v9 = v8;
  if ( byte_8FFCFFC == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEA738);
    byte_8FFCFFC = 1;
  }
  v10 = a2 - v7;
  v11 = a4 - v9;
  if ( *((_DWORD *)off_8CEA738 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEA738);
  if ( sqrtf((float)(v11 * v11) + (float)((float)(v10 * v10) + 0.0)) <= 0.00001 && byte_8FFCFFD == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEF3D8);
    byte_8FFCFFD = 1;
  }
}
