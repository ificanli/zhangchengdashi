void *Oke______dZ_x(void *bytes, void *key, const MethodInfo *method)
{
  void *v5; // x1

  if ( (byte_90091BF & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D77EF0);
    byte_90091BF = 1;
  }
  if ( (System_String__IsNullOrEmpty(key, 0) & 1) != 0 )
    v5 = (void *)qword_8D77EF0;
  else
    v5 = key;
  return GameFramework_Tools_UIGradientBlender__SplitColors(bytes, v5, nullptr);
}
