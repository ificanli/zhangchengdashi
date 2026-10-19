int GameFramework_Login_ILoginProcedure__get_accountType(const MethodInfo *method)
{
  _DWORD **v1; // x0

  if ( (byte_900A19C & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
    byte_900A19C = 1;
  }
  v1 = (_DWORD **)off_8CE8C58;
  if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE8C58);
    v1 = (_DWORD **)off_8CE8C58;
  }
  return *v1[23];
}
