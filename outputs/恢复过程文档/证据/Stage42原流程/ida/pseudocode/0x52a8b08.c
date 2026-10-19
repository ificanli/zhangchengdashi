void *GameFramework_Fsm_Fsm_object___get_OwnerType_52a8b08(void *this, const MethodInfo *method)
{
  __int64 v3; // x19

  if ( (byte_9002565 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8CEEA50);
    byte_9002565 = 1;
  }
  v3 = *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 88LL);
  if ( *((_DWORD *)off_8CEEA50 + 56) == 0 )
    il2cpp_codegen_runtime_class_init(off_8CEEA50);
  return (void *)System_Type__GetTypeFromHandle(v3, 0);
}
