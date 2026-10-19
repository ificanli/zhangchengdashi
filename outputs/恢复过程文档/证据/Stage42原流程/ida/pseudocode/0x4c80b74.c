void *GameFramework_Fsm_FsmManager__GetFsm_object__4c80b74(void *this, void *name, const MethodInfo *method)
{
  _QWORD *v3; // x8
  __int64 v7; // x21
  __int64 FullName_object; // x0
  __int64 v9; // x20
  __int64 v10; // x19
  void *result; // x0
  __int64 v12; // [xsp+8h] [xbp-28h] BYREF

  v3 = *((_QWORD **)method + 7);
  if ( v3 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4F0);
    v3 = *((_QWORD **)method + 7);
    if ( v3 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v3 = *((_QWORD **)method + 7);
    }
  }
  v12 = 0;
  v7 = *((_QWORD *)this + 4);
  FullName_object = GameFramework_Utility_Text__GetFullName_object_(name, *v3);
  if ( v7 == 0 )
    il2cpp_codegen_raise_null_reference_exception();
  if ( (System_Collections_Generic_Dictionary_object__object___TryGetValue(v7, FullName_object, &v12, qword_8CFE4F0) & 1) != 0 )
  {
    v9 = v12;
    v10 = *(_QWORD *)(*((_QWORD *)method + 7) + 8LL);
    if ( (*(_BYTE *)(v10 + 309) & 1) == 0 )
      v10 = ((__int64 (__fastcall *)(__int64))unk_3C503A0)(v10);
    if ( v9 != 0 )
    {
      result = (void *)((__int64 (__fastcall *)(__int64, __int64))unk_3C3D3B4)(v9, v10);
      if ( result != nullptr )
        return result;
      ((void (__fastcall *)(__int64, __int64))unk_3C3D868)(v9, v10);
    }
  }
  return nullptr;
}
