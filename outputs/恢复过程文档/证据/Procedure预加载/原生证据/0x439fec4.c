void ljzs_lt_Procedure_ProcedurePreLoad__OnLeave(
        void *self,
        void *owner,
        unsigned __int8 shutdown,
        const MethodInfo *method)
{
  GameFramework_Procedure_ProcedureBase__OnLeave(self, owner, shutdown & 1, 0);
}
