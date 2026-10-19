void *GameFramework_ConfigRead____it_g_object_(void *a0, void *a1)
{
  unsigned int v4; // w0
  __int64 v5; // x0
  __int64 v6; // x0

  if ( *((_QWORD *)a1 + 7) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D85208);
    if ( *((_QWORD *)a1 + 7) == 0 )
      ((void (__fastcall *)(void *))unk_3C503FC)(a1);
  }
  if ( a0 == nullptr
    || (v4 = System_String__IndexOf(a0, qword_8D85208, 0),
        v5 = sub_750DE48(a0, v4, 0),
        (v6 = UnityEngine_JsonUtility__FromJson_object_(v5, **((_QWORD **)a1 + 7))) == 0) )
  {
    il2cpp_codegen_raise_null_reference_exception();
  }
  return *(void **)(v6 + 16);
}
