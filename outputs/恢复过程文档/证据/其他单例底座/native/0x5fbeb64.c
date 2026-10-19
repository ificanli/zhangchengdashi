void *QuickTutor_Singleton_object___get_Instance(const MethodInfo *method)
{
  __int64 v2; // x0
  __int64 v3; // x0
  __int64 v4; // x0
  __int64 v5; // x0
  __int64 v6; // x20
  __int64 v7; // x0

  v2 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v2 + 309) & 1) == 0 )
    v2 = ((__int64 (*)(void))unk_3C503A0)();
  v3 = *(_QWORD *)(*(_QWORD *)(v2 + 192) + 16LL);
  if ( (*(_BYTE *)(v3 + 309) & 1) == 0 )
    v3 = ((__int64 (*)(void))unk_3C503A0)();
  if ( *(_DWORD *)(v3 + 224) == 0 )
    il2cpp_codegen_runtime_class_init((void *)v3);
  v4 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v4 + 309) & 1) == 0 )
    v4 = ((__int64 (*)(void))unk_3C503A0)();
  v5 = *(_QWORD *)(*(_QWORD *)(v4 + 192) + 16LL);
  if ( (*(_BYTE *)(v5 + 309) & 1) == 0 )
    v5 = ((__int64 (*)(void))unk_3C503A0)();
  v6 = **(_QWORD **)(v5 + 184);
  if ( v6 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v7 = *((_QWORD *)method + 4);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (*)(void))unk_3C503A0)();
  return System_Lazy_object___get_Value(v6, *(_QWORD *)(*(_QWORD *)(v7 + 192) + 24LL));
}
