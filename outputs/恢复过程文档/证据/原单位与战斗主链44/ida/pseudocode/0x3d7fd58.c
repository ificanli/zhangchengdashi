__int64 __fastcall GameModule_RoleBehaviour__ResolveAnimationBehaviour(__int64 a1)
{
  __int64 Component_object; // x20
  __int64 v4; // x19

  if ( (byte_8FFD454 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25E18);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D25FE8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEB3E0);
    byte_8FFD454 = 1;
  }
  Component_object = UnityEngine_Component__GetComponent_object_(a1, qword_8D25E18);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(Component_object, 0, 0) & 1) != 0 )
    return Component_object;
  v4 = UnityEngine_Component__GetComponent_object_(a1, qword_8D25FE8);
  if ( *((_DWORD *)off_8CEB3E0 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEB3E0);
  if ( (UnityEngine_Object__op_Inequality(v4, 0, 0) & 1) != 0 )
    return v4;
  else
    return 0;
}
