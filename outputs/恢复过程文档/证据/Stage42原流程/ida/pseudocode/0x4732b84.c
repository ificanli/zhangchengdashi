void GameFramework_Fsm_Fsm_object___Start_object__4732b84(void *this, void *args, const MethodInfo *method)
{
  __int64 *v3; // x8
  __int64 v7; // x22
  __int64 TypeFromHandle; // x1

  v3 = *((__int64 **)method + 7);
  if ( v3 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    v3 = *((__int64 **)method + 7);
    if ( v3 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v3 = *((__int64 **)method + 7);
    }
  }
  v7 = *v3;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v7, 0);
  GameFramework_Fsm_Fsm_object___Start(
    this,
    TypeFromHandle,
    args,
    *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 208LL));
}
