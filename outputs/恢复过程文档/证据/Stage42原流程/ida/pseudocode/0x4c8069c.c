void *GameFramework_Fsm_FsmManager__CreateFsm_object__4c8069c(
        void *this,
        void *owner,
        void *states,
        const MethodInfo *method)
{
  __int64 v4; // x8

  v4 = *((_QWORD *)method + 7);
  if ( v4 == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEDAE8);
    v4 = *((_QWORD *)method + 7);
    if ( v4 == 0 )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v4 = *((_QWORD *)method + 7);
    }
  }
  return GameFramework_Fsm_FsmManager__CreateFsm_object_(
           this,
           **((_QWORD **)off_8CEDAE8 + 23),
           owner,
           states,
           *(_QWORD *)(v4 + 16));
}
