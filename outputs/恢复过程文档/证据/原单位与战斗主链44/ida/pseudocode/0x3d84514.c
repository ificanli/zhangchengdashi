bool __fastcall GameModule_RoleBehaviour__get_WebGLNavigationCanSoftSeparate(_BYTE *a1)
{
  __int64 gameObject; // x0

  if ( a1[577] == 0 || a1[328] == 0 || a1[636] != 0 || a1[637] != 0 || a1[33] != 0 )
    return false;
  gameObject = UnityEngine_Component__get_gameObject(a1, 0);
  if ( gameObject == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (UnityEngine_GameObject__get_activeInHierarchy(gameObject, 0) & 1) != 0
      && a1[188] == 0
      && a1[224] == 0
      && a1[404] == 0
      && a1[592] == 0
      && a1[578] == 0;
}
