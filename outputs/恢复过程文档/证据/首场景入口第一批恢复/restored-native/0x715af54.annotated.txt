void GameFramework_GameFrameEntry__Initialize(void *module, void *callback, void *args, const MethodInfo *method)
{
  __int64 v4; // x8

  if ( module == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = *(_QWORD *)module;
  *((_QWORD *)module + 3) = callback;
  (*(void (__fastcall **)(void *, void *, _QWORD))(v4 + 392))(module, args, *(_QWORD *)(v4 + 400));
}
