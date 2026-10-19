void *GameFramework_Tools_UIGradientBlender____F__X(void *str, const MethodInfo *method)
{
  __int64 Unicode; // x0

  Unicode = System_Text_Encoding__get_Unicode(0, method);
  if ( Unicode == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  return (*(void *(__fastcall **)(__int64, void *, _QWORD))(*(_QWORD *)Unicode + 600LL))(
           Unicode,
           str,
           *(_QWORD *)(*(_QWORD *)Unicode + 608LL));
}
