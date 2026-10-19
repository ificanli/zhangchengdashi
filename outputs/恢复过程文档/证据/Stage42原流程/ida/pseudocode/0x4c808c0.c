unsigned __int8 GameFramework_Fsm_FsmManager__DestroyFsm_object__4c808c0(void *this, const MethodInfo *method)
{
  _QWORD *v2; // x8

  v2 = *((_QWORD **)method + 7);
  if ( v2 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    v2 = *((_QWORD **)method + 7);
    if ( v2 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v2 = *((_QWORD **)method + 7);
    }
  }
  return GameFramework_Fsm_FsmManager__DestroyFsm_object_(this, **((_QWORD **)off_8CEDAE8 + 23), *v2);
}
