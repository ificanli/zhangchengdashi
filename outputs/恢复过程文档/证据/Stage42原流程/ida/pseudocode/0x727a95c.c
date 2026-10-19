void GameFramework_Procedure_ProcedureBase__OnDestroy_727a95c(
        void *this,
        void *procedureOwner,
        const MethodInfo *method)
{
  if ( (byte_9009C30 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061B8);
    byte_9009C30 = 1;
  }
  GameFramework_Fsm_FsmState_object___OnDestroy(this, procedureOwner, qword_8D061B8);
}
