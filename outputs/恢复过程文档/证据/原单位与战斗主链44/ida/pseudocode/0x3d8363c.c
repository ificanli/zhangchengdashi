void __fastcall GameModule_RoleBehaviour__OnKillTalentTrigger(__int64 a1)
{
  __int64 v2; // x20
  __int64 v3; // x0
  unsigned int v4; // w21
  __int64 Item; // x0
  __int64 v6; // x20
  __int64 v7; // x0
  unsigned int v8; // w21
  __int64 v9; // x0

  if ( (byte_8FFD463 & 1) == 0 )
  {
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8CE7B28);
    il2cpp_codegen_initialize_runtime_metadata(&qword_8D0EBD8);
    il2cpp_codegen_initialize_runtime_metadata((void **)&qword_8D0EBE0);
    byte_8FFD463 = 1;
  }
  if ( *(_QWORD *)(a1 + 360) != 0 )
  {
    v2 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B28);
    GameModule_GameEventArgs___ctor(v2, a1, 0, 0, 0, 0, 0, 0.0, 0.0);
    v3 = *(_QWORD *)(a1 + 360);
    if ( v3 != 0 )
    {
      v4 = 0;
      while ( (signed int)v4 < *(_DWORD *)(v3 + 24) )
      {
        Item = System_Collections_Generic_List_object___get_Item(v3, v4, qword_8D0EBE0);
        if ( Item != 0 )
        {
          (*(void (__fastcall **)(__int64, __int64, __int64, _QWORD))(*(_QWORD *)Item + 392LL))(
            Item,
            2,
            v2,
            *(_QWORD *)(*(_QWORD *)Item + 400LL));
          v3 = *(_QWORD *)(a1 + 360);
          ++v4;
          if ( v3 != 0 )
            continue;
        }
        goto LABEL_16;
      }
      return;
    }
LABEL_16:
    il2cpp_codegen_raise_null_reference_exception();
  }
  if ( *(_QWORD *)(a1 + 352) == 0 )
    return;
  v6 = ((__int64 (__fastcall *)(__int64))unk_3C3D4C4)(qword_8CE7B28);
  GameModule_GameEventArgs___ctor(v6, a1, 0, 0, 0, 0, 0, 0.0, 0.0);
  v7 = *(_QWORD *)(a1 + 352);
  if ( v7 == 0 )
    goto LABEL_16;
  v8 = 0;
  while ( (signed int)v8 < *(_DWORD *)(v7 + 24) )
  {
    v9 = System_Collections_Generic_List_object___get_Item(v7, v8, qword_8D0EBE0);
    if ( v9 != 0 )
    {
      (*(void (__fastcall **)(__int64, __int64, __int64, _QWORD))(*(_QWORD *)v9 + 392LL))(
        v9,
        2,
        v6,
        *(_QWORD *)(*(_QWORD *)v9 + 400LL));
      v7 = *(_QWORD *)(a1 + 352);
      ++v8;
      if ( v7 != 0 )
        continue;
    }
    goto LABEL_16;
  }
}
