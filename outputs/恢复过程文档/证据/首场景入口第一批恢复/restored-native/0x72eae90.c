void GameFramework_Base_IGameStart__InitConfigOver(void *self, const MethodInfo *method)
{
  _BYTE *v2; // x0

  v2 = *((_BYTE **)self + 4);
  if ( v2 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v2[72] = 1;
  GameFramework_Base_GameStartEntry______V_(v2, method);
}
