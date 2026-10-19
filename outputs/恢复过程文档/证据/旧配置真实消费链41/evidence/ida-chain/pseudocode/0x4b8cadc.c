void stage41_GameFramework_ConfigRead__readConfigByUnityJson_object_(void *a0, void *a1)
{
  __int64 *v2; // x8
  __int64 v5; // x21
  __int64 TypeFromHandle; // x0
  __int64 v7; // x21
  __int64 it_W; // x0

  v2 = *((__int64 **)a1 + 7);
  if ( v2 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CE5BB8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    v2 = *((__int64 **)a1 + 7);
    if ( v2 == nullptr )
    {
      ((void (__fastcall *)(void *))unk_3C503FC)(a1);
      v2 = *((__int64 **)a1 + 7);
    }
  }
  v5 = *v2;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  if ( TypeFromHandle == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  v7 = (*(__int64 (__fastcall **)(__int64, _QWORD))(*(_QWORD *)TypeFromHandle + 440LL))(
         TypeFromHandle,
         *(_QWORD *)(*(_QWORD *)TypeFromHandle + 448LL));
  if ( *((_DWORD *)off_8CE5BB8 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CE5BB8);
  it_W = GameFramework_ConfigRead____it_W(v7, 0);
  GameFramework_ConfigRead__A____i_object_(a0, it_W, v7, 1, *(_QWORD *)(*((_QWORD *)a1 + 7) + 16LL));
  ++*(_DWORD *)(*((_QWORD *)off_8CE5BB8 + 23) + 36LL);
}
