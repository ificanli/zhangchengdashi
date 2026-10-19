void *GameFramework_Utility_Text__GetFullName___Il2CppFullySharedGenericType__511d6dc(
        void *iPJ,
        const MethodInfo *method)
{
  __int64 *v2; // x8
  __int64 v5; // x20
  __int64 TypeFromHandle; // x0

  v2 = *((__int64 **)method + 7);
  if ( v2 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    v2 = *((__int64 **)method + 7);
    if ( v2 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v2 = *((__int64 **)method + 7);
    }
  }
  v5 = *v2;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  return GameFramework_Utility_Text__GetFullName(TypeFromHandle, iPJ, 0);
}
