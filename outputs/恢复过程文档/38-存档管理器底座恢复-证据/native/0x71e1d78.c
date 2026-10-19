void *GameFramework_Utility_AssemblyUtility__LoadCSharpAssembly(const MethodInfo *method)
{
  const MethodInfo *v1; // x1
  void *Assembly; // x19

  if ( (byte_900965D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CF6750);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE64E8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D86710);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D56B20);
    byte_900965D = 1;
  }
  if ( *((_DWORD *)off_8CF6750 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CF6750);
  Assembly = GameFramework_Utility_AssemblyUtility__LoadAssembly((void *)qword_8D56B20, v1);
  if ( (System_Reflection_Assembly__op_Equality(0, Assembly, 0) & 1) != 0 )
  {
    if ( *((_DWORD *)off_8CE64E8 + 56) == 0 )
      il2cpp_codegen_runtime_class_init(off_8CE64E8);
    UnityEngine_Debug__LogError(qword_8D86710, 0);
    return nullptr;
  }
  return Assembly;
}
