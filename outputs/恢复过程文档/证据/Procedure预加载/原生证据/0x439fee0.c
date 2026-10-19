void ljzs_lt_Procedure_ProcedurePreLoad___c__DisplayClass4_0___PreLoadAsync_g__TryLogin_0(
        void *self,
        const MethodInfo *method)
{
  __int64 v3; // x20
  __int64 v4; // x21

  if ( (byte_90008CA & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CD8378);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D497E8);
    byte_90008CA = 1;
  }
  v3 = *((_QWORD *)self + 2);
  v4 = ((__int64 (__fastcall *)(__int64, const MethodInfo *))unk_3C3D4C4)(qword_8CD8378, method);
  System_Action_bool____ctor(v4, self, qword_8D497E8, 0);
  if ( v3 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  L_Tools_LoginControl__Login(v3, v4, 0, 0);
}
