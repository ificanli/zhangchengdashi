void GameModule_GameManager___ctor(void *self, const MethodInfo *method)
{
  __int64 v3; // x20

  if ( (byte_8FFD89F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D121A8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CEF020);
    byte_8FFD89F = 1;
  }
  v3 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CEF020, method);
  GameModule_UpdateController___ctor(v3, 0);
  *((_QWORD *)self + 5) = v3;
  ToolModule_ManagerBase_object____ctor(self, qword_8D121A8);
}
