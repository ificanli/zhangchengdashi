void DataModule_PlayerCustomizationData___ctor(void *self, const MethodInfo *method)
{
  if ( (byte_9000733 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53728);
    byte_9000733 = 1;
  }
  *((_WORD *)self + 8) = 257;
  *((_BYTE *)self + 18) = 1;
  *((_QWORD *)self + 4) = qword_8D53728;
  ServerBaseData___ctor(self, 0);
}
