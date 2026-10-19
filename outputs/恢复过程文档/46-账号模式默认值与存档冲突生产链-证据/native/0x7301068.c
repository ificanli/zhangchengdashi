void GameFramework_Login_ILoginProcedure__set_accountType(int mode, const MethodInfo *method)
{
  _DWORD **v3; // x0

  if ( (byte_900A19D & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE8C58);
    byte_900A19D = 1;
  }
  v3 = (_DWORD **)off_8CE8C58;
  if ( *((_DWORD *)off_8CE8C58 + 56) == 0 )
  {
    il2cpp_codegen_runtime_class_init(off_8CE8C58);
    v3 = (_DWORD **)off_8CE8C58;
  }
  *v3[23] = mode;
}
