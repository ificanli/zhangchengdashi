void GameModule_GameManager__LoadEnd(void *self, void *obj, const MethodInfo *method)
{
  __int64 Instance; // x0

  if ( (byte_8FFD89E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D12148);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D690B8);
    byte_8FFD89E = 1;
  }
  if ( *((_BYTE *)self + 33) != 0 )
  {
    Instance = ToolModule_ManagerBase_object___get_Instance(qword_8D12148, obj, method);
    if ( Instance == 0 )
      il2cpp_codegen_raise_null_reference_exception();
    EventModule_EventManager__TriggerEvent(Instance, qword_8D690B8, 0, 0);
  }
}
