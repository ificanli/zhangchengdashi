void DataModule_PlayerAdData__Init(void *self, const MethodInfo *method)
{
  __int64 v3; // x1
  __int64 v4; // x2
  __int64 Instance; // x0
  char AdsLimitTo8On; // w0
  int v7; // w8

  if ( (byte_900070A & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D17890);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE1928);
    byte_900070A = 1;
  }
  ServerBaseData__Init(self, 0);
  if ( *((_DWORD *)off_8CE1928 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE1928);
  Instance = QuickTutor_Singleton_object___get_Instance(qword_8D17890, v3, v4);
  if ( Instance == 0 || (AdsLimitTo8On = SDKModule_ABTestManager__get_AdsLimitTo8On(Instance, 0), self == nullptr) )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (AdsLimitTo8On & 1) != 0 )
    v7 = 8;
  else
    v7 = 5;
  *((_DWORD *)self + 5) = v7;
}
