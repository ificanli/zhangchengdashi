void ljzs_lt_Procedure_ProcedurePreLoad__OnEnter(void *self, void *owner, const MethodInfo *method)
{
  GameFramework_Procedure_ProcedureBase__OnEnter(self, owner, 0);
  ljzs_lt_Procedure_ProcedurePreLoad__PreLoad(self);
}
