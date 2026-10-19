void *GameFramework_ConfigRead_________object_(void *a0, void *a1)
{
  unsigned int v4; // w0
  __int64 v5; // x20

  if ( *((_QWORD *)a1 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE9A10);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D783B0);
    if ( *((_QWORD *)a1 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a1);
  }
  if ( a0 == nullptr )
    il2cpp_codegen_raise_null_reference_exception();
  v4 = System_String__IndexOf(a0, qword_8D783B0, 0);
  v5 = sub_750DE48(a0, v4, 0);
  if ( *((_DWORD *)off_8CE9A10 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE9A10);
  return (void *)LitJson_JsonMapper__ToObject_object_(v5, **((_QWORD **)a1 + 7));
}
