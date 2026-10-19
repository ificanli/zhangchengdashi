void *GameModule_GameManager__CheckNetworkState(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_8FFD892 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CF2ED0);
    byte_8FFD892 = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CF2ED0, method);
  System_Object___ctor(v3, 0);
  *(_DWORD *)(v3 + 16) = 0;
  *(_QWORD *)(v3 + 32) = self;
  return (void *)v3;
}
