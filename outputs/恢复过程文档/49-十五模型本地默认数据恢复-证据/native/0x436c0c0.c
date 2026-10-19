void DataModule_PlayerArtifactData__InitFromDefaults(void *self, const MethodInfo *method)
{
  if ( (byte_900070E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D53EC0);
    byte_900070E = 1;
  }
  ServerBaseData__InitFromDefaults(self, 0);
  *((_QWORD *)self + 3) = qword_8D53EC0;
}
