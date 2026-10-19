void *Oke____i__B__(void *bytes, const MethodInfo *method)
{
  __int64 v3; // x0
  __int64 v4; // x19
  __int64 Default; // x0

  if ( (byte_90091C4 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D778E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D4ECC0);
    byte_90091C4 = 1;
  }
  v3 = GameFramework_Tools_UIGradientBlender__SplitColors(bytes, qword_8D778E8, 0);
  if ( v3 == 0 )
    return (void *)qword_8D4ECC0;
  v4 = v3;
  Default = System_Text_Encoding__get_Default(0);
  if ( Default == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (*(void *(__fastcall **)(__int64, __int64, _QWORD))(*(_QWORD *)Default + 888LL))(
           Default,
           v4,
           *(_QWORD *)(*(_QWORD *)Default + 896LL));
}
