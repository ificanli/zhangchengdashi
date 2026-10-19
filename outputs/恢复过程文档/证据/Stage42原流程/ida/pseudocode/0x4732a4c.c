unsigned __int8 GameFramework_Fsm_Fsm_object___HasState_object__4732a4c(void *this, const MethodInfo *method)
{
  __int64 *v2; // x8
  __int64 v5; // x21
  __int64 TypeFromHandle; // x0

  v2 = *((__int64 **)method + 7);
  if ( v2 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    v2 = *((__int64 **)method + 7);
    if ( v2 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v2 = *((__int64 **)method + 7);
    }
  }
  v5 = *v2;
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  TypeFromHandle = System_Type__GetTypeFromHandle(v5, 0);
  return GameFramework_Fsm_Fsm_object___HasState(
           this,
           TypeFromHandle,
           *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 240LL));
}
