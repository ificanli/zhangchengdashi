void *GameFramework_Fsm_Fsm_object___GetData_object__47328f8(void *this, void *name, const MethodInfo *method)
{
  void *Data; // x20
  __int64 v7; // x19
  void *result; // x0

  if ( *((_QWORD *)method + 7) == 0 )
    ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
  Data = GameFramework_Fsm_Fsm_object___GetData(
           this,
           name,
           *(const MethodInfo **)(*(_QWORD *)(*((_QWORD *)method + 4) + 192LL) + 272LL));
  v7 = **((_QWORD **)method + 7);
  if ( (*(_BYTE *)(v7 + 309) & 1) == 0 )
    v7 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v7);
  if ( Data != nullptr )
  {
    result = (void *)((__int64 (__fastcall *)(void *, __int64))unk_3C3D3B4)(Data, v7);
    if ( result != nullptr )
      return result;
    ((void (__fastcall *)(void *, __int64))unk_3C3D868)(Data, v7);
  }
  return nullptr;
}
