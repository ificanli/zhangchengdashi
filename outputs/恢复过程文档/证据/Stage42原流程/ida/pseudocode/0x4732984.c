void *GameFramework_Fsm_Fsm_object___GetState_object__4732984(void *this, const MethodInfo *method)
{
  __int64 *v2; // x8
  __int64 v5; // x21
  __int64 TypeFromHandle; // x0
  __int64 State; // x20
  __int64 v8; // x19
  void *result; // x0

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
  State = GameFramework_Fsm_Fsm_object___GetState(
            this,
            TypeFromHandle,
            *(_QWORD *)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 216LL));
  v8 = *(_QWORD *)(*((_QWORD *)method + 7) + 8LL);
  if ( (*(_BYTE *)(v8 + 309) & 1) == 0 )
    v8 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v8);
  if ( State != 0 )
  {
    result = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(State, v8);
    if ( result != nullptr )
      return result;
    ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(State, v8);
  }
  return nullptr;
}
