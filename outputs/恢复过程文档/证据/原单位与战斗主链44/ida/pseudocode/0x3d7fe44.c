__int64 __fastcall GameModule_RoleBehaviour__GetAnimationDriverType(__int64 a1)
{
  __int64 Component_object; // x19

  if ( (byte_8FFD455 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25E18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD455 = 1;
  }
  Component_object = UnityEngine_Component__GetComponent_object_(a1, qword_8D25E18);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  return UnityEngine_Object__op_Inequality(Component_object, 0, 0) & 1;
}
