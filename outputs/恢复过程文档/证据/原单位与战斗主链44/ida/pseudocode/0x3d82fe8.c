__int64 __fastcall GameModule_RoleBehaviour__OnHealthChangeTalentTrigger(_QWORD *a1)
{
  __int64 v2; // x21
  __int64 v3; // x22
  __int64 v4; // x20
  __int64 v5; // x0
  unsigned int v6; // w21
  __int64 Item; // x0
  __int64 v8; // x21
  __int64 v9; // x22
  __int64 v10; // x20
  __int64 v11; // x0
  unsigned int v12; // w21
  __int64 v13; // x0

  if ( (byte_8FFD45F & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B28);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0EBD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0EBE0);
    byte_8FFD45F = 1;
  }
  if ( a1[45] != 0 )
  {
    v2 = a1[46];
    v3 = GameModule_RoleBehaviour__GetNearOneMTeamMate(a1);
    v4 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B28);
    GameModule_GameEventArgs___ctor(v4, a1, v2, v3, 1, 0, 0, 0.0, 0.0);
    v5 = a1[45];
    if ( v5 != 0 )
    {
      v6 = 0;
      while ( (signed int)v6 < *(_DWORD *)(v5 + 24) )
      {
        Item = System_Collections_Generic_List_object___get_Item(v5, v6, qword_8D0EBE0);
        if ( Item != 0 )
        {
          (*(void (__fastcall **)(__int64, __int64, __int64, _QWORD))(*(_QWORD *)Item + 392LL))(
            Item,
            4,
            v4,
            *(_QWORD *)(*(_QWORD *)Item + 400LL));
          v5 = a1[45];
          ++v6;
          if ( v5 != 0 )
            continue;
        }
        goto LABEL_16;
      }
      return (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*a1 + 840LL))(a1, *(_QWORD *)(*a1 + 848LL));
    }
LABEL_16:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( a1[44] == 0 )
    return (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*a1 + 840LL))(a1, *(_QWORD *)(*a1 + 848LL));
  v8 = a1[46];
  v9 = GameModule_RoleBehaviour__GetNearOneMTeamMate(a1);
  v10 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B28);
  GameModule_GameEventArgs___ctor(v10, a1, v8, v9, 1, 0, 0, 0.0, 0.0);
  v11 = a1[44];
  if ( v11 == 0 )
    goto LABEL_16;
  v12 = 0;
  while ( (signed int)v12 < *(_DWORD *)(v11 + 24) )
  {
    v13 = System_Collections_Generic_List_object___get_Item(v11, v12, qword_8D0EBE0);
    if ( v13 != 0 )
    {
      (*(void (__fastcall **)(__int64, __int64, __int64, _QWORD))(*(_QWORD *)v13 + 392LL))(
        v13,
        4,
        v10,
        *(_QWORD *)(*(_QWORD *)v13 + 400LL));
      v11 = a1[44];
      ++v12;
      if ( v11 != 0 )
        continue;
    }
    goto LABEL_16;
  }
  return (*(__int64 (__fastcall **)(_QWORD *, _QWORD))(*a1 + 840LL))(a1, *(_QWORD *)(*a1 + 848LL));
}
