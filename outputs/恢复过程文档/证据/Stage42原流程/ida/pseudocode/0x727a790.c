// local variable allocation has failed, the output may be wrong!
void GameFramework_Procedure_ProcedureBase__OnUpdate_727a790(
        void *this,
        void *procedureOwner,
        float elapseSeconds,
        float realElapseSeconds,
        const MethodInfo *method)
{
  long double v5; // q8
  long double v6; // q9

  v5 = *(long double *)&realElapseSeconds;
  v6 = *(long double *)&elapseSeconds;
  if ( (byte_9009C2E & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D061D8);
    byte_9009C2E = 1;
  }
  GameFramework_Fsm_FsmState_object___OnUpdate(this, procedureOwner, qword_8D061D8, v6, v5);
}
