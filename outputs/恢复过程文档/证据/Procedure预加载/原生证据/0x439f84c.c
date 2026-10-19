void ljzs_lt_Procedure_ProcedurePreLoad__OnInit(void *self, void *owner, const MethodInfo *method)
{
  GameFramework_Procedure_ProcedureBase__OnInit(self, owner, 0);
  *((_QWORD *)self + 3) = owner;
}
