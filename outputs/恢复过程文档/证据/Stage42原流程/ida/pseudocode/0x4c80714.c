void *GameFramework_Fsm_FsmManager__CreateFsm_object__4c80714(
        void *this,
        void *name,
        void *owner,
        void *states,
        const MethodInfo *method)
{
  const MethodInfo **v5; // x8
  unsigned __int8 HasFsm_object; // w0
  __int64 v12; // x8
  __int64 v13; // x0
  _QWORD *v14; // x22
  __int64 FullName_object; // x0
  __int64 v16; // x1
  __int64 v17; // x0
  __int64 v18; // x0
  __int64 v19; // x8
  _QWORD *v20; // x9
  __int64 v21; // x10
  __int64 v23; // x20
  __int64 v24; // x0
  __int64 v25; // x20
  __int64 v26; // x0
  __int64 v27; // x21

  v5 = *((const MethodInfo ***)method + 7);
  if ( v5 == nullptr )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CFE4C8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&off_8D0A818);
    v5 = *((const MethodInfo ***)method + 7);
    if ( v5 == nullptr )
    {
      ((void (__fastcall *)(const MethodInfo *))unk_3C503FC)(method);
      v5 = *((const MethodInfo ***)method + 7);
    }
  }
  HasFsm_object = GameFramework_Fsm_FsmManager__HasFsm_object_(this, name, *v5);
  v12 = *((_QWORD *)method + 7);
  if ( (HasFsm_object & 1) != 0 )
  {
    v23 = ((__int64 (__fastcall *)(void *, _QWORD))unk_35FB8E0)(name, *(_QWORD *)(v12 + 8));
    v24 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8D55F98);
    v25 = System_String__Format(v24, v23, 0);
    v26 = ((__int64 (__fastcall *)(void *))unk_3C3D294)(&unk_8CE7B50);
    v27 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v26);
    GameFramework_GameFrameworkException___ctor(v27, v25, 0);
    ((void (__fastcall *)(__int64, const MethodInfo *))unk_3C3D3A0)(v27, method);
    JUMPOUT(0x4C808C0);
  }
  v13 = *(_QWORD *)(v12 + 32);
  if ( (*(_BYTE *)(v13 + 309) & 1) == 0 )
    v13 = ((__int64 (*)(void))unk_3C503A0)();
  v14 = (_QWORD *)((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(v13);
  GameFramework_Fsm_Fsm_object____ctor(v14, name, owner, states, *(const MethodInfo **)(*((_QWORD *)method + 7) + 40LL));
  FullName_object = GameFramework_Utility_Text__GetFullName_object_(name, *(_QWORD *)(*((_QWORD *)method + 7) + 8LL));
  if ( v14 != nullptr )
  {
    v14[3] = FullName_object;
    v16 = FullName_object;
    v17 = *((_QWORD *)this + 4);
    if ( v17 != 0 )
    {
      System_Collections_Generic_Dictionary_object__object___Add(v17, v16, v14, qword_8CFE4C8);
      v18 = *((_QWORD *)this + 5);
      if ( v18 != 0 )
      {
        v19 = *(_QWORD *)(v18 + 16);
        v20 = off_8D0A818;
        ++*(_DWORD *)(v18 + 28);
        if ( v19 != 0 )
        {
          v21 = *(int *)(v18 + 24);
          if ( (unsigned int)v21 >= *(_DWORD *)(v19 + 24) )
          {
            System_Collections_Generic_List_object___AddWithResize(
              v18,
              v14,
              *(_QWORD *)(*(_QWORD *)(v20[4] + 192LL) + 112LL));
          }
          else
          {
            *(_DWORD *)(v18 + 24) = v21 + 1;
            *(_QWORD *)(v19 + 8 * v21 + 32) = v14;
          }
          return v14;
        }
      }
    }
  }
  il2cpp_codegen_raise_null_reference_exception();
}
